using System.Collections.Generic;
using System.Linq;

namespace ModellingSystem
{
    public class RequestQueue
    {
        public int ID;
        public string Type;
        public string Name;
        public int Size;
        public int ReqInQ;
        public int MaxLengh = 0;
        public List<RequestForServ> Queue;
        public double LastChangeTime;
        public RequestQueue(int id, string type, string name, int s)
        {
            ID = id;
            Type = type;
            Name = name;
            Size = s;
            ReqInQ = 0;
            MaxLengh = 0;
            Queue = new List<RequestForServ>();
        }

        public int GetElemCount()
        {
            return (Queue.Count());
        }

        public bool IsEmpty()
        {
            if (Queue.Count() == 0) return true;
            else return false;
        }

        public void Push(RequestForServ NewApp)
        {
            if (Size == -1 || ReqInQ < Size)
            {
                Statistic.STL[ID] += (mainForm.TS - LastChangeTime) * ReqInQ;
                LastChangeTime = mainForm.TS;

                NewApp.WasInQueue = true;
                NewApp.WaitTime = mainForm.TS;
                Statistic.CountQueueApps[ID]++;
                ReqInQ++;
                if (MaxLengh > ReqInQ)
                    MaxLengh = ReqInQ;
                Queue.Add(NewApp);
            }
            else
            {
                Statistic.PullApps[ID]++;
                mainForm.Log.Add("Время: " + mainForm.TS.ToString() + "; Исключение: очередь переполнена, заявка " + NewApp.ID + " вытолкнута с обслуживания");
            }
        }

        public RequestForServ Pop(int ChannelNeeds, int Dev)
        {
            bool run = true;
            RequestForServ res = null;
            if (ReqInQ > 0)
            {
                int n;
                switch (Type)
                {
                    case "FIFO":
                        n = -1;
                        run = true;
                        while (run && n < ReqInQ)
                        {
                            n++;
                            if (n < ReqInQ)
                                run = (Queue[n].ChannelNeeds[Dev] > ChannelNeeds);
                        }
                        if (n == ReqInQ)
                        {
                            res = null;
                        }
                        else
                        {
                            res = Queue[n];
                            Queue.RemoveAt(n);
                        }
                        break;
                    case "LIFO":
                        n = Queue.Count;

                        while (run && n >= 0)
                        {
                            n--;
                            if (n >= 0)
                                run = Queue[n].ChannelNeeds[ID] > ChannelNeeds;
                        }
                        if (n == -1)
                        {
                            res = null;
                        }
                        else
                        {
                            res = Queue[n];
                            Queue.RemoveAt(n);
                        }
                        break;
                    case "PRIORITET":
                        n = 0;
                        int maxpr = Queue[0].Priority;
                        for (int i = 1; i < Queue.Count; i++)
                        {
                            if (Queue[i].Priority > maxpr)
                            {
                                maxpr = Queue[i].Priority;
                                n = i;
                            }
                        }
                        res = Queue[n];
                        Queue.RemoveAt(n);
                        break;

                }
                Statistic.STL[ID] += (mainForm.TS - LastChangeTime) * ReqInQ;
                LastChangeTime = mainForm.TS;
                Statistic.QueuePassedApps[ID]++;
                ReqInQ--;
            }
            return res;
        }
    }
}
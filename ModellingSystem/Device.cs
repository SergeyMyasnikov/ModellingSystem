using System.Collections.Generic;
using System.Linq;

namespace ModellingSystem
{
    public class Device
    {
        public int ID;
        public RequestQueue Q;
        public RandomGenerator Dist;
        public int Channels;
        public int FreeChannels;
        public int ProcessingNow;
        public bool Busy;
        public double ChangeTime;
        private double LastTimeBusyChanChanged;
        List<RequestForServ> Active_Apps;

        public Device(int id, RequestQueue q, RandomGenerator g, int c)
        {
            ID = id;
            Q = q;
            Dist = g;
            Channels = c;
            FreeChannels = c;
            ProcessingNow = 0;
            Active_Apps = new List<RequestForServ>();
        }

        public void AddReq(RequestForServ NewApp)
        {
            Statistic.GeneralQueryValue[ID] += NewApp.ChannelNeeds[ID];
            Statistic.QueryCount[ID]++;
            if (Channels < NewApp.ChannelNeeds[ID])
            {
                Statistic.PullApps[ID]++;
                mainForm.Log.Add("Время: " + mainForm.TS.ToString() + "; Исключение: rоличество запрашиваемых каналов заявкой " + NewApp.ID + " превышает количество доступных");

            }
            else
            {
                if (FreeChannels < NewApp.ChannelNeeds[ID])//отправляем в очередь устройства
                {
                    Q.Push(NewApp);
                    mainForm.Log.Add("Время: " + mainForm.TS.ToString() + "; Событие: Заявка: " + NewApp.ID + " встала в очередь устройства: " + ID.ToString());
                }
                else// отправляем заявыку на обслуживание
                {
                    if (!NewApp.WasInQueue)
                    {

                        Statistic.NotWaitApps[ID]++;
                    }
                    else
                    {
                        Statistic.HT[ID] += mainForm.TS - NewApp.WaitTime;
                        Statistic.SW2[ID] += (mainForm.TS - NewApp.WaitTime) * (mainForm.TS - NewApp.WaitTime);
                    }
                    if (Busy)
                    {
                        Statistic.BusyTime[ID] += mainForm.TS - ChangeTime;
                    }
                    else
                    {
                        Busy = true;
                    }
                    ChangeTime = mainForm.TS;
                    FreeChannels -= NewApp.ChannelNeeds[ID];

                    NewApp.ArrivalTime = mainForm.TS;
                    Statistic.BusyChanCount[ID] += (Channels - FreeChannels) * (mainForm.TS - LastTimeBusyChanChanged);
                    LastTimeBusyChanChanged = mainForm.TS;
                    NewApp.EndTime = mainForm.TS + Dist.nextDouble();//время конца обработки заявки
                    EventList.AddEvent(NewApp.EndTime, ID, NewApp);//снова добавили в список событий
                    Active_Apps.Add(NewApp);
                    mainForm.Log.Add("Время: " + mainForm.TS.ToString() + "; Событие: Заявка: " + NewApp.ID + " встала на обслуживание на устройстве: " + ID.ToString());
                }
            }
        }

        public void LeaveApp(RequestForServ DelApp)
        {
            //Сбор статистики
            Statistic.BT_Common += mainForm.TS - DelApp.ArrivalTime;
            Statistic.BT[ID] += mainForm.TS - DelApp.ArrivalTime;//количество выполненных заявок
            Statistic.TC[ID]++;//Суммарное время обслуживания
            if (ID == mainForm.DeviceList.Count)
            {
                Statistic.TC_Common++;
            }
            Active_Apps.Remove(DelApp);
            FreeChannels += DelApp.ChannelNeeds[ID];
            if (Active_Apps.Count == 0)
            {
                Busy = false;
                ChangeTime = mainForm.TS;
            }
            mainForm.Log.Add("Время: " + DelApp.EndTime + "; Событие: Заявка: " + DelApp.ID.ToString() + " закончила обслуживание на устройстве: " + ID.ToString());
            RequestForServ appl = Q.Pop(FreeChannels, ID);//получение заявки из очереди
            if (appl != null)
            {
                mainForm.Log.Add("Время: " + mainForm.TS.ToString() + "; Событие: Заявка: " + appl.ID.ToString() + " вышла из очереди устройства: " + ID.ToString());
                AddReq(appl);
            }
        }


    }
}

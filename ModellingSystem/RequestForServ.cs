namespace ModellingSystem
{
    public class RequestForServ
    {
        public int ID;
        public int[] ChannelNeeds = new int[100];
        public int Priority;
        public bool WasInQueue = false;
        public double WaitTime;
        public double ArrivalTime;//время прибытия
        public double EndTime;//время завершения обслуживания

        public RequestForServ(int n)
        {
            ID = n;
            foreach (Device item in mainForm.DeviceList)
            {
                ChannelNeeds[item.ID] = 1;
            }
            Priority = 1;// 
        }
    }
}

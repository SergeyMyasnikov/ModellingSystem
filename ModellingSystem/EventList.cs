using System.Collections.Generic;

namespace ModellingSystem
{
    static class EventList
    {
        public static List<Event> Events = new List<Event>();

        public static void AddEvent(double time, RequestForServ rec)
        {
            Event e = new Event();
            e.IsNew = true;
            e.time = time;
            e.Request = rec;
            Events.Add(e);
            Events.Sort(Compare);
        }

        //Заявки сортируются по времени
        private static int Compare(Event x, Event y)
        {
            if (x.time == y.time)
                return 0;
            else
                if (x.time > y.time)
                return 1;
            else return -1;
        }

        public static void AddEvent(double time, int PhNum, RequestForServ Appl)
        {
            Event e = new Event();
            e.IsNew = false;
            e.time = time;
            e.TekDevice = PhNum;
            e.Request = Appl;
            Events.Add(e);
            Events.Sort(Compare);
        }

        public static Event GetClosest()
        {
            Event e = Events[0];
            Events.RemoveAt(0);
            return e;
        }
    }
}

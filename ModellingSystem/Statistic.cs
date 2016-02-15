namespace ModellingSystem
{
    static class Statistic
    {
        /// Общее число выполненных запросов на устройстве
        public static int TC_Common = 0;
        /// Суммарное время обслуживания на устройстве
        public static double BT_Common = 0;
        /// Общее число выполненных запросов
        public static int[] TC = new int[100];
        /// Суммарное время обслуживания
        public static double[] BT = new double[100];
        /// число отказных заявок
        public static int[] PullApps = new int[100];
        /// количество заявок поставленных в очередь
        public static int[] CountQueueApps = new int[100];
        /// количество заявок прошедших через очередь
        public static int[] QueuePassedApps = new int[100];
        /// число заявок с нулевым ожиданием
        public static int[] NotWaitApps = new int[100];
        /// суммарное время ожидания
        public static double[] HT = new double[100];
        /// суммаа квадратов времен ожидания
        public static double[] SW2 = new double[100];
        /// сумма произведений длины оч на промежутки времени в течении которых эти длины не изменялись
        public static double[] STL = new double[100];
        /// сумма произведений кол-ва занятых каналов на промежутки времени в течение которых не изменялось
        public static double[] BusyChanCount = new double[100];
        /// максимальная длина очереди
        public static int[] Max = new int[100];
        /// счетчик запросов на выделение каналов
        public static int[] QueryCount = new int[100];
        /// общая сумма величин запросов
        public static int[] GeneralQueryValue = new int[100];
        /// сумма  квадратов величин запросов
        public static int[] SQ2 = new int[100];
        /// время занятости устройства
        public static double[] BusyTime = new double[100];
    }
}
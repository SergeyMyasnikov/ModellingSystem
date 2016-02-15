using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;

namespace ModellingSystem
{
    public partial class mainForm : Form
    {
        int KolDist = 1;
        int KolQueue = 1;
        int KolSysytem = 1;
        int KolReq = 0;
        int KolObrRec = 0;
        public static List<RandomGenerator> DistList = new List<RandomGenerator>();
        public static List<RequestQueue> QueueList = new List<RequestQueue>();
        public static List<Device> DeviceList = new List<Device>();
        public static List<string> Log = new List<string>();
        RequestForServ NewRequest;
        int MaxReq = 0;
        int MaxTime = 0;
        RandomGenerator mainG;
        public static Uniform channeldist;
        public static Uniform priordist;
        public static double TS = 0;
        int A = 1;
        int B = 3;
        public bool StopGen;

        public mainForm()
        {
            InitializeComponent();
            channeldist = new Uniform(A, B);
            priordist = new Uniform(A, B);
        }

        private void btnCreateQueue_Click(object sender, EventArgs e)
        {
            string[] items = { tbQueueName.Text, cmbQueueType.Text, tbQueueSize.Text };
            ListViewItem lvi = new ListViewItem(items);
            lvQueue.Items.Add(lvi);

            string d;
            if (string.IsNullOrEmpty(tbQueueSize.Text)) d = "-1";
            else d = tbQueueSize.Text;
            RequestQueue a = new RequestQueue(KolQueue, cmbQueueType.Text, tbQueueName.Text, Convert.ToInt32(d));
            QueueList.Add(a);
            cmbDeviceQueueName.Items.Add(KolQueue);
            lvQueueStatistic.Columns.Add(tbQueueName.Text, 100);
            lbLog.Items.Add("Создана очередь, Имя = " + tbQueueName.Text + "; Тип=" + cmbQueueType.Text + "; Размер=" + d);
            KolQueue++;
        }

        private void btnCreateDevice_Click(object sender, EventArgs e)
        {
            string name = tbDeviceName.Text;
            int channelCount = Convert.ToInt32(tbDeviceChannelCount.Text);
            string[] items = { name, cmbDeviceQueueName.Text, cmbDeviceDistribution.Text, tbDeviceChannelCount.Text };
            ListViewItem lvi = new ListViewItem(items);
            lvDevice.Items.Add(lvi);

            Device a = new Device(KolSysytem, QueueList[Convert.ToInt32(cmbDeviceQueueName.Text) - 1], DistList[Convert.ToInt32(cmbDeviceQueueName.Text) - 1], Convert.ToInt32(tbDeviceChannelCount.Text));
            DeviceList.Add(a);
            lvDeviceStatistic.Columns.Add(tbDeviceName.Text, 100);
            lbLog.Items.Add("Создано устройство. Имя: " + tbDeviceName.Text + "; количество каналов = " + tbDeviceChannelCount.Text + "; очередь: " + cmbDeviceQueueName.Text + "; распределение: " + DistList[Convert.ToInt32(cmbDeviceDistribution.Text) - 1].Name);
            KolSysytem++;
        }

        private void cmbDistributionType_SelectedIndexChanged(object sender, EventArgs e)
        {
            tbA.Enabled = tbB.Enabled = tbD.Enabled = tbM.Enabled = tbModa.Enabled = false;
            switch (cmbDistributionType.Text)
            {
                case "Равномерное":
                    tbA.Enabled = true;
                    tbB.Enabled = true;
                    break;
                case "Нормальное":
                    tbM.Enabled = true;
                    tbD.Enabled = true;
                    break;
                case "Экспоненциальное":
                    tbM.Enabled = true;
                    break;
                case "Треугольное":
                    tbA.Enabled = true;
                    tbB.Enabled = true;
                    tbModa.Enabled = true;
                    break;
                default:
                    break;
            }
        }

        private void btnCreateDistribution_Click(object sender, EventArgs e)
        {
            RandomGenerator generator = null;
            ListViewItem lvi = null;
            int a, b, D, M, Moda;
            switch (cmbDistributionType.Text)
            {
                case "Равномерное":
                    a = Convert.ToInt32(tbA.Text);
                    b = Convert.ToInt32(tbB.Text);
                    generator = new Uniform(a, b);
                    string[] uniformItems = { KolDist.ToString(), cmbDistributionType.Text, tbA.Text, tbB.Text, "" };
                    lvi = new ListViewItem(uniformItems);
                    DistList.Add(generator);
                    lbLog.Items.Add("Добавлено " + generator.Name + " распределение c параметрами: a = " + tbA.Text + ", b = " + tbB.Text);
                    break;
                case "Нормальное":
                    M = Convert.ToInt32(tbM.Text);
                    D = Convert.ToInt32(tbD.Text);
                    generator = new Normal(M, D);
                    string[] normalItems = { KolDist.ToString(), cmbDistributionType.Text, tbM.Text, tbD.Text, "" };
                    lvi = new ListViewItem(normalItems);
                    DistList.Add(generator);
                    lbLog.Items.Add("Добавлено " + generator.Name + " распределение c параметрами: M = " + tbM.Text + ", D = " + tbD.Text);
                    break;
                case "Экспоненциальное":
                    M = Convert.ToInt32(tbM.Text);
                    generator = new Exponential(M);
                    string[] expItems = { KolDist.ToString(), cmbDistributionType.Text, tbM.Text, "", "" };
                    lvi = new ListViewItem(expItems);
                    DistList.Add(generator);
                    lbLog.Items.Add("Добавлено " + generator.Name + " распределение c параметрами: M = " + tbM.Text);
                    break;
                case "Треугольное":
                    a = Convert.ToInt32(tbA.Text);
                    b = Convert.ToInt32(tbB.Text);
                    Moda = Convert.ToInt32(tbModa.Text);
                    generator = new Triangle(a, b, Moda);
                    string[] triangleItems = { KolDist.ToString(), cmbDistributionType.Text, tbA.Text, tbB.Text, tbModa.Text };
                    lvi = new ListViewItem(triangleItems);
                    DistList.Add(generator);
                    lbLog.Items.Add("Добавлено " + generator.Name + " распределение c параметрами: a = " + tbA.Text + ", b = " + tbB.Text + ", moda =" + tbModa.Text);
                    break;
                default:
                    break;
            }
            lvDistribution.Items.Add(lvi);
            cmbDeviceDistribution.Items.Add(KolDist);
            cmbGeneratorDistribution.Items.Add(KolDist);
            KolDist++;
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(tbRequestNumber.Text)) MaxReq = Convert.ToInt32(tbRequestNumber.Text);
            if (!string.IsNullOrEmpty(tbWorkTime.Text)) MaxTime = Convert.ToInt32(tbWorkTime.Text);
            mainG = DistList[Convert.ToInt32(cmbGeneratorDistribution.Text) - 1];
          
            NewRequest = new RequestForServ(KolReq);
            NewRequest.ArrivalTime = mainG.nextDouble();
            EventList.AddEvent(NewRequest.ArrivalTime, NewRequest);
            bool stop = false;
            Event CurReq;

            while (!stop)
            {
                CurReq = EventList.GetClosest();
                Console.WriteLine(CurReq.Request.ID);
                TS = CurReq.time;
                if (CurReq.IsNew)
                {
                    Log.Add("Время: " + TS.ToString() + ". Поступила новая завка с номером: " + CurReq.Request.ID);
                    KolObrRec++;
                    DeviceList[0].AddReq(GenNewRequest());//получаем новую заявку и записываем ее в список
                    if (KolObrRec == MaxReq) StopGen = true;
                }
                else
                {
                    CurReq.Request.WasInQueue = false;
                    Console.WriteLine(CurReq.Request.ID);
                    Console.WriteLine(CurReq.TekDevice);
                    DeviceList[CurReq.TekDevice - 1].LeaveApp(CurReq.Request);//уходим с устройства на котором были
                    if (CurReq.TekDevice == DeviceList.Count)
                    {
                        if (chbClosedSystem.Checked)
                        {
                            DeviceList[0].AddReq(CurReq.Request);
                        }
                        else Log.Add("Заявка " + CurReq.Request.ID + " вышла из системы");
                    }
                    else
                    {
                        DeviceList[CurReq.TekDevice].AddReq(CurReq.Request);
                    }
                }
                stop = stop || (EventList.Events.Count <= 0) || (MaxTime > 0) && (MaxTime <= TS);
            }

            foreach (string s in Log)
                lbLog.Items.Add(s);
            ToStat();
        }

        private RequestForServ GenNewRequest()
        {
            RequestForServ r = NewRequest;
            if (!StopGen)
            {
                KolReq++;
                NewRequest = new RequestForServ(KolReq);
                NewRequest.ArrivalTime = mainG.nextDouble() + r.ArrivalTime;
                EventList.AddEvent(NewRequest.ArrivalTime, NewRequest);
            }
            return r;
        }

        public void ToStat()
        {
            //Статистика по устройствам
            for (int i = 1; i <= DeviceList.Count; i++)
            {
                lvDeviceStatistic.Items[0].SubItems.Add(Statistic.TC[i].ToString());//Количество обслуженных заявок
                lvDeviceStatistic.Items[1].SubItems.Add(Statistic.BT[i].ToString());//Суммарное время обслуживания
                lvDeviceStatistic.Items[2].SubItems.Add((Statistic.BT[i] / Statistic.TC[i]).ToString());//Среднее время занятости
                lvDeviceStatistic.Items[3].SubItems.Add((Statistic.BT[i] / TS).ToString());//Коэффициент загрузки системы
                lvDeviceStatistic.Items[4].SubItems.Add(Statistic.PullApps[i].ToString());//Количество вытолкнутых заявок
                lvDeviceStatistic.Items[5].SubItems.Add(Statistic.QueryCount[i].ToString());//Число запросов на выделение каналов
                lvDeviceStatistic.Items[6].SubItems.Add(Statistic.GeneralQueryValue[i].ToString());//Сумма величин запросов
                if (Statistic.QueryCount[i] != 0)
                {
                    lvDeviceStatistic.Items[7].SubItems.Add((1.0 * Statistic.GeneralQueryValue[i] / Statistic.QueryCount[i]).ToString());//Средняя величина запроса
                }
                lvDeviceStatistic.Items[8].SubItems.Add((Statistic.BusyChanCount[i] / TS).ToString());//Среднее количество занятых каналов
            }

            //Статистика по очередям
            for (int i = 1; i <= QueueList.Count; i++)
            {
                lvQueueStatistic.Items[0].SubItems.Add(Statistic.CountQueueApps[i].ToString());//Количество заявок поставленных в очередь
                lvQueueStatistic.Items[1].SubItems.Add(Statistic.QueuePassedApps[i].ToString());//Количество заявок прошедших через очередь
                lvQueueStatistic.Items[2].SubItems.Add(Statistic.NotWaitApps[i].ToString());//Количество заявок с нулевым ожиданием
                lvQueueStatistic.Items[3].SubItems.Add(Statistic.HT[i].ToString());//Суммарное время ожидания
                if (Statistic.QueuePassedApps[i] != 0) lvQueueStatistic.Items[4].SubItems.Add((Statistic.HT[i] / Statistic.QueuePassedApps[i]).ToString());//Среднее время ожидания
                else lvQueueStatistic.Items[4].SubItems.Add("0");
                if (Statistic.QueuePassedApps[i] != 0) lvQueueStatistic.Items[5].SubItems.Add((Math.Sqrt(Statistic.SW2[i] / Statistic.QueuePassedApps[i] - (Statistic.HT[i] / Statistic.QueuePassedApps[i]) * (Statistic.HT[i] / Statistic.QueuePassedApps[i]))).ToString());//Среднеквадратичное отклонение времени ожидания
                else lvQueueStatistic.Items[5].SubItems.Add("0");
                lvQueueStatistic.Items[6].SubItems.Add((Statistic.STL[i] / TS).ToString());//Средняя длина очереди
                lvQueueStatistic.Items[7].SubItems.Add(QueueList[i - 1].MaxLengh.ToString());//Максимальная длина очереди
                lvQueueStatistic.Items[8].SubItems.Add(Statistic.PullApps[i].ToString());//Количество заявок получивших отказ
            }

            //Общая статистика
            double BusyPercent = 0, AvrServiceTime = 0, WaitTime = 0;
            int QueueInApps = 0, QueueThroughApps = 0, QueueNotWaitApps = 0, refAppsCount = 0;
            for (int i = 1; i <= DeviceList.Count; i++)
            {
                BusyPercent += Statistic.BT[i] / Statistic.TC[i] / DeviceList[i - 1].Channels;
                AvrServiceTime += Statistic.BT[i] / Statistic.TC[i];
                QueueInApps += Statistic.CountQueueApps[i];
                QueueThroughApps += Statistic.QueuePassedApps[i];
                QueueNotWaitApps += Statistic.NotWaitApps[i];
                WaitTime += Statistic.HT[i];
                refAppsCount += Statistic.PullApps[i];
            }
            lvCommonStatistic.Items[0].SubItems.Add(Statistic.TC_Common.ToString());//Общее число выполненных запросов
            lvCommonStatistic.Items[1].SubItems.Add(Statistic.BT_Common.ToString());//Суммарное время обслуживания
            lvCommonStatistic.Items[2].SubItems.Add(AvrServiceTime.ToString());//Среднее время занятости
            lvCommonStatistic.Items[3].SubItems.Add(BusyPercent.ToString());//Процент использования
            lvCommonStatistic.Items[4].SubItems.Add(QueueInApps.ToString());//Количество заявок поставленных в очередь
            lvCommonStatistic.Items[5].SubItems.Add(QueueThroughApps.ToString());//Количество заявок прошедших через очередь
            lvCommonStatistic.Items[6].SubItems.Add(QueueNotWaitApps.ToString());//Количество заявок с нулевым ожиданием
            lvCommonStatistic.Items[7].SubItems.Add(WaitTime.ToString());//Суммарное время ожидания
            lvCommonStatistic.Items[8].SubItems.Add((WaitTime / TS).ToString());//Среднее время ожидания
            lvCommonStatistic.Items[9].SubItems.Add(refAppsCount.ToString());//Количество вытолкнутых заявок
        }
    }
}

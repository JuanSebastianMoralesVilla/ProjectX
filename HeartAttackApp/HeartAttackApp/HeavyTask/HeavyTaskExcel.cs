using HeartAttackApp.Ui;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace HeartAttackApp.HeavyTask
{
    public class HeavyTaskExcel
    {
        private readonly SynchronizationContext SyncContext;

        public event EventHandler<HeavyTaskResponseExcel> Callback;

        private Main main;
        public HeavyTaskExcel(Main main)
        {
            this.main = main;
            SyncContext = AsyncOperationManager.SynchronizationContext;
        }

        public void Start()
        {
            Thread thread = new Thread(Run);
            thread.IsBackground = true;
            thread.Start();
        }
        private void Run()
        {
            while (!main.stop)
            {
                SyncContext.Post(e => triggerCallback1(
                    new HeavyTaskResponseExcel()
                ), null);

                Thread.Sleep(10);
            }
            main.stop = false;
        }

        private void triggerCallback1(HeavyTaskResponseExcel response)
        {
            Callback?.Invoke(this, response);
        }
    }
}

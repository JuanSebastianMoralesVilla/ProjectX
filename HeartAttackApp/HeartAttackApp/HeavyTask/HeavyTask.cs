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
    public class HeavyTask
    {

        private readonly SynchronizationContext SyncContext;

        public event EventHandler<HeavyTaskResponse> Callback;

        private Main main;
        public HeavyTask(Main main)
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
                    new HeavyTaskResponse()
                ), null);
                Thread.Sleep(10);
            }
            
        }


        private void triggerCallback1(HeavyTaskResponse response)
        {
            Callback?.Invoke(this, response);
        }

    }
}

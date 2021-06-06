using HeartAttackApp.Ui;
using System;
using System.ComponentModel;
using System.Threading;

namespace HeartAttackApp.HeavyTask
{
    public class HeavyTasks
    {

        private readonly SynchronizationContext SyncContext;

        public event EventHandler<HeavyTaskResponse> CallbackTraining;
        public event EventHandler<HeavyTaskResponse> CallbackExcel;
        public event EventHandler<HeavyTaskResponse> CallbackExperiment;

        private Main main;
        private int value;
        public HeavyTasks(Main main)
        {

            this.main = main;
            SyncContext = AsyncOperationManager.SynchronizationContext;
        }

        public void Start(int value)
        {
            main.stop = false;
            this.value = value;
            Thread thread = new Thread(Run);
            thread.IsBackground = true;
            thread.Start();
        }
        private void Run()
        {
            while (!main.stop)
            {
                if (value == 0)
                {
                    SyncContext.Post(e => triggerCallbackTraining(
                    new HeavyTaskResponse()), null);
                }
                else if (value == 1)
                {
                    SyncContext.Post(e => triggerCallbackExcel(
                    new HeavyTaskResponse()), null);
                }
                else
                {
                    SyncContext.Post(e => triggerCallbackExperiment(
                    new HeavyTaskResponse()), null);
                }

                Thread.Sleep(100);
            }
            main.stop = false;
        }
        private void triggerCallbackExcel(HeavyTaskResponse response)
        {
            CallbackExcel?.Invoke(this, response);
        }

        private void triggerCallbackTraining(HeavyTaskResponse response)
        {
            CallbackTraining?.Invoke(this, response);
        }

        private void triggerCallbackExperiment(HeavyTaskResponse response)
        {
            CallbackExperiment?.Invoke(this, response);
        }

    }
}

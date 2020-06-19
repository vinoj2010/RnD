using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ObfuscationCheckerLib
{
    public class ObfuscationValidator: Component
    {
        private delegate void WorkerEventHandler(string scanPath, AsyncOperation asyncOp);
            
        private HybridDictionary userStateToLifetime = new HybridDictionary();

        public event ProgressChangedEventHandler ProgressChanged;
        public event DoValidationCompletedEventHandler DoValidationCompleted;

        SendOrPostCallback OnProgressReportDelegate;
        SendOrPostCallback OnOperationCompleteDelegate;

        //string _scanPath = string.Empty;

        public ObfuscationValidator()
        {
            OnProgressReportDelegate = new SendOrPostCallback(ReportProgress);

        }

        private void ReportProgress(object state)
        {
            ProgressChangedEventArgs e = new ProgressChangedEventArgs(0, state);
            ProgressChanged(this, e);
        }

        public void DoValidatationAsync(string scanPath, object taskId)
        {
            // Create an AsyncOperation for taskId
            AsyncOperation asyncOp = AsyncOperationManager.CreateOperation(taskId);

            //Initialzie the worker delegate
            WorkerEventHandler workerDelegate = new WorkerEventHandler(ValidateWorker);
            //start the asynchronous operation
            workerDelegate.BeginInvoke(scanPath, asyncOp, null, null);
        }

        private void ValidateWorker(string scanPath, AsyncOperation asyncOp)
        {
            //Scan all dll files from scanPath
            if (!string.IsNullOrWhiteSpace(scanPath) && Directory.Exists(scanPath))
            {
                IList<FileInfo> filesToValidate = GetFilesToValidate(scanPath);

                //Iterate through each dll file and check if it is obfuscated
                foreach (var fileInfo in filesToValidate)
                {

                }
                //send progress info during the checks

                //On completing validation for all files, invoke the DoValidationCompleted event
            }
        }

        private IList<FileInfo> GetFilesToValidate(string scanPath)
        {
            IList<FileInfo> fileInfoList = new List<FileInfo>();

            DirectoryInfo directoryInfo = new DirectoryInfo(scanPath);
            fileInfoList = directoryInfo.GetFiles("*.dll", SearchOption.AllDirectories);

            return fileInfoList;
        }

        public void DoValidatationAsync(object userState)
        {

        }
    }

    public delegate void DoValidationCompletedEventHandler(object sender, DoValidationCompletedEventArgs e);

    public class DoValidationCompletedEventArgs : AsyncCompletedEventArgs
    {
        private readonly IList<string> _observations = new List<string>();
        public IList<string> Observations
        {
            get
            {
                // Raise an exception if the operation failed or
                // was canceled
                RaiseExceptionIfNecessary();

                // If the operation was successful, return the
                // property value
                return _observations;
            }
        }

        public DoValidationCompletedEventArgs(IList<String> observations, Exception e, bool cancelled, object userState)
            :base(e, cancelled, userState)
        {
            _observations = observations;
        }
    }
}

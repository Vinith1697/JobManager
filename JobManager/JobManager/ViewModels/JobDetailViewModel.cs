using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace JobManager.ViewModels
{
    [QueryProperty(nameof(jobId),nameof(JobId))]
    public class JobDetailViewModel : JobManagerBase
    {
        private int jobId;
        public int JobId
        {
            get { 
                    return jobId; 
                }

            set { 
                    jobId = value;
                }
        }

    }
}

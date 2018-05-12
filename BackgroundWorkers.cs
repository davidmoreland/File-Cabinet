using System;
using nsDataTracker;


namespace BackgroundWorker
{

    public class bgwReadMedia
    {
        public void Initialize_bgwReadMedia()
        {

            bgwReadMedia.DoWork +=
                new DoWorkEventHandler(bgwReadMedia_DoWork);
            bgwReadMedia.RunWorkerCompleted +=
            new RunWorkerCompletedEventHandler(
        bgwReadMedia_RunWorkerCompleted);
            bgwReadMedia.ProgressChanged +=
                new ProgressChangedEventHandler(
            bgwReadMedia_ProgressChanged);
        }

    }
}

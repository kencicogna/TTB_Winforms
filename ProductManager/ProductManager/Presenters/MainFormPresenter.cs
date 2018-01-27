using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProductManager.Views;
using ProductManager.Events;

namespace ProductManager.Presenters
{
    class MainFormPresenter
    {
        private MainForm mainForm;

        public MainFormPresenter(MainForm mf)
        {
            mainForm = mf;
            EventAggregator.Instance.Subscribe<SpeechBubble>(OnSpeechBubbleChange_UpdateStatus);
        }

        private void OnSpeechBubbleChange_UpdateStatus(SpeechBubble statusMessage)
        {
            mainForm.SetStatus(statusMessage.Text);
        }

    }
}

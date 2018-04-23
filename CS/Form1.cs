using System;
using System.Windows.Forms;

namespace SchedulerNonStandardTimeInterval {
    public partial class Form1 : Form {
        public TimeSpan StartTimeOffset { get { return TimeSpan.FromHours(rangeTrackBarControl1.Properties.Maximum - rangeTrackBarControl1.Value.Maximum); } }
        public TimeSpan EndTimeOffset { get { return TimeSpan.FromHours(rangeTrackBarControl1.Properties.Maximum - rangeTrackBarControl1.Value.Minimum); } }

        public Form1() {
            InitializeComponent();
            UpdateVisibleTime();
        }

        private void rangeTrackBarControl1_EditValueChanged(object sender, EventArgs e) {
            UpdateVisibleTime();
        }

        private void UpdateVisibleTime() {
            schedulerControl1.DayView.VisibleTime = new DevExpress.XtraScheduler.TimeOfDayInterval(StartTimeOffset, EndTimeOffset);
            schedulerControl1.WorkWeekView.VisibleTime = new DevExpress.XtraScheduler.TimeOfDayInterval(StartTimeOffset, EndTimeOffset);
        }

        private void rangeTrackBarControl1_BeforeShowValueToolTip(object sender, DevExpress.XtraEditors.TrackBarValueToolTipEventArgs e) {
            e.ShowArgs.ToolTip = string.Format("Interval = [{0}; {1}]", StartTimeOffset, EndTimeOffset);
        }
    }
}
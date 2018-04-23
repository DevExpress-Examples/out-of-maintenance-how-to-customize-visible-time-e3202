namespace SchedulerNonStandardTimeInterval
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            DevExpress.XtraScheduler.TimeRuler timeRuler1 = new DevExpress.XtraScheduler.TimeRuler();
            DevExpress.XtraScheduler.TimeRuler timeRuler2 = new DevExpress.XtraScheduler.TimeRuler();
            this.schedulerControl1 = new DevExpress.XtraScheduler.SchedulerControl();
            this.schedulerStorage1 = new DevExpress.XtraScheduler.SchedulerStorage(this.components);
            this.rangeTrackBarControl1 = new DevExpress.XtraEditors.RangeTrackBarControl();
            ((System.ComponentModel.ISupportInitialize)(this.schedulerControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schedulerStorage1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rangeTrackBarControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rangeTrackBarControl1.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // schedulerControl1
            // 
            this.schedulerControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.schedulerControl1.Location = new System.Drawing.Point(84, 15);
            this.schedulerControl1.Margin = new System.Windows.Forms.Padding(4);
            this.schedulerControl1.Name = "schedulerControl1";
            this.schedulerControl1.Size = new System.Drawing.Size(751, 418);
            this.schedulerControl1.Start = new System.DateTime(2008, 9, 4, 0, 0, 0, 0);
            this.schedulerControl1.Storage = this.schedulerStorage1;
            this.schedulerControl1.TabIndex = 0;
            this.schedulerControl1.Text = "schedulerControl1";
            this.schedulerControl1.Views.DayView.TimeRulers.Add(timeRuler1);
            this.schedulerControl1.Views.MonthView.Enabled = false;
            this.schedulerControl1.Views.TimelineView.Enabled = false;
            this.schedulerControl1.Views.WeekView.Enabled = false;
            this.schedulerControl1.Views.WorkWeekView.TimeRulers.Add(timeRuler2);
            // 
            // rangeTrackBarControl1
            // 
            this.rangeTrackBarControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            this.rangeTrackBarControl1.EditValue = new DevExpress.XtraEditors.Repository.TrackBarRange(18, 42);
            this.rangeTrackBarControl1.Location = new System.Drawing.Point(16, 15);
            this.rangeTrackBarControl1.Margin = new System.Windows.Forms.Padding(4);
            this.rangeTrackBarControl1.Name = "rangeTrackBarControl1";
            this.rangeTrackBarControl1.Properties.Maximum = 48;
            this.rangeTrackBarControl1.Properties.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.rangeTrackBarControl1.Properties.ShowValueToolTip = true;
            this.rangeTrackBarControl1.Size = new System.Drawing.Size(56, 418);
            this.rangeTrackBarControl1.TabIndex = 0;
            this.rangeTrackBarControl1.Value = new DevExpress.XtraEditors.Repository.TrackBarRange(18, 42);
            this.rangeTrackBarControl1.EditValueChanged += new System.EventHandler(this.rangeTrackBarControl1_EditValueChanged);
            this.rangeTrackBarControl1.BeforeShowValueToolTip += new DevExpress.XtraEditors.TrackBarValueToolTipEventHandler(this.rangeTrackBarControl1_BeforeShowValueToolTip);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(851, 447);
            this.Controls.Add(this.rangeTrackBarControl1);
            this.Controls.Add(this.schedulerControl1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.schedulerControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schedulerStorage1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rangeTrackBarControl1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rangeTrackBarControl1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraScheduler.SchedulerControl schedulerControl1;
        private DevExpress.XtraScheduler.SchedulerStorage schedulerStorage1;
        private DevExpress.XtraEditors.RangeTrackBarControl rangeTrackBarControl1;
    }
}


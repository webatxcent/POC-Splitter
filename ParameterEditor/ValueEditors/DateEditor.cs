﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using XCENT.JobServer.Abstract;
using XCENT.Core.UI.WinForms;

namespace POC_Splitter
{
    public partial class DateEditor : DateBox, IValueEditor
    {

        public DateEditor() {
            InitializeComponent();
        }

        #region IValueEditor implementation

        public IValueEditorContainer ValueEditorContainer {
            get;
            set;
        }

        public Control Control {
            get {
                return this as Control;
            }
        }

        public string Value {
            get { return Text; }
        }

        public void Configure( ParameterDef parameterDef, string value ) {
            Text = value; 
        }

        public new int PreferredHeight {
            get {
                return PreferredSize.Height;
            }
        }

        public void SetMoveFocusHandler( ControlMoveFocusHandler controlMoveFocusHandler ) {
            //nothing to do for this control.
        }

        public bool RequiresFocusRectangle => false;

        public bool SuppressUpDownHandling => false;
        #endregion
    }
}

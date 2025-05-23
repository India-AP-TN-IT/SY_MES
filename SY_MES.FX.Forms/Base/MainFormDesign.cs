﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Resources;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SY_MES.FX.MainForm.Base
{
    [ToolboxItem(true)]
    [TypeConverter(typeof(MainFormTitlesConverter))]
    public class MainFormDesign : MainFormComponent
    {
        private const string CN_CATEGORY_APP = "_SY_MES.Appearance";
        private const string CN_CATEGORY_MOV = "_SY_MES.Movement";
        private const string CN_CATEGORY_DB = "_SY_MES.DataBase";
        private Image m_LogoImg = Properties.Resources.PB_LOGO;
        private Icon m_AppIcon;

        

        private string m_MsgTy_WARNING = "WARNING";
        private string m_MsgTy_ALARM = "NOTICE";   
        private string m_MsgTy_ERROR = "ERROR";
        private string m_MsgTy_TRACE = "TRACE";

        private string m_WorkState_WAIT = "WAIT";
        private string m_WorkState_RUNNING = "RUNNING";
        private string m_WorkState_COMPLETE_OK = "COMPLETE";
        private string m_WorkState_COMPLETE_NG = "COMPLETE";

        private string m_XMLConfigFile = @".\Config.xml";
        private string m_XMLConfigPrivateFile = @".\Config_Private.xml";
        private string m_XMLDebugModeEleName = "DEBUG_MODE";
        private string m_XMLDebugClientEleName = "DEBUG_CLIENT";
        private string m_LogicAppNameSpace = "SY_MES.Logics";

        private Common.DateFormatEnum m_TIT_DateFormat = Common.DateFormatEnum.YYYYMMDD;
        private DateTime m_CurrentTime = DateTime.Now;
        private IMainFormDesign m_Parent;
        private string m_TIT_Plant;
        private Font m_TIT_Plant_FONT;

        private string m_TIT_Line;
        private Font m_TIT_Line_FONT;

        private string m_TIT_Station;
        private Font m_TIT_Station_FONT;

        private string m_TIT_Result;
        private Font m_TIT_Result_FONT;

        private string m_TIT_WorkStandard;
        private Font m_TIT_WorkStandard_FONT;

        private string m_TIT_Exit;
        private Font m_TIT_Exit_FONT;

        private string m_TIT_Config;
        private Font m_TIT_Config_FONT;
        private bool m_AllowDuplicatedRun = false;
        private string m_DuplicatedRunMsg = "Duplicated Application";
        private string m_DuplicatedRunTitle = "Violated Run";
        private string m_Exit_Dlg_Title= "Exit of Program";
        private string m_Exit_Dlg_Contents= "Do you want to exit program?";
        private string m_Error_DB_Connection = "DB Connection Error";

        private string m_Xml_DBKind_NM = "DB_CONNECTION";
        private string m_Xml_DBSvr_NM = "DBSVR";
        private string m_Xml_DBID_NM = "DBUID";
        private string m_Xml_DBPWD_NM = "DBPWD";
        private string m_Xml_DBSID_NM = "DBSERVICE";
        private string m_Xml_DBPort_NM = "DBPORT";
        

        [Category(CN_CATEGORY_MOV)]
        public string LogicAppNameSpace
        {
            get { return m_LogicAppNameSpace; }
            set { m_LogicAppNameSpace = value; }
        }
        [Category(CN_CATEGORY_MOV)]
        public string XMLDebugModeEleName
        {
            get { return m_XMLDebugModeEleName; }
            set { m_XMLDebugModeEleName = value; }
        }
        [Category(CN_CATEGORY_MOV)]
        public string XMLDebugClientEleName
        {
            get { return m_XMLDebugClientEleName; }
            set { m_XMLDebugClientEleName = value; }
        }
        [Category(CN_CATEGORY_MOV)]
        public string XMLConfigFile
        {
            get { return m_XMLConfigFile; }
            set { m_XMLConfigFile = value; }
        }
        [Category(CN_CATEGORY_MOV)]
        public string XMLConfigPrivateFile
        {
            get { return m_XMLConfigPrivateFile; }
            set { m_XMLConfigPrivateFile = value; }
        }
        [Category(CN_CATEGORY_DB)]
        public string Error_DB_Connection
        {
            get { return m_Error_DB_Connection; }
            set { m_Error_DB_Connection = value; }
        }

       
        [System.ComponentModel.Category(CN_CATEGORY_DB)]
        public string Xml_DBKind_NM
        {
            get { return m_Xml_DBKind_NM; }
            set { m_Xml_DBKind_NM = value; }
        }
        [System.ComponentModel.Category(CN_CATEGORY_DB)]
        public string Xml_DBSvr_NM
        {
            get { return m_Xml_DBSvr_NM; }
            set { m_Xml_DBSvr_NM = value; }
        }
        [System.ComponentModel.Category(CN_CATEGORY_DB)]
        public string Xml_DBID_NM
        {
            get { return m_Xml_DBID_NM; }
            set { m_Xml_DBID_NM = value; }
        }
        [System.ComponentModel.Category(CN_CATEGORY_DB)]
        public string Xml_DBPWD_NM
        {
            get { return m_Xml_DBPWD_NM; }
            set { m_Xml_DBPWD_NM = value; }
        }
        [System.ComponentModel.Category(CN_CATEGORY_DB)]
        public string Xml_DBSID_NM
        {
            get { return m_Xml_DBSID_NM; }
            set { m_Xml_DBSID_NM = value; }
        }
        [System.ComponentModel.Category(CN_CATEGORY_DB)]
        public string Xml_DBPort_NM
        {
            get { return m_Xml_DBPort_NM; }
            set { m_Xml_DBPort_NM = value; }
        }
        [System.ComponentModel.Category(CN_CATEGORY_APP)]
        public bool AllowDuplicatedRun
        {
            get { return m_AllowDuplicatedRun; }
            set { m_AllowDuplicatedRun = value; }
        }

        [System.ComponentModel.Category(CN_CATEGORY_APP)]
        public string Exit_Dlg_Title
        {
            get { return m_Exit_Dlg_Title; }
            set { m_Exit_Dlg_Title = value; }
        }
        [System.ComponentModel.Category(CN_CATEGORY_APP)]
        public string DuplicatedRunMsg
        {
            get { return m_DuplicatedRunMsg; }
            set { m_DuplicatedRunMsg = value; }
        }
        [System.ComponentModel.Category(CN_CATEGORY_APP)]
        public string DuplicatedRunTitle
        {
            get { return m_DuplicatedRunTitle; }
            set { m_DuplicatedRunTitle = value; }
        }
        [System.ComponentModel.Category(CN_CATEGORY_APP)]
        public string Exit_Dlg_Contents
        {
            get { return m_Exit_Dlg_Contents; }
            set { m_Exit_Dlg_Contents = value; }
        }

        [System.ComponentModel.Category(CN_CATEGORY_APP)]
        public string MsgTy_WARNING
        {
            get { return m_MsgTy_WARNING; }
            set 
            { 
                m_MsgTy_WARNING = value;
                StatusMsgTitle(SY_MES.FX.MainForm.Base.Common.MsgTypeEnum.Warnning);
            }
        }
        [System.ComponentModel.Category(CN_CATEGORY_APP)]
        public string MsgTy_ALARM
        {
            get { return m_MsgTy_ALARM; }
            set 
            { 
                m_MsgTy_ALARM = value;
                StatusMsgTitle(SY_MES.FX.MainForm.Base.Common.MsgTypeEnum.Alarm);
            }
        }
        [System.ComponentModel.Category(CN_CATEGORY_APP)]
        public string MsgTy_ERROR
        {
            get { return m_MsgTy_ERROR; }
            set 
            { 
                m_MsgTy_ERROR = value;
                StatusMsgTitle(SY_MES.FX.MainForm.Base.Common.MsgTypeEnum.Error);
            }
        }
        [System.ComponentModel.Category(CN_CATEGORY_APP)]
        public string MsgTy_TRACE
        {
            get { return m_MsgTy_TRACE; }
            set 
            { 
                m_MsgTy_TRACE = value;
                StatusMsgTitle(SY_MES.FX.MainForm.Base.Common.MsgTypeEnum.Alarm);
            }
        }


        [System.ComponentModel.Category(CN_CATEGORY_APP)]
        public string WorkState_WAIT
        {
            get { return m_WorkState_WAIT; }
            set
            {
                m_WorkState_WAIT = value;
                WorkState(SY_MES.FX.MainForm.Base.Common.WorkStateEnum.Wait);
            }
        }
        [System.ComponentModel.Category(CN_CATEGORY_APP)]
        public string WorkState_RUNNING
        {
            get { return m_WorkState_RUNNING; }
            set
            {
                m_WorkState_RUNNING = value;
                WorkState(SY_MES.FX.MainForm.Base.Common.WorkStateEnum.Running);
            }
        }
        [System.ComponentModel.Category(CN_CATEGORY_APP)]
        public string WorkState_COMPLETE_OK
        {
            get { return m_WorkState_COMPLETE_OK; }
            set
            {
                m_WorkState_COMPLETE_OK = value;
                WorkState(SY_MES.FX.MainForm.Base.Common.WorkStateEnum.OK_Complete);
            }
        }
        [System.ComponentModel.Category(CN_CATEGORY_APP)]
        public string WorkState_COMPLETE_NG
        {
            get { return m_WorkState_COMPLETE_NG; }
            set
            {
                m_WorkState_COMPLETE_NG = value;
                WorkState(SY_MES.FX.MainForm.Base.Common.WorkStateEnum.NG_Complete);
            }
        }
        [Browsable(false)]
        public IMainFormDesign Parent
        {
            get 
            { 
                if(ContainerControl!= null)
                {
                    if(ContainerControl is IMainFormDesign)
                    {
                        m_Parent = (IMainFormDesign)ContainerControl;
                        return (IMainFormDesign)ContainerControl;
                    }
                }
                return null;
                 
            }
            set 
            {
                if (ContainerControl != null)
                {
                    if (ContainerControl is IMainFormDesign)
                    {
                        ((IMainFormDesign)ContainerControl).Plant_CTL.Text = m_TIT_Plant;
                        ((IMainFormDesign)ContainerControl).Plant_CTL.Font = m_TIT_Plant_FONT;
                        ((IMainFormDesign)ContainerControl).Line_CTL.Text = m_TIT_Line;
                        ((IMainFormDesign)ContainerControl).Line_CTL.Font = m_TIT_Line_FONT;
                        ((IMainFormDesign)ContainerControl).Station_CTL.Text = m_TIT_Station;
                        ((IMainFormDesign)ContainerControl).Station_CTL.Font = m_TIT_Station_FONT;
                        ((IMainFormDesign)ContainerControl).WorkStandard_CTL.Text = m_TIT_WorkStandard;
                        ((IMainFormDesign)ContainerControl).WorkStandard_CTL.Font = m_TIT_WorkStandard_FONT;
                        ((IMainFormDesign)ContainerControl).Result_CTL.Text = m_TIT_Result;
                        ((IMainFormDesign)ContainerControl).Result_CTL.Font = m_TIT_Result_FONT;
                        ((IMainFormDesign)ContainerControl).Config_CTL.Text = m_TIT_Config;
                        ((IMainFormDesign)ContainerControl).Config_CTL.Font = m_TIT_Config_FONT;
                        ((IMainFormDesign)ContainerControl).LogoImg.Image = m_LogoImg;
                    }
                }
            }
        }
        public MainFormDesign()
        {
            m_TIT_Plant = "PLANT";
            m_TIT_Plant_FONT = new Font("Microsoft Sans Serif", 18F, FontStyle.Bold);

            m_TIT_Line = "This is Production Line";
            m_TIT_Line_FONT = new Font("Microsoft Sans Serif", 20.25F, FontStyle.Bold);

            m_TIT_Station = "This is WorkStation";
            m_TIT_Station_FONT = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold);

            m_TIT_Result = "Result";
            m_TIT_Result_FONT = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);

            m_TIT_Config = "Config";
            m_TIT_Config_FONT = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold);

            m_TIT_Exit = "EXIT";
            m_TIT_Exit_FONT = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);

            m_TIT_WorkStandard = "WORK\r\nSTANDARD";
            m_TIT_WorkStandard_FONT = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold);
            m_LogoImg = Properties.Resources.PB_LOGO;
            

        }

        [System.ComponentModel.Category(CN_CATEGORY_APP)]
        public Image LogoImg
        {
            get { return m_LogoImg; }
            set 
            { 
                m_LogoImg = value;
                if (Parent != null)
                {
                    Parent.LogoImg.Image = m_LogoImg;
                }
            }
        }
        [System.ComponentModel.Category(CN_CATEGORY_APP)]
        public Icon AppIcon
        {
            get { return m_AppIcon; }
            set
            {
                m_AppIcon = value;
                if (Parent != null)
                {
                    Parent.AppIcon = m_AppIcon;
                }
            }
        }
        [System.ComponentModel.Category(CN_CATEGORY_APP)]
        public string TIT_Plant
        {
            get { return m_TIT_Plant; }
            set 
            { 
                m_TIT_Plant = value;
                if (Parent != null)
                {
                    Parent.Plant_CTL.Text = m_TIT_Plant;
                }
            }

        }
        [System.ComponentModel.Category(CN_CATEGORY_APP)]
        public Font TIT_Plant_FONT
        {
            get { return m_TIT_Plant_FONT; }
            set 
            { 
                m_TIT_Plant_FONT = value;
                if (Parent != null)
                {
                    Parent.Plant_CTL.Font = m_TIT_Plant_FONT;
                }
            }
        }
        [System.ComponentModel.Category(CN_CATEGORY_APP)]
        public string TIT_Line
        {
            get { return m_TIT_Line; }
            set 
            { 
                m_TIT_Line = value;
                if (Parent != null)
                {
                    Parent.Line_CTL.Text = m_TIT_Line;
                }
            }

        }
        [System.ComponentModel.Category(CN_CATEGORY_APP)]
        public Font TIT_Line_FONT
        {
            get { return m_TIT_Line_FONT; }
            set 
            { 
                m_TIT_Line_FONT = value;
                if (Parent != null)
                {
                    Parent.Line_CTL.Font = m_TIT_Line_FONT;
                }
            }
        }
        [System.ComponentModel.Category(CN_CATEGORY_APP)]
        public string TIT_Station
        {
            get { return m_TIT_Station; }
            set 
            { 
                m_TIT_Station = value;
                if (Parent != null)
                {
                    Parent.Station_CTL.Text = m_TIT_Station;
                }
            }

        }
        [System.ComponentModel.Category(CN_CATEGORY_APP)]
        public Font TIT_Station_FONT
        {
            get { return m_TIT_Station_FONT; }
            set 
            { 
                m_TIT_Station_FONT = value;
                if (Parent != null)
                {
                    Parent.Station_CTL.Font = m_TIT_Station_FONT;
                }
            }
        }
        [System.ComponentModel.Category(CN_CATEGORY_APP)]
        public string TIT_WorkStandard
        {
            get { return m_TIT_WorkStandard; }
            set 
            {
                m_TIT_WorkStandard = value;
                if (Parent != null)
                {
                    Parent.WorkStandard_CTL.Text = m_TIT_WorkStandard;
                }
            }

        }
        [System.ComponentModel.Category(CN_CATEGORY_APP)]
        public Font TIT_WorkStandard_FONT
        {
            get { return m_TIT_WorkStandard_FONT; }
            set
            {
                m_TIT_WorkStandard_FONT = value;
                if (Parent != null)
                {
                    Parent.WorkStandard_CTL.Font = m_TIT_WorkStandard_FONT;
                }
            }
        }
        [System.ComponentModel.Category(CN_CATEGORY_APP)]
        public string TIT_Result
        {
            get { return m_TIT_Result; }
            set
            {
                m_TIT_Result = value;
                if (Parent != null)
                {
                    Parent.Result_CTL.Text = m_TIT_Result;
                }
            }

        }
        [System.ComponentModel.Category(CN_CATEGORY_APP)]
        public Font TIT_Result_FONT
        {
            get { return m_TIT_Result_FONT; }
            set 
            {
                m_TIT_Result_FONT = value;
                if (Parent != null)
                {
                    Parent.Result_CTL.Font = m_TIT_Result_FONT;
                }
            }
        }
        [System.ComponentModel.Category(CN_CATEGORY_APP)]
        public string TIT_Exit
        {
            get { return m_TIT_Exit; }
            set
            {
                m_TIT_Exit = value;
                if (Parent != null)
                {
                    Parent.Exit_CTL.Text = m_TIT_Exit;
                }
            }

        }
        [System.ComponentModel.Category(CN_CATEGORY_APP)]
        public Font TIT_Exit_FONT
        {
            get { return m_TIT_Exit_FONT; }
            set
            {
                m_TIT_Exit_FONT = value;
                if (Parent != null)
                {
                    Parent.Exit_CTL.Font = m_TIT_Exit_FONT;
                }
            }
        }
        [System.ComponentModel.Category(CN_CATEGORY_APP)]
        public string TIT_Config
        {
            get { return m_TIT_Config; }
            set
            {
                m_TIT_Config = value;
                if (Parent != null)
                {
                    Parent.Config_CTL.Text = m_TIT_Config;
                }
            }

        }
        [System.ComponentModel.Category(CN_CATEGORY_APP)]
        public Font TIT_Config_FONT
        {
            get { return m_TIT_Config_FONT; }
            set
            {
                m_TIT_Config_FONT = value;
                if (Parent != null)
                {
                    Parent.Config_CTL.Font = m_TIT_Config_FONT;
                }
            }
        }
        [System.ComponentModel.Category(CN_CATEGORY_APP)]
        public SY_MES.FX.MainForm.Base.Common.DateFormatEnum TIT_DateFormat
        {
            get { return m_TIT_DateFormat; }
            set
            {

                m_TIT_DateFormat = value;
                SyncTIT_Date(m_CurrentTime);
            }
        }
        
        public void SyncTIT_Date(DateTime date)
        {
            m_CurrentTime = date;
            if (Parent != null)
            {
                switch (m_TIT_DateFormat)
                {
                    case Common.DateFormatEnum.YYYYMMDD:
                        Parent.Date_CTL.Text = date.ToString("yyyy-MM-dd");
                        Parent.Time_CTL.Text = date.ToString("HH:mm:ss");
                        break;
                    case Common.DateFormatEnum.DDMMYYYY:
                        Parent.Date_CTL.Text = date.ToString("dd-MM-yyyy");
                        Parent.Time_CTL.Text = date.ToString("HH:mm:ss");
                        break;
                    case Common.DateFormatEnum.MMDDYYYY:
                        Parent.Date_CTL.Text = date.ToString("MM-dd-yyyy");
                        Parent.Time_CTL.Text = date.ToString("HH:mm:ss");
                        break;
                }
            }
            
        }
        public void WorkState(Common.WorkStateEnum state)
        {
            if (m_Parent != null)
            {
                switch (state)
                {
                    case Common.WorkStateEnum.Wait:
                        Parent.WorkState.Text = this.WorkState_WAIT;
                        Parent.WorkState.BackColor = Color.Silver;
                        Parent.WorkState.ForeColor = Color.Black;
                        break;
                    case Common.WorkStateEnum.Running:
                        Parent.WorkState.Text = this.WorkState_RUNNING;
                        Parent.WorkState.BackColor = Color.Yellow;
                        Parent.WorkState.ForeColor = Color.Black;
                        break;
                    case Common.WorkStateEnum.OK_Complete:
                        Parent.WorkState.Text = this.m_WorkState_COMPLETE_OK;
                        Parent.WorkState.BackColor = Color.Lime;
                        Parent.WorkState.ForeColor = Color.Black;
                        break;
                    case Common.WorkStateEnum.NG_Complete:
                        Parent.WorkState.Text = this.m_WorkState_COMPLETE_NG;
                        Parent.WorkState.BackColor = Color.Lime;
                        Parent.WorkState.ForeColor = Color.Black;
                        break;
                }
            }
        }
        public void StatusMsgTitle(Common.MsgTypeEnum msgType)
        {
            if (m_Parent != null)
            {
                switch (msgType)
                {
                    case Common.MsgTypeEnum.Alarm:
                        Parent.MsgTitle_CTL.Text = this.MsgTy_ALARM;
                        Parent.MsgTitle_CTL.BackColor = Color.Blue;
                        Parent.MsgTitle_CTL.ForeColor = Color.White;
                        Parent.StatusMsg.ForeColor = Color.Blue;
                        break;
                    case Common.MsgTypeEnum.Error:
                        Parent.MsgTitle_CTL.Text = this.MsgTy_ERROR;
                        Parent.MsgTitle_CTL.BackColor = Color.Red;
                        Parent.MsgTitle_CTL.ForeColor = Color.White;
                        Parent.StatusMsg.ForeColor = Color.Red;
                        break;
                    case Common.MsgTypeEnum.Warnning:
                        Parent.MsgTitle_CTL.Text = this.MsgTy_WARNING;
                        Parent.MsgTitle_CTL.BackColor = Color.Purple;
                        Parent.MsgTitle_CTL.ForeColor = Color.White;
                        Parent.StatusMsg.ForeColor = Color.Purple;
                        break;
                    case Common.MsgTypeEnum.Trace:
                        Parent.MsgTitle_CTL.Text = this.MsgTy_TRACE;
                        Parent.MsgTitle_CTL.BackColor = Color.Purple;
                        Parent.MsgTitle_CTL.ForeColor = Color.White;
                        Parent.StatusMsg.ForeColor = Color.Purple;
                        break;
                }
            }
        }

        private void InitializeComponent()
        {

        }
        
    }

    public class MainFormTitlesConverter : ExpandableObjectConverter
    {
        public override bool CanConvertTo(ITypeDescriptorContext context, Type destinationType)
        {
            if (destinationType == typeof(MainFormDesign))
            {
                return true;
            }
            return base.CanConvertTo(context, destinationType);
        }

        public override bool CanConvertFrom(ITypeDescriptorContext context, Type sourceType)
        {
            if (sourceType == typeof(string))
            {
                return true;
            }
            return base.CanConvertFrom(context, sourceType);
        }

        public override object ConvertTo(ITypeDescriptorContext context, CultureInfo culture, object value, System.Type destinationType)
        {
            if (destinationType == typeof(System.String) && value is MainFormDesign)
            {
                MainFormDesign m = (MainFormDesign)value;
                return "" + m.TIT_Plant;
            }
            return base.ConvertTo(context, culture, value, destinationType);
        }

        public override object ConvertFrom(ITypeDescriptorContext context, CultureInfo culture, object value)
        {
            if (value is string)
            {
                try
                {
                    MainFormDesign m = new MainFormDesign();
                    string[] sARR = ((string)value).Split(',');
                    for (int i = 0; i < sARR.Length; i++)
                    {
                        if (i == 0)
                        {
                            m.TIT_Plant = sARR[i];
                        }

                    }


                    return m;
                }
                catch
                {
                    throw new ArgumentException("Can not convert '" + (string)value + "' to type MainFormTitles");
                }
            }
            return base.ConvertFrom(context, culture, value);
        }

        
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.IO;
using System.Diagnostics;
using SY_MES.FX.Controls.Base;
using YPdfViewer;
using System.Security.Cryptography;

namespace SY_MES.FX.Controls
{
    [ToolboxBitmap(typeof(PictureBox))]
    public partial class YPdfView : UserControl
    {
        private int m_PageCount = 0;
        public int PageCount
        {
            get { return m_PageCount; }
            set { m_PageCount = value; }
        }
        YPdfViewer.PdfViewer m_pdfViewer;

        public YPdfView()
        {
            InitializeComponent();
            
        }
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            if(DesignMode ==false)
            {
                m_pdfViewer = new YPdfViewer.PdfViewer();
                m_pdfViewer.Dock = DockStyle.Fill;
                m_pdfViewer.AutoScroll = true;
                m_pdfViewer.ShowToolbar = false;
                m_pdfViewer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
                this.Controls.Add(m_pdfViewer);
                
            }
        }
        public void Clear()
        {
            m_pdfViewer.Document = null;
        }
        /// <summary>
        /// Display PDF file by thread
        /// </summary>
        /// <param name="pdf">file path or stream</param>
        public void ThreadPDFShow(object pdf)
        {
            try
            {
                if (!DesignMode)
                {

                    if (!m_bThProc)
                    {
                        m_bThProc = true;
                        m_thProc = new Thread(new ParameterizedThreadStart(thLoadPDF));
                        m_thProc.Start(pdf);
                    }
                }
            }
            catch (Exception eLog)
            {
                Debug.WriteLine("[" + System.Reflection.MethodBase.GetCurrentMethod().Name + "]" + eLog.Message);
            }
        }
        
        private void thLoadPDF(object arg)
        {
            try
            {
                this.Invoke(new MethodInvoker(
                    delegate()
                    {
                        if (arg is string)
                        {
                            LoadPDF((string)arg);
                        }
                        else if (arg is byte[])
                        {
                            LoadPDF((byte[])arg);
                        }
                    }));

            }
            catch (Exception eLog)
            {
                Debug.WriteLine("[" + System.Reflection.MethodBase.GetCurrentMethod().Name + "]" + eLog.Message);
            }
            finally
            {
                m_bThProc = false;
            }
        }

        private bool m_bThProc = false;

        private Thread m_thProc = null;
        

        /// <summary>
        /// Display PDF File
        /// </summary>
        /// <param name="file">File Path</param>
        public void LoadPDF(string file)
        {

            try
            {
                m_pdfViewer.Document = PdfDocument.Load(file);
                if (m_pdfViewer.Document != null)
                {
                    m_PageCount = m_pdfViewer.Document.PageCount;
                }
                else
                {
                    m_PageCount = 0;
                }

            }
            catch (Exception eLog)
            {
                Debug.WriteLine("[" + System.Reflection.MethodBase.GetCurrentMethod().Name + "]" + eLog.Message);
            }
        }
        /// <summary>
        /// Display PDF File
        /// </summary>
        /// <param name="pdf">File byte[]</param>
        public void LoadPDF(byte[] pdf)
        {
            try
            {
                Stream sr = new MemoryStream(pdf);
                m_pdfViewer.Document = PdfDocument.Load(sr);
                if(m_pdfViewer.Document != null)
                {
                    m_PageCount = m_pdfViewer.Document.PageCount;
                }
                else
                {
                    m_PageCount = 0;
                }
            }
            catch (Exception eLog)
            {
                Debug.WriteLine("[" + System.Reflection.MethodBase.GetCurrentMethod().Name + "]" + eLog.Message);
            }

        }

    }
}

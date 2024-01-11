using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Reflection;
using System.Windows.Forms;

using Krypton.Toolkit;

namespace TestForm
{
    public partial class Main : KryptonForm
    {
        public Main()
        {
            InitializeComponent();
        }

        private void AddEvent(string message) => kryptonListBox1.Items.Add(message);

        private void textBox1_Validated(object sender, EventArgs e) => AddEvent(nameof(textBox1_Validated));

        private void kryptonTextBox1_Validated(object sender, EventArgs e) => AddEvent(nameof(kryptonTextBox1_Validated));

        private void kryptonTextBox1_DoubleClick(object sender, EventArgs e) => AddEvent(nameof(kryptonTextBox1_DoubleClick));

        private void kryptonTextBox1_MouseDoubleClick(object sender, MouseEventArgs e) => AddEvent(nameof(kryptonTextBox1_MouseDoubleClick));

        private void kryptonTextBox1_MouseClick(object sender, MouseEventArgs e) => AddEvent(nameof(kryptonTextBox1_MouseClick));

        private void kryptonTextBox1_Click(object sender, EventArgs e) => AddEvent(nameof(kryptonTextBox1_Click));

        private void textBox1_MouseDoubleClick(object sender, MouseEventArgs e) => AddEvent(nameof(textBox1_MouseDoubleClick));

        private void textBox1_MouseClick(object sender, MouseEventArgs e) => AddEvent(nameof(textBox1_MouseClick));

        private void textBox1_DoubleClick(object sender, EventArgs e) => AddEvent(nameof(textBox1_DoubleClick));

        private void textBox1_Click(object sender, EventArgs e) => AddEvent(nameof(textBox1_Click));

        private void textBox1_Validating(object sender, CancelEventArgs e) => AddEvent(nameof(textBox1_Validating));

        private void kryptonTextBox1_Validating(object sender, CancelEventArgs e) => AddEvent(nameof(kryptonTextBox1_Validating));

        private void textBox1_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e) => AddEvent(nameof(textBox1_PreviewKeyDown));

        private void kryptonTextBox1_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e) => AddEvent(nameof(kryptonTextBox1_PreviewKeyDown));

        private void kryptonTextBox1_KeyDown(object sender, KeyEventArgs e) => AddEvent(nameof(kryptonTextBox1_KeyDown));

        private void kryptonTextBox1_KeyPress(object sender, KeyPressEventArgs e) => AddEvent(nameof(kryptonTextBox1_KeyPress));

        private void kryptonTextBox1_KeyUp(object sender, KeyEventArgs e) => AddEvent(nameof(kryptonTextBox1_KeyUp));

        private void textBox1_KeyDown(object sender, KeyEventArgs e) => AddEvent(nameof(textBox1_KeyDown));

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e) => AddEvent(nameof(textBox1_KeyPress));

        private void textBox1_KeyUp(object sender, KeyEventArgs e) => AddEvent(nameof(textBox1_KeyUp));

        private void kryptonButton1_Click(object sender, EventArgs e)
        {
            var form2 = new BreadCrumbTest();

            form2.ShowDialog();
        }

        private void kryptonButton2_Click(object sender, EventArgs e)
        {
            var form3 = new RibbonTest();

            form3.ShowDialog();
        }

        private void kbtnTestMessagebox_Click(object sender, EventArgs e)
        {
            KryptonMessageBoxData data = new KryptonMessageBoxData()
            {
                MessageText = @"This is a test!",
                Caption = @"Hello World",
                Buttons = KryptonMessageBoxButtons.OK,
                Icon = KryptonMessageBoxIcon.Information,
                MessageContentAreaType = MessageBoxContentAreaType.LinkLabel,
                ActionButtonCommand = kcmdMessageboxTest,
                ShowCloseButton = kryptonCheckBox1.Checked
            };

            KryptonMessageBox.Show(@"This is a test!", @"Testing", KryptonMessageBoxButtons.OK,
                KryptonMessageBoxIcon.Information, contentAreaType: MessageBoxContentAreaType.LinkLabel,
                linkAreaCommand: kcmdMessageboxTest, showCloseButton: kryptonCheckBox1.Checked);
        }

        private void kcmdMessageboxTest_Execute(object sender, EventArgs e)
        {
            try
            {
                Process.Start(@"C:\\Windows\\Notepad.exe");
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.ToString());
            }
        }

        private void kbtnIntegratedToolbar_Click(object sender, EventArgs e)
        {
            ThemeTest integratedToolBar = new ThemeTest();

            integratedToolBar.Show();
        }

        private void kryptonButton3_Click(object sender, EventArgs e)
        {
            KryptonThemeBrowser.Show();
        }

        private void kchkUseProgressValueAsText_CheckedChanged(object sender, EventArgs e)
        {
            kryptonProgressBar1.UseValueAsText = kchkUseProgressValueAsText.Checked;
        }

        private void ktrkProgressValues_ValueChanged(object sender, EventArgs e)
        {
            kryptonProgressBar1.Value = ktrkProgressValues.Value;
        }

        private void kbtnVisualStudio2010Theme_Click(object sender, EventArgs e)
        {
            ThemeTest vsTheme = new ThemeTest();

            vsTheme.Show();
        }

        private void kryptonButton4_Click(object sender, EventArgs e)
        {
            new GroupBoxTest().Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            FormBorderStyle = FormBorderStyle.Sizable;

            kcbtnSizable.Checked = true;
        }

        private void kbtnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //private void kryptonButton6_Click(object sender, EventArgs e)
        //{
        //    kryptonCustomPaletteBase1.Import();
        //}

        //private void kryptonButton7_Click(object sender, EventArgs e)
        //{
        //    kryptonCustomPaletteBase1.Export();
        //}

        private void kryptonButton8_Click(object sender, EventArgs e)
        {
            KryptonAboutBoxData aboutBoxData = new KryptonAboutBoxData()
            {
                ApplicationName = @"TestForm",
                CurrentAssembly = Assembly.GetExecutingAssembly(),
                HeaderImage = null,
                MainImage = null,
                ShowToolkitInformation = true,
            };

            KryptonAboutToolkitData aboutToolkitData = new KryptonAboutToolkitData();

            KryptonAboutBox.Show(aboutBoxData, aboutToolkitData);
        }

        private void kcbtnNone_Click(object sender, EventArgs e) => UpdateBorderStyle(FormBorderStyle.None);

        private void kcbtnFixedSingle_Click(object sender, EventArgs e) => UpdateBorderStyle(FormBorderStyle.FixedSingle);

        private void kcbtnFixed3D_Click(object sender, EventArgs e) => UpdateBorderStyle(FormBorderStyle.Fixed3D);

        private void kcbtnFixedDialog_Click(object sender, EventArgs e) => UpdateBorderStyle(FormBorderStyle.FixedDialog);

        private void kcbtnSizable_Click(object sender, EventArgs e) => UpdateBorderStyle(FormBorderStyle.Sizable);

        private void kcbtnFixedToolWindow_Click(object sender, EventArgs e) => UpdateBorderStyle(FormBorderStyle.FixedToolWindow);

        private void kcbtnSizableToolWindow_Click(object sender, EventArgs e) => UpdateBorderStyle(FormBorderStyle.SizableToolWindow);

        private void UpdateBorderStyle(FormBorderStyle borderStyle)
        {
            switch (borderStyle)
            {
                case FormBorderStyle.None:
                    FormBorderStyle = FormBorderStyle.None;

                    kcbtnNone.Checked = true;

                    kcbtnFixed3D.Checked = false;

                    kcbtnFixedDialog.Checked = false;

                    kcbtnFixedSingle.Checked = false;

                    kcbtnFixedToolWindow.Checked = false;

                    kcbtnSizable.Checked = false;

                    kcbtnSizableToolWindow.Checked = false;
                    break;
                case FormBorderStyle.FixedSingle:
                    FormBorderStyle = FormBorderStyle.FixedSingle;

                    kcbtnNone.Checked = false;

                    kcbtnFixed3D.Checked = false;

                    kcbtnFixedDialog.Checked = false;

                    kcbtnFixedSingle.Checked = true;

                    kcbtnFixedToolWindow.Checked = false;

                    kcbtnSizable.Checked = false;

                    kcbtnSizableToolWindow.Checked = false;
                    break;
                case FormBorderStyle.Fixed3D:
                    FormBorderStyle = FormBorderStyle.Fixed3D;

                    kcbtnNone.Checked = false;

                    kcbtnFixed3D.Checked = true;

                    kcbtnFixedDialog.Checked = false;

                    kcbtnFixedSingle.Checked = false;

                    kcbtnFixedToolWindow.Checked = false;

                    kcbtnSizable.Checked = false;

                    kcbtnSizableToolWindow.Checked = false;
                    break;
                case FormBorderStyle.FixedDialog:
                    FormBorderStyle = FormBorderStyle.FixedDialog;

                    kcbtnNone.Checked = false;

                    kcbtnFixed3D.Checked = false;

                    kcbtnFixedDialog.Checked = true;

                    kcbtnFixedSingle.Checked = false;

                    kcbtnFixedToolWindow.Checked = false;

                    kcbtnSizable.Checked = false;

                    kcbtnSizableToolWindow.Checked = false;
                    break;
                case FormBorderStyle.Sizable:
                    FormBorderStyle = FormBorderStyle.Sizable;

                    kcbtnNone.Checked = false;

                    kcbtnFixed3D.Checked = false;

                    kcbtnFixedDialog.Checked = false;

                    kcbtnFixedSingle.Checked = false;

                    kcbtnFixedToolWindow.Checked = false;

                    kcbtnSizable.Checked = true;

                    kcbtnSizableToolWindow.Checked = false;
                    break;
                case FormBorderStyle.FixedToolWindow:
                    FormBorderStyle = FormBorderStyle.FixedToolWindow;

                    kcbtnNone.Checked = false;

                    kcbtnFixed3D.Checked = false;

                    kcbtnFixedDialog.Checked = false;

                    kcbtnFixedSingle.Checked = false;

                    kcbtnFixedToolWindow.Checked = true;

                    kcbtnSizable.Checked = false;

                    kcbtnSizableToolWindow.Checked = false;
                    break;
                case FormBorderStyle.SizableToolWindow:
                    FormBorderStyle = FormBorderStyle.SizableToolWindow;

                    kcbtnNone.Checked = false;

                    kcbtnFixed3D.Checked = false;

                    kcbtnFixedDialog.Checked = false;

                    kcbtnFixedSingle.Checked = false;

                    kcbtnFixedToolWindow.Checked = false;

                    kcbtnSizable.Checked = false;

                    kcbtnSizableToolWindow.Checked = true;
                    break;
                default:
                    throw new ArgumentOutOfRangeException(nameof(borderStyle), borderStyle, null);
            }
        }

        private void kryptonButton5_Click(object sender, EventArgs e)
        {
            kryptonTaskDialog1.ShowDialog();
        }

        private void kryptonButton9_Click(object sender, EventArgs e)
        {
            CommandLinkButtons commandLinks = new CommandLinkButtons();

            commandLinks.ShowDialog();
        }

        private void kryptonColorButton1_SelectedColorChanged(object sender, ColorEventArgs e)
        {
            kryptonButton1.Values.DropDownArrowColor = e.Color;
        }

        private void kryptonButton10_Click(object sender, EventArgs e)
        {
            KryptonBasicToastNotificationData toastNotificationDataNoCustomImage = new KryptonBasicToastNotificationData()
            {
                ShowCloseBox = kryptonCheckBox2.Checked,
                CountDownSeconds = 60,
                NotificationContent = @"This is a test",
                NotificationIcon = KryptonToastNotificationIcon.Information,
                NotificationTitle = @"Hello World"
            };

            //KryptonBasicToastNotificationData toastNotificationDataCustomImage = new KryptonBasicToastNotificationData()
            //{
            //    ShowCloseBox = kryptonCheckBox2.Checked,
            //    CountDownSeconds = 60,
            //    NotificationContent = @"This is a test",
            //    NotificationIcon = KryptonToastNotificationIcon.Custom,
            //    CustomImage = new Bitmap(ktxtCustomImagePath.Text),
            //    NotificationTitle = @"Hello World"
            //};

            KryptonToastNotification.ShowBasicNotification(toastNotificationDataNoCustomImage);

        //    KryptonToastNotification.ShowBasicNotification(string.IsNullOrEmpty(ktxtCustomImagePath.Text)
        //        ? toastNotificationDataNoCustomImage
        //        : toastNotificationDataCustomImage);
        }

        private void kryptonButton11_Click(object sender, EventArgs e)
        {
            KryptonMessageBox.Show(string.Empty, @"Test with no Text");
        }

        private void kryptonButton12_Click(object sender, EventArgs e)
        {
            FadeFormTest fadeForm = new FadeFormTest();

            fadeForm.ShowDialog();
        }

        private void kcmdOpenImage_Execute(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                ktxtCustomImagePath.Text = Path.GetFullPath(openFileDialog.FileName);
            }
        }

        private void kryptonButton13_Click(object sender, EventArgs e)
        {
            KryptonBasicToastNotificationData toastNotificationDataNoCustomImage = new KryptonBasicToastNotificationData()
            {
                ShowCloseBox = kryptonCheckBox2.Checked,
                CountDownSeconds = 60,
                NotificationContent = @"This is a test",
                NotificationIcon = KryptonToastNotificationIcon.Information,
                NotificationTitle = @"Hello World"
            };

            KryptonToastNotification.ShowBasicProgressBarNotification(toastNotificationDataNoCustomImage);
        }
    }
}
﻿namespace TestForm
{
    partial class Form7
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form7));
            this.kryptonPanel1 = new Krypton.Toolkit.KryptonPanel();
            this.kryptonCommandLinkButton1 = new Krypton.Toolkit.KryptonCommandLinkButton();
            this.kryptonAlternateCommandLinkButton1 = new Krypton.Toolkit.KryptonAlternateCommandLinkButton();
            this.kryptonCommandLinkButton2 = new Krypton.Toolkit.KryptonCommandLinkButton();
            this.kryptonCommandLinkButton3 = new Krypton.Toolkit.KryptonCommandLinkButton();
            this.kryptonCommandLinkButton4 = new Krypton.Toolkit.KryptonCommandLinkButton();
            this.kryptonCommandLinkButton5 = new Krypton.Toolkit.KryptonCommandLinkButton();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).BeginInit();
            this.kryptonPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // kryptonPanel1
            // 
            this.kryptonPanel1.Controls.Add(this.kryptonCommandLinkButton5);
            this.kryptonPanel1.Controls.Add(this.kryptonCommandLinkButton4);
            this.kryptonPanel1.Controls.Add(this.kryptonCommandLinkButton3);
            this.kryptonPanel1.Controls.Add(this.kryptonCommandLinkButton2);
            this.kryptonPanel1.Controls.Add(this.kryptonAlternateCommandLinkButton1);
            this.kryptonPanel1.Controls.Add(this.kryptonCommandLinkButton1);
            this.kryptonPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonPanel1.Location = new System.Drawing.Point(0, 0);
            this.kryptonPanel1.Name = "kryptonPanel1";
            this.kryptonPanel1.Size = new System.Drawing.Size(690, 386);
            this.kryptonPanel1.TabIndex = 0;
            // 
            // kryptonCommandLinkButton1
            // 
            this.kryptonCommandLinkButton1.CommandLinkTextValues.Description = "Here be the \"Note Text\"";
            this.kryptonCommandLinkButton1.CommandLinkTextValues.Heading = "Default Ext Command Link";
            this.kryptonCommandLinkButton1.Location = new System.Drawing.Point(12, 99);
            this.kryptonCommandLinkButton1.Name = "kryptonCommandLinkButton1";
            this.kryptonCommandLinkButton1.OverrideFocus.Border.Draw = Krypton.Toolkit.InheritBool.True;
            this.kryptonCommandLinkButton1.OverrideFocus.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom)
            | Krypton.Toolkit.PaletteDrawBorders.Left)
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonCommandLinkButton1.OverrideFocus.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.kryptonCommandLinkButton1.Size = new System.Drawing.Size(341, 61);
            this.kryptonCommandLinkButton1.StateCommon.Content.LongText.TextH = Krypton.Toolkit.PaletteRelativeAlign.Near;
            this.kryptonCommandLinkButton1.StateCommon.Content.LongText.TextV = Krypton.Toolkit.PaletteRelativeAlign.Far;
            this.kryptonCommandLinkButton1.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonCommandLinkButton1.StateCommon.Content.ShortText.TextH = Krypton.Toolkit.PaletteRelativeAlign.Near;
            this.kryptonCommandLinkButton1.StateCommon.Content.ShortText.TextV = Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.kryptonCommandLinkButton1.TabIndex = 0;
            // 
            // kryptonAlternateCommandLinkButton1
            // 
            this.kryptonAlternateCommandLinkButton1.Location = new System.Drawing.Point(12, 12);
            this.kryptonAlternateCommandLinkButton1.Name = "kryptonAlternateCommandLinkButton1";
            this.kryptonAlternateCommandLinkButton1.Size = new System.Drawing.Size(341, 69);
            this.kryptonAlternateCommandLinkButton1.StateCommon.Content.Image.ImageH = Krypton.Toolkit.PaletteRelativeAlign.Near;
            this.kryptonAlternateCommandLinkButton1.StateCommon.Content.Image.ImageV = Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.kryptonAlternateCommandLinkButton1.StateCommon.Content.LongText.TextH = Krypton.Toolkit.PaletteRelativeAlign.Near;
            this.kryptonAlternateCommandLinkButton1.StateCommon.Content.LongText.TextV = Krypton.Toolkit.PaletteRelativeAlign.Far;
            this.kryptonAlternateCommandLinkButton1.StateCommon.Content.ShortText.TextH = Krypton.Toolkit.PaletteRelativeAlign.Near;
            this.kryptonAlternateCommandLinkButton1.StateCommon.Content.ShortText.TextV = Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.kryptonAlternateCommandLinkButton1.TabIndex = 1;
            this.kryptonAlternateCommandLinkButton1.Values.ExtraText = "Text here is forced in to the  lower part of the button";
            this.kryptonAlternateCommandLinkButton1.Values.Image = ((System.Drawing.Image)(resources.GetObject("kryptonAlternateCommandLinkButton1.Values.Image")));
            this.kryptonAlternateCommandLinkButton1.Values.Text = "Normal Krypton Button";
            // 
            // kryptonCommandLinkButton2
            // 
            this.kryptonCommandLinkButton2.ButtonStyle = Krypton.Toolkit.ButtonStyle.Standalone;
            this.kryptonCommandLinkButton2.CommandLinkTextValues.Description = " Here be the extra Text with some spaces";
            this.kryptonCommandLinkButton2.CommandLinkTextValues.Heading = "Standalone Style";
            this.kryptonCommandLinkButton2.Location = new System.Drawing.Point(12, 180);
            this.kryptonCommandLinkButton2.Name = "kryptonCommandLinkButton2";
            this.kryptonCommandLinkButton2.OverrideFocus.Border.Draw = Krypton.Toolkit.InheritBool.True;
            this.kryptonCommandLinkButton2.OverrideFocus.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom)
            | Krypton.Toolkit.PaletteDrawBorders.Left)
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonCommandLinkButton2.OverrideFocus.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.kryptonCommandLinkButton2.Size = new System.Drawing.Size(341, 61);
            this.kryptonCommandLinkButton2.StateCommon.Content.LongText.TextH = Krypton.Toolkit.PaletteRelativeAlign.Near;
            this.kryptonCommandLinkButton2.StateCommon.Content.LongText.TextV = Krypton.Toolkit.PaletteRelativeAlign.Far;
            this.kryptonCommandLinkButton2.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonCommandLinkButton2.StateCommon.Content.ShortText.TextH = Krypton.Toolkit.PaletteRelativeAlign.Near;
            this.kryptonCommandLinkButton2.StateCommon.Content.ShortText.TextV = Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.kryptonCommandLinkButton2.TabIndex = 2;
            // 
            // kryptonCommandLinkButton3
            // 
            this.kryptonCommandLinkButton3.ButtonStyle = Krypton.Toolkit.ButtonStyle.NavigatorMini;
            this.kryptonCommandLinkButton3.CommandLinkTextValues.Description = " Demo the Shortcut display and rounded borders";
            this.kryptonCommandLinkButton3.CommandLinkTextValues.Heading = "&Navigator Mini style";
            this.kryptonCommandLinkButton3.Location = new System.Drawing.Point(12, 247);
            this.kryptonCommandLinkButton3.Name = "kryptonCommandLinkButton3";
            this.kryptonCommandLinkButton3.OverrideFocus.Border.Draw = Krypton.Toolkit.InheritBool.True;
            this.kryptonCommandLinkButton3.OverrideFocus.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom)
            | Krypton.Toolkit.PaletteDrawBorders.Left)
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonCommandLinkButton3.OverrideFocus.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.kryptonCommandLinkButton3.Size = new System.Drawing.Size(341, 61);
            this.kryptonCommandLinkButton3.StateCommon.Border.Draw = Krypton.Toolkit.InheritBool.True;
            this.kryptonCommandLinkButton3.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom)
            | Krypton.Toolkit.PaletteDrawBorders.Left)
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonCommandLinkButton3.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.kryptonCommandLinkButton3.StateCommon.Border.Rounding = 4F;
            this.kryptonCommandLinkButton3.StateCommon.Border.Width = 2;
            this.kryptonCommandLinkButton3.StateCommon.Content.LongText.TextH = Krypton.Toolkit.PaletteRelativeAlign.Near;
            this.kryptonCommandLinkButton3.StateCommon.Content.LongText.TextV = Krypton.Toolkit.PaletteRelativeAlign.Far;
            this.kryptonCommandLinkButton3.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonCommandLinkButton3.StateCommon.Content.ShortText.TextH = Krypton.Toolkit.PaletteRelativeAlign.Near;
            this.kryptonCommandLinkButton3.StateCommon.Content.ShortText.TextV = Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.kryptonCommandLinkButton3.TabIndex = 3;
            // 
            // kryptonCommandLinkButton4
            // 
            this.kryptonCommandLinkButton4.ButtonStyle = Krypton.Toolkit.ButtonStyle.NavigatorMini;
            this.kryptonCommandLinkButton4.CommandLinkImageValues.Image = ((System.Drawing.Image)(resources.GetObject("kryptonCommandLinkButton4.CommandLinkImageValues.Image")));
            this.kryptonCommandLinkButton4.CommandLinkTextValues.Description = " Demo the Shortcut display and rounded borders";
            this.kryptonCommandLinkButton4.CommandLinkTextValues.Heading = "&Disabled Navigator Mini style";
            this.kryptonCommandLinkButton4.Enabled = false;
            this.kryptonCommandLinkButton4.Location = new System.Drawing.Point(13, 315);
            this.kryptonCommandLinkButton4.Name = "kryptonCommandLinkButton4";
            this.kryptonCommandLinkButton4.OverrideFocus.Border.Draw = Krypton.Toolkit.InheritBool.True;
            this.kryptonCommandLinkButton4.OverrideFocus.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom)
            | Krypton.Toolkit.PaletteDrawBorders.Left)
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonCommandLinkButton4.OverrideFocus.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.kryptonCommandLinkButton4.Size = new System.Drawing.Size(340, 55);
            this.kryptonCommandLinkButton4.StateCommon.Border.Draw = Krypton.Toolkit.InheritBool.True;
            this.kryptonCommandLinkButton4.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom)
            | Krypton.Toolkit.PaletteDrawBorders.Left)
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonCommandLinkButton4.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.kryptonCommandLinkButton4.StateCommon.Border.Rounding = 4F;
            this.kryptonCommandLinkButton4.StateCommon.Border.Width = 2;
            this.kryptonCommandLinkButton4.StateCommon.Content.LongText.TextH = Krypton.Toolkit.PaletteRelativeAlign.Near;
            this.kryptonCommandLinkButton4.StateCommon.Content.LongText.TextV = Krypton.Toolkit.PaletteRelativeAlign.Far;
            this.kryptonCommandLinkButton4.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonCommandLinkButton4.StateCommon.Content.ShortText.TextH = Krypton.Toolkit.PaletteRelativeAlign.Near;
            this.kryptonCommandLinkButton4.StateCommon.Content.ShortText.TextV = Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.kryptonCommandLinkButton4.TabIndex = 4;
            // 
            // kryptonCommandLinkButton5
            // 
            this.kryptonCommandLinkButton5.ButtonStyle = Krypton.Toolkit.ButtonStyle.Standalone;
            this.kryptonCommandLinkButton5.CommandLinkTextValues.Description = "What happens when the text is really long, \r\nand wants to go off the edge?\r\nThen " +
    "Use a Multi-line ;-)\r\n";
            this.kryptonCommandLinkButton5.CommandLinkTextValues.Heading = "&Control the World";
            this.kryptonCommandLinkButton5.Location = new System.Drawing.Point(359, 12);
            this.kryptonCommandLinkButton5.Name = "kryptonCommandLinkButton5";
            this.kryptonCommandLinkButton5.OverrideFocus.Border.Draw = Krypton.Toolkit.InheritBool.True;
            this.kryptonCommandLinkButton5.OverrideFocus.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom)
            | Krypton.Toolkit.PaletteDrawBorders.Left)
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonCommandLinkButton5.OverrideFocus.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.kryptonCommandLinkButton5.Size = new System.Drawing.Size(319, 86);
            this.kryptonCommandLinkButton5.StateCommon.Back.Color1 = System.Drawing.SystemColors.GradientActiveCaption;
            this.kryptonCommandLinkButton5.StateCommon.Back.Color2 = System.Drawing.SystemColors.ActiveCaption;
            this.kryptonCommandLinkButton5.StateCommon.Back.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.kryptonCommandLinkButton5.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.kryptonCommandLinkButton5.StateCommon.Border.Draw = Krypton.Toolkit.InheritBool.True;
            this.kryptonCommandLinkButton5.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom)
            | Krypton.Toolkit.PaletteDrawBorders.Left)
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonCommandLinkButton5.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.kryptonCommandLinkButton5.StateCommon.Border.Rounding = 6F;
            this.kryptonCommandLinkButton5.StateCommon.Border.Width = 2;
            this.kryptonCommandLinkButton5.StateCommon.Content.LongText.MultiLine = Krypton.Toolkit.InheritBool.True;
            this.kryptonCommandLinkButton5.StateCommon.Content.LongText.MultiLineH = Krypton.Toolkit.PaletteRelativeAlign.Near;
            this.kryptonCommandLinkButton5.StateCommon.Content.LongText.TextH = Krypton.Toolkit.PaletteRelativeAlign.Near;
            this.kryptonCommandLinkButton5.StateCommon.Content.LongText.TextV = Krypton.Toolkit.PaletteRelativeAlign.Far;
            this.kryptonCommandLinkButton5.StateCommon.Content.LongText.Trim = Krypton.Toolkit.PaletteTextTrim.Word;
            this.kryptonCommandLinkButton5.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonCommandLinkButton5.StateCommon.Content.ShortText.TextH = Krypton.Toolkit.PaletteRelativeAlign.Near;
            this.kryptonCommandLinkButton5.StateCommon.Content.ShortText.TextV = Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.kryptonCommandLinkButton5.TabIndex = 5;
            // 
            // Form7
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(690, 386);
            this.Controls.Add(this.kryptonPanel1);
            this.Name = "Form7";
            this.Text = "Form7";
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).EndInit();
            this.kryptonPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Krypton.Toolkit.KryptonPanel kryptonPanel1;
        private Krypton.Toolkit.KryptonCommandLinkButton kryptonCommandLinkButton1;
        private Krypton.Toolkit.KryptonCommandLinkButton kryptonCommandLinkButton5;
        private Krypton.Toolkit.KryptonCommandLinkButton kryptonCommandLinkButton4;
        private Krypton.Toolkit.KryptonCommandLinkButton kryptonCommandLinkButton3;
        private Krypton.Toolkit.KryptonCommandLinkButton kryptonCommandLinkButton2;
        private Krypton.Toolkit.KryptonAlternateCommandLinkButton kryptonAlternateCommandLinkButton1;
    }
}
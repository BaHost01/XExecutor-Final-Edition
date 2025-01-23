namespace XExecutor_Final_Edition
{
    partial class XExecutor
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(XExecutor));
            this.Inject = new System.Windows.Forms.Button();
            this.Execute = new System.Windows.Forms.Button();
            this.editor = new System.Windows.Forms.RichTextBox();
            this.robloxopen = new System.Windows.Forms.Label();
            this.status = new System.Windows.Forms.Label();
            this.AutoInject = new System.Windows.Forms.CheckBox();
            this.Killer = new System.Windows.Forms.Button();
            this.x = new System.Windows.Forms.Button();
            this.Mini = new System.Windows.Forms.Button();
            this.MainText = new System.Windows.Forms.Label();
            this.List1 = new System.Windows.Forms.ListBox();
            this.Ref = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Inject
            // 
            resources.ApplyResources(this.Inject, "Inject");
            this.Inject.BackColor = System.Drawing.Color.Black;
            this.Inject.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Inject.Name = "Inject";
            this.Inject.UseVisualStyleBackColor = false;
            this.Inject.Click += new System.EventHandler(this.Inject_Click);
            // 
            // Execute
            // 
            resources.ApplyResources(this.Execute, "Execute");
            this.Execute.BackColor = System.Drawing.Color.Black;
            this.Execute.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Execute.Name = "Execute";
            this.Execute.UseVisualStyleBackColor = false;
            this.Execute.Click += new System.EventHandler(this.Execute_Click);
            // 
            // editor
            // 
            resources.ApplyResources(this.editor, "editor");
            this.editor.BackColor = System.Drawing.Color.DimGray;
            this.editor.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.editor.Name = "editor";
            this.editor.TextChanged += new System.EventHandler(this.Editor_TextChanged);
            // 
            // robloxopen
            // 
            resources.ApplyResources(this.robloxopen, "robloxopen");
            this.robloxopen.BackColor = System.Drawing.Color.DimGray;
            this.robloxopen.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.robloxopen.Name = "robloxopen";
            this.robloxopen.Click += new System.EventHandler(this.robloxopen_Click);
            // 
            // status
            // 
            resources.ApplyResources(this.status, "status");
            this.status.BackColor = System.Drawing.Color.DimGray;
            this.status.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.status.Name = "status";
            this.status.Click += new System.EventHandler(this.status_Click);
            // 
            // AutoInject
            // 
            resources.ApplyResources(this.AutoInject, "AutoInject");
            this.AutoInject.BackColor = System.Drawing.Color.DimGray;
            this.AutoInject.Checked = true;
            this.AutoInject.CheckState = System.Windows.Forms.CheckState.Checked;
            this.AutoInject.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.AutoInject.Name = "AutoInject";
            this.AutoInject.UseVisualStyleBackColor = false;
            this.AutoInject.CheckedChanged += new System.EventHandler(this.AutoInject_CheckedChanged);
            // 
            // Killer
            // 
            resources.ApplyResources(this.Killer, "Killer");
            this.Killer.BackColor = System.Drawing.Color.Black;
            this.Killer.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Killer.Name = "Killer";
            this.Killer.UseVisualStyleBackColor = false;
            this.Killer.Click += new System.EventHandler(this.Killer_Click);
            // 
            // x
            // 
            resources.ApplyResources(this.x, "x");
            this.x.BackColor = System.Drawing.Color.DarkViolet;
            this.x.Name = "x";
            this.x.UseVisualStyleBackColor = false;
            this.x.Click += new System.EventHandler(this.x_Click);
            // 
            // Mini
            // 
            resources.ApplyResources(this.Mini, "Mini");
            this.Mini.BackColor = System.Drawing.Color.DarkViolet;
            this.Mini.Name = "Mini";
            this.Mini.UseVisualStyleBackColor = false;
            this.Mini.Click += new System.EventHandler(this.Mini_Click);
            // 
            // MainText
            // 
            resources.ApplyResources(this.MainText, "MainText");
            this.MainText.ForeColor = System.Drawing.Color.OrangeRed;
            this.MainText.Name = "MainText";
            this.MainText.Click += new System.EventHandler(this.label1_Click);
            // 
            // List1
            // 
            resources.ApplyResources(this.List1, "List1");
            this.List1.BackColor = System.Drawing.Color.DimGray;
            this.List1.ForeColor = System.Drawing.SystemColors.Info;
            this.List1.FormattingEnabled = true;
            this.List1.Items.AddRange(new object[] {
            resources.GetString("List1.Items")});
            this.List1.Name = "List1";
            this.List1.SelectedIndexChanged += new System.EventHandler(this.List1_SelectedIndexChanged);
            // 
            // Ref
            // 
            resources.ApplyResources(this.Ref, "Ref");
            this.Ref.BackColor = System.Drawing.Color.Black;
            this.Ref.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Ref.Name = "Ref";
            this.Ref.UseVisualStyleBackColor = false;
            this.Ref.Click += new System.EventHandler(this.button1_Click);
            // 
            // XExecutor
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.Controls.Add(this.Ref);
            this.Controls.Add(this.List1);
            this.Controls.Add(this.MainText);
            this.Controls.Add(this.Mini);
            this.Controls.Add(this.x);
            this.Controls.Add(this.Killer);
            this.Controls.Add(this.AutoInject);
            this.Controls.Add(this.status);
            this.Controls.Add(this.robloxopen);
            this.Controls.Add(this.editor);
            this.Controls.Add(this.Execute);
            this.Controls.Add(this.Inject);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.ForeColor = System.Drawing.Color.Transparent;
            this.Name = "XExecutor";
            this.TopMost = true;
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
            this.Load += new System.EventHandler(this.XExecutor_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.XExecutor_KeyDown);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.XExecutor_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.XExecutor_MouseMove);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Inject;
        private System.Windows.Forms.Button Execute;
        private System.Windows.Forms.RichTextBox editor;
        private System.Windows.Forms.Label robloxopen;
        private System.Windows.Forms.Label status;
        private System.Windows.Forms.CheckBox AutoInject;
        private System.Windows.Forms.Button Killer;
        private System.Windows.Forms.Button x;
        private System.Windows.Forms.Button Mini;
        private System.Windows.Forms.Label MainText;
        private System.Windows.Forms.ListBox List1;
        private System.Windows.Forms.Button Ref;
    }
}


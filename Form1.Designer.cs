
namespace AppKryptoAndCompression
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Dyski:");
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.opcjeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dodajPlikToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.resetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.informacjeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.listViewFiles = new System.Windows.Forms.ListView();
            this.patch = new System.Windows.Forms.ColumnHeader();
            this.rozmiar = new System.Windows.Forms.ColumnHeader();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.progressBar2 = new System.Windows.Forms.ProgressBar();
            this.groupBoxEncrypt = new System.Windows.Forms.GroupBox();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.buttonEncrypt = new System.Windows.Forms.Button();
            this.textBoxEncryptedPassword = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBoxDecrypt = new System.Windows.Forms.GroupBox();
            this.buttonDecrypt = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxDecryptionPassword = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.groupBoxDecompression = new System.Windows.Forms.GroupBox();
            this.buttonDecompression = new System.Windows.Forms.Button();
            this.groupBoxPasswordStrength = new System.Windows.Forms.GroupBox();
            this.groupBoxPasswordConditions = new System.Windows.Forms.GroupBox();
            this.labelHasLowerChar = new System.Windows.Forms.Label();
            this.labelHasSymbol = new System.Windows.Forms.Label();
            this.labelHasUpperChar = new System.Windows.Forms.Label();
            this.labelHasNumber = new System.Windows.Forms.Label();
            this.labelHasMiniMaxChars = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.checkBoxShowPassword = new System.Windows.Forms.CheckBox();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.labelResultPass = new System.Windows.Forms.Label();
            this.labelPassword = new System.Windows.Forms.Label();
            this.progressBarPassword = new System.Windows.Forms.ProgressBar();
            this.groupBoxCompression = new System.Windows.Forms.GroupBox();
            this.radioButtonZip = new System.Windows.Forms.RadioButton();
            this.checkBoxDeleteFile = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.radioButtonlz77 = new System.Windows.Forms.RadioButton();
            this.buttonCompression = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripProgressBar1 = new System.Windows.Forms.ToolStripProgressBar();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripProgressBar2 = new System.Windows.Forms.ToolStripProgressBar();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.UsunToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip3 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.usunToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.toolStripContainer1 = new System.Windows.Forms.ToolStripContainer();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.saveFileDialog2 = new System.Windows.Forms.SaveFileDialog();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBoxEncrypt.SuspendLayout();
            this.groupBoxDecrypt.SuspendLayout();
            this.groupBoxDecompression.SuspendLayout();
            this.groupBoxPasswordStrength.SuspendLayout();
            this.groupBoxPasswordConditions.SuspendLayout();
            this.groupBoxCompression.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.contextMenuStrip2.SuspendLayout();
            this.contextMenuStrip3.SuspendLayout();
            this.toolStripContainer1.BottomToolStripPanel.SuspendLayout();
            this.toolStripContainer1.ContentPanel.SuspendLayout();
            this.toolStripContainer1.TopToolStripPanel.SuspendLayout();
            this.toolStripContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.Control;
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.opcjeToolStripMenuItem,
            this.informacjeToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1032, 31);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // opcjeToolStripMenuItem
            // 
            this.opcjeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dodajPlikToolStripMenuItem,
            this.resetToolStripMenuItem});
            this.opcjeToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.opcjeToolStripMenuItem.Name = "opcjeToolStripMenuItem";
            this.opcjeToolStripMenuItem.Size = new System.Drawing.Size(68, 27);
            this.opcjeToolStripMenuItem.Text = "Opcje";
            // 
            // dodajPlikToolStripMenuItem
            // 
            this.dodajPlikToolStripMenuItem.Name = "dodajPlikToolStripMenuItem";
            this.dodajPlikToolStripMenuItem.Size = new System.Drawing.Size(170, 28);
            this.dodajPlikToolStripMenuItem.Text = "Dodaj plik";
            this.dodajPlikToolStripMenuItem.Click += new System.EventHandler(this.dodajPlikToolStripMenuItem_Click);
            // 
            // resetToolStripMenuItem
            // 
            this.resetToolStripMenuItem.Name = "resetToolStripMenuItem";
            this.resetToolStripMenuItem.Size = new System.Drawing.Size(170, 28);
            this.resetToolStripMenuItem.Text = "Reset";
            this.resetToolStripMenuItem.Click += new System.EventHandler(this.resetToolStripMenuItem_Click);
            // 
            // informacjeToolStripMenuItem
            // 
            this.informacjeToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.informacjeToolStripMenuItem.Name = "informacjeToolStripMenuItem";
            this.informacjeToolStripMenuItem.Size = new System.Drawing.Size(105, 27);
            this.informacjeToolStripMenuItem.Text = "Informacje";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.AutoScroll = true;
            this.splitContainer1.Panel1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.splitContainer1.Panel1.Controls.Add(this.listViewFiles);
            this.splitContainer1.Panel1.Controls.Add(this.groupBox5);
            this.splitContainer1.Panel1.Controls.Add(this.groupBoxEncrypt);
            this.splitContainer1.Panel1.Controls.Add(this.groupBoxDecrypt);
            this.splitContainer1.Panel1.Controls.Add(this.treeView1);
            this.splitContainer1.Panel1.Padding = new System.Windows.Forms.Padding(2);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.AutoScroll = true;
            this.splitContainer1.Panel2.BackColor = System.Drawing.SystemColors.ControlDark;
            this.splitContainer1.Panel2.Controls.Add(this.groupBoxDecompression);
            this.splitContainer1.Panel2.Controls.Add(this.groupBoxPasswordStrength);
            this.splitContainer1.Panel2.Controls.Add(this.groupBoxCompression);
            this.splitContainer1.Panel2.Padding = new System.Windows.Forms.Padding(2);
            this.splitContainer1.Size = new System.Drawing.Size(1032, 710);
            this.splitContainer1.SplitterDistance = 597;
            this.splitContainer1.TabIndex = 1;
            // 
            // listViewFiles
            // 
            this.listViewFiles.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.patch,
            this.rozmiar});
            this.listViewFiles.Dock = System.Windows.Forms.DockStyle.Top;
            this.listViewFiles.Location = new System.Drawing.Point(2, 2);
            this.listViewFiles.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.listViewFiles.MultiSelect = false;
            this.listViewFiles.Name = "listViewFiles";
            this.listViewFiles.Size = new System.Drawing.Size(593, 200);
            this.listViewFiles.TabIndex = 15;
            this.listViewFiles.UseCompatibleStateImageBehavior = false;
            this.listViewFiles.View = System.Windows.Forms.View.Details;
            this.listViewFiles.MouseClick += new System.Windows.Forms.MouseEventHandler(this.listViewFiles_MouseClick);
            // 
            // patch
            // 
            this.patch.Text = "Plik";
            this.patch.Width = 236;
            // 
            // rozmiar
            // 
            this.rozmiar.Text = "Rozmiar";
            this.rozmiar.Width = 84;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.progressBar2);
            this.groupBox5.Location = new System.Drawing.Point(305, 393);
            this.groupBox5.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox5.Size = new System.Drawing.Size(264, 96);
            this.groupBox5.TabIndex = 13;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Postepy Szyfrowania/Deszyfrowania";
            // 
            // progressBar2
            // 
            this.progressBar2.Location = new System.Drawing.Point(24, 38);
            this.progressBar2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.progressBar2.Name = "progressBar2";
            this.progressBar2.Size = new System.Drawing.Size(209, 34);
            this.progressBar2.TabIndex = 12;
            // 
            // groupBoxEncrypt
            // 
            this.groupBoxEncrypt.Controls.Add(this.radioButton4);
            this.groupBoxEncrypt.Controls.Add(this.radioButton3);
            this.groupBoxEncrypt.Controls.Add(this.buttonEncrypt);
            this.groupBoxEncrypt.Controls.Add(this.textBoxEncryptedPassword);
            this.groupBoxEncrypt.Controls.Add(this.label1);
            this.groupBoxEncrypt.Location = new System.Drawing.Point(305, 210);
            this.groupBoxEncrypt.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBoxEncrypt.Name = "groupBoxEncrypt";
            this.groupBoxEncrypt.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBoxEncrypt.Size = new System.Drawing.Size(264, 175);
            this.groupBoxEncrypt.TabIndex = 11;
            this.groupBoxEncrypt.TabStop = false;
            this.groupBoxEncrypt.Text = "Szyfrowanie";
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Location = new System.Drawing.Point(11, 130);
            this.radioButton4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(184, 24);
            this.radioButton4.TabIndex = 15;
            this.radioButton4.TabStop = true;
            this.radioButton4.Text = "Wybierz miejsce zapisu";
            this.radioButton4.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Checked = true;
            this.radioButton3.Location = new System.Drawing.Point(11, 96);
            this.radioButton3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(215, 24);
            this.radioButton3.TabIndex = 14;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "Zapis w tym samym miejscu";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // buttonEncrypt
            // 
            this.buttonEncrypt.Enabled = false;
            this.buttonEncrypt.Location = new System.Drawing.Point(6, 45);
            this.buttonEncrypt.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.buttonEncrypt.Name = "buttonEncrypt";
            this.buttonEncrypt.Size = new System.Drawing.Size(112, 42);
            this.buttonEncrypt.TabIndex = 3;
            this.buttonEncrypt.Text = "Zaszyfruj ";
            this.buttonEncrypt.UseVisualStyleBackColor = true;
            this.buttonEncrypt.Click += new System.EventHandler(this.buttonEncrypt_MouseClick);
            // 
            // textBoxEncryptedPassword
            // 
            this.textBoxEncryptedPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.textBoxEncryptedPassword.Location = new System.Drawing.Point(124, 45);
            this.textBoxEncryptedPassword.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxEncryptedPassword.Multiline = true;
            this.textBoxEncryptedPassword.Name = "textBoxEncryptedPassword";
            this.textBoxEncryptedPassword.PasswordChar = '*';
            this.textBoxEncryptedPassword.Size = new System.Drawing.Size(109, 43);
            this.textBoxEncryptedPassword.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(153, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 19);
            this.label1.TabIndex = 3;
            this.label1.Text = "Hasło";
            // 
            // groupBoxDecrypt
            // 
            this.groupBoxDecrypt.Controls.Add(this.buttonDecrypt);
            this.groupBoxDecrypt.Controls.Add(this.label7);
            this.groupBoxDecrypt.Controls.Add(this.textBoxDecryptionPassword);
            this.groupBoxDecrypt.Controls.Add(this.label5);
            this.groupBoxDecrypt.Location = new System.Drawing.Point(305, 497);
            this.groupBoxDecrypt.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBoxDecrypt.Name = "groupBoxDecrypt";
            this.groupBoxDecrypt.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBoxDecrypt.Size = new System.Drawing.Size(264, 152);
            this.groupBoxDecrypt.TabIndex = 10;
            this.groupBoxDecrypt.TabStop = false;
            this.groupBoxDecrypt.Text = "Odszyfrowywania ";
            // 
            // buttonDecrypt
            // 
            this.buttonDecrypt.Enabled = false;
            this.buttonDecrypt.Location = new System.Drawing.Point(6, 45);
            this.buttonDecrypt.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.buttonDecrypt.Name = "buttonDecrypt";
            this.buttonDecrypt.Size = new System.Drawing.Size(95, 44);
            this.buttonDecrypt.TabIndex = 5;
            this.buttonDecrypt.Text = "Odszyfruj";
            this.buttonDecrypt.UseVisualStyleBackColor = true;
            this.buttonDecrypt.Click += new System.EventHandler(this.buttonDecrypt_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(153, 18);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 19);
            this.label7.TabIndex = 9;
            this.label7.Text = "Hasło";
            // 
            // textBoxDecryptionPassword
            // 
            this.textBoxDecryptionPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.textBoxDecryptionPassword.Location = new System.Drawing.Point(124, 45);
            this.textBoxDecryptionPassword.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxDecryptionPassword.Multiline = true;
            this.textBoxDecryptionPassword.Name = "textBoxDecryptionPassword";
            this.textBoxDecryptionPassword.PasswordChar = '*';
            this.textBoxDecryptionPassword.Size = new System.Drawing.Size(109, 43);
            this.textBoxDecryptionPassword.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 106);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 20);
            this.label5.TabIndex = 7;
            this.label5.Text = "label5";
            // 
            // treeView1
            // 
            this.treeView1.BackColor = System.Drawing.SystemColors.Menu;
            this.treeView1.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.treeView1.Location = new System.Drawing.Point(0, 199);
            this.treeView1.Margin = new System.Windows.Forms.Padding(2);
            this.treeView1.Name = "treeView1";
            treeNode1.Name = "Węzeł0";
            treeNode1.NodeFont = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            treeNode1.Text = "Dyski:";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode1});
            this.treeView1.Size = new System.Drawing.Size(300, 511);
            this.treeView1.TabIndex = 2;
            this.treeView1.BeforeExpand += new System.Windows.Forms.TreeViewCancelEventHandler(this.treeView1_BeforeExpand);
            this.treeView1.NodeMouseDoubleClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.treeView1_NodeMouseDoubleClick);
            // 
            // groupBoxDecompression
            // 
            this.groupBoxDecompression.Controls.Add(this.buttonDecompression);
            this.groupBoxDecompression.Location = new System.Drawing.Point(28, 190);
            this.groupBoxDecompression.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBoxDecompression.Name = "groupBoxDecompression";
            this.groupBoxDecompression.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBoxDecompression.Size = new System.Drawing.Size(364, 118);
            this.groupBoxDecompression.TabIndex = 15;
            this.groupBoxDecompression.TabStop = false;
            this.groupBoxDecompression.Text = "Dekopresja pliku";
            // 
            // buttonDecompression
            // 
            this.buttonDecompression.Enabled = false;
            this.buttonDecompression.Location = new System.Drawing.Point(15, 38);
            this.buttonDecompression.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.buttonDecompression.Name = "buttonDecompression";
            this.buttonDecompression.Size = new System.Drawing.Size(95, 50);
            this.buttonDecompression.TabIndex = 2;
            this.buttonDecompression.Text = "Wypakuj plik";
            this.buttonDecompression.UseVisualStyleBackColor = true;
            this.buttonDecompression.Click += new System.EventHandler(this.buttonDecompression_Click);
            // 
            // groupBoxPasswordStrength
            // 
            this.groupBoxPasswordStrength.Controls.Add(this.groupBoxPasswordConditions);
            this.groupBoxPasswordStrength.Controls.Add(this.label2);
            this.groupBoxPasswordStrength.Controls.Add(this.checkBoxShowPassword);
            this.groupBoxPasswordStrength.Controls.Add(this.textBoxPassword);
            this.groupBoxPasswordStrength.Controls.Add(this.labelResultPass);
            this.groupBoxPasswordStrength.Controls.Add(this.labelPassword);
            this.groupBoxPasswordStrength.Controls.Add(this.progressBarPassword);
            this.groupBoxPasswordStrength.Location = new System.Drawing.Point(28, 316);
            this.groupBoxPasswordStrength.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBoxPasswordStrength.Name = "groupBoxPasswordStrength";
            this.groupBoxPasswordStrength.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBoxPasswordStrength.Size = new System.Drawing.Size(387, 374);
            this.groupBoxPasswordStrength.TabIndex = 14;
            this.groupBoxPasswordStrength.TabStop = false;
            this.groupBoxPasswordStrength.Text = "Siła hasła";
            // 
            // groupBoxPasswordConditions
            // 
            this.groupBoxPasswordConditions.Controls.Add(this.labelHasLowerChar);
            this.groupBoxPasswordConditions.Controls.Add(this.labelHasSymbol);
            this.groupBoxPasswordConditions.Controls.Add(this.labelHasUpperChar);
            this.groupBoxPasswordConditions.Controls.Add(this.labelHasNumber);
            this.groupBoxPasswordConditions.Controls.Add(this.labelHasMiniMaxChars);
            this.groupBoxPasswordConditions.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBoxPasswordConditions.Location = new System.Drawing.Point(13, 182);
            this.groupBoxPasswordConditions.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBoxPasswordConditions.Name = "groupBoxPasswordConditions";
            this.groupBoxPasswordConditions.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBoxPasswordConditions.Size = new System.Drawing.Size(306, 184);
            this.groupBoxPasswordConditions.TabIndex = 15;
            this.groupBoxPasswordConditions.TabStop = false;
            this.groupBoxPasswordConditions.Text = "Warunki hasła";
            // 
            // labelHasLowerChar
            // 
            this.labelHasLowerChar.AutoSize = true;
            this.labelHasLowerChar.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelHasLowerChar.Location = new System.Drawing.Point(10, 36);
            this.labelHasLowerChar.Margin = new System.Windows.Forms.Padding(0);
            this.labelHasLowerChar.Name = "labelHasLowerChar";
            this.labelHasLowerChar.Size = new System.Drawing.Size(182, 19);
            this.labelHasLowerChar.TabIndex = 13;
            this.labelHasLowerChar.Text = "Hasło posiada małe litery";
            // 
            // labelHasSymbol
            // 
            this.labelHasSymbol.AutoSize = true;
            this.labelHasSymbol.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelHasSymbol.Location = new System.Drawing.Point(10, 141);
            this.labelHasSymbol.Margin = new System.Windows.Forms.Padding(0);
            this.labelHasSymbol.Name = "labelHasSymbol";
            this.labelHasSymbol.Size = new System.Drawing.Size(226, 19);
            this.labelHasSymbol.TabIndex = 14;
            this.labelHasSymbol.Text = "Hasło posiada symbol specialny";
            // 
            // labelHasUpperChar
            // 
            this.labelHasUpperChar.AutoSize = true;
            this.labelHasUpperChar.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelHasUpperChar.ForeColor = System.Drawing.Color.Black;
            this.labelHasUpperChar.Location = new System.Drawing.Point(10, 62);
            this.labelHasUpperChar.Margin = new System.Windows.Forms.Padding(0);
            this.labelHasUpperChar.Name = "labelHasUpperChar";
            this.labelHasUpperChar.Size = new System.Drawing.Size(180, 19);
            this.labelHasUpperChar.TabIndex = 11;
            this.labelHasUpperChar.Text = "Hasło posiada duże litery";
            // 
            // labelHasNumber
            // 
            this.labelHasNumber.AutoSize = true;
            this.labelHasNumber.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelHasNumber.Location = new System.Drawing.Point(10, 114);
            this.labelHasNumber.Margin = new System.Windows.Forms.Padding(0);
            this.labelHasNumber.Name = "labelHasNumber";
            this.labelHasNumber.Size = new System.Drawing.Size(144, 19);
            this.labelHasNumber.TabIndex = 10;
            this.labelHasNumber.Text = "Hasło posiada cyfry";
            // 
            // labelHasMiniMaxChars
            // 
            this.labelHasMiniMaxChars.AutoSize = true;
            this.labelHasMiniMaxChars.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelHasMiniMaxChars.Location = new System.Drawing.Point(10, 88);
            this.labelHasMiniMaxChars.Margin = new System.Windows.Forms.Padding(0);
            this.labelHasMiniMaxChars.Name = "labelHasMiniMaxChars";
            this.labelHasMiniMaxChars.Size = new System.Drawing.Size(201, 19);
            this.labelHasMiniMaxChars.TabIndex = 12;
            this.labelHasMiniMaxChars.Text = "Długość hasła min 8 znaków";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(11, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 19);
            this.label2.TabIndex = 4;
            this.label2.Text = "Siła Hasła";
            // 
            // checkBoxShowPassword
            // 
            this.checkBoxShowPassword.AutoSize = true;
            this.checkBoxShowPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.checkBoxShowPassword.Location = new System.Drawing.Point(133, 29);
            this.checkBoxShowPassword.Margin = new System.Windows.Forms.Padding(1);
            this.checkBoxShowPassword.Name = "checkBoxShowPassword";
            this.checkBoxShowPassword.Size = new System.Drawing.Size(122, 24);
            this.checkBoxShowPassword.TabIndex = 9;
            this.checkBoxShowPassword.Text = "Pokaż hasło";
            this.checkBoxShowPassword.UseVisualStyleBackColor = true;
            this.checkBoxShowPassword.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.BackColor = System.Drawing.SystemColors.Window;
            this.textBoxPassword.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.textBoxPassword.Location = new System.Drawing.Point(15, 64);
            this.textBoxPassword.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxPassword.MaxLength = 29;
            this.textBoxPassword.Multiline = true;
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.PasswordChar = '*';
            this.textBoxPassword.Size = new System.Drawing.Size(265, 60);
            this.textBoxPassword.TabIndex = 3;
            this.textBoxPassword.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // labelResultPass
            // 
            this.labelResultPass.AutoSize = true;
            this.labelResultPass.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelResultPass.Location = new System.Drawing.Point(187, 165);
            this.labelResultPass.Name = "labelResultPass";
            this.labelResultPass.Size = new System.Drawing.Size(62, 19);
            this.labelResultPass.TabIndex = 8;
            this.labelResultPass.Text = "Wynik:";
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelPassword.Location = new System.Drawing.Point(11, 139);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(56, 19);
            this.labelPassword.TabIndex = 6;
            this.labelPassword.Text = "Wynik";
            // 
            // progressBarPassword
            // 
            this.progressBarPassword.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.progressBarPassword.Location = new System.Drawing.Point(74, 132);
            this.progressBarPassword.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.progressBarPassword.Maximum = 25;
            this.progressBarPassword.Name = "progressBarPassword";
            this.progressBarPassword.Size = new System.Drawing.Size(206, 29);
            this.progressBarPassword.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.progressBarPassword.TabIndex = 5;
            // 
            // groupBoxCompression
            // 
            this.groupBoxCompression.Controls.Add(this.radioButtonZip);
            this.groupBoxCompression.Controls.Add(this.checkBoxDeleteFile);
            this.groupBoxCompression.Controls.Add(this.label3);
            this.groupBoxCompression.Controls.Add(this.radioButtonlz77);
            this.groupBoxCompression.Controls.Add(this.buttonCompression);
            this.groupBoxCompression.Location = new System.Drawing.Point(28, 6);
            this.groupBoxCompression.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBoxCompression.Name = "groupBoxCompression";
            this.groupBoxCompression.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBoxCompression.Size = new System.Drawing.Size(364, 176);
            this.groupBoxCompression.TabIndex = 13;
            this.groupBoxCompression.TabStop = false;
            this.groupBoxCompression.Text = "Kompresja pliku";
            // 
            // radioButtonZip
            // 
            this.radioButtonZip.AutoSize = true;
            this.radioButtonZip.Checked = true;
            this.radioButtonZip.Location = new System.Drawing.Point(139, 72);
            this.radioButtonZip.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.radioButtonZip.Name = "radioButtonZip";
            this.radioButtonZip.Size = new System.Drawing.Size(116, 24);
            this.radioButtonZip.TabIndex = 18;
            this.radioButtonZip.TabStop = true;
            this.radioButtonZip.Text = "Algorytm zip";
            this.radioButtonZip.UseVisualStyleBackColor = true;
            // 
            // checkBoxDeleteFile
            // 
            this.checkBoxDeleteFile.AutoSize = true;
            this.checkBoxDeleteFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.checkBoxDeleteFile.Location = new System.Drawing.Point(133, 37);
            this.checkBoxDeleteFile.Margin = new System.Windows.Forms.Padding(1);
            this.checkBoxDeleteFile.Name = "checkBoxDeleteFile";
            this.checkBoxDeleteFile.Size = new System.Drawing.Size(200, 24);
            this.checkBoxDeleteFile.TabIndex = 16;
            this.checkBoxDeleteFile.Text = "Usun plik po kompresji";
            this.checkBoxDeleteFile.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 20);
            this.label3.TabIndex = 15;
            this.label3.Text = "label3";
            // 
            // radioButtonlz77
            // 
            this.radioButtonlz77.AutoSize = true;
            this.radioButtonlz77.Location = new System.Drawing.Point(139, 104);
            this.radioButtonlz77.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.radioButtonlz77.Name = "radioButtonlz77";
            this.radioButtonlz77.Size = new System.Drawing.Size(126, 24);
            this.radioButtonlz77.TabIndex = 14;
            this.radioButtonlz77.Text = "Algorytm Lz77";
            this.radioButtonlz77.UseVisualStyleBackColor = true;
            // 
            // buttonCompression
            // 
            this.buttonCompression.Enabled = false;
            this.buttonCompression.Location = new System.Drawing.Point(11, 37);
            this.buttonCompression.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.buttonCompression.Name = "buttonCompression";
            this.buttonCompression.Size = new System.Drawing.Size(95, 50);
            this.buttonCompression.TabIndex = 2;
            this.buttonCompression.Text = "Dodaj do archiwum ";
            this.buttonCompression.UseVisualStyleBackColor = true;
            this.buttonCompression.Click += new System.EventHandler(this.buttonCompression_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripProgressBar1,
            this.toolStripStatusLabel1,
            this.toolStripProgressBar2,
            this.toolStripStatusLabel2});
            this.statusStrip1.Location = new System.Drawing.Point(0, 0);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.statusStrip1.Size = new System.Drawing.Size(1032, 50);
            this.statusStrip1.TabIndex = 14;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripProgressBar1
            // 
            this.toolStripProgressBar1.Name = "toolStripProgressBar1";
            this.toolStripProgressBar1.Padding = new System.Windows.Forms.Padding(2);
            this.toolStripProgressBar1.Size = new System.Drawing.Size(94, 42);
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Padding = new System.Windows.Forms.Padding(5);
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(117, 44);
            this.toolStripStatusLabel1.Text = "Status operacji";
            // 
            // toolStripProgressBar2
            // 
            this.toolStripProgressBar2.Name = "toolStripProgressBar2";
            this.toolStripProgressBar2.Size = new System.Drawing.Size(100, 42);
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(0, 44);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Error;
            this.notifyIcon1.BalloonTipText = "Cos poszło nie tak ";
            this.notifyIcon1.BalloonTipTitle = "Error";
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "CryptoAndCompression";
            this.notifyIcon1.Visible = true;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.UsunToolStripMenuItem});
            this.contextMenuStrip2.Name = "contextMenuStrip2";
            this.contextMenuStrip2.Size = new System.Drawing.Size(169, 28);
            // 
            // UsunToolStripMenuItem
            // 
            this.UsunToolStripMenuItem.Name = "UsunToolStripMenuItem";
            this.UsunToolStripMenuItem.Size = new System.Drawing.Size(168, 24);
            this.UsunToolStripMenuItem.Text = "Usuń element";
            // 
            // contextMenuStrip3
            // 
            this.contextMenuStrip3.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip3.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.usunToolStripMenuItem1});
            this.contextMenuStrip3.Name = "contextMenuStrip3";
            this.contextMenuStrip3.Size = new System.Drawing.Size(115, 28);
            // 
            // usunToolStripMenuItem1
            // 
            this.usunToolStripMenuItem1.Name = "usunToolStripMenuItem1";
            this.usunToolStripMenuItem1.Size = new System.Drawing.Size(114, 24);
            this.usunToolStripMenuItem1.Text = "Usun ";
            this.usunToolStripMenuItem1.Click += new System.EventHandler(this.usunToolStripMenuItem1_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.WorkerReportsProgress = true;
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            this.backgroundWorker1.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorker1_ProgressChanged);
            this.backgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker1_RunWorkerCompleted);
            // 
            // toolStripContainer1
            // 
            // 
            // toolStripContainer1.BottomToolStripPanel
            // 
            this.toolStripContainer1.BottomToolStripPanel.Controls.Add(this.statusStrip1);
            // 
            // toolStripContainer1.ContentPanel
            // 
            this.toolStripContainer1.ContentPanel.AutoScroll = true;
            this.toolStripContainer1.ContentPanel.Controls.Add(this.splitContainer1);
            this.toolStripContainer1.ContentPanel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.toolStripContainer1.ContentPanel.Size = new System.Drawing.Size(1032, 710);
            this.toolStripContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolStripContainer1.Location = new System.Drawing.Point(0, 0);
            this.toolStripContainer1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.toolStripContainer1.Name = "toolStripContainer1";
            this.toolStripContainer1.Size = new System.Drawing.Size(1032, 791);
            this.toolStripContainer1.TabIndex = 3;
            this.toolStripContainer1.Text = "toolStripContainer1";
            // 
            // toolStripContainer1.TopToolStripPanel
            // 
            this.toolStripContainer1.TopToolStripPanel.Controls.Add(this.menuStrip1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1032, 791);
            this.Controls.Add(this.toolStripContainer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.Text = "KryptoAndCompression";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBoxEncrypt.ResumeLayout(false);
            this.groupBoxEncrypt.PerformLayout();
            this.groupBoxDecrypt.ResumeLayout(false);
            this.groupBoxDecrypt.PerformLayout();
            this.groupBoxDecompression.ResumeLayout(false);
            this.groupBoxPasswordStrength.ResumeLayout(false);
            this.groupBoxPasswordStrength.PerformLayout();
            this.groupBoxPasswordConditions.ResumeLayout(false);
            this.groupBoxPasswordConditions.PerformLayout();
            this.groupBoxCompression.ResumeLayout(false);
            this.groupBoxCompression.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.contextMenuStrip2.ResumeLayout(false);
            this.contextMenuStrip3.ResumeLayout(false);
            this.toolStripContainer1.BottomToolStripPanel.ResumeLayout(false);
            this.toolStripContainer1.BottomToolStripPanel.PerformLayout();
            this.toolStripContainer1.ContentPanel.ResumeLayout(false);
            this.toolStripContainer1.TopToolStripPanel.ResumeLayout(false);
            this.toolStripContainer1.TopToolStripPanel.PerformLayout();
            this.toolStripContainer1.ResumeLayout(false);
            this.toolStripContainer1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem opcjeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dodajPlikToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem resetToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem informacjeToolStripMenuItem;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxEncryptedPassword;
        private System.Windows.Forms.Button buttonEncrypt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.Button buttonCompression;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Button buttonDecrypt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxDecryptionPassword;
        private System.Windows.Forms.ProgressBar progressBarPassword;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
        private System.Windows.Forms.ToolStripMenuItem UsunToolStripMenuItem;
        private System.Windows.Forms.CheckBox checkBoxShowPassword;
        private System.Windows.Forms.Label labelResultPass;
        private System.Windows.Forms.GroupBox groupBoxDecrypt;
        private System.Windows.Forms.GroupBox groupBoxEncrypt;
        private System.Windows.Forms.GroupBox groupBoxCompression;
        private System.Windows.Forms.GroupBox groupBoxPasswordStrength;
        private System.Windows.Forms.RadioButton radioButtonlz77;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.ListView listViewFiles;
        private System.Windows.Forms.ColumnHeader patch;
        private System.Windows.Forms.ColumnHeader rozmiar;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip3;
        private System.Windows.Forms.ToolStripMenuItem usunToolStripMenuItem1;
        private System.Windows.Forms.ProgressBar progressBar2;
        private System.Windows.Forms.Timer timer1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripProgressBar toolStripProgressBar1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripContainer toolStripContainer1;
        private System.Windows.Forms.GroupBox groupBoxDecompression;
        private System.Windows.Forms.Button buttonDecompression;
        private System.Windows.Forms.Label labelHasNumber;
        private System.Windows.Forms.Label labelHasMiniMaxChars;
        private System.Windows.Forms.Label labelHasUpperChar;
        private System.Windows.Forms.Label labelHasLowerChar;
        private System.Windows.Forms.Label labelHasSymbol;
        private System.Windows.Forms.GroupBox groupBoxPasswordConditions;
        private Label label3;
        private ToolStripProgressBar toolStripProgressBar2;
        private ToolStripStatusLabel toolStripStatusLabel2;
        private CheckBox checkBoxDeleteFile;
        private RadioButton radioButtonZip;
        private FolderBrowserDialog folderBrowserDialog1;
        private SaveFileDialog saveFileDialog2;
    }
}


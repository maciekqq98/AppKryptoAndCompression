
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.IO.Compression;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using WindowsFormsAppKryptoAndCompression.Compression_algorytm;
using AppKryptoAndCompression.Compression_zip;
using Label = System.Windows.Forms.Label;



namespace AppKryptoAndCompression
{
    public partial class Form1 : Form
    {
        public List<System.IO.FileInfo> FileList = new List<System.IO.FileInfo>();
        private AESRJ encrypter;
        private CompressionLz77 compressor;
        private CompressionZip compressionZip;

        public Form1()
        {
            InitializeComponent();

            this.Load += Form1_Load;
            encrypter = new AESRJ();
            compressor = new CompressionLz77();  

        }

        private void Form1_Load(object sender, EventArgs e)
        {


            Content();

        }
        private void dodajPlikToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog1.ValidateNames = false;
            openFileDialog1.CheckFileExists = false;
            openFileDialog1.CheckPathExists = true;
            openFileDialog1.Multiselect = true;
            openFileDialog1.Title = "Wybierz plik(i)";
            // Always default to Folder Selection.
            //openFileDialog1.FileName = "Folder Selection.";
            DialogResult result = openFileDialog1.ShowDialog(); // zeby sie dwa razy nie otwierało przypisany result do zminnej 
            if (result == DialogResult.OK)
            {

                foreach (String file in openFileDialog1.FileNames)
                {
                    try
                    {
                        ListViewItem item = new ListViewItem(file);
                        string roz = FileSizes(file);
                        item.SubItems.Add(roz); // dodaje rozmiar pliku
                        listViewFiles.Items.Add(item);// dodaje nazwe 
                        buttonEncrypt.Enabled = true;

                    } //działa chyba dobrze tak jak chciałem 

                    catch (Exception ex)
                    {
                        MessageBox.Show("Błąd: nie można odczytać pliku z dysku."
                            + ex.Message);
                    }
                }
 
            }
            else if (result == DialogResult.Cancel)
            {
                // Cancel
            }

        }

        private void buttonEncrypt_MouseClick(object sender, EventArgs e)
        {

            buttonEncrypt.Enabled = false;
            bool ZapisPoSzyfrowaniu = radioButton4.Checked;

            if (!(this.listViewFiles.Items.Count > 0))
            {
                MessageBox.Show("Pusta Lista");
            }
            else
            {
                if (ZapisPoSzyfrowaniu)
                {
                    this.buttonEncrypt.Enabled = false;
                    this.buttonDecrypt.Enabled = false;   
                    using (var fileDialog = new SaveFileDialog())
                    {
                        fileDialog.Filter = @"All files (*.*)|*.*|DOKUMENTY|*.txt;*.docx;*.doc;*.pdf*.xls;*.xlsx;*.pptx;*.ppt|Text File (.txt)|*.txt|Word File (.docx ,.doc)|*.docx;*.doc|PDF (.pdf)|*.pdf|Spreadsheet (.xls ,.xlsx)|  *.xls ;*.xlsx|Presentation (.pptx ,.ppt)|*.pptx;*.ppt|Paczkizip_rar(.zip, .rar)|*.zip;*.rar;";
                        fileDialog.FilterIndex = 1;
                        fileDialog.RestoreDirectory = true;

                        if (fileDialog.ShowDialog() == DialogResult.OK)
                        {
                            List<String> arguments = new List<String>();
                            arguments.Add("Encryption");
                            var FileNameEncryption = listViewFiles.Items.Cast<ListViewItem>()
                                .Where(T => T.Selected)
                                .Select(T => T.Text)
                                .First();
 
                            arguments.Add(FileNameEncryption);
                            
                            arguments.Add(fileDialog.FileName.ToString());

                            backgroundWorker1.RunWorkerAsync(arguments);

                            //MessageBox.Show("Proces" + nameFilevar
                                   // + " szyfrowania zakonczył sie");
                            toolStripStatusLabel1.Text = "Proces szyfrowania trwa";
                            DeleteFromListview();
                            // treeView1.Nodes.Clear();
                            //Content();
                        }
                        else
                        {
                            // jeśli użytkownik zamknął okno wyboru nowej ścieżki, operacje są anulowane
                            toolStripStatusLabel1.Text = " Proces szyfrowania anulowany";
                            return;
                        }
                    }
                }
                else
                {
                   
                    this.buttonEncrypt.Enabled = false;
                    this.buttonDecrypt.Enabled = false;
                    List<String> arguments = new List<String>();
                    arguments.Add("Encryption");
                    var list = listViewFiles.Items.Cast<ListViewItem>()
                        .Where(T => T.Selected)
                        .Select(T => T.Text)
                        .First();
                    arguments.Add(list);
                    
                    backgroundWorker1.RunWorkerAsync(arguments);

                    toolStripStatusLabel1.Text = "Proces szyfrowania trwa";
                    DeleteFromListview();

                }
            }   
        }


        private void buttonDecrypt_Click(object sender, EventArgs e) //Odszyfrowanie 
        {

           saveFileDialog1.Filter = @"All files (*.*)|*.*|DOKUMENTY|*.txt;*.docx;*.doc;*.pdf*.xls;*.xlsx;*.pptx;*.ppt|Text File (.txt)|*.txt|Word File (.docx ,.doc)|*.docx;*.doc|PDF (.pdf)|*.pdf|Spreadsheet (.xls ,.xlsx)|  *.xls ;*.xlsx|Presentation (.pptx ,.ppt)|*.pptx;*.ppt|Paczkizip_rar(.zip, .rar)|*.zip;*.rar;";
           saveFileDialog1.FilterIndex = 1;
           saveFileDialog1.OverwritePrompt = false; 
           saveFileDialog1.RestoreDirectory = true;

            string extn = "txt";
            this.buttonEncrypt.Enabled = false;
            if (listViewFiles.Items.Cast<ListViewItem>()
                    .Where(T => T.Selected).ToList().Count()<=0)
            {
                notifyIcon1.BalloonTipText = "Nie wybrano pliku Zaznacz plik";
                notifyIcon1.ShowBalloonTip(3000);

            }
            else
            {
                var listFileName = listViewFiles.Items.Cast<ListViewItem>()
                   .Where(T => T.Selected)
                   .Select(T => T.Text).First(); 
                
                    if (listFileName.EndsWith(".aes"))
                    {
                        string varNameFile = listFileName[0].ToString();
                        string NameFile = varNameFile.Remove(varNameFile.Length - 4);

                        FileInfo fi = new FileInfo(NameFile);
                        extn = fi.Extension;
                        saveFileDialog1.DefaultExt = extn;
                    }
                    else { } // gdy  uzytkownik wybierze rozszerzenie

                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {

                    List<String> arguments = new List<String>();
                    arguments.Add("Decryption");
                    arguments.Add(listFileName);
                    arguments.Add(saveFileDialog1.FileName);

                    backgroundWorker1.RunWorkerAsync(arguments);
                    //string wynikMetodyDecryptFile = DecryptFile(@"" + listFileName[0], saveFileDialog1.FileName,backgroundWorker1);
                    toolStripStatusLabel1.Text = "Proces Deszyfrowania trwa";
                    DeleteFromListview();
                }
            }

               
        }

  
        private void Content() // dodaniie do drzewa plików
        {
            //get a list of the drives
            string[] drives = Environment.GetLogicalDrives();
            drives = drives.Skip(1).ToArray(); // skipuje dysk c dla bezpieczenstwa 
            foreach (string drive in drives)
            {
                DriveInfo di = new DriveInfo(drive);
                int driveImage;

                switch (di.DriveType)    //set the drive's icon
                {
                    case DriveType.CDRom:
                        driveImage = 3;
                        break;
                    case DriveType.Network:
                        driveImage = 6;
                        break;
                    case DriveType.NoRootDirectory:
                        driveImage = 8;
                        break;
                    case DriveType.Unknown:
                        driveImage = 8;
                        break;
                    default:
                        driveImage = 2;
                        break;
                }

                TreeNode node = new TreeNode(drive.Substring(0, 1), driveImage, driveImage);
                node.Tag = drive;

                if (di.IsReady == true)
                    node.Nodes.Add("...");

                treeView1.Nodes.Add(node);
                
            }
        }
        
    

        private void treeView1_BeforeExpand(object sender, TreeViewCancelEventArgs e)
        {
            if (e.Node is not null)
            {
                if (e.Node.Nodes.Count > 0)
                {
                    if (e.Node.Nodes[0].Text == "..." && e.Node.Nodes[0].Tag == null)
                    {
                        e.Node.Nodes.Clear();

                        //get the list of sub direcotires

                        string[] dirs = Directory.GetDirectories(e.Node.Tag.ToString());

                        //add files of rootdirectory
                        DirectoryInfo rootDir = new DirectoryInfo(e.Node.Tag.ToString());
                        foreach (var file in rootDir.GetFiles())
                        {
                            TreeNode n = new TreeNode(file.FullName, 13, 13);
                            //fullname
                            e.Node.Nodes.Add(n);
                        }

                        foreach (string dir in dirs)
                        {
                            DirectoryInfo di = new DirectoryInfo(dir);
                            TreeNode node = new TreeNode(di.FullName, 0, 1);

                            try
                            {
                                //keep the directory's full path in the tag for use later
                                node.Tag = dir;

                                //if the directory has sub directories add the place holder
                                if (di.GetDirectories().Count() > 0)
                                    node.Nodes.Add(null, "...", 0, 0);

                                foreach (var file in di.GetFiles())
                                {
                                    TreeNode n = new TreeNode(file.FullName, 13, 13);
                                    node.Nodes.Add(n);
                                }

                            }
                            catch (UnauthorizedAccessException)
                            {
                                //display a locked folder icon
                                node.ImageIndex = 12;
                                node.SelectedImageIndex = 12;
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show(ex.Message, "DirectoryLister",
                                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            finally
                            {
                                e.Node.Nodes.Add(node);
                            }
                        }
                    }
                }
            }
        }

        private void resetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            treeView1.Nodes.Clear();
            textBoxEncryptedPassword.Clear();
            textBoxPassword.Clear();
            textBoxDecryptionPassword.Clear();
            checkBoxShowPassword.Checked = false;  
            progressBarPassword.Value = 0;
            toolStripProgressBar1.Value = 0;
            listViewFiles.Items.Clear();
            Content();
        }


        private void treeView1_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            try
            {
                
                FileAttributes attr = System.IO.File.GetAttributes(treeView1.SelectedNode.Text);

                if (attr.HasFlag(FileAttributes.Directory))
                {
                    // MessageBox.Show("to jest folder");
                }
                else
                {   //MessageBox.Show("to jest plik"); 
                    string name = Path.GetFullPath(treeView1.SelectedNode.Text);
                    ListViewItem item = new ListViewItem(name);
                    string roz = FileSizes(treeView1.SelectedNode.Text);
                    item.SubItems.Add(roz); // dodaje rozmiar pliku
                    listViewFiles.Items.Add(item);// dodaje nazwe    
                    buttonEncrypt.Enabled = true;
                    buttonDecrypt.Enabled = true;
                    buttonCompression.Enabled = true;
                    buttonDecompression.Enabled = true;
                }
            }
            catch (FileNotFoundException edir)
            {
                MessageBox.Show("Directory not found: " + edir.Message);
               
            }
        }
       

        private int ValidatePassword(string password)
        {
            
            var input = password;
            var hasNumber = new Regex(@"[0-9]+");
            var hasUpperChar = new Regex(@"[A-Z]+");
            var hasMiniMaxChars = new Regex(@".{8,15}");
            var hasLowerChar = new Regex(@"[a-z]+");
            var hasSymbols = new Regex(@"[!@#$%^&*()_+=\[{\]};:<>|./?,-]");
            int strong = 0;

            if (hasLowerChar.IsMatch(input))
            {
                strong += 5;
                labelHasLowerChar.ForeColor = Color.Green;
                labelHasLowerChar.Text = "Hasło posiada małe litery \x2714";
            }
             if (hasUpperChar.IsMatch(input))
            {
                labelHasUpperChar.ForeColor = Color.Green;
                labelHasUpperChar.Text = "Hasło posiada duże litery \x2714";
                strong += 5;
            }
             if (hasMiniMaxChars.IsMatch(input))
            {
                labelHasMiniMaxChars.ForeColor = Color.Green;
                labelHasMiniMaxChars.Text = "Długość hasła min 8 znaków\x2714";
                strong += 5;
            }
             if (hasNumber.IsMatch(input))
            {
                labelHasNumber.ForeColor = Color.Green;
                labelHasNumber.Text = "Hasło posiada cyfry \x2714";
                 strong += 5;
            }

             if (hasSymbols.IsMatch(input))
            {
                labelHasSymbol.ForeColor = Color.Green;
                labelHasSymbol.Text = "Hasło posiada symbol specialny \x2714";
                strong += 5;
            }
            
            return strong;
        }


        private void resetLabel()
        {
            foreach (Control c in this.groupBoxPasswordConditions.Controls)
            {
                if (c is Label)
                {
                    c.ForeColor = Color.Black;
                }
            }
           
        }

        private void textBox2_TextChanged(object sender, EventArgs e) // pasek siły hsasł
        {
            //int n = textBoxPassword.Text.Length;
           
            this.textBoxPassword.AutoSize = true;
           
            resetLabel();
            if(ValidatePassword(textBoxPassword.Text.ToString())<=10)
            {
                labelResultPass.Text = " Hałso :Słabe";

            }
            else if(ValidatePassword(textBoxPassword.Text.ToString()) <=15)
            {
                labelResultPass.Text = " Hałso :Średnie";
            }
            else if(ValidatePassword(textBoxPassword.Text.ToString()) <= 25)
            {
                labelResultPass.Text = "Hałso :Mocne";
            }
            progressBarPassword.Value =ValidatePassword(textBoxPassword.Text.ToString());
              
        }

        private void usunToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            DeleteFromListview(); // usuwa z listy ViewList
        }

        

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBoxShowPassword.Checked is true)
            {
                textBoxPassword.PasswordChar = '\0';
            }
            else
            {
                textBoxPassword.PasswordChar = '*';
            }
        }

        private void buttonCompression_Click(object sender, EventArgs e)
        {
            //List<int> selectedIndices = listView1.SelectedIndices.Cast<int>().ToList();

            if (radioButtonZip.Checked is false)
            {
                if (!(this.listViewFiles.Items.Count > 0))
                {
                    MessageBox.Show("Pusta Lista");
                }
                else
                {

                    List<String> arguments = new List<String>();
                    arguments.Add("Compress");
                    var fileName = listViewFiles.Items.Cast<ListViewItem>()
                        .Where(T => T.Selected)
                        .Select(T => T.Text)
                        .First();
                    arguments.Add(fileName);
                   // foreach (var item in ss)
                   // {
                    //    arguments.Add(item);
                    //}
                    //compressor.CompressFile(item.ToString(),item.ToString());
                    backgroundWorker1.RunWorkerAsync(arguments);
                    toolStripStatusLabel1.Text = "Proces Kompresji trwa";
                    buttonCompression.Enabled = false;
                }
            }
            else
            {
                List<String> arguments = new List<String>();
                arguments.Add("CompressZip");
                var fileName = listViewFiles.Items.Cast<ListViewItem>()
                    .Where(T => T.Selected)
                    .Select(T => T.Text)
                    .First();
                arguments.Add(fileName);
           
                backgroundWorker1.RunWorkerAsync(arguments);
                toolStripStatusLabel1.Text = "Proces Kompresji ZIP trwa";
                buttonCompression.Enabled = false;
               
            }
        
        }
        private void buttonDecompression_Click(object sender, EventArgs e)
        {
            if (!(this.listViewFiles.Items.Count > 0))
            {
                MessageBox.Show("Pusta Lista");
            }
            else
            {
                var fileName = listViewFiles.Items.Cast<ListViewItem>()
                    .Where(T => T.Selected)
                    .Select(T => T.Text).First();

                if (fileName.EndsWith(".lz77"))
                {
                    MessageBox.Show("LZ77 plik");
                    List<String> arguments = new List<String>();
                    arguments.Add("DeCompress");
                    
                    arguments.Add(fileName);

                    backgroundWorker1.RunWorkerAsync(arguments);
                    toolStripStatusLabel1.Text = "Proces Dekompresji trwa";
                    buttonDecompression.Enabled = false;
                }
                else if(fileName.EndsWith(".zip"))
                {
                    MessageBox.Show("Zip plik");
                    List<String> arguments = new List<String>();
                    arguments.Add("DeCompressZip");
                    arguments.Add(fileName);

                    backgroundWorker1.RunWorkerAsync(arguments);
                    toolStripStatusLabel1.Text = "Proces Dekompresji ZIP trwa";
                    buttonDecompression.Enabled = false;
                }
                else
                {
                    MessageBox.Show("Error: zły plik ");
                }
            }
        }


        private void DeleteFromListview()
        {
            listViewFiles.Items.Cast<ListViewItem>()
                .Where(T => T.Selected)
                .Select(T => T.Index)
                .ToList()
                .ForEach(T => listViewFiles.Items.RemoveAt(T));
        }
        

        private string FileSizes(string path)
        {

            long size = 0;
            FileInfo file;

            file = new FileInfo(path);
            size += file.Length;
            
            string unit;

            if (size > 1073741824)
            {
                size /= 1073741824;
                unit = "GB";
            }
            else if (size > 1048576)
            {
                size /= 1048576;
                unit = "MB";
            }
            else if (size > 1024)
            {
                size /= 1024;
                unit = "KB";
            }
            else
            {
                unit = "B";
            }
            return $"{size} {unit}";

            
        }

        private void listViewFiles_MouseClick(object sender, MouseEventArgs e) // usuwanie z listy 
        {
            listViewFiles.ContextMenuStrip = contextMenuStrip3;
            //listView1.MouseUp += new MouseEventHandler(listView1_MouseClick);
            
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            string filepath= e.Argument.ToString();
            List<String> genericlist = e.Argument as List<String>;
            if (backgroundWorker1.CancellationPending == true)
            {
                e.Cancel = true;
                return;
            }
            else
            {
                string testStringEncrypted;
                string testStringDecrypt;
                testStringEncrypted = textBoxEncryptedPassword.Text.ToString();
                testStringDecrypt = textBoxDecryptionPassword.Text.ToString();
                // byte[] key = CreatingPassword(testString);
                //MessageBox.Show(key[1].ToString())
                switch (genericlist[0])
                {

                    case "Encryption":
                        if (radioButton4.Checked == true)
                        {

                            encrypter.EncryptFile(@"" + genericlist[1], genericlist[2], testStringEncrypted, backgroundWorker1);
                            
                            e.Result = "szyfrowanie ukonczone";
                        }
                        else
                        {
                            encrypter.EncryptFile(@"" + genericlist[1], genericlist[1], @"" + testStringEncrypted, backgroundWorker1);
                             e.Result = "szyfrowanie ukonczone";
                            MessageBox.Show(testStringEncrypted);
                        }
                        
                        break;
                    case "Decryption":

                       string wynikMetodyDecryptFile = encrypter.DecryptFile(@"" + genericlist[1], genericlist[2], backgroundWorker1, testStringDecrypt);
                        
                        if (wynikMetodyDecryptFile.Equals("OK"))
                        {

                            e.Result = $"Odszyfrowywanie pliku {genericlist[1]} ukonczone";

                        }
                        else if (wynikMetodyDecryptFile.Equals("repeat"))
                        {
                            e.Result = "Wybrałes niezszyfrowany plik wybierz plik z rozszerzeniem .aes";
                            notifyIcon1.BalloonTipText = "Wybrałes niezszyfrowany plik wybierz plik z rozszerzeniem .aes";
                            notifyIcon1.ShowBalloonTip(3000);
                            File.Delete(saveFileDialog1.FileName);
                            // MessageBox.Show("Wybrałes niezszyfrowany plik wybierz plik z rozszerzeniem .aes");

                        }
                        else if (wynikMetodyDecryptFile.Equals("error"))
                        {
                            e.Result = "Error";
                            notifyIcon1.BalloonTipText = "Error";
                            notifyIcon1.ShowBalloonTip(3000);
                            File.Delete(saveFileDialog1.FileName); // usuwany jest pusty utworzony plik 

                        }
                        break;
                    case "Compress":

                        compressor.CompressFileLz77(genericlist[1], genericlist[1], backgroundWorker1);
                        
                        e.Result = "Kompresja zakonczona";
                        if (checkBoxDeleteFile.Checked is true)
                        {

                            File.Delete(genericlist[1]);
                        }

                        break;
                    case "CompressZip":


                        compressionZip.CompressFileZip(genericlist[1],backgroundWorker1);
                        e.Result = "Kompresja ZIP zakonczona";
                        if (checkBoxDeleteFile.Checked is true)
                        {

                            File.Delete(genericlist[1]);
                        }

                        break;
                    case "DeCompress":

                        compressor.DecompressFileLz77(genericlist[1], genericlist[1], backgroundWorker1);
                        e.Result = "Dekompresja zakonczona ";

                        break;
                    case "DeCompressZip":

                       compressionZip.DeCompressFileZip(genericlist[1], backgroundWorker1);
                        e.Result = "Dekompresja ZIP zakonczona ";

                        break;
                    case null:
                        return;
                }
                
            }

        }
 
        private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            // progressBar2.Value = e.ProgressPercentage;
             //toolStripProgressBar1.Value= e.ProgressPercentage;
            //label10.Text = e.ProgressPercentage.ToString();
            if(e.ProgressPercentage == 1)
            {
                toolStripProgressBar2.Style = ProgressBarStyle.Marquee;
                toolStripProgressBar2.MarqueeAnimationSpeed = 100;
            }
            else
            {
                progressBar2.Value = e.ProgressPercentage;
                toolStripProgressBar1.Value = e.ProgressPercentage;
            }
            
            //label3.Text= e.ProgressPercentage.ToString();
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
           

            if (e.Cancelled == true)
            {
                MessageBox.Show("Operation stopped");
                buttonEncrypt.Enabled = true;
               
            }
            else if (e.Error != null)
            {
                MessageBox.Show("Error: " + e.Error.Message);
                buttonEncrypt.Enabled = true;
                
            }
            else
            {
                if (e.Result is not null)
                {
                    MessageBox.Show(e.Result.ToString());
                    toolStripStatusLabel1.Text = e.Result.ToString();
                }
                progressBar2.Value = 0;
                toolStripProgressBar1.Value = 0;
                this.buttonEncrypt.Enabled = true;
                this.buttonDecrypt.Enabled = true;
                treeView1.Nodes.Clear();
                Content();
                textBoxEncryptedPassword.Clear();
                textBoxDecryptionPassword.Clear();
                toolStripProgressBar2.Style = ProgressBarStyle.Continuous;

                buttonCompression.Enabled = true;
                buttonDecompression.Enabled = true;
            }
        }

        //kom

    }
}

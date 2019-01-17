using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AddressBook
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            PersonPic.AllowDrop = true;
            this.BackColor = Color.Black;
            this.TransparencyKey = Color.Black;
        }

        private void PersonPic_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd =new OpenFileDialog();
            ofd.Filter = "JPG (*.jpg,*.jpeg)|*.jpg;*.jpeg";
            if (ofd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                var fileToOpen = ofd.FileName;
                MessageBox.Show(fileToOpen);
                PersonPic.ImageLocation = fileToOpen;
            }
        }

        private void btnSaveChanges_Click(object sender, EventArgs e)
        {
            MaterialTabController m = new MaterialTabController();
            this.Hide();
            m.Show();
        }

        private void btnAddContact_Click(object sender, EventArgs e)
        {

        }

        private void btnRemove_Click(object sender, EventArgs e)
        {

        }

        private void PersonPic_DragDrop(object sender, DragEventArgs e)
        {
            foreach (var pic in ((string[])e.Data.GetData(DataFormats.FileDrop)))
            {
                Image img = Image.FromFile(pic);
                PersonPic.Image = img;
            }
            //MessageBox.Show("Droped");
        }

        private void PersonPic_DragEnter(object sender, DragEventArgs e)
        {
           // MessageBox.Show("DragEnter");
            e.Effect = DragDropEffects.Copy;
        }

        private void removePeopleToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
        public static Timer t;

        public void T_Tick(object sender, EventArgs e)
        {
            t.Stop();
            this.Hide();
            exit();
        }

        private void lblClose_Click(object sender, EventArgs e)
        {
            t = new Timer();
            t.Interval = 2000;
            t.Start();
            this.Hide();
            SplashScreen s = new SplashScreen();
            s.Show();
            t.Tick += T_Tick;
        }

        void exit()
        {
            Application.Exit();
        }

        private void label7_Click(object sender, EventArgs e)
        {
            this.Hide();
            notifyIcon1.ShowBalloonTip(1000,"AddressBook","An Rj Porosh Creation Still Running in Background",ToolTipIcon.Info);

        }

        private void notifyIcon1_MouseDown(object sender, MouseEventArgs e)
        {
            this.Show();
        }
    }
        //private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        //{
        //    t = new Timer();
        //    t.Interval = 2000;
        //    t.Start();
        //    t.Tick += T_Tick;  
        //}
        //public void T_Tick(object sender, EventArgs e)
        //{
        //    t.Stop();
        //    Application.Exit();
        //}

        //private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        //{
        //    t = new Timer();
        //    t.Interval = 2000;
        //    t.Start();
        //    t.Tick += T_Tick;  
        //}
    }

    public class Person
    {
        public string Name { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Street { get; set; }
        public string AdditionalInfo { get; set; }
        public DateTime DateOfBirth { get; set; }
    }

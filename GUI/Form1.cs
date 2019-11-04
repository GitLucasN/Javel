using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Logic;
using Model;
using System.IO;
using System.Timers;
using Timer = System.Timers.Timer;
using System.Threading.Tasks;

namespace GUI
{
    public partial class Form1 : Form
    {
        private static Timer oneMTimer;
        private static Timer twoMTimer;
        private static Timer threeMTimer;
        private static Timer fourMTimer;
        private static List<String> eventlog;
        
        public Form1()
        {
            InitializeComponent();
        }
        
        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                
                lwPodcast.FullRowSelect = true;
                string url = lwPodcast.SelectedItems[0].Text;
                tbURL.Text = url;
                tbName.Text = lwPodcast.SelectedItems[0].SubItems[1].Text;
                cbxUppdateringsfrekvens.SelectedItem = lwPodcast.SelectedItems[0].SubItems[3].Text;
                cbxKategori.SelectedItem = lwPodcast.SelectedItems[0].SubItems[4].Text;
                lbxPodcastAvsnitt.Items.Clear();
                List<Avsnitt> avsnitt = GUIController.GetAvsnittFromSelectedPodcast(url);
                foreach (Avsnitt a in avsnitt)
                {
                    lbxPodcastAvsnitt.Items.Add(a.Title);
                }
            }catch(Exception ex)
            {
                Console.WriteLine(ex);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lblAvsnitt_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            RefreshListView();
            RefreshKategoriListAsync(lbxKategorier, cbxKategori);
            Timer();

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void tbURL_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblURL_Click(object sender, EventArgs e)
        {

        }

        private void cbxUppdateringsfrekvens_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lblKategori_Click(object sender, EventArgs e)
        {

        }

        private void cbxKategori_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void tbURL_MouseClick(object sender, MouseEventArgs e)
        {
            if (tbURL.Text.Equals("https://..."))
            {
                tbURL.Text = "";
            }
        }

        private void btnSparaAvsnitt_Click(object sender, EventArgs e)
        {
            var url = tbURL.Text;
            var uppdateringsFrekvens = cbxUppdateringsfrekvens.GetItemText(cbxUppdateringsfrekvens.SelectedItem);
            var kategori = cbxKategori.GetItemText(cbxKategori.SelectedItem);
            var namn = tbName.Text;
            EntityCreater.CreatePodcast(url,uppdateringsFrekvens,kategori,namn);
            RefreshListView();
        }

        private void btnSparaKategori_Click(object sender, EventArgs e)
        {
            KategoriValidator.ValidateKategori(tbxKategorier.Text);

            if (KategoriValidator.ValidateKategori(tbxKategorier.Text) == false)
            {
                string kategori = tbxKategorier.Text;
                EntityCreater.CreateKategori(kategori);
                RefreshKategoriListAsync(lbxKategorier, cbxKategori);

            } else
            {
                tbxKategorier.Text = "Kategori finns redan";
            }

        }

        private void btnTaBortKategori_Click(object sender, EventArgs e)
        {
            SerializeHandler.RemoveKategori(tbxKategorier.Text);
            RefreshKategoriListAsync(lbxKategorier, cbxKategori);
        }

        private void btnTaBortAvsnitt_Click(object sender, EventArgs e)
        {
            ListOfPodcast.DeleteFromListofPodcast(tbURL.Text);
            RefreshListView();
        }

        private void lbxPodcastAvsnitt_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {

                var a = lbxPodcastAvsnitt.SelectedItem.ToString();
                tbxAvsnittBeskrivning.Clear();
                lblAvsnittBeksrivning.Text = a;
                string url = lwPodcast.SelectedItems[0].Text;
                Avsnitt avsnitt = GUIController.GetAvsnittFromSelectedPodcast(url, a);
                tbxAvsnittBeskrivning.Text = GUIController.GetAvsnittBeskrivning(avsnitt);
                
               
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }

        private void tbxAvsnittBeskrivning_TextChanged(object sender, EventArgs e)
        {

        }

        public void RefreshListView()
        {
            var podcasts = ListOfPodcast.GetPodcastFromJson();
            lwPodcast.Items.Clear();
            if (podcasts != null)
            {
                foreach (Podcast p in podcasts)
                {
                    var row = new string[] { p.Url, p.Name, p.AntalAvsnitt.ToString(), p.UppdateringsFrekvens, p.Kategori };
                    var lvi = new ListViewItem(row)
                    {
                        Tag = p
                    };
                    lwPodcast.Items.Add(lvi);

                }
            }
        }
        public void SortListView(string kategori)
        {
            var podcasts = ListOfPodcast.GetPodcastFromJsonKategori(kategori);
            lwPodcast.Items.Clear();
            foreach (Podcast p in podcasts)
            {
                var row = new string[] { p.Url, p.Name, p.AntalAvsnitt.ToString(), p.UppdateringsFrekvens, p.Kategori };
                var lvi = new ListViewItem(row)
                {
                    Tag = p
                };
                lwPodcast.Items.Add(lvi);

            }
        }
        public void RefreshKategoriListAsync(ListBox lbxKategorier, ComboBox cbxKategori)
        {
            /* Tagit bort async, behövs den? */
            lbxKategorier.Items.Clear();
            cbxKategori.Items.Clear();
            var kategorier = ListOfKategori.GetKategoriFromJson();
            foreach (var k in kategorier)
            {
                lbxKategorier.Items.Add(k.Name);
                cbxKategori.Items.Add(k.Name);
            }


        }

        private void lbxKategorier_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbxKategorier.SelectedItem != null)
            {
                tbxKategorier.Text = lbxKategorier.SelectedItem.ToString();
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            RefreshListView();
            RefreshKategoriListAsync(lbxKategorier, cbxKategori);
        }

        private void btnSort_Click(object sender, EventArgs e)
        {
            GUIController.SortOnKategori(tbxKategorier.Text);
            SortListView(tbxKategorier.Text);

        }
        public async Task Timer()
        {
            await Task.Run(() =>
            {
                eventlog = new List<String>();

                StreamWriter sr = new StreamWriter(@".\Interval.txt");
                // timer med 5 minut
                while (true)
                {
                    Task.Delay(5000);
                    foreach (var item in eventlog)
                        sr.WriteLine(item);
                    OnTimedEvent();
                }
                //oneMTimer = new Timer(6000);
                //oneMTimer.Elapsed += OnTimedEvent;
                //oneMTimer.AutoReset = true;
                //oneMTimer.Enabled = true;
                

                
                //Console.WriteLine("Press the Enter key to exit the program... ");
                //Console.ReadLine();
                
                //sr.Close();
                //Console.WriteLine("Terminating the application...");

                ///* Disposea allt som är IDisposable */
                //sr.Dispose();
                
            });
            
        }

        public void OnTimedEvent()
        {
            
            RefreshKategoriListAsync(lbxKategorier, cbxKategori);
           
        }
    }
}

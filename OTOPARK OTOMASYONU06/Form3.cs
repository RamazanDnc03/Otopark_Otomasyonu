using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;
using OTOPARK_OTOMASYONU06.Model;
namespace OTOPARK_OTOMASYONU06
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text.ToUpper();
            textBox1.SelectionStart = textBox1.Text.Length;
          
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e, string v)
        {

          
            bool asdf = false;
            string DosyaAdı = "arac.json";
            string Dosyayolu = @"C:\Users\Ramazan\Desktop\debug\OTOPARK OTOMASYONU06\arac.json";
            string DosyaYolu = System.IO.Path.Combine(Dosyayolu, DosyaAdı);
            var fileName = @"C:\Users\Ramazan\Desktop\debug\OTOPARK OTOMASYONU06\arac.json";
            if (asdf == true)
            {

            }

            if (File.Exists(fileName))
            {
                string jsonString = File.ReadAllText(fileName);
                var weatherForecastt = JsonSerializer.Deserialize<List<kayıt>>(jsonString);
                var asd = weatherForecastt.Where(x => x.plaka.ToString() == textBox1.Text).FirstOrDefault();

                if (asd != null)
                {

                }
                else
                {
                    MessageBox.Show("Geçersiz Plaka Girdiniz!!!");
                }
            }
            else
            {
                var a = 0;
            }

            


        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox2.Clear();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged_1(object sender, EventArgs e)
        {
            
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
          
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            bool asdf = false;
            string DosyaAdı = "arac.json";
            string Dosyayolu = @"C:\Users\Ramazan\Desktop\debug\OTOPARK OTOMASYONU06\arac.json";
            string DosyaYolu = System.IO.Path.Combine(Dosyayolu, DosyaAdı);
            var fileName = @"C:\Users\Ramazan\Desktop\debug\OTOPARK OTOMASYONU06\arac.json";

            if (asdf == true)
            {

            }

            string jsonString = File.ReadAllText(fileName);
            var abonmankayıt = JsonSerializer.Deserialize<List<kayıt>>(jsonString);
            int AracTipi = -1;

            var asd = abonmankayıt.Where(x => x.plaka.ToString() == textBox1.Text).FirstOrDefault();

            if (asd != null)
            {
                AracTipi = asd.AracTipi;

            }
            double totalCost = 0;
            double baseCost = 0;

             if (AracTipi == 1)
             {
                { baseCost = 8; }
             }   
            else if (AracTipi == 2)
            { baseCost = 13; }
            else if (AracTipi == 3)
            { baseCost = 18; }
            else if (AracTipi == 4)
            { baseCost = 20; }

            if (haftalık.Checked == true)
            { totalCost = (baseCost * 0.95) * 7; }
            else if (aylık.Checked == true)
            { totalCost = (baseCost * 0.90) * 30; }
            else if (üçaylık.Checked == true)
            { totalCost = (baseCost * 0.85) * 90; }
            else if (altıaylık.Checked == true)
            { totalCost = (baseCost * 0.80) * 180; }
            else if (yıllık.Checked == true)
            { totalCost = (baseCost * 0.75) * 360; }

            textBox2.Text = Math.Round(Convert.ToDecimal(totalCost),2)+""+"TL".ToString();
          
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            textBox2.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
              
            if (textBox1.Text=="")
            {
               
                return;
            }
            bool asdf = false;
            string DosyaAdıf = "arac.json";
            string Dosyayoluf = @"C:\Users\Ramazan\Desktop\debug\OTOPARK OTOMASYONU06\arac.json";
            string DosyaYoluf = System.IO.Path.Combine(Dosyayoluf, DosyaAdıf);
            var fileNamek = @"C:\Users\Ramazan\Desktop\debug\OTOPARK OTOMASYONU06\arac.json";
            if (asdf == true)
            {

            }

            if (File.Exists(fileNamek))
            {
                string jsonString = File.ReadAllText(fileNamek);
                var plakaeşle = JsonSerializer.Deserialize<List<kayıt>>(jsonString);
                int Id = -1;
                var asdh = plakaeşle.Where(x => x.plaka.ToString() == textBox1.Text).FirstOrDefault();

                if (asdh == null)
                {
                    
                    return;
                }
                else
                {
                    Id = asdh.Id;
                    bool mark = false;
                    string dosyaname = "abonman.json";
                    string dosyaway = @"C:\Users\Ramazan\Desktop\debug\OTOPARK OTOMASYONU06\abonman.json";
                    string dosyaWay = System.IO.Path.Combine(dosyaway, dosyaname);
                    var fileNameq = @"C:\Users\Ramazan\Desktop\debug\OTOPARK OTOMASYONU06\abonman.json";
                    if (mark == true)
                    {

                    }

                    if (File.Exists(fileNameq))
                    {
                        string jsonStringw = File.ReadAllText(fileNameq);
                        var abonmansorgu = JsonSerializer.Deserialize<List<abonman>>(jsonStringw);
                        var hay = abonmansorgu.Where(x => x.plaka.ToString() == textBox1.Text).FirstOrDefault();
                       if (hay != null)
                        {

                            MessageBox.Show("Araç Üzerine Tanımlı Abonman Mevcuttur!!");
                            textBox1.Clear();
                            textBox2.Clear();
                            return;


                       }
                    else
                    {
                    }
                    }
            }
            
           
            }
            if (haftalık.Checked && aylık.Checked && üçaylık.Checked && altıaylık.Checked && yıllık.Checked)
            {

            }
           
            bool asdfr = false;
            string DosyaAdı = "arac.json";
            string Dosyayolu = @"C:\Users\Ramazan\Desktop\debug\OTOPARK OTOMASYONU06\arac.json";
            string DosyaYolu = System.IO.Path.Combine(Dosyayolu, DosyaAdı);
            var fileName = @"C:\Users\Ramazan\Desktop\debug\OTOPARK OTOMASYONU06\arac.json";
            if (asdfr == true)
            {

            }
                
            if (File.Exists(fileName))
            {
                string jsonString = File.ReadAllText(fileName);
                var abonmankayıt = JsonSerializer.Deserialize<List<kayıt>>(jsonString);
                string plaka = "-1";
                int AracTipi = -1;
                int sahibId = -1;
                int Id = -1;
                var asd = abonmankayıt.Where(x => x.plaka.ToString() == textBox1.Text).FirstOrDefault();
                if (asd != null)
                {
                    plaka = textBox1.Text;
                    AracTipi = asd.AracTipi;
                    sahibId = asd.sahibId;
                    Id = asd.Id;
                    List<abonman> ABONMANKAYIT = new List<abonman>();
                    var abonmantype = "";
                    int daysLater = 0;
                    if (haftalık.Checked)
                    {
                        abonmantype = "weekly";
                        daysLater = 7;
                    }
                    else if (aylık.Checked)
                    {
                        abonmantype = "monthly";
                        daysLater = 30;
                    }
                    else if (üçaylık.Checked)
                    {
                        abonmantype = "3 monthly";
                        daysLater = 90;
                    }
                    else if(altıaylık.Checked)
                    {
                        abonmantype = "6 monthly";
                        daysLater = 180;
                    }
                    else if (yıllık.Checked)
                    {
                        abonmantype = "annualy";
                        daysLater = 360;
                    }
                    if (asdf!=null)
                    {
                        abonman abonmane = new abonman
                        {
                            plaka = textBox1.Text,
                            sahibId = sahibId,
                            Id = Id,
                            abonmanStart = DateTime.Now,
                            abonmanEnd = DateTime.Now.AddDays(daysLater),
                            abonmanType = abonmantype
                            
                                        
                        };
                        ABONMANKAYIT.Add(abonmane);
                    }
                    fileName = @"C:\Users\Ramazan\Desktop\debug\OTOPARK OTOMASYONU06\abonman.json";
                    string jsonstring = File.ReadAllText(fileName);
                    var content = JsonSerializer.Deserialize<List<abonman>>(jsonstring);
                    content.Add(ABONMANKAYIT[0]);
                    using FileStream createStream = File.Create(fileName);
                    JsonSerializer.Serialize(createStream, content);
                    createStream.Dispose();
                    MessageBox.Show("Abonman Kaydı Gerçekleşmiştir");
                }
                else
                {
                    MessageBox.Show("Arac Kaydı Yapılması Lazım!!!");
                }
                          
                    textBox1.Clear();
                
              
            }

            this.Close();


        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == 32)
            {
                e.Handled = true;
            }
        }

        private void haftalık_CheckedChanged(object sender, EventArgs e)
        {
            if (haftalık.Checked==true)
            {
                aylık.Checked = false;
                üçaylık.Checked=false;
                altıaylık.Checked = false;
                yıllık.Checked = false;

            }
            

                
        }

        private void aylık_CheckedChanged(object sender, EventArgs e)
        {
            if (aylık.Checked == true)
            {
                haftalık.Checked = false;
                üçaylık.Checked = false;
                altıaylık.Checked = false;
                yıllık.Checked = false;

            }
        }

        private void üçaylık_CheckedChanged(object sender, EventArgs e)
        {
            if (üçaylık.Checked == true)
            {
                haftalık.Checked = false;
                aylık.Checked = false;
                altıaylık.Checked = false;
                yıllık.Checked = false;

            }
        }

        private void altıaylık_CheckedChanged(object sender, EventArgs e)
        {
            if (altıaylık.Checked == true)
            {
                haftalık.Checked = false;
                üçaylık.Checked = false;
                aylık.Checked = false;
                yıllık.Checked = false;

            }
        }

        private void yıllık_CheckedChanged(object sender, EventArgs e)
        {
            if (yıllık.Checked == true)
            {
                haftalık.Checked = false;
                üçaylık.Checked = false;
                altıaylık.Checked = false;
                aylık.Checked = false;

            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
          
        }
    }
}

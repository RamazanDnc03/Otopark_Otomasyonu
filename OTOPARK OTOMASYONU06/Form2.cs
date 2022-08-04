using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.Json;
using OTOPARK_OTOMASYONU06.Model;

namespace OTOPARK_OTOMASYONU06
{
    public partial class Form2 : Form
    {
        public static string plakaaktarımı;
       
        public Form2()
        {
            InitializeComponent();
           
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            List<kayıt> araclar = new List<kayıt>();
            if (textBox2.Text == "") 
            {
                MessageBox.Show("Lütfen TC Kimlik Numaranızı Kontrol Ediniz!");
            }
            if (true)
            {
                bool asdl = false;
                string DosyaAdır = "arac.json";
                string Dosyayolur = @"C:\Users\Ramazan\Desktop\debug\OTOPARK OTOMASYONU06\arac.json";
                string DosyaYolur = System.IO.Path.Combine(Dosyayolur, DosyaAdır);
                var plakaeşlemes = @"C:\Users\Ramazan\Desktop\debug\OTOPARK OTOMASYONU06\arac.json";
                if (File.Exists(plakaeşlemes))
                {
                    string jsonstring = File.ReadAllText(plakaeşlemes);
                    var plakaeşleme = JsonSerializer.Deserialize<List<kayıt>>(jsonstring);
                    int sahibId = 0;
                    var asdc = plakaeşleme.Where(x => x.plaka.ToString() == plaka.Text).FirstOrDefault();
                    if (asdc != null)
                    {
                        MessageBox.Show("Plaka zaten Kayıtlı");
                        plaka.Clear();
                        AraçTipi.Clear();
                        return;

                    }
                }

            }






            if (plaka.Text != "" && AraçTipi.Text != "")
            {
                
                kayıt arac = new kayıt
                {
                    
                    plaka = plaka.Text,
                    AracTipi = Int32.Parse(AraçTipi.Text),
                };
               
                araclar.Add(arac);
            }
            else
            {
                MessageBox.Show("Boş Alan Bırakmayınız!!!!!");
                return;
            }
        

            
            var fileName = @"C:\Users\Ramazan\Desktop\debug\OTOPARK OTOMASYONU06\arac.json";         
            if (File.Exists(fileName))
            {
                string jsonStringg = File.ReadAllText(fileName);

            }
            else
            {
                var a = 0;
            }
            string jsonString = File.ReadAllText(fileName);
            var content = JsonSerializer.Deserialize<List<kayıt>>(jsonString);
            if (content.Count == 0)
            {
                araclar[0].Id = 1;
            }
            else 
            {
                araclar[0].Id = content.LastOrDefault().Id + 1;
          

            }
            content.Add(araclar[0]);
            //using FileStream createStream = File.Create(fileName);
            //JsonSerializer.Serialize(createStream, content);
            //createStream.Dispose();

            // fileName = "yeni kayıtlar.json";
            bool asdf = false;
            string DosyaAdı = "yeni kayıtlar.json";
            string Dosyayolu = @"C:\Users\Ramazan\Desktop\debug\OTOPARK OTOMASYONU06\yeni kayıtlar.json";
            string DosyaYolu = System.IO.Path.Combine(Dosyayolu, DosyaAdı);
            var filename = @"C:\Users\Ramazan\Desktop\debug\OTOPARK OTOMASYONU06\yeni kayıtlar.json";
          
            if (File.Exists(filename))
            {
                string jsonstring = File.ReadAllText(filename);
                var TcEşleme = JsonSerializer.Deserialize<List<yenikayıt>>(jsonstring);
                int sahibId = 0;
                var asdc = TcEşleme.Where(x => x.TC_Kimlik_Numarasi.ToString() == textBox2.Text).FirstOrDefault();
              
                if (asdc != null)
                {

                    content[content.Count - 1].sahibId = asdc.sahibId;
                    using FileStream createStream = File.Create(fileName);
                    JsonSerializer.Serialize(createStream, content);
                  //  createStream.Dispose();
                }
                else
                {
                    MessageBox.Show("T.C Kimlik Numarası Yalnıştır!!");
                    return;
                }    
            }
         
           
        
            this.Close();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            
            List<yenikayıt> yenikayıtlar = new List<yenikayıt>();
            if (KullanıcıAdı.Text != "" && Soyadı.Text != "" && Telefon.Text != "" && TC.Text !="")
            {
                yenikayıt yeni = new yenikayıt
                {
                    sahibId = 0,
                    Adi = KullanıcıAdı.Text,
                    Soyadi = Soyadı.Text,
                    TC_Kimlik_Numarasi =Telefon.Text,
                    Telefon = TC.Text,
                };
                yenikayıtlar.Add(yeni);
            }
            else
            {
                MessageBox.Show("Boş Alan Bırakmayınız!!!!!");
                return;
            }
           // KullanıcıAdı.Clear();
           // Soyadı.Clear();
            textBox2.Text = Telefon.Text.ToString();
           // Telefon.Clear();
           // TC.Clear();
            
           KullanıcıAdı.Enabled = false;
            Soyadı.Enabled = false;
            textBox2.Enabled = false;
            Telefon.Enabled = false;
            TC.Enabled = false;
            var fileName = @"C:\Users\Ramazan\Desktop\debug\OTOPARK OTOMASYONU06\yeni kayıtlar.json";
            if (File.Exists(fileName))
            {
                string jsonStringg = File.ReadAllText(fileName);
            }
            else
            {
                var a = 0;
            }
            
            string jsonString = File.ReadAllText(fileName);
            var content = JsonSerializer.Deserialize<List<yenikayıt>>(jsonString);
           // List<yenikayıt> content = JsonSerializer.Deserialize<List<yenikayıt>>(jsonString);
            if (content.Count == 0)
            {
                yenikayıtlar[0].sahibId = 1;
            }
            else
            {
                yenikayıtlar[0].sahibId = content.LastOrDefault().sahibId + 1;

            }
            content.Add(yenikayıtlar[0]);
            // content.Add(yenikayıtlar[0]);
            using FileStream createStream = File.Create(fileName);
            JsonSerializer.Serialize(createStream, content);
            createStream.Dispose();


            // **   if (content != null && content.Count() > 0)
            //    {
            //      newid = content.LastOrDefault().sahibId + 1;
            //   }
            //  yenikayıt.sahibId = newid;
            //  yenikayıtlar.Add(yenikayıt);
            //    content.Add(yenikayıtlar[0]);


            //  using FileStream createStream = File.Create(fileName);
            //  JsonSerializer.Serialize(createStream, yenikayıtlar);
            //   createStream.Dispose();
           

        }

        private void button2_Click(object sender, EventArgs e)
        {

            if (textBox2.Text == "")
            {
                MessageBox.Show("Boş Alan Bırakmayınız!!!!!");
                return;
            }
            bool asdf = false;
            string DosyaAdı = "yeni kayıtlar.json";
            string Dosyayolu = @"C:\Users\Ramazan\Desktop\debug\OTOPARK OTOMASYONU06\yeni kayıtlar.json";
            string DosyaYolu = System.IO.Path.Combine(Dosyayolu, DosyaAdı);
            var fileName = @"C:\Users\Ramazan\Desktop\debug\OTOPARK OTOMASYONU06\yeni kayıtlar.json";
            if (asdf == true)
            {

            }
            
            if (File.Exists(fileName))
            {
                string jsonString = File.ReadAllText(fileName);
                var tckontrol = JsonSerializer.Deserialize<List<yenikayıt>>(jsonString);
                var asd = tckontrol.Where(x => x.TC_Kimlik_Numarasi.ToString() == textBox2.Text).FirstOrDefault();
                int sahibId = -1;               
                if (asd != null)
                {
                     
                    sahibId = asd.sahibId;                  
                    sahibId = asd.sahibId;
                    DosyaAdı = "yeni kayıtlar.json";
                    Dosyayolu = @"C:\Users\Ramazan\Desktop\debug\OTOPARK OTOMASYONU06\yeni kayıtlar.json";
                    DosyaYolu = System.IO.Path.Combine(Dosyayolu, DosyaAdı);
                    fileName = @"C:\Users\Ramazan\Desktop\debug\OTOPARK OTOMASYONU06\yeni kayıtlar.json";
                    jsonString = File.ReadAllText(fileName);
                    var müşteribilgileri = JsonSerializer.Deserialize<List<yenikayıt>>(jsonString);
                    KullanıcıAdı.Text = asd.Adi;
                    Soyadı.Text = asd.Soyadi;
                    TC.Text = asd.Telefon;
                    Telefon.Text = asd.TC_Kimlik_Numarasi;
                    KullanıcıAdı.Enabled = false;
                    Soyadı.Enabled = false;
                    Telefon.Enabled = false;
                    TC.Enabled = false;
                    textBox2.Enabled = false;
                }
                else
                {
                    MessageBox.Show("Müşteri Kaydı Bulunamadı!!!");
                }
            }
            else
            {
                var a = 0;
            }

        }

        private void KullanıcıAdı_TextChanged(object sender, EventArgs e)
        {
            if (KullanıcıAdı.TextLength > 0)
            {
                KullanıcıAdı.Text = char.ToUpper(KullanıcıAdı.Text[0]).ToString() + KullanıcıAdı.Text.Substring(1);
                KullanıcıAdı.SelectionStart = KullanıcıAdı.TextLength;
            }
           
        }


        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Telefon_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void AraçTipi_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void Telefon_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
            if ((int)e.KeyChar == 32)
            {
                e.Handled = true;
            }

        }

        private void TC_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
            if ((int)e.KeyChar == 32)
            {
                e.Handled = true;
            }
        }

        private void KullanıcıAdı_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsSeparator(e.KeyChar);
            if ((int)e.KeyChar == 32)
            {
                e.Handled = true;
            }
        }

        private void Soyadı_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsSeparator(e.KeyChar);
            if ((int)e.KeyChar == 32)
            {
                e.Handled = true;
            }
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void AraçTipi_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void Soyadı_TextChanged(object sender, EventArgs e)
        {
            if (Soyadı.TextLength > 0)
            {
                Soyadı.Text = char.ToUpper(Soyadı.Text[0]).ToString() + Soyadı.Text.Substring(1);
                Soyadı.SelectionStart = Soyadı.TextLength;
            }
         
        }


        private void plaka_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (e.KeyChar == '£' || e.KeyChar == '½' ||
               e.KeyChar == '€' || e.KeyChar == '₺' ||
               e.KeyChar == '¨' || e.KeyChar == 'æ' ||
               e.KeyChar == 'ß' || e.KeyChar == '´')
            {
                e.Handled = true;
            }
            if ((int)e.KeyChar >= 33 && (int)e.KeyChar <= 47)
            {
                e.Handled = true;
            }
            if ((int)e.KeyChar >= 58 && (int)e.KeyChar <= 64)
            {
                e.Handled = true;
            }
            if ((int)e.KeyChar >= 91 && (int)e.KeyChar <= 96)
            {
                e.Handled = true;
            }
            if ((int)e.KeyChar >= 123 && (int)e.KeyChar <= 127)
            {
                e.Handled = true;
            }
        }

        private void TC_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void plaka_TextChanged(object sender, EventArgs e)
        {
            plaka.Text = plaka.Text.ToUpper();
            plaka.SelectionStart = plaka.Text.Length;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
          
        }

        private void AraçTipi_TextChanged_1(object sender, EventArgs e)
        {
           
        }

        private void AraçTipi_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar<49 || e.KeyChar> 52)
            {
             
                AraçTipi.Text = "1";
               
           
            }
            
        }

        private void button1_KeyPress(object sender, KeyPressEventArgs e)
        {
           
            
        }
    }
}


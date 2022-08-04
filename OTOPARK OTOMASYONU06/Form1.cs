using OTOPARK_OTOMASYONU06.Model;
using System.Text.Json;


namespace OTOPARK_OTOMASYONU06
{
    public partial class Form1 : Form
    {
        public static string entry_exit;
        private Stream jsonString;
        public object sahipidsorgulama;

        public object Label4 { get; private set; }

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Form2.plakaaktarımı = textBox1.Text;
            textBox4.Enabled = false;
            textBox5.Enabled = false;
            textBox6.Enabled = false;
            textBox2.Enabled = false;

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form3 f3 = new Form3();
            f3.ShowDialog();

        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (textBox1.Text!="")
            {

            
            }
            else
            {
                MessageBox.Show("Boş Alan Bırakmayınız!!!!!");
                return;
            }
            textBox5.Clear();
            textBox6.Clear();
            label7.Text = "";
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
                var plakasorgula = JsonSerializer.Deserialize<List<kayıt>>(jsonString);
                int sahibId;

                var asd = plakasorgula.Where(x => x.plaka.ToString() == textBox1.Text).FirstOrDefault();
                if (asd != null)
                {
                    sahibId = asd.sahibId;
                    DosyaAdı = "yeni kayıtlar.json";
                    Dosyayolu = @"C:\Users\Ramazan\Desktop\debug\OTOPARK OTOMASYONU06\yeni kayıtlar.json";
                    DosyaYolu = System.IO.Path.Combine(Dosyayolu, DosyaAdı);
                    fileName = @"C:\Users\Ramazan\Desktop\debug\OTOPARK OTOMASYONU06\yeni kayıtlar.json";
                    jsonString = File.ReadAllText(fileName);
                    var müşteribilgileri = JsonSerializer.Deserialize<List<yenikayıt>>(jsonString);
                    var abc = müşteribilgileri.Where(x => x.sahibId == sahibId).FirstOrDefault();
                    //
                    textBox4.Text = abc.Adi + " " + abc.Soyadi + "      " + "" + "Telefon Numarası:" + abc.Telefon.ToString();
                    DosyaAdı = "abonman.json";
                    Dosyayolu = @"C:\Users\Ramazan\Desktop\debug\OTOPARK OTOMASYONU06\abonman.json";
                    DosyaYolu = System.IO.Path.Combine(Dosyayolu, DosyaAdı);
                    fileName = @"C:\Users\Ramazan\Desktop\debug\OTOPARK OTOMASYONU06\abonman.json";
                    jsonString = File.ReadAllText(fileName);
                    var abonmantarih = JsonSerializer.Deserialize<List<abonman>>(jsonString);
                    var abcd = abonmantarih.Where(x => x.sahibId == sahibId).FirstOrDefault();

                    if (abcd != null)
                    {
                        textBox5.Text = abcd.abonmanStart.ToString();
                        textBox6.Text = abcd.abonmanEnd.ToString();
                    }
                    else
                    {
                        label7.Text = "Kayıtlı Abonman Yoktur";

                    }
                }
                else
                {
                    MessageBox.Show("Arac Kaydı Yapılması Lazım!!!");


                    return;
                }
            }
            else
            {
                var a = 0;
            }

        }
       
	     
        
        int i = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {


        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        
        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == 32)
            {
                e.Handled = true;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text.ToUpper();
            textBox1.SelectionStart = textBox1.Text.Length;
        }

        private void textBox1_KeyPress_1(object sender, KeyPressEventArgs e)
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
               
        private void button2_Click_1(object sender, EventArgs e)
        {
            if (textBox5.Text == "")
            {
            }
          
            else
            {
                return;
            }
         

            bool asdf = false;
            string DosyaAdı = "arac.json";
            string Dosyayolu = @"C:\Users\Ramazan\Desktop\debug\OTOPARK OTOMASYONU06\arac.json";
            string DosyaYolu = System.IO.Path.Combine(Dosyayolu, DosyaAdı);
            var fileName = @"C:\Users\Ramazan\Desktop\debug\OTOPARK OTOMASYONU06\arac.json";
            if (File.Exists(fileName))
            {
                string jsonString = File.ReadAllText(fileName);
                var giriş = JsonSerializer.Deserialize<List<kayıt>>(jsonString);
                var asd = giriş.Where(x => x.plaka.ToString() == textBox1.Text).FirstOrDefault();
                int AracTipi = -1;
                List<entry_exit> Login = new List<entry_exit>();
                if (asd != null)
                {
                    
                    AracTipi = asd.AracTipi;
                }



            }
            if (File.Exists(fileName))
            {
                string jsonString = File.ReadAllText(fileName);
                var giriş = JsonSerializer.Deserialize<List<kayıt>>(jsonString);
                var asd = giriş.Where(x => x.plaka.ToString() == textBox1.Text).FirstOrDefault();
                int AracTipi = -1;
                List<entry_exit> Login = new List<entry_exit>();

                if (asd != null)
                {
                    fileName = @"C:\Users\Ramazan\Desktop\debug\OTOPARK OTOMASYONU06\entry-end.json";

                    if (File.Exists(fileName))
                    {
                        jsonString = File.ReadAllText(fileName);
                        var entry_end_list = JsonSerializer.Deserialize<List<entry_exit>>(jsonString);
                        entry_end_list.Where(x => x.Id == asd.Id).FirstOrDefault().exit = DateTime.Now;
                        using FileStream createStream = File.Create(fileName);
                        JsonSerializer.Serialize(createStream, entry_end_list);


                        var other_asd = entry_end_list.Where(x => x.Id == asd.Id).FirstOrDefault();
                        // createStream.Dispose();
                        // entry_end_list.Remove(other_asd);
                        // using FileStream createStream = File.Create(fileName);
                        //  JsonSerializer.Serialize(createStream, entry_end_list);
                        //  createStream.Dispose();
                        double baseCost = 0;

                        if (asd.AracTipi == 1)
                        {
                            { baseCost = 0.002; }
                        }
                        else if (asd.AracTipi == 2)
                        { baseCost = 0.00361; }
                        else if (asd.AracTipi == 3)
                        { baseCost = 0.005; }
                        else if (asd.AracTipi == 4)
                        { baseCost = 0.0055555555555556; }

                        TimeSpan timeSpan = other_asd.exit - other_asd.entry;


                        textBox2.Text = Math.Round(Convert.ToDecimal(timeSpan.TotalSeconds * baseCost),2)+"TL".ToString();
                        MessageBox.Show("ÇIKIŞ YAPILDI");                    
                    }
                }
            }
            changeButtonEffect();

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (textBox1.Text =="")
            {
                return;

            }
            if (textBox5.Text !="")
            {
                MessageBox.Show("Araç Üzerinde Abonman Tanımlı");
            }

           

            bool asdf = false;
            string DosyaAdı = "arac.json";
            //string Dosyayolu = @"C:\Users\Ramazan\Desktop\debug\OTOPARK OTOMASYONU06\arac.json";
            var fileName = @"C:\Users\Ramazan\Desktop\debug\OTOPARK OTOMASYONU06\arac.json";
            string DosyaYolu = System.IO.Path.Combine(fileName, DosyaAdı);

            if (File.Exists(fileName))
            {
                string jsonString = File.ReadAllText(fileName);
                var giriş = JsonSerializer.Deserialize<List<kayıt>>(jsonString);
                int Id = -1;
                var asd = giriş.Where(x => x.plaka.ToString() == textBox1.Text).FirstOrDefault();
                List<entry_exit> Login = new List<entry_exit>();
                if (asd != null)
                {  
                    Id = asd.Id;
                   
                }
                if (asd == null)
                {
                    return;

                }
                else
                {

                }
                if (asdf != null)
                {
                    entry_exit asdff = new entry_exit
                    {
                        loginId = -1,
                        entry = DateTime.Now,
                        exit = new DateTime(),
                        Id = Id
                    };
                    Login.Add(asdff);

                }
                fileName = @"C:\Users\Ramazan\Desktop\debug\OTOPARK OTOMASYONU06\entry-end.json";
                string jsonstring = File.ReadAllText(fileName);
                var content = JsonSerializer.Deserialize<List<entry_exit>>(jsonstring);
                if (content.Count == 0)
                {
                    Login[0].loginId = 1;
                }
                else
                {
                    Login[0].loginId = content.LastOrDefault().loginId + 1;
                }
                content.Add(Login[0]);
                using FileStream createStream = File.Create(fileName);
                JsonSerializer.Serialize(createStream, content);
                createStream.Dispose();

                MessageBox.Show("Giriş Onaylanmıştır");
                content.Add(Login[0]);


                textBox2.Clear();

            }
            changeButtonEffect();

        }

        private void textBox1_TextChanged_2(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text.ToUpper();
            textBox1.SelectionStart = textBox1.Text.Length;
            
        }

       

        private void textBox1_TextChanged_3(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text.ToUpper();
            textBox1.SelectionStart = textBox1.Text.Length;
            changeButtonEffect();
        }

        private void changeButtonEffect()
        {
            if (textBox1.Text != "")
            {
                string fileName = @"C:\Users\Ramazan\Desktop\debug\OTOPARK OTOMASYONU06\arac.json";
                string fileContent = File.ReadAllText(fileName);
                var aracList = JsonSerializer.Deserialize<List<kayıt>>(fileContent);
                kayıt kayit = aracList.Where(x => x.plaka == textBox1.Text).FirstOrDefault();
                if (kayit != null)
                {
                    fileName = @"C:\Users\Ramazan\Desktop\debug\OTOPARK OTOMASYONU06\entry-end.json";
                    fileContent = File.ReadAllText(fileName);
                    var girisCikisList = JsonSerializer.Deserialize<List<entry_exit>>(fileContent);
                    List<entry_exit> girisCikislar = girisCikisList.Where(x => x.Id == kayit.Id).Where(x => x.exit == new DateTime()).ToList();
                    if (girisCikislar.Count == 1)
                    {
                        button1.Enabled = false;
                        button1.BackColor = Color.DarkGreen;
                        button2.Enabled = true;
                        button2.BackColor = Color.Red;
                    }
                    else
                    {
                        button1.Enabled = true;
                        button1.BackColor = Color.Lime;
                        button2.Enabled = false;
                        button2.BackColor = Color.DarkRed;
                    }
                    return;
                }
            }
            button1.Enabled = false;
            button1.BackColor = Color.DarkGreen;
            button2.Enabled = false;
            button2.BackColor = Color.DarkRed;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}   
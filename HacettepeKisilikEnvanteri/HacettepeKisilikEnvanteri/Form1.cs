using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HacettepeKisilikEnvanteri
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //public string[,] cevaplar = new string[168, 168];
        public List<string> cevaplarlist = new List<string>();
        Dictionary<int, string> cevaplar = new Dictionary<int, string>();
        int sayac = 0;
        public int index = 0;
        public string[] Sorular()
        {
            string sorular = @"1.Başkaları sizinle tartışmaya kalkınca hemen rahatsız olur musunuz ?
2.Zıt görüşte olanlara rağmen planınızı genellikle uygulayabilir misiniz ?
3.Yaptıklarınıza üzüldüğünüz zamanlar çok oluyor mu ?
4.Bazı anlamsız düşünceler zihninizi meşgul edip sizi rahatsız eder mi ?
5.Bir şanssızlığa uğrayacağınızdan korkuyor musunuz ?
6.Oturduğunuz yerde duramaz hale geldiğiniz zamanlar olur mu ?
7.Sık sık önemsiz şeyleri kendinize dert edinir misiniz ?
8.Diğer insanlarla tanışmakta zorluk çeker misiniz ?
9.Çözemediğiniz ve cesaretinizi kıran sorunlarınız ve sorumluluklarınız var mı ?
10.Bazen hiç kimsenin sizi iyi anlayamadığını düşündüğünüz olur mu ?
11.Arkadaşlarınızla dışarıda çok fazla zaman harcadığınız için ailenizin sizden şikayet ettiği olur mu ?
12.Aile içinde kararlar alınırken sizin de fikrinizi alırlar mı ?
13.İnsanları birbirleri ile tanıştırmak size kolay gelir mi ?
14.Olabildiğince kalabalıktan uzak kalma eğiliminiz var mı ?
15.Arkadaşlarınız sosyal ilişkilerinizi istenilen düzeyde bulurlar mı ?
16.Tanışmadığınız yeni birisine de dostça davranmak gerekir mi ?
17.Yasalara uymayan davranışları için insanlar hıklı görülebilir mi ?
18.Başkalarına sır vermek size güç gelir mi ?
19.Saygısız oluşlarından dolayı gençlerden öç almak istediğiniz zamanlar oluyor mu ?
20.Çoğu zaman yanlış veya kötü bir şey yapacağınızdan kaygılanır mısınız ?
21.Size kötü davrandıkları için öç almayı istediğiniz kişiler olur mu ?
22.Fikirlerinizi başkalarına kabul ettirmenin güç olduğu kanısında mısınız ?
23.Çoğu zaman başkalarının aynı konuda ne karar verdiklerini öğrenme zorluğu duyar mısınız ?
24.Hoş olmadığı için sizi uzun zamandır üzen bir yaşantınız var mı ?
25.Duygularınızı kontrol altında tutabiliyor musunuz ?
26.Güç bir durumda karşılaşacağınızı düşününce heyecanlanır ve terler misiniz ?
27.Görme gücünüzdeki bozukluklardan sık sık yakınır mısınız ?
28.Aileniz bireyleri ile sık sık tartışmalarınız olur mu ?
29.Beklentinizin üstünde dostluk gösteren insanlara karşı dikkatli olmaya çalışır mısınız ?
30.Dikkatinizi bir konu üzerinde toplamada çok güçlük çeker misiniz ?
31.Çoğu zaman tüm vücudunuzda bir kırıklık, halsizlik hisseder misiniz ?
32.Aileniz, onlara karşı düşünceli davrandığınız kanısında mıdır ?
33.Aileniz bireyleri genellikle birbirlerine karşı sakin davranırlar mı ?
34.Birbirleri ile şakalaşan kimseler arasında olmak ister misiniz ?
35.Diğer insanlarla ilişki kurmada sizi yetenekli bulurlar mı ?
36.Genellikle karşı cinsten birisi ile çalışmaktan hoşlanır mısınız ?
37.Sahibine haber vermeden bazı şeyleri ödünç almak doğru sayılabilir mi ?
38.Kişinin toplumdaki adet ve geleneklere uyması sizce önemli midir ?
39.Kendini beğenmiş oldukları için çevrenizdeki çoğu kişileri uyarmak zorunda kaldığınız oluyor mu ?
40.Hakkınızda dedikodu yapacaklarından kuşkulanır mısınız ?
41.Zararsız yalanlar söyleyerek zor durumlardan kurtulmak size kolay gelir mi ?
42.Arkadaşlarınız sizi, “eğriye eğri doğruya doğru” diyen bir kişi olarak mı bilirler ?
43.Çevrenizdeki kişiler önemli konularda sizin görüşünüzü de öğrenmek isterler mi ?
44.Arkadaşlarınızın çoğu kadar siz de güçlü ve sağlıklı mısınız ?
45.Çevrenizdeki kişilerden kolayca hastalık kapan bir yaradılışta mısınız ?
46. “Başaramadım” gibi bir duygudan rahatsız mısınız ?
47.Sağlığınıza çok dikkat etmek ihtiyacında mısınız ?
48.İçinde bulunduğunuz koşullardan dolayı sık sık sinirlendiğiniz olur mu ?
49.Belli etmeseniz bile çevrenizdekilere sık sık darıldığınız olur mu ?
50.Moralinizin bozulduğu ve bundan kurtulmanın çok zor olduğu zamanlar oluyor mu ?
51.Çevrenizdeki kişilerin çoğu ile arkadaşlık etmek yerine yalnız olmayı tercih eder misiniz ?
52.Tanıdıkların bulunmadığı bir çevrede sıkılganlık çeker misiniz ?
53.Ailenizdeki kişilerin bazıları size karşı çok cimri davranıyor mu ?
54.Ailenizin çoğu kez her şeye itaat etmenizi beklemeleri sizi kızdırır mı ?
55.Mutlu olacağınız sayıda ve nitelikte arkadaşlarınız var mı ?
56.Gürültülü eğlencelere katılmaktan hoşlanır mısınız ?
57.Sosyal etkinlikler sırasında başkalarını eğlendirmek size zor gelir mi ?
58.İş ve sorumluluklardan kaçmak her zaman hatalı mıdır ?
59.İnsan verdiği sözü her zaman yerine getirmeli midir ?
60.Kapılarını açık bırakan kişilerin eşyalarının çalınmasını hak ettikleri görüşüne katılır mısınız ?
61.Karşıt cinsten birisi ile birlikte olunca genellikle onun cinsiyeti ile ilgili şeyler mi düşünürsünüz ?
62.Bulunduğunuz çevrede çok fazla konu - komşu dedikoduları yapılıyor mu ?
63.İnsan ilişkilerinde utangaç bir kişi misiniz ?
64.Kişileri birbirine tanıştırmak ve başkalarına tanıştırılmak size kolay gelir mi ?
65.Başkaları sizi yetenekli ve cesur bulur mu ?
66.Alıngan bir kişi misiniz ?
67.Fiziki görünüşünüzden dolayı duygusal bir hassasiyetiniz var mı ?
68.Duygularınıza olan güveninizden dolayı görüşlerinizin esnek olduğu kanısında mısınız ?
69.Sık sık kabızlıktan ve mide ağrılarından şikayetiniz olur mu ?
70.Ara sıra zihninizin ağır işlediğini hisseder misiniz ?
71.Başkalarının mutluluğunu kıskandığınız zamanlar oluyor mu ?
72.Başarmayı arzu ettiğiniz şeyleri düşünmek, onları yapmaktan daha çok haz veriyor mu ?
73.Size açık olan avantajlı durumlardan bazı kişilerin yararlanma çabasında oldukları kanısında mısınız ?
74.İstekli olduğunuz toplantı veya etkinliklere katılmanız genellikle engellenir mi ?
75.En az anlayış gördüğünüz yerin aileniz olduğunu düşündüğünüz oluyor mu ?
76.Koşulsuz olarak her insana yardım eder misiniz ?
77.Sönük geçmekte olan bir toplantıya öncülük edip canlandırmak size kolay gelir mi ?
78.Çabuk arkadaş edinen bir kişi misiniz ?
79.Ortaya çıkan fırsatlarda otobüse ücret ödemeden binmek bir şerefsizlik midir ?
80.İşlerini düze çıkarmak için pek çok kişinin yalan söylediği kanısında mısınız ?
81.Sosyal kurallardan oldukça bağımsız bir yaşantı içinde misiniz ?
82.Çevrenizdeki çoğu kişilerin politik görüşleri sizinkine ters düşer mi ?
83.Başkalarının saflığını kendi çıkarlarına kullanan kimseleri ayıplar mısınız ?
84.Aileniz, sizin başarılı olduğunuz kanısında mıdır ?
85.İstediğiniz bir işe veya mesleğe girmenizin engellendiği oldu mu ?
86.Önemli olmayan konular yüzünden sık sık eleştirildiğiniz olur mu ?
87.Yaptığınız bir yanlışı kabul etmek size zor gelir mi ?
88.Ailenizin düşündüğü gibi olmama duygusu sizi rahatsız ediyor mu ?
89.Belirli bir nedeni olmadan duygularınız kolayca neşeden üzüntüye, üzüntüden neşeye dönüşür mü ?
90.Çevrenizdeki insanlara gerçeği kabul ettirmenin güç olduğu zamanlar olur mu ?
91.Zihninizi dolduran türlü düşünceler uykunuzu kaçırır mı ?
92.Genellikle sakin ve meseleleri soğukkanlı olarak ele alan bir kişi misiniz ?
93.Zaman zaman aleyhinize çalışan insanların varlığından şüphelendiğiniz olur mu ?
94.İnsanların içinde iken bile kendinizi yalnız hisseder misiniz ?
95.Aileniz yeterli düzeyde başarılı olduğunuz kanısında mıdır ?
96.Akşamları eve dönüş sizi kaygılandırır mı ?
97.Ailenizdeki kişilerden bazılarının yakınlık ve sevginize yeterince karşılık vermediği oluyor mu ?
98.Yeni tanıştığınız bir kimse ile konuşmaktan çekinir misiniz ?
99.Çevrenizdeki insanlar çoğu zaman sizi hayal kırıklığına uğratırlar mı ?
100.Sizce geçinilmesi güç kişilere de nazik davranılmalı mıdır ?
101.Davranışınızın çevredekilere aykırı düşmesi sizi rahatsız eder mi ?
102.Söz dinlemeyip kendisini problemin içine atmakta ısrar eden kişiler cezalarını çekmeli midir ?
103.Bazı konularda kendi kendinizle kavga içinde misiniz ?
104.İnatçı kişilere biraz zor kullanmanın onları ikna etmede yararlı olacağı kanısında mısınız ?
105.Başkalarının mutluluğunu kıskandığınız zamanlar oluyor mu ?
106.Başkalarının sizden hoşlandığı duygusu içinde misiniz ?
107.Yeteneğinizi küçümseyip başladığınız bazı işleri yarım bıraktığınız oluyor mu ?
108.Kafesleri içinde olsa da vahşi hayvan görmekten heyecanlanır mısınız ?
109.Sizi eleştirdikleri zaman sakin kalabiliyor musunuz ?
110.Kendinizi sinirli bir kişi olarak mı görüyorsunuz ?
111.Üzüntülü veya heyecanlı olduğunuz zaman konuşmanızda kekemelik olur mu ?
112.Sonradan pişman olacağınız çok şeyi yaptığınız oluyor mu ?
113.Kaslarınızda bazen asabi hareketler veya tikler olur mu ?
114.Belirli bir neden yokken kendinizi son derece neşeli veya üzüntülü hissettiğiniz zamanlar olur mu ?
115.Yaşı sizden küçük olanların daha rahat bir yaşam sürdürdükleri kanısında mısınız ?
116.Hoşlanmadıkları için ailenizin evde misafir etmek istemedikleri arkadaşlarınız var mı ?
117.Ailenizle aranızdaki değer yargıları ve inanç farkları nedeniyle önemli sorunlarla karşılaştığınız oluyor mu ?
118.Aileniz sizden çok fazla şeyler mi bekliyor ?
119.Kız ve erkeklerin birlikte bulunduğu durumlarda kendinizi rahat hisseder misiniz ?
120.İnsan ilişkilerinde utangaç bir kişi misiniz ?
121.Çıkarlarını korumak için pek doğru olmayan yollara sapanları ayıplar mısınız ?
122.Bir şeyi bulan kişiye onu saklama hakkı verilmeli midir ?
123.İnsanların inançlarında kusur etmeleri, bir diğerine bunu başkalarına yayma hakkı verir mi ?
124.Yaptığınız şeylerin yanlış anlaşılacağı kaygısı içinde misiniz ?
125.İnsanların koşulsuz olarak serbest davranmalarına izin verilse toplumun daha iyi olacağı kanısında mısınız ?
126.İçinde bulunduğunuz koşullardan dolayı sık sık sinirlendiğiniz olur mu ?
127.Arkadaşlarınız istemediğiniz bir davranışta bulunduğu zaman, çoğunlukla bunu, çekinmeden kendisine söyleyebilir misiniz ?
128.Gerçek yeteneklerinizi gösterebildiğiniz kanısında mısınız ?
129.Kendinize özgü bir plan yapmaktansa arkadaşlarınızın önerilerini uygulamak size daha kolay gelir mi ?
130.Açlık hissi duymadan yemek yediğiniz zamanlar oluyor mu ?
131.Akşama doğru ya da sabahları kendinizi çok yorgun hisseder misiniz ?
132.Ne okuduğunuzun farkında olmadan bir süre okuyup sonra dikkatinizi topladığınız olur mu ?
133.Çoğu zaman kendinizi yorgun ve halsiz hisseder misiniz ?
134.Eleştirilmek sizi çok kırar mı ?
135.Hoşlanmadığınız birisi ile karşılaşmamak için yolunuzu sık sık değiştirdiğiniz oluyor mu ?
136.Cinsel konularda kendinizi rahat hisseder misiniz ?
137.Başka bir aile veya grubun üyesi olmayı istediğiniz zamanlar olur mu ?
138.Aile bireylerinin kişisel meselelerinizi bilmek istemelerinden şikayetçi misiniz ?
139.Aileniz karşı cinsten olan arkadaşlarınızı genellikle reddeder mi ?
140.Bulunduğunuz çevrede halk tarafından sevilmeyen çok kişi var mı ?
141.Topluluk içinde tanıştığınız insanlarla çabucak kaynaşabiliyor musunuz ?
142.Uzlaşma kabul etmeyen kişilere nazik davranır mısınız ?
143.Arkadaşlarınız sizi, eğriye eğri doğruya doğru diyen bir kişi olarak mı bilirler ?
144.Saygısızlık gösterenlere aynı şekilde cevap verir misiniz ?
145.Onlara aldırmamak yerine öç almanın daha iyi olduğu kanısında mısınız ?
146.Yasalara aykırı davranmadan yasanın bir açığından yararlanmada bir sakınca görür müsünüz ?
147.Duygularınızı kontrol altında tutabiliyor musunuz ?
148.Arkadaş edinmede zorluk çekiyor musunuz ?
149.Doğru yargılarınızı bile, değerli bulmadıkları olur mu ?
150.Cesaret verilmediği zaman işlerinize devam etmek size zor gelir mi ?
151.Heyecanlı olaylar sizi karamsarlıktan kurtarır mı ?
152.İşler kötü gittiği zaman çabuk heyecanlanan bir kişi misiniz ?
153.Bazen içinizden insanlara küfretmek gelir mi ?
154.Sık sık başınız ağrır mı ?
155.Ayrıntılı konuşmadıkları için sık sık kişilerin sözlerini tekrarlatmak zorunda kalır mısınız ?
156.Bazen sevdiğiniz kişiyi kırmaktan hoşlandığınız olur mu ?
157.Sizden gelen bir neden yokken işlerinizin ter gittiği zamanlar oluyor mu ?
158.Evden kaçıp başka bir yere gitmeyi düşündüğünüz zamanlar oluyor mu ?
159.Aileniz bireylerinin hepsini denk ölçüler içinde seviyor musunuz ?
160.Evde sakin olmak için ya susmak ya da dışarı çıkmak zorunda olduğunuz zamanlar oluyor mu ?
161.Taşıdığınız sorumlulukların ağırlığı sizi fazlaca hareketsiz hale getiriyor mu ?
162.Neşeli arkadaşlar arasına katılınca üzüntülerinizi unutabiliyor musunuz ?
163.Sıkışık durumlardan kurtulmak için gerçeği söylemediğiniz zamanlar olur mu ?
164.Bulunmuş olan bir eşyayı her zaman iade etmek gerekli midir ?
165.Yaşamının bir döneminde her insanın bir şeyler çalmış olabileceği görüşüne katılır mısınız ?
166.Bazı insanların mal ve mülklerini tahrip etmeyi hak ettiklerini düşündüğünüz olur mu ?
167.Size kötü davrandıkları için öç almayı istediğiniz kişiler oldu mu ?
168.Başkaları sizinle tartışmaya kalkınca hemen rahatsız olur musunuz ?";


            string[] sonuc = sorular.Split('\n');
            return sonuc;

        }

        public void PanelYaratici(int index, string soru)
        {
            label1.Text = soru;
            this.AutoSize = true;
            this.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            if (listBox1.Items.Count==1)
            {
                button1.Text = "Envanteri Bitir";
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Sorular();
            for (int i = 1; i <= Sorular().Length; i++)
            {
                listBox1.Items.Add(i);
            }
            if (label1.Text == "label1")
            {
                PanelYaratici(index, Sorular()[index]);
            }
            if (label2.Text == "label2")
            {
                label2.Text = "";
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {


            if (label1.Text == "label1")
            {
                PanelYaratici(index, Sorular()[index]);
            }
            else
            {
                if (radioButton1.Checked == true)
                {
                    if (cevaplar.ContainsKey(index))
                    {
                        cevaplar[index] = "Evet";
                        if (listBox1.Items.Count == 0)
                        {
                            Form2 frm2 = new Form2();
                            frm2.Show();
                        }
                        else
                        {
                            index++;
                            PanelYaratici(index, Sorular()[index]);
                        }

                    }
                    else
                    {
                        cevaplar.Add(index, "Evet");
                        listBox1.Items.Remove(index+1);
                        listBox1.Items.Remove(index + 1);
                        if (listBox1.Items.Count == 0)
                        {
                            sayac++;
                            if (sayac == Sorular().Count())
                            {
                                Form2 frm2 = new Form2();
                                frm2.SonucAnaliz(cevaplar);
                                frm2.Show();
                            }
                            else
                            {
                                sayac++;
                                index++;
                            }


                        }
                        else
                        {
                            sayac++;
                            index++;
                            if (listBox1.Items.Count+ sayac == index)
                            {
                                index = int.Parse(listBox1.Items[0].ToString()) - 1;
                                PanelYaratici(int.Parse(listBox1.Items[0].ToString()) - 1, Sorular()[int.Parse(listBox1.Items[0].ToString()) - 1]);
                                listBox1.SelectedItem = listBox1.Items[0];
                            }
                            else
                            {
                                if (listBox1.Items.Contains(index+1)==false)
                                {
                                    index = int.Parse(listBox1.Items[0].ToString()) - 1;
                                    PanelYaratici(int.Parse(listBox1.Items[0].ToString()) - 1, Sorular()[int.Parse(listBox1.Items[0].ToString()) - 1]);
                                    listBox1.SelectedItem = listBox1.Items[0];
                                }
                                else
                                {
                                    PanelYaratici(index, Sorular()[index]);
                                }
                               
                            }
                        }


                    }

                
                    label2.Text = "Yapılan soru = " + sayac + ", Toplam soru = " + Sorular().Length + " , Kalan soru = " + (Sorular().Length - sayac);
                }
                else if (radioButton2.Checked == true)
                {
                    if (cevaplar.ContainsKey(index))
                    {
                        cevaplar[index] = "Hayır";
                        if (listBox1.Items.Count==0)
                        {
                            Form2 frm2 = new Form2();
                            frm2.Show();
                        }
                        else
                        {
                            index++;
                            PanelYaratici(index, Sorular()[index]);
                        }


                    }
                    else
                    {
                        cevaplar.Add(index, "Hayır");
                        listBox1.Items.Remove(index+1);
                        if (listBox1.Items.Count == 0)
                        {
                            sayac++;
                            if (sayac==Sorular().Count())
                            {
                                Form2 frm2 = new Form2();
                                frm2.Show();
                            }
                            else
                            {
                                sayac++;
                                index++;
                            }
                            

                        }
                        else
                        {
                            sayac++;
                            index++;
                            if (listBox1.Items.Count+sayac == index)
                            {
                                index = int.Parse(listBox1.Items[0].ToString()) - 1;
                                PanelYaratici(int.Parse(listBox1.Items[0].ToString())-1, Sorular()[int.Parse(listBox1.Items[0].ToString())-1]);
                                listBox1.SelectedItem = listBox1.Items[0];
                            }
                            else
                            {
                                if (listBox1.Items.Contains(index+1) == false)
                                {
                                    index = int.Parse(listBox1.Items[0].ToString()) - 1;
                                    PanelYaratici(index, Sorular()[index]);
                                    listBox1.SelectedItem = listBox1.Items[0];
                                }
                                else
                                {
                                    PanelYaratici(index, Sorular()[index]);
                                }
                            }
                            
                        }
                        

                    }
                    label2.Text = "Yapılan soru = " + sayac + ", Toplam soru = " + Sorular().Length + " Kalan soru = " + (Sorular().Length - sayac);
                }
                else
                {
                    MessageBox.Show("Hata . Herhangi bir seçenek seçilmemiş");
                }


            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (1 <= index)
            {
                if (listBox1.Items.Contains(index) == false)
                {
                    index = index - 2;
                }
                else if (listBox1.Items.Contains(index-2)==false)
                {
                    if (index < Sorular().Length - 2)
                    {
                        index = index -1;
                    }
                    else
                    {
                        index = int.Parse(listBox1.Items[listBox1.Items.Count - 1].ToString()) - 1;
                    }
                    
                }
                else
                {
                    index = index - 1;
                }
                
            }
            else
            {
                index = int.Parse(listBox1.Items[listBox1.Items.Count - 1].ToString()) - 1;
            }
            PanelYaratici(index, Sorular()[index]);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (index < Sorular().Length - 1)
            {
                if (listBox1.Items.Contains(index + 2) == false)
                {
                    if (index<Sorular().Length-2)
                    {
                        index = index + 1;
                    }

                }

                if (listBox1.Items.Contains(index+2)!=false)
                {
                    index++;
                }
                else
                {
                    index = int.Parse(listBox1.Items[0].ToString()) -1;

                }
                

            }
            else
            {
                index = int.Parse(listBox1.Items[0].ToString()) - 1;
            }
            PanelYaratici(index, Sorular()[index]);

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            int myindex = Convert.ToInt32(listBox1.SelectedItem);
            index = myindex - 1;
            PanelYaratici(index, Sorular()[index]);
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }
    }
}

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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        public void SonucAnaliz(Dictionary<int, string> cevaplar)
        {
            if (5 < GecerlilikAnaliz(cevaplar))
            {
                if (12 <= KendiniGerceklestirme(cevaplar))
                {
                    label1.Text = @"Kendini Gerçekleştirme : Bu Özelliklere Sahip Olma Olasılığı Yüksektir ( % 75 üstü )
Kendini gerçekleştirme puanı, kendini gerçekleştiren kişinin davranış özelliklerinden kendine güvenme, kendi yeteneklerinin farkında olma, kendi kendine kararlar verebilme, doğru bildiğini söyleyebilme, kabul edildiği ve bir işe yaradığı duygusu içinde olma gibi niteliklerle ilişkilidir.
Puanın yüksek ya da düşük olması bireyin bu nitelikteki davranışlarını değerlendirme olanağı sağlamaktadır.";
                }
                if (9 <= KendiniGerceklestirme(cevaplar) || 12 > KendiniGerceklestirme(cevaplar))
                {
                    label1.Text = @"Kendini Gerçekleştirme : Bu Özelliklere Aday Bir Kişidir ( % 75 - % 50 arası )
Kendini gerçekleştirme puanı, kendini gerçekleştiren kişinin davranış özelliklerinden kendine güvenme, kendi yeteneklerinin farkında olma, kendi kendine kararlar verebilme, doğru bildiğini söyleyebilme, kabul edildiği ve bir işe yaradığı duygusu içinde olma gibi niteliklerle ilişkilidir.
Puanın yüksek ya da düşük olması bireyin bu nitelikteki davranışlarını değerlendirme olanağı sağlamaktadır.";
                }
                if (6<KendiniGerceklestirme(cevaplar)||9>KendiniGerceklestirme(cevaplar))
                {
                    label1.Text = @"Kendini Gerçekleştirme : Bu Özelliklere Sahip Olma Yeterliliği Düşüktür ( % 50 - % 25 arası )
Kendini gerçekleştirme puanı, kendini gerçekleştiren kişinin davranış özelliklerinden kendine güvenme, kendi yeteneklerinin farkında olma, kendi kendine kararlar verebilme, doğru bildiğini söyleyebilme, kabul edildiği ve bir işe yaradığı duygusu içinde olma gibi niteliklerle ilişkilidir.
Puanın yüksek ya da düşük olması bireyin bu nitelikteki davranışlarını değerlendirme olanağı sağlamaktadır.";
                }
                if (KendiniGerceklestirme(cevaplar)<=6)
                {
                    label1.Text = @"Kendini Gerçekleştirme : Bu Özelliğe Sahip Olmaya Yeterliliği Çok Düşüktür ( % 25 ve altı ) 
Kendini gerçekleştirme puanı, kendini gerçekleştiren kişinin davranış özelliklerinden kendine güvenme, kendi yeteneklerinin farkında olma, kendi kendine kararlar verebilme, doğru bildiğini söyleyebilme, kabul edildiği ve bir işe yaradığı duygusu içinde olma gibi niteliklerle ilişkilidir.
Puanın yüksek ya da düşük olması bireyin bu nitelikteki davranışlarını değerlendirme olanağı sağlamaktadır.";
                }
                /////////////////////////////////////////////////
                if (11 <= DuygusalKararlilik(cevaplar))
                {
                    label2.Text = @"Duygusal Kararlılık : Bu Özelliklere Sahip Olma Olasılığı Yüksektir ( % 75 üstü )
Duygusal kararlılık puanının yüksek oluşu bireyin duygusal yönden kararlı oluşunu belirtir. Duygusal kararlılık puanı yüksek olan bireyler genellikle kendine güvenen, az üzülen, alıngan olmama özellikleri gösteren kişilerdir. Çoğu kez sakin ve huzurlu bireyler izlenimi verirler.
Başkalarından pek az tavsiye isterler. Kendi kararlarını kendileri verme eğilimindedirler. Ortaya çıkan yeni ve yabancı durumlardan çekinmezler. Acil durumlarda etkili davranışlar gösterirler.
Puanı düşük olan kişiler genellikle gergin ve kaygılı olurlar. Sıkıntılı durumlarda gözyaşlarını tutamazlar. Karşılaştıkları yeni durumlarda ise ya korkak ve çekingen ya da aşırı düzeyde atak ve kavgacı olabilirler.";
                }
                if (8 <= DuygusalKararlilik(cevaplar) || 11 > DuygusalKararlilik(cevaplar))
                {
                    label2.Text = @"Duygusal Kararlılık : Bu Özelliklere Aday Bir Kişidir ( % 75 - % 50 arası )
Duygusal kararlılık puanının yüksek oluşu bireyin duygusal yönden kararlı oluşunu belirtir. Duygusal kararlılık puanı yüksek olan bireyler genellikle kendine güvenen, az üzülen, alıngan olmama özellikleri gösteren kişilerdir. Çoğu kez sakin ve huzurlu bireyler izlenimi verirler.
Başkalarından pek az tavsiye isterler. Kendi kararlarını kendileri verme eğilimindedirler. Ortaya çıkan yeni ve yabancı durumlardan çekinmezler. Acil durumlarda etkili davranışlar gösterirler.
Puanı düşük olan kişiler genellikle gergin ve kaygılı olurlar. Sıkıntılı durumlarda gözyaşlarını tutamazlar. Karşılaştıkları yeni durumlarda ise ya korkak ve çekingen ya da aşırı düzeyde atak ve kavgacı olabilirler.";
                }
                if (5 < DuygusalKararlilik(cevaplar) || 9 > DuygusalKararlilik(cevaplar))
                {
                    label2.Text = @"Duygusal Kararlılık : Bu Özelliklere Sahip Olma Yeterliliği Düşüktür ( % 50 - % 25 arası )
Duygusal kararlılık puanının yüksek oluşu bireyin duygusal yönden kararlı oluşunu belirtir. Duygusal kararlılık puanı yüksek olan bireyler genellikle kendine güvenen, az üzülen, alıngan olmama özellikleri gösteren kişilerdir. Çoğu kez sakin ve huzurlu bireyler izlenimi verirler.
Başkalarından pek az tavsiye isterler. Kendi kararlarını kendileri verme eğilimindedirler. Ortaya çıkan yeni ve yabancı durumlardan çekinmezler. Acil durumlarda etkili davranışlar gösterirler.
Puanı düşük olan kişiler genellikle gergin ve kaygılı olurlar. Sıkıntılı durumlarda gözyaşlarını tutamazlar. Karşılaştıkları yeni durumlarda ise ya korkak ve çekingen ya da aşırı düzeyde atak ve kavgacı olabilirler.";
                }
                if (DuygusalKararlilik(cevaplar) <= 5)
                {
                    label2.Text = @"Duygusal Kararlılık : Bu Özelliğe Sahip Olmaya Yeterliliği Çok Düşüktür ( % 25 ve altı ) 
Duygusal kararlılık puanının yüksek oluşu bireyin duygusal yönden kararlı oluşunu belirtir. Duygusal kararlılık puanı yüksek olan bireyler genellikle kendine güvenen, az üzülen, alıngan olmama özellikleri gösteren kişilerdir. Çoğu kez sakin ve huzurlu bireyler izlenimi verirler.
Başkalarından pek az tavsiye isterler. Kendi kararlarını kendileri verme eğilimindedirler. Ortaya çıkan yeni ve yabancı durumlardan çekinmezler. Acil durumlarda etkili davranışlar gösterirler.
Puanı düşük olan kişiler genellikle gergin ve kaygılı olurlar. Sıkıntılı durumlarda gözyaşlarını tutamazlar. Karşılaştıkları yeni durumlarda ise ya korkak ve çekingen ya da aşırı düzeyde atak ve kavgacı olabilirler.";
                }
                /////////////////////////////////////////////////
                if (12 <= NevrotikEgilimler(cevaplar))
                {
                    label3.Text = @"Nevrotik Eğilimler : Bu Özelliklere Sahip Olma Olasılığı Yüksektir ( % 75 üstü )
Nevrotik belirtileri olan kişiler kronik yorgunluk, baş ağrısı, uyuyamama, görme güçlüleri, iştahsızlık vb. gibi çeşitli psikosomatik belirtilen birinden ya da bir kaçından şikâyetçidirler. Nevrotik kişiler duygusal çatışmalarını genellikle fiziksel yollardan ifade etmektedirler. Ayrıca, nevrotik eğilimler benliğini olduğu gibi kabul edememe, mükemmeliyetçi olma, eleştiriye açık olmama gibi davranışları da içerir.
Nevrotik eğilimler puanının yüksek bulunması bu tür belirtilerin azlığını düşük olması ise çokluğunu gösterir.";
                }
                if (9 <= NevrotikEgilimler(cevaplar) || 12 > NevrotikEgilimler(cevaplar))
                {
                    label3.Text = @"Nevrotik Eğilimler : Bu Özelliklere Aday Bir Kişidir ( % 75 - % 50 arası )
Nevrotik belirtileri olan kişiler kronik yorgunluk, baş ağrısı, uyuyamama, görme güçlüleri, iştahsızlık vb. gibi çeşitli psikosomatik belirtilen birinden ya da bir kaçından şikâyetçidirler. Nevrotik kişiler duygusal çatışmalarını genellikle fiziksel yollardan ifade etmektedirler. Ayrıca, nevrotik eğilimler benliğini olduğu gibi kabul edememe, mükemmeliyetçi olma, eleştiriye açık olmama gibi davranışları da içerir.
Nevrotik eğilimler puanının yüksek bulunması bu tür belirtilerin azlığını düşük olması ise çokluğunu gösterir.";
                }
                if (6 < NevrotikEgilimler(cevaplar) || 9 > NevrotikEgilimler(cevaplar))
                {
                    label3.Text = @"Nevrotik Eğilimler : Bu Özelliklere Sahip Olma Yeterliliği Düşüktür ( % 50 - % 25 arası )
Nevrotik belirtileri olan kişiler kronik yorgunluk, baş ağrısı, uyuyamama, görme güçlüleri, iştahsızlık vb. gibi çeşitli psikosomatik belirtilen birinden ya da bir kaçından şikâyetçidirler. Nevrotik kişiler duygusal çatışmalarını genellikle fiziksel yollardan ifade etmektedirler. Ayrıca, nevrotik eğilimler benliğini olduğu gibi kabul edememe, mükemmeliyetçi olma, eleştiriye açık olmama gibi davranışları da içerir.
Nevrotik eğilimler puanının yüksek bulunması bu tür belirtilerin azlığını düşük olması ise çokluğunu gösterir.";
                }
                if (NevrotikEgilimler(cevaplar) <= 6)
                {
                    label3.Text = @"Nevrotik Eğilimler : Bu Özelliğe Sahip Olmaya Yeterliliği Çok Düşüktür ( % 25 ve altı ) 
Nevrotik belirtileri olan kişiler kronik yorgunluk, baş ağrısı, uyuyamama, görme güçlüleri, iştahsızlık vb. gibi çeşitli psikosomatik belirtilen birinden ya da bir kaçından şikâyetçidirler. Nevrotik kişiler duygusal çatışmalarını genellikle fiziksel yollardan ifade etmektedirler. Ayrıca, nevrotik eğilimler benliğini olduğu gibi kabul edememe, mükemmeliyetçi olma, eleştiriye açık olmama gibi davranışları da içerir.
Nevrotik eğilimler puanının yüksek bulunması bu tür belirtilerin azlığını düşük olması ise çokluğunu gösterir.";
                }
                /////////////////////////////////////////////////
                if (12 <= PsikolojikBelirtiler(cevaplar))
                {
                    label4.Text = @"Psikolojik Belirtiler : Bu Özelliklere Sahip Olma Olasılığı Yüksektir ( % 75 üstü )
Psikotik belirtiler puanı düşük olan bireylerde insanlardan uzaklaşma ve yalnız kalmayı yeğleme eğilimi, dikkatini bir noktada toplama güçlüğü ve hayal kurma eğilimi gözlenir. Bu bireyler alıngan ve aşırı duygusaldırlar. Kendilerine yönelik düşünceleri fazladır.
Psikotik belirtiler puanının yüksek olduğu normal uyum tarzında ise birey belirli ölçüler içinde hayal dünyasından bağımsız olarak yaşamını sürdürür.";
                }
                if (9 <= PsikolojikBelirtiler(cevaplar) || 12 > NevrotikEgilimler(cevaplar))
                {
                    label4.Text = @"Psikolojik Belirtiler : Bu Özelliklere Aday Bir Kişidir ( % 75 - % 50 arası )
Psikotik belirtiler puanı düşük olan bireylerde insanlardan uzaklaşma ve yalnız kalmayı yeğleme eğilimi, dikkatini bir noktada toplama güçlüğü ve hayal kurma eğilimi gözlenir. Bu bireyler alıngan ve aşırı duygusaldırlar. Kendilerine yönelik düşünceleri fazladır.
Psikotik belirtiler puanının yüksek olduğu normal uyum tarzında ise birey belirli ölçüler içinde hayal dünyasından bağımsız olarak yaşamını sürdürür.";
                }
                if (6 < PsikolojikBelirtiler(cevaplar) || 9 > NevrotikEgilimler(cevaplar))
                {
                    label4.Text = @"Psikolojik Belirtiler : Bu Özelliklere Sahip Olma Yeterliliği Düşüktür ( % 50 - % 25 arası )
Psikotik belirtiler puanı düşük olan bireylerde insanlardan uzaklaşma ve yalnız kalmayı yeğleme eğilimi, dikkatini bir noktada toplama güçlüğü ve hayal kurma eğilimi gözlenir. Bu bireyler alıngan ve aşırı duygusaldırlar. Kendilerine yönelik düşünceleri fazladır.
Psikotik belirtiler puanının yüksek olduğu normal uyum tarzında ise birey belirli ölçüler içinde hayal dünyasından bağımsız olarak yaşamını sürdürür.";
                }
                if (PsikolojikBelirtiler(cevaplar) <= 6)
                {
                    label4.Text = @"Psikolojik Belirtiler : Bu Özelliğe Sahip Olmaya Yeterliliği Çok Düşüktür ( % 25 ve altı ) 
Psikotik belirtiler puanı düşük olan bireylerde insanlardan uzaklaşma ve yalnız kalmayı yeğleme eğilimi, dikkatini bir noktada toplama güçlüğü ve hayal kurma eğilimi gözlenir. Bu bireyler alıngan ve aşırı duygusaldırlar. Kendilerine yönelik düşünceleri fazladır.
Psikotik belirtiler puanının yüksek olduğu normal uyum tarzında ise birey belirli ölçüler içinde hayal dünyasından bağımsız olarak yaşamını sürdürür.";
                }
                /////////////////////////////////////////////////
                if (13 <= AileIliskileri(cevaplar))
                {
                    label5.Text = @"Aile İlişkileri : Bu Özelliklere Sahip Olma Olasılığı Yüksektir ( % 75 üstü )
Bu alt ölçekten elde edilen puan bireyin ailesi ile olan ilişkilerini yansıtır. Puanın yüksek bulunması kişinin anne babası ve kardeşleri ile dostça ve sağlıklı ilişkiler içinde olduğunu, ailesini sevdiğini, ailesi tarafından sevildiğini gösterir.
	Bu tür bireyler aile üyelerini normal ölçüler içinde kendilerinden isteklerde bulunan ancak belli düzeyde bağımsız olma hakkını onlara tanıyan kişiler olarak görürler. Zamanlarının çoğunu aileleri ile evde geçirirler ve birlikte etkinlik gösterirler.
Aile ilişkileri puanının düşük bulunması ise bireyin ailesi ile olan ilişkilerinde karışıklık ve uyumsuzluk bulunduğuna işaret eder.
Genellikle ana babası ve kardeşleri ile problemleri olan bireyler aile üyelerini çok otoriter bulurlar, onların kendilerinden çok fazla şey beklediklerini düşünürler. Çok zorunlu durumlar dışında evde olmaktan kaçınırlar, evden kaçma isteklerini sık sık ifade ederler.";
                }
                if (10 <= AileIliskileri(cevaplar) || 13 > AileIliskileri(cevaplar))
                {
                    label5.Text = @"Aile İlişkileri : Bu Özelliklere Aday Bir Kişidir ( % 75 - % 50 arası )
Bu alt ölçekten elde edilen puan bireyin ailesi ile olan ilişkilerini yansıtır. Puanın yüksek bulunması kişinin anne babası ve kardeşleri ile dostça ve sağlıklı ilişkiler içinde olduğunu, ailesini sevdiğini, ailesi tarafından sevildiğini gösterir.
	Bu tür bireyler aile üyelerini normal ölçüler içinde kendilerinden isteklerde bulunan ancak belli düzeyde bağımsız olma hakkını onlara tanıyan kişiler olarak görürler. Zamanlarının çoğunu aileleri ile evde geçirirler ve birlikte etkinlik gösterirler.
Aile ilişkileri puanının düşük bulunması ise bireyin ailesi ile olan ilişkilerinde karışıklık ve uyumsuzluk bulunduğuna işaret eder.
Genellikle ana babası ve kardeşleri ile problemleri olan bireyler aile üyelerini çok otoriter bulurlar, onların kendilerinden çok fazla şey beklediklerini düşünürler. Çok zorunlu durumlar dışında evde olmaktan kaçınırlar, evden kaçma isteklerini sık sık ifade ederler.";
                }
                if (7 < AileIliskileri(cevaplar) || 10 > AileIliskileri(cevaplar))
                {
                    label5.Text = @"Aile İlişkileri : Bu Özelliklere Sahip Olma Yeterliliği Düşüktür ( % 50 - % 25 arası )
Bu alt ölçekten elde edilen puan bireyin ailesi ile olan ilişkilerini yansıtır. Puanın yüksek bulunması kişinin anne babası ve kardeşleri ile dostça ve sağlıklı ilişkiler içinde olduğunu, ailesini sevdiğini, ailesi tarafından sevildiğini gösterir.
	Bu tür bireyler aile üyelerini normal ölçüler içinde kendilerinden isteklerde bulunan ancak belli düzeyde bağımsız olma hakkını onlara tanıyan kişiler olarak görürler. Zamanlarının çoğunu aileleri ile evde geçirirler ve birlikte etkinlik gösterirler.
Aile ilişkileri puanının düşük bulunması ise bireyin ailesi ile olan ilişkilerinde karışıklık ve uyumsuzluk bulunduğuna işaret eder.
Genellikle ana babası ve kardeşleri ile problemleri olan bireyler aile üyelerini çok otoriter bulurlar, onların kendilerinden çok fazla şey beklediklerini düşünürler. Çok zorunlu durumlar dışında evde olmaktan kaçınırlar, evden kaçma isteklerini sık sık ifade ederler.";
                }
                if (AileIliskileri(cevaplar) <= 6)
                {
                    label5.Text = @"Aile İlişkileri : Bu Özelliğe Sahip Olmaya Yeterliliği Çok Düşüktür ( % 25 ve altı ) 
Bu alt ölçekten elde edilen puan bireyin ailesi ile olan ilişkilerini yansıtır. Puanın yüksek bulunması kişinin anne babası ve kardeşleri ile dostça ve sağlıklı ilişkiler içinde olduğunu, ailesini sevdiğini, ailesi tarafından sevildiğini gösterir.
	Bu tür bireyler aile üyelerini normal ölçüler içinde kendilerinden isteklerde bulunan ancak belli düzeyde bağımsız olma hakkını onlara tanıyan kişiler olarak görürler. Zamanlarının çoğunu aileleri ile evde geçirirler ve birlikte etkinlik gösterirler.
Aile ilişkileri puanının düşük bulunması ise bireyin ailesi ile olan ilişkilerinde karışıklık ve uyumsuzluk bulunduğuna işaret eder.
Genellikle ana babası ve kardeşleri ile problemleri olan bireyler aile üyelerini çok otoriter bulurlar, onların kendilerinden çok fazla şey beklediklerini düşünürler. Çok zorunlu durumlar dışında evde olmaktan kaçınırlar, evden kaçma isteklerini sık sık ifade ederler.";
                }
                ////////////////////////////////////////
                if (13 <= SosyalIliskiler(cevaplar))
                {
                    label6.Text = @"Sosyal İlişkiler : Bu Özelliklere Sahip Olma Olasılığı Yüksektir ( % 75 üstü )
Sosyal ilişkiler puanı bireyin diğer insanlarla olan ilişkilerinin niteliğini belirtir. Puanın yüksek oluşu sosyal olgunluk yönünden bireyin uyumlu ve sosyal becerilerinin yüksek düzeyde olduğuna işaret eder. Bu kişiler arkadaşları ve diğer yetişkin grupları içinde mutlu ve rahat bir görünüm verirler. Konuşmaktan hoşlanırlar ve başkalarının söylediklerine ilgi gösterirler. Başkalarını sever ve başkaları tarafından sevilirler. Topluluk içinde esnek bir tutum benimserler, kabul gören davranışlar sergilerler. Kendilerini sosyal durumlarda uygun şekilde idare etmesini bilirler.
Sosyal ilişkiler puanının düşük olması ise bireyin sosyal beceriler ve sosyalleşme bakımından durgun olduğu anlamına gelir. Bu kişiler arkadaş ve yetişkin grupları içerisinde iken kendilerini mutlu ve rahat hissetmezler. Konuşmaktan ve başkaları ile bir arada olmaktan hoşlanmazlar. Dışarıdan gelen sosyal uyarıcılara tepki göstermede isteksiz hareket ederler ya da hiç tepki göstermezler.";
                }
                if (10 <= SosyalIliskiler(cevaplar) || 13 > SosyalIliskiler(cevaplar))
                {
                    label6.Text = @"Sosyal İlişkiler :Bu Özelliklere Aday Bir Kişidir ( % 75 - % 50 arası )
Sosyal ilişkiler puanı bireyin diğer insanlarla olan ilişkilerinin niteliğini belirtir. Puanın yüksek oluşu sosyal olgunluk yönünden bireyin uyumlu ve sosyal becerilerinin yüksek düzeyde olduğuna işaret eder. Bu kişiler arkadaşları ve diğer yetişkin grupları içinde mutlu ve rahat bir görünüm verirler. Konuşmaktan hoşlanırlar ve başkalarının söylediklerine ilgi gösterirler. Başkalarını sever ve başkaları tarafından sevilirler. Topluluk içinde esnek bir tutum benimserler, kabul gören davranışlar sergilerler. Kendilerini sosyal durumlarda uygun şekilde idare etmesini bilirler.
Sosyal ilişkiler puanının düşük olması ise bireyin sosyal beceriler ve sosyalleşme bakımından durgun olduğu anlamına gelir. Bu kişiler arkadaş ve yetişkin grupları içerisinde iken kendilerini mutlu ve rahat hissetmezler. Konuşmaktan ve başkaları ile bir arada olmaktan hoşlanmazlar. Dışarıdan gelen sosyal uyarıcılara tepki göstermede isteksiz hareket ederler ya da hiç tepki göstermezler.";
                }
                if (7 < SosyalIliskiler(cevaplar) || 10 > SosyalIliskiler(cevaplar))
                {
                    label6.Text = @"Sosyal İlişkiler : Bu Özelliklere Sahip Olma Yeterliliği Düşüktür ( % 50 - % 25 arası )
Sosyal ilişkiler puanı bireyin diğer insanlarla olan ilişkilerinin niteliğini belirtir. Puanın yüksek oluşu sosyal olgunluk yönünden bireyin uyumlu ve sosyal becerilerinin yüksek düzeyde olduğuna işaret eder. Bu kişiler arkadaşları ve diğer yetişkin grupları içinde mutlu ve rahat bir görünüm verirler. Konuşmaktan hoşlanırlar ve başkalarının söylediklerine ilgi gösterirler. Başkalarını sever ve başkaları tarafından sevilirler. Topluluk içinde esnek bir tutum benimserler, kabul gören davranışlar sergilerler. Kendilerini sosyal durumlarda uygun şekilde idare etmesini bilirler.
Sosyal ilişkiler puanının düşük olması ise bireyin sosyal beceriler ve sosyalleşme bakımından durgun olduğu anlamına gelir. Bu kişiler arkadaş ve yetişkin grupları içerisinde iken kendilerini mutlu ve rahat hissetmezler. Konuşmaktan ve başkaları ile bir arada olmaktan hoşlanmazlar. Dışarıdan gelen sosyal uyarıcılara tepki göstermede isteksiz hareket ederler ya da hiç tepki göstermezler.";
                }
                if (SosyalIliskiler(cevaplar) <= 6)
                {
                    label6.Text = @"Sosyal İlişkiler : Bu Özelliğe Sahip Olmaya Yeterliliği Çok Düşüktür ( % 25 ve altı ) 
Sosyal ilişkiler puanı bireyin diğer insanlarla olan ilişkilerinin niteliğini belirtir. Puanın yüksek oluşu sosyal olgunluk yönünden bireyin uyumlu ve sosyal becerilerinin yüksek düzeyde olduğuna işaret eder. Bu kişiler arkadaşları ve diğer yetişkin grupları içinde mutlu ve rahat bir görünüm verirler. Konuşmaktan hoşlanırlar ve başkalarının söylediklerine ilgi gösterirler. Başkalarını sever ve başkaları tarafından sevilirler. Topluluk içinde esnek bir tutum benimserler, kabul gören davranışlar sergilerler. Kendilerini sosyal durumlarda uygun şekilde idare etmesini bilirler.
Sosyal ilişkiler puanının düşük olması ise bireyin sosyal beceriler ve sosyalleşme bakımından durgun olduğu anlamına gelir. Bu kişiler arkadaş ve yetişkin grupları içerisinde iken kendilerini mutlu ve rahat hissetmezler. Konuşmaktan ve başkaları ile bir arada olmaktan hoşlanmazlar. Dışarıdan gelen sosyal uyarıcılara tepki göstermede isteksiz hareket ederler ya da hiç tepki göstermezler.";
                }
                /////////////////////////////
                if (13 <= SosyalNormlar(cevaplar))
                {
                    label7.Text = @"Sosyal Normlar : Bu Özelliklere Sahip Olma Olasılığı Yüksektir ( % 75 üstü )
Sosyal normlar puanı uyulması zorunlu yasal durumlara olduğu kadar dikkate alınması gereken sosyal kural ve toplum değerlerine ve başkalarının haklarına saygılı olma bunun yanı sıra kendi istek ve gereksinimlerini de toplumla uzlaşarak, belli ölçülerde bağımsız olarak karşılama gibi davranışları ölçer.
Sosyal normlar puanının yüksek olması bireyin başkalarının haklarını anlayışla karşıladığını, kişisel isteklerini grubun gereksinmelerine göre erteleyebildiğini ya da değiştirebildiğini gösterir. Bu kişiler toplumda neyin yanlış neyin doğru olarak kabul edildiğinin bilincindedirler.";
                }
                if (10 <= SosyalNormlar(cevaplar) || 13 > SosyalNormlar(cevaplar))
                {
                    label7.Text = @"Sosyal Normlar : Bu Özelliklere Aday Bir Kişidir ( % 75 - % 50 arası )
Sosyal normlar puanı uyulması zorunlu yasal durumlara olduğu kadar dikkate alınması gereken sosyal kural ve toplum değerlerine ve başkalarının haklarına saygılı olma bunun yanı sıra kendi istek ve gereksinimlerini de toplumla uzlaşarak, belli ölçülerde bağımsız olarak karşılama gibi davranışları ölçer.
Sosyal normlar puanının yüksek olması bireyin başkalarının haklarını anlayışla karşıladığını, kişisel isteklerini grubun gereksinmelerine göre erteleyebildiğini ya da değiştirebildiğini gösterir. Bu kişiler toplumda neyin yanlış neyin doğru olarak kabul edildiğinin bilincindedirler.";
                }
                if (7 < SosyalNormlar(cevaplar) || 10 > SosyalNormlar(cevaplar))
                {
                    label7.Text = @"Sosyal Normlar : Bu Özelliklere Sahip Olma Yeterliliği Düşüktür ( % 50 - % 25 arası )
Sosyal normlar puanı uyulması zorunlu yasal durumlara olduğu kadar dikkate alınması gereken sosyal kural ve toplum değerlerine ve başkalarının haklarına saygılı olma bunun yanı sıra kendi istek ve gereksinimlerini de toplumla uzlaşarak, belli ölçülerde bağımsız olarak karşılama gibi davranışları ölçer.
Sosyal normlar puanının yüksek olması bireyin başkalarının haklarını anlayışla karşıladığını, kişisel isteklerini grubun gereksinmelerine göre erteleyebildiğini ya da değiştirebildiğini gösterir. Bu kişiler toplumda neyin yanlış neyin doğru olarak kabul edildiğinin bilincindedirler.";
                }
                if (SosyalNormlar(cevaplar) <= 6)
                {
                    label7.Text = @"Sosyal Normlar : Bu Özelliğe Sahip Olmaya Yeterliliği Çok Düşüktür ( % 25 ve altı ) 
Sosyal normlar puanı uyulması zorunlu yasal durumlara olduğu kadar dikkate alınması gereken sosyal kural ve toplum değerlerine ve başkalarının haklarına saygılı olma bunun yanı sıra kendi istek ve gereksinimlerini de toplumla uzlaşarak, belli ölçülerde bağımsız olarak karşılama gibi davranışları ölçer.
Sosyal normlar puanının yüksek olması bireyin başkalarının haklarını anlayışla karşıladığını, kişisel isteklerini grubun gereksinmelerine göre erteleyebildiğini ya da değiştirebildiğini gösterir. Bu kişiler toplumda neyin yanlış neyin doğru olarak kabul edildiğinin bilincindedirler.";
                }
                //////////////////////////////////////////////////
                if (12 <= AntisosyalEgilimler(cevaplar))
                {
                    label8.Text = @"Antisosyal Eğilimler : Bu Özelliklere Sahip Olma Olasılığı Yüksektir ( % 75 üstü )
Anti sosyal eğilimler puanının düşük olması bireyin anti sosyal eğilimlere sahip olduğunu gösterir. Anti sosyal eğilimleri olan kişiler genellikle sert, öfkeyle dolu, kavgacı, incitme isteği duyan, zor kullanmaya eğilimli, öç alma duyguları içinde olan, saygısız bireylerdir. Eşyalara özellikle başkalarının eşyalarına zarar vermekten, bilinçli olarak toplumsal normlara ters düşen davranışlarda bulunmaktan hoşlanırlar ve bu şekilde kişisel doyum sağlamaya çalışırlar.
Anti sosyal eğilimler puanının yüksek olması bireyin belli ölçüler içinde bu tür eğilimleri olmadığına işaret eder.";
                }
                if (9 <= AntisosyalEgilimler(cevaplar) || 12 > AntisosyalEgilimler(cevaplar))
                {
                    label8.Text = @"Antisosyal Eğilimler : Bu Özelliklere Aday Bir Kişidir ( % 75 - % 50 arası )
Anti sosyal eğilimler puanının düşük olması bireyin anti sosyal eğilimlere sahip olduğunu gösterir. Anti sosyal eğilimleri olan kişiler genellikle sert, öfkeyle dolu, kavgacı, incitme isteği duyan, zor kullanmaya eğilimli, öç alma duyguları içinde olan, saygısız bireylerdir. Eşyalara özellikle başkalarının eşyalarına zarar vermekten, bilinçli olarak toplumsal normlara ters düşen davranışlarda bulunmaktan hoşlanırlar ve bu şekilde kişisel doyum sağlamaya çalışırlar.
Anti sosyal eğilimler puanının yüksek olması bireyin belli ölçüler içinde bu tür eğilimleri olmadığına işaret eder.";
                }
                if (6 < AntisosyalEgilimler(cevaplar) || 9 > AntisosyalEgilimler(cevaplar))
                {
                    label8.Text = @"Antisosyal Eğilimler : Bu Özelliklere Sahip Olma Yeterliliği Düşüktür ( % 50 - % 25 arası )
Anti sosyal eğilimler puanının düşük olması bireyin anti sosyal eğilimlere sahip olduğunu gösterir. Anti sosyal eğilimleri olan kişiler genellikle sert, öfkeyle dolu, kavgacı, incitme isteği duyan, zor kullanmaya eğilimli, öç alma duyguları içinde olan, saygısız bireylerdir. Eşyalara özellikle başkalarının eşyalarına zarar vermekten, bilinçli olarak toplumsal normlara ters düşen davranışlarda bulunmaktan hoşlanırlar ve bu şekilde kişisel doyum sağlamaya çalışırlar.
Anti sosyal eğilimler puanının yüksek olması bireyin belli ölçüler içinde bu tür eğilimleri olmadığına işaret eder.";
                }
                if (AntisosyalEgilimler(cevaplar) <= 6)
                {
                    label8.Text = @"Antisosyal Eğilimler : Bu Özelliğe Sahip Olmaya Yeterliliği Çok Düşüktür ( % 25 ve altı ) 
Anti sosyal eğilimler puanının düşük olması bireyin anti sosyal eğilimlere sahip olduğunu gösterir. Anti sosyal eğilimleri olan kişiler genellikle sert, öfkeyle dolu, kavgacı, incitme isteği duyan, zor kullanmaya eğilimli, öç alma duyguları içinde olan, saygısız bireylerdir. Eşyalara özellikle başkalarının eşyalarına zarar vermekten, bilinçli olarak toplumsal normlara ters düşen davranışlarda bulunmaktan hoşlanırlar ve bu şekilde kişisel doyum sağlamaya çalışırlar.
Anti sosyal eğilimler puanının yüksek olması bireyin belli ölçüler içinde bu tür eğilimleri olmadığına işaret eder.";
                }

            }
            else
            {
                MessageBox.Show("BU ANKET GEÇERSİZDİR");
                this.Close();
            }
        }

        public int GecerlilikAnaliz(Dictionary<int, string> cevaplar)
        {
            int gecerlilik = 0;
            if (cevaplar[20] == cevaplar[166])
            {
                gecerlilik++;
            }
            if (cevaplar[41] == cevaplar[142])
            {
                gecerlilik++;
            }
            if (cevaplar[62] == cevaplar[119])
            {
                gecerlilik++;
            }
            if (cevaplar[83] == cevaplar[94])
            {
                gecerlilik++;
            }
            if (cevaplar[125] == cevaplar[47])
            {
                gecerlilik++;
            }
            if (cevaplar[167] == cevaplar[0])
            {
                gecerlilik++;
            }
            return gecerlilik;
        }

        public int KendiniGerceklestirme(Dictionary<int, string> cevaplar)
        {
            int kendinigelistirmepuan = 0;
            kendinigelistirmepuan = HayırDondurucu(cevaplar[0]) + HayırDondurucu(cevaplar[21]) + HayırDondurucu(cevaplar[22]) + HayırDondurucu(cevaplar[84]) + HayırDondurucu(cevaplar[85]) + HayırDondurucu(cevaplar[86]) + HayırDondurucu(cevaplar[106]) + HayırDondurucu(cevaplar[128]) + HayırDondurucu(cevaplar[147]) + HayırDondurucu(cevaplar[148]) + HayırDondurucu(cevaplar[149]) + EvetDondurucu(cevaplar[1]) + EvetDondurucu(cevaplar[42]) + EvetDondurucu(cevaplar[43]) + EvetDondurucu(cevaplar[63]) + EvetDondurucu(cevaplar[64]) + EvetDondurucu(cevaplar[105]) + EvetDondurucu(cevaplar[126]) + EvetDondurucu(cevaplar[127]);
            return kendinigelistirmepuan;
        }

        public int DuygusalKararlilik(Dictionary<int, string> cevaplar)
        {
            int duygusalkararlilikpuan = 0;
            duygusalkararlilikpuan = HayırDondurucu(cevaplar[2]) + HayırDondurucu(cevaplar[3]) + HayırDondurucu(cevaplar[4]) + HayırDondurucu(cevaplar[23]) + HayırDondurucu(cevaplar[25]) + HayırDondurucu(cevaplar[44]) + HayırDondurucu(cevaplar[45]) + HayırDondurucu(cevaplar[46]) + HayırDondurucu(cevaplar[65]) + HayırDondurucu(cevaplar[66]) + HayırDondurucu(cevaplar[67]) + HayırDondurucu(cevaplar[87]) + HayırDondurucu(cevaplar[88]) + HayırDondurucu(cevaplar[109]) + HayırDondurucu(cevaplar[129]) + HayırDondurucu(cevaplar[130]) + HayırDondurucu(cevaplar[150]) + HayırDondurucu(cevaplar[151]) + EvetDondurucu(cevaplar[24]) + EvetDondurucu(cevaplar[108]);
            return duygusalkararlilikpuan;
        }

        public int NevrotikEgilimler(Dictionary<int, string> cevaplar)
        {
            int nevrotikegilimlerpuan = 0;
            nevrotikegilimlerpuan = HayırDondurucu(cevaplar[5]) + HayırDondurucu(cevaplar[6]) + HayırDondurucu(cevaplar[26]) + HayırDondurucu(cevaplar[27]) + HayırDondurucu(cevaplar[47]) + HayırDondurucu(cevaplar[48]) + HayırDondurucu(cevaplar[68]) + HayırDondurucu(cevaplar[69]) + HayırDondurucu(cevaplar[89]) + HayırDondurucu(cevaplar[90]) + HayırDondurucu(cevaplar[110]) + HayırDondurucu(cevaplar[111]) + HayırDondurucu(cevaplar[112]) + HayırDondurucu(cevaplar[131]) + HayırDondurucu(cevaplar[132]) + HayırDondurucu(cevaplar[133]) + HayırDondurucu(cevaplar[152]) + HayırDondurucu(cevaplar[153]) + HayırDondurucu(cevaplar[154]) + EvetDondurucu(cevaplar[91]);
            return nevrotikegilimlerpuan;

        }

        public int PsikolojikBelirtiler(Dictionary<int, string> cevaplar)
        {
            int psikolojikbelirtilerpuan = 0;
            psikolojikbelirtilerpuan = HayırDondurucu(cevaplar[7]) + HayırDondurucu(cevaplar[8]) + HayırDondurucu(cevaplar[9]) + HayırDondurucu(cevaplar[28]) + HayırDondurucu(cevaplar[29]) + HayırDondurucu(cevaplar[30]) + HayırDondurucu(cevaplar[49]) + HayırDondurucu(cevaplar[50]) + HayırDondurucu(cevaplar[51]) + HayırDondurucu(cevaplar[70]) + HayırDondurucu(cevaplar[71]) + HayırDondurucu(cevaplar[72]) + HayırDondurucu(cevaplar[92]) + HayırDondurucu(cevaplar[93]) + HayırDondurucu(cevaplar[113]) + HayırDondurucu(cevaplar[114]) + HayırDondurucu(cevaplar[134]) + HayırDondurucu(cevaplar[155]) + HayırDondurucu(cevaplar[156]) + EvetDondurucu(cevaplar[135]);
            return psikolojikbelirtilerpuan;

        }

        public int AileIliskileri(Dictionary<int, string> cevaplar)
        {
            int aileiliskileripuan = 0;
            aileiliskileripuan = HayırDondurucu(cevaplar[10]) + HayırDondurucu(cevaplar[52]) + HayırDondurucu(cevaplar[53]) + HayırDondurucu(cevaplar[73]) + HayırDondurucu(cevaplar[74]) + HayırDondurucu(cevaplar[95]) + HayırDondurucu(cevaplar[96]) + HayırDondurucu(cevaplar[115]) + HayırDondurucu(cevaplar[116]) + HayırDondurucu(cevaplar[117]) + HayırDondurucu(cevaplar[136]) + HayırDondurucu(cevaplar[137]) + HayırDondurucu(cevaplar[138]) + HayırDondurucu(cevaplar[157]) + HayırDondurucu(cevaplar[159]) + EvetDondurucu(cevaplar[11]) + EvetDondurucu(cevaplar[31]) + EvetDondurucu(cevaplar[32]) + EvetDondurucu(cevaplar[94]) + EvetDondurucu(cevaplar[158]);
            return aileiliskileripuan;
        }

        public int SosyalIliskiler(Dictionary<int, string> cevaplar)
        {
            int sosyaliliskilerpuan = 0;
            sosyaliliskilerpuan = EvetDondurucu(cevaplar[12]) + EvetDondurucu(cevaplar[14]) + EvetDondurucu(cevaplar[33]) + EvetDondurucu(cevaplar[34]) + EvetDondurucu(cevaplar[35]) + EvetDondurucu(cevaplar[54]) + EvetDondurucu(cevaplar[55]) + EvetDondurucu(cevaplar[75]) + EvetDondurucu(cevaplar[76]) + EvetDondurucu(cevaplar[77]) + EvetDondurucu(cevaplar[118]) + EvetDondurucu(cevaplar[140]) + EvetDondurucu(cevaplar[161]) + HayırDondurucu(cevaplar[13]) + HayırDondurucu(cevaplar[56]) + HayırDondurucu(cevaplar[97]) + HayırDondurucu(cevaplar[98]) + HayırDondurucu(cevaplar[119]) + HayırDondurucu(cevaplar[139]) + HayırDondurucu(cevaplar[160]);
            return sosyaliliskilerpuan;
        }

        public int SosyalNormlar(Dictionary<int, string> cevaplar)
        {
            int sosyalnormlarpuan = 0;
            sosyalnormlarpuan = EvetDondurucu(cevaplar[15]) + EvetDondurucu(cevaplar[37]) + EvetDondurucu(cevaplar[57]) + EvetDondurucu(cevaplar[58]) + EvetDondurucu(cevaplar[78]) + EvetDondurucu(cevaplar[99]) + EvetDondurucu(cevaplar[100]) + EvetDondurucu(cevaplar[120]) + EvetDondurucu(cevaplar[141]) + EvetDondurucu(cevaplar[142]) + EvetDondurucu(cevaplar[163]) + HayırDondurucu(cevaplar[16]) + HayırDondurucu(cevaplar[36]) + HayırDondurucu(cevaplar[79]) + HayırDondurucu(cevaplar[101]) + HayırDondurucu(cevaplar[121]) + HayırDondurucu(cevaplar[122]) + HayırDondurucu(cevaplar[143]) + HayırDondurucu(cevaplar[162]) + HayırDondurucu(cevaplar[164]);
            return sosyalnormlarpuan;
        }

        public int AntisosyalEgilimler(Dictionary<int, string> cevaplar)
        {
            int antisosyalegilimlerpuan = 0;
            antisosyalegilimlerpuan = HayırDondurucu(cevaplar[17]) + HayırDondurucu(cevaplar[18]) + HayırDondurucu(cevaplar[19]) + HayırDondurucu(cevaplar[38]) + HayırDondurucu(cevaplar[39]) + HayırDondurucu(cevaplar[40]) + HayırDondurucu(cevaplar[59]) + HayırDondurucu(cevaplar[60]) + HayırDondurucu(cevaplar[61]) + HayırDondurucu(cevaplar[80]) + HayırDondurucu(cevaplar[81]) + HayırDondurucu(cevaplar[102]) + HayırDondurucu(cevaplar[103]) + HayırDondurucu(cevaplar[123]) + HayırDondurucu(cevaplar[124]) + HayırDondurucu(cevaplar[144]) + HayırDondurucu(cevaplar[165]) + HayırDondurucu(cevaplar[166]) + EvetDondurucu(cevaplar[82]) + EvetDondurucu(cevaplar[145]);
            return antisosyalegilimlerpuan;
        }

        public int HayırDondurucu(string cevap)
        {
            if (cevap == "Hayır")
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }

        public int EvetDondurucu(string cevap)
        {
            if (cevap == "Evet")
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            this.AutoSize = true;
            this.AutoSizeMode = AutoSizeMode.GrowAndShrink;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string s1 = "";
            foreach (var item in this.Controls)
            {
                if (item is Label)
                {
                    Label mylbl = item as Label;
                    s1 += mylbl.Text.ToString() + "\r\n";
                }
            }
            
            Clipboard.SetText(s1);
        }
    }
}

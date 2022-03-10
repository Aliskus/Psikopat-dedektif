using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class durumlar : MonoBehaviour
{

    public Image resim;
    //Sprite myFruit = Resources.Load("cesed", typeof(Sprite)) as Sprite;
    public enum Secimler
    {
        basla, uyanma, telefonaBak, patronuAra, ofiseGit, sertCikis, sertCikisma, polisleKonus, cesedIncele, teyze, teyzedenSuphelen, arkadas, kavgaEt,
        arkadasSuphelen, bardakiAdam, barSuphelen, suphelenme, sakinOl, secim, secimTeyze, secimArkadas, secimAdam, son1, son2, son3
    }

    public enum Sahneler
    {
        basla, uyanma, telefonaBak
    }
    Sahneler currentScene;
    Secimler benimSecimim;
    public Text yazi;

    // Start is called before the first frame update
    void Start()
    {
        currentScene = Sahneler.basla;
        Basla();
    }

    // Update is called once per frame
    void Update()
    {
        if (benimSecimim == Secimler.basla) { Basla(); }
        else if (benimSecimim == Secimler.uyanma) { Uyanma(); }
        else if (benimSecimim == Secimler.telefonaBak) { TelefonaBak(); }
        else if (benimSecimim == Secimler.patronuAra) { PatronuAra(); }
        else if (benimSecimim == Secimler.ofiseGit) { OfiseGit(); }

        else if (benimSecimim == Secimler.sertCikis) { SertCikis(); }
        else if (benimSecimim == Secimler.sertCikisma) { SertCikisma(); }
        else if (benimSecimim == Secimler.polisleKonus) { PolisleKonus(); }
        else if (benimSecimim == Secimler.cesedIncele) { CesedIncele(); }

        else if (benimSecimim == Secimler.teyze) { Teyze(); }
        else if (benimSecimim == Secimler.teyzedenSuphelen) { TeyzedenSuphelen(); }
        else if (benimSecimim == Secimler.arkadas) { Arkadas(); }
        else if (benimSecimim == Secimler.arkadasSuphelen) { ArkadasSuphelen(); }
        else if (benimSecimim == Secimler.bardakiAdam) { BardakiAdam(); }
        else if (benimSecimim == Secimler.barSuphelen) { BarSuphelen(); }
        
        
        else if (benimSecimim == Secimler.suphelenme) {Suphelenme(); }

        else if (benimSecimim == Secimler.kavgaEt) { KavgaEt(); }
        else if (benimSecimim == Secimler.sakinOl) { SakinOl(); }
        else if (benimSecimim == Secimler.secim) { Secim(); }

        else if (benimSecimim == Secimler.secimTeyze) { SecimTeyze(); }
        else if (benimSecimim == Secimler.secimArkadas) { SecimArkadas(); }
        else if (benimSecimim == Secimler.secimAdam) { SecimAdam(); }
        else if (benimSecimim == Secimler.son1) { Son1(); }
        else if (benimSecimim == Secimler.son2) { Son2(); }
        else if (benimSecimim == Secimler.son3) { Son3(); }

    }
    


    public void Basla()
    {
        resim.sprite = Resources.Load<Sprite>("download");
        yazi.text = "Ankara'nın Kalbi Gölbaşı'nda sıradan bir gün daha geçiyordu." +
            " Bu güzel yerde Serhan adında bir dedektif yaşıyordu. Bu dedektif aldığı dosyaları kısa sürede çözmesiyle tanınırdı." +
            " Fakat son zamanlarda -kendi isteğiyle- aldığı seri cinayet dosyasını çözmekte epey sıkıntılar yaşıyordu." +
            " Hele bir de vakaların olduğu günler çektiği baş ağrısı canını oldukça sıkıyordu. Bir sabah yine aynı baş ağrısıyla uyanmıştı...\n" +
            " (SAHNELERİ GEÇMEK İÇİN SPACE KULLANIN)";
        if (Input.GetKeyDown(KeyCode.Space))
            benimSecimim = Secimler.uyanma;
    }
    
    public void Uyanma()
    {
        resim.sprite = Resources.Load<Sprite>("uyanma");
        yazi.text = "Ağğhhhh... \n Yine mi baş ağrısı. Beni delirtecek. Keşke kafam kopsa da rahatlasam. " +
            "Dün ne yapmış olabilirim ki böyle bir lanet çekiyorum.";
        
        if (Input.GetKeyDown(KeyCode.Space))
            benimSecimim = Secimler.telefonaBak;
    }

    public void TelefonaBak()
    {
        resim.sprite = Resources.Load<Sprite>("telefon");
        yazi.text = " Oh NO..\n Saat de amma geç olmuş. Yine işe geç kaldım..\n Lanet olsun.. 5 kere.. BE5Ş55!!\n El insaf be ADAM\n" +
            " Patronu ara-> A\n Aramadan hazırlanıp git -> B";

        if (Input.GetKeyDown(KeyCode.A))
            benimSecimim = Secimler.patronuAra;
        if (Input.GetKeyDown(KeyCode.B))
            benimSecimim = Secimler.ofiseGit;
    }


    public void PatronuAra()
    {
        resim.sprite = Resources.Load<Sprite>("konusma");
        yazi.text = "Dedektif:\n ııee.. Alo patron.. Bir yakınım için hastaneye gitmiştim. Telefonu evde unutmuşum.\n" +
            "Patron:\n Saatin kaç olduğunun farkında mısın ? Önceden haber vermeye beynin mi yetmedi.. Neyse.. Bir an önce ofise gel." +
            "Yeni vaka var.\n";
        if (Input.GetKeyDown(KeyCode.Space))
            benimSecimim = Secimler.ofiseGit;

    }

    public void OfiseGit()
    {
        resim.sprite = Resources.Load<Sprite>("patron");
        yazi.text = "Dedektif hiç oyalanmadan baş ağrısıyla hazırlanıp evden çıkar.. ve ofise gelir.\n\n" +
            "Patronun odasına girer ve karşısına oturur *Patron ciddi gözüküyor, yine boş yapacak..*\n" +
            "PATRON:\nSeni aşağılık HERİF!!! Sana KAÇ KERE bu şekilde geç gelmemen gerektiğini söyledim APTAL!!1!\n" +
            "*Bu adam beni sinir ediyor buna ağzının payını versem mi sakin mi kalmaya çalışsam*\nDEDEKTİF:\n" +
            "A-> Ağzının payını ver!\n" +
            "B-> Sakin kal evlat";
        if (Input.GetKeyDown(KeyCode.A))
            benimSecimim = Secimler.sertCikis;
        if (Input.GetKeyDown(KeyCode.B))
            benimSecimim = Secimler.sertCikisma;
    }

    public void SertCikis()
    {
        resim.sprite = Resources.Load<Sprite>("patron");
        yazi.text = "İŞTEN KOVULDUN SPACE BAS";
        if (Input.GetKeyDown(KeyCode.Space))
            benimSecimim = Secimler.basla;
    }

    public void SertCikisma()
    {
        resim.sprite = Resources.Load<Sprite>("patron");
        yazi.text = "DEDEKTİF:\nÖzür dilerim patron. Lütfen beni affet, bir daha olmayacak söz veriyorum.\n" +
            "PATRON:\n" +
            "Neyse.. Acilen Ankara Üniversitesi Gölbaşı kampüsüne gitmen gerek. Yine aynı şey oldu, adam durmuyor. Lanet olası..\n" +
            "DEDEKTİF:\n" +
            "Tamam patron hemen gidiyorum.";
        if (Input.GetKeyDown(KeyCode.Space))
            benimSecimim = Secimler.polisleKonus;
    }

    public void PolisleKonus()
    {
        resim.sprite = Resources.Load<Sprite>("olayYeri");
        yazi.text = "Cinayet mahaline gelir ve olay yeri incelemeden Abuziddin ile konuşur\n" +
            "DEDEKTİF:\nNasılsın Abuziddin, işker güçler nasıl gidiyor ?\n" +
            "ABUZİDDİN:\nNolcak işte *** yine ölüleri inceliyoruz.. Boş yapma da git merhumun teyzesiyle konuş. Tek akrabası teyzesiymiş.\n" +
            "DEDEKTİF:\nTamam içerisi hazırsa ben de gidip bakayım. Sonra gider konuşurum.\n" +
            "Cesedi incelemeye gider..";
        if (Input.GetKeyDown(KeyCode.Space))
            benimSecimim = Secimler.cesedIncele;
    }

    public void CesedIncele()
    {
        resim.sprite = Resources.Load<Sprite>("cesed");
        yazi.text = "OH FU*K.. Yine gözleri oyulmuş bir ceset.. Aynı o zamanki gibi.. Bu görüntü midemi bulandırıyor. Bu işi bırakmayı düşünüyorum." +
            " Ama zaten bunun için bu mesleği seçmedim mi ? Annemi öldüren katilin kesinlikle bu işle bir bağlantısı olmalı, I will find that bastard!!";
        if (Input.GetKeyDown(KeyCode.Space))
            benimSecimim = Secimler.teyze;
    }

    public void Suphelenme()
    {

        yazi.text = "NE BİÇİM DEDEKTİFSİN UÇAN KUŞTAN BİLE ŞÜPHELENECEKSİN!!11!";
        if (Input.GetKeyDown(KeyCode.Space))
            benimSecimim = Secimler.basla;
    }
    public void Teyze()
    {
        resim.sprite = Resources.Load<Sprite>("teyze");
        yazi.text = "Teyzesine gelir.\n" +
            "DEDEKTİF:\nSon zamanlarda bir düşmanı, anlaşamadığı birisi var mıydı ?\n" +
            "TEYZE:\nKendsiyle 3 aydır görüşmüyorum.. Onun yüzünü şeytan görsün.." +
            " Zaten o lanet arkadaşıyla fazlasıyla yaşadı. Tek söyleyebileceğim o pislik arkadaşının yurtların ilerisindeki evde yaşadığı.\n" +
            "A-> Teyzeden şüphelen\nB-> Teyzeden şüphelenme";
        if (Input.GetKeyDown(KeyCode.A))
            benimSecimim = Secimler.teyzedenSuphelen;
        if (Input.GetKeyDown(KeyCode.B))
            benimSecimim = Secimler.suphelenme;
    }

    public void TeyzedenSuphelen()
    {
        resim.sprite = Resources.Load<Sprite>("teyze");
        yazi.text = "Ne garip bir kadın.. İnsan akrabası hakkında böyle konuşur mu.. Neyse gidelim bakalım arkadaşı kimmiş\n";
        if (Input.GetKeyDown(KeyCode.Space))
            benimSecimim = Secimler.arkadas;
    }

    public void Arkadas()
    {
        resim.sprite = Resources.Load<Sprite>("arkadas");
        yazi.text = "DEDEKTİF:\nSelam delikanlı. Arkadaşının ölümünden haberin var mı ?\n" +
            "ARKADAŞ:\nEvet var. Ama bundan sanane MORUK! Sen git torunlarınla çiftlik evinde emekliğinin tadını çıkar MOTHER F*CKER\n" +
            "*Bu dallama bana ne diyor LAN. Yine sakinliğimi koruyayım mı yoksa kafa göz dalıyım mı*\n" +
            "A-> Kafa göz dal\nB-> Sakin ol evlat, yine";
        if (Input.GetKeyDown(KeyCode.A))
            benimSecimim = Secimler.kavgaEt;
        if (Input.GetKeyDown(KeyCode.B))
            benimSecimim = Secimler.sakinOl;
    }
    public void KavgaEt()
    {
        resim.sprite = Resources.Load<Sprite>("arkadas");
        yazi.text = "TÜM MAHALLE TOPLANIP AĞZINI YÜZÜNÜ KIRDI\nBİRAZ SAKİN KALMAYI ÖĞRENMELİSİN";
        if (Input.GetKeyDown(KeyCode.Space))
            benimSecimim = Secimler.basla;
    }
    public void SakinOl()
    {
        resim.sprite = Resources.Load<Sprite>("arkadas");
        yazi.text = "DEDEKTİF:\nSakin ol evlat, bu benim işim. Son günlerde beraber miydiniz, bildiğin bir şey var mı ?\n" +
            "ARKADAŞ:\nDün beraberdik. Aşağıdaki barda bir adamla tartışmıştı bence o yapmıştır, aşağılık herifin tekiydi.\n" +
            "A-> Arkadaşından şüphelen\nB-> Arkadaşından şüphelenme";
        if (Input.GetKeyDown(KeyCode.A))
            benimSecimim = Secimler.arkadasSuphelen;
        if (Input.GetKeyDown(KeyCode.B))
            benimSecimim = Secimler.suphelenme;
    }
    
    public void ArkadasSuphelen()
    {
        resim.sprite = Resources.Load<Sprite>("arkadas");
        yazi.text = "Terbiyesiz herifin teki.. Yeni gençler de hep böyle.. Çok şüpheli bi tip, gözüm hiç tutmadı.";
        if (Input.GetKeyDown(KeyCode.Space))
            benimSecimim = Secimler.bardakiAdam;
    }

    public void BardakiAdam()
    {
        resim.sprite = Resources.Load<Sprite>("bar");
        yazi.text = "DEDEKTİF:  Dün kavga ettiğin adam var ya..\n" +
            "ADAM:  ???\n" +
            "DEDEKTİF:  ÖLDÜ!!!\nADAM:    Allah rahmet eylesin çok da üzülmedim.\nDEDEKTİF: Neden kavga ettiiniz?\nADAM:    Bu seni alakadar etmez..\n" +
            "A-> Adamdan şüphelen\nB-> Adamdan şüphelenme";
        if (Input.GetKeyDown(KeyCode.A))
            benimSecimim = Secimler.barSuphelen;
        if (Input.GetKeyDown(KeyCode.B))
            benimSecimim = Secimler.suphelenme;
    }

    public void BarSuphelen()
    {
        resim.sprite = Resources.Load<Sprite>("bar");
        yazi.text = "Kesinlikle en şüphelileri bu. Alkolik adamdan ne beklersin zaten.";
        if (Input.GetKeyDown(KeyCode.Space))
            benimSecimim = Secimler.secim;
    }
    
    public void Secim()
    {
        yazi.text = "*Katili bulmaya ilk defa bu kadar yaklaştım. Bu üçünden biri kesinlikle katil olmalı.*\nBirini seçip takip etmeliyim.\n" +
            "T-> TEYZE\nA-> ARKADAŞ\nB-> BARDAKİ ADAM";
        if (Input.GetKeyDown(KeyCode.T))
            benimSecimim = Secimler.secimTeyze;
        if (Input.GetKeyDown(KeyCode.A))
            benimSecimim = Secimler.secimArkadas;
        if (Input.GetKeyDown(KeyCode.B))
            benimSecimim = Secimler.secimAdam;
    }

    public void SecimTeyze()
    {
        resim.sprite = Resources.Load<Sprite>("teyzeEv");
        yazi.text = "GECE KADININ EVİNİ GÖZETLEMEYE BAŞLADI VE KADININ BALKONDA TEDİRGİN BİR ŞEKİLDE OTURDUĞUNU GÖRDÜ. ANNESİNİN KATİLİNİ BULDUĞUNU DÜŞÜNÜP DAHA FAZLA SABREDEMEDEN" +
            " EVE DOĞRU YOL ALDI.";
        if (Input.GetKeyDown(KeyCode.Space))
            benimSecimim = Secimler.son1;
    }


    public void SecimArkadas()
    {
        resim.sprite = Resources.Load<Sprite>("takip");
        yazi.text = "KESİNLİKLE BU TİPİN BÖYLE BİR ŞEY YAPMASINA OLANAK VERİYORDU DEDEKTİF. ONU İNCELEMEYE BİLE GEREK YOKTU. " +
            "AMA EMİN OLMAK ADINA BİRAZ DAHA GÖZLEMLEDİ VE EVDEN ÇIKTIĞINI GÖRÜP PEŞİNDEN TAKİP ETTİ.";
        if (Input.GetKeyDown(KeyCode.Space))
            benimSecimim = Secimler.son2;
    }


    public void SecimAdam()
    {
        resim.sprite = Resources.Load<Sprite>("takip");
        yazi.text = "ARALARINDA BİR SIKINTI OLDUĞU BELLİYDİ. DEDEKTİF EN ÇOK BU ADAMDAN ŞÜPHELENİYORDU. " +
            "ADAM BARDAN GEÇ SAATTE ÇIKIP EVİNE YOL ALIRKEN DEDEKTİF ONU TAKİP ETTİ.";
        if (Input.GetKeyDown(KeyCode.Space))
            benimSecimim = Secimler.son3;
    }

    public void Son1()
    {
        resim.sprite = Resources.Load<Sprite>("kurbanArk");
        yazi.text = "Üff yine mi...";
    }
    public void Son2()
    {
        resim.sprite = Resources.Load<Sprite>("kurbanTeyz");
        yazi.text = "Üff yine mi...";
    }
    public void Son3()
    {
        resim.sprite = Resources.Load<Sprite>("kurbanBar");
        yazi.text = "Üff yine mi...";
    }

}

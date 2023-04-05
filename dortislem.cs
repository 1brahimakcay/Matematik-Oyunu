using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class dortislem : MonoBehaviour
{
    public UnityEngine.UI.Text ilksayi,ikincisayi,islem,cevap,sonuc;
    int sayi1,sayi2,islemisareti;
    int islemsonucu;
    public UnityEngine.UI.InputField sonucinput;
    // Start is called before the first frame update
    void Start()
    {
        yenisoru();
        
    }

    // Update is called once per frame
    void Update()
    {  }   
        

        
            public void cevapkontrol(){
            if(int.Parse(cevap.text)==islemsonucu) 

            {
                sonuc.text="DOĞRU";
                
            } else
            
                {sonuc.text="YANLIŞ";}
            
        } 
        public void yenisoru()
        {
            sonucinput.text = "";
            cevap.text="";
            sonuc.text="";
sayi1 = Random.Range (1,10);
        sayi2 = Random.Range (1,10);
        islemisareti = Random.Range (1,5);
        switch (islemisareti)
        {
            
            case 1: islem.text="+";
            islemsonucu = sayi1 + sayi2;
            break;
            case 2: islem.text="-";
            islemsonucu = sayi1 - sayi2;
            break;
            case 3: islem.text="*";
            islemsonucu = sayi1 * sayi2;
            break;
            
//             Case4:
// sayi1= sayi1*sayi2;

// islem.text = "/";

// islemSonucu = sayi1 / sayi2;

// break;

            case 4: islem.text="/";
            sayi1 = sayi1*sayi2;
            islemsonucu = sayi1 / sayi2;
            break;
        }
        ilksayi.text = sayi1 + "";
        ikincisayi.text = sayi2 + "";
        }

}
 
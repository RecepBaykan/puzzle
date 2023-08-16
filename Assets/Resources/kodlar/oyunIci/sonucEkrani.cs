using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sonucEkrani : MonoBehaviour
{
    public static Vector2 eskiSonucKonum;
    public static Vector2 eskiKaybettinKonum;
    kayitBilgileri k = new kayitBilgileri();
    public static bool kazandinParayi;
    public static Vector2 k1;
    public static Vector2 k2;
    public static Vector2 k3;
    [SerializeField] private GameObject parent;
    [SerializeField] private  GameObject cerceve;
    [SerializeField] private GameObject resimNesnesi;
    [SerializeField] private GameObject sonuc;
    [SerializeField] private GameObject durdurButton;
    [SerializeField] private GameObject resimGoster;
    [SerializeField] private GameObject kazandin;
    [SerializeField] private GameObject miktarr;
    // Start is called before the first frame update
    void Start()
    {
        sonuc.SetActive(false);
        eskiSonucKonum = sonuc.transform.GetChild(0).transform.position;
        eskiKaybettinKonum =    sonuc.transform.GetChild(1).transform.position;
        k1 = resimGoster.transform.position;
        k2 = resimNesnesi.transform.position;
        k3 = durdurButton.transform.position;
    }

    // Update is called once per frame

    private void Update()
    {
       if (!dusenParcalar.sureBaslat)
        {
            resimGoster.transform.position = new Vector2(Screen.width * 4, Screen.height);
            resimNesnesi.transform.position = new Vector2(Screen.width * 4, Screen.height);
            durdurButton.transform.position = new Vector2(Screen.width * 4, Screen.height);
        }
        else
        {
            resimGoster.transform.position = k1;
         
            durdurButton.transform.position = k3;
        }
        if(sure.zaman <= 0)
        {
            kaybet();
            resimGoster.transform.position = new Vector2(Screen.width * 4, Screen.height);
            resimNesnesi.transform.position = new Vector2(Screen.width * 4, Screen.height);
            durdurButton.transform.position = new Vector2(Screen.width * 4, Screen.height);
          
                parent.SetActive(false);
                cerceve.SetActive(false);
           
          
            
        }
        else
        {
            if (kontrol.Kazandin)
            {
                kazan();
                resimGoster.transform.position = new Vector2(Screen.width * 4, Screen.height);
                resimNesnesi.transform.position = new Vector2(Screen.width * 4, Screen.height);
                durdurButton.transform.position = new Vector2(Screen.width * 4, Screen.height);
            }
        }
       
    }



    void kazan()
    {
        sonuc.SetActive(true);
        if(Vector3.Distance(sonuc.transform.GetChild(0).transform.position,new Vector3(Screen.width / 2, Screen.height / 2)) <= 20f)
        {
           sonuc.transform.GetChild(0).transform.position = new Vector3(Screen.width / 2, Screen.height / 2);
        }
        if(sonuc.transform.GetChild(0).transform.position ==  new Vector3(Screen.width/2, Screen.height / 2))
        {
            yildizKap();
        }
        else
        {
            sonuc.transform.GetChild(0).transform.position = Vector2.Lerp(sonuc.transform.GetChild(0).transform.position, new Vector2(Screen.width / 2, Screen.height / 2), 
            Time.deltaTime*3f);
        }
       

    }

    

    void kaybet()
    {
        sonuc.SetActive(true);
        durdur.sureyiDurdur = true;
        if (Vector3.Distance(sonuc.transform.GetChild(1).transform.position, new Vector3(Screen.width / 2, Screen.height / 2)) <= 20f)
        {
            sonuc.transform.GetChild(1).transform.position = new Vector3(Screen.width / 2, Screen.height / 2);
        }
        if (sonuc.transform.GetChild(1).transform.position == new Vector3(Screen.width / 2, Screen.height / 2))
        {
        
        }
        else
        {
            sonuc.transform.GetChild(1).transform.position = Vector2.Lerp(sonuc.transform.GetChild(1).transform.position, new Vector2(Screen.width / 2, Screen.height / 2),
            Time.deltaTime * 3f);
        }
    }

    void yildizKap()
    {
       
        if (sure.zaman>= 60)
        {
            
            k.seviye[int.Parse(butonBilgileri.resim)] = 3;
            kazandin.transform.GetChild(0).GetComponent<UnityEngine.UI.Image>().sprite = yildizlariKap.sprite;
            kazandin.transform.GetChild(1).GetComponent<UnityEngine.UI.Image>().sprite = yildizlariKap.sprite;
            kazandin.transform.GetChild(2).GetComponent<UnityEngine.UI.Image>().sprite = yildizlariKap.sprite;
        }
        else
        {
            if (sure.zaman >= 30)
            {
              
             
                kazandin.transform.GetChild(0).GetComponent<UnityEngine.UI.Image>().sprite = yildizlariKap.sprite;
                kazandin.transform.GetChild(1).GetComponent<UnityEngine.UI.Image>().sprite = yildizlariKap.sprite;
                kazandin.transform.GetChild(2).GetComponent<UnityEngine.UI.Image>().sprite = yildizlariKap.spriteOr;
                if (kaydet.yukle().seviye[int.Parse(butonBilgileri.resim)] > 2)
                {
                    k.seviye[int.Parse(butonBilgileri.resim)] = kaydet.yukle().seviye[int.Parse(butonBilgileri.resim)];
                }
                else
                {
                    k.seviye[int.Parse(butonBilgileri.resim)] = 2;
                }
            }
            else
            {
              
                
                kazandin.transform.GetChild(0).GetComponent<UnityEngine.UI.Image>().sprite = yildizlariKap.sprite;
                kazandin.transform.GetChild(1).GetComponent<UnityEngine.UI.Image>().sprite = yildizlariKap.spriteOr;
                kazandin.transform.GetChild(2).GetComponent<UnityEngine.UI.Image>().sprite = yildizlariKap.spriteOr;
                if (kaydet.yukle().seviye[int.Parse(butonBilgileri.resim)] > 1)
                {
                    k.seviye[int.Parse(butonBilgileri.resim)] = kaydet.yukle().seviye[int.Parse(butonBilgileri.resim)];
                }
                else
                {
                    k.seviye[int.Parse(butonBilgileri.resim)] = 1;
                }
            }
        }
        
        miktarr.GetComponent<TMPro.TextMeshProUGUI>().text = (kaydetAltin.yukle().altin-kontrol.tempAltin).ToString();
       
       
        int bolum = int.Parse(butonBilgileri.resim);
    
       
        _durum.yuklee(k,bolum, kaydet.yukle().kaldigin_yer);
        if (!kazandinParayi)
        {
            kaydetAltin.kayit(kontrol.a);
            kazandinParayi = true;
        }
       

        
        
    }

}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class _durum : MonoBehaviour
{
    kayitBilgileri k = new kayitBilgileri();
    [SerializeField] private GameObject silme;
    [SerializeField] private GameObject onay;
  
   
    // Start is called before the first frame update
    void Start()
    {
        onaylar();

    
        
       
    }

    // Update is called once per frame
  
    void onaylar()
    {
       /* GameObject.Find("muzikOnay").GetComponent<UnityEngine.UI.Toggle>().isOn = kaydet.yukle().m�zikAcik;
        GameObject.Find("sesOnay").GetComponent<UnityEngine.UI.Toggle>().isOn = kaydet.yukle().sesAcik;*/
       onay.GetComponent<UnityEngine.UI.Toggle>().isOn = false;
    }

   public void sesAc()
    {
        
        yuklee(k,-1);

    }

    public void sifirla()
    {
        silme.SetActive(true);
        silme.transform.position = new Vector2(Screen.width / 2, Screen.height / 2);
        
        onay.GetComponent<UnityEngine.UI.Toggle>().isOn = false;


    }
    public void evet()
    {
        altinBilgisi a = new altinBilgisi();
        a.altin = 0;
        sureBilgisi s = new sureBilgisi();
        canBilgisi c = new canBilgisi();
        kayitBilgileri k = new kayitBilgileri();
        k.kaldigin_yer = 1;
        c.can = 5;
        kaydetAltin.kayit(a);
        
       
        kaydetSure.yukle().sure = 300;
        kaydet.kayit(k);
        kaydetCan.kayit(c);
        kilitlemeSistemi.geciciKilit = new bool[resimIsimleri.resim.Length];
        silme.SetActive(false);
        //GameObject.Find("silmeOnayi").transform.position = new Vector2(Screen.width *4, Screen.height *4);
    }

    public  void hayir()
    {
        silme.SetActive(false);
        //GameObject.Find("silmeOnayi").transform.position = new Vector2(Screen.width * 4, Screen.height * 4);
    }

  public  void muzikAc()
    {

        yuklee(k,-1);
    }

  public static  void yuklee(kayitBilgileri k,int bolum)
    {
        
    
        
       // k.sesAcik = GameObject.Find("muzikOnay").GetComponent<UnityEngine.UI.Toggle>().isOn;
        // k.m�zikAcik = GameObject.Find("muzikOnay").GetComponent<UnityEngine.UI.Toggle>().isOn;
        for (int i = 0; i < kaydet.yukle().seviye.Length; i++)
        {
            if( i == bolum)
            {
                continue;
            }
            else
            {
                k.seviye[i] = kaydet.yukle().seviye[i];
            }
          
        }
        
        k.kaldigin_yer = kaydet.yukle().kaldigin_yer;
        kaydet.kayit(k);
        
    }
    public static void yuklee(kayitBilgileri k, int bolum, int kayit)
    {



        // k.sesAcik = GameObject.Find("muzikOnay").GetComponent<UnityEngine.UI.Toggle>().isOn;
        // k.m�zikAcik = GameObject.Find("muzikOnay").GetComponent<UnityEngine.UI.Toggle>().isOn;
        for (int i = 0; i < kaydet.yukle().seviye.Length; i++)
        {
            if (i == bolum)
            {
                continue;
            }
            else
            {
                k.seviye[i] = kaydet.yukle().seviye[i];
            }

        }

        k.kaldigin_yer = kayit;
        kaydet.kayit(k);
       
    }

}

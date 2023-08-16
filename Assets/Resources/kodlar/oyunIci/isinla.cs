using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class isinla : MonoBehaviour
{
    // Start is called before the first frame update
   
    public void anaMenu()
    {

        SceneManager.LoadScene("anaMenu", LoadSceneMode.Single);
        GameObject.Find("sonuc").transform.GetChild(0).transform.position = sonucEkrani.eskiSonucKonum;
        GameObject.Find("sonuc").transform.GetChild(1).transform.position = sonucEkrani.eskiKaybettinKonum;
        oyna.oyunda = false;
    }
    public void seviyeEkrani()
    {
       
        SceneManager.LoadScene("seviyeler", LoadSceneMode.Single);
        GameObject.Find("sonuc").transform.GetChild(0).transform.position = sonucEkrani.eskiSonucKonum;
        GameObject.Find("sonuc").transform.GetChild(1).transform.position = sonucEkrani.eskiKaybettinKonum;
        oyna.oyunda = false;
    }

    public void siradakiSeviye()
    {
        if(kaydetCan.yukle().can <= 0)
        {
            seviyeEkrani();
            yokEt.yok();

        }
        else
        {
            GameObject.Find("sonuc").transform.GetChild(0).transform.position = sonucEkrani.eskiSonucKonum;
            GameObject.Find("sonuc").transform.GetChild(1).transform.position = sonucEkrani.eskiKaybettinKonum;
            yokEt.yok();
            durdur.sureyiDurdur = false;
            dusenParcalar.sureBaslat = false;
            sure.zaman = oyunBilgiler.Sure;
            butonBilgileri.resim = (int.Parse(butonBilgileri.resim) + 1).ToString();
            kayitBilgileri k = new kayitBilgileri();
            for (int i = 0; i < resimIsimleri.resim.Length; i++)
            {
                k.seviye[i] = kaydet.yukle().seviye[i];
            }
            k.kaldigin_yer = int.Parse(butonBilgileri.resim)/6 +1 ;

            kaydet.kayit(k);

            oyna.hazirla();
           
        }
       
   
        
        
    }

    public void yeniden()
    {
        if (kaydetCan.yukle().can <= 0)
        {
            seviyeEkrani();
           
        }
        else
        {
        
            durdur.sureyiDurdur = false;
            dusenParcalar.sureBaslat = false;
            sure.zaman = oyunBilgiler.Sure;
            butonBilgileri.resim = (int.Parse(butonBilgileri.resim)).ToString();
            oyna.hazirla();
            GameObject.Find("sonuc").transform.GetChild(0).transform.position = sonucEkrani.eskiSonucKonum;
            GameObject.Find("sonuc").transform.GetChild(1).transform.position = sonucEkrani.eskiKaybettinKonum;
            oyna.oyunda = false;
        }
     
    }


}

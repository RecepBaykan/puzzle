using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.SymbolStore;
using UnityEngine;
using UnityEngine.SceneManagement;

public class oyna : MonoBehaviour
{
    public static bool azalt;
   public static bool hazirlandi;
    // Start is called before the first frame update
 public  static canBilgisi c = new canBilgisi();
 public  static bool caninYokki;
  public  static GameObject canYokYazisi;
  public  static float canYokSuresi;
  public  static bool biKereBas;
    public static bool oyunda = false;
   public static Vector2 kalpGecici;

     void Start()
    {
        
       
    }
    public static void hazirla()
    {
        sirala.resim = (Texture2D)Resources.Load("resimler/" + butonBilgileri.resim);
        sirala.bgText = (Texture2D)Resources.Load("bg/" + "bg");
        

        for (int i = 1; i < resimIsimleri.resim.Length / 24 +2 ; i++)
        {
            for (int j = 1; j < resimIsimleri.resim.Length; j++)
            {
                if (int.Parse(butonBilgileri.resim) < i * (24) && !hazirlandi)
                {
                    if (sirala.resim.width > sirala.resim.height)
                    {
                        sirala.gen = 2 + i;
                        sirala.yuk = 1 + i;



                    }
                    else
                    {
                        if (sirala.resim.width < sirala.resim.height)
                        {
                            sirala.gen = 1 + i;
                            sirala.yuk = 2 + i;

                        }
                        else
                        {
                            sirala.gen = 7;
                            sirala.yuk = 7;
                        }
                    }
                  
                    
                       
                    
                    hazirlandi = true;
                }
            }


        }

        sirala.enBoyParcaX = 0.7f;
        sirala.enBoyParcaY = 0.7f;
       
        if (sirala.gen * sirala.yuk >= 16)
        {
            sirala.enBoyKutu = 0.09f;

        }
        else
        {
            sirala.enBoyKutu = 0.2f;
        }



        kayitBilgileri k = new kayitBilgileri();
        for (int i = 0; i < resimIsimleri.resim.Length; i++)
        {
            k.seviye[i] = kaydet.yukle().seviye[i];
        }
        k.kaldigin_yer = int.Parse(butonBilgileri.resim) / 6 + 1;

        kaydet.kayit(k);

        //sure.zaman = oyunBilgiler.Sure;
        durdur.sureyiDurdur = false;
        dusenParcalar.sureBaslat = false;
        hazirlandi = false;
        sure.zaman = oyunBilgiler.Sure;
   
        kontrol.Kazandin = false;
      
        butonBilgileri.parsomenKilidi = false;
        resmiGoster.goster = false;
      


       
        c.can = kaydetCan.yukle().can;
        if(c.can >= 1)
        {
            if (oyunda)
            {
                c.can -= 1;
                azalt = true;
                SceneManager.LoadScene("game", LoadSceneMode.Single);
                kaydetCan.kayit(c);
                azalt = false;

            }
            else
            {
                GameObject.Find("oyna").SetActive(false);
                GameObject.Find("azalma").transform.position = canHizala.canAzalmaKonumu;
                GameObject.Find("kalpResmi").transform.position = GameObject.Find("parsomen").transform.position;
                GameObject.Find("canYazisi").GetComponent<TMPro.TextMeshProUGUI>().text = (c.can - 1).ToString();
                c.can -= 1;
                azalt = true;

            }


        }
        else
        {
            if (!biKereBas)
            {
                if (!oyunda)
                {
                    canYokYazisi = new GameObject();
                    canYokYazisi.AddComponent<TMPro.TextMeshProUGUI>();
                    canYokYazisi.GetComponent<TMPro.TextMeshProUGUI>().text = "Canınız Yoktur";
                    canYokYazisi.GetComponent<TMPro.TextMeshProUGUI>().alignment = TMPro.TextAlignmentOptions.Center; 
                    canYokYazisi.GetComponent<TMPro.TextMeshProUGUI>().color = Color.red;
                    canYokYazisi.GetComponent<TMPro.TextMeshProUGUI>().fontWeight = TMPro.FontWeight.Bold;
                    canYokYazisi.transform.parent = GameObject.Find("parsomen").transform;
                    canYokYazisi.transform.position = GameObject.Find("parsomen").transform.position;
                    canYokSuresi = 2f;

                    caninYokki = true;
                    biKereBas = true;
                }
                else
                {
                    SceneManager.LoadScene("seviyeler", LoadSceneMode.Single);
                }
            
            
            }
          
        }
        
      

        //SceneManager.LoadScene("game", LoadSceneMode.Single);//

    }




   public void anaMenu()
    {
        if (!butonBilgileri.parsomenKilidi)
        {
            SceneManager.LoadScene("anaMenu", LoadSceneMode.Single);
            
            GameObject.Find("kalpResmi").transform.position = kalpGecici;

        }

    }

    private void Update()
    {
        canDegeriAzalt();
        caninYok();
    
    }


    void canDegeriAzalt()
    {
        if (azalt)
        {
            if (oyunda)
            {
               

            }
            else
            {
                if (Vector2.Distance(GameObject.Find("azalma").transform.position, GameObject.Find("azalmaSonKonum").transform.position) < 1f)
                {
                    GameObject.Find("azalma").transform.position = GameObject.Find("azalmaSonKonum").transform.position;
                }
                else
                {
                    GameObject.Find("azalma").transform.position = Vector2.Lerp(GameObject.Find("azalma").transform.position, GameObject.Find("azalmaSonKonum").transform.position, 0.2f);
                }

                if (GameObject.Find("azalma").transform.position == GameObject.Find("azalmaSonKonum").transform.position)
                {
                    azalt = false;


                    kaydetCan.kayit(c);
                    GameObject.Find("azalma").transform.position = new Vector2(Screen.width * 3, Screen.height * 4);

                    SceneManager.LoadScene("game", LoadSceneMode.Single);
                    oyunda = true;




                }

            }

        }

    }
    void caninYok()
    {
        if (caninYokki)
        {
            if(canYokSuresi <= 0)
            {
               
                caninYokki = false;
                biKereBas = false;
                Destroy(canYokYazisi);
            }
            else
            {
                canYokSuresi -= Time.deltaTime;
            }
          
            
        }
    }

  static  void boyutAyarla()
    {
    
    }
}

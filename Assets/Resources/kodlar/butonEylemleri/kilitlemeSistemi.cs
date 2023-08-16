using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class kilitlemeSistemi : MonoBehaviour
{
    public static bool[] seviyeKilidi = new bool[resimIsimleri.resim.Length];
    public static bool[] geciciKilit = new bool[resimIsimleri.resim.Length];

    public static Texture2D kapat;
    public static Sprite kapali;

    public static Texture2D ac;
    public static Sprite acik;

    public static Texture2D gec;
    public static Sprite gecici;



    // Start is called before the first frame update
    void Start()
    {

 

      
        



        kapat = (Texture2D)Resources.Load("Menu/seviyeGorselleri/kapali");
        kapali = Sprite.Create(kapat, new Rect(0, 0, kapat.width, kapat.height), new Vector2(0.5f,0.5f));

        ac = (Texture2D)Resources.Load("Menu/seviyeGorselleri/acik");
        acik = Sprite.Create(ac, new Rect(0, 0, ac.width, ac.height), new Vector2(0.5f, 0.5f));

        gec = (Texture2D)Resources.Load("Menu/seviyeGorselleri/gecici");
        gecici = Sprite.Create(ac, new Rect(0, 0, gec.width, gec.height), new Vector2(0.5f, 0.5f));

        for (int i = 1; i < seviyeKilidi.Length; i++)
        {
            seviyeKilidi[i] = true;
            if (kaydet.yukle().seviye[i - 1] > 0)
            {
                
                geciciKilit[i] = true;
                for (int j = 0; j < GameObject.FindGameObjectsWithTag("buton").Length; j++)
                {
                    if (i.ToString() == GameObject.FindGameObjectsWithTag("buton")[j].name)
                    {
                        GameObject.FindGameObjectsWithTag("buton")[j].GetComponent<UnityEngine.UI.Image>().sprite = acik;
                    }
                }
            }


        }


    }

    // Update is called once per frame
    void Update()
    {
        
            kontrolEt();
            kilitAc();
            yildiz();
        
       

    }

    public  static void kontrolEt()
    {
        
        for (int i = 0; i < resimIsimleri.resim.Length; i++)
        {
            if (kaydet.yukle().seviye[i] == 0)
            {
                for (int j = 0; j < GameObject.FindGameObjectsWithTag("buton").Length; j++)
                {
                    if (i == int.Parse(GameObject.FindGameObjectsWithTag("buton")[j].name))
                    {
                        if (geciciKilit[i])
                        {
                            GameObject.FindGameObjectsWithTag("buton")[j].GetComponent<UnityEngine.UI.Image>().sprite = acik;
                        }
                        else
                        {
                            GameObject.FindGameObjectsWithTag("buton")[j].GetComponent<UnityEngine.UI.Image>().sprite = kapali;
                        }
                        
                        if(geciciKilit[i])
                        seviyeKilidi[i] = true;


                    }

                }
            }
            else
            {

                for (int j = 0; j < GameObject.FindGameObjectsWithTag("buton").Length; j++)
                {
                    if (i == int.Parse(GameObject.FindGameObjectsWithTag("buton")[j].name))
                    {
                        GameObject.FindGameObjectsWithTag("buton")[j].GetComponent<UnityEngine.UI.Image>().sprite = acik;
                        seviyeKilidi[i] = false;


                    }

                }
            }
        }
    }


   public static void kilitAc()
    {
        for(int i = 1; i < seviyeKilidi.Length; i++)    
        {
            if (seviyeKilidi[i])
            {
                if (!seviyeKilidi[i - 1])
                {
                    geciciKilit[i] = true;
                    for(int j = 0; j < GameObject.FindGameObjectsWithTag("buton").Length; j++)
                    {
                        if(i == int.Parse(GameObject.FindGameObjectsWithTag("buton")[j].name))
                        {
                            GameObject.FindGameObjectsWithTag("buton")[j].GetComponent<UnityEngine.UI.Image>().sprite = gecici;
                        }
                    }
                }
            }
               
        }
    }

  public static  void yildiz()
    {
        for (int i = 0; i < resimIsimleri.resim.Length; i++)
        {
            if (seviyeKilidi[i] && !geciciKilit[i])
            {
                for (int j = 0; j < GameObject.FindGameObjectsWithTag("buton").Length; j++)
                {
                    if (i == int.Parse(GameObject.FindGameObjectsWithTag("buton")[j].transform.GetChild(0).GetComponent<TMPro.TextMeshProUGUI>().text))
                    {
                        GameObject.FindGameObjectsWithTag("buton")[j].transform.GetChild(0).GetChild(0).gameObject.SetActive(false);
                        GameObject.FindGameObjectsWithTag("buton")[j].transform.GetChild(0).GetChild(1).gameObject.SetActive(false);
                        GameObject.FindGameObjectsWithTag("buton")[j].transform.GetChild(0).GetChild(2).gameObject.SetActive(false);

                    }
                }
            }
            else
            {
                for(int j = 0; j < GameObject.FindGameObjectsWithTag("buton").Length; j++)
                {
                    if(i == int.Parse(GameObject.FindGameObjectsWithTag("buton")[j].transform.GetChild(0).GetComponent<TMPro.TextMeshProUGUI>().text))
                    {
                        GameObject.FindGameObjectsWithTag("buton")[j].transform.GetChild(0).GetChild(0).gameObject.SetActive(true);
                        GameObject.FindGameObjectsWithTag("buton")[j].transform.GetChild(0).GetChild(1).gameObject.SetActive(true);
                        GameObject.FindGameObjectsWithTag("buton")[j].transform.GetChild(0).GetChild(2).gameObject.SetActive(true);
                        if (kaydet.yukle().seviye[i] == 3)
                        {
                            GameObject.FindGameObjectsWithTag("buton")[j].transform.GetChild(0).GetChild(0).GetComponent<UnityEngine.UI.Image>().sprite = yildizlariKap.sprite;
                            GameObject.FindGameObjectsWithTag("buton")[j].transform.GetChild(0).GetChild(1).GetComponent<UnityEngine.UI.Image>().sprite = yildizlariKap.sprite;
                            GameObject.FindGameObjectsWithTag("buton")[j].transform.GetChild(0).GetChild(2).GetComponent<UnityEngine.UI.Image>().sprite = yildizlariKap.sprite;
                            
                        }
                        else
                        {
                            if (kaydet.yukle().seviye[i] == 2)
                            {
                                GameObject.FindGameObjectsWithTag("buton")[j].transform.GetChild(0).GetChild(0).GetComponent<UnityEngine.UI.Image>().sprite = yildizlariKap.sprite;
                                GameObject.FindGameObjectsWithTag("buton")[j].transform.GetChild(0).GetChild(1).GetComponent<UnityEngine.UI.Image>().sprite = yildizlariKap.sprite;
                                GameObject.FindGameObjectsWithTag("buton")[j].transform.GetChild(0).GetChild(2).GetComponent<UnityEngine.UI.Image>().sprite = yildizlariKap.spriteOr;

                            }
                            else
                            {
                                if (kaydet.yukle().seviye[i] == 1)
                                {
                                    GameObject.FindGameObjectsWithTag("buton")[j].transform.GetChild(0).GetChild(0).GetComponent<UnityEngine.UI.Image>().sprite = yildizlariKap.sprite;
                                    GameObject.FindGameObjectsWithTag("buton")[j].transform.GetChild(0).GetChild(1).GetComponent<UnityEngine.UI.Image>().sprite = yildizlariKap.spriteOr;
                                    GameObject.FindGameObjectsWithTag("buton")[j].transform.GetChild(0).GetChild(2).GetComponent<UnityEngine.UI.Image>().sprite = yildizlariKap.spriteOr;

                                }
                                else
                                {
                                    GameObject.FindGameObjectsWithTag("buton")[j].transform.GetChild(0).GetChild(0).GetComponent<UnityEngine.UI.Image>().sprite = yildizlariKap.spriteOr;
                                    GameObject.FindGameObjectsWithTag("buton")[j].transform.GetChild(0).GetChild(1).GetComponent<UnityEngine.UI.Image>().sprite = yildizlariKap.spriteOr;
                                    GameObject.FindGameObjectsWithTag("buton")[j].transform.GetChild(0).GetChild(2).GetComponent<UnityEngine.UI.Image>().sprite = yildizlariKap.spriteOr;
                                }
                            }
                        }
                    }
                }
              
            }
        }
    }
}

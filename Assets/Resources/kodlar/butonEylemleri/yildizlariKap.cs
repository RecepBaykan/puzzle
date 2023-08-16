
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class yildizlariKap : MonoBehaviour
{
    
    kayitBilgileri k = new kayitBilgileri();
    Texture2D yildiz;
   public static Sprite sprite;
  public static  Sprite spriteOr;
  [SerializeField] private GameObject star;
    // Start is called before the first frame update
    void Start()
    {
        _durum.yuklee(k, -1);
         yildiz = (Texture2D)Resources.Load("Menu/seviyeGorselleri/doluYildiz");
        spriteOr =star.transform.GetChild(0).GetComponent<UnityEngine.UI.Image>().sprite;
         sprite = Sprite.Create(yildiz, new(0, 0, yildiz.width, yildiz.height), new Vector2(0.5f, 0.5f));
        

        
   
    }

    private void Update()
    {
        for(int i = 0; i < resimIsimleri.resim.Length; i++)
        {
            if (k.seviye[int.Parse(butonBilgileri.resim)] < 1 || k.seviye[int.Parse(butonBilgileri.resim)] > 3)
            {
               star.transform.GetChild(0).GetComponent<UnityEngine.UI.Image>().sprite = spriteOr;
                star.transform.GetChild(1).GetComponent<UnityEngine.UI.Image>().sprite = spriteOr;
                star.transform.GetChild(2).GetComponent<UnityEngine.UI.Image>().sprite = spriteOr;
            }
            else
            {
                if (k.seviye[int.Parse(butonBilgileri.resim)] == 3)
                {
                    star.transform.GetChild(0).GetComponent<UnityEngine.UI.Image>().sprite = sprite;
                    star.transform.GetChild(1).GetComponent<UnityEngine.UI.Image>().sprite = sprite;
                    star.transform.GetChild(2).GetComponent<UnityEngine.UI.Image>().sprite = sprite;
                }
                else
                {
                    if (k.seviye[int.Parse(butonBilgileri.resim)] == 2)
                    {
                        star.transform.GetChild(0).GetComponent<UnityEngine.UI.Image>().sprite = sprite;
                        star.transform.GetChild(1).GetComponent<UnityEngine.UI.Image>().sprite = sprite;
                        star.transform.GetChild(2).GetComponent<UnityEngine.UI.Image>().sprite = spriteOr;
                    }
                    else
                    {
                        if (k.seviye[int.Parse(butonBilgileri.resim)] == 1)
                        {
                            star.transform.GetChild(0).GetComponent<UnityEngine.UI.Image>().sprite = sprite;
                            star.transform.GetChild(1).GetComponent<UnityEngine.UI.Image>().sprite = spriteOr;
                            star.transform.GetChild(2).GetComponent<UnityEngine.UI.Image>().sprite = spriteOr;

                        }
                    }

                }

            }


        }
            
    }

    // Update is called once per frame
} 

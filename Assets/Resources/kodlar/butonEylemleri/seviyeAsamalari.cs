using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class seviyeAsamalari : MonoBehaviour
{
    private void Start()
    {
       
        
        
        butonBilgileri.ulkeDegeri = kaydet.yukle().kaldigin_yer;
        


       
        asama();
    }

    public static void asama()
    {
        if(butonBilgileri.ulkeDegeri >= 21)
        {
            butonBilgileri.ulkeDegeri = 20;
        }
       
        if (butonBilgileri.ulkeDegeri <= 1)
        {
            GameObject.Find("yon").transform.GetChild(1).gameObject.SetActive(false);
        }
        else
        {

            GameObject.Find("yon").transform.GetChild(1).gameObject.SetActive(true);
        }
        if (butonBilgileri.ulkeDegeri == resimIsimleri.bayrakIsimleri.Length - 1)
        {
            GameObject.Find("yon").transform.GetChild(0).gameObject.SetActive(false);
        }
        else
        {
            GameObject.Find("yon").transform.GetChild(0).gameObject.SetActive(true);
        }

        if (Resources.Load("ulkeler/" + butonBilgileri.ulkeDegeri.ToString()) != null)
        {
            butonBilgileri.ulkeResmi = (Texture2D)Resources.Load("ulkeler/" + butonBilgileri.ulkeDegeri.ToString());
        }else
        {
             butonBilgileri.ulkeResmi = (Texture2D)Resources.Load("ulkeler/" + (butonBilgileri.ulkeDegeri-1).ToString());
        }
        if (Resources.Load("ulkeBayraklari/" + butonBilgileri.ulkeDegeri.ToString()) != null)
        {
            butonBilgileri.bayrakResmi = (Texture2D)Resources.Load("ulkeBayraklari/" + butonBilgileri.ulkeDegeri.ToString());
        }else
        {
            butonBilgileri.bayrakResmi = (Texture2D)Resources.Load("ulkeBayraklari/" + (butonBilgileri.ulkeDegeri-1).ToString());
        }

        resmiIsle();
    }

   public static void resmiIsle()
    {
        var ulke = Sprite.Create(butonBilgileri.ulkeResmi, new Rect(0, 0, butonBilgileri.ulkeResmi.width, butonBilgileri.ulkeResmi.height), new Vector2(0.5f, 0.5f));
        var ulkeBayrak = Sprite.Create(butonBilgileri.bayrakResmi, new Rect(0, 0, butonBilgileri.bayrakResmi.width, butonBilgileri.bayrakResmi.height), new Vector2(0.5f, 0.5f));
        GameObject.Find("arkaPlan").GetComponent<UnityEngine.UI.Image>().sprite = ulke;
        GameObject.Find("ulkeBayragi").GetComponent<UnityEngine.UI.Image>().sprite = ulkeBayrak;
        GameObject.Find("ulke").GetComponent<TextMeshProUGUI>().text = resimIsimleri.bayrakIsimleri[butonBilgileri.ulkeDegeri];
    }
}

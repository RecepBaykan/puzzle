using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.EventSystems;
using TMPro;

public class _kod : MonoBehaviour
{
    
    [SerializeField] float a;
    string sev;
    // Start is called before the first frame update
    public static int ulkeDegeri = 1;
    Texture2D ulkeResmi;
    Texture2D bayrakResmi;
    bool pasifEt;
    int seviye = 6;
    GameObject[]  buton;
    Vector3 geciciParsomenKonumu;
    bool kilit;
    public static float f;
    kayitBilgileri kayit = new kayitBilgileri();
    Texture2D gecersizSeviye;
    Sprite gecersiz;
    private void Start()
    {
        kaydet.yukle();
        kaydet.yukle().seviye[0] = 0;
        kaydet.yukle().seviye[1] = 0;
        
    
        buton = new GameObject[6];
        butonIsimlendir();
        GameObject.Find("0").SetActive(false);
        geciciParsomenKonumu = GameObject.Find("parsomen").transform.position;
        gecersizSeviye = (Texture2D)Resources.Load("Menu/seviyeGorselleri/kapali");
        gecersiz = Sprite.Create(gecersizSeviye, new Rect(0, 0, gecersizSeviye.width, gecersizSeviye.height), new Vector2(0, 0));

    }
     void Update()
    {
        if(!kilit)
        seviyeAsamalari();
        
     
    }

    public void getir()
    {
        
        if (!kilit)
        {
            GameObject.Find("parsomen").transform.position = GameObject.Find("ortaKonum").transform.position;
            sev = EventSystem.current.currentSelectedGameObject.name;
            GameObject.Find("seviyeAdi").GetComponent<TextMeshProUGUI>().text = resimIsimleri.resim[int.Parse(sev)];
            var tex = (Texture2D)Resources.Load("resimler/" + sev);
            GameObject.Find("seviyeResmi").GetComponent<UnityEngine.UI.Image>().sprite = Sprite.Create(tex,
                new Rect(0, 0, tex.width, tex.height), new Vector2(0.5f, 0.5f));
        }
        kilit = true;
    

    }

    public void kapat()
    {
        kilit = false;
        GameObject.Find("parsomen").transform.position = geciciParsomenKonumu;
    }

    public void bas()
    {







        sirala.gen = Random.Range(2, 5);
        sirala.yuk = Random.Range(2, 6);
        while (sirala.yuk< sirala.gen -1 || sirala.yuk > sirala.gen+1)
        {
            sirala.yuk = Random.Range(2, 6);
        }
           
        
            yukle();
       
        sirala.resim = (Texture2D)Resources.Load("resimler/"+sev);
       
      
    
        SceneManager.LoadScene("game", LoadSceneMode.Single);
       
        /*
        GameObject.Find("parsomen").transform.parent = GameObject.Find(seviye).transform;
        GameObject.Find("parsomen").transform.position = GameObject.Find(seviye).transform.position;*/
       
        


    }

    void yukle()
    {
        
        
       
       for(int i = 2; i <= 6; i++)
        {
            if(sirala.gen == i)
            {
                sirala.enBoyParcaX = a / (i / 2);
            }
            if (sirala.yuk == i)
            {
                sirala.enBoyParcaY = a / (i / 2);
            }
        }


    }

    public void ileri()
    {
        if (!kilit)
        {
            for (int i = 0; i < GameObject.FindGameObjectsWithTag("buton").Length; i++)
            {
                GameObject.FindGameObjectsWithTag("buton")[i].GetComponentInChildren<TextMeshProUGUI>().text = (int.Parse(GameObject.FindGameObjectsWithTag("buton")[i].GetComponentInChildren<TextMeshProUGUI>().text) + 6).ToString();
                GameObject.FindGameObjectsWithTag("buton")[i].name = GameObject.FindGameObjectsWithTag("buton")[i].GetComponentInChildren<TextMeshProUGUI>().text;
            }
            ulkeDegeri += 1;
        }
       
       
    }
    public void geri()
    {

        if (!kilit)
        {
            for (int i = 0; i < GameObject.FindGameObjectsWithTag("buton").Length; i++)
            {
                GameObject.FindGameObjectsWithTag("buton")[i].GetComponentInChildren<TextMeshProUGUI>().text = (int.Parse(GameObject.FindGameObjectsWithTag("buton")[i].GetComponentInChildren<TextMeshProUGUI>().text) - 6).ToString();
                GameObject.FindGameObjectsWithTag("buton")[i].name = GameObject.FindGameObjectsWithTag("buton")[i].GetComponentInChildren<TextMeshProUGUI>().text;
            }
            ulkeDegeri += -1;
        }
  
    }

    void seviyeAsamalari()
    {
        if (ulkeDegeri <= 1)
        {
            GameObject.Find("yon").transform.GetChild(1).gameObject.SetActive(false);
        }
        else
        {

            GameObject.Find("yon").transform.GetChild(1).gameObject.SetActive(true);
        }
        if(ulkeDegeri == resimIsimleri.bayrakIsimleri.Length-1)
        {
            GameObject.Find("yon").transform.GetChild(0).gameObject.SetActive(false);
        }
        else
        {
            GameObject.Find("yon").transform.GetChild(0).gameObject.SetActive(true);
        }

        if (Resources.Load("ulkeler/" + ulkeDegeri.ToString()) != null)
        {
            ulkeResmi = (Texture2D)Resources.Load("ulkeler/" + ulkeDegeri.ToString());
        }
        if (Resources.Load("ulkeBayraklari/" + ulkeDegeri.ToString()) != null)
        {
            bayrakResmi = (Texture2D)Resources.Load("ulkeBayraklari/" + ulkeDegeri.ToString());
        }




        var ulke = Sprite.Create(ulkeResmi, new Rect(0, 0, ulkeResmi.width, ulkeResmi.height), new Vector2(0.5f, 0.5f));
        var ulkeBayrak = Sprite.Create(bayrakResmi, new Rect(0, 0, bayrakResmi.width, bayrakResmi.height), new Vector2(0.5f, 0.5f));
        GameObject.Find("arkaPlan").GetComponent<UnityEngine.UI.Image>().sprite = ulke;
        GameObject.Find("ulkeBayragi").GetComponent<UnityEngine.UI.Image>().sprite = ulkeBayrak;
        GameObject.Find("ulke").GetComponent<TextMeshProUGUI>().text = resimIsimleri.bayrakIsimleri[ulkeDegeri];
    }


    void butonIsimlendir()
    {
        for(int i = 0; i < seviye; i++)
        {
            buton[i] = Instantiate(GameObject.Find(("0")));
         
            buton[i].name = (i+1).ToString();
            buton[i].GetComponentInChildren<TextMeshProUGUI>().text = (i+1).ToString();
            buton[i].transform.SetParent(GameObject.Find("seviyeAlani").transform,false);
            buton[i].tag = "buton";
            if(kayit.seviye[i+1] == 0)
            {
                buton[i].GetComponent<UnityEngine.UI.Image>().sprite = gecersiz;
            }
        }
    }
}

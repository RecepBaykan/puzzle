using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class parsonmenGetir : MonoBehaviour
{
    public static Vector2 kalpGeciciKonum;
    public static Vector2 oynaGeciciKonum;

    [SerializeField] private GameObject kalpResmi;
    [SerializeField] private GameObject oynaButton;
    [SerializeField] private GameObject parsomen;
    
    public void Start()
    {
        kalpGeciciKonum = kalpResmi.transform.position;
        oynaGeciciKonum = oynaButton.transform.position;
        
    }
  public void parsomeniGetir()
    {
        
            parsomen.SetActive(true);
            butonBilgileri.resim = EventSystem.current.currentSelectedGameObject.GetComponentInChildren<TMPro.TextMeshProUGUI>().text;
            if (!kilitlemeSistemi.seviyeKilidi[int.Parse(butonBilgileri.resim)] || kilitlemeSistemi.geciciKilit[int.Parse(butonBilgileri.resim)])
            {
            parsomen.transform.position = new Vector2(Screen.width / 2, Screen.height / 2);

            parsomen.transform.GetChild(1).GetComponent<TextMeshProUGUI>().text = resimIsimleri.resim[int.Parse(butonBilgileri.resim)];
            var yapboz = (Texture2D)Resources.Load("resimler/" + butonBilgileri.resim);
            parsomen.transform.GetChild(2).GetComponent<UnityEngine.UI.Image>().sprite =
                Sprite.Create(yapboz, new Rect(0, 0, yapboz.width, yapboz.height), new Vector2(0, 0));

            butonBilgileri.parsomenKilidi = true;
        
        }
        
        
            
    }

    public void parsomenGotur()
    {
        parsomen.SetActive(false);
        parsomen.transform.position = butonBilgileri.parsomeninGeciciKonumu;
        butonBilgileri.parsomenKilidi = false;
       
        kalpResmi.transform.position = oyna.kalpGecici;
        Destroy(oyna.canYokYazisi);
        oyna.biKereBas = false;
        oyna.caninYokki = false;



    }
}   

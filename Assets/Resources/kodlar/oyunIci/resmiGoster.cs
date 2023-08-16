using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class resmiGoster : MonoBehaviour
{
    // Start is called before the first frame update
  public static  bool goster;
    string gecici;
    [SerializeField] private GameObject resimNesne;
   
    private void Start() {
        resimNesne.SetActive(false);
    }
    public void resimGelsin()
    {
        if (!goster)
        {
            resimNesne.SetActive(true);
            resimNesne.transform.position = new Vector2(Screen.width / 2, Screen.height / 2);
            //gecici = GameObject.Find("resmiGoster").transform.GetChild(0).GetComponent<TextMeshProUGUI>().text;
            //GameObject.Find("resmiGoster").transform.GetChild(0).GetComponent<TextMeshProUGUI>().text = "Resmi gizle";
            var resim = Sprite.Create(sirala.resim, new Rect(0, 0, sirala.resim.width, sirala.resim.height),new Vector2(0, 0));
            resimNesne.transform.GetChild(0).GetComponent<UnityEngine.UI.Image>().sprite = resim;
            
            goster = true;
        }
        else
        {
            //GameObject.Find("resmiGoster").transform.GetChild(0).GetComponent<TextMeshProUGUI>().text = gecici;
            resimNesne.transform.position = new Vector2(Screen.width *2, Screen.height / 2*2);
            goster = false;
            resimNesne.SetActive(false);
        }
    } 
}

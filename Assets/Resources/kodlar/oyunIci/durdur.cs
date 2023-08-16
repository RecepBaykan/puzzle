using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class durdur : MonoBehaviour
{
    [SerializeField] private GameObject durdurButton;
    static float parcaX = 10;
    static float parcaY = (Screen.height * parcaX) / Screen.width;
    public static bool sureyiDurdur;
    Vector3 gecici;

    Vector2 geciciGoster;
    Vector2 geciciResim;

    [SerializeField] private GameObject durdurmaMenusu;
    [SerializeField] private GameObject resmiGoster;
    [SerializeField] private GameObject resim;

    private void Start()
    {
       durdurmaMenusu.SetActive(false);
    }
    // Start is called before the first frame update
    public void dur()
    {
            
            
            gecici = durdurButton.transform.position;
            if (durdurButton.transform.GetChild(0).GetComponent<TMPro.TextMeshProUGUI>().text == "Devam et")
            {
                geriDon();
            }
            else
            {
                durdurmaMenusu.SetActive(true);
                durdurButton.transform.GetChild(0).GetComponent<TMPro.TextMeshProUGUI>().text = "Devam et";
                durdurmaMenusu.transform.position = new Vector2(Screen.width / 2, Screen.height / 2);
                durdurButton.transform.position = new Vector2(Screen.width * 2, Screen.height * 2);
                sureyiDurdur = true;
                resmiGoster.SetActive(false);
                //g�ster butonu
                geciciGoster = resmiGoster.transform.position;
                resmiGoster.transform.position = new Vector2(-2 * Screen.width, -2 * Screen.height);

                //resim
                resim.SetActive(false);
                geciciResim = resim.transform.position;
                resim.transform.position = new Vector2(-2 * Screen.width, -2 * Screen.height);

            }
        




    }

    public void geriDon()
    {
        durdurmaMenusu.SetActive(false);
        durdurButton.SetActive(true);
        resim.SetActive(true);
        resmiGoster.SetActive(true);
        durdurmaMenusu.transform.position = new Vector2(-Screen.width, -Screen.height);
        sureyiDurdur = false;
        durdurButton.transform.GetChild(0).GetComponent<TMPro.TextMeshProUGUI>().text = "Durdur";
        resmiGoster.transform.position = geciciGoster;
        resim.transform.position = geciciResim;
        
        

    }


    public void anaMenu()
    {

        yokEt.yok();
        oyna.oyunda = false;
        SceneManager.LoadScene("anaMenu", LoadSceneMode.Single);
        

    }

    public void seviyeSec()
    {
        yokEt.yok();
        oyna.oyunda = false;
        SceneManager.LoadScene("seviyeler", LoadSceneMode.Single);
        
    }

}

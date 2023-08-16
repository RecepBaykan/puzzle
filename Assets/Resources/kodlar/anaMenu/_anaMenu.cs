using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class _anaMenu : MonoBehaviour
{
    [SerializeField] private GameObject ayar;
    private void Start()
    {
        ayar.SetActive(false);
        
        //GameObject.Find("ayar").transform.position = new Vector2(7 * Screen.width, 7*Screen.height);
        
    }
    public void oyna()
    {
        
        SceneManager.LoadScene("seviyeler", LoadSceneMode.Single);
        


    }

    public void ayarlar()
    {

       
    }


    //Ayarlar i�in kapat butonu
    bool ekrandaKapat;
    public void kapat()
    {
        if (!ekrandaKapat)
        {
            ayar.SetActive(true);
            ayar.transform.position = new Vector2(Screen.width / 2, Screen.height / 2);
            ekrandaKapat = true;
        }
        else
        {
            ayar.SetActive(false);
            ayar.transform.position = new Vector2(7*Screen.width, Screen.height / 2);
            ekrandaKapat = false;
        }
    }
    

}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ulkeGecisleri : MonoBehaviour
{
    
    public void ileri()
    {
        
        if (!butonBilgileri.parsomenKilidi)
        {
            for (int i = 0; i < GameObject.FindGameObjectsWithTag("buton").Length; i++)
            {
                GameObject.FindGameObjectsWithTag("buton")[i].GetComponentInChildren<TextMeshProUGUI>().text = (int.Parse(GameObject.FindGameObjectsWithTag("buton")[i].GetComponentInChildren<TextMeshProUGUI>().text) + 6).ToString();
                GameObject.FindGameObjectsWithTag("buton")[i].name = GameObject.FindGameObjectsWithTag("buton")[i].GetComponentInChildren<TextMeshProUGUI>().text;
            }
            butonBilgileri.ulkeDegeri += 1;
           
        }
        seviyeAsamalari.asama();
       

    }
    public void geri()
    {

        if (!butonBilgileri.parsomenKilidi)
        {
            for (int i = 0; i < GameObject.FindGameObjectsWithTag("buton").Length; i++)
            {
                GameObject.FindGameObjectsWithTag("buton")[i].GetComponentInChildren<TextMeshProUGUI>().text = (int.Parse(GameObject.FindGameObjectsWithTag("buton")[i].GetComponentInChildren<TextMeshProUGUI>().text) - 6).ToString();
                GameObject.FindGameObjectsWithTag("buton")[i].name = GameObject.FindGameObjectsWithTag("buton")[i].GetComponentInChildren<TextMeshProUGUI>().text;
            }
           butonBilgileri.ulkeDegeri += -1;
            
        }
        seviyeAsamalari.asama();

    }

}

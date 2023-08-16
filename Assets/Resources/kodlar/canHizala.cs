using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class canHizala : MonoBehaviour
{
    public static Vector2 canAzalmaKonumu;
    // Start is called before the first frame update
    void Start()
    {
        transform.position = new Vector2(9 * Screen.width / 10, 9.6f * Screen.height / 10);
        canAzalmaKonumu = GameObject.Find("azalma").transform.position;
        GameObject.Find("azalma").transform.position = new Vector2(Screen.width * 3, Screen.width * 4);
        oyna.kalpGecici = GameObject.Find("kalpResmi").transform.position;

    }

    // Update is called once per frame
    void Update()
    {
        transform.GetChild(0).GetComponent<TMPro.TextMeshProUGUI>().text = kaydetCan.yukle().can.ToString();
        if(kaydetCan.yukle().can < 5)
        {
            GameObject.Find("canSuresi").GetComponent<TMPro.TextMeshProUGUI>().text = ((int)(canDoldur.canDolumSuresi / 60)).ToString() + ":" + ((int)(canDoldur.canDolumSuresi%60)).ToString();
        }
        else
        {
            GameObject.Find("canSuresi").GetComponent<TMPro.TextMeshProUGUI>().text = "";
        }
        
        
    }
}

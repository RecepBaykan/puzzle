using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class butonIsimlendir : MonoBehaviour
{
    public static bool elemenanTam;
    GameObject[] buton;
    [SerializeField] private GameObject seviyeAlani;
    
    private void Start()
    {
        
        
        buton = new GameObject[6];
        isimlendir();
    }


    void isimlendir()
    {
        for (int i = 0; i < 6; i++)
        {
            buton[i] = Instantiate(GameObject.Find(("0")));
            buton[i].transform.localScale = (GameObject.Find("0")).transform.localScale;
            buton[i].name = (kaydet.yukle().kaldigin_yer*6  + i+1 - 6).ToString();
            buton[i].GetComponentInChildren<TextMeshProUGUI>().text = (kaydet.yukle().kaldigin_yer * 6 + i + 1 - 6).ToString();
            buton[i].transform.SetParent(seviyeAlani.transform, false);
            buton[i].tag = "buton";
           
        }

        seviyeAlani.transform.position = new Vector3(Screen.width / 2, Screen.height / 2, 0);
        
        seviyeAlani.transform.GetChild(0).gameObject.SetActive(false);

    }
}

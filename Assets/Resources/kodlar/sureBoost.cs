using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sureBoost : MonoBehaviour
{
    GameObject[] sureGuc;
    // Start is called before the first frame update
    void Start()
    {
        
        sureGuc = new GameObject[3];
        for(int i = 0; i<3; i++)
        {
            sureGuc[i] = new GameObject();
            sureGuc[i] = Instantiate(gameObject);
            sureGuc[i].name = "sure" + i.ToString();
            sureGuc[i].transform.GetChild(0).GetComponent<TMPro.TextMeshProUGUI>().text = "S�re G��lendirmesi " + (i+1).ToString();
            sureGuc[i].transform.GetChild(1).GetComponent<TMPro.TextMeshProUGUI>().text = (i * 2 + 2).ToString();

        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

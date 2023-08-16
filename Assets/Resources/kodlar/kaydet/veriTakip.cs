using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Search;

public class veriTakip : MonoBehaviour
{
    private kayitBilgileri k;

    
    // Start is called before the first frame update
    void Start()
    {
        
        k = new kayitBilgileri();
        if (kaydet.yukle() == null)
        {
            kaydet.kayit(k);
        }
        int fark = k.seviye.Length - kaydet.yukle().seviye.Length;
        if (fark <= -1)
        {
            for (int i = 0; i<kaydet.yukle().seviye.Length-fark; i++)
            {
                k.seviye[i] = kaydet.yukle().seviye[i];
            }
        }

        if (fark >= 1)
        {
            for (int i = 0; i<kaydet.yukle().seviye.Length; i++)
            {
                k.seviye[i] = kaydet.yukle().seviye[i];
            }

            for (int i = 0; i < fark; i++)
            {
                k.seviye[i + kaydet.yukle().seviye.Length] = 0;
            }
        }

        if (fark == 0)
        {
            for (int i = 0; i<kaydet.yukle().seviye.Length; i++)
            {
                k.seviye[i] = kaydet.yukle().seviye[i];
            }
        }

        k.kaldigin_yer = kaydet.yukle().kaldigin_yer;
        kaydet.kayit(k);
      
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

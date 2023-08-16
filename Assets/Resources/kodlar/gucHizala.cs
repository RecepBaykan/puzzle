using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gucHizala : MonoBehaviour
{
    
    public static Vector2 gecici;
    // Start is called before the first frame update
    void Start()
    {

        transform.position = new Vector2(Screen.width*2, Screen.height*2);
        gecici = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if (dusenParcalar.sureBaslat)
        {
            transform.position = new Vector2(Screen.width * 2, Screen.height * 2);
        }
    }
}

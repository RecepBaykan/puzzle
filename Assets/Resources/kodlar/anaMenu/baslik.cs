using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class baslik : MonoBehaviour
{
    Vector3 gecici;

    
    // Start is called before the first frame update
    void Start()
    {
        gecici = GameObject.Find("butonlar").transform.position;
        GameObject.Find("butonlar").transform.position = new Vector2(-Screen.width * 2, -Screen.height * 2);

    }

    // Update is called once per frame
    void Update()
    {
        konumlandir();
    }



    void konumlandir()
    {
        if(Vector2.Distance(transform.position, new Vector2(Screen.width / 2, 8 * Screen.height / 10)) <= 1*Screen.height/10)
        {
           
                GameObject.Find("butonlar").transform.position = gecici;
            
        }
        transform.position = Vector2.Lerp(transform.position, new Vector2(Screen.width/2, 8 * Screen.height / 10), Time.deltaTime * 0.6f);
       
    }
}

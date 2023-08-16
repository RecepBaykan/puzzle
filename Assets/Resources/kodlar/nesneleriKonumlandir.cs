using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class nesneleriKonumlandir : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        GameObject.Find("sure").transform.position = new Vector2(5*Screen.width /10, 9.5f* Screen.height / 10);    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

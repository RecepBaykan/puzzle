using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class yonHizala : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        GameObject.Find("yon").transform.GetChild(0).transform.position = new Vector2(
            GameObject.Find("yon").transform.GetChild(0).transform.position.x, 2 * Screen.width / 10);
        GameObject.Find("yon").transform.GetChild(1).transform.position = new Vector2(
           GameObject.Find("yon").transform.GetChild(1).transform.position.x, 2 * Screen.width / 10);
    }

  
}

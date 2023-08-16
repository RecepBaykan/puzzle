using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class yokEt : MonoBehaviour
{
    // Start is called before the first frame update
  
    public static void yok()
    {
        foreach(GameObject go in GameObject.FindGameObjectsWithTag("kutu"))
        {
            Destroy(go);
        }
        foreach (GameObject go in GameObject.FindGameObjectsWithTag("parca"))
        {
            Destroy(go);
        }
    }
}

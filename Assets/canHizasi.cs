using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class canHizasi : MonoBehaviour
{

    Vector3 gecici;
    bool geldi;

    [SerializeField] private GameObject boostShop;
    [SerializeField] private GameObject can;
    [SerializeField] private GameObject canAnim;
    
    
    
    
    
    
    
    // Start is called before the first frame update
    void Start()
    {
        canAnim .transform.position = can.transform.position;
        boostShop.transform.position = new Vector2(Screen.width*4, Screen.height*4);
        gecici = boostShop.transform.position;
        

    }

    public void canMarketi()
    {
        if (!geldi)
        {
            boostShop.transform.position = new Vector2(Screen.width/2,8.5f*Screen.height/10);
            geldi = true;
        }
        else
        {
            boostShop.transform.position = gecici;
            geldi = false;
        
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        if(can.transform.position == new Vector3(Screen.width / 2, Screen.height / 2,0f))
        {
            //canAnim.transform.position= new Vector3(Screen.width * 4, Screen.height * 4);
            boostShop.transform.position = new Vector2(Screen.width * 4, Screen.height * 4);
            geldi = false;

        }
       
    }
}

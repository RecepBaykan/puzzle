using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class canDoldur : MonoBehaviour
{
    public static float canDolumSuresi;
    // Start is called before the first frame update
    public static canDoldur can = new canDoldur();
    sureBilgisi s = new sureBilgisi();
    private void Awake()
    {
        if (can == null)
        {
            can = this;
            DontDestroyOnLoad(this);

        }
        else if (can != null)
        {
            Destroy(gameObject);
        }
    }
    private void Start()
    {
        canDolumSuresi = 40;
        
    }
    // Update is called once per frame
    void Update()
    {


        if (kaydetCan.yukle().can < 5)
        {
            if (canDolumSuresi <= 0)
            {
                canDolumSuresi = 40;
                canBilgisi c = new canBilgisi();
                c.can = kaydetCan.yukle().can;
                c.can++;
                kaydetCan.kayit(c);
               

            }
            else
            {
                canDolumSuresi -= Time.deltaTime;
                s.sure = canDolumSuresi;
                kaydetSure.kayit(s);




            } 
        } 
    }
            

        
       
    
      
}

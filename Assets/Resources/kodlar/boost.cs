using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class boost : MonoBehaviour
{
   public static boost hizlandir = new boost();
    
    // Start is called before the first frame update
    private void Awake()
    {
        if (hizlandir == null)
        {
            hizlandir = this;
            DontDestroyOnLoad(this);

        }
        else if (hizlandir != null)
        {
            Destroy(gameObject);
        }
    }
    void Start()
    {
        QualitySettings.vSyncCount = 0;
        Application.targetFrameRate = 60;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

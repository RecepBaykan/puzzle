using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class links : MonoBehaviour
{

    [SerializeField] private GameObject info;
    public void git()
    {
        Application.OpenURL("https://github.com/phanmetal");
    }

    public void ln()
    {
        Application.OpenURL("https://www.linkedin.com/in/recep-baykan-6b5366287/");
    }

    private void Start() {
        info.SetActive(false);
    }

    public void infoAc()
    {
        info.SetActive(true);
    }
    public void infoKapat()
    {
        info.SetActive(false);
    }
    
}

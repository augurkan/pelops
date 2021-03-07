using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HUD : MonoBehaviour
{
    public GameObject MessagePanel;
    public GameObject image1;
    public GameObject image2;
    public GameObject image3;
    public GameObject image4;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    public void OpenMessagePanel(string text)
    {
        MessagePanel.SetActive(true);
    }

    public void CloseMessagePanel()
    {
        MessagePanel.SetActive(false);
    }

    public void OpenImage1()
    {
        image1.SetActive(true);
    }

    public void CloseImage1()
    {
        image1.SetActive(false);
    }

    public void OpenImage2()
    {
        image2.SetActive(true);
    }

    public void CloseImage2()
    {
        image2.SetActive(false);
    }

    public void OpenImage3()
    {
        image3.SetActive(true);
    }

    public void CloseImage3()
    {
        image3.SetActive(false);
    }

    public void OpenImage4()
    {
        image4.SetActive(true);
    }

    public void CloseImage4()
    {
        image4.SetActive(false);
    }

}

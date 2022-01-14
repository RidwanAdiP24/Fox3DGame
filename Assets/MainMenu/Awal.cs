using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Awal : MonoBehaviour
{
    public GameObject MenuPanel;
    public GameObject CreditPanel;
    public GameObject HowPanel;

    // Start is called before the first frame update
    void Start()
    {
        MenuPanel.SetActive(true);
        CreditPanel.SetActive(false);
        HowPanel.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void PlayGameClicked()
    {
        Application.LoadLevel("GamePlay");
    }
    public void CreditClicked()
    {
        MenuPanel.SetActive(false);
        CreditPanel.SetActive(true);
        HowPanel.SetActive(false);
    }

    public void HowToPlayClicked()
    {
        MenuPanel.SetActive(false);
        CreditPanel.SetActive(false);
        HowPanel.SetActive(true);
    }

    public void Quit_Clicked()
    {
        Application.Quit();
    }
    public void BackClicked()
    {
        MenuPanel.SetActive(true);
        CreditPanel.SetActive(false);
        HowPanel.SetActive(false);
    }

}

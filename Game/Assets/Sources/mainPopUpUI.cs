using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mainPopUpUI : MonoBehaviour
{
    public GameObject main_ui;
    public GameObject plunger;

    // Update is called once per frame
    void Update()
    {
         
    }
    public void gameStartClicked()
    {
        main_ui.SetActive(false);
        plunger.SetActive(true);
    }
    public void settingBtClicked()
    {

    }
    public void rankingBtClicked()
    {

    }
    public void quitGameBtClicked()
    {

    }
}

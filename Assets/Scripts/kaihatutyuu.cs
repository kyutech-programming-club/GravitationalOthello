using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class kaihatutyuu : MonoBehaviour
{

    public GameObject buttonMessage;
    public GameObject ButtonMessageText;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void PushButtonMemo() {
        DisplayMessage("開発中");
    }



    void DisplayMessage(string mes) {
        buttonMessage.SetActive(true);
        ButtonMessageText.GetComponent<Text>().text = mes;
    }


    public void PushButtonMessage()
    {
        buttonMessage.SetActive(false);
    }

}

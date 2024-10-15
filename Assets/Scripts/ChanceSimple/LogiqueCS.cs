using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LogiqueCS : MonoBehaviour
{
    [SerializeField]
    private GameProperties gp;
    [SerializeField]
    private InputField numero;
    [SerializeField]
    private InputField mise;
    [SerializeField]
    private GameObject popup;
    [SerializeField]
    private Text popupTitle;
    [SerializeField]
    private Text popupContent;
    [SerializeField]
    private PopupTexts popupTexts;

    public void Play()
    {
        int miseNB = int.Parse(mise.text.ToString());

        if (gp.nombreTire % 2 == 0 && gp.isPair == "pair")
        {
            Debug.Log("OK")
        }
    }
}
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Logique : MonoBehaviour
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
    [SerializeField]
    private Button run;

    private void Start()
    {
        run.onClick.AddListener(Play);
    }

    void Play()
    {
        int miseNB = int.Parse(mise.text.ToString());

        if (numero.text == gp.nombreTire.ToString())
        {
            popupTitle.text = popupTexts.NPGtitle;
            popupContent.text = popupTexts.NPGcontent;
            gp.argentTotal += miseNB * 36;
        }
        else
        {
            popupTitle.text = popupTexts.NPPtitle;
            popupContent.text = popupTexts.NPPcontent;
            gp.argentTotal -= miseNB;
        }
        popup.SetActive(true);
    }
}
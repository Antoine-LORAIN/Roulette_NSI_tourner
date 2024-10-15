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
        if (numero.text == gp.nombreTire.ToString())
        {
            int intmise = int.Parse(mise.text);

            gp.argentTotal += intmise * 36;

            popupTitle.text = popupTexts.NPGtitle;
            popupContent.text = popupTexts.NPGcontent;
        }
        else
        {
            popupTitle.text = popupTexts.NPPtitle;
            popupContent.text = popupTexts.NPPcontent;
        }
        popup.SetActive(true);
    }
}
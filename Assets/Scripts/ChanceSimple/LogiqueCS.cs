using UnityEngine;
using UnityEngine.UI;

public class LogiqueCS : MonoBehaviour
{
    [SerializeField]
    private GameProperties gp;
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
    private Button pairButton;
    [SerializeField]
    private Button impairButton;

    public void Play()
    {
        int miseNB = int.Parse(mise.text.ToString());

        if (gp.nombreTire == 0)
        {
            popupTitle.text = popupTexts.CSOtitle;
            popupContent.text = popupTexts.CSOcontent;
            gp.argentTotal -= miseNB / 2;
        }
        else if (gp.nombreTire%2 == 0 && gp.isPair == "pair")
        {
            popupTitle.text = popupTexts.CSGtitle;
            popupContent.text = popupTexts.CSGcontent;
            gp.argentTotal += miseNB * 2;
        }
        else if (gp.nombreTire%2 == 1 && gp.isPair == "impair")
        {
            popupTitle.text = popupTexts.CSGtitle;
            popupContent.text = popupTexts.CSGcontent;
            gp.argentTotal = miseNB * 2;
        }
        else
        {
            popupTitle.text = popupTexts.CSPtitle;
            popupContent.text = popupTexts.CSPcontent;
            gp.argentTotal -= miseNB;
        }
        popup.SetActive(true);
        mise.enabled = true;
        pairButton.enabled = true;
        impairButton.enabled = true;
    }   
}
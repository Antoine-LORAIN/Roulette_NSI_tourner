using UnityEngine;
using UnityEngine.UI;

public class ControllerCSC : MonoBehaviour
{
    [SerializeField]
    private GameProperties gp;
    [Header("Objects")]
    [SerializeField]
    private Button startButton;
    [SerializeField]
    private Text argentTotal;
    [SerializeField]
    private Button pairButton;
    [SerializeField]
    private Button impairButton;
    [SerializeField]
    private InputField mise;

    private void Start()
    {
        startButton.onClick.AddListener(switchMustRoll);
        pairButton.onClick.AddListener(Pair);
        impairButton.onClick.AddListener(Impair);
    }

    private void Update()
    {
        refreshArgent();
    }

    void switchMustRoll()
    {

        if (gp.canRoll)
        {
            gp.mustRoll = true;
        }
        else
        {
            gp.mustRoll = false;
        }
        pairButton.enabled = false;
        impairButton.enabled = false;
        mise.enabled = false;
    }

    void refreshArgent()
    {
        argentTotal.text = "Argent total : " + gp.argentTotal + "€";
    }

    void Pair()
    {
        gp.isPair = "pair";
    }

    void Impair()
    {
        gp.isPair = "impair";
    }
}
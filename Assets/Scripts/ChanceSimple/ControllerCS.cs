using UnityEngine;
using UnityEngine.UI;

public class ControllerCS : MonoBehaviour
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
    private void Start()
    {
        startButton.onClick.AddListener(switchMustRoll);
        pairButton.onClick.AddListener(Pair);
        impairButton.onClick.AddListener(Impair);
        refreshArgent();
    }

    void Update()
    {
        refreshArgent();
    }

    private void switchMustRoll()
    {
        if (gp.canRoll)
        {
            gp.mustRoll = true;
            gp.typeJeu = "CS";
        }
        else
        {
            gp.mustRoll = false;
        }
    }

    private void refreshArgent()
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
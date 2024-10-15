using UnityEngine;
using UnityEngine.Assertions.Must;
using UnityEngine.UI;

public class Controller : MonoBehaviour
{
    [SerializeField]
    private GameProperties gp;
    [Header("Objects")]
    [SerializeField]
    private Button startButton;
    [SerializeField]
    private Transform triangle;
    [SerializeField]
    private Text argentTotal;

    private void Start()
    {
        startButton.onClick.AddListener(switchMustRoll);
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
            gp.typeJeu = "NP";
        }
        else
        {
            gp.mustRoll = false;
        }
    }

    private void refreshArgent()
    {
        argentTotal.text = "Argent total : " + gp.argentTotal + "�";
    }
}
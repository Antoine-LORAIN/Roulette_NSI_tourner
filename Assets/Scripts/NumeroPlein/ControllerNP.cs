using UnityEngine;
using UnityEngine.Assertions.Must;
using UnityEngine.UI;

public class ControllerNP : MonoBehaviour
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
    [SerializeField]
    private InputField mise;
    [SerializeField]
    private InputField numero;

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
        }
        else
        {
            gp.mustRoll = false;
        }
        mise.enabled = false;
        numero.enabled = false;
    }

    private void refreshArgent()
    {
        argentTotal.text = "Argent total : " + gp.argentTotal + "€";
    }
}
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class RotationNP : MonoBehaviour
{
    [SerializeField]
    private GameProperties gp;
    [SerializeField]
    private float rotSpeed;
    [SerializeField]
    private GameObject popup;
    [SerializeField]
    private InputField miseInput;
    [SerializeField]
    private InputField numeroInput;
    [Header("Script de la logique")]
    [SerializeField]
    private LogiqueNP logique;
    /*[SerializeField]
    private LogiqueCS logiqueCS;*/
    private float currentRotation;

    private List<int> nombreRoue = new List<int>() {0, 32, 15, 19, 4, 21, 2, 25, 17, 34, 6, 27, 13, 36, 11, 30, 8, 23, 10, 5, 24, 16, 33, 1, 20, 14 ,31, 9, 22, 18, 29, 7, 28, 12, 35, 3, 26 };

    private void Start()
    {
        rotSpeed = UnityEngine.Random.Range(gp.rotSpeedMin, gp.rotSpeedMax);
    }

    private void Update()
    {
        if (gp.mustRoll && gp.canRoll)
        {
            popup.SetActive(false);
            miseInput.enabled = false;
            numeroInput.enabled = false;
            if (rotSpeed >= 0)
            {
                rotate(rotSpeed);
                rotSpeed--;
            }
            else
            {
                getNumber();
                gp.mustRoll = false;
                rotSpeed = UnityEngine.Random.Range(gp.rotSpeedMin, gp.rotSpeedMax);
                logique.Play();
            }
        }

        float rotation = transform.rotation.eulerAngles.z;

        if (miseInput.text != "" && numeroInput.text != "")
        {

            gp.canRoll = true;
        }
        else
        {
            gp.canRoll = false;
        }
    }

    private void rotate(float speed)
    {
        transform.Rotate(Vector3.forward * speed * Time.deltaTime);
    }

    private void getNumber()
    {
        currentRotation = transform.rotation.eulerAngles.z;
        float positionListToRound = (currentRotation * 37 / 360);
        int positionList = Mathf.RoundToInt(positionListToRound);
        gp.nombreTire = nombreRoue[positionList];
    }
}
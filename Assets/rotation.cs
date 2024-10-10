using UnityEngine;

public class Rotate : MonoBehaviour
{
    [SerializeField]
    private float rotSpeed = 2500f;

    private void Update()
    {
        Debug.Log(rotSpeed);
        if (rotSpeed >= -49f)
        {
            RotateRoue(rotSpeed);
            rotSpeed--;
            Debug.Log(transform.rotation);
        }
    }

    private void RotateRoue(float speed)
    {
        transform.Rotate(Vector3.forward * speed * Time.deltaTime);
    }
}
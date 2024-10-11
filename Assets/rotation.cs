using UnityEngine;

public class Rotate : MonoBehaviour
{
    [SerializeField]
    private float rotSpeed = Random.Range(2500, 5000);
    public bool mustRoll = false;

    private void Update()
    {
        if (mustRoll) 
            {
            Debug.Log(rotSpeed);
            if (rotSpeed >= -49f)
            {
                RotateRoue(rotSpeed);
                rotSpeed--;
                Debug.Log(transform.rotation);
            }
        }
    }

    private void RotateRoue(float speed)
    {
        transform.Rotate(Vector3.forward * speed * Time.deltaTime);
    }
}
using UnityEngine;

public class CameraRotation : MonoBehaviour
{
    //camera rotation speed
    public float speed = 10f;

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0f, speed * Time.deltaTime);
    }
}

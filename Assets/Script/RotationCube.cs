using UnityEngine;

public class RotationCube : MonoBehaviour
{
    bool tourner = false;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.T))
        {
            tourner = !tourner;
        }

        if (tourner)
        {
            transform.Rotate(0, 100 * Time.deltaTime, 0);
        }
    }
}
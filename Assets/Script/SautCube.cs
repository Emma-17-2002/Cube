using UnityEngine;

public class SautCube : MonoBehaviour
{
    public float forceSaut = 5f;

    private Rigidbody rb;
    private bool auSol = true;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && auSol)
        {
            rb.AddForce(Vector3.up * forceSaut, ForceMode.Impulse);
            auSol = false;
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Sol"))
        {
            auSol = true;
        }
    }
}
using UnityEngine;

public class DeplacementCube : MonoBehaviour
{
    public float vitesse = 5f;

    private Vector3 cible;

    void Start()
    {
        cible = transform.position;
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

            RaycastHit hit;

            if (Physics.Raycast(ray, out hit))
            {
                cible = hit.point;
            }
        }

        transform.position = Vector3.MoveTowards(
            transform.position,
            cible,
            vitesse * Time.deltaTime
        );
    }
}
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Frog : MonoBehaviour
{
    private RaycastHit hit;
    [SerializeField] private LayerMask hitLayer;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void isClicked()
    {
        Debug.Log(this.gameObject.tag + " froga týklandý.");
        MoveManager.Moves--;
        TongueMove();
    }

    private void TongueMove()
    {
        if (Physics.Raycast(transform.position, -transform.forward,out hit,4,hitLayer))
        {
            if (hit.collider.CompareTag(gameObject.tag))
            {
                Debug.Log(hit.collider.name);
                Destroy(hit.collider.gameObject);
            }
        }
    }

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.red;

        // Rayýn baþlangýç noktasýný ve yönünü belirleyin
        Vector3 rayOrigin = transform.position;
        Vector3 rayDirection = -transform.forward;

        // Ray'ýn çizileceði mesafeyi belirleyin
        float rayDistance = 4.0f;

        if (hit.collider != null)
        {
            // Eðer bir çarpýþma varsa, ray'ý çarpýþma noktasýna kadar çizin ve çarpýþma noktasýnda bir küre çizin
            Gizmos.DrawRay(rayOrigin, rayDirection * hit.distance);
            Gizmos.DrawSphere(hit.point, 0.1f);
        }
        else
        {
            // Eðer çarpýþma yoksa, ray'ý maksimum mesafeye kadar çizin
            Gizmos.DrawRay(rayOrigin, rayDirection * rayDistance);
        }
    }
}

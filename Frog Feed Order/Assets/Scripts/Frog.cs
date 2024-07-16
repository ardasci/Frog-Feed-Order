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
        Debug.Log(this.gameObject.tag + " froga t�kland�.");
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

        // Ray�n ba�lang�� noktas�n� ve y�n�n� belirleyin
        Vector3 rayOrigin = transform.position;
        Vector3 rayDirection = -transform.forward;

        // Ray'�n �izilece�i mesafeyi belirleyin
        float rayDistance = 4.0f;

        if (hit.collider != null)
        {
            // E�er bir �arp��ma varsa, ray'� �arp��ma noktas�na kadar �izin ve �arp��ma noktas�nda bir k�re �izin
            Gizmos.DrawRay(rayOrigin, rayDirection * hit.distance);
            Gizmos.DrawSphere(hit.point, 0.1f);
        }
        else
        {
            // E�er �arp��ma yoksa, ray'� maksimum mesafeye kadar �izin
            Gizmos.DrawRay(rayOrigin, rayDirection * rayDistance);
        }
    }
}

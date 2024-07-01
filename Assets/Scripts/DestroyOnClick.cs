using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOnClick : MonoBehaviour
{
    void Update()
    {
        // Check for left mouse button click
        if (Input.GetMouseButtonDown(0))
        {
            // Cast a ray from the mouse position into the scene
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit2D hit = Physics2D.GetRayIntersection(ray);

            // Check if the ray hit this GameObject
            if (hit.collider != null && hit.collider.gameObject == gameObject)
            {
                // Destroy this GameObject
                Destroy(gameObject);
            }
        }
    }
}
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MousePosition : MonoBehaviour
{
    public Vector3 screenPosition;
    public Vector3 worldPosition;
    

    // Update is called once per frame
    void Update()
    {
        //Ray ray = mainCamera.ScreenPointToRay(Input.mousePosition);

        /*if (Physics.Raycast(ray, out RaycastHit raycastHit))
        {
            transform.position = raycastHit.point;

        }*/
        screenPosition = Input.mousePosition;
        //screenPosition.z = Camera.main.nearClipPlane +15;

        //worldPosition = Camera.main.ScreenToWorldPoint(screenPosition);

        Ray ray = Camera.main.ScreenPointToRay(screenPosition);
        if (Physics.Raycast(ray, out RaycastHit hitData)) // for collisions again objects
        {
            worldPosition = hitData.point;
        }

        transform.position = worldPosition;

    }
}

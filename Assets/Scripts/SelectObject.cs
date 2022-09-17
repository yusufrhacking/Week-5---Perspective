using Cinemachine;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor.UIElements;
using UnityEngine;

public class SelectObject : MonoBehaviour
{
    [SerializeField] LayerMask layerMask;
    RaycastHit raycastHit;
    Ray selectionRay;

    [SerializeField] Material selectedMaterial;
    Material objectOriginalMaterial;

    GameObject selectedObject;
    GameObject previouslySelectedObject;

    [SerializeField] string tagString;

    // Start is called before the first frame update
    void Start()
    {
        selectionRay = new Ray();
    }

    // Update is called once per frame
    void Update()
    {
        selectionRay.origin = gameObject.transform.position;
        selectionRay.direction = gameObject.transform.forward;

        Physics.Raycast(selectionRay, out raycastHit);

        ChangeSelectedObjectColor(raycastHit);
    }

    private void ChangeSelectedObjectColor(RaycastHit raycastHit)
    {
        if (raycastHit.collider == null)
        {
            if (previouslySelectedObject != null && 
                previouslySelectedObject.gameObject.tag == "Selectable")
            {
                if (objectOriginalMaterial != null)
                    previouslySelectedObject.GetComponent<Renderer>().material = objectOriginalMaterial;
                previouslySelectedObject = null;
            }
            return;
        }

        selectedObject = raycastHit.collider.gameObject;

        if (selectedObject.tag == tagString)
        {
            if (selectedObject != previouslySelectedObject)
            {
                if (objectOriginalMaterial != null && previouslySelectedObject != null)
                    previouslySelectedObject.GetComponent<Renderer>().material = objectOriginalMaterial;

                objectOriginalMaterial = selectedObject.GetComponent<Renderer>().material;
                selectedObject.GetComponent<Renderer>().material = selectedMaterial;
            }

            previouslySelectedObject = selectedObject;
        }
        else if (selectedObject.tag != tagString)
        {
            if (previouslySelectedObject != null)
                previouslySelectedObject.GetComponent<Renderer>().material = objectOriginalMaterial;
            previouslySelectedObject = null;
        }

    }
}

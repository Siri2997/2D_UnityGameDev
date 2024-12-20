using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Delivery : MonoBehaviour
{
    [SerializeField] Color32 hasPackageColor = new Color32(1, 1, 1, 1);
    [SerializeField] Color32 noPackageColor = new Color32(1, 1, 1, 1);


    [SerializeField] float destroyDelay = 0.5f;
    bool hasPackage;

    SpriteRenderer spriteRenderer;

    private void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }


    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("Ouch!");
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        //Debug.Log("What was that?!");
        if(collision.tag == "Package" && !hasPackage)
        {
            Debug.Log("Package picked up");
            hasPackage = true;
            spriteRenderer.color = hasPackageColor;
            Destroy(collision.gameObject, destroyDelay);
        }

        if(collision.tag == "Customer" && hasPackage)
        {
            Debug.Log("Package Delivered Succefully");
            spriteRenderer.color = noPackageColor;
            hasPackage = false;
        }

    }
}

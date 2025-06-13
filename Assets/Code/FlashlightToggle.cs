using UnityEngine;

public class FlashlightToggle : MonoBehaviour
{
    public GameObject spotlightObject; 

    private bool isActive = false;

    void Start()
    {
        if (spotlightObject == null)
        {
           
            return;
        }

        spotlightObject.SetActive(isActive);
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F))
        {
            isActive = !isActive;
            spotlightObject.SetActive(isActive);
        }
    }
}
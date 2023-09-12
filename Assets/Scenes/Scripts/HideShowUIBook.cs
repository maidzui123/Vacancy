using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HideShowUIBook : MonoBehaviour
{
    [SerializeField] private GameObject touchUI_1;
    [SerializeField] private GameObject touchUI_2;
    private bool isNear;
    private bool isRead = false;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if (!isNear)
        {
            touchUI_1.SetActive(false);
            touchUI_2.SetActive(false);
        }
        else
        {
            touchUI_1.SetActive(true);
            checkRead();
        }

    }

    private void OnTriggerEnter(Collider col)
    {
        if (col.CompareTag("Player"))
        {
            isNear = true;
        }
    }
    private void OnTriggerExit(Collider col)
    {
        if (col.CompareTag("Player"))
        {
            isNear = false;
        }
    }
    void InputKey()
    {
        if (Input.GetKeyDown(KeyCode.F) && isRead == false)
        {
            isRead = true;

        }
        else if (Input.GetKeyDown(KeyCode.F) && isRead == true)
        {
            isRead = false;
        }
    }
    void checkRead()
    {
        if (isRead)
        {
            touchUI_2.SetActive(true);
            touchUI_1.SetActive(false);

        }
        else
        {
            touchUI_2.SetActive(false);
            touchUI_1.SetActive(true);
        }
        InputKey();
    }
}

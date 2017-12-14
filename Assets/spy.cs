using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spy : MonoBehaviour {

    public GameObject B1;
    public GameObject B2;
    public GameObject B3;
    public GameObject B4;
    public GameObject B5;
    public GameObject B6;
    public GameObject B7;
    public GameObject B8;
    public GameObject B9;
    public GameObject B10;
    public GameObject B11;
    public GameObject B12;
    public GameObject B13;
    public GameObject B14;
    public GameObject B15;
    public GameObject B16;
    public GameObject B17;
    public GameObject B18;
    public GameObject B19;
    public GameObject B20;
    public GameObject B21;
    public GameObject B22;
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetMouseButtonDown(0))
        {
            RaycastHit hit;
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

            if (Physics.Raycast(ray, out hit, 100.0f))
            {
                if (hit.transform.gameObject == B1)
                {
                    B1.GetComponent<DialogueTrigger>().TriggerDialogue();
                }
                if (hit.transform.name == B2.name)
                {
                    B2.GetComponent<DialogueTrigger>().TriggerDialogue();
                }
                if (hit.transform.name == B3.name)
                {
                    B3.GetComponent<DialogueTrigger>().TriggerDialogue();
                }
                if (hit.transform.name == B4.name)
                {
                    B4.GetComponent<DialogueTrigger>().TriggerDialogue();
                }
                if (hit.transform.name == B5.name)
                {
                    B5.GetComponent<DialogueTrigger>().TriggerDialogue();
                }
                if (hit.transform.name == B6.name)
                {
                    B6.GetComponent<DialogueTrigger>().TriggerDialogue();
                }
                if (hit.transform.name == B7.name)
                {
                    B7.GetComponent<DialogueTrigger>().TriggerDialogue();
                }
                if (hit.transform.name == B8.name)
                {
                    B8.GetComponent<DialogueTrigger>().TriggerDialogue();
                }
                if (hit.transform.name == B9.name)
                {
                    B9.GetComponent<DialogueTrigger>().TriggerDialogue();
                }
                if (hit.transform.name == B10.name)
                {
                    B10.GetComponent<DialogueTrigger>().TriggerDialogue();
                }
                if (hit.transform.name == B11.name)
                {
                    B11.GetComponent<DialogueTrigger>().TriggerDialogue();
                }
                if (hit.transform.name == B12.name)
                {
                    B12.GetComponent<DialogueTrigger>().TriggerDialogue();
                }
                if (hit.transform.name == B13.name)
                {
                    B13.GetComponent<DialogueTrigger>().TriggerDialogue();
                }
                if (hit.transform.name == B14.name)
                {
                    B14.GetComponent<DialogueTrigger>().TriggerDialogue();
                }
                if (hit.transform.name == B15.name)
                {
                    B15.GetComponent<DialogueTrigger>().TriggerDialogue();
                }
                if (hit.transform.name == B16.name)
                {
                    B16.GetComponent<DialogueTrigger>().TriggerDialogue();
                }
                if (hit.transform.name == B17.name)
                {
                    B17.GetComponent<DialogueTrigger>().TriggerDialogue();
                }
                if (hit.transform.name == B18.name)
                {
                    B18.GetComponent<DialogueTrigger>().TriggerDialogue();
                }
                if (hit.transform.name == B19.name)
                {
                    B19.GetComponent<DialogueTrigger>().TriggerDialogue();
                }
                if (hit.transform.name == B20.name)
                {
                    B20.GetComponent<DialogueTrigger>().TriggerDialogue();
                }
                if (hit.transform.name == B21.name)
                {
                    B21.GetComponent<DialogueTrigger>().TriggerDialogue();
                }
                if (hit.transform.name == B22.name)
                {
                    B22.GetComponent<DialogueTrigger>().TriggerDialogue();
                }
            }
        }
    }
}

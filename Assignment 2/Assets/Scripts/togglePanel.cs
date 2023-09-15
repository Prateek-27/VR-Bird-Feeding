using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class togglePanel : MonoBehaviour
{
    public GameObject panel;
    public bool checklst;
    // Start is called before the first frame update
    void Start()
    {
        panel = GameObject.Find("/Canvas/Panel");
   
    }

    // Update is called once per frame
    void Update()
    {
        // Toggle
        checklst = GetComponent<PlayerController>().checklist;
        //Debug.Log(checklst);
        if (checklst == false)
        {
            panel.SetActive(false);
        }
        else
        {
            panel.SetActive(true);
        }
    }
}

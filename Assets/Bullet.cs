using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[ExecuteInEditMode]
public class Bullet : MonoBehaviour
{
    //Handles the checkbox
    public bool openNextWindow=false;
    //reference the game object that you wanted to check
    public GameObject nextWindow;
    //
    public List <string> scripts;
    
    private void OnEnable()
    {
        MonoBehaviour[] allScriptsInChildren = nextWindow.GetComponentsInChildren<MonoBehaviour>();

        foreach (MonoBehaviour script in allScriptsInChildren)
        {
            scripts.Add(script.GetType().Name);
        }
    }
    private void OnDisable() {
        scripts.Clear();
    }

    // Update is called once per frame
    void Update()
    {        
        // transform.position = transform.position + (Vector3.forward*Time.deltaTime*10);
        
    }
}

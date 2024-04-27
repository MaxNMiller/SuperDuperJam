
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CanvasController : MonoBehaviour
{
    CanvasView view;

    // Start is called before the first frame update
    void Start()
    {
        GameManager.canvasController = this;
        view = GetComponent<CanvasView>();
        if (view == null) {
            Debug.LogError($"I expected a view attached");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager
{
    private static GameManager _instance = new GameManager();
    public static GameManager Instance { 
        get => _instance;
        private set => _instance = value;
    }

    private CanvasController _canvasController; 
    public static CanvasController canvasController {
      get => _instance._canvasController;
      set => _instance._canvasController = value;  
    } 

    public GameManager() {

    }
}

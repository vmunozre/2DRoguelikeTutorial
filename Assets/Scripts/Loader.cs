using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Loader : MonoBehaviour {
    public GameObject gameManager;
    private Camera camera;
    void Awake () {
        camera = GetComponent<Camera>();
        
        if (GameManager.instance == null)
        {
            Instantiate(gameManager);
        }
        checkCamera(GameManager.instance.level);
    }

    void Update()
    {
       if ((GameManager.instance.level % 4 != 0) || (GameManager.instance.level > 24)) return;

        int cameraLevel = GameManager.instance.level / 4;
        Vector3 temp = transform.position;
        
        transform.position = new Vector3(3.5f + cameraLevel, 3.5f + cameraLevel, temp.z);
        camera.orthographicSize = 5 + cameraLevel;
    }

    void checkCamera(int level)
    {
        int cameraLevel = GameManager.instance.level / 4;
        if (level > 25) cameraLevel = 24/4;

        Vector3 temp = transform.position;

        transform.position = new Vector3(3.5f + cameraLevel, 3.5f + cameraLevel, temp.z);
        camera.orthographicSize = 5 + cameraLevel;
    }

}

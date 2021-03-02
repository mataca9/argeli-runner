using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        CanvasGroup canvasgroup = transform.Find("Start").gameObject.GetComponent<CanvasGroup>();
        LeanTween.alphaCanvas(canvasgroup, 0.0f, 0.5f).setLoopPingPong();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            SceneManager.LoadScene(1);
        }
    }
}

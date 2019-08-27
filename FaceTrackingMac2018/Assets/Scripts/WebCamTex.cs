using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WebCamTex : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Application.RequestUserAuthorization(UserAuthorization.WebCam);
        WebCamTexture webcamTexture = new WebCamTexture();
        Renderer _renderer = GetComponent<Renderer>();
        _renderer.material.mainTexture = webcamTexture;
        webcamTexture.Play();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

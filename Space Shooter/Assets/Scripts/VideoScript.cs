using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VideoScript : MonoBehaviour
{

    void Start()
    {
        GameObject camera = GameObject.Find("Main Camera");
        var videoPlayer = camera.AddComponent<UnityEngine.Video.VideoPlayer>();
        // videoPlayer.url = "C:/Users/user/UnityProj/GameZone/Space Shooter/Assets/Intro Scene.mp4";
        videoPlayer.url = "Assets/Intro Scene.mp4";
        videoPlayer.isLooping = false;
        videoPlayer.playOnAwake = true;
        videoPlayer.Play();
    }


    void Update()
    {

    }
}

using UnityEngine;
using UnityEngine.Video;

public class AppManager : MonoBehaviour 
{
    public static AppManager Instance;
    [SerializeField] private VideoPlayer videoPlayer;

    private void Awake()
    {
        Instance = this;
    }

    public VideoPlayer GetVideoPlayer()
    {
        return videoPlayer;
    }
}
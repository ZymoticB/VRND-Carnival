using System.Diagnostics;
using UnityEngine;
using TMPro;


public class Timer : MonoBehaviour {

    [SerializeField]
    private TextMeshPro timerText;

    private Stopwatch stopwatch;

    public static Timer Instance;


    // Use this for initialization
    void Start () {
        if (Instance == null) {
            Instance = this;
        }

        stopwatch = Stopwatch.StartNew();
	}
	
	// Update is called once per frame
    void Update () {
        timerText.SetText(stopwatch.Elapsed.ToString());
    }

    private void OnDestroy()
    {
        stopwatch.Stop();
        stopwatch = null;

        if (Instance == this)
        {
            Instance = null;
        }
    }

    public void StopTimer()
    {
        stopwatch.Stop();
    }
}

using UnityEngine;

public class FrameRateManager : MonoBehaviour
{
    public int defaultFrameRate = 60;

    private void Awake()
    {
        SetFrameRate(defaultFrameRate);
    }
    
    public void SetFrameRate(int rate)
    {
        Application.targetFrameRate = rate;
    }
}

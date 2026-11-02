using UnityEngine;
using UnityEngine.Events;

public class IntToString : MonoBehaviour
{
    public UnityEvent<string> onConversion;

    public void ConvertIntToString(int value)
    {
        onConversion.Invoke(value.ToString());
    }

    public void ConvertIntToString(float value)
    {
        onConversion.Invoke(value.ToString("F2"));
    }
}

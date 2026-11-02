using UnityEngine;
using TMPro;
using UnityEngine.Events;
using System.Linq;

public class OptionsToInt : MonoBehaviour
{
    public int[] ints;
    public TMP_Dropdown dropdown;

    public UnityEvent<int> onSelection;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        if (!dropdown)
        {
            dropdown = GetComponentInChildren<TMP_Dropdown>();
        }

        dropdown.ClearOptions();
        var options = ints.Select(i => i.ToString() + "fps").ToList();
        dropdown.AddOptions(options);
    }

    public void SelectInt(int index)
    {
        onSelection.Invoke(ints[index]);
    }
}

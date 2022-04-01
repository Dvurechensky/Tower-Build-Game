using UnityEngine;
using CustomAttributes;

public class ControlClear : MonoBehaviour
{
    [EditorButton("������ �������� ������������")]
    public void ClearPrefs()
    {
        Debug.Log("��������� ������������ �������!");
        PlayerPrefs.DeleteAll();
    }
}

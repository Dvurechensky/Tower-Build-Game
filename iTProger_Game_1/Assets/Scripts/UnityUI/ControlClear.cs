using UnityEngine;
using CustomAttributes;

public class ControlClear : MonoBehaviour
{
    [EditorButton("Чистка настроек пользователя")]
    public void ClearPrefs()
    {
        Debug.Log("Настройки пользователя очищены!");
        PlayerPrefs.DeleteAll();
    }
}

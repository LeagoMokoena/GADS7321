using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[System.Serializable]

public struct cho
{
    [TextArea(2,5)]
    public string tex;
    public chats _chats;
}

[CreateAssetMenu(fileName = "New que", menuName = "que")]
public class question : ScriptableObject
{
    [TextArea(2,5)]
    public string tex;
    public cho[] options;
}

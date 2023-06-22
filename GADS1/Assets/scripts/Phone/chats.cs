using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[System.Serializable]

public struct line
{
    public people people;

    [TextArea(2,5)]
    public string title;
}

[CreateAssetMenu(fileName ="new chat", menuName = "chat")]
public class chats : ScriptableObject
{
    public people left;
    public people right;
    public line[] lines;
    public question question;
    public chats nextchat;
}

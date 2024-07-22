using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Card : MonoBehaviour
{
    public string name;
    public string[] description; // เปลี่ยน description เป็น array ของ string
    public int[] status;         // เปลี่ยน status เป็น array ของ int
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class RandomCard : MonoBehaviour
{
    [System.Serializable]
    public class Cards
    {
        public string name;
        public float price;         // เปลี่ยน status เป็น array ของ int
    }

    public Cards[] randomCards;

    public TextMeshProUGUI textName;
    public TextMeshProUGUI textPrice;

    void Start()
    {
        if (randomCards.Length > 0)
        {
            int randomIndex = Random.Range(0, randomCards.Length);
            ShowCard(randomIndex); // แสดงการ์ดที่สุ่มเลือก
        }
    }

    void Update()
    {

    }

    void ShowCard(int index)
    {
        if (index >= 0 && index < randomCards.Length)
        {
            textName.text = randomCards[index].name;
            textPrice.text = randomCards[index].price.ToString("F2"); // แปลง float เป็น string พร้อมกำหนดทศนิยม 2 ตำแหน่ง
        }
    }
}

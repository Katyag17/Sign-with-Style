using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System;

public class ClothingManager : MonoBehaviour
{
    [SerializeField]
    public ClothingItem[] closet;
    public List<GameObject> items;
    public List<GameObject> text;

    void generateCloset() {
        for (int i = 0; i < closet.Length; i++) {
            GameObject clothingItem = new GameObject("Item_" + i);
            clothingItem.transform.position = new Vector3(i * 3, 0, 5);

            clothingItem.AddComponent<Image>();
            clothingItem.GetComponent<Image>().sprite = closet[i].image;
            clothingItem.AddComponent<TextMeshPro>();
            clothingItem.GetComponent<TextMeshPro>().text = closet[i].word;

            items.Add(clothingItem);

            

        }
    }


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        generateCloset();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

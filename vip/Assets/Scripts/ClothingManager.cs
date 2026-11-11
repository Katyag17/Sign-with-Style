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
    public TextMeshPro textPrefab;
    public Canvas canvas;
    public List<GameObject> items;
    public List<TextMeshPro> texts;

    void generateCloset() {
        for (int i = 0; i < closet.Length; i++) {
            GameObject clothingItem = new GameObject("Item_" + i);
            TextMeshPro itemText = Instantiate(textPrefab, canvas.transform);
            clothingItem.transform.SetParent(canvas.transform);
            clothingItem.transform.localScale = new Vector3(0.5f, 0.5f, 0.5f);
            clothingItem.AddComponent<RectTransform>();
            //itemText.font = 
            //itemText.AddComponent<RectTransform>();

            RectTransform clothingTransform = clothingItem.GetComponent<RectTransform>();
            if (clothingTransform != null) {
                clothingTransform.anchoredPosition = Vector2.zero;
            } else {
                clothingTransform.transform.localPosition = Vector2.zero;
            }

            RectTransform textTransform = itemText.GetComponent<RectTransform>();
            
            clothingTransform.GetComponent<RectTransform>().anchoredPosition += new Vector2(i * 5, 5);
            textTransform.GetComponent<RectTransform>().anchoredPosition += new Vector2(i * 5, 10);
            
            if (textTransform != null) {
                textTransform.anchoredPosition = Vector3.zero;
            } else {
                textTransform.transform.localPosition = Vector3.zero;
            }


            clothingItem.AddComponent<Image>();
            clothingItem.GetComponent<Image>().sprite = closet[i].image;
            itemText.GetComponent<TMP_Text>().text = closet[i].word;
            items.Add(clothingItem);
            texts.Add(itemText);

            

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

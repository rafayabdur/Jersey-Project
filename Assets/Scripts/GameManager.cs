using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;


public class GameManager : MonoBehaviour
{
    [SerializeField] private GameObject colorPanel;
    [SerializeField] private GameObject textPanel;
    [SerializeField] private Button colorBtn;
    [SerializeField] private Button textBtn;


    public GameObject model;

    


    private bool isOn;
    public Material[] modelMaterials;
    public Color[] modelColor;


    public void Awake()
    {
        StartingColors();
    }

    private void Start()
    {
        
        isOn = false;
        colorPanel.SetActive(false);
        textPanel.SetActive(false);
        //int Length = model.GetComponent<MeshRenderer>().materials.Length;
       

    }
    public void OnClick_ColorBtn()
    {
        
        isOn ^= true;
        colorPanel.SetActive(isOn);

        //textPanel.SetActive(false);
        
        if (textBtn.interactable == true)
        {
            textBtn.interactable = false;

        }
        else
        {
            textBtn.interactable = true;
        }
        

    }

    public void OnClick_TextBtn()
    {
        
        isOn ^= true;
        textPanel.SetActive(isOn);
        //colorPanel.SetActive(false);
       
        if (colorBtn.interactable == true)
        {
            colorBtn.interactable = false;
        }
        else
        {
            colorBtn.interactable = true    ;
        }
        

    }
    //***********************************************************IF YOU WANT TO CHANGE COLOR OF ALL MATERIALS*********************//
    //public void OnClick_ColourBtn(int btnindex)
    //{
    //    //rend.sharedMaterial.color = modelColor[0];

    //    for(int i = 0; i < rend.materials.Length; i++)
    //    {
    //        rend.materials[i].color = modelColor[btnindex];
    //    }
    //}

    //public void OnClick_ButtonsBtn(int btnindex)
    //{

    //    //int Length = model.GetComponent<MeshRenderer>().materials.Length;
    //    for (int i = 0; i < model.GetComponent<MeshRenderer>().materials.Length; i++)
    //    {
    //        modelMaterials[i] = model.GetComponent<MeshRenderer>().materials[i];
    //    }
    //    modelMaterials[0].color = modelColor[btnindex];

    //}

    public void OnClick_ButtonsBtn(Image _color)
    {

        //int Length = model.GetComponent<MeshRenderer>().materials.Length;
        for (int i = 0; i < model.GetComponent<MeshRenderer>().materials.Length; i++)
        {
            modelMaterials[i] = model.GetComponent<MeshRenderer>().materials[i];
        }
        modelMaterials[0].color = _color.color;

    }

    public void OnClick_BaseBtn(Image _color)
    {
       

        //int Length = model.GetComponent<MeshRenderer>().materials.Length;
        for (int i = 0; i < model.GetComponent<MeshRenderer>().materials.Length; i++)
        {
            modelMaterials[i] = model.GetComponent<MeshRenderer>().materials[i];
        }
        //modelMaterials[1].color = modelColor[btnindex];
        modelMaterials[1].color = _color.color;
       
    }

    
    public void OnClick_SleevesBtn(Image _color)
    {

        //int Length = model.GetComponent<MeshRenderer>().materials.Length;
        for (int i = 0; i < model.GetComponent<MeshRenderer>().materials.Length; i++)
        {
            modelMaterials[i] = model.GetComponent<MeshRenderer>().materials[i];
        }
       
        modelMaterials[2].color = _color.color;
        
       
    }
    public void OnClick_LinesBtn(Image _color)
    {
       
        //int Length = model.GetComponent<MeshRenderer>().materials.Length;
        for (int i = 0; i < model.GetComponent<MeshRenderer>().materials.Length; i++)
        {
            modelMaterials[i] = model.GetComponent<MeshRenderer>().materials[i];
        }
        modelMaterials[3].color = _color.color;
       
    }
    
    public void StartingColors()
    {
        for (int i = 0; i < model.GetComponent<MeshRenderer>().materials.Length; i++)
        {
            modelMaterials[i] = model.GetComponent<MeshRenderer>().materials[i];
            modelMaterials[i].color = modelColor[i];
        }
    }
    
    public void OnClick_QuitBtn()
    {
        Application.Quit();
    }
   





}

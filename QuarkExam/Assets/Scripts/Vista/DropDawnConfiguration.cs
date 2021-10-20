using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UIElements;
using TMPro;

public class DropDawnConfiguration : MonoBehaviour
{
    [SerializeField] GameObject selectSleev;
    [SerializeField] GameObject selectNeck;
    [SerializeField] GameObject selectPant;
    [SerializeField] GameObject selectQuality;
    private int valClothe;
    private Neck valNeck;
    private Sleev valSleev;
    private Pant valPan;
    private Quality valQuality;

    public int ValClothe { get => valClothe;}
    public Neck ValNeck { get => valNeck;}
    public Sleev ValSleev { get => valSleev;}
    public Pant ValPan { get => valPan;}
    public Quality ValQuality { get => valQuality;}

    public void ClotheSelection(int val)
    {
        if(val == 0)
        {
            
            selectPant.SetActive(false);
            selectNeck.SetActive(false);
            selectSleev.SetActive(false);
            selectQuality.GetComponent<TMP_Dropdown>().interactable = false;
            gameObject.GetComponent<InputFieldConfiguration>().UnActiveInputs();
            AdvisorSystem.InputClothe();
            AdvisorSystem.UnActivateDataText();
            
        }
        if(val == 1)
        {
            selectPant.SetActive(false);
            selectNeck.SetActive(true);
            selectSleev.SetActive(true);
            selectQuality.GetComponent<TMP_Dropdown>().interactable = true;
            AdvisorSystem.UnActiveAdvisor();
        }
        if(val == 2)
        {
            selectNeck.SetActive(false);
            selectSleev.SetActive(false);
            selectPant.SetActive(true);
            selectQuality.GetComponent<TMP_Dropdown>().interactable = true;
        }
        valClothe = val;
    }

    public void NeckSelection(int val)
    {
            
        if(val == 0)
        {
            valNeck = Neck.REGULAR;
        }
        else
        {
            valNeck = Neck.MAO;
        }
    }
    public void SleevSelection(int val)
    {
        if (val == 0)
        {
            valSleev = Sleev.SHORT;
        }
        else
        {
            valSleev = Sleev.LONG;
        }
    }
    public void PantSelection(int val)
    {
        if (val == 0)
        {
            valPan = Pant.REGULAR;
        }
        else
        {
            valPan = Pant.CHUPIN;
        }
    }
    public void QualitySelection(int val)
    {
        if (val == 0)
        {
            AdvisorSystem.InputQuality();
            AdvisorSystem.UnActivateDataText();
            gameObject.GetComponent<InputFieldConfiguration>().UnActiveInputs();
        }
        else
        {
            if (val == 1)
            {
                valQuality = Quality.STANDARD;

            }
            if (val == 2)
            {
                valQuality = Quality.STANDARD;
            }
            Next();
        }
    }

    public void Next()
    {
        InputFieldConfiguration ifc = gameObject.GetComponent<InputFieldConfiguration>();
        ifc.ActivarInputPrice();
    }
}

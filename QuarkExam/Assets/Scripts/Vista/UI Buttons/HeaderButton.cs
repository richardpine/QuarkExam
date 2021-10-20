using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class HeaderButton : MonoBehaviour
{
    [SerializeField] private List<GameObject> bodys;

    public void SelectBody(GameObject body)
    {
        foreach(GameObject g in bodys)
        {
            g.SetActive(false);
        }

        body.SetActive(true);
    }
}

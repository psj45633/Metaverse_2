using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PressKey : MonoBehaviour
{
    public GameObject riding;
    public GameObject interaction1;
    public GameObject interaction2;
    public void PressGKey()
    {
        riding.gameObject.SetActive(!riding.gameObject.activeSelf);
    }

    public void PressSpacebar1()
    {
        interaction1.gameObject.SetActive(true);
    }

    public void PressSpacebar2()
    {
        interaction2.gameObject.SetActive(true);
    }


}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PressG : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject riding;
    public void PressGKey()
    {
        riding.gameObject.SetActive(!riding.gameObject.activeSelf);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestUnit : MonoBehaviour
{
    private bool flag = false;
    public bool flag_public = false;
    [SerializeField]
    private bool flag_serialize = false;
    [HideInInspector]
    public bool flag_hide = false;

    // Start is called before the first frame update
    void Start()
    {
        LogFlag();
    }

    public void SetFlag(bool f)
    {
        flag = f;
        flag_public = f;
        flag_serialize = f;
        flag_hide = f;
        LogFlag();
    }

    private void LogFlag()
    {
        Debug.Log(string.Format("{0}: {1}, {2}, {3}, {4}", name, flag, flag_public, flag_serialize, flag_hide));
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

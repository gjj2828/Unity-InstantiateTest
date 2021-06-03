using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestMgr : MonoBehaviour
{
    private GameObject unit1;
    private GameObject unit2;

    // Start is called before the first frame update
    void Start()
    {
        unit1 = new GameObject("TestUnit1", typeof(TestUnit));
        StartCoroutine(TestProcess());
    }

    private IEnumerator TestProcess()
    {
        yield return new WaitForSeconds(1.0f);
        unit1.GetComponent<TestUnit>().SetFlag(true);
        yield return new WaitForSeconds(1.0f);
        unit2 = Instantiate(unit1);
        unit2.name = "TestUnit2";
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Luis Diaz Reynoso #1260642
public class Prac1 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int[] nums = new int[] {8,1,2,2,3};
        int[] res = new int[nums.Length];
        int c = 0;

        for(int j=0; j<nums.Length; j++) {
            for(int k=0; k<nums.Length; k++) {
                if(nums[j] > nums[k]) {
                    c++;
                }
            }
            res[j] = c;
            c = 0;
        }

        foreach(var r in res) {
            Debug.Log(r);
        }

        Debug.Log("Complejidad del algoritmo: O(n^2)");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

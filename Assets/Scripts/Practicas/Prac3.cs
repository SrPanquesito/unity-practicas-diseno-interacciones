using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Luis Diaz Reynoso #1260642
public class Prac3 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int[] nums = new int[] {2,7,11,15};
        
        int[] res = SumaDos(nums, 9);

        for(int c=0;c<2;c++) {
            Debug.Log(res[c]);
        }

        Debug.Log("Complejidad del algoritmo. Tiempo: O(n^2) Espacio: O(1)");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public int[] SumaDos(int[] nums, int target) {
        int[] indx = new int[2];

        for(int j=0; j<nums.Length; j++){
            for(int k=0; k<nums.Length; k++){
                if(nums[j] != nums[k]) {
                    if((nums[j]+nums[k]) == target) {
                        indx[0] = j;
                        indx[1] = k;
                        return indx;
                    }
                }
            }
        }
        Debug.Log("Ninguna suma con el arreglo de nums da como resultado 'target'");
        return indx;
    }
}

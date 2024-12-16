using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace assignment27
{
    public class refrences : MonoBehaviour
    {

        void Start()
        {
            int a = 1;
            int b = 2;
            AddMethod(a);
            Debug.Log (a);
            AddMethod(b);
            Debug.Log(b);
            AdvancedAddMethod(ref a);
            Debug.Log(a);
            MoreAvancedMethod(out b);
            Debug.Log(b);

        }
        public void AddMethod(int num)
        {
            num += 10;
        }
        public void AdvancedAddMethod(ref int num)
        {
            num+=5;
        }
        public void MoreAvancedMethod(out int number)
        {
            number=8;
        }
        void Update()
        {

        }
    }
}
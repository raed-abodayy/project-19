using System;
using System.Collections;
using System.Collections.Generic;
using JetBrains.Annotations;
using Unity.VisualScripting;
using UnityEngine;
namespace assignment26
{
    public class creature
    {
        public virtual void Speak()
        {
            Debug.Log("a creature makes a sound");
        }
    }
    public interface IRunnable
    {
        public void Run()
        {
        }
    }
    public interface Ijumpable
    {
        public void Jump()
        {

        }
    }
    public interface ISwimable
    {
        public void Swim()
        {

        }

    }
    public class kangaroo : creature, IRunnable, Ijumpable
    {
        public void Run()
        {
            Debug.Log("kangaroo runs");
        }
        public void Jump()
        {
            Debug.Log("kangaroo jumps");
        }
        public override void Speak()
        {
            Debug.Log("kangaroo says:hop!");
        }
    }
    public class Duck : creature, IRunnable, ISwimable
    {
        public void Run()
        {
            Debug.Log("duck runs");
        }
        public void Swim()
        {
            Debug.Log("duck swims");
        }
        public override void Speak()
        {
            Debug.Log("duck says:quack!");
        }
    }
}
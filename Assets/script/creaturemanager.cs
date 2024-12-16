using System.Collections;
using System.Collections.Generic;
using assignment26;
using UnityEngine;

public class creaturemanager : MonoBehaviour
{
    kangaroo kangaroo = new kangaroo();
    Duck duck=new Duck();
    void Start()
    {
        List<creature> creatures = new List<creature>();
        List<IRunnable> runnables = new List<IRunnable>();
        List<Ijumpable> jumpables = new List<Ijumpable>();
        List<ISwimable> swimables = new List<ISwimable>();
        creatures.Add(kangaroo);
        creatures.Add(duck);
        runnables.Add(kangaroo);
        jumpables.Add(kangaroo);
        swimables.Add(duck);
        runnables.Add(duck);
        foreach (var runner in runnables)
        { runner.Run(); }
        foreach (var jumper in jumpables)
        { jumper.Jump(); }
        foreach (var swimmer in swimables)
        { swimmer.Swim(); }
        foreach (var creature in creatures)
        { creature.Speak(); }
    }

    void Update()
    {

    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Log {
    public static class Debugger
    {
        private const string endOfSentence = "\n" + "\n";

        public static void Bool(bool boolean, string name)
        {
            Debug.Log("------------------- DEBUGGING " + name + "-------------------");
            Debug.Log(" --- " + boolean + " --- " + endOfSentence);
        }

        public static void MissReference()
        {
            Debug.LogWarning(" ------ WARNING MISSED REFERENCE/NULL OBJECT ------ ");
        }
        public static void Position(GameObject gameObject)
        {
            Debug.Log("------------------- DEBUGGING " + gameObject.name + "-------------------");
            Debug.Log("--- X: " + gameObject.transform.position.x
                     + " --- Y: " + gameObject.transform.position.y + endOfSentence);
        }
    }
}

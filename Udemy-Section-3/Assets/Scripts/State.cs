using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "State")]
public class State:ScriptableObject {

    /*text area changes size of writable space in inspector*/

    [TextArea(14,10)] [SerializeField] string storyText;

}

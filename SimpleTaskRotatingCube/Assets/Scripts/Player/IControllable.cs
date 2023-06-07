using UnityEngine;

public interface IControllable 
{
    void Move();
    void Rotate(string direction);
    void Jump();
}
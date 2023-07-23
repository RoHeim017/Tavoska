using UnityEngine;
using UnityEngine.Events;

public class CharacterEvents
{
    //damage karakter dan angka damage
    public static UnityAction<GameObject, int> characterDamaged;

    //heal karakter dan seberapa banyak
    public static UnityAction<GameObject, int> characterHealed;
}
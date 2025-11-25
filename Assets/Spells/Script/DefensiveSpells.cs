using UnityEngine;

public abstract class DefensiveSpell : Spell
{
    public float duration;
    public float strength; // shield HP or heal amount

    public override void Cast()
    {
        // Default defensive behavior
        Debug.Log(spellName + " defensive spell cast.");

        // Examples:
        // - Add shield
        // - Heal player
        // - Reflect damage
    }
}


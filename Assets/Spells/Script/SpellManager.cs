using UnityEngine;
using System.Collections.Generic;

public class SpellManager : MonoBehaviour
{
    public List<Spell> learnedSpells = new List<Spell>();
    private Spell activeSpell;

    public void LearnSpell(Spell newSpell)
    {
        if (!learnedSpells.Contains(newSpell))
            learnedSpells.Add(newSpell);
    }

    public void SetActiveSpell(Spell spell)
    {
        if (learnedSpells.Contains(spell))
        {
            activeSpell = spell;
            Debug.Log("Active spell: " + spell.spellName);
        }
    }

    public Spell GetActiveSpell()
    {
        return activeSpell;
    }
}

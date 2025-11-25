using UnityEngine;

using UnityEngine;
using System.Collections.Generic;

public class SpellManager : MonoBehaviour
{
    public List<Spell> learnedSpells = new List<Spell>();
    public Spell activeSpell;

    private Dictionary<Spell, float> cooldownTimers = new Dictionary<Spell, float>();

    void Update()
    {
        UpdateCooldowns();
    }

    void UpdateCooldowns()
    {
        var keys = new List<Spell>(cooldownTimers.Keys);

        foreach (var spell in keys)
        {
            cooldownTimers[spell] -= Time.deltaTime;
            if (cooldownTimers[spell] <= 0)
                cooldownTimers.Remove(spell);
        }
    }

    public void SetActiveSpell(Spell spell)
    {
        activeSpell = spell;
    }

    public void CastActiveSpell()
    {
        if (activeSpell == null) return;

        if (cooldownTimers.ContainsKey(activeSpell))
        {
            Debug.Log("Spell on cooldown!");
            return;
        }

        activeSpell.Initialize(this);

        activeSpell.Cast();
        cooldownTimers[activeSpell] = activeSpell.cooldown;
    }
}

using UnityEngine;
using UnityEngine.UI;

public class SpellSelectButton : MonoBehaviour
{
    public SpellManager spellManager;
    public WandController wandController;
    public Spell spell;

    public void SelectSpell()
    {
        spellManager.SetActiveSpell(spell);
        wandController.SetSpellSelected(true);
    }
}

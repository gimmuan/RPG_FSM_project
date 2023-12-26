using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnimationData : MonoBehaviour
{
    [SerializeField] private string groundParameterName = "@Ground";
    [SerializeField] private string idleParameterName = "Idle";
    [SerializeField] private string walkParameterName = "Walk";
    [SerializeField] private string runParameterName = "Run";

    [SerializeField] private string airParameterName = "@Air";
    [SerializeField] private string jumpParameterName = "Jump";
    [SerializeField] private string fallParameterName = "Fall";

    [SerializeField] private string attackParameterName = "@Attack";
    [SerializeField] private string comboAttackParameterName = "ComboAttack";

    public int GroundParmeterHash {  get; private set; }
    public int IdleParmeterHash { get; private set;}
    public int WalkParmeterHash { get; private set; }
    public int RunParmeterHash { get; private set; }
    public int AirParmeterHash { get; private set; }
    public int JumpParmeterHash { get; private set; }
    public int FallParmeterHash { get; private set; }
    public int AttackParmeterHash { get; private set; }
    public int ComboAttackPermeterHash { get; private set; }

    public void Initialize()
    {
        GroundParmeterHash = Animator.StringToHash(groundParameterName);
        IdleParmeterHash = Animator.StringToHash(idleParameterName);
        WalkParmeterHash = Animator.StringToHash(walkParameterName);
        RunParmeterHash = Animator.StringToHash(runParameterName);

        AirParmeterHash = Animator.StringToHash(airParameterName);
        JumpParmeterHash = Animator.StringToHash(jumpParameterName);
        FallParmeterHash = Animator.StringToHash(fallParameterName);

        AttackParmeterHash = Animator.StringToHash(attackParameterName);
        ComboAttackPermeterHash = Animator.StringToHash(comboAttackParameterName);
    }
}

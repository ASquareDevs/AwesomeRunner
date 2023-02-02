using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using UnityEngine;

public class StartingIdleState : PlayerState
{
    private int countdownTime;
    public StartingIdleState(PlayerStateMachine playerStateMachine) : base(playerStateMachine)
    { }
    public override void OnStateEnter()
    {
        playerSM.PlayIdleAnimation(true);
        //Session.SetPlayingState();
        //Session.ShowGameOverPopUp(false);
        GameSession.Instance.RestrictInputs(InputConstants.InGameCommands, true);
        playerTransform.position = new Vector3(0, 0.38f, 15);
        //countdownTime = 3;
        //BeginCountDown();
        //CountdownBeforeTheStart();
    }
    //void BeginCountDown()
    //{
    //    StartCoroutine(CountdownBeforeTheStart());

    //}
    public override void OnStateExit()
    {
        playerSM.PlayIdleAnimation(false);
        playerSM.HorizontalDeltaPosition = Vector3.zero;
        playerSM.VerticalDeltaPosition = 0f;
        GameSession.Instance.RestrictInputs(InputConstants.InGameCommands, false);
    }
    public override void Tick() { }
    //public IEnumerator CountdownBeforeTheStart()
    //{
    //    yield return new WaitForSeconds(countdownTime);


    //    playerSM.SetState(playerSM.PlayerGroundState);
    //}
}

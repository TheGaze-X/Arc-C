using System;
using Il2CppDummyDll;
using UnityEngine;

namespace YoStar.SDK.UIWidgets
{
	// Token: 0x020000CF RID: 207
	[Token(Token = "0x20000CF")]
	public class AnimationEventSender : StateMachineBehaviour
	{
		// Token: 0x06000594 RID: 1428 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6000594")]
		[Address(RVA = "0x5C24AA0", Offset = "0x5C236A0", VA = "0x185C24AA0", Slot = "9")]
		public override void OnStateMachineEnter(Animator animator, int stateMachinePathHash)
		{
		}

		// Token: 0x06000595 RID: 1429 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6000595")]
		[Address(RVA = "0x5C24AB0", Offset = "0x5C236B0", VA = "0x185C24AB0", Slot = "10")]
		public override void OnStateMachineExit(Animator animator, int stateMachinePathHash)
		{
		}

		// Token: 0x06000596 RID: 1430 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6000596")]
		[Address(RVA = "0x5C24A80", Offset = "0x5C23680", VA = "0x185C24A80", Slot = "4")]
		public override void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
		{
		}

		// Token: 0x06000597 RID: 1431 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6000597")]
		[Address(RVA = "0x5C24AC0", Offset = "0x5C236C0", VA = "0x185C24AC0", Slot = "5")]
		public override void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
		{
		}

		// Token: 0x06000598 RID: 1432 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6000598")]
		[Address(RVA = "0x5C24A90", Offset = "0x5C23690", VA = "0x185C24A90", Slot = "6")]
		public override void OnStateExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
		{
		}

		// Token: 0x06000599 RID: 1433 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6000599")]
		[Address(RVA = "0x5C24AD0", Offset = "0x5C236D0", VA = "0x185C24AD0")]
		private void SendEvent(Animator animator)
		{
		}

		// Token: 0x0600059A RID: 1434 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x600059A")]
		[Address(RVA = "0x5C24CD0", Offset = "0x5C238D0", VA = "0x185C24CD0")]
		public AnimationEventSender()
		{
		}

		// Token: 0x04000305 RID: 773
		[Token(Token = "0x4000305")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private AnimationEventSender.AnimationEventType m_Type;

		// Token: 0x04000306 RID: 774
		[Token(Token = "0x4000306")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private string m_EventName;

		// Token: 0x04000307 RID: 775
		[Token(Token = "0x4000307")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private ArgumentVariable m_Argument;

		// Token: 0x020000D0 RID: 208
		[Token(Token = "0x20000D0")]
		public enum AnimationEventType
		{
			// Token: 0x04000309 RID: 777
			[Token(Token = "0x4000309")]
			OnStateEnter,
			// Token: 0x0400030A RID: 778
			[Token(Token = "0x400030A")]
			OnStateUpdate,
			// Token: 0x0400030B RID: 779
			[Token(Token = "0x400030B")]
			OnStateExit,
			// Token: 0x0400030C RID: 780
			[Token(Token = "0x400030C")]
			OnStateMachineEnter,
			// Token: 0x0400030D RID: 781
			[Token(Token = "0x400030D")]
			OnStateMachineExit
		}
	}
}

using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Torappu.Building.Vault
{
	// Token: 0x02001A0D RID: 6669
	[Token(Token = "0x2001A0D")]
	public class FurnitureAnimatorBehaviour : StateMachineBehaviour
	{
		// Token: 0x0600A735 RID: 42805 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A735")]
		[Address(RVA = "0x3223FE0", Offset = "0x3222BE0", VA = "0x183223FE0", Slot = "4")]
		public override void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
		{
		}

		// Token: 0x0600A736 RID: 42806 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A736")]
		[Address(RVA = "0x3224040", Offset = "0x3222C40", VA = "0x183224040", Slot = "6")]
		public override void OnStateExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
		{
		}

		// Token: 0x0600A737 RID: 42807 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A737")]
		[Address(RVA = "0x4E4190", Offset = "0x4E2D90", VA = "0x1804E4190")]
		public FurnitureAnimatorBehaviour()
		{
		}

		// Token: 0x04009F6A RID: 40810
		[Token(Token = "0x4009F6A")]
		[FieldOffset(Offset = "0x18")]
		public string stateKey;

		// Token: 0x04009F6B RID: 40811
		[Token(Token = "0x4009F6B")]
		[FieldOffset(Offset = "0x20")]
		public string triggerName;

		// Token: 0x04009F6C RID: 40812
		[Token(Token = "0x4009F6C")]
		[FieldOffset(Offset = "0x28")]
		public Action<string, AnimatorStateEvent> onStateChange;
	}
}

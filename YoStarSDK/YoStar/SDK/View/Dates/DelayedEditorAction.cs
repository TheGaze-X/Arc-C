using System;
using Il2CppDummyDll;
using UnityEngine;

namespace YoStar.SDK.View.Dates
{
	// Token: 0x02000108 RID: 264
	[Token(Token = "0x2000108")]
	internal class DelayedEditorAction
	{
		// Token: 0x06000730 RID: 1840 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6000730")]
		[Address(RVA = "0x5C4D130", Offset = "0x5C4BD30", VA = "0x185C4D130")]
		public DelayedEditorAction(double timeToExecute, Action action, MonoBehaviour actionTarget, bool forceEvenIfTargetIsGone = false)
		{
		}

		// Token: 0x040003FC RID: 1020
		[Token(Token = "0x40003FC")]
		[FieldOffset(Offset = "0x10")]
		internal double TimeToExecute;

		// Token: 0x040003FD RID: 1021
		[Token(Token = "0x40003FD")]
		[FieldOffset(Offset = "0x18")]
		internal Action Action;

		// Token: 0x040003FE RID: 1022
		[Token(Token = "0x40003FE")]
		[FieldOffset(Offset = "0x20")]
		internal MonoBehaviour ActionTarget;

		// Token: 0x040003FF RID: 1023
		[Token(Token = "0x40003FF")]
		[FieldOffset(Offset = "0x28")]
		internal bool ForceEvenIfTargetIsGone;
	}
}

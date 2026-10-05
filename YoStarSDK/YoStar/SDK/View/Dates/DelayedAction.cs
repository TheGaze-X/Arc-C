using System;
using Il2CppDummyDll;
using UnityEngine;

namespace YoStar.SDK.View.Dates
{
	// Token: 0x0200010B RID: 267
	[Token(Token = "0x200010B")]
	public class DelayedAction
	{
		// Token: 0x0600073E RID: 1854 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x600073E")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public DelayedAction()
		{
		}

		// Token: 0x04000403 RID: 1027
		[Token(Token = "0x4000403")]
		[FieldOffset(Offset = "0x10")]
		public float timeToExecute;

		// Token: 0x04000404 RID: 1028
		[Token(Token = "0x4000404")]
		[FieldOffset(Offset = "0x18")]
		public Action action;

		// Token: 0x04000405 RID: 1029
		[Token(Token = "0x4000405")]
		[FieldOffset(Offset = "0x20")]
		public MonoBehaviour target;

		// Token: 0x04000406 RID: 1030
		[Token(Token = "0x4000406")]
		[FieldOffset(Offset = "0x28")]
		public bool forceEvenIfTargetIsInactive;
	}
}

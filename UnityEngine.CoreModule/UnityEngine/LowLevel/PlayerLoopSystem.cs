using System;
using Il2CppDummyDll;
using UnityEngine.Scripting.APIUpdating;

namespace UnityEngine.LowLevel
{
	// Token: 0x020001A6 RID: 422
	[Token(Token = "0x20001A6")]
	[MovedFrom("UnityEngine.Experimental.LowLevel")]
	public struct PlayerLoopSystem
	{
		// Token: 0x06000D2D RID: 3373 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000D2D")]
		[Address(RVA = "0x59678D0", Offset = "0x59664D0", VA = "0x1859678D0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x040005FA RID: 1530
		[Token(Token = "0x40005FA")]
		[FieldOffset(Offset = "0x0")]
		public Type type;

		// Token: 0x040005FB RID: 1531
		[Token(Token = "0x40005FB")]
		[FieldOffset(Offset = "0x8")]
		public PlayerLoopSystem[] subSystemList;

		// Token: 0x040005FC RID: 1532
		[Token(Token = "0x40005FC")]
		[FieldOffset(Offset = "0x10")]
		public PlayerLoopSystem.UpdateFunction updateDelegate;

		// Token: 0x040005FD RID: 1533
		[Token(Token = "0x40005FD")]
		[FieldOffset(Offset = "0x18")]
		public IntPtr updateFunction;

		// Token: 0x040005FE RID: 1534
		[Token(Token = "0x40005FE")]
		[FieldOffset(Offset = "0x20")]
		public IntPtr loopConditionFunction;

		// Token: 0x020001A7 RID: 423
		// (Invoke) Token: 0x06000D2F RID: 3375
		[Token(Token = "0x20001A7")]
		public delegate void UpdateFunction();
	}
}

using System;
using Il2CppDummyDll;

namespace Torappu.Audio.Engine
{
	// Token: 0x02000260 RID: 608
	[Token(Token = "0x2000260")]
	public struct SnapshotTransition
	{
		// Token: 0x06000DE8 RID: 3560 RVA: 0x00008F0C File Offset: 0x0000710C
		[Token(Token = "0x6000DE8")]
		[Address(RVA = "0x5586AC0", Offset = "0x55856C0", VA = "0x185586AC0")]
		public bool IsValid(out string message)
		{
			return default(bool);
		}

		// Token: 0x04000E89 RID: 3721
		[Token(Token = "0x4000E89")]
		[FieldOffset(Offset = "0x0")]
		public string[] snapshots;

		// Token: 0x04000E8A RID: 3722
		[Token(Token = "0x4000E8A")]
		[FieldOffset(Offset = "0x8")]
		public float[] weights;

		// Token: 0x04000E8B RID: 3723
		[Token(Token = "0x4000E8B")]
		[FieldOffset(Offset = "0x10")]
		public float duration;

		// Token: 0x04000E8C RID: 3724
		[Token(Token = "0x4000E8C")]
		[FieldOffset(Offset = "0x14")]
		public float delay;
	}
}

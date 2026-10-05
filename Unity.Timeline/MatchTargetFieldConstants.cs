using System;
using Il2CppDummyDll;

namespace UnityEngine.Timeline
{
	// Token: 0x02000011 RID: 17
	[Token(Token = "0x2000011")]
	internal static class MatchTargetFieldConstants
	{
		// Token: 0x06000046 RID: 70 RVA: 0x000022C4 File Offset: 0x000004C4
		[Token(Token = "0x6000046")]
		[Address(RVA = "0x58EABD0", Offset = "0x58E97D0", VA = "0x1858EABD0")]
		public static bool HasAny(this MatchTargetFields me, MatchTargetFields fields)
		{
			return default(bool);
		}

		// Token: 0x06000047 RID: 71 RVA: 0x000022DC File Offset: 0x000004DC
		[Token(Token = "0x6000047")]
		[Address(RVA = "0x58EAC40", Offset = "0x58E9840", VA = "0x1858EAC40")]
		public static MatchTargetFields Toggle(this MatchTargetFields me, MatchTargetFields flag)
		{
			return (MatchTargetFields)0;
		}

		// Token: 0x0400003E RID: 62
		[Token(Token = "0x400003E")]
		[FieldOffset(Offset = "0x0")]
		public static MatchTargetFields All;

		// Token: 0x0400003F RID: 63
		[Token(Token = "0x400003F")]
		[FieldOffset(Offset = "0x4")]
		public static MatchTargetFields None;

		// Token: 0x04000040 RID: 64
		[Token(Token = "0x4000040")]
		[FieldOffset(Offset = "0x8")]
		public static MatchTargetFields Position;

		// Token: 0x04000041 RID: 65
		[Token(Token = "0x4000041")]
		[FieldOffset(Offset = "0xC")]
		public static MatchTargetFields Rotation;
	}
}

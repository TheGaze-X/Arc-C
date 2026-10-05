using System;
using Il2CppDummyDll;

namespace AdvancedInspector
{
	// Token: 0x0200004C RID: 76
	[Token(Token = "0x200004C")]
	[Serializable]
	public struct RangeInt
	{
		// Token: 0x0600022E RID: 558 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600022E")]
		[Address(RVA = "0x4F1E60", Offset = "0x4F0A60", VA = "0x1804F1E60")]
		public RangeInt(int min, int max)
		{
		}

		// Token: 0x040000B7 RID: 183
		[Token(Token = "0x40000B7")]
		[FieldOffset(Offset = "0x0")]
		public int min;

		// Token: 0x040000B8 RID: 184
		[Token(Token = "0x40000B8")]
		[FieldOffset(Offset = "0x4")]
		public int max;
	}
}

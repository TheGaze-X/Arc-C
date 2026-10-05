using System;
using Il2CppDummyDll;

namespace AdvancedInspector
{
	// Token: 0x0200004B RID: 75
	[Token(Token = "0x200004B")]
	[Serializable]
	public struct RangeFloat
	{
		// Token: 0x0600022D RID: 557 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600022D")]
		[Address(RVA = "0x4F1E50", Offset = "0x4F0A50", VA = "0x1804F1E50")]
		public RangeFloat(float min, float max)
		{
		}

		// Token: 0x040000B5 RID: 181
		[Token(Token = "0x40000B5")]
		[FieldOffset(Offset = "0x0")]
		public float min;

		// Token: 0x040000B6 RID: 182
		[Token(Token = "0x40000B6")]
		[FieldOffset(Offset = "0x4")]
		public float max;
	}
}

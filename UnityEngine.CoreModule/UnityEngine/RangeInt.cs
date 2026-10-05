using System;
using Il2CppDummyDll;

namespace UnityEngine
{
	// Token: 0x0200010C RID: 268
	[Token(Token = "0x200010C")]
	public struct RangeInt
	{
		// Token: 0x17000204 RID: 516
		// (get) Token: 0x060009D6 RID: 2518 RVA: 0x00005C88 File Offset: 0x00003E88
		[Token(Token = "0x17000204")]
		public int end
		{
			[Token(Token = "0x60009D6")]
			[Address(RVA = "0x5967B20", Offset = "0x5966720", VA = "0x185967B20")]
			get
			{
				return 0;
			}
		}

		// Token: 0x060009D7 RID: 2519 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60009D7")]
		[Address(RVA = "0x4F1E60", Offset = "0x4F0A60", VA = "0x1804F1E60")]
		public RangeInt(int start, int length)
		{
		}

		// Token: 0x040004A6 RID: 1190
		[Token(Token = "0x40004A6")]
		[FieldOffset(Offset = "0x0")]
		public int start;

		// Token: 0x040004A7 RID: 1191
		[Token(Token = "0x40004A7")]
		[FieldOffset(Offset = "0x4")]
		public int length;
	}
}

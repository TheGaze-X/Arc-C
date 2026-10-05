using System;
using Il2CppDummyDll;

namespace Steamworks
{
	// Token: 0x020001AC RID: 428
	[Token(Token = "0x20001AC")]
	public static class Packsize
	{
		// Token: 0x06000975 RID: 2421 RVA: 0x00007ED4 File Offset: 0x000060D4
		[Token(Token = "0x6000975")]
		[Address(RVA = "0x4F0C7F0", Offset = "0x4F0B3F0", VA = "0x184F0C7F0")]
		public static bool Test()
		{
			return default(bool);
		}

		// Token: 0x04000A7E RID: 2686
		[Token(Token = "0x4000A7E")]
		public const int value = 8;

		// Token: 0x020001AD RID: 429
		[Token(Token = "0x20001AD")]
		private struct ValvePackingSentinel_t
		{
			// Token: 0x04000A7F RID: 2687
			[Token(Token = "0x4000A7F")]
			[FieldOffset(Offset = "0x0")]
			private uint m_u32;

			// Token: 0x04000A80 RID: 2688
			[Token(Token = "0x4000A80")]
			[FieldOffset(Offset = "0x8")]
			private ulong m_u64;

			// Token: 0x04000A81 RID: 2689
			[Token(Token = "0x4000A81")]
			[FieldOffset(Offset = "0x10")]
			private ushort m_u16;

			// Token: 0x04000A82 RID: 2690
			[Token(Token = "0x4000A82")]
			[FieldOffset(Offset = "0x18")]
			private double m_d;
		}
	}
}

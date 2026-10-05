using System;
using Il2CppDummyDll;

namespace Steamworks
{
	// Token: 0x02000171 RID: 369
	[Token(Token = "0x2000171")]
	public struct InputAnalogActionData_t
	{
		// Token: 0x040009E1 RID: 2529
		[Token(Token = "0x40009E1")]
		[FieldOffset(Offset = "0x0")]
		public EInputSourceMode eMode;

		// Token: 0x040009E2 RID: 2530
		[Token(Token = "0x40009E2")]
		[FieldOffset(Offset = "0x4")]
		public float x;

		// Token: 0x040009E3 RID: 2531
		[Token(Token = "0x40009E3")]
		[FieldOffset(Offset = "0x8")]
		public float y;

		// Token: 0x040009E4 RID: 2532
		[Token(Token = "0x40009E4")]
		[FieldOffset(Offset = "0xC")]
		public byte bActive;
	}
}

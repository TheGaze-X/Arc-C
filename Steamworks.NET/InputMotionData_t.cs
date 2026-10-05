using System;
using Il2CppDummyDll;

namespace Steamworks
{
	// Token: 0x02000173 RID: 371
	[Token(Token = "0x2000173")]
	public struct InputMotionData_t
	{
		// Token: 0x040009E7 RID: 2535
		[Token(Token = "0x40009E7")]
		[FieldOffset(Offset = "0x0")]
		public float rotQuatX;

		// Token: 0x040009E8 RID: 2536
		[Token(Token = "0x40009E8")]
		[FieldOffset(Offset = "0x4")]
		public float rotQuatY;

		// Token: 0x040009E9 RID: 2537
		[Token(Token = "0x40009E9")]
		[FieldOffset(Offset = "0x8")]
		public float rotQuatZ;

		// Token: 0x040009EA RID: 2538
		[Token(Token = "0x40009EA")]
		[FieldOffset(Offset = "0xC")]
		public float rotQuatW;

		// Token: 0x040009EB RID: 2539
		[Token(Token = "0x40009EB")]
		[FieldOffset(Offset = "0x10")]
		public float posAccelX;

		// Token: 0x040009EC RID: 2540
		[Token(Token = "0x40009EC")]
		[FieldOffset(Offset = "0x14")]
		public float posAccelY;

		// Token: 0x040009ED RID: 2541
		[Token(Token = "0x40009ED")]
		[FieldOffset(Offset = "0x18")]
		public float posAccelZ;

		// Token: 0x040009EE RID: 2542
		[Token(Token = "0x40009EE")]
		[FieldOffset(Offset = "0x1C")]
		public float rotVelX;

		// Token: 0x040009EF RID: 2543
		[Token(Token = "0x40009EF")]
		[FieldOffset(Offset = "0x20")]
		public float rotVelY;

		// Token: 0x040009F0 RID: 2544
		[Token(Token = "0x40009F0")]
		[FieldOffset(Offset = "0x24")]
		public float rotVelZ;
	}
}

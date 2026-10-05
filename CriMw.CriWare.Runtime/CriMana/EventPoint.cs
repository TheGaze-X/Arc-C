using System;
using Il2CppDummyDll;

namespace CriWare.CriMana
{
	// Token: 0x02000131 RID: 305
	[Token(Token = "0x2000131")]
	public struct EventPoint
	{
		// Token: 0x040005AE RID: 1454
		[Token(Token = "0x40005AE")]
		[FieldOffset(Offset = "0x0")]
		public IntPtr cueName;

		// Token: 0x040005AF RID: 1455
		[Token(Token = "0x40005AF")]
		[FieldOffset(Offset = "0x8")]
		public uint cueNameSize;

		// Token: 0x040005B0 RID: 1456
		[Token(Token = "0x40005B0")]
		[FieldOffset(Offset = "0x10")]
		public ulong time;

		// Token: 0x040005B1 RID: 1457
		[Token(Token = "0x40005B1")]
		[FieldOffset(Offset = "0x18")]
		public ulong tunit;

		// Token: 0x040005B2 RID: 1458
		[Token(Token = "0x40005B2")]
		[FieldOffset(Offset = "0x20")]
		public int type;

		// Token: 0x040005B3 RID: 1459
		[Token(Token = "0x40005B3")]
		[FieldOffset(Offset = "0x28")]
		public IntPtr paramString;

		// Token: 0x040005B4 RID: 1460
		[Token(Token = "0x40005B4")]
		[FieldOffset(Offset = "0x30")]
		public uint paramStringSize;

		// Token: 0x040005B5 RID: 1461
		[Token(Token = "0x40005B5")]
		[FieldOffset(Offset = "0x34")]
		public uint cntCallback;
	}
}

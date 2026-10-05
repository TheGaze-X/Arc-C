using System;
using Il2CppDummyDll;

namespace Torappu.UI
{
	// Token: 0x020034A9 RID: 13481
	[Token(Token = "0x20034A9")]
	public struct BackPressOptions
	{
		// Token: 0x060157D1 RID: 88017 RVA: 0x0008C388 File Offset: 0x0008A588
		[Token(Token = "0x60157D1")]
		[Address(RVA = "0xDF9A30", Offset = "0xDF8630", VA = "0x180DF9A30")]
		public bool IsEmpty()
		{
			return default(bool);
		}

		// Token: 0x04019BBE RID: 105406
		[Token(Token = "0x4019BBE")]
		[FieldOffset(Offset = "0x0")]
		public static readonly BackPressOptions EMPTY;

		// Token: 0x04019BBF RID: 105407
		[Token(Token = "0x4019BBF")]
		[FieldOffset(Offset = "0x0")]
		private bool m_isEmpty;

		// Token: 0x04019BC0 RID: 105408
		[Token(Token = "0x4019BC0")]
		[FieldOffset(Offset = "0x4")]
		public BackPressType type;

		// Token: 0x04019BC1 RID: 105409
		[Token(Token = "0x4019BC1")]
		[FieldOffset(Offset = "0x8")]
		public Func<bool> conditionFunc;

		// Token: 0x04019BC2 RID: 105410
		[Token(Token = "0x4019BC2")]
		[FieldOffset(Offset = "0x10")]
		public bool registerOnEnable;

		// Token: 0x04019BC3 RID: 105411
		[Token(Token = "0x4019BC3")]
		[FieldOffset(Offset = "0x11")]
		public bool interectWithWorldCenter;

		// Token: 0x04019BC4 RID: 105412
		[Token(Token = "0x4019BC4")]
		[FieldOffset(Offset = "0x18")]
		public Action onBackPressed;
	}
}

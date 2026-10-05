using System;
using Il2CppDummyDll;

namespace Vuplex.WebView
{
	// Token: 0x0200003F RID: 63
	[Token(Token = "0x200003F")]
	public class PointerOptions
	{
		// Token: 0x060001FA RID: 506 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60001FA")]
		[Address(RVA = "0x5BBA470", Offset = "0x5BB9070", VA = "0x185BBA470", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x060001FB RID: 507 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001FB")]
		[Address(RVA = "0x1EFABA0", Offset = "0x1EF97A0", VA = "0x181EFABA0")]
		public PointerOptions()
		{
		}

		// Token: 0x040000CA RID: 202
		[Token(Token = "0x40000CA")]
		[FieldOffset(Offset = "0x10")]
		public MouseButton Button;

		// Token: 0x040000CB RID: 203
		[Token(Token = "0x40000CB")]
		[FieldOffset(Offset = "0x14")]
		public int ClickCount;

		// Token: 0x040000CC RID: 204
		[Token(Token = "0x40000CC")]
		[FieldOffset(Offset = "0x18")]
		public bool PreventStealingFocus;
	}
}

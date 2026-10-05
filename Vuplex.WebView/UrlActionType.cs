using System;
using Il2CppDummyDll;

namespace Vuplex.WebView
{
	// Token: 0x0200004C RID: 76
	[Token(Token = "0x200004C")]
	public class UrlActionType
	{
		// Token: 0x06000205 RID: 517 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000205")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public UrlActionType()
		{
		}

		// Token: 0x040000F1 RID: 241
		[Token(Token = "0x40000F1")]
		[FieldOffset(Offset = "0x0")]
		public static readonly string Load;

		// Token: 0x040000F2 RID: 242
		[Token(Token = "0x40000F2")]
		[FieldOffset(Offset = "0x8")]
		public static readonly string PushState;

		// Token: 0x040000F3 RID: 243
		[Token(Token = "0x40000F3")]
		[FieldOffset(Offset = "0x10")]
		public static readonly string ReplaceState;

		// Token: 0x040000F4 RID: 244
		[Token(Token = "0x40000F4")]
		[FieldOffset(Offset = "0x18")]
		public static readonly string HashChange;
	}
}

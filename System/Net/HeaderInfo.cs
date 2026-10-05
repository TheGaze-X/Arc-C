using System;
using Il2CppDummyDll;

namespace System.Net
{
	// Token: 0x020002D0 RID: 720
	[Token(Token = "0x20002D0")]
	internal class HeaderInfo
	{
		// Token: 0x0600140A RID: 5130 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600140A")]
		[Address(RVA = "0x505A100", Offset = "0x5058D00", VA = "0x18505A100")]
		internal HeaderInfo(string name, bool requestRestricted, bool responseRestricted, bool multi, HeaderParser p)
		{
		}

		// Token: 0x04000ACF RID: 2767
		[Token(Token = "0x4000ACF")]
		[FieldOffset(Offset = "0x10")]
		internal readonly bool IsRequestRestricted;

		// Token: 0x04000AD0 RID: 2768
		[Token(Token = "0x4000AD0")]
		[FieldOffset(Offset = "0x11")]
		internal readonly bool IsResponseRestricted;

		// Token: 0x04000AD1 RID: 2769
		[Token(Token = "0x4000AD1")]
		[FieldOffset(Offset = "0x18")]
		internal readonly HeaderParser Parser;

		// Token: 0x04000AD2 RID: 2770
		[Token(Token = "0x4000AD2")]
		[FieldOffset(Offset = "0x20")]
		internal readonly string HeaderName;

		// Token: 0x04000AD3 RID: 2771
		[Token(Token = "0x4000AD3")]
		[FieldOffset(Offset = "0x28")]
		internal readonly bool AllowMultiValues;
	}
}

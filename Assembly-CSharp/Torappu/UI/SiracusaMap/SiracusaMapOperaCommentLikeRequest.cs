using System;
using Il2CppDummyDll;

namespace Torappu.UI.SiracusaMap
{
	// Token: 0x02003F67 RID: 16231
	[Token(Token = "0x2003F67")]
	public class SiracusaMapOperaCommentLikeRequest
	{
		// Token: 0x0601930C RID: 103180 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601930C")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public SiracusaMapOperaCommentLikeRequest()
		{
		}

		// Token: 0x0401F3C2 RID: 127938
		[Token(Token = "0x401F3C2")]
		[FieldOffset(Offset = "0x10")]
		public string groupId;

		// Token: 0x0401F3C3 RID: 127939
		[Token(Token = "0x401F3C3")]
		[FieldOffset(Offset = "0x18")]
		public string operaId;

		// Token: 0x0401F3C4 RID: 127940
		[Token(Token = "0x401F3C4")]
		[FieldOffset(Offset = "0x20")]
		public string commentId;
	}
}

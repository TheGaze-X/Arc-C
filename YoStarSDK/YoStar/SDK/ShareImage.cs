using System;
using Il2CppDummyDll;
using UnityEngine;

namespace YoStar.SDK
{
	// Token: 0x02000074 RID: 116
	[Token(Token = "0x2000074")]
	public class ShareImage : ShareContent
	{
		// Token: 0x0600024E RID: 590 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x600024E")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		private ShareImage()
		{
		}

		// Token: 0x0600024F RID: 591 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x600024F")]
		[Address(RVA = "0x5BE2100", Offset = "0x5BE0D00", VA = "0x185BE2100")]
		public ShareImage(Texture2D image)
		{
		}

		// Token: 0x06000250 RID: 592 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000250")]
		[Address(RVA = "0x4E5A80", Offset = "0x4E4680", VA = "0x1804E5A80")]
		public Texture2D getImage()
		{
			return null;
		}

		// Token: 0x04000208 RID: 520
		[Token(Token = "0x4000208")]
		[FieldOffset(Offset = "0x18")]
		private Texture2D image;
	}
}

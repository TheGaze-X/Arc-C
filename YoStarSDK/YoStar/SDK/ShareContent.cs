using System;
using Il2CppDummyDll;

namespace YoStar.SDK
{
	// Token: 0x02000073 RID: 115
	[Token(Token = "0x2000073")]
	public abstract class ShareContent
	{
		// Token: 0x0600024D RID: 589 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x600024D")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		protected ShareContent()
		{
		}

		// Token: 0x04000205 RID: 517
		[Token(Token = "0x4000205")]
		public const int TYPE_IMAGE = 1;

		// Token: 0x04000206 RID: 518
		[Token(Token = "0x4000206")]
		public const int TYPE_URL = 2;

		// Token: 0x04000207 RID: 519
		[Token(Token = "0x4000207")]
		[FieldOffset(Offset = "0x10")]
		protected int shareType;
	}
}

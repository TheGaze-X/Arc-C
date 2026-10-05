using System;
using Il2CppDummyDll;

namespace UnityEngine.UIElements.StyleSheets
{
	// Token: 0x020002EC RID: 748
	[Token(Token = "0x20002EC")]
	internal struct ImageSource
	{
		// Token: 0x06001482 RID: 5250 RVA: 0x0000ADE8 File Offset: 0x00008FE8
		[Token(Token = "0x6001482")]
		[Address(RVA = "0x5A7B9D0", Offset = "0x5A7A5D0", VA = "0x185A7B9D0")]
		public bool IsNull()
		{
			return default(bool);
		}

		// Token: 0x04000C43 RID: 3139
		[Token(Token = "0x4000C43")]
		[FieldOffset(Offset = "0x0")]
		public Texture2D texture;

		// Token: 0x04000C44 RID: 3140
		[Token(Token = "0x4000C44")]
		[FieldOffset(Offset = "0x8")]
		public Sprite sprite;

		// Token: 0x04000C45 RID: 3141
		[Token(Token = "0x4000C45")]
		[FieldOffset(Offset = "0x10")]
		public VectorImage vectorImage;

		// Token: 0x04000C46 RID: 3142
		[Token(Token = "0x4000C46")]
		[FieldOffset(Offset = "0x18")]
		public RenderTexture renderTexture;
	}
}

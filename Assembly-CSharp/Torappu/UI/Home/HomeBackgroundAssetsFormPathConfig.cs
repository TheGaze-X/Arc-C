using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Torappu.UI.Home
{
	// Token: 0x02004BFF RID: 19455
	[Token(Token = "0x2004BFF")]
	[Serializable]
	public struct HomeBackgroundAssetsFormPathConfig : IHotfixable
	{
		// Token: 0x04026682 RID: 157314
		[Token(Token = "0x4026682")]
		[FieldOffset(Offset = "0x0")]
		public string formId;

		// Token: 0x04026683 RID: 157315
		[Token(Token = "0x4026683")]
		[FieldOffset(Offset = "0x8")]
		public string pathImgBgLeft;

		// Token: 0x04026684 RID: 157316
		[Token(Token = "0x4026684")]
		[FieldOffset(Offset = "0x10")]
		public string pathImgBgRight;

		// Token: 0x04026685 RID: 157317
		[Token(Token = "0x4026685")]
		[FieldOffset(Offset = "0x18")]
		public string pathCompress;

		// Token: 0x04026686 RID: 157318
		[Token(Token = "0x4026686")]
		[FieldOffset(Offset = "0x20")]
		public string pathPlayerPic;

		// Token: 0x04026687 RID: 157319
		[Token(Token = "0x4026687")]
		[FieldOffset(Offset = "0x0")]
		[HideInInspector]
		public static readonly HomeBackgroundAssetsFormPathConfig EMPTY;
	}
}

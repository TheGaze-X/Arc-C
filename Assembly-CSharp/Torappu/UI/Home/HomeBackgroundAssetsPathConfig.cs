using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace Torappu.UI.Home
{
	// Token: 0x02004C00 RID: 19456
	[Token(Token = "0x2004C00")]
	[Serializable]
	public struct HomeBackgroundAssetsPathConfig : IHotfixable
	{
		// Token: 0x04026688 RID: 157320
		[Token(Token = "0x4026688")]
		[FieldOffset(Offset = "0x0")]
		public string pathPlayerView;

		// Token: 0x04026689 RID: 157321
		[Token(Token = "0x4026689")]
		[FieldOffset(Offset = "0x8")]
		public string pathEffectCamera;

		// Token: 0x0402668A RID: 157322
		[Token(Token = "0x402668A")]
		[FieldOffset(Offset = "0x10")]
		public string pathEffectFront;

		// Token: 0x0402668B RID: 157323
		[Token(Token = "0x402668B")]
		[FieldOffset(Offset = "0x18")]
		public string pathEffectBg;

		// Token: 0x0402668C RID: 157324
		[Token(Token = "0x402668C")]
		[FieldOffset(Offset = "0x20")]
		public bool isMultiForm;

		// Token: 0x0402668D RID: 157325
		[Token(Token = "0x402668D")]
		[FieldOffset(Offset = "0x28")]
		public List<HomeBackgroundAssetsFormPathConfig> formConfigs;

		// Token: 0x0402668E RID: 157326
		[Token(Token = "0x402668E")]
		[FieldOffset(Offset = "0x0")]
		[HideInInspector]
		public static readonly HomeBackgroundAssetsPathConfig EMPTY;
	}
}

using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Torappu.UI.Home
{
	// Token: 0x02004C02 RID: 19458
	[Token(Token = "0x2004C02")]
	[Serializable]
	public class BackgroundFormAssetWrapper
	{
		// Token: 0x0601D3B5 RID: 119733 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D3B5")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public BackgroundFormAssetWrapper()
		{
		}

		// Token: 0x04026692 RID: 157330
		[Token(Token = "0x4026692")]
		[FieldOffset(Offset = "0x10")]
		public string bgFormId;

		// Token: 0x04026693 RID: 157331
		[Token(Token = "0x4026693")]
		[FieldOffset(Offset = "0x18")]
		public Sprite imgLeft;

		// Token: 0x04026694 RID: 157332
		[Token(Token = "0x4026694")]
		[FieldOffset(Offset = "0x20")]
		public Sprite imgRight;

		// Token: 0x04026695 RID: 157333
		[Token(Token = "0x4026695")]
		[FieldOffset(Offset = "0x28")]
		public Sprite imgCompress;
	}
}

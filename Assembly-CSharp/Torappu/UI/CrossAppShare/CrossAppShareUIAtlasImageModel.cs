using System;
using Il2CppDummyDll;
using Torappu.UI.Atlas;
using UnityEngine;
using XLua;

namespace Torappu.UI.CrossAppShare
{
	// Token: 0x020058C7 RID: 22727
	[Token(Token = "0x20058C7")]
	public class CrossAppShareUIAtlasImageModel : CrossAppShareComponentBaseModel
	{
		// Token: 0x06021290 RID: 135824 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021290")]
		[Address(RVA = "0x1B79820", Offset = "0x1B78420", VA = "0x181B79820")]
		public void InitModel(UIAtlasImage iAtlasImage)
		{
		}

		// Token: 0x06021291 RID: 135825 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021291")]
		[Address(RVA = "0x1B79970", Offset = "0x1B78570", VA = "0x181B79970")]
		public CrossAppShareUIAtlasImageModel()
		{
		}

		// Token: 0x0402D29D RID: 184989
		[Token(Token = "0x402D29D")]
		[FieldOffset(Offset = "0x18")]
		public SpriteRenderData atlasImageRd;

		// Token: 0x0402D29E RID: 184990
		[Token(Token = "0x402D29E")]
		[FieldOffset(Offset = "0x58")]
		public Color color;

		// Token: 0x0402D29F RID: 184991
		[Token(Token = "0x402D29F")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_InitModel;

		// Token: 0x0402D2A0 RID: 184992
		[Token(Token = "0x402D2A0")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}

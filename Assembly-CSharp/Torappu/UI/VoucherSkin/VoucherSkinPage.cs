using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.VoucherSkin
{
	// Token: 0x02003B95 RID: 15253
	[Token(Token = "0x2003B95")]
	public class VoucherSkinPage : StateEnginePage, IFadeInPushWithBlurBkg, IHotfixable
	{
		// Token: 0x06017E5D RID: 97885 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017E5D")]
		[Address(RVA = "0x1027200", Offset = "0x1025E00", VA = "0x181027200")]
		public static void Open(VoucherSkinPage.Params param)
		{
		}

		// Token: 0x06017E5E RID: 97886 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6017E5E")]
		[Address(RVA = "0x10271A0", Offset = "0x1025DA0", VA = "0x1810271A0", Slot = "29")]
		public UIRenderTextureImage GetBlurBkg()
		{
			return null;
		}

		// Token: 0x06017E5F RID: 97887 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017E5F")]
		[Address(RVA = "0x10272B0", Offset = "0x1025EB0", VA = "0x1810272B0")]
		public VoucherSkinPage()
		{
		}

		// Token: 0x0401CE5F RID: 118367
		[Token(Token = "0x401CE5F")]
		[FieldOffset(Offset = "0xF0")]
		[SerializeField]
		private UIRenderTextureImage _imageBlurBkg;

		// Token: 0x0401CE60 RID: 118368
		[Token(Token = "0x401CE60")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Open;

		// Token: 0x0401CE61 RID: 118369
		[Token(Token = "0x401CE61")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_GetBlurBkg;

		// Token: 0x0401CE62 RID: 118370
		[Token(Token = "0x401CE62")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02003B96 RID: 15254
		[Token(Token = "0x2003B96")]
		public enum VoucherSkinType
		{
			// Token: 0x0401CE64 RID: 118372
			[Token(Token = "0x401CE64")]
			NOTVOUCHER,
			// Token: 0x0401CE65 RID: 118373
			[Token(Token = "0x401CE65")]
			EXCHANGE,
			// Token: 0x0401CE66 RID: 118374
			[Token(Token = "0x401CE66")]
			PREVIEW
		}

		// Token: 0x02003B97 RID: 15255
		[Token(Token = "0x2003B97")]
		public class Params
		{
			// Token: 0x06017E60 RID: 97888 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6017E60")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public Params()
			{
			}

			// Token: 0x0401CE67 RID: 118375
			[Token(Token = "0x401CE67")]
			[FieldOffset(Offset = "0x10")]
			public string itemId;

			// Token: 0x0401CE68 RID: 118376
			[Token(Token = "0x401CE68")]
			[FieldOffset(Offset = "0x18")]
			public int itemInstId;

			// Token: 0x0401CE69 RID: 118377
			[Token(Token = "0x401CE69")]
			[FieldOffset(Offset = "0x20")]
			public string ruleDesc;

			// Token: 0x0401CE6A RID: 118378
			[Token(Token = "0x401CE6A")]
			[FieldOffset(Offset = "0x28")]
			public List<VoucherSkinItemViewModel> skinItems;

			// Token: 0x0401CE6B RID: 118379
			[Token(Token = "0x401CE6B")]
			[FieldOffset(Offset = "0x30")]
			public bool isPreview;
		}
	}
}

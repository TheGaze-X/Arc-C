using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.AVG.Holders
{
	// Token: 0x02001F97 RID: 8087
	[Token(Token = "0x2001F97")]
	public class AVGDisplayableImageHolder : AVGDisplayableHolder, AVGDisplayableHolder.IFadeFeature, AVGDisplayableHolder.IFeature, IHotfixable
	{
		// Token: 0x170017CD RID: 6093
		// (get) Token: 0x0600C8F0 RID: 51440 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170017CD")]
		public CanvasGroup contentGroup
		{
			[Token(Token = "0x600C8F0")]
			[Address(RVA = "0x348CA00", Offset = "0x348B600", VA = "0x18348CA00", Slot = "6")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600C8F1 RID: 51441 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600C8F1")]
		[Address(RVA = "0x348C6F0", Offset = "0x348B2F0", VA = "0x18348C6F0", Slot = "5")]
		public override GameObject GenerateContent(AVGDisplayableHolder.AVGDisplayParam param)
		{
			return null;
		}

		// Token: 0x0600C8F2 RID: 51442 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C8F2")]
		[Address(RVA = "0x348C9A0", Offset = "0x348B5A0", VA = "0x18348C9A0")]
		public AVGDisplayableImageHolder()
		{
		}

		// Token: 0x0400CF7C RID: 53116
		[Token(Token = "0x400CF7C")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Image _image;

		// Token: 0x0400CF7D RID: 53117
		[Token(Token = "0x400CF7D")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Canvas _canvas;

		// Token: 0x0400CF7E RID: 53118
		[Token(Token = "0x400CF7E")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private CanvasGroup _group;

		// Token: 0x0400CF7F RID: 53119
		[Token(Token = "0x400CF7F")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_contentGroup;

		// Token: 0x0400CF80 RID: 53120
		[Token(Token = "0x400CF80")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_GenerateContent;

		// Token: 0x0400CF81 RID: 53121
		[Token(Token = "0x400CF81")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}

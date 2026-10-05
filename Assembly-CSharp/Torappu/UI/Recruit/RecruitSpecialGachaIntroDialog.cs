using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Recruit
{
	// Token: 0x02004717 RID: 18199
	[Token(Token = "0x2004717")]
	public class RecruitSpecialGachaIntroDialog : UICompDialog<RecruitSpecialGachaIntroDialog.Options>, IHotfixable
	{
		// Token: 0x0601B961 RID: 112993 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601B961")]
		[Address(RVA = "0x14E72C0", Offset = "0x14E5EC0", VA = "0x1814E72C0", Slot = "15")]
		protected override UIRenderTextureImage GetBlurTarget()
		{
			return null;
		}

		// Token: 0x0601B962 RID: 112994 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B962")]
		[Address(RVA = "0x14E7320", Offset = "0x14E5F20", VA = "0x1814E7320", Slot = "9")]
		protected override void OnInit()
		{
		}

		// Token: 0x0601B963 RID: 112995 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B963")]
		[Address(RVA = "0x14E7430", Offset = "0x14E6030", VA = "0x1814E7430", Slot = "18")]
		protected override void OnRender(RecruitSpecialGachaIntroDialog.Options input)
		{
		}

		// Token: 0x0601B964 RID: 112996 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B964")]
		[Address(RVA = "0x14E7200", Offset = "0x14E5E00", VA = "0x1814E7200")]
		public void EventOnBackBtnClicked()
		{
		}

		// Token: 0x0601B965 RID: 112997 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B965")]
		[Address(RVA = "0x14E7580", Offset = "0x14E6180", VA = "0x1814E7580")]
		public RecruitSpecialGachaIntroDialog()
		{
		}

		// Token: 0x0601B966 RID: 112998 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601B966")]
		[Address(RVA = "0xE613B0", Offset = "0xE5FFB0", VA = "0x180E613B0")]
		private UIRenderTextureImage <>xLuaBaseProxy_GetBlurTarget()
		{
			return null;
		}

		// Token: 0x0601B967 RID: 112999 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B967")]
		[Address(RVA = "0xE613C0", Offset = "0xE5FFC0", VA = "0x180E613C0")]
		private void <>xLuaBaseProxy_OnInit()
		{
		}

		// Token: 0x04023BCA RID: 146378
		[Token(Token = "0x4023BCA")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private UIRenderTextureImage _blurBkg;

		// Token: 0x04023BCB RID: 146379
		[Token(Token = "0x4023BCB")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private Text _textTitle;

		// Token: 0x04023BCC RID: 146380
		[Token(Token = "0x4023BCC")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private Text _textInfo;

		// Token: 0x04023BCD RID: 146381
		[Token(Token = "0x4023BCD")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		private Image _bkgTitle;

		// Token: 0x04023BCE RID: 146382
		[Token(Token = "0x4023BCE")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		private RectTransform _backRt;

		// Token: 0x04023BCF RID: 146383
		[Token(Token = "0x4023BCF")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetBlurTarget;

		// Token: 0x04023BD0 RID: 146384
		[Token(Token = "0x4023BD0")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnInit;

		// Token: 0x04023BD1 RID: 146385
		[Token(Token = "0x4023BD1")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnRender;

		// Token: 0x04023BD2 RID: 146386
		[Token(Token = "0x4023BD2")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_EventOnBackBtnClicked;

		// Token: 0x04023BD3 RID: 146387
		[Token(Token = "0x4023BD3")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02004718 RID: 18200
		[Token(Token = "0x2004718")]
		public class Options
		{
			// Token: 0x0601B968 RID: 113000 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601B968")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public Options()
			{
			}

			// Token: 0x04023BD4 RID: 146388
			[Token(Token = "0x4023BD4")]
			[FieldOffset(Offset = "0x10")]
			public string detailTitle;

			// Token: 0x04023BD5 RID: 146389
			[Token(Token = "0x4023BD5")]
			[FieldOffset(Offset = "0x18")]
			public string detailInfo;

			// Token: 0x04023BD6 RID: 146390
			[Token(Token = "0x4023BD6")]
			[FieldOffset(Offset = "0x20")]
			public Color colorTheme;
		}
	}
}

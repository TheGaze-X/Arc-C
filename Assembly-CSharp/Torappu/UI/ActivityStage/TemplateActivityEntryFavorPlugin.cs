using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.ActivityStage
{
	// Token: 0x02006C83 RID: 27779
	[Token(Token = "0x2006C83")]
	public class TemplateActivityEntryFavorPlugin : TemplateActivityCommonPlugin
	{
		// Token: 0x06027A3A RID: 162362 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027A3A")]
		[Address(RVA = "0x22CC4F0", Offset = "0x22CB0F0", VA = "0x1822CC4F0", Slot = "5")]
		public override void OnViewModelRefresh(TemplateActivityViewModel viewModel)
		{
		}

		// Token: 0x06027A3B RID: 162363 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027A3B")]
		[Address(RVA = "0x22CC430", Offset = "0x22CB030", VA = "0x1822CC430")]
		public void OnFavorClick()
		{
		}

		// Token: 0x06027A3C RID: 162364 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027A3C")]
		[Address(RVA = "0x22CC730", Offset = "0x22CB330", VA = "0x1822CC730")]
		public TemplateActivityEntryFavorPlugin()
		{
		}

		// Token: 0x04038380 RID: 230272
		[Token(Token = "0x4038380")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private UICommonTrackPoint _trackPoint;

		// Token: 0x04038381 RID: 230273
		[Token(Token = "0x4038381")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private GameObject _favorItem;

		// Token: 0x04038382 RID: 230274
		[Token(Token = "0x4038382")]
		[FieldOffset(Offset = "0x38")]
		private TemplateActivityFavorViewModel m_cacheViewModel;

		// Token: 0x04038383 RID: 230275
		[Token(Token = "0x4038383")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnViewModelRefresh;

		// Token: 0x04038384 RID: 230276
		[Token(Token = "0x4038384")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnFavorClick;

		// Token: 0x04038385 RID: 230277
		[Token(Token = "0x4038385")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}

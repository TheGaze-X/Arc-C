using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.ActivityStage
{
	// Token: 0x02006C78 RID: 27768
	[Token(Token = "0x2006C78")]
	public class TemplateActivityEntryCGGalleryPlugin : TemplateActivityCommonPlugin
	{
		// Token: 0x06027A1D RID: 162333 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027A1D")]
		[Address(RVA = "0x22CB810", Offset = "0x22CA410", VA = "0x1822CB810", Slot = "5")]
		public override void OnViewModelRefresh(TemplateActivityViewModel raw)
		{
		}

		// Token: 0x06027A1E RID: 162334 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027A1E")]
		[Address(RVA = "0x22CB640", Offset = "0x22CA240", VA = "0x1822CB640")]
		public void OnEntryClick()
		{
		}

		// Token: 0x06027A1F RID: 162335 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027A1F")]
		[Address(RVA = "0x22CB930", Offset = "0x22CA530", VA = "0x1822CB930")]
		public TemplateActivityEntryCGGalleryPlugin()
		{
		}

		// Token: 0x0403834D RID: 230221
		[Token(Token = "0x403834D")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private GameObject _lockedVariant;

		// Token: 0x0403834E RID: 230222
		[Token(Token = "0x403834E")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private GameObject _unlockedVariant;

		// Token: 0x0403834F RID: 230223
		[Token(Token = "0x403834F")]
		[FieldOffset(Offset = "0x38")]
		private TemplateActivityCGGalleryViewModel m_cachedModel;

		// Token: 0x04038350 RID: 230224
		[Token(Token = "0x4038350")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnViewModelRefresh;

		// Token: 0x04038351 RID: 230225
		[Token(Token = "0x4038351")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnEntryClick;

		// Token: 0x04038352 RID: 230226
		[Token(Token = "0x4038352")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}

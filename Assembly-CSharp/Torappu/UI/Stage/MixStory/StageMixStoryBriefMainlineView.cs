using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Stage.MixStory
{
	// Token: 0x02006A84 RID: 27268
	[Token(Token = "0x2006A84")]
	public class StageMixStoryBriefMainlineView : MonoBehaviour, IHotfixable
	{
		// Token: 0x0602703D RID: 159805 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602703D")]
		[Address(RVA = "0x223C8E0", Offset = "0x223B4E0", VA = "0x18223C8E0")]
		public void ToZoneMapEvent()
		{
		}

		// Token: 0x0602703E RID: 159806 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602703E")]
		[Address(RVA = "0x223C7C0", Offset = "0x223B3C0", VA = "0x18223C7C0")]
		public void Render(StageStorylineMainlineViewModel model)
		{
		}

		// Token: 0x0602703F RID: 159807 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602703F")]
		[Address(RVA = "0x223C750", Offset = "0x223B350", VA = "0x18223C750")]
		public void ClearCache()
		{
		}

		// Token: 0x06027040 RID: 159808 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027040")]
		[Address(RVA = "0x223C980", Offset = "0x223B580", VA = "0x18223C980")]
		public StageMixStoryBriefMainlineView()
		{
		}

		// Token: 0x040372FB RID: 226043
		[Token(Token = "0x40372FB")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private StageMixStoryBriefTagView _tagView;

		// Token: 0x040372FC RID: 226044
		[Token(Token = "0x40372FC")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Text _descText;

		// Token: 0x040372FD RID: 226045
		[Token(Token = "0x40372FD")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private ScrollRect _descScrollRect;

		// Token: 0x040372FE RID: 226046
		[Token(Token = "0x40372FE")]
		[FieldOffset(Offset = "0x30")]
		private UIStateFinder m_finder;

		// Token: 0x040372FF RID: 226047
		[Token(Token = "0x40372FF")]
		[FieldOffset(Offset = "0x40")]
		private StageStorylineMainlineViewModel m_cachedModel;

		// Token: 0x04037300 RID: 226048
		[Token(Token = "0x4037300")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_ToZoneMapEvent;

		// Token: 0x04037301 RID: 226049
		[Token(Token = "0x4037301")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x04037302 RID: 226050
		[Token(Token = "0x4037302")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_ClearCache;

		// Token: 0x04037303 RID: 226051
		[Token(Token = "0x4037303")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}

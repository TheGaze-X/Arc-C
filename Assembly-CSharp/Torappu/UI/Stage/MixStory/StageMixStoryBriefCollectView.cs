using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Stage.MixStory
{
	// Token: 0x02006A80 RID: 27264
	[Token(Token = "0x2006A80")]
	public class StageMixStoryBriefCollectView : MonoBehaviour, IHotfixable
	{
		// Token: 0x06027024 RID: 159780 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027024")]
		[Address(RVA = "0x223BB00", Offset = "0x223A700", VA = "0x18223BB00")]
		public void ToStoriesEvent()
		{
		}

		// Token: 0x06027025 RID: 159781 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027025")]
		[Address(RVA = "0x223BA60", Offset = "0x223A660", VA = "0x18223BA60")]
		public void ToRetroTrailEvent()
		{
		}

		// Token: 0x06027026 RID: 159782 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027026")]
		[Address(RVA = "0x223B7F0", Offset = "0x223A3F0", VA = "0x18223B7F0")]
		public void ClearCache()
		{
		}

		// Token: 0x06027027 RID: 159783 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027027")]
		[Address(RVA = "0x223B860", Offset = "0x223A460", VA = "0x18223B860")]
		public void Render(StageStorylineCollectViewModel model)
		{
		}

		// Token: 0x06027028 RID: 159784 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027028")]
		[Address(RVA = "0x223BB90", Offset = "0x223A790", VA = "0x18223BB90")]
		public StageMixStoryBriefCollectView()
		{
		}

		// Token: 0x040372C9 RID: 225993
		[Token(Token = "0x40372C9")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Text _descText;

		// Token: 0x040372CA RID: 225994
		[Token(Token = "0x40372CA")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private ScrollRect _descScrollRect;

		// Token: 0x040372CB RID: 225995
		[Token(Token = "0x40372CB")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private GameObject _retroTrailPart;

		// Token: 0x040372CC RID: 225996
		[Token(Token = "0x40372CC")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Transform _trackPointHolder;

		// Token: 0x040372CD RID: 225997
		[Token(Token = "0x40372CD")]
		[FieldOffset(Offset = "0x38")]
		private UIStateFinder m_finder;

		// Token: 0x040372CE RID: 225998
		[Token(Token = "0x40372CE")]
		[FieldOffset(Offset = "0x48")]
		private StageStorylineCollectViewModel m_cachedModel;

		// Token: 0x040372CF RID: 225999
		[Token(Token = "0x40372CF")]
		[FieldOffset(Offset = "0x50")]
		private GameObject m_trackPointInstance;

		// Token: 0x040372D0 RID: 226000
		[Token(Token = "0x40372D0")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_ToStoriesEvent;

		// Token: 0x040372D1 RID: 226001
		[Token(Token = "0x40372D1")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_ToRetroTrailEvent;

		// Token: 0x040372D2 RID: 226002
		[Token(Token = "0x40372D2")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_ClearCache;

		// Token: 0x040372D3 RID: 226003
		[Token(Token = "0x40372D3")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x040372D4 RID: 226004
		[Token(Token = "0x40372D4")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}

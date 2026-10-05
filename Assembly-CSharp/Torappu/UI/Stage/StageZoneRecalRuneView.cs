using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Stage
{
	// Token: 0x0200693F RID: 26943
	[Token(Token = "0x200693F")]
	public class StageZoneRecalRuneView : StageZoneSeasonEntryItem<RecalRuneEntryModel>
	{
		// Token: 0x06026946 RID: 158022 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026946")]
		[Address(RVA = "0x21B8DE0", Offset = "0x21B79E0", VA = "0x1821B8DE0", Slot = "4")]
		public override void Render(RecalRuneEntryModel entryModel)
		{
		}

		// Token: 0x06026947 RID: 158023 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026947")]
		[Address(RVA = "0x21B8B20", Offset = "0x21B7720", VA = "0x1821B8B20")]
		public void EventOnEntryBtnClicked()
		{
		}

		// Token: 0x06026948 RID: 158024 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026948")]
		[Address(RVA = "0x21B8C80", Offset = "0x21B7880", VA = "0x1821B8C80")]
		public void EventOnSeasonClicked()
		{
		}

		// Token: 0x06026949 RID: 158025 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026949")]
		[Address(RVA = "0x21B9010", Offset = "0x21B7C10", VA = "0x1821B9010")]
		public StageZoneRecalRuneView()
		{
		}

		// Token: 0x040366CB RID: 222923
		[Token(Token = "0x40366CB")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private TwoStateToggle _unlockToggle;

		// Token: 0x040366CC RID: 222924
		[Token(Token = "0x40366CC")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Text _seasonCode;

		// Token: 0x040366CD RID: 222925
		[Token(Token = "0x40366CD")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private GameObject _medalBg;

		// Token: 0x040366CE RID: 222926
		[Token(Token = "0x40366CE")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Image _medal;

		// Token: 0x040366CF RID: 222927
		[Token(Token = "0x40366CF")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private TwoStateToggle _trackToggle;

		// Token: 0x040366D0 RID: 222928
		[Token(Token = "0x40366D0")]
		[FieldOffset(Offset = "0x40")]
		private UIPageFinder m_finder;

		// Token: 0x040366D1 RID: 222929
		[Token(Token = "0x40366D1")]
		[FieldOffset(Offset = "0x50")]
		private string m_cachedSeasonId;

		// Token: 0x040366D2 RID: 222930
		[Token(Token = "0x40366D2")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x040366D3 RID: 222931
		[Token(Token = "0x40366D3")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_EventOnEntryBtnClicked;

		// Token: 0x040366D4 RID: 222932
		[Token(Token = "0x40366D4")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_EventOnSeasonClicked;

		// Token: 0x040366D5 RID: 222933
		[Token(Token = "0x40366D5")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}

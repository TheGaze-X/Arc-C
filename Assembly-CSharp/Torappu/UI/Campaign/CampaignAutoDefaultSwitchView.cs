using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.Campaign
{
	// Token: 0x02006116 RID: 24854
	[Token(Token = "0x2006116")]
	public class CampaignAutoDefaultSwitchView : MonoBehaviour, ICampaignAutoSwitchView, IHotfixable
	{
		// Token: 0x06023E71 RID: 147057 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023E71")]
		[Address(RVA = "0x1E83400", Offset = "0x1E82000", VA = "0x181E83400", Slot = "4")]
		public void UpdateView(AutoCampConfigModel viewModel)
		{
		}

		// Token: 0x06023E72 RID: 147058 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023E72")]
		[Address(RVA = "0x1E832E0", Offset = "0x1E81EE0", VA = "0x181E832E0")]
		public void EventOnAutoBattleClicked()
		{
		}

		// Token: 0x06023E73 RID: 147059 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023E73")]
		[Address(RVA = "0x1E83370", Offset = "0x1E81F70", VA = "0x181E83370")]
		public void EventOnFastBattleClicked()
		{
		}

		// Token: 0x06023E74 RID: 147060 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023E74")]
		[Address(RVA = "0x1E834D0", Offset = "0x1E820D0", VA = "0x181E834D0")]
		public CampaignAutoDefaultSwitchView()
		{
		}

		// Token: 0x04031D24 RID: 204068
		[Token(Token = "0x4031D24")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private GameObject _panelLocked;

		// Token: 0x04031D25 RID: 204069
		[Token(Token = "0x4031D25")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GameObject _panelUnlock;

		// Token: 0x04031D26 RID: 204070
		[Token(Token = "0x4031D26")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private GameObject _panelFastBattle;

		// Token: 0x04031D27 RID: 204071
		[Token(Token = "0x4031D27")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private TwoStateToggle _toggle;

		// Token: 0x04031D28 RID: 204072
		[Token(Token = "0x4031D28")]
		[FieldOffset(Offset = "0x38")]
		private UIStateFinder m_stateFinder;

		// Token: 0x04031D29 RID: 204073
		[Token(Token = "0x4031D29")]
		[FieldOffset(Offset = "0x48")]
		private AutoCampConfigModel.AutoBattleOnly m_model;

		// Token: 0x04031D2A RID: 204074
		[Token(Token = "0x4031D2A")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_UpdateView;

		// Token: 0x04031D2B RID: 204075
		[Token(Token = "0x4031D2B")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_EventOnAutoBattleClicked;

		// Token: 0x04031D2C RID: 204076
		[Token(Token = "0x4031D2C")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_EventOnFastBattleClicked;

		// Token: 0x04031D2D RID: 204077
		[Token(Token = "0x4031D2D")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}

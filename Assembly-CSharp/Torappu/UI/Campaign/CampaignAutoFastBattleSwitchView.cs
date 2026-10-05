using System;
using AdvancedInspector;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.Campaign
{
	// Token: 0x02006117 RID: 24855
	[Token(Token = "0x2006117")]
	public class CampaignAutoFastBattleSwitchView : MonoBehaviour, ICampaignAutoSwitchView, IHotfixable
	{
		// Token: 0x06023E75 RID: 147061 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023E75")]
		[Address(RVA = "0x1E83650", Offset = "0x1E82250", VA = "0x181E83650", Slot = "4")]
		public void UpdateView(AutoCampConfigModel viewModel)
		{
		}

		// Token: 0x06023E76 RID: 147062 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023E76")]
		[Address(RVA = "0x1E83B20", Offset = "0x1E82720", VA = "0x181E83B20")]
		private void _TryRaiseAVGSignalAndRegisterObjs()
		{
		}

		// Token: 0x06023E77 RID: 147063 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023E77")]
		[Address(RVA = "0x1E83A20", Offset = "0x1E82620", VA = "0x181E83A20")]
		private void _InitIfNot()
		{
		}

		// Token: 0x06023E78 RID: 147064 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023E78")]
		[Address(RVA = "0x1E83530", Offset = "0x1E82130", VA = "0x181E83530")]
		public void EventOnAutoBattleClicked()
		{
		}

		// Token: 0x06023E79 RID: 147065 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023E79")]
		[Address(RVA = "0x1E835C0", Offset = "0x1E821C0", VA = "0x181E835C0")]
		public void EventOnFastBattleClicked()
		{
		}

		// Token: 0x06023E7A RID: 147066 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023E7A")]
		[Address(RVA = "0x1E83C80", Offset = "0x1E82880", VA = "0x181E83C80")]
		public CampaignAutoFastBattleSwitchView()
		{
		}

		// Token: 0x04031D2E RID: 204078
		[Token(Token = "0x4031D2E")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private UIAnimationLocation _animFastOn;

		// Token: 0x04031D2F RID: 204079
		[Token(Token = "0x4031D2F")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private TwoStateToggle _toggleAutoBattle;

		// Token: 0x04031D30 RID: 204080
		[Token(Token = "0x4031D30")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		[Group("AVG Trace")]
		private GameObject _storyBtnFastBtl;

		// Token: 0x04031D31 RID: 204081
		[Token(Token = "0x4031D31")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		[Group("AVG Trace")]
		private GameObject _storyAreaSwitch;

		// Token: 0x04031D32 RID: 204082
		[Token(Token = "0x4031D32")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		[Group("AVG Trace")]
		private GameObject _storyAreaStartBtl;

		// Token: 0x04031D33 RID: 204083
		[Token(Token = "0x4031D33")]
		[FieldOffset(Offset = "0x48")]
		private UIStateFinder m_stateFinder;

		// Token: 0x04031D34 RID: 204084
		[Token(Token = "0x4031D34")]
		[FieldOffset(Offset = "0x58")]
		private bool m_isInited;

		// Token: 0x04031D35 RID: 204085
		[Token(Token = "0x4031D35")]
		[FieldOffset(Offset = "0x5C")]
		private AutoCampConfigModel.EnableFastBattle m_model;

		// Token: 0x04031D36 RID: 204086
		[Token(Token = "0x4031D36")]
		[FieldOffset(Offset = "0x60")]
		private AnimationSwitchTween m_fastSwitch;

		// Token: 0x04031D37 RID: 204087
		[Token(Token = "0x4031D37")]
		[FieldOffset(Offset = "0x68")]
		private string m_lastStageId;

		// Token: 0x04031D38 RID: 204088
		[Token(Token = "0x4031D38")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_UpdateView;

		// Token: 0x04031D39 RID: 204089
		[Token(Token = "0x4031D39")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__TryRaiseAVGSignalAndRegisterObjs;

		// Token: 0x04031D3A RID: 204090
		[Token(Token = "0x4031D3A")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x04031D3B RID: 204091
		[Token(Token = "0x4031D3B")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_EventOnAutoBattleClicked;

		// Token: 0x04031D3C RID: 204092
		[Token(Token = "0x4031D3C")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_EventOnFastBattleClicked;

		// Token: 0x04031D3D RID: 204093
		[Token(Token = "0x4031D3D")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}

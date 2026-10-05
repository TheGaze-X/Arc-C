using System;
using Il2CppDummyDll;
using Torappu.UI;
using Torappu.UI.ActivityStage;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Activity.Act1BossRush
{
	// Token: 0x020070B2 RID: 28850
	[Token(Token = "0x20070B2")]
	public class Act1BossRushEntryMileStonePlugin : TemplateActivityCommonPlugin
	{
		// Token: 0x06029032 RID: 167986 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029032")]
		[Address(RVA = "0x2466300", Offset = "0x2464F00", VA = "0x182466300", Slot = "5")]
		public override void OnViewModelRefresh(TemplateActivityViewModel viewModel)
		{
		}

		// Token: 0x06029033 RID: 167987 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029033")]
		[Address(RVA = "0x24667F0", Offset = "0x24653F0", VA = "0x1824667F0")]
		public void OpenMilestone()
		{
		}

		// Token: 0x06029034 RID: 167988 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029034")]
		[Address(RVA = "0x24668B0", Offset = "0x24654B0", VA = "0x1824668B0")]
		private void _InitIfNot()
		{
		}

		// Token: 0x06029035 RID: 167989 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029035")]
		[Address(RVA = "0x2466990", Offset = "0x2465590", VA = "0x182466990")]
		public Act1BossRushEntryMileStonePlugin()
		{
		}

		// Token: 0x0403A89D RID: 239773
		[Token(Token = "0x403A89D")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private UICommonTrackPoint _newMileStoneTrackPoint;

		// Token: 0x0403A89E RID: 239774
		[Token(Token = "0x403A89E")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Slider _mileStoneProgress;

		// Token: 0x0403A89F RID: 239775
		[Token(Token = "0x403A89F")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Text _txtMileStoneLv;

		// Token: 0x0403A8A0 RID: 239776
		[Token(Token = "0x403A8A0")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private GameObject _objMileStoneProgressing;

		// Token: 0x0403A8A1 RID: 239777
		[Token(Token = "0x403A8A1")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private Text _textMileStoneExp;

		// Token: 0x0403A8A2 RID: 239778
		[Token(Token = "0x403A8A2")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private GameObject _objMileStoneMax;

		// Token: 0x0403A8A3 RID: 239779
		[Token(Token = "0x403A8A3")]
		[FieldOffset(Offset = "0x58")]
		private bool m_isInited;

		// Token: 0x0403A8A4 RID: 239780
		[Token(Token = "0x403A8A4")]
		[FieldOffset(Offset = "0x60")]
		private string m_actId;

		// Token: 0x0403A8A5 RID: 239781
		[Token(Token = "0x403A8A5")]
		[FieldOffset(Offset = "0x68")]
		private TrackPointViewProperty m_milestoneTrackProperty;

		// Token: 0x0403A8A6 RID: 239782
		[Token(Token = "0x403A8A6")]
		private const string MILESTONE_PROCESS = "<color=#FFA200>{0}</color><color=#FFFFFF>/{1}</color>";

		// Token: 0x0403A8A7 RID: 239783
		[Token(Token = "0x403A8A7")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnViewModelRefresh;

		// Token: 0x0403A8A8 RID: 239784
		[Token(Token = "0x403A8A8")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OpenMilestone;

		// Token: 0x0403A8A9 RID: 239785
		[Token(Token = "0x403A8A9")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0403A8AA RID: 239786
		[Token(Token = "0x403A8AA")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}

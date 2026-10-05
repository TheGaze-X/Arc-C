using System;
using Il2CppDummyDll;
using Torappu.UI;
using Torappu.UI.ActivityStage;
using UnityEngine;
using XLua;

namespace Torappu.Activity.Act1BossRush
{
	// Token: 0x020070B5 RID: 28853
	[Token(Token = "0x20070B5")]
	public class Act1BossRushEntryMissionButtonPlugin : TemplateActivityCommonPlugin
	{
		// Token: 0x0602903A RID: 167994 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602903A")]
		[Address(RVA = "0x24669F0", Offset = "0x24655F0", VA = "0x1824669F0", Slot = "5")]
		public override void OnViewModelRefresh(TemplateActivityViewModel viewModel)
		{
		}

		// Token: 0x0602903B RID: 167995 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602903B")]
		[Address(RVA = "0x2466C20", Offset = "0x2465820", VA = "0x182466C20")]
		public void OpenMission()
		{
		}

		// Token: 0x0602903C RID: 167996 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602903C")]
		[Address(RVA = "0x2466CE0", Offset = "0x24658E0", VA = "0x182466CE0")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0602903D RID: 167997 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602903D")]
		[Address(RVA = "0x2466DC0", Offset = "0x24659C0", VA = "0x182466DC0")]
		public Act1BossRushEntryMissionButtonPlugin()
		{
		}

		// Token: 0x0403A8B0 RID: 239792
		[Token(Token = "0x403A8B0")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private UICommonTrackPoint _newMissionTrackPoint;

		// Token: 0x0403A8B1 RID: 239793
		[Token(Token = "0x403A8B1")]
		[FieldOffset(Offset = "0x30")]
		private bool m_isInited;

		// Token: 0x0403A8B2 RID: 239794
		[Token(Token = "0x403A8B2")]
		[FieldOffset(Offset = "0x38")]
		private TrackPointViewProperty m_missionTrackProperty;

		// Token: 0x0403A8B3 RID: 239795
		[Token(Token = "0x403A8B3")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnViewModelRefresh;

		// Token: 0x0403A8B4 RID: 239796
		[Token(Token = "0x403A8B4")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OpenMission;

		// Token: 0x0403A8B5 RID: 239797
		[Token(Token = "0x403A8B5")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0403A8B6 RID: 239798
		[Token(Token = "0x403A8B6")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}

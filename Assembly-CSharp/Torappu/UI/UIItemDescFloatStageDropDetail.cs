using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI
{
	// Token: 0x02003738 RID: 14136
	[Token(Token = "0x2003738")]
	public class UIItemDescFloatStageDropDetail : MonoBehaviour, IHotfixable
	{
		// Token: 0x170035D8 RID: 13784
		// (get) Token: 0x0601674E RID: 91982 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0601674F RID: 91983 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170035D8")]
		public Action<UIItemDescFloatStageDropDetail.RouteTarget> onRouteClicked
		{
			[Token(Token = "0x601674E")]
			[Address(RVA = "0xEE7670", Offset = "0xEE6270", VA = "0x180EE7670")]
			[CompilerGenerated]
			private get
			{
				return null;
			}
			[Token(Token = "0x601674F")]
			[Address(RVA = "0xEE76D0", Offset = "0xEE62D0", VA = "0x180EE76D0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x06016750 RID: 91984 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6016750")]
		[Address(RVA = "0xEE7190", Offset = "0xEE5D90", VA = "0x180EE7190")]
		public void Render(PlayerStage playerStage, StageData stageData, OccPer occPercent, bool enableDropRoute)
		{
		}

		// Token: 0x06016751 RID: 91985 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6016751")]
		[Address(RVA = "0xEE6DA0", Offset = "0xEE59A0", VA = "0x180EE6DA0")]
		public void RenderWeekly(string zoneId, bool enableDropRoute)
		{
		}

		// Token: 0x06016752 RID: 91986 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6016752")]
		[Address(RVA = "0xEE68D0", Offset = "0xEE54D0", VA = "0x180EE68D0")]
		public void RenderCampaign(List<string> stages, bool enbableDropRoute)
		{
		}

		// Token: 0x06016753 RID: 91987 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6016753")]
		[Address(RVA = "0xEE6B40", Offset = "0xEE5740", VA = "0x180EE6B40")]
		public void RenderClimbTower(bool enableDropRoute)
		{
		}

		// Token: 0x06016754 RID: 91988 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6016754")]
		[Address(RVA = "0xEE73F0", Offset = "0xEE5FF0", VA = "0x180EE73F0")]
		private void _RecordCache(string zoneId, [Optional] string stageId, StageType type = StageType.ENUM)
		{
		}

		// Token: 0x06016755 RID: 91989 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6016755")]
		[Address(RVA = "0xEE74B0", Offset = "0xEE60B0", VA = "0x180EE74B0")]
		private void _SetButtonsGotoMode()
		{
		}

		// Token: 0x06016756 RID: 91990 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6016756")]
		[Address(RVA = "0xEE7580", Offset = "0xEE6180", VA = "0x180EE7580")]
		private void _SetButtonsUnlockMode()
		{
		}

		// Token: 0x06016757 RID: 91991 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6016757")]
		[Address(RVA = "0xEE6780", Offset = "0xEE5380", VA = "0x180EE6780")]
		public void EventOnGoToButtonClicked()
		{
		}

		// Token: 0x06016758 RID: 91992 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6016758")]
		[Address(RVA = "0xEE7610", Offset = "0xEE6210", VA = "0x180EE7610")]
		public UIItemDescFloatStageDropDetail()
		{
		}

		// Token: 0x0401B08E RID: 110734
		[Token(Token = "0x401B08E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Text _stageName;

		// Token: 0x0401B08F RID: 110735
		[Token(Token = "0x401B08F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Button _gotoButton;

		// Token: 0x0401B090 RID: 110736
		[Token(Token = "0x401B090")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private GameObject _unlockButton;

		// Token: 0x0401B091 RID: 110737
		[Token(Token = "0x401B091")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		private GameObject _notPassButton;

		// Token: 0x0401B092 RID: 110738
		[Token(Token = "0x401B092")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[SerializeField]
		private GameObject[] _occPerGameObject;

		// Token: 0x0401B093 RID: 110739
		[Token(Token = "0x401B093")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[SerializeField]
		private RectTransform _autoLayout;

		// Token: 0x0401B094 RID: 110740
		[Token(Token = "0x401B094")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private string m_stageId;

		// Token: 0x0401B095 RID: 110741
		[Token(Token = "0x401B095")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private string m_zoneId;

		// Token: 0x0401B096 RID: 110742
		[Token(Token = "0x401B096")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private bool m_isCampaign;

		// Token: 0x0401B097 RID: 110743
		[Token(Token = "0x401B097")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x59")]
		private bool m_isClimbTower;

		// Token: 0x0401B098 RID: 110744
		[Token(Token = "0x401B098")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5A")]
		private bool m_enableDropRoute;

		// Token: 0x0401B09A RID: 110746
		[Token(Token = "0x401B09A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_onRouteClicked;

		// Token: 0x0401B09B RID: 110747
		[Token(Token = "0x401B09B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_onRouteClicked;

		// Token: 0x0401B09C RID: 110748
		[Token(Token = "0x401B09C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0401B09D RID: 110749
		[Token(Token = "0x401B09D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_RenderWeekly;

		// Token: 0x0401B09E RID: 110750
		[Token(Token = "0x401B09E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_RenderCampaign;

		// Token: 0x0401B09F RID: 110751
		[Token(Token = "0x401B09F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_RenderClimbTower;

		// Token: 0x0401B0A0 RID: 110752
		[Token(Token = "0x401B0A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__RecordCache;

		// Token: 0x0401B0A1 RID: 110753
		[Token(Token = "0x401B0A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__SetButtonsGotoMode;

		// Token: 0x0401B0A2 RID: 110754
		[Token(Token = "0x401B0A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__SetButtonsUnlockMode;

		// Token: 0x0401B0A3 RID: 110755
		[Token(Token = "0x401B0A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_EventOnGoToButtonClicked;

		// Token: 0x0401B0A4 RID: 110756
		[Token(Token = "0x401B0A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02003739 RID: 14137
		[Token(Token = "0x2003739")]
		public struct RouteTarget
		{
			// Token: 0x0401B0A5 RID: 110757
			[Token(Token = "0x401B0A5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public bool isCampaign;

			// Token: 0x0401B0A6 RID: 110758
			[Token(Token = "0x401B0A6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1")]
			public bool isClimbTower;

			// Token: 0x0401B0A7 RID: 110759
			[Token(Token = "0x401B0A7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public string zoneId;

			// Token: 0x0401B0A8 RID: 110760
			[Token(Token = "0x401B0A8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public string stageId;
		}
	}
}

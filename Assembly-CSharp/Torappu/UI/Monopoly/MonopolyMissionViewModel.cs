using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.Monopoly
{
	// Token: 0x0200480F RID: 18447
	[Token(Token = "0x200480F")]
	public class MonopolyMissionViewModel : IHotfixable
	{
		// Token: 0x0601BE44 RID: 114244 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601BE44")]
		[Address(RVA = "0x1546600", Offset = "0x1545200", VA = "0x181546600")]
		private void _LoadMissionListData(List<PlayerActivity.PlayerAct46SideActivity.PlayerMonopolyTask> playerTaskList)
		{
		}

		// Token: 0x0601BE45 RID: 114245 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601BE45")]
		[Address(RVA = "0x1546330", Offset = "0x1544F30", VA = "0x181546330")]
		public void LoadData(string actId, MonopolyCardPanelModel cardPanelModel, MonopolyMapViewModel mapViewModel)
		{
		}

		// Token: 0x0601BE46 RID: 114246 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601BE46")]
		[Address(RVA = "0x1546030", Offset = "0x1544C30", VA = "0x181546030")]
		public void CalculateDelayInfo(MonopolyCalculateDelayInfoInput input, ref float delay)
		{
		}

		// Token: 0x0601BE47 RID: 114247 RVA: 0x000A68F0 File Offset: 0x000A4AF0
		[Token(Token = "0x601BE47")]
		[Address(RVA = "0x1546280", Offset = "0x1544E80", VA = "0x181546280")]
		public int GetPreviewResourceCount(string resourceId)
		{
			return 0;
		}

		// Token: 0x0601BE48 RID: 114248 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601BE48")]
		[Address(RVA = "0x15467F0", Offset = "0x15453F0", VA = "0x1815467F0")]
		private void _RefreshMissionPreviewData(MonopolyCardPanelModel cardPanelModel, MonopolyMapViewModel mapViewModel)
		{
		}

		// Token: 0x0601BE49 RID: 114249 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601BE49")]
		[Address(RVA = "0x1546930", Offset = "0x1545530", VA = "0x181546930")]
		public MonopolyMissionViewModel()
		{
		}

		// Token: 0x04024599 RID: 148889
		[Token(Token = "0x4024599")]
		[FieldOffset(Offset = "0x10")]
		public string actId;

		// Token: 0x0402459A RID: 148890
		[Token(Token = "0x402459A")]
		[FieldOffset(Offset = "0x18")]
		public string stageId;

		// Token: 0x0402459B RID: 148891
		[Token(Token = "0x402459B")]
		[FieldOffset(Offset = "0x20")]
		public int currScore;

		// Token: 0x0402459C RID: 148892
		[Token(Token = "0x402459C")]
		[FieldOffset(Offset = "0x24")]
		public int targetScore;

		// Token: 0x0402459D RID: 148893
		[Token(Token = "0x402459D")]
		[FieldOffset(Offset = "0x28")]
		public string currPreviewResourceId;

		// Token: 0x0402459E RID: 148894
		[Token(Token = "0x402459E")]
		[FieldOffset(Offset = "0x30")]
		public int currPreviewResourceCount;

		// Token: 0x0402459F RID: 148895
		[Token(Token = "0x402459F")]
		[FieldOffset(Offset = "0x34")]
		public int currPreviewComboRewardScore;

		// Token: 0x040245A0 RID: 148896
		[Token(Token = "0x40245A0")]
		[FieldOffset(Offset = "0x38")]
		public int comboRewardScore;

		// Token: 0x040245A1 RID: 148897
		[Token(Token = "0x40245A1")]
		[FieldOffset(Offset = "0x3C")]
		public bool showPreview;

		// Token: 0x040245A2 RID: 148898
		[Token(Token = "0x40245A2")]
		[FieldOffset(Offset = "0x40")]
		public List<MonopolyMissionItemViewModel> missionList;

		// Token: 0x040245A3 RID: 148899
		[Token(Token = "0x40245A3")]
		[FieldOffset(Offset = "0x48")]
		public int comboTipSeqNum;

		// Token: 0x040245A4 RID: 148900
		[Token(Token = "0x40245A4")]
		[FieldOffset(Offset = "0x4C")]
		public float comboTipDelay;

		// Token: 0x040245A5 RID: 148901
		[Token(Token = "0x40245A5")]
		[FieldOffset(Offset = "0x50")]
		public float progressIncreaseDelay;

		// Token: 0x040245A6 RID: 148902
		[Token(Token = "0x40245A6")]
		[FieldOffset(Offset = "0x54")]
		public int missionCompleteSeqNum;

		// Token: 0x040245A7 RID: 148903
		[Token(Token = "0x40245A7")]
		[FieldOffset(Offset = "0x58")]
		public float afterProgressIncreaseDelay;

		// Token: 0x040245A8 RID: 148904
		[Token(Token = "0x40245A8")]
		[FieldOffset(Offset = "0x5C")]
		public float scoreRankUp1AnimDelay;

		// Token: 0x040245A9 RID: 148905
		[Token(Token = "0x40245A9")]
		[FieldOffset(Offset = "0x60")]
		public float scoreRankUp2AnimDelay;

		// Token: 0x040245AA RID: 148906
		[Token(Token = "0x40245AA")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0__LoadMissionListData;

		// Token: 0x040245AB RID: 148907
		[Token(Token = "0x40245AB")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_LoadData;

		// Token: 0x040245AC RID: 148908
		[Token(Token = "0x40245AC")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_CalculateDelayInfo;

		// Token: 0x040245AD RID: 148909
		[Token(Token = "0x40245AD")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_GetPreviewResourceCount;

		// Token: 0x040245AE RID: 148910
		[Token(Token = "0x40245AE")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__RefreshMissionPreviewData;

		// Token: 0x040245AF RID: 148911
		[Token(Token = "0x40245AF")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}

using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.Stage
{
	// Token: 0x020068C4 RID: 26820
	[Token(Token = "0x20068C4")]
	public class StageRewardStateBean : MonoBehaviour, IStateBean, IHotfixable
	{
		// Token: 0x17005AB5 RID: 23221
		// (get) Token: 0x060266C6 RID: 157382 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17005AB5")]
		public StageData stageData
		{
			[Token(Token = "0x60266C6")]
			[Address(RVA = "0x21861B0", Offset = "0x2184DB0", VA = "0x1821861B0")]
			get
			{
				return null;
			}
		}

		// Token: 0x060266C7 RID: 157383 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60266C7")]
		[Address(RVA = "0x2184C60", Offset = "0x2183860", VA = "0x182184C60")]
		public void ApplyStageData(string stageId, CampaignStageType stageType = CampaignStageType.NONE)
		{
		}

		// Token: 0x060266C8 RID: 157384 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60266C8")]
		[Address(RVA = "0x2185F50", Offset = "0x2184B50", VA = "0x182185F50")]
		private void _InsertViewModel(StageData.DisplayDetailRewards detailRewards)
		{
		}

		// Token: 0x060266C9 RID: 157385 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60266C9")]
		[Address(RVA = "0x2185430", Offset = "0x2184030", VA = "0x182185430")]
		private IList<StageData.DisplayDetailRewards> _GetActivityRewards(StageData stageData)
		{
			return null;
		}

		// Token: 0x060266CA RID: 157386 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60266CA")]
		[Address(RVA = "0x2185580", Offset = "0x2184180", VA = "0x182185580")]
		private IList<StageData.DisplayDetailRewards> _GetDisplayDetailRewards(StageData stageData, CampaignStageType campaignStageType = CampaignStageType.NONE)
		{
			return null;
		}

		// Token: 0x060266CB RID: 157387 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60266CB")]
		[Address(RVA = "0x2185AD0", Offset = "0x21846D0", VA = "0x182185AD0")]
		private Dictionary<string, StageData.StageDropInfo> _GetReplaceDropDisplay(StageData data)
		{
			return null;
		}

		// Token: 0x060266CC RID: 157388 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60266CC")]
		[Address(RVA = "0x2185ED0", Offset = "0x2184AD0", VA = "0x182185ED0")]
		private Dictionary<string, StageData.StageDropInfo> _GetTimelyDropDisplay(StageData data)
		{
			return null;
		}

		// Token: 0x060266CD RID: 157389 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60266CD")]
		[Address(RVA = "0x21858F0", Offset = "0x21844F0", VA = "0x1821858F0")]
		private Dictionary<string, StageData.StageDropInfo> _GetIfHasOverrideDropDisplay(StageData data, bool checkRepalce, bool isReplace = false)
		{
			return null;
		}

		// Token: 0x060266CE RID: 157390 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60266CE")]
		[Address(RVA = "0x2185B50", Offset = "0x2184750", VA = "0x182185B50")]
		private List<KeyValuePair<string, StageRewardDetailViewModel>> _GetTimelyDisplayDetailRewards(StageData stageData)
		{
			return null;
		}

		// Token: 0x060266CF RID: 157391 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60266CF")]
		[Address(RVA = "0x2186100", Offset = "0x2184D00", VA = "0x182186100")]
		public StageRewardStateBean()
		{
		}

		// Token: 0x040361FE RID: 221694
		[Token(Token = "0x40361FE")]
		[FieldOffset(Offset = "0x18")]
		[NonSerialized]
		public Dictionary<StageDropType, List<StageRewardDetailViewModel>> groupRewardList;

		// Token: 0x040361FF RID: 221695
		[Token(Token = "0x40361FF")]
		[FieldOffset(Offset = "0x20")]
		[NonSerialized]
		public List<KeyValuePair<string, StageRewardDetailViewModel>> timelyRewardList;

		// Token: 0x04036200 RID: 221696
		[Token(Token = "0x4036200")]
		[FieldOffset(Offset = "0x28")]
		[NonSerialized]
		public bool isGet;

		// Token: 0x04036201 RID: 221697
		[Token(Token = "0x4036201")]
		[FieldOffset(Offset = "0x29")]
		[NonSerialized]
		public bool isComplete;

		// Token: 0x04036202 RID: 221698
		[Token(Token = "0x4036202")]
		[FieldOffset(Offset = "0x2A")]
		[NonSerialized]
		public bool hasOverrideBuff;

		// Token: 0x04036203 RID: 221699
		[Token(Token = "0x4036203")]
		[FieldOffset(Offset = "0x30")]
		[NonSerialized]
		public OverrideDropInfo overrideDropInfo;

		// Token: 0x04036204 RID: 221700
		[Token(Token = "0x4036204")]
		[FieldOffset(Offset = "0x38")]
		private StageData m_stageData;

		// Token: 0x04036205 RID: 221701
		[Token(Token = "0x4036205")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_stageData;

		// Token: 0x04036206 RID: 221702
		[Token(Token = "0x4036206")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_ApplyStageData;

		// Token: 0x04036207 RID: 221703
		[Token(Token = "0x4036207")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__InsertViewModel;

		// Token: 0x04036208 RID: 221704
		[Token(Token = "0x4036208")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__GetActivityRewards;

		// Token: 0x04036209 RID: 221705
		[Token(Token = "0x4036209")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__GetDisplayDetailRewards;

		// Token: 0x0403620A RID: 221706
		[Token(Token = "0x403620A")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__GetReplaceDropDisplay;

		// Token: 0x0403620B RID: 221707
		[Token(Token = "0x403620B")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__GetTimelyDropDisplay;

		// Token: 0x0403620C RID: 221708
		[Token(Token = "0x403620C")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__GetIfHasOverrideDropDisplay;

		// Token: 0x0403620D RID: 221709
		[Token(Token = "0x403620D")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__GetTimelyDisplayDetailRewards;

		// Token: 0x0403620E RID: 221710
		[Token(Token = "0x403620E")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}

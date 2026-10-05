using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.UI;
using Torappu.UI.Stage;
using UnityEngine;
using XLua;

namespace Torappu.Activity.Act24side
{
	// Token: 0x02007617 RID: 30231
	[Token(Token = "0x2007617")]
	public class Act24sideStageRewardDetailPluginView : StageRewardDetailPluginView
	{
		// Token: 0x0602A8F4 RID: 174324 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A8F4")]
		[Address(RVA = "0x26626D0", Offset = "0x26612D0", VA = "0x1826626D0", Slot = "4")]
		public override void Dispose()
		{
		}

		// Token: 0x0602A8F5 RID: 174325 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A8F5")]
		[Address(RVA = "0x2662730", Offset = "0x2661330", VA = "0x182662730", Slot = "5")]
		public override void Render(string actId, StageData stageData, bool getFlag, bool completeFlag)
		{
		}

		// Token: 0x0602A8F6 RID: 174326 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A8F6")]
		[Address(RVA = "0x2662C40", Offset = "0x2661840", VA = "0x182662C40")]
		private void _InitData()
		{
		}

		// Token: 0x0602A8F7 RID: 174327 RVA: 0x000D8FC0 File Offset: 0x000D71C0
		[Token(Token = "0x602A8F7")]
		[Address(RVA = "0x26630B0", Offset = "0x2661CB0", VA = "0x1826630B0")]
		private int _SortReward(Act24sideStageRewardDetailPluginView.MeldingDataStruct x, Act24sideStageRewardDetailPluginView.MeldingDataStruct y)
		{
			return 0;
		}

		// Token: 0x0602A8F8 RID: 174328 RVA: 0x000D8FD8 File Offset: 0x000D71D8
		[Token(Token = "0x602A8F8")]
		[Address(RVA = "0x2662AB0", Offset = "0x26616B0", VA = "0x182662AB0")]
		private Act24sideStageRewardDetailPluginView.MeldingDataStruct _CreateMeldingStruct(StageData.DisplayDetailRewards rewardData)
		{
			return default(Act24sideStageRewardDetailPluginView.MeldingDataStruct);
		}

		// Token: 0x0602A8F9 RID: 174329 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A8F9")]
		[Address(RVA = "0x2662F90", Offset = "0x2661B90", VA = "0x182662F90")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0602A8FA RID: 174330 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A8FA")]
		[Address(RVA = "0x26632A0", Offset = "0x2661EA0", VA = "0x1826632A0")]
		public Act24sideStageRewardDetailPluginView()
		{
		}

		// Token: 0x0403D466 RID: 250982
		[Token(Token = "0x403D466")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private RectTransform _viewRoot;

		// Token: 0x0403D467 RID: 250983
		[Token(Token = "0x403D467")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private SimpleLayoutContent _firstCompleteList;

		// Token: 0x0403D468 RID: 250984
		[Token(Token = "0x403D468")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private SimpleLayoutContent _normalList;

		// Token: 0x0403D469 RID: 250985
		[Token(Token = "0x403D469")]
		[FieldOffset(Offset = "0x30")]
		private bool m_hasInited;

		// Token: 0x0403D46A RID: 250986
		[Token(Token = "0x403D46A")]
		[FieldOffset(Offset = "0x38")]
		private string m_actId;

		// Token: 0x0403D46B RID: 250987
		[Token(Token = "0x403D46B")]
		[FieldOffset(Offset = "0x40")]
		private StageData m_stageData;

		// Token: 0x0403D46C RID: 250988
		[Token(Token = "0x403D46C")]
		[FieldOffset(Offset = "0x48")]
		private Act24sideStageRewardDetailPluginView.RewardListAdapter m_firstCompleteListAdapter;

		// Token: 0x0403D46D RID: 250989
		[Token(Token = "0x403D46D")]
		[FieldOffset(Offset = "0x50")]
		private Act24sideStageRewardDetailPluginView.RewardListAdapter m_normalListAdapter;

		// Token: 0x0403D46E RID: 250990
		[Token(Token = "0x403D46E")]
		[FieldOffset(Offset = "0x58")]
		private List<Act24sideStageRewardDetailPluginView.MeldingDataStruct> m_firstCompleteRewardList;

		// Token: 0x0403D46F RID: 250991
		[Token(Token = "0x403D46F")]
		[FieldOffset(Offset = "0x60")]
		private List<Act24sideStageRewardDetailPluginView.MeldingDataStruct> m_normalRewardList;

		// Token: 0x0403D470 RID: 250992
		[Token(Token = "0x403D470")]
		[FieldOffset(Offset = "0x68")]
		private bool m_getFlag;

		// Token: 0x0403D471 RID: 250993
		[Token(Token = "0x403D471")]
		[FieldOffset(Offset = "0x69")]
		private bool m_completeFlag;

		// Token: 0x0403D472 RID: 250994
		[Token(Token = "0x403D472")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Dispose;

		// Token: 0x0403D473 RID: 250995
		[Token(Token = "0x403D473")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0403D474 RID: 250996
		[Token(Token = "0x403D474")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__InitData;

		// Token: 0x0403D475 RID: 250997
		[Token(Token = "0x403D475")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__SortReward;

		// Token: 0x0403D476 RID: 250998
		[Token(Token = "0x403D476")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__CreateMeldingStruct;

		// Token: 0x0403D477 RID: 250999
		[Token(Token = "0x403D477")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0403D478 RID: 251000
		[Token(Token = "0x403D478")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02007618 RID: 30232
		[Token(Token = "0x2007618")]
		private struct MeldingDataStruct
		{
			// Token: 0x0403D479 RID: 251001
			[Token(Token = "0x403D479")]
			[FieldOffset(Offset = "0x0")]
			public StageData.DisplayDetailRewards detailReward;

			// Token: 0x0403D47A RID: 251002
			[Token(Token = "0x403D47A")]
			[FieldOffset(Offset = "0x8")]
			public Act24sideMeldingItemViewModel itemViewModel;
		}

		// Token: 0x02007619 RID: 30233
		[Token(Token = "0x2007619")]
		private class RewardListAdapter : SimpleLayoutAdapter
		{
			// Token: 0x0602A8FB RID: 174331 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602A8FB")]
			[Address(RVA = "0x2665D10", Offset = "0x2664910", VA = "0x182665D10")]
			public void SetData(string actId, bool getFlag, bool completeFlag, List<Act24sideStageRewardDetailPluginView.MeldingDataStruct> rewardList)
			{
			}

			// Token: 0x17006421 RID: 25633
			// (get) Token: 0x0602A8FC RID: 174332 RVA: 0x000D8FF0 File Offset: 0x000D71F0
			[Token(Token = "0x17006421")]
			public override int count
			{
				[Token(Token = "0x602A8FC")]
				[Address(RVA = "0x2665E30", Offset = "0x2664A30", VA = "0x182665E30", Slot = "4")]
				get
				{
					return 0;
				}
			}

			// Token: 0x0602A8FD RID: 174333 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x602A8FD")]
			[Address(RVA = "0x2665A20", Offset = "0x2664620", VA = "0x182665A20", Slot = "5")]
			public override GameObject RenderView(int position, GameObject prefab, Transform parent)
			{
				return null;
			}

			// Token: 0x0602A8FE RID: 174334 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602A8FE")]
			[Address(RVA = "0x2665DD0", Offset = "0x26649D0", VA = "0x182665DD0")]
			public RewardListAdapter()
			{
			}

			// Token: 0x0403D47B RID: 251003
			[Token(Token = "0x403D47B")]
			[FieldOffset(Offset = "0x20")]
			private string m_actId;

			// Token: 0x0403D47C RID: 251004
			[Token(Token = "0x403D47C")]
			[FieldOffset(Offset = "0x28")]
			private bool m_getFlag;

			// Token: 0x0403D47D RID: 251005
			[Token(Token = "0x403D47D")]
			[FieldOffset(Offset = "0x29")]
			private bool m_completeFlag;

			// Token: 0x0403D47E RID: 251006
			[Token(Token = "0x403D47E")]
			[FieldOffset(Offset = "0x30")]
			private List<Act24sideStageRewardDetailPluginView.MeldingDataStruct> m_rewardList;

			// Token: 0x0403D47F RID: 251007
			[Token(Token = "0x403D47F")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_SetData;

			// Token: 0x0403D480 RID: 251008
			[Token(Token = "0x403D480")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_get_count;

			// Token: 0x0403D481 RID: 251009
			[Token(Token = "0x403D481")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_RenderView;

			// Token: 0x0403D482 RID: 251010
			[Token(Token = "0x403D482")]
			[FieldOffset(Offset = "0x18")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}
	}
}

using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.UI;
using Torappu.UI.Stage;
using UnityEngine;
using XLua;

namespace Torappu.Activity.Act24side
{
	// Token: 0x0200761A RID: 30234
	[Token(Token = "0x200761A")]
	public class Act24sideStageRewardPreviewPluginView : StageRewardPreviewPluginView
	{
		// Token: 0x0602A8FF RID: 174335 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A8FF")]
		[Address(RVA = "0x2663390", Offset = "0x2661F90", VA = "0x182663390", Slot = "5")]
		public override void Dispose()
		{
		}

		// Token: 0x0602A900 RID: 174336 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A900")]
		[Address(RVA = "0x26633F0", Offset = "0x2661FF0", VA = "0x1826633F0", Slot = "4")]
		public override void Render(StageViewModel selectedStage)
		{
		}

		// Token: 0x0602A901 RID: 174337 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A901")]
		[Address(RVA = "0x2663840", Offset = "0x2662440", VA = "0x182663840")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0602A902 RID: 174338 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A902")]
		[Address(RVA = "0x2663960", Offset = "0x2662560", VA = "0x182663960")]
		private void _UpdateNormalRewardList()
		{
		}

		// Token: 0x0602A903 RID: 174339 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A903")]
		[Address(RVA = "0x2663AE0", Offset = "0x26626E0", VA = "0x182663AE0")]
		public Act24sideStageRewardPreviewPluginView()
		{
		}

		// Token: 0x0403D483 RID: 251011
		[Token(Token = "0x403D483")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private StageRewardPreviewItem _normalRewardView;

		// Token: 0x0403D484 RID: 251012
		[Token(Token = "0x403D484")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private SimpleLayoutContent _meldingList;

		// Token: 0x0403D485 RID: 251013
		[Token(Token = "0x403D485")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private GameObject _meldingListGo;

		// Token: 0x0403D486 RID: 251014
		[Token(Token = "0x403D486")]
		[FieldOffset(Offset = "0x38")]
		private List<StageRewardViewModel> m_normalRewardList;

		// Token: 0x0403D487 RID: 251015
		[Token(Token = "0x403D487")]
		[FieldOffset(Offset = "0x40")]
		private List<Act24sideMeldingSmallItemViewModel> m_meldingRewardList;

		// Token: 0x0403D488 RID: 251016
		[Token(Token = "0x403D488")]
		[FieldOffset(Offset = "0x48")]
		private string m_actId;

		// Token: 0x0403D489 RID: 251017
		[Token(Token = "0x403D489")]
		[FieldOffset(Offset = "0x50")]
		private StageViewModel m_stageModel;

		// Token: 0x0403D48A RID: 251018
		[Token(Token = "0x403D48A")]
		[FieldOffset(Offset = "0x58")]
		private bool m_hasInited;

		// Token: 0x0403D48B RID: 251019
		[Token(Token = "0x403D48B")]
		[FieldOffset(Offset = "0x60")]
		private Act24sideStageRewardPreviewPluginView.MeldingListAdapter m_meldingListAdapter;

		// Token: 0x0403D48C RID: 251020
		[Token(Token = "0x403D48C")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Dispose;

		// Token: 0x0403D48D RID: 251021
		[Token(Token = "0x403D48D")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0403D48E RID: 251022
		[Token(Token = "0x403D48E")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0403D48F RID: 251023
		[Token(Token = "0x403D48F")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__UpdateNormalRewardList;

		// Token: 0x0403D490 RID: 251024
		[Token(Token = "0x403D490")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x0200761B RID: 30235
		[Token(Token = "0x200761B")]
		private class MeldingListAdapter : SimpleLayoutAdapter
		{
			// Token: 0x0602A904 RID: 174340 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602A904")]
			[Address(RVA = "0x2664B00", Offset = "0x2663700", VA = "0x182664B00")]
			public MeldingListAdapter(Act24sideStageRewardPreviewPluginView closure)
			{
			}

			// Token: 0x17006422 RID: 25634
			// (get) Token: 0x0602A905 RID: 174341 RVA: 0x000D9008 File Offset: 0x000D7208
			[Token(Token = "0x17006422")]
			public override int count
			{
				[Token(Token = "0x602A905")]
				[Address(RVA = "0x2664C80", Offset = "0x2663880", VA = "0x182664C80", Slot = "4")]
				get
				{
					return 0;
				}
			}

			// Token: 0x0602A906 RID: 174342 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x602A906")]
			[Address(RVA = "0x2664650", Offset = "0x2663250", VA = "0x182664650", Slot = "5")]
			public override GameObject RenderView(int position, GameObject prefab, Transform parent)
			{
				return null;
			}

			// Token: 0x0403D491 RID: 251025
			[Token(Token = "0x403D491")]
			private const int MAX_COUNT = 4;

			// Token: 0x0403D492 RID: 251026
			[Token(Token = "0x403D492")]
			[FieldOffset(Offset = "0x20")]
			private Act24sideStageRewardPreviewPluginView m_closure;

			// Token: 0x0403D493 RID: 251027
			[Token(Token = "0x403D493")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x0403D494 RID: 251028
			[Token(Token = "0x403D494")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_get_count;

			// Token: 0x0403D495 RID: 251029
			[Token(Token = "0x403D495")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_RenderView;
		}
	}
}

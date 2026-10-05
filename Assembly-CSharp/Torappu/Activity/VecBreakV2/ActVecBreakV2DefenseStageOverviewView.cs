using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Torappu.DataBind;
using Torappu.UI;
using UnityEngine;
using XLua;

namespace Torappu.Activity.VecBreakV2
{
	// Token: 0x02006E19 RID: 28185
	[Token(Token = "0x2006E19")]
	public class ActVecBreakV2DefenseStageOverviewView : DataBinder<ActVecBreakV2DefenseStageOverviewProperty>
	{
		// Token: 0x060281F9 RID: 164345 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60281F9")]
		[Address(RVA = "0x236AF00", Offset = "0x2369B00", VA = "0x18236AF00", Slot = "7")]
		public override void OnValueChanged(ActVecBreakV2DefenseStageOverviewProperty property)
		{
		}

		// Token: 0x060281FA RID: 164346 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60281FA")]
		[Address(RVA = "0x236ACC0", Offset = "0x23698C0", VA = "0x18236ACC0")]
		public void CollectInputParamForShareModel(List<ActVecBreakV2DefenseStageBaseItem.InputParam> list)
		{
		}

		// Token: 0x060281FB RID: 164347 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60281FB")]
		[Address(RVA = "0x236AE70", Offset = "0x2369A70", VA = "0x18236AE70")]
		public void EventOnOpenShare()
		{
		}

		// Token: 0x060281FC RID: 164348 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60281FC")]
		[Address(RVA = "0x236B290", Offset = "0x2369E90", VA = "0x18236B290")]
		private void _InitIfNot()
		{
		}

		// Token: 0x060281FD RID: 164349 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60281FD")]
		[Address(RVA = "0x236B1A0", Offset = "0x2369DA0", VA = "0x18236B1A0")]
		private void _EventOnFocusStage(string stageId)
		{
		}

		// Token: 0x060281FE RID: 164350 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60281FE")]
		[Address(RVA = "0x236B460", Offset = "0x236A060", VA = "0x18236B460")]
		public ActVecBreakV2DefenseStageOverviewView()
		{
		}

		// Token: 0x04038F65 RID: 233317
		[Token(Token = "0x4038F65")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private SimpleLayoutContent _overviewListContent;

		// Token: 0x04038F66 RID: 233318
		[Token(Token = "0x4038F66")]
		[FieldOffset(Offset = "0x28")]
		private bool m_hasInited;

		// Token: 0x04038F67 RID: 233319
		[Token(Token = "0x4038F67")]
		[FieldOffset(Offset = "0x30")]
		private List<ActVecBreakV2DefenseBuffListItemModel> m_cacheListItemModels;

		// Token: 0x04038F68 RID: 233320
		[Token(Token = "0x4038F68")]
		[FieldOffset(Offset = "0x38")]
		private List<string> m_cacheSelectedBuffIds;

		// Token: 0x04038F69 RID: 233321
		[Token(Token = "0x4038F69")]
		[FieldOffset(Offset = "0x40")]
		private Dictionary<string, ActVecBreakV2DefenseStageDetailItemModel> m_cacheStageDetailDict;

		// Token: 0x04038F6A RID: 233322
		[Token(Token = "0x4038F6A")]
		[FieldOffset(Offset = "0x48")]
		private ActVecBreakV2DefenseStageOverviewView.Adapter m_adapter;

		// Token: 0x04038F6B RID: 233323
		[Token(Token = "0x4038F6B")]
		[FieldOffset(Offset = "0x50")]
		private UIStateFinder m_stateFinder;

		// Token: 0x04038F6C RID: 233324
		[Token(Token = "0x4038F6C")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnValueChanged;

		// Token: 0x04038F6D RID: 233325
		[Token(Token = "0x4038F6D")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_CollectInputParamForShareModel;

		// Token: 0x04038F6E RID: 233326
		[Token(Token = "0x4038F6E")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_EventOnOpenShare;

		// Token: 0x04038F6F RID: 233327
		[Token(Token = "0x4038F6F")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x04038F70 RID: 233328
		[Token(Token = "0x4038F70")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__EventOnFocusStage;

		// Token: 0x04038F71 RID: 233329
		[Token(Token = "0x4038F71")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02006E1A RID: 28186
		[Token(Token = "0x2006E1A")]
		private class Adapter : SimpleLayoutAdapter
		{
			// Token: 0x060281FF RID: 164351 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60281FF")]
			[Address(RVA = "0x2372900", Offset = "0x2371500", VA = "0x182372900")]
			public Adapter(ActVecBreakV2DefenseStageOverviewView closure)
			{
			}

			// Token: 0x17005EE1 RID: 24289
			// (get) Token: 0x06028200 RID: 164352 RVA: 0x00002050 File Offset: 0x00000250
			// (set) Token: 0x06028201 RID: 164353 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x17005EE1")]
			public Action<string> onItemClick
			{
				[Token(Token = "0x6028200")]
				[Address(RVA = "0x2372B00", Offset = "0x2371700", VA = "0x182372B00")]
				[CompilerGenerated]
				private get
				{
					return null;
				}
				[Token(Token = "0x6028201")]
				[Address(RVA = "0x2372BC0", Offset = "0x23717C0", VA = "0x182372BC0")]
				[CompilerGenerated]
				set
				{
				}
			}

			// Token: 0x17005EE2 RID: 24290
			// (get) Token: 0x06028202 RID: 164354 RVA: 0x000D0B78 File Offset: 0x000CED78
			[Token(Token = "0x17005EE2")]
			public override int count
			{
				[Token(Token = "0x6028202")]
				[Address(RVA = "0x2372980", Offset = "0x2371580", VA = "0x182372980", Slot = "4")]
				get
				{
					return 0;
				}
			}

			// Token: 0x06028203 RID: 164355 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6028203")]
			[Address(RVA = "0x2372380", Offset = "0x2370F80", VA = "0x182372380", Slot = "5")]
			public override GameObject RenderView(int position, GameObject prefab, Transform parent)
			{
				return null;
			}

			// Token: 0x06028204 RID: 164356 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6028204")]
			[Address(RVA = "0x2372090", Offset = "0x2370C90", VA = "0x182372090")]
			public void CollectInputParamForShareModel(List<ActVecBreakV2DefenseStageBaseItem.InputParam> list)
			{
			}

			// Token: 0x04038F72 RID: 233330
			[Token(Token = "0x4038F72")]
			[FieldOffset(Offset = "0x20")]
			private ActVecBreakV2DefenseStageOverviewView m_closure;

			// Token: 0x04038F74 RID: 233332
			[Token(Token = "0x4038F74")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x04038F75 RID: 233333
			[Token(Token = "0x4038F75")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_get_onItemClick;

			// Token: 0x04038F76 RID: 233334
			[Token(Token = "0x4038F76")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_set_onItemClick;

			// Token: 0x04038F77 RID: 233335
			[Token(Token = "0x4038F77")]
			[FieldOffset(Offset = "0x18")]
			private static DelegateBridge __Hotfix0_get_count;

			// Token: 0x04038F78 RID: 233336
			[Token(Token = "0x4038F78")]
			[FieldOffset(Offset = "0x20")]
			private static DelegateBridge __Hotfix0_RenderView;

			// Token: 0x04038F79 RID: 233337
			[Token(Token = "0x4038F79")]
			[FieldOffset(Offset = "0x28")]
			private static DelegateBridge __Hotfix0_CollectInputParamForShareModel;
		}
	}
}

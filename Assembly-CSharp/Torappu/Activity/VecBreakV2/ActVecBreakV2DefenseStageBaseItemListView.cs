using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Torappu.UI;
using UnityEngine;
using XLua;

namespace Torappu.Activity.VecBreakV2
{
	// Token: 0x02006E15 RID: 28181
	[Token(Token = "0x2006E15")]
	public class ActVecBreakV2DefenseStageBaseItemListView : MonoBehaviour, IHotfixable
	{
		// Token: 0x17005EDA RID: 24282
		// (get) Token: 0x060281D2 RID: 164306 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060281D3 RID: 164307 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17005EDA")]
		public Action<string> onItemClick
		{
			[Token(Token = "0x60281D2")]
			[Address(RVA = "0x2364260", Offset = "0x2362E60", VA = "0x182364260")]
			[CompilerGenerated]
			private get
			{
				return null;
			}
			[Token(Token = "0x60281D3")]
			[Address(RVA = "0x23642C0", Offset = "0x2362EC0", VA = "0x1823642C0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x060281D4 RID: 164308 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60281D4")]
		[Address(RVA = "0x2363C40", Offset = "0x2362840", VA = "0x182363C40")]
		public void Render(ActVecBreakV2DefenseBuffListItemModel itemModel, List<string> selectedBuffIds, Dictionary<string, ActVecBreakV2DefenseStageDetailItemModel> detailDict)
		{
		}

		// Token: 0x060281D5 RID: 164309 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60281D5")]
		[Address(RVA = "0x2363E60", Offset = "0x2362A60", VA = "0x182363E60")]
		public void SetAdapterParam(Func<string, bool> checkSelectFunc)
		{
		}

		// Token: 0x060281D6 RID: 164310 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60281D6")]
		[Address(RVA = "0x2363A70", Offset = "0x2362670", VA = "0x182363A70")]
		public void CollectInputParamForShareModel(List<ActVecBreakV2DefenseStageBaseItem.InputParam> list)
		{
		}

		// Token: 0x060281D7 RID: 164311 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60281D7")]
		[Address(RVA = "0x2364040", Offset = "0x2362C40", VA = "0x182364040")]
		private void _InitIfNot()
		{
		}

		// Token: 0x060281D8 RID: 164312 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60281D8")]
		[Address(RVA = "0x2363F20", Offset = "0x2362B20", VA = "0x182363F20")]
		private void _EventOnItemClick(string str)
		{
		}

		// Token: 0x060281D9 RID: 164313 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60281D9")]
		[Address(RVA = "0x2364200", Offset = "0x2362E00", VA = "0x182364200")]
		public ActVecBreakV2DefenseStageBaseItemListView()
		{
		}

		// Token: 0x04038EE8 RID: 233192
		[Token(Token = "0x4038EE8")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private SimpleLayoutContent _itemListContent;

		// Token: 0x04038EE9 RID: 233193
		[Token(Token = "0x4038EE9")]
		[FieldOffset(Offset = "0x20")]
		private bool m_hasInited;

		// Token: 0x04038EEA RID: 233194
		[Token(Token = "0x4038EEA")]
		[FieldOffset(Offset = "0x28")]
		private ActVecBreakV2DefenseStageBaseItemListView.BuffListAdapter m_adapter;

		// Token: 0x04038EEC RID: 233196
		[Token(Token = "0x4038EEC")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_onItemClick;

		// Token: 0x04038EED RID: 233197
		[Token(Token = "0x4038EED")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_onItemClick;

		// Token: 0x04038EEE RID: 233198
		[Token(Token = "0x4038EEE")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x04038EEF RID: 233199
		[Token(Token = "0x4038EEF")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_SetAdapterParam;

		// Token: 0x04038EF0 RID: 233200
		[Token(Token = "0x4038EF0")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_CollectInputParamForShareModel;

		// Token: 0x04038EF1 RID: 233201
		[Token(Token = "0x4038EF1")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x04038EF2 RID: 233202
		[Token(Token = "0x4038EF2")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__EventOnItemClick;

		// Token: 0x04038EF3 RID: 233203
		[Token(Token = "0x4038EF3")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02006E16 RID: 28182
		[Token(Token = "0x2006E16")]
		private class BuffListAdapter : SimpleLayoutAdapter
		{
			// Token: 0x17005EDB RID: 24283
			// (set) Token: 0x060281DA RID: 164314 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x17005EDB")]
			public ActVecBreakV2DefenseBuffListItemModel listModel
			{
				[Token(Token = "0x60281DA")]
				[Address(RVA = "0x23738D0", Offset = "0x23724D0", VA = "0x1823738D0")]
				set
				{
				}
			}

			// Token: 0x17005EDC RID: 24284
			// (set) Token: 0x060281DB RID: 164315 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x17005EDC")]
			public List<string> selectedBuffIds
			{
				[Token(Token = "0x60281DB")]
				[Address(RVA = "0x23739F0", Offset = "0x23725F0", VA = "0x1823739F0")]
				set
				{
				}
			}

			// Token: 0x17005EDD RID: 24285
			// (set) Token: 0x060281DC RID: 164316 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x17005EDD")]
			public Dictionary<string, ActVecBreakV2DefenseStageDetailItemModel> stageDetailDict
			{
				[Token(Token = "0x60281DC")]
				[Address(RVA = "0x2373A70", Offset = "0x2372670", VA = "0x182373A70")]
				set
				{
				}
			}

			// Token: 0x17005EDE RID: 24286
			// (get) Token: 0x060281DD RID: 164317 RVA: 0x00002050 File Offset: 0x00000250
			// (set) Token: 0x060281DE RID: 164318 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x17005EDE")]
			public Action<string> onItemClick
			{
				[Token(Token = "0x60281DD")]
				[Address(RVA = "0x23737F0", Offset = "0x23723F0", VA = "0x1823737F0")]
				[CompilerGenerated]
				private get
				{
					return null;
				}
				[Token(Token = "0x60281DE")]
				[Address(RVA = "0x2373970", Offset = "0x2372570", VA = "0x182373970")]
				[CompilerGenerated]
				set
				{
				}
			}

			// Token: 0x17005EDF RID: 24287
			// (get) Token: 0x060281DF RID: 164319 RVA: 0x00002050 File Offset: 0x00000250
			// (set) Token: 0x060281E0 RID: 164320 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x17005EDF")]
			public Func<string, bool> checkCanSelectItemByStageId
			{
				[Token(Token = "0x60281DF")]
				[Address(RVA = "0x2373720", Offset = "0x2372320", VA = "0x182373720")]
				[CompilerGenerated]
				private get
				{
					return null;
				}
				[Token(Token = "0x60281E0")]
				[Address(RVA = "0x2373850", Offset = "0x2372450", VA = "0x182373850")]
				[CompilerGenerated]
				set
				{
				}
			}

			// Token: 0x17005EE0 RID: 24288
			// (get) Token: 0x060281E1 RID: 164321 RVA: 0x000D0B30 File Offset: 0x000CED30
			[Token(Token = "0x17005EE0")]
			public override int count
			{
				[Token(Token = "0x60281E1")]
				[Address(RVA = "0x2373780", Offset = "0x2372380", VA = "0x182373780", Slot = "4")]
				get
				{
					return 0;
				}
			}

			// Token: 0x060281E2 RID: 164322 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60281E2")]
			[Address(RVA = "0x2372EE0", Offset = "0x2371AE0", VA = "0x182372EE0", Slot = "5")]
			public override GameObject RenderView(int position, GameObject prefab, Transform parent)
			{
				return null;
			}

			// Token: 0x060281E3 RID: 164323 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60281E3")]
			[Address(RVA = "0x2372D60", Offset = "0x2371960", VA = "0x182372D60")]
			public void CollectInputParamForShareModel(List<ActVecBreakV2DefenseStageBaseItem.InputParam> list)
			{
			}

			// Token: 0x060281E4 RID: 164324 RVA: 0x000D0B48 File Offset: 0x000CED48
			[Token(Token = "0x60281E4")]
			[Address(RVA = "0x2373260", Offset = "0x2371E60", VA = "0x182373260")]
			private ActVecBreakV2DefenseStageBaseItem.InputParam _GenerateStageBaseItemInputParam(int position)
			{
				return default(ActVecBreakV2DefenseStageBaseItem.InputParam);
			}

			// Token: 0x060281E5 RID: 164325 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60281E5")]
			[Address(RVA = "0x2373530", Offset = "0x2372130", VA = "0x182373530")]
			private ActVecBreakV2DefenseStageBuffItemModel _GetBuffItemByPosition(int position, out bool useLeftStyle, out bool useRightStyle)
			{
				return null;
			}

			// Token: 0x060281E6 RID: 164326 RVA: 0x000D0B60 File Offset: 0x000CED60
			[Token(Token = "0x60281E6")]
			[Address(RVA = "0x23731B0", Offset = "0x2371DB0", VA = "0x1823731B0")]
			private bool _CheckIfBuffSelected(string buffId)
			{
				return default(bool);
			}

			// Token: 0x060281E7 RID: 164327 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60281E7")]
			[Address(RVA = "0x23736C0", Offset = "0x23722C0", VA = "0x1823736C0")]
			public BuffListAdapter()
			{
			}

			// Token: 0x04038EF4 RID: 233204
			[Token(Token = "0x4038EF4")]
			[FieldOffset(Offset = "0x20")]
			private ActVecBreakV2DefenseBuffListItemModel m_cacheListModel;

			// Token: 0x04038EF5 RID: 233205
			[Token(Token = "0x4038EF5")]
			[FieldOffset(Offset = "0x28")]
			private bool m_isBuffItemList;

			// Token: 0x04038EF6 RID: 233206
			[Token(Token = "0x4038EF6")]
			[FieldOffset(Offset = "0x30")]
			private List<string> m_cacheSelectedBuffIds;

			// Token: 0x04038EF7 RID: 233207
			[Token(Token = "0x4038EF7")]
			[FieldOffset(Offset = "0x38")]
			private Dictionary<string, ActVecBreakV2DefenseStageDetailItemModel> m_cacheStageDetailDict;

			// Token: 0x04038EFA RID: 233210
			[Token(Token = "0x4038EFA")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_set_listModel;

			// Token: 0x04038EFB RID: 233211
			[Token(Token = "0x4038EFB")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_set_selectedBuffIds;

			// Token: 0x04038EFC RID: 233212
			[Token(Token = "0x4038EFC")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_set_stageDetailDict;

			// Token: 0x04038EFD RID: 233213
			[Token(Token = "0x4038EFD")]
			[FieldOffset(Offset = "0x18")]
			private static DelegateBridge __Hotfix0_get_onItemClick;

			// Token: 0x04038EFE RID: 233214
			[Token(Token = "0x4038EFE")]
			[FieldOffset(Offset = "0x20")]
			private static DelegateBridge __Hotfix0_set_onItemClick;

			// Token: 0x04038EFF RID: 233215
			[Token(Token = "0x4038EFF")]
			[FieldOffset(Offset = "0x28")]
			private static DelegateBridge __Hotfix0_get_checkCanSelectItemByStageId;

			// Token: 0x04038F00 RID: 233216
			[Token(Token = "0x4038F00")]
			[FieldOffset(Offset = "0x30")]
			private static DelegateBridge __Hotfix0_set_checkCanSelectItemByStageId;

			// Token: 0x04038F01 RID: 233217
			[Token(Token = "0x4038F01")]
			[FieldOffset(Offset = "0x38")]
			private static DelegateBridge __Hotfix0_get_count;

			// Token: 0x04038F02 RID: 233218
			[Token(Token = "0x4038F02")]
			[FieldOffset(Offset = "0x40")]
			private static DelegateBridge __Hotfix0_RenderView;

			// Token: 0x04038F03 RID: 233219
			[Token(Token = "0x4038F03")]
			[FieldOffset(Offset = "0x48")]
			private static DelegateBridge __Hotfix0_CollectInputParamForShareModel;

			// Token: 0x04038F04 RID: 233220
			[Token(Token = "0x4038F04")]
			[FieldOffset(Offset = "0x50")]
			private static DelegateBridge __Hotfix0__GenerateStageBaseItemInputParam;

			// Token: 0x04038F05 RID: 233221
			[Token(Token = "0x4038F05")]
			[FieldOffset(Offset = "0x58")]
			private static DelegateBridge __Hotfix0__GetBuffItemByPosition;

			// Token: 0x04038F06 RID: 233222
			[Token(Token = "0x4038F06")]
			[FieldOffset(Offset = "0x60")]
			private static DelegateBridge __Hotfix0__CheckIfBuffSelected;

			// Token: 0x04038F07 RID: 233223
			[Token(Token = "0x4038F07")]
			[FieldOffset(Offset = "0x68")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}
	}
}

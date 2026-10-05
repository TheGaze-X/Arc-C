using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.Roguelike.RL04
{
	// Token: 0x02005683 RID: 22147
	[Token(Token = "0x2005683")]
	public class RL04AlchemySlotListView : MonoBehaviour, IHotfixable
	{
		// Token: 0x060207E3 RID: 133091 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60207E3")]
		[Address(RVA = "0x1AA02F0", Offset = "0x1A9EEF0", VA = "0x181AA02F0")]
		public void Render(RL04AlchemySlotListViewModel slotListViewModel)
		{
		}

		// Token: 0x060207E4 RID: 133092 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60207E4")]
		[Address(RVA = "0x1AA0510", Offset = "0x1A9F110", VA = "0x181AA0510")]
		private void _InitIfNot()
		{
		}

		// Token: 0x060207E5 RID: 133093 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60207E5")]
		[Address(RVA = "0x1AA0630", Offset = "0x1A9F230", VA = "0x181AA0630")]
		public RL04AlchemySlotListView()
		{
		}

		// Token: 0x0402C082 RID: 180354
		[Token(Token = "0x402C082")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private SimpleLayoutContent _slotList;

		// Token: 0x0402C083 RID: 180355
		[Token(Token = "0x402C083")]
		[FieldOffset(Offset = "0x20")]
		private bool m_hasInited;

		// Token: 0x0402C084 RID: 180356
		[Token(Token = "0x402C084")]
		[FieldOffset(Offset = "0x28")]
		private RL04AlchemySlotListView.SlotListAdapter m_slotListAdapter;

		// Token: 0x0402C085 RID: 180357
		[Token(Token = "0x402C085")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0402C086 RID: 180358
		[Token(Token = "0x402C086")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0402C087 RID: 180359
		[Token(Token = "0x402C087")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02005684 RID: 22148
		[Token(Token = "0x2005684")]
		private class SlotListAdapter : SimpleLayoutAdapter
		{
			// Token: 0x17004C23 RID: 19491
			// (get) Token: 0x060207E6 RID: 133094 RVA: 0x00002050 File Offset: 0x00000250
			// (set) Token: 0x060207E7 RID: 133095 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x17004C23")]
			public List<RL04AlchemySlotItemViewModel> slotDataList
			{
				[Token(Token = "0x60207E6")]
				[Address(RVA = "0x1AA2530", Offset = "0x1AA1130", VA = "0x181AA2530")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Token(Token = "0x60207E7")]
				[Address(RVA = "0x1AA2590", Offset = "0x1AA1190", VA = "0x181AA2590")]
				[CompilerGenerated]
				set
				{
				}
			}

			// Token: 0x060207E8 RID: 133096 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60207E8")]
			[Address(RVA = "0x1AA23F0", Offset = "0x1AA0FF0", VA = "0x181AA23F0")]
			public SlotListAdapter(RL04AlchemySlotListView view)
			{
			}

			// Token: 0x17004C24 RID: 19492
			// (get) Token: 0x060207E9 RID: 133097 RVA: 0x000B6268 File Offset: 0x000B4468
			[Token(Token = "0x17004C24")]
			public override int count
			{
				[Token(Token = "0x60207E9")]
				[Address(RVA = "0x1AA2470", Offset = "0x1AA1070", VA = "0x181AA2470", Slot = "4")]
				get
				{
					return 0;
				}
			}

			// Token: 0x060207EA RID: 133098 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60207EA")]
			[Address(RVA = "0x1AA2210", Offset = "0x1AA0E10", VA = "0x181AA2210", Slot = "5")]
			public override GameObject RenderView(int position, GameObject prefab, Transform parent)
			{
				return null;
			}

			// Token: 0x0402C088 RID: 180360
			[Token(Token = "0x402C088")]
			[FieldOffset(Offset = "0x20")]
			private RL04AlchemySlotListView m_view;

			// Token: 0x0402C08A RID: 180362
			[Token(Token = "0x402C08A")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_get_slotDataList;

			// Token: 0x0402C08B RID: 180363
			[Token(Token = "0x402C08B")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_set_slotDataList;

			// Token: 0x0402C08C RID: 180364
			[Token(Token = "0x402C08C")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x0402C08D RID: 180365
			[Token(Token = "0x402C08D")]
			[FieldOffset(Offset = "0x18")]
			private static DelegateBridge __Hotfix0_get_count;

			// Token: 0x0402C08E RID: 180366
			[Token(Token = "0x402C08E")]
			[FieldOffset(Offset = "0x20")]
			private static DelegateBridge __Hotfix0_RenderView;
		}
	}
}

using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Torappu.UI;
using UnityEngine;
using XLua;

namespace Torappu.Activity
{
	// Token: 0x02006DB3 RID: 28083
	[Token(Token = "0x2006DB3")]
	public class ActivityCheckinCardSubObjListTool : IHotfixable
	{
		// Token: 0x17005E7C RID: 24188
		// (set) Token: 0x06027FDD RID: 163805 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17005E7C")]
		public SimpleLayoutContent subItemListContainer
		{
			[Token(Token = "0x6027FDD")]
			[Address(RVA = "0x2335440", Offset = "0x2334040", VA = "0x182335440")]
			set
			{
			}
		}

		// Token: 0x06027FDE RID: 163806 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027FDE")]
		[Address(RVA = "0x2334D90", Offset = "0x2333990", VA = "0x182334D90")]
		public void RenderCardSubObjList(ActivityCheckinCardSubObjListTool.SubItemListRenderConfig renderConfig)
		{
		}

		// Token: 0x06027FDF RID: 163807 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027FDF")]
		[Address(RVA = "0x2335240", Offset = "0x2333E40", VA = "0x182335240")]
		private void _InitAdapterIfNot()
		{
		}

		// Token: 0x06027FE0 RID: 163808 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027FE0")]
		[Address(RVA = "0x2335340", Offset = "0x2333F40", VA = "0x182335340")]
		public ActivityCheckinCardSubObjListTool()
		{
		}

		// Token: 0x04038B17 RID: 232215
		[Token(Token = "0x4038B17")]
		[FieldOffset(Offset = "0x0")]
		public static readonly ActivityCheckinCardSubObjListTool.ItemObjConfig ITEM_OBJ_CONFIG_EMPTY;

		// Token: 0x04038B18 RID: 232216
		[Token(Token = "0x4038B18")]
		[FieldOffset(Offset = "0x10")]
		private bool m_hasAdapterInited;

		// Token: 0x04038B19 RID: 232217
		[Token(Token = "0x4038B19")]
		[FieldOffset(Offset = "0x18")]
		private ActivityCheckinCardSubObjListTool.SubItemListAdapter m_adapter;

		// Token: 0x04038B1A RID: 232218
		[Token(Token = "0x4038B1A")]
		[FieldOffset(Offset = "0x20")]
		private SimpleLayoutContent m_subItemListContainer;

		// Token: 0x04038B1B RID: 232219
		[Token(Token = "0x4038B1B")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_set_subItemListContainer;

		// Token: 0x04038B1C RID: 232220
		[Token(Token = "0x4038B1C")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_RenderCardSubObjList;

		// Token: 0x04038B1D RID: 232221
		[Token(Token = "0x4038B1D")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__InitAdapterIfNot;

		// Token: 0x04038B1E RID: 232222
		[Token(Token = "0x4038B1E")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02006DB4 RID: 28084
		[Token(Token = "0x2006DB4")]
		[Serializable]
		public struct ItemObjConfig
		{
			// Token: 0x04038B1F RID: 232223
			[Token(Token = "0x4038B1F")]
			[FieldOffset(Offset = "0x0")]
			public int cardSubObjCount;

			// Token: 0x04038B20 RID: 232224
			[Token(Token = "0x4038B20")]
			[FieldOffset(Offset = "0x4")]
			public float scale;

			// Token: 0x04038B21 RID: 232225
			[Token(Token = "0x4038B21")]
			[FieldOffset(Offset = "0x8")]
			public int preferredHeight;
		}

		// Token: 0x02006DB5 RID: 28085
		[Token(Token = "0x2006DB5")]
		public struct SubItemListRenderConfig
		{
			// Token: 0x04038B22 RID: 232226
			[Token(Token = "0x4038B22")]
			[FieldOffset(Offset = "0x0")]
			public int order;

			// Token: 0x04038B23 RID: 232227
			[Token(Token = "0x4038B23")]
			[FieldOffset(Offset = "0x4")]
			public bool isClickable;

			// Token: 0x04038B24 RID: 232228
			[Token(Token = "0x4038B24")]
			[FieldOffset(Offset = "0x8")]
			public List<ItemBundle> itemList;

			// Token: 0x04038B25 RID: 232229
			[Token(Token = "0x4038B25")]
			[FieldOffset(Offset = "0x10")]
			public ActivityCheckinCardSubObjListTool.ItemObjConfig itemObjConfig;
		}

		// Token: 0x02006DB6 RID: 28086
		[Token(Token = "0x2006DB6")]
		protected class SubItemListAdapter : SimpleLayoutAdapter
		{
			// Token: 0x17005E7D RID: 24189
			// (get) Token: 0x06027FE2 RID: 163810 RVA: 0x00002050 File Offset: 0x00000250
			// (set) Token: 0x06027FE3 RID: 163811 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x17005E7D")]
			public List<ActivityCommonCheckinV2ItemObj.CheckinCardSubObjViewModel> dataSet
			{
				[Token(Token = "0x6027FE2")]
				[Address(RVA = "0x23437B0", Offset = "0x23423B0", VA = "0x1823437B0")]
				[CompilerGenerated]
				private get
				{
					return null;
				}
				[Token(Token = "0x6027FE3")]
				[Address(RVA = "0x2343810", Offset = "0x2342410", VA = "0x182343810")]
				[CompilerGenerated]
				set
				{
				}
			}

			// Token: 0x17005E7E RID: 24190
			// (get) Token: 0x06027FE4 RID: 163812 RVA: 0x000D0470 File Offset: 0x000CE670
			[Token(Token = "0x17005E7E")]
			public override int count
			{
				[Token(Token = "0x6027FE4")]
				[Address(RVA = "0x23436F0", Offset = "0x23422F0", VA = "0x1823436F0", Slot = "4")]
				get
				{
					return 0;
				}
			}

			// Token: 0x06027FE5 RID: 163813 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6027FE5")]
			[Address(RVA = "0x2343480", Offset = "0x2342080", VA = "0x182343480", Slot = "5")]
			public override GameObject RenderView(int position, GameObject prefab, Transform parent)
			{
				return null;
			}

			// Token: 0x06027FE6 RID: 163814 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6027FE6")]
			[Address(RVA = "0x2343690", Offset = "0x2342290", VA = "0x182343690")]
			public SubItemListAdapter()
			{
			}

			// Token: 0x04038B27 RID: 232231
			[Token(Token = "0x4038B27")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_get_dataSet;

			// Token: 0x04038B28 RID: 232232
			[Token(Token = "0x4038B28")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_set_dataSet;

			// Token: 0x04038B29 RID: 232233
			[Token(Token = "0x4038B29")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_get_count;

			// Token: 0x04038B2A RID: 232234
			[Token(Token = "0x4038B2A")]
			[FieldOffset(Offset = "0x18")]
			private static DelegateBridge __Hotfix0_RenderView;

			// Token: 0x04038B2B RID: 232235
			[Token(Token = "0x4038B2B")]
			[FieldOffset(Offset = "0x20")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}
	}
}

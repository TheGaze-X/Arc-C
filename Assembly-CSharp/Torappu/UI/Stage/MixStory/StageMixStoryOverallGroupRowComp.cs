using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Stage.MixStory
{
	// Token: 0x02006A94 RID: 27284
	[Token(Token = "0x2006A94")]
	public class StageMixStoryOverallGroupRowComp : MonoBehaviour, IHotfixable
	{
		// Token: 0x17005C36 RID: 23606
		// (get) Token: 0x06027088 RID: 159880 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17005C36")]
		public RectOffset layoutPadding
		{
			[Token(Token = "0x6027088")]
			[Address(RVA = "0x22416D0", Offset = "0x22402D0", VA = "0x1822416D0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17005C37 RID: 23607
		// (get) Token: 0x06027089 RID: 159881 RVA: 0x000CD518 File Offset: 0x000CB718
		[Token(Token = "0x17005C37")]
		public float layoutSpacing
		{
			[Token(Token = "0x6027089")]
			[Address(RVA = "0x2241740", Offset = "0x2240340", VA = "0x182241740")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x0602708A RID: 159882 RVA: 0x000CD530 File Offset: 0x000CB730
		[Token(Token = "0x602708A")]
		[Address(RVA = "0x2241260", Offset = "0x223FE60", VA = "0x182241260")]
		public float WidthOfStorySetItem(StorylineStorySetType type)
		{
			return 0f;
		}

		// Token: 0x0602708B RID: 159883 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602708B")]
		[Address(RVA = "0x22413F0", Offset = "0x223FFF0", VA = "0x1822413F0")]
		private void _Render(StageMixStoryOverallGroupRowComp.ViewModel model, StageMixStoryOverallItemStateHandler itemStateHandler)
		{
		}

		// Token: 0x0602708C RID: 159884 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602708C")]
		[Address(RVA = "0x22412E0", Offset = "0x223FEE0", VA = "0x1822412E0")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0602708D RID: 159885 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602708D")]
		[Address(RVA = "0x2241670", Offset = "0x2240270", VA = "0x182241670")]
		public StageMixStoryOverallGroupRowComp()
		{
		}

		// Token: 0x040373AD RID: 226221
		[Token(Token = "0x40373AD")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private float _height;

		// Token: 0x040373AE RID: 226222
		[Token(Token = "0x40373AE")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private HorizontalLayoutGroup _layoutGroup;

		// Token: 0x040373AF RID: 226223
		[Token(Token = "0x40373AF")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private SimpleLayoutContent _layoutContent;

		// Token: 0x040373B0 RID: 226224
		[Token(Token = "0x40373B0")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private StageMixStoryOverallGroupItemView _itemView;

		// Token: 0x040373B1 RID: 226225
		[Token(Token = "0x40373B1")]
		[FieldOffset(Offset = "0x38")]
		private bool m_hasInited;

		// Token: 0x040373B2 RID: 226226
		[Token(Token = "0x40373B2")]
		[FieldOffset(Offset = "0x40")]
		private StageMixStoryOverallGroupRowComp.Adapter m_adapter;

		// Token: 0x040373B3 RID: 226227
		[Token(Token = "0x40373B3")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_layoutPadding;

		// Token: 0x040373B4 RID: 226228
		[Token(Token = "0x40373B4")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_layoutSpacing;

		// Token: 0x040373B5 RID: 226229
		[Token(Token = "0x40373B5")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_WidthOfStorySetItem;

		// Token: 0x040373B6 RID: 226230
		[Token(Token = "0x40373B6")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__Render;

		// Token: 0x040373B7 RID: 226231
		[Token(Token = "0x40373B7")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x040373B8 RID: 226232
		[Token(Token = "0x40373B8")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02006A95 RID: 27285
		[Token(Token = "0x2006A95")]
		public class ViewModel
		{
			// Token: 0x0602708E RID: 159886 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602708E")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public ViewModel()
			{
			}

			// Token: 0x040373B9 RID: 226233
			[Token(Token = "0x40373B9")]
			[FieldOffset(Offset = "0x10")]
			public StageMixStoryOverallGroupRowComp prefab;

			// Token: 0x040373BA RID: 226234
			[Token(Token = "0x40373BA")]
			[FieldOffset(Offset = "0x18")]
			public List<StageStorylineStorySetViewModel> items;
		}

		// Token: 0x02006A96 RID: 27286
		[Token(Token = "0x2006A96")]
		public class VirtualView : UIRecycleLayoutAdapter.VirtualView<StageMixStoryOverallGroupRowComp>
		{
			// Token: 0x17005C38 RID: 23608
			// (get) Token: 0x0602708F RID: 159887 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17005C38")]
			public StageMixStoryOverallGroupRowComp.ViewModel model
			{
				[Token(Token = "0x602708F")]
				[Address(RVA = "0x2249920", Offset = "0x2248520", VA = "0x182249920")]
				get
				{
					return null;
				}
			}

			// Token: 0x06027090 RID: 159888 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6027090")]
			[Address(RVA = "0x22497E0", Offset = "0x22483E0", VA = "0x1822497E0")]
			public VirtualView(StageMixStoryOverallView mainView, StageMixStoryOverallGroupRowComp.ViewModel model)
			{
			}

			// Token: 0x06027091 RID: 159889 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6027091")]
			[Address(RVA = "0x2249590", Offset = "0x2248190", VA = "0x182249590", Slot = "10")]
			protected override void OnViewAttached()
			{
			}

			// Token: 0x06027092 RID: 159890 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6027092")]
			[Address(RVA = "0x2249720", Offset = "0x2248320", VA = "0x182249720", Slot = "11")]
			protected override void OnViewDetached()
			{
			}

			// Token: 0x06027093 RID: 159891 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6027093")]
			[Address(RVA = "0x2249400", Offset = "0x2248000", VA = "0x182249400", Slot = "12")]
			public override GameObject GetPrefab()
			{
				return null;
			}

			// Token: 0x06027094 RID: 159892 RVA: 0x000CD548 File Offset: 0x000CB748
			[Token(Token = "0x6027094")]
			[Address(RVA = "0x22494B0", Offset = "0x22480B0", VA = "0x1822494B0", Slot = "13")]
			public override float GetPreferSize()
			{
				return 0f;
			}

			// Token: 0x040373BB RID: 226235
			[Token(Token = "0x40373BB")]
			[FieldOffset(Offset = "0x20")]
			private readonly StageMixStoryOverallView m_mainView;

			// Token: 0x040373BC RID: 226236
			[Token(Token = "0x40373BC")]
			[FieldOffset(Offset = "0x28")]
			private readonly StageMixStoryOverallGroupRowComp.ViewModel m_model;

			// Token: 0x040373BD RID: 226237
			[Token(Token = "0x40373BD")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_get_model;

			// Token: 0x040373BE RID: 226238
			[Token(Token = "0x40373BE")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x040373BF RID: 226239
			[Token(Token = "0x40373BF")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_OnViewAttached;

			// Token: 0x040373C0 RID: 226240
			[Token(Token = "0x40373C0")]
			[FieldOffset(Offset = "0x18")]
			private static DelegateBridge __Hotfix0_OnViewDetached;

			// Token: 0x040373C1 RID: 226241
			[Token(Token = "0x40373C1")]
			[FieldOffset(Offset = "0x20")]
			private static DelegateBridge __Hotfix0_GetPrefab;

			// Token: 0x040373C2 RID: 226242
			[Token(Token = "0x40373C2")]
			[FieldOffset(Offset = "0x28")]
			private static DelegateBridge __Hotfix0_GetPreferSize;
		}

		// Token: 0x02006A97 RID: 27287
		[Token(Token = "0x2006A97")]
		private class Adapter : SimpleLayoutAdapter
		{
			// Token: 0x17005C39 RID: 23609
			// (get) Token: 0x06027095 RID: 159893 RVA: 0x00002050 File Offset: 0x00000250
			// (set) Token: 0x06027096 RID: 159894 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x17005C39")]
			public List<StageStorylineStorySetViewModel> source
			{
				[Token(Token = "0x6027095")]
				[Address(RVA = "0x2236700", Offset = "0x2235300", VA = "0x182236700")]
				[CompilerGenerated]
				private get
				{
					return null;
				}
				[Token(Token = "0x6027096")]
				[Address(RVA = "0x2236860", Offset = "0x2235460", VA = "0x182236860")]
				[CompilerGenerated]
				set
				{
				}
			}

			// Token: 0x17005C3A RID: 23610
			// (get) Token: 0x06027097 RID: 159895 RVA: 0x00002050 File Offset: 0x00000250
			// (set) Token: 0x06027098 RID: 159896 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x17005C3A")]
			public StageMixStoryOverallItemStateHandler itemStateHandler
			{
				[Token(Token = "0x6027097")]
				[Address(RVA = "0x22366A0", Offset = "0x22352A0", VA = "0x1822366A0")]
				[CompilerGenerated]
				private get
				{
					return null;
				}
				[Token(Token = "0x6027098")]
				[Address(RVA = "0x22367E0", Offset = "0x22353E0", VA = "0x1822367E0")]
				[CompilerGenerated]
				set
				{
				}
			}

			// Token: 0x17005C3B RID: 23611
			// (get) Token: 0x06027099 RID: 159897 RVA: 0x000CD560 File Offset: 0x000CB760
			[Token(Token = "0x17005C3B")]
			public override int count
			{
				[Token(Token = "0x6027099")]
				[Address(RVA = "0x2236580", Offset = "0x2235180", VA = "0x182236580", Slot = "4")]
				get
				{
					return 0;
				}
			}

			// Token: 0x0602709A RID: 159898 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x602709A")]
			[Address(RVA = "0x2235E00", Offset = "0x2234A00", VA = "0x182235E00", Slot = "5")]
			public override GameObject RenderView(int position, GameObject prefab, Transform parent)
			{
				return null;
			}

			// Token: 0x0602709B RID: 159899 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602709B")]
			[Address(RVA = "0x2236380", Offset = "0x2234F80", VA = "0x182236380")]
			public Adapter()
			{
			}

			// Token: 0x040373C3 RID: 226243
			[Token(Token = "0x40373C3")]
			[FieldOffset(Offset = "0x20")]
			private int m_count;

			// Token: 0x040373C6 RID: 226246
			[Token(Token = "0x40373C6")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_get_source;

			// Token: 0x040373C7 RID: 226247
			[Token(Token = "0x40373C7")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_set_source;

			// Token: 0x040373C8 RID: 226248
			[Token(Token = "0x40373C8")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_get_itemStateHandler;

			// Token: 0x040373C9 RID: 226249
			[Token(Token = "0x40373C9")]
			[FieldOffset(Offset = "0x18")]
			private static DelegateBridge __Hotfix0_set_itemStateHandler;

			// Token: 0x040373CA RID: 226250
			[Token(Token = "0x40373CA")]
			[FieldOffset(Offset = "0x20")]
			private static DelegateBridge __Hotfix0_get_count;

			// Token: 0x040373CB RID: 226251
			[Token(Token = "0x40373CB")]
			[FieldOffset(Offset = "0x28")]
			private static DelegateBridge __Hotfix0_RenderView;

			// Token: 0x040373CC RID: 226252
			[Token(Token = "0x40373CC")]
			[FieldOffset(Offset = "0x30")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}
	}
}

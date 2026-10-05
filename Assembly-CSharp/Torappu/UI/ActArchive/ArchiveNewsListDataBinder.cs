using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using AdvancedInspector;
using Il2CppDummyDll;
using Torappu.DataBind;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.ActArchive
{
	// Token: 0x02006BC4 RID: 27588
	[Token(Token = "0x2006BC4")]
	public class ArchiveNewsListDataBinder : DataBinder<NewsProperty>
	{
		// Token: 0x17005D08 RID: 23816
		// (get) Token: 0x0602766B RID: 161387 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0602766C RID: 161388 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17005D08")]
		public ArchiveNewsController controller
		{
			[Token(Token = "0x602766B")]
			[Address(RVA = "0x2296F00", Offset = "0x2295B00", VA = "0x182296F00")]
			private get
			{
				return null;
			}
			[Token(Token = "0x602766C")]
			[Address(RVA = "0x2296F60", Offset = "0x2295B60", VA = "0x182296F60")]
			set
			{
			}
		}

		// Token: 0x0602766D RID: 161389 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602766D")]
		[Address(RVA = "0x2296120", Offset = "0x2294D20", VA = "0x182296120", Slot = "7")]
		public override void OnValueChanged(NewsProperty property)
		{
		}

		// Token: 0x0602766E RID: 161390 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602766E")]
		[Address(RVA = "0x22963D0", Offset = "0x2294FD0", VA = "0x1822963D0")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0602766F RID: 161391 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602766F")]
		[Address(RVA = "0x22964F0", Offset = "0x22950F0", VA = "0x1822964F0")]
		private void _RefreshLeftContent()
		{
		}

		// Token: 0x06027670 RID: 161392 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027670")]
		[Address(RVA = "0x2296920", Offset = "0x2295520", VA = "0x182296920")]
		private void _RenderDetail(NewsItemModel itemModel, ArchiveNewsModel newsModel)
		{
		}

		// Token: 0x06027671 RID: 161393 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027671")]
		[Address(RVA = "0x22962D0", Offset = "0x2294ED0", VA = "0x1822962D0")]
		private void _ClearContent()
		{
		}

		// Token: 0x06027672 RID: 161394 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6027672")]
		[Address(RVA = "0x2296040", Offset = "0x2294C40", VA = "0x182296040")]
		public IEnumerator FocusOnSelectedItem(bool fastMode, float duration)
		{
			return null;
		}

		// Token: 0x06027673 RID: 161395 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027673")]
		[Address(RVA = "0x2296E10", Offset = "0x2295A10", VA = "0x182296E10")]
		public ArchiveNewsListDataBinder()
		{
		}

		// Token: 0x04037D20 RID: 228640
		[Token(Token = "0x4037D20")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private AutoFocusScrollView _scrollView;

		// Token: 0x04037D21 RID: 228641
		[Token(Token = "0x4037D21")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private SimpleLayoutContent _viewContainer;

		// Token: 0x04037D22 RID: 228642
		[Token(Token = "0x4037D22")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Image _imgBorderBg;

		// Token: 0x04037D23 RID: 228643
		[Token(Token = "0x4037D23")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Image _imgBorderTitle;

		// Token: 0x04037D24 RID: 228644
		[Token(Token = "0x4037D24")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Image _imgMainTitle;

		// Token: 0x04037D25 RID: 228645
		[Token(Token = "0x4037D25")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private ScrollRect _detailContent;

		// Token: 0x04037D26 RID: 228646
		[Token(Token = "0x4037D26")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		[Group("Detail View")]
		private ArchiveNewsDetailObjView _titleObj;

		// Token: 0x04037D27 RID: 228647
		[Token(Token = "0x4037D27")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		[Group("Detail View")]
		private ArchiveNewsDetailObjView _textObj;

		// Token: 0x04037D28 RID: 228648
		[Token(Token = "0x4037D28")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		[Group("Detail View")]
		private ArchiveNewsDetailObjView _imgObj;

		// Token: 0x04037D29 RID: 228649
		[Token(Token = "0x4037D29")]
		[FieldOffset(Offset = "0x68")]
		private bool m_hasInited;

		// Token: 0x04037D2A RID: 228650
		[Token(Token = "0x4037D2A")]
		[FieldOffset(Offset = "0x70")]
		private string m_cachedNewsItem;

		// Token: 0x04037D2B RID: 228651
		[Token(Token = "0x4037D2B")]
		[FieldOffset(Offset = "0x78")]
		private ArchiveNewsListDataBinder.ArchiveNewsListAdapter m_listAdapter;

		// Token: 0x04037D2C RID: 228652
		[Token(Token = "0x4037D2C")]
		[FieldOffset(Offset = "0x80")]
		private ArchiveNewsController m_controller;

		// Token: 0x04037D2D RID: 228653
		[Token(Token = "0x4037D2D")]
		[FieldOffset(Offset = "0x88")]
		private ArchiveNewsModel m_cachedModel;

		// Token: 0x04037D2E RID: 228654
		[Token(Token = "0x4037D2E")]
		[FieldOffset(Offset = "0x90")]
		private string m_cachedNewsType;

		// Token: 0x04037D2F RID: 228655
		[Token(Token = "0x4037D2F")]
		[FieldOffset(Offset = "0x98")]
		private string m_cachedNewsId;

		// Token: 0x04037D30 RID: 228656
		[Token(Token = "0x4037D30")]
		[FieldOffset(Offset = "0xA0")]
		private Dictionary<string, Sprite> m_cachedSprites;

		// Token: 0x04037D31 RID: 228657
		[Token(Token = "0x4037D31")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_controller;

		// Token: 0x04037D32 RID: 228658
		[Token(Token = "0x4037D32")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_controller;

		// Token: 0x04037D33 RID: 228659
		[Token(Token = "0x4037D33")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnValueChanged;

		// Token: 0x04037D34 RID: 228660
		[Token(Token = "0x4037D34")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x04037D35 RID: 228661
		[Token(Token = "0x4037D35")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__RefreshLeftContent;

		// Token: 0x04037D36 RID: 228662
		[Token(Token = "0x4037D36")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__RenderDetail;

		// Token: 0x04037D37 RID: 228663
		[Token(Token = "0x4037D37")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__ClearContent;

		// Token: 0x04037D38 RID: 228664
		[Token(Token = "0x4037D38")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_FocusOnSelectedItem;

		// Token: 0x04037D39 RID: 228665
		[Token(Token = "0x4037D39")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02006BC5 RID: 27589
		[Token(Token = "0x2006BC5")]
		public class ArchiveNewsListAdapter : SimpleLayoutAdapter, IHotfixable
		{
			// Token: 0x17005D09 RID: 23817
			// (get) Token: 0x06027674 RID: 161396 RVA: 0x00002050 File Offset: 0x00000250
			// (set) Token: 0x06027675 RID: 161397 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x17005D09")]
			public ListDict<string, NewsItemModel> dataSet
			{
				[Token(Token = "0x6027674")]
				[Address(RVA = "0x2295F60", Offset = "0x2294B60", VA = "0x182295F60")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Token(Token = "0x6027675")]
				[Address(RVA = "0x2295FC0", Offset = "0x2294BC0", VA = "0x182295FC0")]
				[CompilerGenerated]
				set
				{
				}
			}

			// Token: 0x17005D0A RID: 23818
			// (get) Token: 0x06027676 RID: 161398 RVA: 0x000CE508 File Offset: 0x000CC708
			[Token(Token = "0x17005D0A")]
			public override int count
			{
				[Token(Token = "0x6027676")]
				[Address(RVA = "0x2295EA0", Offset = "0x2294AA0", VA = "0x182295EA0", Slot = "4")]
				get
				{
					return 0;
				}
			}

			// Token: 0x06027677 RID: 161399 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6027677")]
			[Address(RVA = "0x2295E20", Offset = "0x2294A20", VA = "0x182295E20")]
			public ArchiveNewsListAdapter(ArchiveNewsListDataBinder closure)
			{
			}

			// Token: 0x06027678 RID: 161400 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6027678")]
			[Address(RVA = "0x2295B30", Offset = "0x2294730", VA = "0x182295B30", Slot = "5")]
			public override GameObject RenderView(int position, GameObject prefab, Transform parent)
			{
				return null;
			}

			// Token: 0x04037D3A RID: 228666
			[Token(Token = "0x4037D3A")]
			[FieldOffset(Offset = "0x20")]
			private ArchiveNewsListDataBinder m_closure;

			// Token: 0x04037D3C RID: 228668
			[Token(Token = "0x4037D3C")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_get_dataSet;

			// Token: 0x04037D3D RID: 228669
			[Token(Token = "0x4037D3D")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_set_dataSet;

			// Token: 0x04037D3E RID: 228670
			[Token(Token = "0x4037D3E")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_get_count;

			// Token: 0x04037D3F RID: 228671
			[Token(Token = "0x4037D3F")]
			[FieldOffset(Offset = "0x18")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x04037D40 RID: 228672
			[Token(Token = "0x4037D40")]
			[FieldOffset(Offset = "0x20")]
			private static DelegateBridge __Hotfix0_RenderView;
		}
	}
}

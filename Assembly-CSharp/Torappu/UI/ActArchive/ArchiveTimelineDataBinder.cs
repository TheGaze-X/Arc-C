using System;
using System.Collections;
using Il2CppDummyDll;
using Torappu.DataBind;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.ActArchive
{
	// Token: 0x02006C2F RID: 27695
	[Token(Token = "0x2006C2F")]
	public class ArchiveTimelineDataBinder : DataBinder<TimelineProperty>
	{
		// Token: 0x0602789A RID: 161946 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602789A")]
		[Address(RVA = "0x22B76F0", Offset = "0x22B62F0", VA = "0x1822B76F0")]
		private void _InitIfNot()
		{
		}

		// Token: 0x17005D52 RID: 23890
		// (get) Token: 0x0602789B RID: 161947 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0602789C RID: 161948 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17005D52")]
		public ArchiveTimelineController controller
		{
			[Token(Token = "0x602789B")]
			[Address(RVA = "0x22B78D0", Offset = "0x22B64D0", VA = "0x1822B78D0")]
			get
			{
				return null;
			}
			[Token(Token = "0x602789C")]
			[Address(RVA = "0x22B7930", Offset = "0x22B6530", VA = "0x1822B7930")]
			set
			{
			}
		}

		// Token: 0x0602789D RID: 161949 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602789D")]
		[Address(RVA = "0x22B7480", Offset = "0x22B6080", VA = "0x1822B7480", Slot = "7")]
		public override void OnValueChanged(TimelineProperty property)
		{
		}

		// Token: 0x0602789E RID: 161950 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602789E")]
		[Address(RVA = "0x22B73A0", Offset = "0x22B5FA0", VA = "0x1822B73A0")]
		public IEnumerator FocusOnLastUncheckedItem(bool fastMode, float duration)
		{
			return null;
		}

		// Token: 0x0602789F RID: 161951 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602789F")]
		[Address(RVA = "0x22B7860", Offset = "0x22B6460", VA = "0x1822B7860")]
		public ArchiveTimelineDataBinder()
		{
		}

		// Token: 0x040380E9 RID: 229609
		[Token(Token = "0x40380E9")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private SimpleLayoutContent _viewContainer;

		// Token: 0x040380EA RID: 229610
		[Token(Token = "0x40380EA")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Image _imgBkg;

		// Token: 0x040380EB RID: 229611
		[Token(Token = "0x40380EB")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private AutoFocusScrollView _scrollView;

		// Token: 0x040380EC RID: 229612
		[Token(Token = "0x40380EC")]
		[FieldOffset(Offset = "0x38")]
		private ArchiveTimelineDataBinder.ArchiveTimelineAdapter m_listAdapter;

		// Token: 0x040380ED RID: 229613
		[Token(Token = "0x40380ED")]
		[FieldOffset(Offset = "0x40")]
		private ArchiveTimelineModel m_cachedModel;

		// Token: 0x040380EE RID: 229614
		[Token(Token = "0x40380EE")]
		[FieldOffset(Offset = "0x48")]
		private bool m_hasInited;

		// Token: 0x040380EF RID: 229615
		[Token(Token = "0x40380EF")]
		[FieldOffset(Offset = "0x50")]
		private ArchiveTimelineController m_controller;

		// Token: 0x040380F0 RID: 229616
		[Token(Token = "0x40380F0")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x040380F1 RID: 229617
		[Token(Token = "0x40380F1")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_controller;

		// Token: 0x040380F2 RID: 229618
		[Token(Token = "0x40380F2")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_set_controller;

		// Token: 0x040380F3 RID: 229619
		[Token(Token = "0x40380F3")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnValueChanged;

		// Token: 0x040380F4 RID: 229620
		[Token(Token = "0x40380F4")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_FocusOnLastUncheckedItem;

		// Token: 0x040380F5 RID: 229621
		[Token(Token = "0x40380F5")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02006C30 RID: 27696
		[Token(Token = "0x2006C30")]
		public class ArchiveTimelineAdapter : SimpleLayoutAdapter, IHotfixable
		{
			// Token: 0x17005D53 RID: 23891
			// (get) Token: 0x060278A0 RID: 161952 RVA: 0x000CEA78 File Offset: 0x000CCC78
			[Token(Token = "0x17005D53")]
			public override int count
			{
				[Token(Token = "0x60278A0")]
				[Address(RVA = "0x22B67D0", Offset = "0x22B53D0", VA = "0x1822B67D0", Slot = "4")]
				get
				{
					return 0;
				}
			}

			// Token: 0x060278A1 RID: 161953 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60278A1")]
			[Address(RVA = "0x22B6700", Offset = "0x22B5300", VA = "0x1822B6700")]
			public ArchiveTimelineAdapter(ArchiveTimelineDataBinder closure)
			{
			}

			// Token: 0x060278A2 RID: 161954 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60278A2")]
			[Address(RVA = "0x22B63C0", Offset = "0x22B4FC0", VA = "0x1822B63C0", Slot = "5")]
			public override GameObject RenderView(int position, GameObject prefab, Transform parent)
			{
				return null;
			}

			// Token: 0x040380F6 RID: 229622
			[Token(Token = "0x40380F6")]
			[FieldOffset(Offset = "0x20")]
			private ArchiveTimelineDataBinder m_closure;

			// Token: 0x040380F7 RID: 229623
			[Token(Token = "0x40380F7")]
			[FieldOffset(Offset = "0x28")]
			public ListDict<string, TimelineItemModel> timelineItemList;

			// Token: 0x040380F8 RID: 229624
			[Token(Token = "0x40380F8")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_get_count;

			// Token: 0x040380F9 RID: 229625
			[Token(Token = "0x40380F9")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x040380FA RID: 229626
			[Token(Token = "0x40380FA")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_RenderView;
		}
	}
}

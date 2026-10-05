using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.ActArchive
{
	// Token: 0x02006B78 RID: 27512
	[Token(Token = "0x2006B78")]
	public class ArchiveEndbookEntryPickerView : MonoBehaviour, IHotfixable
	{
		// Token: 0x060274F3 RID: 161011 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60274F3")]
		[Address(RVA = "0x227F400", Offset = "0x227E000", VA = "0x18227F400")]
		public void Render(ArchiveEndbookPickerViewModel pickerViewModel, bool isInit)
		{
		}

		// Token: 0x060274F4 RID: 161012 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60274F4")]
		[Address(RVA = "0x227F570", Offset = "0x227E170", VA = "0x18227F570")]
		private void Update()
		{
		}

		// Token: 0x060274F5 RID: 161013 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60274F5")]
		[Address(RVA = "0x227F650", Offset = "0x227E250", VA = "0x18227F650")]
		private void _InitIfNot()
		{
		}

		// Token: 0x060274F6 RID: 161014 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60274F6")]
		[Address(RVA = "0x227F930", Offset = "0x227E530", VA = "0x18227F930")]
		private void _InitViewPager()
		{
		}

		// Token: 0x060274F7 RID: 161015 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60274F7")]
		[Address(RVA = "0x227FC60", Offset = "0x227E860", VA = "0x18227FC60")]
		private void _OnScrollPagerStateChanged(InertiaScrollViewPager.State state)
		{
		}

		// Token: 0x060274F8 RID: 161016 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60274F8")]
		[Address(RVA = "0x227FBD0", Offset = "0x227E7D0", VA = "0x18227FBD0")]
		private void _OnPageChangeEnd(float index)
		{
		}

		// Token: 0x060274F9 RID: 161017 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60274F9")]
		[Address(RVA = "0x227FDF0", Offset = "0x227E9F0", VA = "0x18227FDF0")]
		private void _OnpageChangeBegin(float index)
		{
		}

		// Token: 0x060274FA RID: 161018 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60274FA")]
		[Address(RVA = "0x227FAC0", Offset = "0x227E6C0", VA = "0x18227FAC0")]
		private void _OnItemClick(int index)
		{
		}

		// Token: 0x060274FB RID: 161019 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60274FB")]
		[Address(RVA = "0x227FE70", Offset = "0x227EA70", VA = "0x18227FE70")]
		public ArchiveEndbookEntryPickerView()
		{
		}

		// Token: 0x04037AB8 RID: 228024
		[Token(Token = "0x4037AB8")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private InertiaScrollViewPager _viewPager;

		// Token: 0x04037AB9 RID: 228025
		[Token(Token = "0x4037AB9")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private UIRecycleLayoutGroup _content;

		// Token: 0x04037ABA RID: 228026
		[Token(Token = "0x4037ABA")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private ArchiveEndbookEntryItemView _itemPrefab;

		// Token: 0x04037ABB RID: 228027
		[Token(Token = "0x4037ABB")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		[HideInInspector]
		private float _minFlingSpd;

		// Token: 0x04037ABC RID: 228028
		[Token(Token = "0x4037ABC")]
		[FieldOffset(Offset = "0x34")]
		[SerializeField]
		[HideInInspector]
		private float _maxFlingSpd;

		// Token: 0x04037ABD RID: 228029
		[Token(Token = "0x4037ABD")]
		[FieldOffset(Offset = "0x38")]
		private bool m_isInited;

		// Token: 0x04037ABE RID: 228030
		[Token(Token = "0x4037ABE")]
		[FieldOffset(Offset = "0x40")]
		private ArchiveEndbookEntryPickerView.PagerAdapter m_adapter;

		// Token: 0x04037ABF RID: 228031
		[Token(Token = "0x4037ABF")]
		[FieldOffset(Offset = "0x48")]
		private int m_cachedIndex;

		// Token: 0x04037AC0 RID: 228032
		[Token(Token = "0x4037AC0")]
		[FieldOffset(Offset = "0x50")]
		private List<int> m_maxAttainableFrameList;

		// Token: 0x04037AC1 RID: 228033
		[Token(Token = "0x4037AC1")]
		[FieldOffset(Offset = "0x58")]
		private ArchiveEndbookPickerViewModel m_cachedViewModel;

		// Token: 0x04037AC2 RID: 228034
		[Token(Token = "0x4037AC2")]
		[FieldOffset(Offset = "0x60")]
		[NonSerialized]
		public Action<int> onIndexUpdate;

		// Token: 0x04037AC3 RID: 228035
		[Token(Token = "0x4037AC3")]
		[FieldOffset(Offset = "0x68")]
		[NonSerialized]
		public Action<int> onIndexConfirm;

		// Token: 0x04037AC4 RID: 228036
		[Token(Token = "0x4037AC4")]
		[FieldOffset(Offset = "0x70")]
		[NonSerialized]
		public Action<string> onItemClick;

		// Token: 0x04037AC5 RID: 228037
		[Token(Token = "0x4037AC5")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x04037AC6 RID: 228038
		[Token(Token = "0x4037AC6")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_Update;

		// Token: 0x04037AC7 RID: 228039
		[Token(Token = "0x4037AC7")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x04037AC8 RID: 228040
		[Token(Token = "0x4037AC8")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__InitViewPager;

		// Token: 0x04037AC9 RID: 228041
		[Token(Token = "0x4037AC9")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__OnScrollPagerStateChanged;

		// Token: 0x04037ACA RID: 228042
		[Token(Token = "0x4037ACA")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__OnPageChangeEnd;

		// Token: 0x04037ACB RID: 228043
		[Token(Token = "0x4037ACB")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__OnpageChangeBegin;

		// Token: 0x04037ACC RID: 228044
		[Token(Token = "0x4037ACC")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__OnItemClick;

		// Token: 0x04037ACD RID: 228045
		[Token(Token = "0x4037ACD")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02006B79 RID: 27513
		[Token(Token = "0x2006B79")]
		private class PagerAdapter : UIRecycleLayoutAdapter
		{
			// Token: 0x060274FC RID: 161020 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60274FC")]
			[Address(RVA = "0x228EBE0", Offset = "0x228D7E0", VA = "0x18228EBE0")]
			public PagerAdapter(ArchiveEndbookEntryPickerView closure)
			{
			}

			// Token: 0x060274FD RID: 161021 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60274FD")]
			[Address(RVA = "0x228E800", Offset = "0x228D400", VA = "0x18228E800")]
			public void RebuildList(ArchiveEndbookPickerViewModel pickerViewModel, float focusedPage)
			{
			}

			// Token: 0x060274FE RID: 161022 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60274FE")]
			[Address(RVA = "0x228E3F0", Offset = "0x228CFF0", VA = "0x18228E3F0")]
			public void NotifyFocusPage(float pageIndex)
			{
			}

			// Token: 0x060274FF RID: 161023 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60274FF")]
			[Address(RVA = "0x228E600", Offset = "0x228D200", VA = "0x18228E600")]
			public void NotifyFocusUnstable(float pageIndex)
			{
			}

			// Token: 0x06027500 RID: 161024 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6027500")]
			[Address(RVA = "0x228E2C0", Offset = "0x228CEC0", VA = "0x18228E2C0", Slot = "4")]
			public override IList<UIRecycleLayoutAdapter.IVirtualView> GenerateViewsForRebuild()
			{
				return null;
			}

			// Token: 0x04037ACE RID: 228046
			[Token(Token = "0x4037ACE")]
			[FieldOffset(Offset = "0x18")]
			private ArchiveEndbookEntryPickerView m_closure;

			// Token: 0x04037ACF RID: 228047
			[Token(Token = "0x4037ACF")]
			[FieldOffset(Offset = "0x20")]
			private float m_focusPageIndex;

			// Token: 0x04037AD0 RID: 228048
			[Token(Token = "0x4037AD0")]
			[FieldOffset(Offset = "0x28")]
			private string m_curWidgetID;

			// Token: 0x04037AD1 RID: 228049
			[Token(Token = "0x4037AD1")]
			[FieldOffset(Offset = "0x30")]
			private List<ArchiveEndbookEntryItemView.VirtualView> m_cells;

			// Token: 0x04037AD2 RID: 228050
			[Token(Token = "0x4037AD2")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x04037AD3 RID: 228051
			[Token(Token = "0x4037AD3")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_RebuildList;

			// Token: 0x04037AD4 RID: 228052
			[Token(Token = "0x4037AD4")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_NotifyFocusPage;

			// Token: 0x04037AD5 RID: 228053
			[Token(Token = "0x4037AD5")]
			[FieldOffset(Offset = "0x18")]
			private static DelegateBridge __Hotfix0_NotifyFocusUnstable;

			// Token: 0x04037AD6 RID: 228054
			[Token(Token = "0x4037AD6")]
			[FieldOffset(Offset = "0x20")]
			private static DelegateBridge __Hotfix0_GenerateViewsForRebuild;
		}
	}
}

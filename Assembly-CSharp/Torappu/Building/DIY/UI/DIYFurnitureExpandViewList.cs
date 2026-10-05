using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Torappu.DataBind;
using Torappu.UI;
using UnityEngine;
using XLua;

namespace Torappu.Building.DIY.UI
{
	// Token: 0x02001984 RID: 6532
	[Token(Token = "0x2001984")]
	public class DIYFurnitureExpandViewList : DataBinder<DIYViewListProperty>
	{
		// Token: 0x170012F7 RID: 4855
		// (get) Token: 0x0600A3E1 RID: 41953 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600A3E2 RID: 41954 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170012F7")]
		public DIYListViewState bindState
		{
			[Token(Token = "0x600A3E1")]
			[Address(RVA = "0x31DB2F0", Offset = "0x31D9EF0", VA = "0x1831DB2F0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600A3E2")]
			[Address(RVA = "0x31DB350", Offset = "0x31D9F50", VA = "0x1831DB350")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x0600A3E3 RID: 41955 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A3E3")]
		[Address(RVA = "0x31DB140", Offset = "0x31D9D40", VA = "0x1831DB140")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0600A3E4 RID: 41956 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A3E4")]
		[Address(RVA = "0x31DABB0", Offset = "0x31D97B0", VA = "0x1831DABB0")]
		public void OnEnter()
		{
		}

		// Token: 0x0600A3E5 RID: 41957 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A3E5")]
		[Address(RVA = "0x31DAEA0", Offset = "0x31D9AA0", VA = "0x1831DAEA0", Slot = "7")]
		public override void OnValueChanged(DIYViewListProperty property)
		{
		}

		// Token: 0x0600A3E6 RID: 41958 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A3E6")]
		[Address(RVA = "0x31DADB0", Offset = "0x31D99B0", VA = "0x1831DADB0")]
		public void OnSortMethodClicked()
		{
		}

		// Token: 0x0600A3E7 RID: 41959 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A3E7")]
		[Address(RVA = "0x31DB280", Offset = "0x31D9E80", VA = "0x1831DB280")]
		public DIYFurnitureExpandViewList()
		{
		}

		// Token: 0x04009ABD RID: 39613
		[Token(Token = "0x4009ABD")]
		private const int BKG_HEIGHT_NORMAL = 275;

		// Token: 0x04009ABE RID: 39614
		[Token(Token = "0x4009ABE")]
		private const int BKG_HEIGHT_EXPAND = 610;

		// Token: 0x04009ABF RID: 39615
		[Token(Token = "0x4009ABF")]
		private const float EXPAND_DURATION = 0.16f;

		// Token: 0x04009AC0 RID: 39616
		[Token(Token = "0x4009AC0")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private RectTransform _panelBackGround;

		// Token: 0x04009AC1 RID: 39617
		[Token(Token = "0x4009AC1")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private RectTransform _panelExpandBackGroundMask;

		// Token: 0x04009AC2 RID: 39618
		[Token(Token = "0x4009AC2")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private DIYFurniturePanelSort _sortPanel;

		// Token: 0x04009AC3 RID: 39619
		[Token(Token = "0x4009AC3")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private DIYViewListGroup _viewListGroup;

		// Token: 0x04009AC4 RID: 39620
		[Token(Token = "0x4009AC4")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private DIYViewListGroup _viewListThemeGroup;

		// Token: 0x04009AC5 RID: 39621
		[Token(Token = "0x4009AC5")]
		[FieldOffset(Offset = "0x48")]
		private bool m_isInit;

		// Token: 0x04009AC6 RID: 39622
		[Token(Token = "0x4009AC6")]
		[FieldOffset(Offset = "0x50")]
		private DIYFurnitureExpandViewList.ExpandSwitchTween m_expandSwitchTween;

		// Token: 0x04009AC7 RID: 39623
		[Token(Token = "0x4009AC7")]
		[FieldOffset(Offset = "0x58")]
		private DIYViewListGroup m_currViewListGroup;

		// Token: 0x04009AC8 RID: 39624
		[Token(Token = "0x4009AC8")]
		[FieldOffset(Offset = "0x60")]
		private DIYViewListModel.UIExpandListState m_cachedExpandListState;

		// Token: 0x04009AC9 RID: 39625
		[Token(Token = "0x4009AC9")]
		[FieldOffset(Offset = "0x64")]
		private DIYViewListModel.DIYViewListThemeState m_cachedThemeState;

		// Token: 0x04009ACA RID: 39626
		[Token(Token = "0x4009ACA")]
		[FieldOffset(Offset = "0x68")]
		[NonSerialized]
		public Func<DIYItemViewData, bool> OnButtonPressed;

		// Token: 0x04009ACB RID: 39627
		[Token(Token = "0x4009ACB")]
		[FieldOffset(Offset = "0x70")]
		[NonSerialized]
		public Func<DIYItemViewData, bool> OnInfoPressed;

		// Token: 0x04009ACD RID: 39629
		[Token(Token = "0x4009ACD")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_bindState;

		// Token: 0x04009ACE RID: 39630
		[Token(Token = "0x4009ACE")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_bindState;

		// Token: 0x04009ACF RID: 39631
		[Token(Token = "0x4009ACF")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x04009AD0 RID: 39632
		[Token(Token = "0x4009AD0")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnEnter;

		// Token: 0x04009AD1 RID: 39633
		[Token(Token = "0x4009AD1")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_OnValueChanged;

		// Token: 0x04009AD2 RID: 39634
		[Token(Token = "0x4009AD2")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_OnSortMethodClicked;

		// Token: 0x04009AD3 RID: 39635
		[Token(Token = "0x4009AD3")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02001985 RID: 6533
		[Token(Token = "0x2001985")]
		public class DIYViewDataOptions
		{
			// Token: 0x0600A3E8 RID: 41960 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600A3E8")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public DIYViewDataOptions()
			{
			}

			// Token: 0x04009AD4 RID: 39636
			[Token(Token = "0x4009AD4")]
			[FieldOffset(Offset = "0x10")]
			public DIYViewListModel.DIYViewListThemeState themeState;

			// Token: 0x04009AD5 RID: 39637
			[Token(Token = "0x4009AD5")]
			[FieldOffset(Offset = "0x14")]
			public bool needRebuild;

			// Token: 0x04009AD6 RID: 39638
			[Token(Token = "0x4009AD6")]
			[FieldOffset(Offset = "0x18")]
			public float rebuildIndex;
		}

		// Token: 0x02001986 RID: 6534
		[Token(Token = "0x2001986")]
		private class ExpandSwitchTween : UISwitchTween
		{
			// Token: 0x0600A3E9 RID: 41961 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600A3E9")]
			[Address(RVA = "0x31E9240", Offset = "0x31E7E40", VA = "0x1831E9240")]
			public ExpandSwitchTween(DIYFurnitureExpandViewList closure)
			{
			}

			// Token: 0x0600A3EA RID: 41962 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600A3EA")]
			[Address(RVA = "0x31E8EB0", Offset = "0x31E7AB0", VA = "0x1831E8EB0", Slot = "5")]
			protected override UISwitchTween.ITweenHandler GenerateTweenOfHide()
			{
				return null;
			}

			// Token: 0x0600A3EB RID: 41963 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600A3EB")]
			[Address(RVA = "0x31E8FF0", Offset = "0x31E7BF0", VA = "0x1831E8FF0", Slot = "4")]
			protected override UISwitchTween.ITweenHandler GenerateTweenOfShow()
			{
				return null;
			}

			// Token: 0x0600A3EC RID: 41964 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600A3EC")]
			[Address(RVA = "0x31E8CD0", Offset = "0x31E78D0", VA = "0x1831E8CD0", Slot = "8")]
			protected override void AfterShowEffect()
			{
			}

			// Token: 0x0600A3ED RID: 41965 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600A3ED")]
			[Address(RVA = "0x31E8C50", Offset = "0x31E7850", VA = "0x1831E8C50", Slot = "9")]
			protected override void AfterHideEffect()
			{
			}

			// Token: 0x0600A3EE RID: 41966 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600A3EE")]
			[Address(RVA = "0x31E8D50", Offset = "0x31E7950", VA = "0x1831E8D50", Slot = "7")]
			protected override void BeforeHideEffect()
			{
			}

			// Token: 0x0600A3EF RID: 41967 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600A3EF")]
			[Address(RVA = "0x31E8E00", Offset = "0x31E7A00", VA = "0x1831E8E00", Slot = "6")]
			protected override void BeforeShowEffect()
			{
			}

			// Token: 0x0600A3F0 RID: 41968 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600A3F0")]
			[Address(RVA = "0x31E9130", Offset = "0x31E7D30", VA = "0x1831E9130", Slot = "10")]
			protected override void ResetToState(bool isShow)
			{
			}

			// Token: 0x0600A3F1 RID: 41969 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600A3F1")]
			[Address(RVA = "0xECEC90", Offset = "0xECD890", VA = "0x180ECEC90")]
			private void <>xLuaBaseProxy_AfterShowEffect()
			{
			}

			// Token: 0x0600A3F2 RID: 41970 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600A3F2")]
			[Address(RVA = "0x9C2DA0", Offset = "0x9C19A0", VA = "0x1809C2DA0")]
			private void <>xLuaBaseProxy_AfterHideEffect()
			{
			}

			// Token: 0x0600A3F3 RID: 41971 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600A3F3")]
			[Address(RVA = "0x10A4B70", Offset = "0x10A3770", VA = "0x1810A4B70")]
			private void <>xLuaBaseProxy_BeforeHideEffect()
			{
			}

			// Token: 0x0600A3F4 RID: 41972 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600A3F4")]
			[Address(RVA = "0xDFAF10", Offset = "0xDF9B10", VA = "0x180DFAF10")]
			private void <>xLuaBaseProxy_BeforeShowEffect()
			{
			}

			// Token: 0x0600A3F5 RID: 41973 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600A3F5")]
			[Address(RVA = "0x9B38B0", Offset = "0x9B24B0", VA = "0x1809B38B0")]
			private void <>xLuaBaseProxy_ResetToState(bool P0)
			{
			}

			// Token: 0x04009AD7 RID: 39639
			[Token(Token = "0x4009AD7")]
			[FieldOffset(Offset = "0x48")]
			private DIYFurnitureExpandViewList m_closure;

			// Token: 0x04009AD8 RID: 39640
			[Token(Token = "0x4009AD8")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x04009AD9 RID: 39641
			[Token(Token = "0x4009AD9")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_GenerateTweenOfHide;

			// Token: 0x04009ADA RID: 39642
			[Token(Token = "0x4009ADA")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_GenerateTweenOfShow;

			// Token: 0x04009ADB RID: 39643
			[Token(Token = "0x4009ADB")]
			[FieldOffset(Offset = "0x18")]
			private static DelegateBridge __Hotfix0_AfterShowEffect;

			// Token: 0x04009ADC RID: 39644
			[Token(Token = "0x4009ADC")]
			[FieldOffset(Offset = "0x20")]
			private static DelegateBridge __Hotfix0_AfterHideEffect;

			// Token: 0x04009ADD RID: 39645
			[Token(Token = "0x4009ADD")]
			[FieldOffset(Offset = "0x28")]
			private static DelegateBridge __Hotfix0_BeforeHideEffect;

			// Token: 0x04009ADE RID: 39646
			[Token(Token = "0x4009ADE")]
			[FieldOffset(Offset = "0x30")]
			private static DelegateBridge __Hotfix0_BeforeShowEffect;

			// Token: 0x04009ADF RID: 39647
			[Token(Token = "0x4009ADF")]
			[FieldOffset(Offset = "0x38")]
			private static DelegateBridge __Hotfix0_ResetToState;
		}
	}
}

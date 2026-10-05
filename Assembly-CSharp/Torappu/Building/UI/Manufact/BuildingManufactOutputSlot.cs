using System;
using AdvancedInspector;
using Il2CppDummyDll;
using Torappu.DataBind;
using Torappu.UI;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Building.UI.Manufact
{
	// Token: 0x02001DA9 RID: 7593
	[Token(Token = "0x2001DA9")]
	public class BuildingManufactOutputSlot : DataBinder<MRoomViewPropety>
	{
		// Token: 0x0600BB37 RID: 47927 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BB37")]
		[Address(RVA = "0x3392920", Offset = "0x3391520", VA = "0x183392920", Slot = "7")]
		public override void OnValueChanged(MRoomViewPropety property)
		{
		}

		// Token: 0x0600BB38 RID: 47928 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BB38")]
		[Address(RVA = "0x3392BE0", Offset = "0x33917E0", VA = "0x183392BE0")]
		private void _Init(MRoomViewModel viewModel)
		{
		}

		// Token: 0x0600BB39 RID: 47929 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BB39")]
		[Address(RVA = "0x3393230", Offset = "0x3391E30", VA = "0x183393230")]
		private void _RenderNormal(MRoomViewModel viewModel)
		{
		}

		// Token: 0x0600BB3A RID: 47930 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BB3A")]
		[Address(RVA = "0x3392D50", Offset = "0x3391950", VA = "0x183392D50")]
		private void _RenderEdit(MRoomViewModel viewModel)
		{
		}

		// Token: 0x0600BB3B RID: 47931 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BB3B")]
		[Address(RVA = "0x3393070", Offset = "0x3391C70", VA = "0x183393070")]
		private void _RenderItemInfo(BuildingData.ManufactFormula formula, int remainCount)
		{
		}

		// Token: 0x0600BB3C RID: 47932 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BB3C")]
		[Address(RVA = "0x33935D0", Offset = "0x33921D0", VA = "0x1833935D0")]
		private void _UpdateCountDown(MRoomViewModel viewModel, ManufactSnapshot snapshot)
		{
		}

		// Token: 0x0600BB3D RID: 47933 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BB3D")]
		[Address(RVA = "0x3393810", Offset = "0x3392410", VA = "0x183393810")]
		private void _UpdateSecond(CountDownTask.TickValue value)
		{
		}

		// Token: 0x0600BB3E RID: 47934 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BB3E")]
		[Address(RVA = "0x33928B0", Offset = "0x33914B0", VA = "0x1833928B0")]
		public void EventOnPanelClick()
		{
		}

		// Token: 0x0600BB3F RID: 47935 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BB3F")]
		[Address(RVA = "0x3392B70", Offset = "0x3391770", VA = "0x183392B70")]
		private void Update()
		{
		}

		// Token: 0x0600BB40 RID: 47936 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BB40")]
		[Address(RVA = "0x33939A0", Offset = "0x33925A0", VA = "0x1833939A0")]
		public BuildingManufactOutputSlot()
		{
		}

		// Token: 0x0400BABB RID: 47803
		[Token(Token = "0x400BABB")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GameObject _panelStop;

		// Token: 0x0400BABC RID: 47804
		[Token(Token = "0x400BABC")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private GameObject _panelFinish;

		// Token: 0x0400BABD RID: 47805
		[Token(Token = "0x400BABD")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private GameObject _panelAdd;

		// Token: 0x0400BABE RID: 47806
		[Token(Token = "0x400BABE")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private GameObject _panelItemInfo;

		// Token: 0x0400BABF RID: 47807
		[Token(Token = "0x400BABF")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private GameObject _panelWorking;

		// Token: 0x0400BAC0 RID: 47808
		[Token(Token = "0x400BAC0")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private Text _textName;

		// Token: 0x0400BAC1 RID: 47809
		[Token(Token = "0x400BAC1")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private Text _textWeight;

		// Token: 0x0400BAC2 RID: 47810
		[Token(Token = "0x400BAC2")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private Text _textTime;

		// Token: 0x0400BAC3 RID: 47811
		[Token(Token = "0x400BAC3")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		[Group("Item")]
		private RectTransform _itemContainer;

		// Token: 0x0400BAC4 RID: 47812
		[Token(Token = "0x400BAC4")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		[Group("Item")]
		private float _itemScale;

		// Token: 0x0400BAC5 RID: 47813
		[Token(Token = "0x400BAC5")]
		[FieldOffset(Offset = "0x6C")]
		private bool m_isInited;

		// Token: 0x0400BAC6 RID: 47814
		[Token(Token = "0x400BAC6")]
		[FieldOffset(Offset = "0x70")]
		private CountDownTask m_countDown;

		// Token: 0x0400BAC7 RID: 47815
		[Token(Token = "0x400BAC7")]
		[FieldOffset(Offset = "0x78")]
		private UIItemCard m_itemCard;

		// Token: 0x0400BAC8 RID: 47816
		[Token(Token = "0x400BAC8")]
		[FieldOffset(Offset = "0x80")]
		private UIItemViewModel m_itemViewModel;

		// Token: 0x0400BAC9 RID: 47817
		[Token(Token = "0x400BAC9")]
		[FieldOffset(Offset = "0x88")]
		private MRoomViewModel m_viewModelCache;

		// Token: 0x0400BACA RID: 47818
		[Token(Token = "0x400BACA")]
		[FieldOffset(Offset = "0x90")]
		[NonSerialized]
		public Action onEditFormula;

		// Token: 0x0400BACB RID: 47819
		[Token(Token = "0x400BACB")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnValueChanged;

		// Token: 0x0400BACC RID: 47820
		[Token(Token = "0x400BACC")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__Init;

		// Token: 0x0400BACD RID: 47821
		[Token(Token = "0x400BACD")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__RenderNormal;

		// Token: 0x0400BACE RID: 47822
		[Token(Token = "0x400BACE")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__RenderEdit;

		// Token: 0x0400BACF RID: 47823
		[Token(Token = "0x400BACF")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__RenderItemInfo;

		// Token: 0x0400BAD0 RID: 47824
		[Token(Token = "0x400BAD0")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__UpdateCountDown;

		// Token: 0x0400BAD1 RID: 47825
		[Token(Token = "0x400BAD1")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__UpdateSecond;

		// Token: 0x0400BAD2 RID: 47826
		[Token(Token = "0x400BAD2")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_EventOnPanelClick;

		// Token: 0x0400BAD3 RID: 47827
		[Token(Token = "0x400BAD3")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_Update;

		// Token: 0x0400BAD4 RID: 47828
		[Token(Token = "0x400BAD4")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}

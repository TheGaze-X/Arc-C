using System;
using System.Collections.Generic;
using AdvancedInspector;
using Il2CppDummyDll;
using Torappu.DataBind;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Tuning
{
	// Token: 0x02003CD8 RID: 15576
	[Token(Token = "0x2003CD8")]
	public class TuningProductMenuView : DataBinder<TuningProductProperty>
	{
		// Token: 0x06018490 RID: 99472 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018490")]
		[Address(RVA = "0x10CAC40", Offset = "0x10C9840", VA = "0x1810CAC40", Slot = "7")]
		public override void OnValueChanged(TuningProductProperty property)
		{
		}

		// Token: 0x06018491 RID: 99473 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018491")]
		[Address(RVA = "0x10CB140", Offset = "0x10C9D40", VA = "0x1810CB140")]
		private void _RenderCardSlotItem(TuningProductViewModel model)
		{
		}

		// Token: 0x06018492 RID: 99474 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018492")]
		[Address(RVA = "0x10CADA0", Offset = "0x10C99A0", VA = "0x1810CADA0")]
		private void _RenderCardDesc(TuningProductViewModel model)
		{
		}

		// Token: 0x06018493 RID: 99475 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018493")]
		[Address(RVA = "0x10CAB20", Offset = "0x10C9720", VA = "0x1810CAB20")]
		public void BackToSelectFrag()
		{
		}

		// Token: 0x06018494 RID: 99476 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018494")]
		[Address(RVA = "0x10CABB0", Offset = "0x10C97B0", VA = "0x1810CABB0")]
		public void NextStep()
		{
		}

		// Token: 0x06018495 RID: 99477 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018495")]
		[Address(RVA = "0x10CB310", Offset = "0x10C9F10", VA = "0x1810CB310")]
		public TuningProductMenuView()
		{
		}

		// Token: 0x0401DA5A RID: 121434
		[Token(Token = "0x401DA5A")]
		private const string UNKNOWN_FORM_DESC = "???";

		// Token: 0x0401DA5B RID: 121435
		[Token(Token = "0x401DA5B")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		[Group("Card")]
		private List<TuningProductSlotImageItemView> _fragSlotItemViews;

		// Token: 0x0401DA5C RID: 121436
		[Token(Token = "0x401DA5C")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		[Group("Card")]
		private TuningProductSlotImageItemView _eyeSlotItemView;

		// Token: 0x0401DA5D RID: 121437
		[Token(Token = "0x401DA5D")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		[Group("Card")]
		private TuningProductSlotImageItemView _orcheItemView;

		// Token: 0x0401DA5E RID: 121438
		[Token(Token = "0x401DA5E")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		[Group("Card")]
		private TuningProductSlotGroupItemView _slotUnknownGroupView;

		// Token: 0x0401DA5F RID: 121439
		[Token(Token = "0x401DA5F")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		[Group("Button")]
		private GameObject _canNextStepBtnObj;

		// Token: 0x0401DA60 RID: 121440
		[Token(Token = "0x401DA60")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		[Group("Button")]
		private GameObject _cannotNextStepBtnObj;

		// Token: 0x0401DA61 RID: 121441
		[Token(Token = "0x401DA61")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		[Group("Button")]
		private Button _nextStepBtn;

		// Token: 0x0401DA62 RID: 121442
		[Token(Token = "0x401DA62")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		[Group("Button")]
		private GameObject _makeBtnObj;

		// Token: 0x0401DA63 RID: 121443
		[Token(Token = "0x401DA63")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		[Group("Desc")]
		private Text _productTypeName;

		// Token: 0x0401DA64 RID: 121444
		[Token(Token = "0x401DA64")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		[Group("Desc")]
		private Text _orcheName;

		// Token: 0x0401DA65 RID: 121445
		[Token(Token = "0x401DA65")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		[Group("Desc")]
		private Text _formName;

		// Token: 0x0401DA66 RID: 121446
		[Token(Token = "0x401DA66")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		[Group("Desc")]
		private Text _formNameFrontBrackets;

		// Token: 0x0401DA67 RID: 121447
		[Token(Token = "0x401DA67")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		[Group("Desc")]
		private Text _formNameBehindBracket;

		// Token: 0x0401DA68 RID: 121448
		[Token(Token = "0x401DA68")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		[Group("Desc")]
		private TuningProductSlotGroupItemView _descUnknownGroupView;

		// Token: 0x0401DA69 RID: 121449
		[Token(Token = "0x401DA69")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		[Group("Desc")]
		private TuningProductSlotGroupItemView _productTypeDescGroupView;

		// Token: 0x0401DA6A RID: 121450
		[Token(Token = "0x401DA6A")]
		[FieldOffset(Offset = "0x98")]
		[SerializeField]
		[Group("Desc")]
		private TuningProductSlotGroupItemView _formDescGroupView;

		// Token: 0x0401DA6B RID: 121451
		[Token(Token = "0x401DA6B")]
		[FieldOffset(Offset = "0xA0")]
		[SerializeField]
		[Group("Desc")]
		private TuningProductSlotGroupItemView _orcheDescGroupView;

		// Token: 0x0401DA6C RID: 121452
		[Token(Token = "0x401DA6C")]
		[FieldOffset(Offset = "0xA8")]
		private UIStateFinder m_stateFinder;

		// Token: 0x0401DA6D RID: 121453
		[Token(Token = "0x401DA6D")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnValueChanged;

		// Token: 0x0401DA6E RID: 121454
		[Token(Token = "0x401DA6E")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__RenderCardSlotItem;

		// Token: 0x0401DA6F RID: 121455
		[Token(Token = "0x401DA6F")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__RenderCardDesc;

		// Token: 0x0401DA70 RID: 121456
		[Token(Token = "0x401DA70")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_BackToSelectFrag;

		// Token: 0x0401DA71 RID: 121457
		[Token(Token = "0x401DA71")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_NextStep;

		// Token: 0x0401DA72 RID: 121458
		[Token(Token = "0x401DA72")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}

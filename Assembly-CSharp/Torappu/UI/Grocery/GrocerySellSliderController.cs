using System;
using Il2CppDummyDll;
using Torappu.DataBind;
using UnityEngine;
using XLua;

namespace Torappu.UI.Grocery
{
	// Token: 0x02004CFC RID: 19708
	[Token(Token = "0x2004CFC")]
	public class GrocerySellSliderController : DataBinder<GrocerySellProperty>, IHotfixable
	{
		// Token: 0x0601D88F RID: 120975 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D88F")]
		[Address(RVA = "0x171C340", Offset = "0x171AF40", VA = "0x18171C340", Slot = "7")]
		public override void OnValueChanged(GrocerySellProperty property)
		{
		}

		// Token: 0x0601D890 RID: 120976 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D890")]
		[Address(RVA = "0x171C2B0", Offset = "0x171AEB0", VA = "0x18171C2B0")]
		public void OnMinBtnClick()
		{
		}

		// Token: 0x0601D891 RID: 120977 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D891")]
		[Address(RVA = "0x171C220", Offset = "0x171AE20", VA = "0x18171C220")]
		public void OnAddBtnClick()
		{
		}

		// Token: 0x0601D892 RID: 120978 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D892")]
		[Address(RVA = "0x171C800", Offset = "0x171B400", VA = "0x18171C800")]
		private void _OnSliderPageChanged(int selectedPage)
		{
		}

		// Token: 0x0601D893 RID: 120979 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D893")]
		[Address(RVA = "0x171C920", Offset = "0x171B520", VA = "0x18171C920")]
		private void _OnSliderValueUpdating(float pageIndex)
		{
		}

		// Token: 0x0601D894 RID: 120980 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D894")]
		[Address(RVA = "0x171C880", Offset = "0x171B480", VA = "0x18171C880")]
		private void _OnSliderStateChanged(UISliderPager.State state)
		{
		}

		// Token: 0x0601D895 RID: 120981 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D895")]
		[Address(RVA = "0x171C4C0", Offset = "0x171B0C0", VA = "0x18171C4C0")]
		private void _InitIfNot(int valueCount)
		{
		}

		// Token: 0x0601D896 RID: 120982 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D896")]
		[Address(RVA = "0x171CA80", Offset = "0x171B680", VA = "0x18171CA80")]
		private void _UpdateSliderWhenStable()
		{
		}

		// Token: 0x0601D897 RID: 120983 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D897")]
		[Address(RVA = "0x171C720", Offset = "0x171B320", VA = "0x18171C720")]
		private void _NotifySelectionChanged(int targetIndex)
		{
		}

		// Token: 0x0601D898 RID: 120984 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D898")]
		[Address(RVA = "0x171CC90", Offset = "0x171B890", VA = "0x18171CC90")]
		public GrocerySellSliderController()
		{
		}

		// Token: 0x04026F77 RID: 159607
		[Token(Token = "0x4026F77")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private MagneticDotSliderView _view;

		// Token: 0x04026F78 RID: 159608
		[Token(Token = "0x4026F78")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private UISliderPager _sliderPager;

		// Token: 0x04026F79 RID: 159609
		[Token(Token = "0x4026F79")]
		[FieldOffset(Offset = "0x30")]
		private MagneticDotSliderViewModelProperty m_dotProp;

		// Token: 0x04026F7A RID: 159610
		[Token(Token = "0x4026F7A")]
		[FieldOffset(Offset = "0x38")]
		private UIStateFinder m_stateFinder;

		// Token: 0x04026F7B RID: 159611
		[Token(Token = "0x4026F7B")]
		[FieldOffset(Offset = "0x48")]
		private LatchUtils.InvokeWhenUnlock m_updateSliderLatch;

		// Token: 0x04026F7C RID: 159612
		[Token(Token = "0x4026F7C")]
		[FieldOffset(Offset = "0x50")]
		private int m_resetDataVersion;

		// Token: 0x04026F7D RID: 159613
		[Token(Token = "0x4026F7D")]
		[FieldOffset(Offset = "0x58")]
		private GrocerySellViewModel m_viewModel;

		// Token: 0x04026F7E RID: 159614
		[Token(Token = "0x4026F7E")]
		[FieldOffset(Offset = "0x60")]
		private bool m_hasInited;

		// Token: 0x04026F7F RID: 159615
		[Token(Token = "0x4026F7F")]
		[FieldOffset(Offset = "0x64")]
		private int m_valueCount;

		// Token: 0x04026F80 RID: 159616
		[Token(Token = "0x4026F80")]
		[FieldOffset(Offset = "0x68")]
		private int m_selectIndex;

		// Token: 0x04026F81 RID: 159617
		[Token(Token = "0x4026F81")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnValueChanged;

		// Token: 0x04026F82 RID: 159618
		[Token(Token = "0x4026F82")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnMinBtnClick;

		// Token: 0x04026F83 RID: 159619
		[Token(Token = "0x4026F83")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnAddBtnClick;

		// Token: 0x04026F84 RID: 159620
		[Token(Token = "0x4026F84")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__OnSliderPageChanged;

		// Token: 0x04026F85 RID: 159621
		[Token(Token = "0x4026F85")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__OnSliderValueUpdating;

		// Token: 0x04026F86 RID: 159622
		[Token(Token = "0x4026F86")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__OnSliderStateChanged;

		// Token: 0x04026F87 RID: 159623
		[Token(Token = "0x4026F87")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x04026F88 RID: 159624
		[Token(Token = "0x4026F88")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__UpdateSliderWhenStable;

		// Token: 0x04026F89 RID: 159625
		[Token(Token = "0x4026F89")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__NotifySelectionChanged;

		// Token: 0x04026F8A RID: 159626
		[Token(Token = "0x4026F8A")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}

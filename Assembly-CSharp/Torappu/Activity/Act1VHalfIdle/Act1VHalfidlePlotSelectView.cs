using System;
using Il2CppDummyDll;
using Torappu.DataBind;
using Torappu.UI;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Activity.Act1VHalfIdle
{
	// Token: 0x0200776E RID: 30574
	[Token(Token = "0x200776E")]
	public class Act1VHalfidlePlotSelectView : DataBinder<Act1VHalfidlePlotSelectProperty>
	{
		// Token: 0x0602AF0C RID: 175884 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602AF0C")]
		[Address(RVA = "0x26BE500", Offset = "0x26BD100", VA = "0x1826BE500", Slot = "7")]
		public override void OnValueChanged(Act1VHalfidlePlotSelectProperty property)
		{
		}

		// Token: 0x0602AF0D RID: 175885 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602AF0D")]
		[Address(RVA = "0x26BE890", Offset = "0x26BD490", VA = "0x1826BE890")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0602AF0E RID: 175886 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602AF0E")]
		[Address(RVA = "0x26BEDC0", Offset = "0x26BD9C0", VA = "0x1826BEDC0")]
		private void _Render(Act1VHalfidlePlotSelectViewModel viewModel)
		{
		}

		// Token: 0x0602AF0F RID: 175887 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602AF0F")]
		[Address(RVA = "0x26BEAD0", Offset = "0x26BD6D0", VA = "0x1826BEAD0")]
		private void _RefreshTipAndBtn(Act1VHalfidlePlotSelectViewModel viewModel)
		{
		}

		// Token: 0x0602AF10 RID: 175888 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602AF10")]
		[Address(RVA = "0x26BE9E0", Offset = "0x26BD5E0", VA = "0x1826BE9E0")]
		private void _OnItemClicked(string plotId)
		{
		}

		// Token: 0x0602AF11 RID: 175889 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602AF11")]
		[Address(RVA = "0x26BE3A0", Offset = "0x26BCFA0", VA = "0x1826BE3A0")]
		public void EventOnClearAll()
		{
		}

		// Token: 0x0602AF12 RID: 175890 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602AF12")]
		[Address(RVA = "0x26BE420", Offset = "0x26BD020", VA = "0x1826BE420")]
		public void EventOnSavePlot()
		{
		}

		// Token: 0x0602AF13 RID: 175891 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602AF13")]
		[Address(RVA = "0x26BE7A0", Offset = "0x26BD3A0", VA = "0x1826BE7A0")]
		public void RegisterTutorialGO()
		{
		}

		// Token: 0x0602AF14 RID: 175892 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602AF14")]
		[Address(RVA = "0x26BEEC0", Offset = "0x26BDAC0", VA = "0x1826BEEC0")]
		public Act1VHalfidlePlotSelectView()
		{
		}

		// Token: 0x0403DF40 RID: 253760
		[Token(Token = "0x403DF40")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Act1VHalfidlePlotBackpackCardItemAdapter _adapter;

		// Token: 0x0403DF41 RID: 253761
		[Token(Token = "0x403DF41")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private GameObject _emptyObj;

		// Token: 0x0403DF42 RID: 253762
		[Token(Token = "0x403DF42")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Text _textTip;

		// Token: 0x0403DF43 RID: 253763
		[Token(Token = "0x403DF43")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private GameObject _tipGO;

		// Token: 0x0403DF44 RID: 253764
		[Token(Token = "0x403DF44")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private GameObject _btnConfirmGO;

		// Token: 0x0403DF45 RID: 253765
		[Token(Token = "0x403DF45")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private GameObject _invalidBtn;

		// Token: 0x0403DF46 RID: 253766
		[Token(Token = "0x403DF46")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private GameObject _validBtn;

		// Token: 0x0403DF47 RID: 253767
		[Token(Token = "0x403DF47")]
		[FieldOffset(Offset = "0x58")]
		private UIStateFinder m_stateFinder;

		// Token: 0x0403DF48 RID: 253768
		[Token(Token = "0x403DF48")]
		[FieldOffset(Offset = "0x68")]
		private bool m_isInited;

		// Token: 0x0403DF49 RID: 253769
		[Token(Token = "0x403DF49")]
		[FieldOffset(Offset = "0x69")]
		private bool m_selectedValid;

		// Token: 0x0403DF4A RID: 253770
		[Token(Token = "0x403DF4A")]
		[FieldOffset(Offset = "0x70")]
		private string m_actId;

		// Token: 0x0403DF4B RID: 253771
		[Token(Token = "0x403DF4B")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnValueChanged;

		// Token: 0x0403DF4C RID: 253772
		[Token(Token = "0x403DF4C")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0403DF4D RID: 253773
		[Token(Token = "0x403DF4D")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__Render;

		// Token: 0x0403DF4E RID: 253774
		[Token(Token = "0x403DF4E")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__RefreshTipAndBtn;

		// Token: 0x0403DF4F RID: 253775
		[Token(Token = "0x403DF4F")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__OnItemClicked;

		// Token: 0x0403DF50 RID: 253776
		[Token(Token = "0x403DF50")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_EventOnClearAll;

		// Token: 0x0403DF51 RID: 253777
		[Token(Token = "0x403DF51")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_EventOnSavePlot;

		// Token: 0x0403DF52 RID: 253778
		[Token(Token = "0x403DF52")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_RegisterTutorialGO;

		// Token: 0x0403DF53 RID: 253779
		[Token(Token = "0x403DF53")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}

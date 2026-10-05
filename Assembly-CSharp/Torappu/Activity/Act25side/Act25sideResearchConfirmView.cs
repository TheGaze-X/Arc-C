using System;
using Il2CppDummyDll;
using Torappu.DataBind;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Activity.Act25side
{
	// Token: 0x0200751A RID: 29978
	[Token(Token = "0x200751A")]
	public class Act25sideResearchConfirmView : DataBinder<Act25sideResearchConfirmProperty>
	{
		// Token: 0x0602A3F6 RID: 173046 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A3F6")]
		[Address(RVA = "0x25E3640", Offset = "0x25E2240", VA = "0x1825E3640", Slot = "7")]
		public override void OnValueChanged(Act25sideResearchConfirmProperty property)
		{
		}

		// Token: 0x0602A3F7 RID: 173047 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A3F7")]
		[Address(RVA = "0x25E35D0", Offset = "0x25E21D0", VA = "0x1825E35D0")]
		public void OnConfirm()
		{
		}

		// Token: 0x0602A3F8 RID: 173048 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A3F8")]
		[Address(RVA = "0x25E3940", Offset = "0x25E2540", VA = "0x1825E3940")]
		public Act25sideResearchConfirmView()
		{
		}

		// Token: 0x0403CBA8 RID: 248744
		[Token(Token = "0x403CBA8")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GameObject _panelCount;

		// Token: 0x0403CBA9 RID: 248745
		[Token(Token = "0x403CBA9")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private GameObject _panelBtnExit;

		// Token: 0x0403CBAA RID: 248746
		[Token(Token = "0x403CBAA")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private GameObject _panelBtnConfirm;

		// Token: 0x0403CBAB RID: 248747
		[Token(Token = "0x403CBAB")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private GameObject _panelCountText;

		// Token: 0x0403CBAC RID: 248748
		[Token(Token = "0x403CBAC")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Text _currentCount;

		// Token: 0x0403CBAD RID: 248749
		[Token(Token = "0x403CBAD")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private Text _descUp;

		// Token: 0x0403CBAE RID: 248750
		[Token(Token = "0x403CBAE")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private Text _descDown;

		// Token: 0x0403CBAF RID: 248751
		[Token(Token = "0x403CBAF")]
		[FieldOffset(Offset = "0x58")]
		[NonSerialized]
		public Action onConfirmClick;

		// Token: 0x0403CBB0 RID: 248752
		[Token(Token = "0x403CBB0")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnValueChanged;

		// Token: 0x0403CBB1 RID: 248753
		[Token(Token = "0x403CBB1")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnConfirm;

		// Token: 0x0403CBB2 RID: 248754
		[Token(Token = "0x403CBB2")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}

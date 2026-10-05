using System;
using System.Text;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI
{
	// Token: 0x020035B3 RID: 13747
	[Token(Token = "0x20035B3")]
	public class CommonInputDialog : UICustomDialog<CommonInputDialog.Options>
	{
		// Token: 0x06015DFD RID: 89597 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015DFD")]
		[Address(RVA = "0xE60B40", Offset = "0xE5F740", VA = "0x180E60B40")]
		private void _InitIfNot()
		{
		}

		// Token: 0x06015DFE RID: 89598 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015DFE")]
		[Address(RVA = "0xE600F0", Offset = "0xE5ECF0", VA = "0x180E600F0", Slot = "7")]
		protected override void OnRender(CommonInputDialog.Options options)
		{
		}

		// Token: 0x06015DFF RID: 89599 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015DFF")]
		[Address(RVA = "0xE60E40", Offset = "0xE5FA40", VA = "0x180E60E40")]
		private void _OnInputFieldValueChange(string input)
		{
		}

		// Token: 0x06015E00 RID: 89600 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015E00")]
		[Address(RVA = "0xE60D40", Offset = "0xE5F940", VA = "0x180E60D40")]
		private void _OnInputFieldEndEdit(string input)
		{
		}

		// Token: 0x06015E01 RID: 89601 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6015E01")]
		[Address(RVA = "0xE60860", Offset = "0xE5F460", VA = "0x180E60860")]
		private string _BlockLength(string input)
		{
			return null;
		}

		// Token: 0x06015E02 RID: 89602 RVA: 0x0008E8D8 File Offset: 0x0008CAD8
		[Token(Token = "0x6015E02")]
		[Address(RVA = "0xE60AB0", Offset = "0xE5F6B0", VA = "0x180E60AB0")]
		private static int _CalcCharCount(char c)
		{
			return 0;
		}

		// Token: 0x06015E03 RID: 89603 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015E03")]
		[Address(RVA = "0xE5FFF0", Offset = "0xE5EBF0", VA = "0x180E5FFF0")]
		public void ClosePanel()
		{
		}

		// Token: 0x06015E04 RID: 89604 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015E04")]
		[Address(RVA = "0xE605B0", Offset = "0xE5F1B0", VA = "0x180E605B0")]
		public void OnSubmitInputClicked()
		{
		}

		// Token: 0x06015E05 RID: 89605 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6015E05")]
		[Address(RVA = "0xE60090", Offset = "0xE5EC90", VA = "0x180E60090", Slot = "10")]
		protected override UIRenderTextureImage GetBlurTarget()
		{
			return null;
		}

		// Token: 0x06015E06 RID: 89606 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015E06")]
		[Address(RVA = "0xE60F40", Offset = "0xE5FB40", VA = "0x180E60F40")]
		public CommonInputDialog()
		{
		}

		// Token: 0x0401A4D1 RID: 107729
		[Token(Token = "0x401A4D1")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		private InputField _inputName;

		// Token: 0x0401A4D2 RID: 107730
		[Token(Token = "0x401A4D2")]
		[FieldOffset(Offset = "0x98")]
		[SerializeField]
		private Text _placeHolder;

		// Token: 0x0401A4D3 RID: 107731
		[Token(Token = "0x401A4D3")]
		[FieldOffset(Offset = "0xA0")]
		[SerializeField]
		private GameObject _confirmBtnBlue;

		// Token: 0x0401A4D4 RID: 107732
		[Token(Token = "0x401A4D4")]
		[FieldOffset(Offset = "0xA8")]
		[SerializeField]
		private GameObject _confirmBtnRed;

		// Token: 0x0401A4D5 RID: 107733
		[Token(Token = "0x401A4D5")]
		[FieldOffset(Offset = "0xB0")]
		[SerializeField]
		private RectTransform _backRt;

		// Token: 0x0401A4D6 RID: 107734
		[Token(Token = "0x401A4D6")]
		[FieldOffset(Offset = "0xB8")]
		[SerializeField]
		private UIRenderTextureImage _blurBkg;

		// Token: 0x0401A4D7 RID: 107735
		[Token(Token = "0x401A4D7")]
		[FieldOffset(Offset = "0xC0")]
		private bool m_isInited;

		// Token: 0x0401A4D8 RID: 107736
		[Token(Token = "0x401A4D8")]
		[FieldOffset(Offset = "0xC8")]
		private ICommonInputDialogConfirmConfig m_confirmConfig;

		// Token: 0x0401A4D9 RID: 107737
		[Token(Token = "0x401A4D9")]
		[FieldOffset(Offset = "0xD0")]
		private Action m_onSuccess;

		// Token: 0x0401A4DA RID: 107738
		[Token(Token = "0x401A4DA")]
		[FieldOffset(Offset = "0xD8")]
		private string m_emptyToast;

		// Token: 0x0401A4DB RID: 107739
		[Token(Token = "0x401A4DB")]
		[FieldOffset(Offset = "0xE0")]
		private ValueBundle m_param;

		// Token: 0x0401A4DC RID: 107740
		[Token(Token = "0x401A4DC")]
		[FieldOffset(Offset = "0x100")]
		private int m_inputLimitCount;

		// Token: 0x0401A4DD RID: 107741
		[Token(Token = "0x401A4DD")]
		[FieldOffset(Offset = "0x104")]
		private bool m_checkCrossDay;

		// Token: 0x0401A4DE RID: 107742
		[Token(Token = "0x401A4DE")]
		[FieldOffset(Offset = "0x108")]
		private StringBuilder m_sharedBuilder;

		// Token: 0x0401A4DF RID: 107743
		[Token(Token = "0x401A4DF")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0401A4E0 RID: 107744
		[Token(Token = "0x401A4E0")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnRender;

		// Token: 0x0401A4E1 RID: 107745
		[Token(Token = "0x401A4E1")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__OnInputFieldValueChange;

		// Token: 0x0401A4E2 RID: 107746
		[Token(Token = "0x401A4E2")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__OnInputFieldEndEdit;

		// Token: 0x0401A4E3 RID: 107747
		[Token(Token = "0x401A4E3")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__BlockLength;

		// Token: 0x0401A4E4 RID: 107748
		[Token(Token = "0x401A4E4")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__CalcCharCount;

		// Token: 0x0401A4E5 RID: 107749
		[Token(Token = "0x401A4E5")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_ClosePanel;

		// Token: 0x0401A4E6 RID: 107750
		[Token(Token = "0x401A4E6")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_OnSubmitInputClicked;

		// Token: 0x0401A4E7 RID: 107751
		[Token(Token = "0x401A4E7")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_GetBlurTarget;

		// Token: 0x0401A4E8 RID: 107752
		[Token(Token = "0x401A4E8")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x020035B4 RID: 13748
		[Token(Token = "0x20035B4")]
		public struct Options
		{
			// Token: 0x0401A4E9 RID: 107753
			[Token(Token = "0x401A4E9")]
			[FieldOffset(Offset = "0x0")]
			public string defaultText;

			// Token: 0x0401A4EA RID: 107754
			[Token(Token = "0x401A4EA")]
			[FieldOffset(Offset = "0x8")]
			public string placeHolder;

			// Token: 0x0401A4EB RID: 107755
			[Token(Token = "0x401A4EB")]
			[FieldOffset(Offset = "0x10")]
			public bool useBlueConfirmBtn;

			// Token: 0x0401A4EC RID: 107756
			[Token(Token = "0x401A4EC")]
			[FieldOffset(Offset = "0x14")]
			public int inputLimitCount;

			// Token: 0x0401A4ED RID: 107757
			[Token(Token = "0x401A4ED")]
			[FieldOffset(Offset = "0x18")]
			public Action onSuccess;

			// Token: 0x0401A4EE RID: 107758
			[Token(Token = "0x401A4EE")]
			[FieldOffset(Offset = "0x20")]
			public string emptyToast;

			// Token: 0x0401A4EF RID: 107759
			[Token(Token = "0x401A4EF")]
			[FieldOffset(Offset = "0x28")]
			public Type confirmConfigType;

			// Token: 0x0401A4F0 RID: 107760
			[Token(Token = "0x401A4F0")]
			[FieldOffset(Offset = "0x30")]
			public ValueBundle param;

			// Token: 0x0401A4F1 RID: 107761
			[Token(Token = "0x401A4F1")]
			[FieldOffset(Offset = "0x50")]
			public bool checkCrossDay;
		}
	}
}

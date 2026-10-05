using System;
using Il2CppDummyDll;
using Torappu.UI;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Resource
{
	// Token: 0x0200175C RID: 5980
	[Token(Token = "0x200175C")]
	public class UIHotUpdatePreferencePanel : MonoBehaviour, IHotfixable
	{
		// Token: 0x0600969F RID: 38559 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600969F")]
		[Address(RVA = "0x312F490", Offset = "0x312E090", VA = "0x18312F490")]
		public void Show(UIHotUpdatePreferencePanel.Options options)
		{
		}

		// Token: 0x060096A0 RID: 38560 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60096A0")]
		[Address(RVA = "0x312F3A0", Offset = "0x312DFA0", VA = "0x18312F3A0")]
		public void OnFullToggleClick()
		{
		}

		// Token: 0x060096A1 RID: 38561 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60096A1")]
		[Address(RVA = "0x312F220", Offset = "0x312DE20", VA = "0x18312F220")]
		public void OnBaseToggleClick()
		{
		}

		// Token: 0x060096A2 RID: 38562 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60096A2")]
		[Address(RVA = "0x312F420", Offset = "0x312E020", VA = "0x18312F420")]
		public void OnQuitBtnClick()
		{
		}

		// Token: 0x060096A3 RID: 38563 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60096A3")]
		[Address(RVA = "0x312F2A0", Offset = "0x312DEA0", VA = "0x18312F2A0")]
		public void OnConfirmBtnClick()
		{
		}

		// Token: 0x060096A4 RID: 38564 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60096A4")]
		[Address(RVA = "0x312F740", Offset = "0x312E340", VA = "0x18312F740")]
		public UIHotUpdatePreferencePanel()
		{
		}

		// Token: 0x04008CEB RID: 36075
		[Token(Token = "0x4008CEB")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private UIFadeFloatPanel _fadeFloatPanel;

		// Token: 0x04008CEC RID: 36076
		[Token(Token = "0x4008CEC")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private TwoStateToggle _fullToggle;

		// Token: 0x04008CED RID: 36077
		[Token(Token = "0x4008CED")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Text _fullUnselectLabel;

		// Token: 0x04008CEE RID: 36078
		[Token(Token = "0x4008CEE")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Text _fullSelectLabel;

		// Token: 0x04008CEF RID: 36079
		[Token(Token = "0x4008CEF")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private TwoStateToggle _baseToggle;

		// Token: 0x04008CF0 RID: 36080
		[Token(Token = "0x4008CF0")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Text _baseUnselectLabel;

		// Token: 0x04008CF1 RID: 36081
		[Token(Token = "0x4008CF1")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private Text _baseSelectLabel;

		// Token: 0x04008CF2 RID: 36082
		[Token(Token = "0x4008CF2")]
		[FieldOffset(Offset = "0x50")]
		private UIHotUpdatePreferencePanel.Options m_options;

		// Token: 0x04008CF3 RID: 36083
		[Token(Token = "0x4008CF3")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Show;

		// Token: 0x04008CF4 RID: 36084
		[Token(Token = "0x4008CF4")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnFullToggleClick;

		// Token: 0x04008CF5 RID: 36085
		[Token(Token = "0x4008CF5")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnBaseToggleClick;

		// Token: 0x04008CF6 RID: 36086
		[Token(Token = "0x4008CF6")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnQuitBtnClick;

		// Token: 0x04008CF7 RID: 36087
		[Token(Token = "0x4008CF7")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_OnConfirmBtnClick;

		// Token: 0x04008CF8 RID: 36088
		[Token(Token = "0x4008CF8")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x0200175D RID: 5981
		[Token(Token = "0x200175D")]
		public struct Options
		{
			// Token: 0x04008CF9 RID: 36089
			[Token(Token = "0x4008CF9")]
			[FieldOffset(Offset = "0x0")]
			public Action<HotUpdater.UpdatePreferenceType> onConfirm;

			// Token: 0x04008CFA RID: 36090
			[Token(Token = "0x4008CFA")]
			[FieldOffset(Offset = "0x8")]
			public Action onQuit;

			// Token: 0x04008CFB RID: 36091
			[Token(Token = "0x4008CFB")]
			[FieldOffset(Offset = "0x10")]
			public string fullSize;

			// Token: 0x04008CFC RID: 36092
			[Token(Token = "0x4008CFC")]
			[FieldOffset(Offset = "0x18")]
			public string baseSize;
		}
	}
}

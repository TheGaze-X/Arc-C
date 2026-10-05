using System;
using Il2CppDummyDll;

namespace UnityEngine.UIElements
{
	// Token: 0x020000EE RID: 238
	[Token(Token = "0x20000EE")]
	public abstract class BaseBoolField : BaseField<bool>
	{
		// Token: 0x060006E1 RID: 1761 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60006E1")]
		[Address(RVA = "0x5AA78C0", Offset = "0x5AA64C0", VA = "0x185AA78C0")]
		public BaseBoolField(string label)
		{
		}

		// Token: 0x060006E2 RID: 1762 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60006E2")]
		[Address(RVA = "0x5AA7530", Offset = "0x5AA6130", VA = "0x185AA7530")]
		private void OnNavigationSubmit(NavigationSubmitEvent evt)
		{
		}

		// Token: 0x060006E3 RID: 1763 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60006E3")]
		[Address(RVA = "0x5AA7460", Offset = "0x5AA6060", VA = "0x185AA7460")]
		private void OnKeyDown(KeyDownEvent evt)
		{
		}

		// Token: 0x17000170 RID: 368
		// (get) Token: 0x060006E4 RID: 1764 RVA: 0x0000212A File Offset: 0x0000032A
		// (set) Token: 0x060006E5 RID: 1765 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000170")]
		public string text
		{
			[Token(Token = "0x60006E4")]
			[Address(RVA = "0x5AA7B80", Offset = "0x5AA6780", VA = "0x185AA7B80")]
			get
			{
				return null;
			}
			[Token(Token = "0x60006E5")]
			[Address(RVA = "0x5AA7BD0", Offset = "0x5AA67D0", VA = "0x185AA7BD0")]
			set
			{
			}
		}

		// Token: 0x060006E6 RID: 1766 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60006E6")]
		[Address(RVA = "0x5AA7140", Offset = "0x5AA5D40", VA = "0x185AA7140", Slot = "108")]
		protected virtual void InitLabel()
		{
		}

		// Token: 0x060006E7 RID: 1767 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60006E7")]
		[Address(RVA = "0x5AA7590", Offset = "0x5AA6190", VA = "0x185AA7590", Slot = "107")]
		public override void SetValueWithoutNotify(bool newValue)
		{
		}

		// Token: 0x060006E8 RID: 1768 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60006E8")]
		[Address(RVA = "0x5AA7230", Offset = "0x5AA5E30", VA = "0x185AA7230")]
		private void OnClickEvent(EventBase evt)
		{
		}

		// Token: 0x060006E9 RID: 1769 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60006E9")]
		[Address(RVA = "0x5AA7680", Offset = "0x5AA6280", VA = "0x185AA7680", Slot = "109")]
		protected virtual void ToggleValue()
		{
		}

		// Token: 0x060006EA RID: 1770 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60006EA")]
		[Address(RVA = "0x5AA76F0", Offset = "0x5AA62F0", VA = "0x185AA76F0", Slot = "106")]
		protected override void UpdateMixedValueContent()
		{
		}

		// Token: 0x0400035C RID: 860
		[Token(Token = "0x400035C")]
		[FieldOffset(Offset = "0x408")]
		protected Label m_Label;

		// Token: 0x0400035D RID: 861
		[Token(Token = "0x400035D")]
		[FieldOffset(Offset = "0x410")]
		protected readonly VisualElement m_CheckMark;

		// Token: 0x0400035E RID: 862
		[Token(Token = "0x400035E")]
		[FieldOffset(Offset = "0x418")]
		internal Clickable m_Clickable;

		// Token: 0x0400035F RID: 863
		[Token(Token = "0x400035F")]
		[FieldOffset(Offset = "0x420")]
		private string m_OriginalText;
	}
}

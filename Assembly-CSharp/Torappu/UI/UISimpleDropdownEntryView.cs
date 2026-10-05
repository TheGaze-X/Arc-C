using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI
{
	// Token: 0x020039F1 RID: 14833
	[Token(Token = "0x20039F1")]
	public class UISimpleDropdownEntryView : MonoBehaviour, IHotfixable
	{
		// Token: 0x17003812 RID: 14354
		// (get) Token: 0x060176AA RID: 95914 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060176AB RID: 95915 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17003812")]
		public Action onItemClicked
		{
			[Token(Token = "0x60176AA")]
			[Address(RVA = "0xFC5F10", Offset = "0xFC4B10", VA = "0x180FC5F10")]
			[CompilerGenerated]
			private get
			{
				return null;
			}
			[Token(Token = "0x60176AB")]
			[Address(RVA = "0xFC5F70", Offset = "0xFC4B70", VA = "0x180FC5F70")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x060176AC RID: 95916 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60176AC")]
		[Address(RVA = "0xFC5B60", Offset = "0xFC4760", VA = "0x180FC5B60")]
		public void Render(ICommonDropdownModel model, bool selected)
		{
		}

		// Token: 0x060176AD RID: 95917 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60176AD")]
		[Address(RVA = "0xFC5C90", Offset = "0xFC4890", VA = "0x180FC5C90")]
		public void ResetStatus(bool selected)
		{
		}

		// Token: 0x060176AE RID: 95918 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60176AE")]
		[Address(RVA = "0xFC5AB0", Offset = "0xFC46B0", VA = "0x180FC5AB0")]
		public void EventOnClicked()
		{
		}

		// Token: 0x060176AF RID: 95919 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60176AF")]
		[Address(RVA = "0xFC5D40", Offset = "0xFC4940", VA = "0x180FC5D40")]
		private void _InitIfNot()
		{
		}

		// Token: 0x060176B0 RID: 95920 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60176B0")]
		[Address(RVA = "0xFC5EB0", Offset = "0xFC4AB0", VA = "0x180FC5EB0")]
		public UISimpleDropdownEntryView()
		{
		}

		// Token: 0x0401C498 RID: 115864
		[Token(Token = "0x401C498")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private CanvasGroup _panelSelected;

		// Token: 0x0401C499 RID: 115865
		[Token(Token = "0x401C499")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private CanvasGroup _panelUnselected;

		// Token: 0x0401C49A RID: 115866
		[Token(Token = "0x401C49A")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Text _textDesc;

		// Token: 0x0401C49B RID: 115867
		[Token(Token = "0x401C49B")]
		[FieldOffset(Offset = "0x30")]
		private bool m_hasInited;

		// Token: 0x0401C49C RID: 115868
		[Token(Token = "0x401C49C")]
		[FieldOffset(Offset = "0x38")]
		private UISwitchTween m_selectedSwitch;

		// Token: 0x0401C49D RID: 115869
		[Token(Token = "0x401C49D")]
		[FieldOffset(Offset = "0x40")]
		private UISwitchTween m_unselectedSwitch;

		// Token: 0x0401C49F RID: 115871
		[Token(Token = "0x401C49F")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_onItemClicked;

		// Token: 0x0401C4A0 RID: 115872
		[Token(Token = "0x401C4A0")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_onItemClicked;

		// Token: 0x0401C4A1 RID: 115873
		[Token(Token = "0x401C4A1")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0401C4A2 RID: 115874
		[Token(Token = "0x401C4A2")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_ResetStatus;

		// Token: 0x0401C4A3 RID: 115875
		[Token(Token = "0x401C4A3")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_EventOnClicked;

		// Token: 0x0401C4A4 RID: 115876
		[Token(Token = "0x401C4A4")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0401C4A5 RID: 115877
		[Token(Token = "0x401C4A5")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}

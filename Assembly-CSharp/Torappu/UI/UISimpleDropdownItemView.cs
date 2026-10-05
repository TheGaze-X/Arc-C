using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI
{
	// Token: 0x020039F2 RID: 14834
	[Token(Token = "0x20039F2")]
	[RequireComponent(typeof(LayoutElement))]
	public class UISimpleDropdownItemView : MonoBehaviour, IHotfixable
	{
		// Token: 0x17003813 RID: 14355
		// (get) Token: 0x060176B1 RID: 95921 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17003813")]
		public LayoutElement layoutElement
		{
			[Token(Token = "0x60176B1")]
			[Address(RVA = "0xFC6380", Offset = "0xFC4F80", VA = "0x180FC6380")]
			get
			{
				return null;
			}
		}

		// Token: 0x060176B2 RID: 95922 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60176B2")]
		[Address(RVA = "0xFC61F0", Offset = "0xFC4DF0", VA = "0x180FC61F0")]
		public void Render(ICommonDropdownModel model, int focusIndex)
		{
		}

		// Token: 0x060176B3 RID: 95923 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60176B3")]
		[Address(RVA = "0xFC6110", Offset = "0xFC4D10", VA = "0x180FC6110")]
		public void EventOnClicked()
		{
		}

		// Token: 0x060176B4 RID: 95924 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60176B4")]
		[Address(RVA = "0xFC6320", Offset = "0xFC4F20", VA = "0x180FC6320")]
		public UISimpleDropdownItemView()
		{
		}

		// Token: 0x0401C4A6 RID: 115878
		[Token(Token = "0x401C4A6")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private GameObject _panelFocused;

		// Token: 0x0401C4A7 RID: 115879
		[Token(Token = "0x401C4A7")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Text _textDesc;

		// Token: 0x0401C4A8 RID: 115880
		[Token(Token = "0x401C4A8")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private GameObject _panelSplit;

		// Token: 0x0401C4A9 RID: 115881
		[Token(Token = "0x401C4A9")]
		[FieldOffset(Offset = "0x30")]
		private int m_cachedIndex;

		// Token: 0x0401C4AA RID: 115882
		[Token(Token = "0x401C4AA")]
		[FieldOffset(Offset = "0x38")]
		private UICompDialogFinder m_dialogFinder;

		// Token: 0x0401C4AB RID: 115883
		[Token(Token = "0x401C4AB")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_layoutElement;

		// Token: 0x0401C4AC RID: 115884
		[Token(Token = "0x401C4AC")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0401C4AD RID: 115885
		[Token(Token = "0x401C4AD")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_EventOnClicked;

		// Token: 0x0401C4AE RID: 115886
		[Token(Token = "0x401C4AE")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}

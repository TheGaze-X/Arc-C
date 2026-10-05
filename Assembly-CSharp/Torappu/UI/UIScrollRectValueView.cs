using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI
{
	// Token: 0x02003A2F RID: 14895
	[Token(Token = "0x2003A2F")]
	[RequireComponent(typeof(Slider))]
	public class UIScrollRectValueView : MonoBehaviour, IHotfixable
	{
		// Token: 0x0601782D RID: 96301 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601782D")]
		[Address(RVA = "0xFD3560", Offset = "0xFD2160", VA = "0x180FD3560")]
		private void OnEnable()
		{
		}

		// Token: 0x0601782E RID: 96302 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601782E")]
		[Address(RVA = "0xFD3440", Offset = "0xFD2040", VA = "0x180FD3440")]
		private void OnDisable()
		{
		}

		// Token: 0x0601782F RID: 96303 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601782F")]
		[Address(RVA = "0xFD3750", Offset = "0xFD2350", VA = "0x180FD3750")]
		private void _OnScrollRectValueChanged(Vector2 scrollValue)
		{
		}

		// Token: 0x06017830 RID: 96304 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6017830")]
		[Address(RVA = "0xFD3680", Offset = "0xFD2280", VA = "0x180FD3680")]
		private Slider _GetScrollBar()
		{
			return null;
		}

		// Token: 0x06017831 RID: 96305 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017831")]
		[Address(RVA = "0xFD38D0", Offset = "0xFD24D0", VA = "0x180FD38D0")]
		public UIScrollRectValueView()
		{
		}

		// Token: 0x0401C644 RID: 116292
		[Token(Token = "0x401C644")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private ScrollRect _scrollRect;

		// Token: 0x0401C645 RID: 116293
		[Token(Token = "0x401C645")]
		[FieldOffset(Offset = "0x20")]
		private Slider m_scrollBar;

		// Token: 0x0401C646 RID: 116294
		[Token(Token = "0x401C646")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnEnable;

		// Token: 0x0401C647 RID: 116295
		[Token(Token = "0x401C647")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnDisable;

		// Token: 0x0401C648 RID: 116296
		[Token(Token = "0x401C648")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__OnScrollRectValueChanged;

		// Token: 0x0401C649 RID: 116297
		[Token(Token = "0x401C649")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__GetScrollBar;

		// Token: 0x0401C64A RID: 116298
		[Token(Token = "0x401C64A")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}

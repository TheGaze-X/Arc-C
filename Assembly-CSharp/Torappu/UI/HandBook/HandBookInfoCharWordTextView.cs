using System;
using System.Collections;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.HandBook
{
	// Token: 0x02006693 RID: 26259
	[Token(Token = "0x2006693")]
	public class HandBookInfoCharWordTextView : PageSingleComponent
	{
		// Token: 0x06025B85 RID: 154501 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025B85")]
		[Address(RVA = "0x20A5380", Offset = "0x20A3F80", VA = "0x1820A5380")]
		private void OnEnable()
		{
		}

		// Token: 0x06025B86 RID: 154502 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025B86")]
		[Address(RVA = "0x20A5160", Offset = "0x20A3D60", VA = "0x1820A5160")]
		public static void InitText(string voiceText, UIPageFinder.Interface pageInterface)
		{
		}

		// Token: 0x06025B87 RID: 154503 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025B87")]
		[Address(RVA = "0x20A5090", Offset = "0x20A3C90", VA = "0x1820A5090")]
		public static void CloseText(UIPageFinder.Interface pageInterface)
		{
		}

		// Token: 0x06025B88 RID: 154504 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025B88")]
		[Address(RVA = "0x20A53E0", Offset = "0x20A3FE0", VA = "0x1820A53E0")]
		private void _CloseText()
		{
		}

		// Token: 0x06025B89 RID: 154505 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025B89")]
		[Address(RVA = "0x20A54B0", Offset = "0x20A40B0", VA = "0x1820A54B0")]
		private void _InitText(string voiceText)
		{
		}

		// Token: 0x06025B8A RID: 154506 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6025B8A")]
		[Address(RVA = "0x20A5610", Offset = "0x20A4210", VA = "0x1820A5610")]
		private IEnumerator _Refresh()
		{
			return null;
		}

		// Token: 0x06025B8B RID: 154507 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025B8B")]
		[Address(RVA = "0x20A56C0", Offset = "0x20A42C0", VA = "0x1820A56C0")]
		public HandBookInfoCharWordTextView()
		{
		}

		// Token: 0x04034FE6 RID: 217062
		[Token(Token = "0x4034FE6")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private CanvasGroup _canvasGroup;

		// Token: 0x04034FE7 RID: 217063
		[Token(Token = "0x4034FE7")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private RectTransform _scrollRect;

		// Token: 0x04034FE8 RID: 217064
		[Token(Token = "0x4034FE8")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private RectTransform _textRect;

		// Token: 0x04034FE9 RID: 217065
		[Token(Token = "0x4034FE9")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Text _voiceText;

		// Token: 0x04034FEA RID: 217066
		[Token(Token = "0x4034FEA")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Image _triangle;

		// Token: 0x04034FEB RID: 217067
		[Token(Token = "0x4034FEB")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnEnable;

		// Token: 0x04034FEC RID: 217068
		[Token(Token = "0x4034FEC")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_InitText;

		// Token: 0x04034FED RID: 217069
		[Token(Token = "0x4034FED")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_CloseText;

		// Token: 0x04034FEE RID: 217070
		[Token(Token = "0x4034FEE")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__CloseText;

		// Token: 0x04034FEF RID: 217071
		[Token(Token = "0x4034FEF")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__InitText;

		// Token: 0x04034FF0 RID: 217072
		[Token(Token = "0x4034FF0")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__Refresh;

		// Token: 0x04034FF1 RID: 217073
		[Token(Token = "0x4034FF1")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}

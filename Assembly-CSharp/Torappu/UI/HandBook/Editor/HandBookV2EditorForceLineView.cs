using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.HandBook.Editor
{
	// Token: 0x02006738 RID: 26424
	[Token(Token = "0x2006738")]
	public class HandBookV2EditorForceLineView : HandBookV2MapForceLineView
	{
		// Token: 0x06025E54 RID: 155220 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025E54")]
		[Address(RVA = "0x20D0470", Offset = "0x20CF070", VA = "0x1820D0470")]
		public void SetSelect(bool isSelected)
		{
		}

		// Token: 0x06025E55 RID: 155221 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025E55")]
		[Address(RVA = "0x20D0510", Offset = "0x20CF110", VA = "0x1820D0510")]
		public void SetVisible(bool isVisible)
		{
		}

		// Token: 0x06025E56 RID: 155222 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025E56")]
		[Address(RVA = "0x20D0590", Offset = "0x20CF190", VA = "0x1820D0590")]
		public HandBookV2EditorForceLineView()
		{
		}

		// Token: 0x040354C9 RID: 218313
		[Token(Token = "0x40354C9")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Image _imgLine;

		// Token: 0x040354CA RID: 218314
		[Token(Token = "0x40354CA")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Sprite _normalSprite;

		// Token: 0x040354CB RID: 218315
		[Token(Token = "0x40354CB")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Sprite _selectedSprite;

		// Token: 0x040354CC RID: 218316
		[Token(Token = "0x40354CC")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_SetSelect;

		// Token: 0x040354CD RID: 218317
		[Token(Token = "0x40354CD")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_SetVisible;

		// Token: 0x040354CE RID: 218318
		[Token(Token = "0x40354CE")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}

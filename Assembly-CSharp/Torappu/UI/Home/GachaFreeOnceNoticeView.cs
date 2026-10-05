using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Home
{
	// Token: 0x02004BEF RID: 19439
	[Token(Token = "0x2004BEF")]
	public class GachaFreeOnceNoticeView : MonoBehaviour, IHotfixable
	{
		// Token: 0x0601D356 RID: 119638 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D356")]
		[Address(RVA = "0x16B7D40", Offset = "0x16B6940", VA = "0x1816B7D40")]
		public void Render(Color color)
		{
		}

		// Token: 0x0601D357 RID: 119639 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D357")]
		[Address(RVA = "0x16B7E40", Offset = "0x16B6A40", VA = "0x1816B7E40")]
		public GachaFreeOnceNoticeView()
		{
		}

		// Token: 0x040265D4 RID: 157140
		[Token(Token = "0x40265D4")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Text _limitFreeTxt;

		// Token: 0x040265D5 RID: 157141
		[Token(Token = "0x40265D5")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Image _leftBkgImg;

		// Token: 0x040265D6 RID: 157142
		[Token(Token = "0x40265D6")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x040265D7 RID: 157143
		[Token(Token = "0x40265D7")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}

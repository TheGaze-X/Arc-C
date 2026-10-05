using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Home.Theme.R6Theme
{
	// Token: 0x02004C71 RID: 19569
	[Token(Token = "0x2004C71")]
	public class HomeThemeR6ApView : HomeThemeApView
	{
		// Token: 0x0601D59D RID: 120221 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D59D")]
		[Address(RVA = "0x16E8530", Offset = "0x16E7130", VA = "0x1816E8530", Slot = "7")]
		public override void OnValueChanged(APInfoProperty property)
		{
		}

		// Token: 0x0601D59E RID: 120222 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D59E")]
		[Address(RVA = "0x16E8760", Offset = "0x16E7360", VA = "0x1816E8760")]
		public HomeThemeR6ApView()
		{
		}

		// Token: 0x040269D1 RID: 158161
		[Token(Token = "0x40269D1")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Image _rotateImg;

		// Token: 0x040269D2 RID: 158162
		[Token(Token = "0x40269D2")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private RectTransform _rotate;

		// Token: 0x040269D3 RID: 158163
		[Token(Token = "0x40269D3")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnValueChanged;

		// Token: 0x040269D4 RID: 158164
		[Token(Token = "0x40269D4")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}

using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Home.Theme
{
	// Token: 0x02004C68 RID: 19560
	[Token(Token = "0x2004C68")]
	public class HomeThemeText : HomeThemeUIElem<HomeThemeTextData>
	{
		// Token: 0x0601D575 RID: 120181 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D575")]
		[Address(RVA = "0x16E8BF0", Offset = "0x16E77F0", VA = "0x1816E8BF0", Slot = "16")]
		protected override void OnUIApply(HomeThemeTextData data, HomeTheme theme)
		{
		}

		// Token: 0x0601D576 RID: 120182 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D576")]
		[Address(RVA = "0x16E8AD0", Offset = "0x16E76D0", VA = "0x1816E8AD0", Slot = "17")]
		protected override void OnFillUIData(HomeThemeTextData data, AssetPathConvertor pathConvertor)
		{
		}

		// Token: 0x0601D577 RID: 120183 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D577")]
		[Address(RVA = "0x16E8D30", Offset = "0x16E7930", VA = "0x1816E8D30")]
		public HomeThemeText()
		{
		}

		// Token: 0x040269A4 RID: 158116
		[Token(Token = "0x40269A4")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Text _text;

		// Token: 0x040269A5 RID: 158117
		[Token(Token = "0x40269A5")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnUIApply;

		// Token: 0x040269A6 RID: 158118
		[Token(Token = "0x40269A6")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnFillUIData;

		// Token: 0x040269A7 RID: 158119
		[Token(Token = "0x40269A7")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}

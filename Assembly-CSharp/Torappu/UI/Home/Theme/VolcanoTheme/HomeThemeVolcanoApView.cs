using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Home.Theme.VolcanoTheme
{
	// Token: 0x02004C70 RID: 19568
	[Token(Token = "0x2004C70")]
	public class HomeThemeVolcanoApView : HomeThemeApView
	{
		// Token: 0x0601D59B RID: 120219 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D59B")]
		[Address(RVA = "0x16E9000", Offset = "0x16E7C00", VA = "0x1816E9000", Slot = "7")]
		public override void OnValueChanged(APInfoProperty property)
		{
		}

		// Token: 0x0601D59C RID: 120220 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D59C")]
		[Address(RVA = "0x16E91B0", Offset = "0x16E7DB0", VA = "0x1816E91B0")]
		public HomeThemeVolcanoApView()
		{
		}

		// Token: 0x040269CD RID: 158157
		[Token(Token = "0x40269CD")]
		private const string AP_MAX_FORMAT = "/{0}";

		// Token: 0x040269CE RID: 158158
		[Token(Token = "0x40269CE")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Text _textApCurrShadow;

		// Token: 0x040269CF RID: 158159
		[Token(Token = "0x40269CF")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnValueChanged;

		// Token: 0x040269D0 RID: 158160
		[Token(Token = "0x40269D0")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}

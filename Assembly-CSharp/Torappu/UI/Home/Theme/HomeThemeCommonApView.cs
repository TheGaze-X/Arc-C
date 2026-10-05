using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Home.Theme
{
	// Token: 0x02004C58 RID: 19544
	[Token(Token = "0x2004C58")]
	public class HomeThemeCommonApView : HomeThemeApView, IHotfixable
	{
		// Token: 0x0601D537 RID: 120119 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D537")]
		[Address(RVA = "0x16E6760", Offset = "0x16E5360", VA = "0x1816E6760", Slot = "7")]
		public override void OnValueChanged(APInfoProperty property)
		{
		}

		// Token: 0x0601D538 RID: 120120 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D538")]
		[Address(RVA = "0x16E6930", Offset = "0x16E5530", VA = "0x1816E6930")]
		public HomeThemeCommonApView()
		{
		}

		// Token: 0x04026967 RID: 158055
		[Token(Token = "0x4026967")]
		private const string AP_MAX_FORMAT = "/{0}";

		// Token: 0x04026968 RID: 158056
		[Token(Token = "0x4026968")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Text _shadowCurr;

		// Token: 0x04026969 RID: 158057
		[Token(Token = "0x4026969")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnValueChanged;

		// Token: 0x0402696A RID: 158058
		[Token(Token = "0x402696A")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}

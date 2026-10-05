using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Home.Theme
{
	// Token: 0x02004C5E RID: 19550
	[Token(Token = "0x2004C5E")]
	public class HomeThemeGraphic : HomeThemeUIElem<HomeThemeGraphicData>
	{
		// Token: 0x0601D556 RID: 120150 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D556")]
		[Address(RVA = "0x16E6BC0", Offset = "0x16E57C0", VA = "0x1816E6BC0", Slot = "16")]
		protected override void OnUIApply(HomeThemeGraphicData data, HomeTheme theme)
		{
		}

		// Token: 0x0601D557 RID: 120151 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D557")]
		[Address(RVA = "0x16E6AB0", Offset = "0x16E56B0", VA = "0x1816E6AB0", Slot = "17")]
		protected override void OnFillUIData(HomeThemeGraphicData data, AssetPathConvertor pathConvertor)
		{
		}

		// Token: 0x0601D558 RID: 120152 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D558")]
		[Address(RVA = "0x16E6CD0", Offset = "0x16E58D0", VA = "0x1816E6CD0")]
		public HomeThemeGraphic()
		{
		}

		// Token: 0x0402697B RID: 158075
		[Token(Token = "0x402697B")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Graphic _graphic;

		// Token: 0x0402697C RID: 158076
		[Token(Token = "0x402697C")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnUIApply;

		// Token: 0x0402697D RID: 158077
		[Token(Token = "0x402697D")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnFillUIData;

		// Token: 0x0402697E RID: 158078
		[Token(Token = "0x402697E")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}

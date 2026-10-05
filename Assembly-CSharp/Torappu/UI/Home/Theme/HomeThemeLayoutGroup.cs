using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Home.Theme
{
	// Token: 0x02004C62 RID: 19554
	[Token(Token = "0x2004C62")]
	public class HomeThemeLayoutGroup : HomeThemeUIElem<HomeThemeLayoutGroupData>, IHotfixable
	{
		// Token: 0x0601D561 RID: 120161 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D561")]
		[Address(RVA = "0x16E7890", Offset = "0x16E6490", VA = "0x1816E7890", Slot = "16")]
		protected override void OnUIApply(HomeThemeLayoutGroupData data, HomeTheme theme)
		{
		}

		// Token: 0x0601D562 RID: 120162 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D562")]
		[Address(RVA = "0x16E7770", Offset = "0x16E6370", VA = "0x1816E7770", Slot = "17")]
		protected override void OnFillUIData(HomeThemeLayoutGroupData data, AssetPathConvertor pathConvertor)
		{
		}

		// Token: 0x0601D563 RID: 120163 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D563")]
		[Address(RVA = "0x16E7A10", Offset = "0x16E6610", VA = "0x1816E7A10")]
		public HomeThemeLayoutGroup()
		{
		}

		// Token: 0x0402698E RID: 158094
		[Token(Token = "0x402698E")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private HorizontalOrVerticalLayoutGroup _layoutGroup;

		// Token: 0x0402698F RID: 158095
		[Token(Token = "0x402698F")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnUIApply;

		// Token: 0x04026990 RID: 158096
		[Token(Token = "0x4026990")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnFillUIData;

		// Token: 0x04026991 RID: 158097
		[Token(Token = "0x4026991")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}

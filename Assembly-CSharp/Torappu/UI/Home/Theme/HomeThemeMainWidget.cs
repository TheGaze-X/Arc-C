using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.Home.Theme
{
	// Token: 0x02004C63 RID: 19555
	[Token(Token = "0x2004C63")]
	public class HomeThemeMainWidget : HomeThemePrefab
	{
		// Token: 0x0601D564 RID: 120164 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D564")]
		[Address(RVA = "0x16E7A80", Offset = "0x16E6680", VA = "0x1816E7A80", Slot = "18")]
		protected override void OnPrefabApplied(GameObject inst)
		{
		}

		// Token: 0x0601D565 RID: 120165 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D565")]
		[Address(RVA = "0x16E7BC0", Offset = "0x16E67C0", VA = "0x1816E7BC0")]
		public HomeThemeMainWidget()
		{
		}

		// Token: 0x0601D566 RID: 120166 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D566")]
		[Address(RVA = "0x16E7B60", Offset = "0x16E6760", VA = "0x1816E7B60")]
		private void <>xLuaBaseProxy_OnPrefabApplied(GameObject P0)
		{
		}

		// Token: 0x04026992 RID: 158098
		[Token(Token = "0x4026992")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private HomeMainWidgetHolder _widgetHolder;

		// Token: 0x04026993 RID: 158099
		[Token(Token = "0x4026993")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnPrefabApplied;

		// Token: 0x04026994 RID: 158100
		[Token(Token = "0x4026994")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}

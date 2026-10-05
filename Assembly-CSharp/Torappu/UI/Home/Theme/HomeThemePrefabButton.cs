using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.Home.Theme
{
	// Token: 0x02004C66 RID: 19558
	[Token(Token = "0x2004C66")]
	public class HomeThemePrefabButton : HomeThemePrefab
	{
		// Token: 0x0601D570 RID: 120176 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D570")]
		[Address(RVA = "0x16E7C70", Offset = "0x16E6870", VA = "0x1816E7C70", Slot = "18")]
		protected override void OnPrefabApplied(GameObject inst)
		{
		}

		// Token: 0x0601D571 RID: 120177 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D571")]
		[Address(RVA = "0x16E7D70", Offset = "0x16E6970", VA = "0x1816E7D70")]
		public HomeThemePrefabButton()
		{
		}

		// Token: 0x0601D572 RID: 120178 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D572")]
		[Address(RVA = "0x16E7B60", Offset = "0x16E6760", VA = "0x1816E7B60")]
		private void <>xLuaBaseProxy_OnPrefabApplied(GameObject P0)
		{
		}

		// Token: 0x0402699E RID: 158110
		[Token(Token = "0x402699E")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private GameObject _defaultContent;

		// Token: 0x0402699F RID: 158111
		[Token(Token = "0x402699F")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private UIColorGraphic _btnColor;

		// Token: 0x040269A0 RID: 158112
		[Token(Token = "0x40269A0")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnPrefabApplied;

		// Token: 0x040269A1 RID: 158113
		[Token(Token = "0x40269A1")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}

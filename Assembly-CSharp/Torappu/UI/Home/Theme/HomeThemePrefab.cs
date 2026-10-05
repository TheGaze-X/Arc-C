using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.Home.Theme
{
	// Token: 0x02004C65 RID: 19557
	[Token(Token = "0x2004C65")]
	public class HomeThemePrefab : HomeThemeUIElem<HomeThemePrefabData>
	{
		// Token: 0x0601D569 RID: 120169 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D569")]
		[Address(RVA = "0x16E80B0", Offset = "0x16E6CB0", VA = "0x1816E80B0", Slot = "17")]
		protected sealed override void OnFillUIData(HomeThemePrefabData data, AssetPathConvertor pathConvertor)
		{
		}

		// Token: 0x0601D56A RID: 120170 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D56A")]
		[Address(RVA = "0x16E81C0", Offset = "0x16E6DC0", VA = "0x1816E81C0", Slot = "11")]
		public override void OnGenData()
		{
		}

		// Token: 0x0601D56B RID: 120171 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D56B")]
		[Address(RVA = "0x16E8250", Offset = "0x16E6E50", VA = "0x1816E8250", Slot = "16")]
		protected sealed override void OnUIApply(HomeThemePrefabData data, HomeTheme theme)
		{
		}

		// Token: 0x0601D56C RID: 120172 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D56C")]
		[Address(RVA = "0x16E7FD0", Offset = "0x16E6BD0", VA = "0x1816E7FD0", Slot = "15")]
		protected override void OnClearRef()
		{
		}

		// Token: 0x0601D56D RID: 120173 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D56D")]
		[Address(RVA = "0x16E7EF0", Offset = "0x16E6AF0", VA = "0x1816E7EF0", Slot = "13")]
		protected override void OnApplyEmpty()
		{
		}

		// Token: 0x0601D56E RID: 120174 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D56E")]
		[Address(RVA = "0x16E7B60", Offset = "0x16E6760", VA = "0x1816E7B60", Slot = "18")]
		protected virtual void OnPrefabApplied(GameObject inst)
		{
		}

		// Token: 0x0601D56F RID: 120175 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D56F")]
		[Address(RVA = "0x16E84C0", Offset = "0x16E70C0", VA = "0x1816E84C0")]
		public HomeThemePrefab()
		{
		}

		// Token: 0x04026996 RID: 158102
		[Token(Token = "0x4026996")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private PrefabDisplay _prefab;

		// Token: 0x04026997 RID: 158103
		[Token(Token = "0x4026997")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnFillUIData;

		// Token: 0x04026998 RID: 158104
		[Token(Token = "0x4026998")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnGenData;

		// Token: 0x04026999 RID: 158105
		[Token(Token = "0x4026999")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnUIApply;

		// Token: 0x0402699A RID: 158106
		[Token(Token = "0x402699A")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnClearRef;

		// Token: 0x0402699B RID: 158107
		[Token(Token = "0x402699B")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_OnApplyEmpty;

		// Token: 0x0402699C RID: 158108
		[Token(Token = "0x402699C")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_OnPrefabApplied;

		// Token: 0x0402699D RID: 158109
		[Token(Token = "0x402699D")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}

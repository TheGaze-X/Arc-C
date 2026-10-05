using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.Home.Theme
{
	// Token: 0x02004C69 RID: 19561
	[Token(Token = "0x2004C69")]
	public class HomeThemeTrackPointHolder : HomeThemePrefab
	{
		// Token: 0x0601D578 RID: 120184 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D578")]
		[Address(RVA = "0x16E8DA0", Offset = "0x16E79A0", VA = "0x1816E8DA0", Slot = "18")]
		protected override void OnPrefabApplied(GameObject inst)
		{
		}

		// Token: 0x0601D579 RID: 120185 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D579")]
		[Address(RVA = "0x16E8E60", Offset = "0x16E7A60", VA = "0x1816E8E60")]
		public HomeThemeTrackPointHolder()
		{
		}

		// Token: 0x0601D57A RID: 120186 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D57A")]
		[Address(RVA = "0x16E7B60", Offset = "0x16E6760", VA = "0x1816E7B60")]
		private void <>xLuaBaseProxy_OnPrefabApplied(GameObject P0)
		{
		}

		// Token: 0x040269A8 RID: 158120
		[Token(Token = "0x40269A8")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private UIHomeThemeTrackPoint _trackPointHandler;

		// Token: 0x040269A9 RID: 158121
		[Token(Token = "0x40269A9")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnPrefabApplied;

		// Token: 0x040269AA RID: 158122
		[Token(Token = "0x40269AA")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}

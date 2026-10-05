using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Battle
{
	// Token: 0x020024ED RID: 9453
	[Token(Token = "0x20024ED")]
	public class AdvancedSelectorWithID : AdvancedSelector
	{
		// Token: 0x0600F38E RID: 62350 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F38E")]
		[Address(RVA = "0x69E090", Offset = "0x69CC90", VA = "0x18069E090", Slot = "37")]
		protected override void OnPostFilter(List<Entity> candidates)
		{
		}

		// Token: 0x0600F38F RID: 62351 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F38F")]
		[Address(RVA = "0x69E1C0", Offset = "0x69CDC0", VA = "0x18069E1C0")]
		public AdvancedSelectorWithID()
		{
		}

		// Token: 0x0600F390 RID: 62352 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F390")]
		[Address(RVA = "0x69A940", Offset = "0x699540", VA = "0x18069A940")]
		private void <>xLuaBaseProxy_OnPostFilter(List<Entity> P0)
		{
		}

		// Token: 0x04010D9B RID: 69019
		[Token(Token = "0x4010D9B")]
		[FieldOffset(Offset = "0xF0")]
		[SerializeField]
		private string _filterID;

		// Token: 0x04010D9C RID: 69020
		[Token(Token = "0x4010D9C")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnPostFilter;

		// Token: 0x04010D9D RID: 69021
		[Token(Token = "0x4010D9D")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}

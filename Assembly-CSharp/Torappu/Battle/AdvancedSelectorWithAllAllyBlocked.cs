using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Battle
{
	// Token: 0x020024E4 RID: 9444
	[Token(Token = "0x20024E4")]
	public class AdvancedSelectorWithAllAllyBlocked : AdvancedSelector
	{
		// Token: 0x0600F362 RID: 62306 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F362")]
		[Address(RVA = "0x69B640", Offset = "0x69A240", VA = "0x18069B640", Slot = "37")]
		protected override void OnPostFilter(List<Entity> candidates)
		{
		}

		// Token: 0x0600F363 RID: 62307 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F363")]
		[Address(RVA = "0x69BA00", Offset = "0x69A600", VA = "0x18069BA00")]
		public AdvancedSelectorWithAllAllyBlocked()
		{
		}

		// Token: 0x0600F364 RID: 62308 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F364")]
		[Address(RVA = "0x69A940", Offset = "0x699540", VA = "0x18069A940")]
		private void <>xLuaBaseProxy_OnPostFilter(List<Entity> P0)
		{
		}

		// Token: 0x04010D4E RID: 68942
		[Token(Token = "0x4010D4E")]
		[FieldOffset(Offset = "0xF0")]
		[SerializeField]
		public bool _excludeToken;

		// Token: 0x04010D4F RID: 68943
		[Token(Token = "0x4010D4F")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnPostFilter;

		// Token: 0x04010D50 RID: 68944
		[Token(Token = "0x4010D50")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}

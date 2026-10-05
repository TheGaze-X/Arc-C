using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Battle
{
	// Token: 0x020024EB RID: 9451
	[Token(Token = "0x20024EB")]
	public class AdvancedSelectorWithGroupTag : AdvancedSelector
	{
		// Token: 0x0600F383 RID: 62339 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F383")]
		[Address(RVA = "0x69D000", Offset = "0x69BC00", VA = "0x18069D000", Slot = "37")]
		protected override void OnPostFilter(List<Entity> candidates)
		{
		}

		// Token: 0x0600F384 RID: 62340 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F384")]
		[Address(RVA = "0x69D220", Offset = "0x69BE20", VA = "0x18069D220")]
		public AdvancedSelectorWithGroupTag()
		{
		}

		// Token: 0x0600F385 RID: 62341 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F385")]
		[Address(RVA = "0x69A940", Offset = "0x699540", VA = "0x18069A940")]
		private void <>xLuaBaseProxy_OnPostFilter(List<Entity> P0)
		{
		}

		// Token: 0x04010D8D RID: 69005
		[Token(Token = "0x4010D8D")]
		[FieldOffset(Offset = "0xF0")]
		[SerializeField]
		private string _groupTag;

		// Token: 0x04010D8E RID: 69006
		[Token(Token = "0x4010D8E")]
		[FieldOffset(Offset = "0xF8")]
		[SerializeField]
		private bool _tagExcluded;

		// Token: 0x04010D8F RID: 69007
		[Token(Token = "0x4010D8F")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnPostFilter;

		// Token: 0x04010D90 RID: 69008
		[Token(Token = "0x4010D90")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}

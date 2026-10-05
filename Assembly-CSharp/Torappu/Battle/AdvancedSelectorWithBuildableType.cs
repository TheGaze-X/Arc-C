using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Battle
{
	// Token: 0x020024E6 RID: 9446
	[Token(Token = "0x20024E6")]
	public class AdvancedSelectorWithBuildableType : AdvancedSelector
	{
		// Token: 0x0600F36B RID: 62315 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F36B")]
		[Address(RVA = "0x69BF40", Offset = "0x69AB40", VA = "0x18069BF40", Slot = "37")]
		protected override void OnPostFilter(List<Entity> candidates)
		{
		}

		// Token: 0x0600F36C RID: 62316 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F36C")]
		[Address(RVA = "0x69C0F0", Offset = "0x69ACF0", VA = "0x18069C0F0")]
		public AdvancedSelectorWithBuildableType()
		{
		}

		// Token: 0x0600F36D RID: 62317 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F36D")]
		[Address(RVA = "0x69A940", Offset = "0x699540", VA = "0x18069A940")]
		private void <>xLuaBaseProxy_OnPostFilter(List<Entity> P0)
		{
		}

		// Token: 0x04010D5B RID: 68955
		[Token(Token = "0x4010D5B")]
		[FieldOffset(Offset = "0xF0")]
		[SerializeField]
		private BuildableType _buildableType;

		// Token: 0x04010D5C RID: 68956
		[Token(Token = "0x4010D5C")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnPostFilter;

		// Token: 0x04010D5D RID: 68957
		[Token(Token = "0x4010D5D")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}

using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Battle
{
	// Token: 0x020024E3 RID: 9443
	[Token(Token = "0x20024E3")]
	public class AdvancedSelectorWithAbnormalFlag : AdvancedSelector
	{
		// Token: 0x0600F35F RID: 62303 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F35F")]
		[Address(RVA = "0x69B370", Offset = "0x699F70", VA = "0x18069B370", Slot = "37")]
		protected override void OnPostFilter(List<Entity> candidates)
		{
		}

		// Token: 0x0600F360 RID: 62304 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F360")]
		[Address(RVA = "0x69B5E0", Offset = "0x69A1E0", VA = "0x18069B5E0")]
		public AdvancedSelectorWithAbnormalFlag()
		{
		}

		// Token: 0x0600F361 RID: 62305 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F361")]
		[Address(RVA = "0x69A940", Offset = "0x699540", VA = "0x18069A940")]
		private void <>xLuaBaseProxy_OnPostFilter(List<Entity> P0)
		{
		}

		// Token: 0x04010D49 RID: 68937
		[Token(Token = "0x4010D49")]
		[FieldOffset(Offset = "0xF0")]
		[SerializeField]
		private bool _abnormalFlagExcluded;

		// Token: 0x04010D4A RID: 68938
		[Token(Token = "0x4010D4A")]
		[FieldOffset(Offset = "0xF8")]
		[SerializeField]
		private AbnormalFlag[] _abnormalFlags;

		// Token: 0x04010D4B RID: 68939
		[Token(Token = "0x4010D4B")]
		[FieldOffset(Offset = "0x100")]
		[SerializeField]
		private bool _filterAbnormalImmune;

		// Token: 0x04010D4C RID: 68940
		[Token(Token = "0x4010D4C")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnPostFilter;

		// Token: 0x04010D4D RID: 68941
		[Token(Token = "0x4010D4D")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}

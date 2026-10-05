using System;
using System.Collections.Generic;
using AdvancedInspector;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Battle
{
	// Token: 0x020024F1 RID: 9457
	[Token(Token = "0x20024F1")]
	public class AdvancedSelectorWithMassRange : AdvancedSelector
	{
		// Token: 0x0600F3A1 RID: 62369 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F3A1")]
		[Address(RVA = "0x69E430", Offset = "0x69D030", VA = "0x18069E430", Slot = "37")]
		protected override void OnPostFilter(List<Entity> candidates)
		{
		}

		// Token: 0x0600F3A2 RID: 62370 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F3A2")]
		[Address(RVA = "0x69E690", Offset = "0x69D290", VA = "0x18069E690")]
		public AdvancedSelectorWithMassRange()
		{
		}

		// Token: 0x0600F3A3 RID: 62371 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F3A3")]
		[Address(RVA = "0x69A940", Offset = "0x699540", VA = "0x18069A940")]
		private void <>xLuaBaseProxy_OnPostFilter(List<Entity> P0)
		{
		}

		// Token: 0x04010DBB RID: 69051
		[Token(Token = "0x4010DBB")]
		[FieldOffset(Offset = "0xF0")]
		[SerializeField]
		[Group("MassCondition")]
		private CompareType _condType;

		// Token: 0x04010DBC RID: 69052
		[Token(Token = "0x4010DBC")]
		[FieldOffset(Offset = "0xF4")]
		[SerializeField]
		[Group("MassCondition")]
		private int _massLevel;

		// Token: 0x04010DBD RID: 69053
		[Token(Token = "0x4010DBD")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnPostFilter;

		// Token: 0x04010DBE RID: 69054
		[Token(Token = "0x4010DBE")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}

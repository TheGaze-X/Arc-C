using System;
using System.Collections.Generic;
using AdvancedInspector;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Battle
{
	// Token: 0x020024DF RID: 9439
	[Token(Token = "0x20024DF")]
	public class AdvancedSelectorBaseOnOwnerTile : AdvancedSelector
	{
		// Token: 0x17001FB4 RID: 8116
		// (get) Token: 0x0600F349 RID: 62281 RVA: 0x00059C70 File Offset: 0x00057E70
		[Token(Token = "0x17001FB4")]
		private bool filterEnemyMassLevel
		{
			[Token(Token = "0x600F349")]
			[Address(RVA = "0x69A9C0", Offset = "0x6995C0", VA = "0x18069A9C0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x0600F34A RID: 62282 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F34A")]
		[Address(RVA = "0x69A5E0", Offset = "0x6991E0", VA = "0x18069A5E0", Slot = "37")]
		protected override void OnPostFilter(List<Entity> candidates)
		{
		}

		// Token: 0x0600F34B RID: 62283 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F34B")]
		[Address(RVA = "0x69A950", Offset = "0x699550", VA = "0x18069A950")]
		public AdvancedSelectorBaseOnOwnerTile()
		{
		}

		// Token: 0x0600F34C RID: 62284 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F34C")]
		[Address(RVA = "0x69A940", Offset = "0x699540", VA = "0x18069A940")]
		private void <>xLuaBaseProxy_OnPostFilter(List<Entity> P0)
		{
		}

		// Token: 0x04010D33 RID: 68915
		[Token(Token = "0x4010D33")]
		[FieldOffset(Offset = "0xF0")]
		[SerializeField]
		private bool _filterEnemyMassLevel;

		// Token: 0x04010D34 RID: 68916
		[Token(Token = "0x4010D34")]
		[FieldOffset(Offset = "0xF4")]
		[SerializeField]
		[Inspect("filterEnemyMassLevel")]
		private CompareType _massLevelCondType;

		// Token: 0x04010D35 RID: 68917
		[Token(Token = "0x4010D35")]
		[FieldOffset(Offset = "0xF8")]
		[SerializeField]
		[Inspect("filterEnemyMassLevel")]
		private int _massLevelToCompare;

		// Token: 0x04010D36 RID: 68918
		[Token(Token = "0x4010D36")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_filterEnemyMassLevel;

		// Token: 0x04010D37 RID: 68919
		[Token(Token = "0x4010D37")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnPostFilter;

		// Token: 0x04010D38 RID: 68920
		[Token(Token = "0x4010D38")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}

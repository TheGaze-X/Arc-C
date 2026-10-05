using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Battle
{
	// Token: 0x0200252D RID: 9517
	[Token(Token = "0x200252D")]
	public class AdvancedSelectorInSandbox : AdvancedSelector
	{
		// Token: 0x17002025 RID: 8229
		// (get) Token: 0x0600F5A1 RID: 62881 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17002025")]
		private Enemy ownerE
		{
			[Token(Token = "0x600F5A1")]
			[Address(RVA = "0x6CF210", Offset = "0x6CDE10", VA = "0x1806CF210")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600F5A2 RID: 62882 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F5A2")]
		[Address(RVA = "0x6CE060", Offset = "0x6CCC60", VA = "0x1806CE060", Slot = "37")]
		protected override void OnPostFilter(List<Entity> candidates)
		{
		}

		// Token: 0x0600F5A3 RID: 62883 RVA: 0x0005B4B8 File Offset: 0x000596B8
		[Token(Token = "0x600F5A3")]
		[Address(RVA = "0x6CEF70", Offset = "0x6CDB70", VA = "0x1806CEF70")]
		private bool _Filter_TransferRes(Entity candidate, Entity source, out FP weight, out FP priorWeight)
		{
			return default(bool);
		}

		// Token: 0x0600F5A4 RID: 62884 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F5A4")]
		[Address(RVA = "0x6CED90", Offset = "0x6CD990", VA = "0x1806CED90")]
		private void _CheckBuff(IList<Entity> candidates, string buffKey)
		{
		}

		// Token: 0x0600F5A5 RID: 62885 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F5A5")]
		[Address(RVA = "0x6CF180", Offset = "0x6CDD80", VA = "0x1806CF180")]
		public AdvancedSelectorInSandbox()
		{
		}

		// Token: 0x0600F5A6 RID: 62886 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F5A6")]
		[Address(RVA = "0x69A940", Offset = "0x699540", VA = "0x18069A940")]
		private void <>xLuaBaseProxy_OnPostFilter(List<Entity> P0)
		{
		}

		// Token: 0x04011054 RID: 69716
		[Token(Token = "0x4011054")]
		[FieldOffset(Offset = "0xF0")]
		[SerializeField]
		private AdvancedSelectorInSandbox.SandboxFilterType _filter;

		// Token: 0x04011055 RID: 69717
		[Token(Token = "0x4011055")]
		[FieldOffset(Offset = "0xF8")]
		[SerializeField]
		private string _filterTag;

		// Token: 0x04011056 RID: 69718
		[Token(Token = "0x4011056")]
		[FieldOffset(Offset = "0x100")]
		[SerializeField]
		private List<string> _buffs;

		// Token: 0x04011057 RID: 69719
		[Token(Token = "0x4011057")]
		[FieldOffset(Offset = "0x108")]
		[SerializeField]
		private bool _buffKeyExcluded;

		// Token: 0x04011058 RID: 69720
		[Token(Token = "0x4011058")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_ownerE;

		// Token: 0x04011059 RID: 69721
		[Token(Token = "0x4011059")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnPostFilter;

		// Token: 0x0401105A RID: 69722
		[Token(Token = "0x401105A")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__Filter_TransferRes;

		// Token: 0x0401105B RID: 69723
		[Token(Token = "0x401105B")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__CheckBuff;

		// Token: 0x0401105C RID: 69724
		[Token(Token = "0x401105C")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x0200252E RID: 9518
		[Token(Token = "0x200252E")]
		public enum SandboxFilterType
		{
			// Token: 0x0401105E RID: 69726
			[Token(Token = "0x401105E")]
			SANDBOX_TRANSFER_RES,
			// Token: 0x0401105F RID: 69727
			[Token(Token = "0x401105F")]
			REMOVE_CANNOT_BE_TRACED,
			// Token: 0x04011060 RID: 69728
			[Token(Token = "0x4011060")]
			RANDOM_NEAREST,
			// Token: 0x04011061 RID: 69729
			[Token(Token = "0x4011061")]
			TRACE_TARGET_ONLY
		}
	}
}

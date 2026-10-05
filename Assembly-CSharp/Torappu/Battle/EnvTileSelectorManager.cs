using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Battle
{
	// Token: 0x02002322 RID: 8994
	[Token(Token = "0x2002322")]
	public class EnvTileSelectorManager : PeriodicTriggerManager
	{
		// Token: 0x17001C82 RID: 7298
		// (get) Token: 0x0600E338 RID: 58168 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17001C82")]
		public override IEnumerable<GlobalEnvSystem.EnvManager.BattleEventGroup> eventGroups
		{
			[Token(Token = "0x600E338")]
			[Address(RVA = "0x571290", Offset = "0x56FE90", VA = "0x180571290", Slot = "14")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600E339 RID: 58169 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E339")]
		[Address(RVA = "0x571090", Offset = "0x56FC90", VA = "0x180571090")]
		private void _OnUnitBorn(object arg)
		{
		}

		// Token: 0x0600E33A RID: 58170 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E33A")]
		[Address(RVA = "0x570D40", Offset = "0x56F940", VA = "0x180570D40", Slot = "17")]
		public override void UpdateCandidates()
		{
		}

		// Token: 0x0600E33B RID: 58171 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E33B")]
		[Address(RVA = "0x570C70", Offset = "0x56F870", VA = "0x180570C70", Slot = "19")]
		public override void FilterTargets()
		{
		}

		// Token: 0x0600E33C RID: 58172 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E33C")]
		[Address(RVA = "0x571230", Offset = "0x56FE30", VA = "0x180571230")]
		public EnvTileSelectorManager()
		{
		}

		// Token: 0x0600E33D RID: 58173 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600E33D")]
		[Address(RVA = "0x550C20", Offset = "0x54F820", VA = "0x180550C20")]
		private IEnumerable<GlobalEnvSystem.EnvManager.BattleEventGroup> <>xLuaBaseProxy_get_eventGroups()
		{
			return null;
		}

		// Token: 0x0600E33E RID: 58174 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E33E")]
		[Address(RVA = "0x570D30", Offset = "0x56F930", VA = "0x180570D30")]
		private void <>xLuaBaseProxy_UpdateCandidates()
		{
		}

		// Token: 0x0600E33F RID: 58175 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E33F")]
		[Address(RVA = "0x570D20", Offset = "0x56F920", VA = "0x180570D20")]
		private void <>xLuaBaseProxy_FilterTargets()
		{
		}

		// Token: 0x0400F97E RID: 63870
		[Token(Token = "0x400F97E")]
		[FieldOffset(Offset = "0xA8")]
		[SerializeField]
		private string _bornEvent;

		// Token: 0x0400F97F RID: 63871
		[Token(Token = "0x400F97F")]
		[FieldOffset(Offset = "0xB0")]
		[SerializeField]
		private List<string> _entityIdList;

		// Token: 0x0400F980 RID: 63872
		[Token(Token = "0x400F980")]
		[FieldOffset(Offset = "0xB8")]
		[SerializeField]
		private EnvTileSelectorManager.FilterType _tileFilterType;

		// Token: 0x0400F981 RID: 63873
		[Token(Token = "0x400F981")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_eventGroups;

		// Token: 0x0400F982 RID: 63874
		[Token(Token = "0x400F982")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__OnUnitBorn;

		// Token: 0x0400F983 RID: 63875
		[Token(Token = "0x400F983")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_UpdateCandidates;

		// Token: 0x0400F984 RID: 63876
		[Token(Token = "0x400F984")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_FilterTargets;

		// Token: 0x0400F985 RID: 63877
		[Token(Token = "0x400F985")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02002323 RID: 8995
		[Token(Token = "0x2002323")]
		public enum FilterType
		{
			// Token: 0x0400F987 RID: 63879
			[Token(Token = "0x400F987")]
			ALL,
			// Token: 0x0400F988 RID: 63880
			[Token(Token = "0x400F988")]
			EMPTY_BUILDABLE
		}
	}
}

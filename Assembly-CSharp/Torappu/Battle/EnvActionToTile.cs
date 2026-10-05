using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.Battle.Action;
using UnityEngine;
using XLua;

namespace Torappu.Battle
{
	// Token: 0x02002280 RID: 8832
	[Token(Token = "0x2002280")]
	public class EnvActionToTile : GlobalEnvSystem.EnvEventExecutor
	{
		// Token: 0x17001BED RID: 7149
		// (get) Token: 0x0600DE31 RID: 56881 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17001BED")]
		public new Context context
		{
			[Token(Token = "0x600DE31")]
			[Address(RVA = "0x3633880", Offset = "0x3632480", VA = "0x183633880")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600DE32 RID: 56882 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600DE32")]
		[Address(RVA = "0x3633500", Offset = "0x3632100", VA = "0x183633500", Slot = "15")]
		public override void OnEnvChanged(Tile tile, string status)
		{
		}

		// Token: 0x0600DE33 RID: 56883 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600DE33")]
		[Address(RVA = "0x36335D0", Offset = "0x36321D0", VA = "0x1836335D0")]
		public void RunActionsOnTarget(Tile tile)
		{
		}

		// Token: 0x0600DE34 RID: 56884 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600DE34")]
		[Address(RVA = "0x3633460", Offset = "0x3632060", VA = "0x183633460", Slot = "11")]
		public override void GatherActionNodes(List<ActionNode> results)
		{
		}

		// Token: 0x0600DE35 RID: 56885 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600DE35")]
		[Address(RVA = "0x36337E0", Offset = "0x36323E0", VA = "0x1836337E0")]
		public EnvActionToTile()
		{
		}

		// Token: 0x0600DE36 RID: 56886 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600DE36")]
		[Address(RVA = "0x36337D0", Offset = "0x36323D0", VA = "0x1836337D0")]
		private void <>xLuaBaseProxy_OnEnvChanged(Tile P0, string P1)
		{
		}

		// Token: 0x0600DE37 RID: 56887 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600DE37")]
		[Address(RVA = "0x550BB0", Offset = "0x54F7B0", VA = "0x180550BB0")]
		private void <>xLuaBaseProxy_GatherActionNodes(List<ActionNode> P0)
		{
		}

		// Token: 0x0400F0F8 RID: 61688
		[Token(Token = "0x400F0F8")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private List<string> _envStatus;

		// Token: 0x0400F0F9 RID: 61689
		[Token(Token = "0x400F0F9")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private List<Blackboard.DataPair> _blackboardPairs;

		// Token: 0x0400F0FA RID: 61690
		[Token(Token = "0x400F0FA")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private ActionArray _actions;

		// Token: 0x0400F0FB RID: 61691
		[Token(Token = "0x400F0FB")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_context;

		// Token: 0x0400F0FC RID: 61692
		[Token(Token = "0x400F0FC")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnEnvChanged;

		// Token: 0x0400F0FD RID: 61693
		[Token(Token = "0x400F0FD")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_RunActionsOnTarget;

		// Token: 0x0400F0FE RID: 61694
		[Token(Token = "0x400F0FE")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_GatherActionNodes;

		// Token: 0x0400F0FF RID: 61695
		[Token(Token = "0x400F0FF")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}

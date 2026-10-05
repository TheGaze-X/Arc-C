using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.Battle.Action;
using UnityEngine;
using XLua;

namespace Torappu.Battle
{
	// Token: 0x02002282 RID: 8834
	[Token(Token = "0x2002282")]
	public class EnvActionToUnitOnTile : GlobalEnvSystem.EnvEventExecutor
	{
		// Token: 0x17001BEE RID: 7150
		// (get) Token: 0x0600DE40 RID: 56896 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17001BEE")]
		public new Context context
		{
			[Token(Token = "0x600DE40")]
			[Address(RVA = "0x3633FB0", Offset = "0x3632BB0", VA = "0x183633FB0")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600DE41 RID: 56897 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600DE41")]
		[Address(RVA = "0x36339A0", Offset = "0x36325A0", VA = "0x1836339A0", Slot = "7")]
		public override void Init(GlobalEnvSystem owner)
		{
		}

		// Token: 0x0600DE42 RID: 56898 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600DE42")]
		[Address(RVA = "0x3633A50", Offset = "0x3632650", VA = "0x183633A50", Slot = "15")]
		public override void OnEnvChanged(Tile tile, string status)
		{
		}

		// Token: 0x0600DE43 RID: 56899 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600DE43")]
		[Address(RVA = "0x3633C90", Offset = "0x3632890", VA = "0x183633C90")]
		public void RunActionsOnTarget(Entity entity)
		{
		}

		// Token: 0x0600DE44 RID: 56900 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600DE44")]
		[Address(RVA = "0x3633900", Offset = "0x3632500", VA = "0x183633900", Slot = "11")]
		public override void GatherActionNodes(List<ActionNode> results)
		{
		}

		// Token: 0x0600DE45 RID: 56901 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600DE45")]
		[Address(RVA = "0x3633F00", Offset = "0x3632B00", VA = "0x183633F00")]
		public EnvActionToUnitOnTile()
		{
		}

		// Token: 0x0600DE46 RID: 56902 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600DE46")]
		[Address(RVA = "0x3633EF0", Offset = "0x3632AF0", VA = "0x183633EF0")]
		private void <>xLuaBaseProxy_Init(GlobalEnvSystem P0)
		{
		}

		// Token: 0x0600DE47 RID: 56903 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600DE47")]
		[Address(RVA = "0x36337D0", Offset = "0x36323D0", VA = "0x1836337D0")]
		private void <>xLuaBaseProxy_OnEnvChanged(Tile P0, string P1)
		{
		}

		// Token: 0x0600DE48 RID: 56904 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600DE48")]
		[Address(RVA = "0x550BB0", Offset = "0x54F7B0", VA = "0x180550BB0")]
		private void <>xLuaBaseProxy_GatherActionNodes(List<ActionNode> P0)
		{
		}

		// Token: 0x0400F108 RID: 61704
		[Token(Token = "0x400F108")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		public List<string> _envStatus;

		// Token: 0x0400F109 RID: 61705
		[Token(Token = "0x400F109")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		protected TargetOptions _options;

		// Token: 0x0400F10A RID: 61706
		[Token(Token = "0x400F10A")]
		[FieldOffset(Offset = "0x98")]
		[SerializeField]
		protected List<Blackboard.DataPair> _blackboardPairs;

		// Token: 0x0400F10B RID: 61707
		[Token(Token = "0x400F10B")]
		[FieldOffset(Offset = "0xA0")]
		[SerializeField]
		private ActionArray _actions;

		// Token: 0x0400F10C RID: 61708
		[Token(Token = "0x400F10C")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_context;

		// Token: 0x0400F10D RID: 61709
		[Token(Token = "0x400F10D")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_Init;

		// Token: 0x0400F10E RID: 61710
		[Token(Token = "0x400F10E")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnEnvChanged;

		// Token: 0x0400F10F RID: 61711
		[Token(Token = "0x400F10F")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_RunActionsOnTarget;

		// Token: 0x0400F110 RID: 61712
		[Token(Token = "0x400F110")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_GatherActionNodes;

		// Token: 0x0400F111 RID: 61713
		[Token(Token = "0x400F111")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}

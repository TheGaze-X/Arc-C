using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.Battle.Action
{
	// Token: 0x02002C4B RID: 11339
	[Token(Token = "0x2002C4B")]
	[Serializable]
	public abstract class ActionNode : IHotfixable
	{
		// Token: 0x17002A0E RID: 10766
		// (get) Token: 0x06013242 RID: 78402
		[Token(Token = "0x17002A0E")]
		public abstract ActionNode.SourceType allowedSource { [Token(Token = "0x6013242")] get; }

		// Token: 0x17002A0F RID: 10767
		// (get) Token: 0x06013243 RID: 78403 RVA: 0x00074AF0 File Offset: 0x00072CF0
		[Token(Token = "0x17002A0F")]
		public virtual ActionNode.ExecuteCondition executeCondition
		{
			[Token(Token = "0x6013243")]
			[Address(RVA = "0xB41930", Offset = "0xB40530", VA = "0x180B41930", Slot = "5")]
			get
			{
				return ActionNode.ExecuteCondition.ALWAYS;
			}
		}

		// Token: 0x06013244 RID: 78404
		[Token(Token = "0x6013244")]
		public abstract bool Execute(Blackboard blackboard, ActionNode.SourceType sourceType, ref Context.Snapshot snapshot);

		// Token: 0x06013245 RID: 78405 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6013245")]
		[Address(RVA = "0xB41830", Offset = "0xB40430", VA = "0x180B41830", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06013246 RID: 78406 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6013246")]
		[Address(RVA = "0xB418D0", Offset = "0xB404D0", VA = "0x180B418D0")]
		protected ActionNode()
		{
		}

		// Token: 0x06013247 RID: 78407 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6013247")]
		[Address(RVA = "0x850A00", Offset = "0x84F600", VA = "0x180850A00")]
		private string <>xLuaBaseProxy_ToString()
		{
			return null;
		}

		// Token: 0x040159EF RID: 88559
		[Token(Token = "0x40159EF")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_executeCondition;

		// Token: 0x040159F0 RID: 88560
		[Token(Token = "0x40159F0")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_ToString;

		// Token: 0x040159F1 RID: 88561
		[Token(Token = "0x40159F1")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02002C4C RID: 11340
		[Token(Token = "0x2002C4C")]
		[LuaCallCSharp(GenFlag.No)]
		[GCOptimize(OptimizeFlag.Default)]
		public enum SourceType
		{
			// Token: 0x040159F3 RID: 88563
			[Token(Token = "0x40159F3")]
			NONE,
			// Token: 0x040159F4 RID: 88564
			[Token(Token = "0x40159F4")]
			FROM_BUFF,
			// Token: 0x040159F5 RID: 88565
			[Token(Token = "0x40159F5")]
			FROM_ABILITY,
			// Token: 0x040159F6 RID: 88566
			[Token(Token = "0x40159F6")]
			FROM_PROJECTILE = 4,
			// Token: 0x040159F7 RID: 88567
			[Token(Token = "0x40159F7")]
			FROM_BATTLE_AVG = 8,
			// Token: 0x040159F8 RID: 88568
			[Token(Token = "0x40159F8")]
			FROM_ENVIRONMENT = 16,
			// Token: 0x040159F9 RID: 88569
			[Token(Token = "0x40159F9")]
			FROM_VALIDATOR = 32,
			// Token: 0x040159FA RID: 88570
			[Token(Token = "0x40159FA")]
			ALL = 63
		}

		// Token: 0x02002C4D RID: 11341
		[Token(Token = "0x2002C4D")]
		public enum ExecuteCondition
		{
			// Token: 0x040159FC RID: 88572
			[Token(Token = "0x40159FC")]
			ALWAYS,
			// Token: 0x040159FD RID: 88573
			[Token(Token = "0x40159FD")]
			PREVIOUS_SUCCEED,
			// Token: 0x040159FE RID: 88574
			[Token(Token = "0x40159FE")]
			PREVIOUS_FAILED
		}
	}
}

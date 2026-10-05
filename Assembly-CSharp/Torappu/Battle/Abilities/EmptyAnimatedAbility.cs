using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.Battle.Action;
using XLua;

namespace Torappu.Battle.Abilities
{
	// Token: 0x02002A91 RID: 10897
	[Token(Token = "0x2002A91")]
	public class EmptyAnimatedAbility : AbstractAnimatedAbility
	{
		// Token: 0x0601216D RID: 74093 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601216D")]
		[Address(RVA = "0xA20850", Offset = "0xA1F450", VA = "0x180A20850", Slot = "44")]
		public override IList<ActionNode> GetProjectileActions(Projectile.Event ev, Projectile projectile)
		{
			return null;
		}

		// Token: 0x0601216E RID: 74094 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601216E")]
		[Address(RVA = "0xA207E0", Offset = "0xA1F3E0", VA = "0x180A207E0", Slot = "72")]
		protected override IList<ActionNode> GetEventActions(AbilityStandard.Event ev)
		{
			return null;
		}

		// Token: 0x170027B4 RID: 10164
		// (get) Token: 0x0601216F RID: 74095 RVA: 0x0006EB98 File Offset: 0x0006CD98
		[Token(Token = "0x170027B4")]
		public override bool ignorePalsyInterrupt
		{
			[Token(Token = "0x601216F")]
			[Address(RVA = "0xA20950", Offset = "0xA1F550", VA = "0x180A20950", Slot = "25")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06012170 RID: 74096 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012170")]
		[Address(RVA = "0xA208F0", Offset = "0xA1F4F0", VA = "0x180A208F0")]
		public EmptyAnimatedAbility()
		{
		}

		// Token: 0x06012171 RID: 74097 RVA: 0x0006EBB0 File Offset: 0x0006CDB0
		[Token(Token = "0x6012171")]
		[Address(RVA = "0xA208E0", Offset = "0xA1F4E0", VA = "0x180A208E0")]
		private bool <>xLuaBaseProxy_get_ignorePalsyInterrupt()
		{
			return default(bool);
		}

		// Token: 0x04014797 RID: 83863
		[Token(Token = "0x4014797")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetProjectileActions;

		// Token: 0x04014798 RID: 83864
		[Token(Token = "0x4014798")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_GetEventActions;

		// Token: 0x04014799 RID: 83865
		[Token(Token = "0x4014799")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_ignorePalsyInterrupt;

		// Token: 0x0401479A RID: 83866
		[Token(Token = "0x401479A")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}

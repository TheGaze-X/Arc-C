using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using XLua;

namespace Torappu.Battle
{
	// Token: 0x02002266 RID: 8806
	[Token(Token = "0x2002266")]
	public class BossRushLastWaveNotUseGlobalBuff : GlobalBuff
	{
		// Token: 0x0600DD77 RID: 56695 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600DD77")]
		[Address(RVA = "0x362CBE0", Offset = "0x362B7E0", VA = "0x18362CBE0", Slot = "11")]
		public override void OnInit(LevelData.GlobalBuffData data)
		{
		}

		// Token: 0x0600DD78 RID: 56696 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600DD78")]
		[Address(RVA = "0x362CDC0", Offset = "0x362B9C0", VA = "0x18362CDC0", Slot = "12")]
		public override void TryAddBuff(Unit unit, bool isInit = true)
		{
		}

		// Token: 0x0600DD79 RID: 56697 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600DD79")]
		[Address(RVA = "0x362CF40", Offset = "0x362BB40", VA = "0x18362CF40")]
		private void _OnUnitBorn(object arg)
		{
		}

		// Token: 0x0600DD7A RID: 56698 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600DD7A")]
		[Address(RVA = "0x362D100", Offset = "0x362BD00", VA = "0x18362D100")]
		private void _OnWaveStart(object arg)
		{
		}

		// Token: 0x0600DD7B RID: 56699 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600DD7B")]
		[Address(RVA = "0x362D4D0", Offset = "0x362C0D0", VA = "0x18362D4D0")]
		public BossRushLastWaveNotUseGlobalBuff()
		{
		}

		// Token: 0x0600DD7C RID: 56700 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600DD7C")]
		[Address(RVA = "0x362AB00", Offset = "0x3629700", VA = "0x18362AB00")]
		private void <>xLuaBaseProxy_OnInit(LevelData.GlobalBuffData P0)
		{
		}

		// Token: 0x0600DD7D RID: 56701 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600DD7D")]
		[Address(RVA = "0x362AB70", Offset = "0x3629770", VA = "0x18362AB70")]
		private void <>xLuaBaseProxy_TryAddBuff(Unit P0, bool P1)
		{
		}

		// Token: 0x0400EFEB RID: 61419
		[Token(Token = "0x400EFEB")]
		[FieldOffset(Offset = "0x148")]
		private int m_waveCnt;

		// Token: 0x0400EFEC RID: 61420
		[Token(Token = "0x400EFEC")]
		[FieldOffset(Offset = "0x150")]
		private List<uint> m_lastWaveId;

		// Token: 0x0400EFED RID: 61421
		[Token(Token = "0x400EFED")]
		[FieldOffset(Offset = "0x158")]
		private List<uint> m_curWaveId;

		// Token: 0x0400EFEE RID: 61422
		[Token(Token = "0x400EFEE")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnInit;

		// Token: 0x0400EFEF RID: 61423
		[Token(Token = "0x400EFEF")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_TryAddBuff;

		// Token: 0x0400EFF0 RID: 61424
		[Token(Token = "0x400EFF0")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__OnUnitBorn;

		// Token: 0x0400EFF1 RID: 61425
		[Token(Token = "0x400EFF1")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__OnWaveStart;

		// Token: 0x0400EFF2 RID: 61426
		[Token(Token = "0x400EFF2")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}

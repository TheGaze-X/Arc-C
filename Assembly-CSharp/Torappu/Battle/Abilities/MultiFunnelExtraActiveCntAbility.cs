using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using XLua;

namespace Torappu.Battle.Abilities
{
	// Token: 0x02002BA7 RID: 11175
	[Token(Token = "0x2002BA7")]
	public class MultiFunnelExtraActiveCntAbility : PassiveBuffAbility
	{
		// Token: 0x06012D88 RID: 77192 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012D88")]
		[Address(RVA = "0xAC5F30", Offset = "0xAC4B30", VA = "0x180AC5F30", Slot = "40")]
		protected override void Reset()
		{
		}

		// Token: 0x06012D89 RID: 77193 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012D89")]
		[Address(RVA = "0xAC5CA0", Offset = "0xAC48A0", VA = "0x180AC5CA0")]
		public void AddExtraFunnelActiveCnt(string abilityName, int cnt)
		{
		}

		// Token: 0x06012D8A RID: 77194 RVA: 0x00073668 File Offset: 0x00071868
		[Token(Token = "0x6012D8A")]
		[Address(RVA = "0xAC5E70", Offset = "0xAC4A70", VA = "0x180AC5E70")]
		public int GetExtraFunnelActiveCnt(string abilityName)
		{
			return 0;
		}

		// Token: 0x06012D8B RID: 77195 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012D8B")]
		[Address(RVA = "0xAC5DE0", Offset = "0xAC49E0", VA = "0x180AC5DE0", Slot = "30")]
		protected override void DoDetach()
		{
		}

		// Token: 0x06012D8C RID: 77196 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012D8C")]
		[Address(RVA = "0xAC5FC0", Offset = "0xAC4BC0", VA = "0x180AC5FC0")]
		public MultiFunnelExtraActiveCntAbility()
		{
		}

		// Token: 0x06012D8D RID: 77197 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012D8D")]
		[Address(RVA = "0xA4B0B0", Offset = "0xA49CB0", VA = "0x180A4B0B0")]
		private void <>xLuaBaseProxy_Reset()
		{
		}

		// Token: 0x06012D8E RID: 77198 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012D8E")]
		[Address(RVA = "0xA3C270", Offset = "0xA3AE70", VA = "0x180A3C270")]
		private void <>xLuaBaseProxy_DoDetach()
		{
		}

		// Token: 0x0401543D RID: 87101
		[Token(Token = "0x401543D")]
		[FieldOffset(Offset = "0x118")]
		private Dictionary<string, int> m_abilityExtraFunnelActiveCnt;

		// Token: 0x0401543E RID: 87102
		[Token(Token = "0x401543E")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Reset;

		// Token: 0x0401543F RID: 87103
		[Token(Token = "0x401543F")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_AddExtraFunnelActiveCnt;

		// Token: 0x04015440 RID: 87104
		[Token(Token = "0x4015440")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_GetExtraFunnelActiveCnt;

		// Token: 0x04015441 RID: 87105
		[Token(Token = "0x4015441")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_DoDetach;

		// Token: 0x04015442 RID: 87106
		[Token(Token = "0x4015442")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}

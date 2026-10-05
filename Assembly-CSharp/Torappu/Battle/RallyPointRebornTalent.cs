using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Battle
{
	// Token: 0x02002493 RID: 9363
	[Token(Token = "0x2002493")]
	[RequireComponent(typeof(Ability))]
	public class RallyPointRebornTalent : Talent
	{
		// Token: 0x0600F0C8 RID: 61640 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F0C8")]
		[Address(RVA = "0x693E60", Offset = "0x692A60", VA = "0x180693E60", Slot = "29")]
		protected override void DoAttach()
		{
		}

		// Token: 0x0600F0C9 RID: 61641 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F0C9")]
		[Address(RVA = "0x694070", Offset = "0x692C70", VA = "0x180694070")]
		private void _FetchFirstPassiveBuffUids()
		{
		}

		// Token: 0x17001F4A RID: 8010
		// (get) Token: 0x0600F0CA RID: 61642 RVA: 0x00058BC0 File Offset: 0x00056DC0
		[Token(Token = "0x17001F4A")]
		public FP rebornProgress
		{
			[Token(Token = "0x600F0CA")]
			[Address(RVA = "0x694250", Offset = "0x692E50", VA = "0x180694250")]
			get
			{
				return default(FP);
			}
		}

		// Token: 0x0600F0CB RID: 61643 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F0CB")]
		[Address(RVA = "0x6941F0", Offset = "0x692DF0", VA = "0x1806941F0")]
		public RallyPointRebornTalent()
		{
		}

		// Token: 0x0600F0CC RID: 61644 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F0CC")]
		[Address(RVA = "0x694060", Offset = "0x692C60", VA = "0x180694060")]
		private void <>xLuaBaseProxy_DoAttach()
		{
		}

		// Token: 0x04010A4D RID: 68173
		[Token(Token = "0x4010A4D")]
		[FieldOffset(Offset = "0x90")]
		private Buff m_rebornBuff;

		// Token: 0x04010A4E RID: 68174
		[Token(Token = "0x4010A4E")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_DoAttach;

		// Token: 0x04010A4F RID: 68175
		[Token(Token = "0x4010A4F")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__FetchFirstPassiveBuffUids;

		// Token: 0x04010A50 RID: 68176
		[Token(Token = "0x4010A50")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_rebornProgress;

		// Token: 0x04010A51 RID: 68177
		[Token(Token = "0x4010A51")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}

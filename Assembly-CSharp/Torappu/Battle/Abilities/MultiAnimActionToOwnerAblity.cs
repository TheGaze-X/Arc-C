using System;
using System.Collections;
using AdvancedInspector;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Battle.Abilities
{
	// Token: 0x02002A98 RID: 10904
	[Token(Token = "0x2002A98")]
	public class MultiAnimActionToOwnerAblity : AnimatedActionToTargetAbility
	{
		// Token: 0x0601219B RID: 74139 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601219B")]
		[Address(RVA = "0xA262C0", Offset = "0xA24EC0", VA = "0x180A262C0", Slot = "26")]
		protected override void DoSetData(Entity owner, Ability.Options options)
		{
		}

		// Token: 0x0601219C RID: 74140 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601219C")]
		[Address(RVA = "0xA26400", Offset = "0xA25000", VA = "0x180A26400", Slot = "77")]
		protected override IEnumerator OnWaitForTriggerDelta()
		{
			return null;
		}

		// Token: 0x0601219D RID: 74141 RVA: 0x0006ED60 File Offset: 0x0006CF60
		[Token(Token = "0x601219D")]
		[Address(RVA = "0xA26250", Offset = "0xA24E50", VA = "0x180A26250", Slot = "87")]
		protected override bool CheckAnotherSpell(int spellCnt)
		{
			return default(bool);
		}

		// Token: 0x0601219E RID: 74142 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601219E")]
		[Address(RVA = "0xA264B0", Offset = "0xA250B0", VA = "0x180A264B0")]
		public MultiAnimActionToOwnerAblity()
		{
		}

		// Token: 0x0601219F RID: 74143 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601219F")]
		[Address(RVA = "0xA1E4E0", Offset = "0xA1D0E0", VA = "0x180A1E4E0")]
		private void <>xLuaBaseProxy_DoSetData(Entity P0, Ability.Options P1)
		{
		}

		// Token: 0x060121A0 RID: 74144 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60121A0")]
		[Address(RVA = "0xA1FD60", Offset = "0xA1E960", VA = "0x180A1FD60")]
		private IEnumerator <>xLuaBaseProxy_OnWaitForTriggerDelta()
		{
			return null;
		}

		// Token: 0x060121A1 RID: 74145 RVA: 0x0006ED78 File Offset: 0x0006CF78
		[Token(Token = "0x60121A1")]
		[Address(RVA = "0xA1FD00", Offset = "0xA1E900", VA = "0x180A1FD00")]
		private bool <>xLuaBaseProxy_CheckAnotherSpell(int P0)
		{
			return default(bool);
		}

		// Token: 0x040147C4 RID: 83908
		[Token(Token = "0x40147C4")]
		[FieldOffset(Offset = "0x1D8")]
		[SerializeField]
		[Group("Multi")]
		private int _additionalTimes;

		// Token: 0x040147C5 RID: 83909
		[Token(Token = "0x40147C5")]
		[FieldOffset(Offset = "0x1DC")]
		[SerializeField]
		[Group("Multi")]
		private float _triggerDelta;

		// Token: 0x040147C6 RID: 83910
		[Token(Token = "0x40147C6")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_DoSetData;

		// Token: 0x040147C7 RID: 83911
		[Token(Token = "0x40147C7")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnWaitForTriggerDelta;

		// Token: 0x040147C8 RID: 83912
		[Token(Token = "0x40147C8")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_CheckAnotherSpell;

		// Token: 0x040147C9 RID: 83913
		[Token(Token = "0x40147C9")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}

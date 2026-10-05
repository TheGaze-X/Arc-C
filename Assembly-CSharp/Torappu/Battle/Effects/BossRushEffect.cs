using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Battle.Effects
{
	// Token: 0x02003220 RID: 12832
	[Token(Token = "0x2003220")]
	public class BossRushEffect : Effect.Behaviour
	{
		// Token: 0x060145B3 RID: 83379 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60145B3")]
		[Address(RVA = "0xC99D30", Offset = "0xC98930", VA = "0x180C99D30", Slot = "5")]
		public override void OnPlay()
		{
		}

		// Token: 0x060145B4 RID: 83380 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60145B4")]
		[Address(RVA = "0xC9A140", Offset = "0xC98D40", VA = "0x180C9A140")]
		public BossRushEffect()
		{
		}

		// Token: 0x060145B5 RID: 83381 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60145B5")]
		[Address(RVA = "0xC99160", Offset = "0xC97D60", VA = "0x180C99160")]
		private void <>xLuaBaseProxy_OnPlay()
		{
		}

		// Token: 0x04018030 RID: 98352
		[Token(Token = "0x4018030")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private BossRushEffect.BossRushMapEffectType _mapEffectType;

		// Token: 0x04018031 RID: 98353
		[Token(Token = "0x4018031")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnPlay;

		// Token: 0x04018032 RID: 98354
		[Token(Token = "0x4018032")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02003221 RID: 12833
		[Token(Token = "0x2003221")]
		private enum BossRushMapEffectType
		{
			// Token: 0x04018034 RID: 98356
			[Token(Token = "0x4018034")]
			DANGER_AREA_BEGIN,
			// Token: 0x04018035 RID: 98357
			[Token(Token = "0x4018035")]
			DANGER_AREA_END,
			// Token: 0x04018036 RID: 98358
			[Token(Token = "0x4018036")]
			BATTLE_AREA_BEGIN,
			// Token: 0x04018037 RID: 98359
			[Token(Token = "0x4018037")]
			BATTLE_AREA_END
		}
	}
}

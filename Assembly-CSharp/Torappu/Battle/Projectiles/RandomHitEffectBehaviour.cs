using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Battle.Projectiles
{
	// Token: 0x020029A8 RID: 10664
	[Token(Token = "0x20029A8")]
	public class RandomHitEffectBehaviour : EffectBehaviour, IEffectSource
	{
		// Token: 0x06011A8A RID: 72330 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011A8A")]
		[Address(RVA = "0x980CF0", Offset = "0x97F8F0", VA = "0x180980CF0", Slot = "10")]
		public override void OnHitTarget(Entity target)
		{
		}

		// Token: 0x06011A8B RID: 72331 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6011A8B")]
		[Address(RVA = "0x9812F0", Offset = "0x97FEF0", VA = "0x1809812F0")]
		private string _SelectEffectForRandom()
		{
			return null;
		}

		// Token: 0x06011A8C RID: 72332 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011A8C")]
		[Address(RVA = "0x981420", Offset = "0x980020", VA = "0x180981420")]
		public RandomHitEffectBehaviour()
		{
		}

		// Token: 0x06011A8D RID: 72333 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011A8D")]
		[Address(RVA = "0x9812E0", Offset = "0x97FEE0", VA = "0x1809812E0")]
		private void <>xLuaBaseProxy_OnHitTarget(Entity P0)
		{
		}

		// Token: 0x04013C71 RID: 81009
		[Token(Token = "0x4013C71")]
		[FieldOffset(Offset = "0x98")]
		[SerializeField]
		private string[] _randomEffectsWhenHit;

		// Token: 0x04013C72 RID: 81010
		[Token(Token = "0x4013C72")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnHitTarget;

		// Token: 0x04013C73 RID: 81011
		[Token(Token = "0x4013C73")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__SelectEffectForRandom;

		// Token: 0x04013C74 RID: 81012
		[Token(Token = "0x4013C74")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}

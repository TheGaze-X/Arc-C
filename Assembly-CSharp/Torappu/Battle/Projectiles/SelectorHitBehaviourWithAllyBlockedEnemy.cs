using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Battle.Projectiles
{
	// Token: 0x020029B0 RID: 10672
	[Token(Token = "0x20029B0")]
	public class SelectorHitBehaviourWithAllyBlockedEnemy : SelectorHitBehaviour
	{
		// Token: 0x06011ACD RID: 72397 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011ACD")]
		[Address(RVA = "0x984C60", Offset = "0x983860", VA = "0x180984C60", Slot = "4")]
		public override void Init(ILocatable start, ILocatable target, Projectile projectile)
		{
		}

		// Token: 0x06011ACE RID: 72398 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011ACE")]
		[Address(RVA = "0x984940", Offset = "0x983540", VA = "0x180984940", Slot = "19")]
		protected override void DoSelectTargetToHit(Vector2 inputPos)
		{
		}

		// Token: 0x06011ACF RID: 72399 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011ACF")]
		[Address(RVA = "0x984DE0", Offset = "0x9839E0", VA = "0x180984DE0")]
		public SelectorHitBehaviourWithAllyBlockedEnemy()
		{
		}

		// Token: 0x06011AD0 RID: 72400 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011AD0")]
		[Address(RVA = "0x9693E0", Offset = "0x967FE0", VA = "0x1809693E0")]
		private void <>xLuaBaseProxy_Init(ILocatable P0, ILocatable P1, Projectile P2)
		{
		}

		// Token: 0x06011AD1 RID: 72401 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011AD1")]
		[Address(RVA = "0x9682B0", Offset = "0x966EB0", VA = "0x1809682B0")]
		private void <>xLuaBaseProxy_DoSelectTargetToHit(Vector2 P0)
		{
		}

		// Token: 0x04013CE9 RID: 81129
		[Token(Token = "0x4013CE9")]
		[FieldOffset(Offset = "0xA8")]
		[SerializeField]
		private TargetSelector _allySelector;

		// Token: 0x04013CEA RID: 81130
		[Token(Token = "0x4013CEA")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Init;

		// Token: 0x04013CEB RID: 81131
		[Token(Token = "0x4013CEB")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_DoSelectTargetToHit;

		// Token: 0x04013CEC RID: 81132
		[Token(Token = "0x4013CEC")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}

using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Battle.Projectiles
{
	// Token: 0x020029BD RID: 10685
	[Token(Token = "0x20029BD")]
	public class SummonEnemyBehaviour : Projectile.Behaviour
	{
		// Token: 0x06011B1A RID: 72474 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011B1A")]
		[Address(RVA = "0x98BDF0", Offset = "0x98A9F0", VA = "0x18098BDF0", Slot = "6")]
		public override void OnProjectileBorn()
		{
		}

		// Token: 0x06011B1B RID: 72475 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011B1B")]
		[Address(RVA = "0x98C340", Offset = "0x98AF40", VA = "0x18098C340")]
		public SummonEnemyBehaviour()
		{
		}

		// Token: 0x06011B1C RID: 72476 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011B1C")]
		[Address(RVA = "0x94DC40", Offset = "0x94C840", VA = "0x18094DC40")]
		private void <>xLuaBaseProxy_OnProjectileBorn()
		{
		}

		// Token: 0x04013D59 RID: 81241
		[Token(Token = "0x4013D59")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private string _enemyKey;

		// Token: 0x04013D5A RID: 81242
		[Token(Token = "0x4013D5A")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private MotionMode _motionMode;

		// Token: 0x04013D5B RID: 81243
		[Token(Token = "0x4013D5B")]
		[FieldOffset(Offset = "0x34")]
		[SerializeField]
		private bool _unharmful;

		// Token: 0x04013D5C RID: 81244
		[Token(Token = "0x4013D5C")]
		[FieldOffset(Offset = "0x35")]
		[SerializeField]
		private bool _alwaysCountAsKilled;

		// Token: 0x04013D5D RID: 81245
		[Token(Token = "0x4013D5D")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private float _waitTime;

		// Token: 0x04013D5E RID: 81246
		[Token(Token = "0x4013D5E")]
		[FieldOffset(Offset = "0x3C")]
		[SerializeField]
		private float _spawnOffset;

		// Token: 0x04013D5F RID: 81247
		[Token(Token = "0x4013D5F")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private bool _avoidHighland;

		// Token: 0x04013D60 RID: 81248
		[Token(Token = "0x4013D60")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnProjectileBorn;

		// Token: 0x04013D61 RID: 81249
		[Token(Token = "0x4013D61")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}

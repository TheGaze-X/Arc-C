using System;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x0200103E RID: 4158
	[Token(Token = "0x200103E")]
	public class InternalEnemyHBData
	{
		// Token: 0x06006DA8 RID: 28072 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006DA8")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public InternalEnemyHBData()
		{
		}

		// Token: 0x0400584A RID: 22602
		[Token(Token = "0x400584A")]
		[FieldOffset(Offset = "0x10")]
		public SourceApplyWay applyWay;

		// Token: 0x0400584B RID: 22603
		[Token(Token = "0x400584B")]
		[FieldOffset(Offset = "0x14")]
		public MotionMode motion;

		// Token: 0x0400584C RID: 22604
		[Token(Token = "0x400584C")]
		[FieldOffset(Offset = "0x18")]
		public string[] enemyTags;

		// Token: 0x0400584D RID: 22605
		[Token(Token = "0x400584D")]
		[FieldOffset(Offset = "0x20")]
		public int lifePointReduce;

		// Token: 0x0400584E RID: 22606
		[Token(Token = "0x400584E")]
		[FieldOffset(Offset = "0x24")]
		public EnemyLevelType levelType;

		// Token: 0x0400584F RID: 22607
		[Token(Token = "0x400584F")]
		[FieldOffset(Offset = "0x28")]
		public int maxHp;

		// Token: 0x04005850 RID: 22608
		[Token(Token = "0x4005850")]
		[FieldOffset(Offset = "0x2C")]
		public int atk;

		// Token: 0x04005851 RID: 22609
		[Token(Token = "0x4005851")]
		[FieldOffset(Offset = "0x30")]
		public int def;

		// Token: 0x04005852 RID: 22610
		[Token(Token = "0x4005852")]
		[FieldOffset(Offset = "0x34")]
		public int massLevel;

		// Token: 0x04005853 RID: 22611
		[Token(Token = "0x4005853")]
		[FieldOffset(Offset = "0x38")]
		public float magicResistance;

		// Token: 0x04005854 RID: 22612
		[Token(Token = "0x4005854")]
		[FieldOffset(Offset = "0x3C")]
		public float moveSpeed;

		// Token: 0x04005855 RID: 22613
		[Token(Token = "0x4005855")]
		[FieldOffset(Offset = "0x40")]
		public float baseAttackTime;

		// Token: 0x04005856 RID: 22614
		[Token(Token = "0x4005856")]
		[FieldOffset(Offset = "0x44")]
		public float epDamageResistance;

		// Token: 0x04005857 RID: 22615
		[Token(Token = "0x4005857")]
		[FieldOffset(Offset = "0x48")]
		public float epResistance;

		// Token: 0x04005858 RID: 22616
		[Token(Token = "0x4005858")]
		[FieldOffset(Offset = "0x4C")]
		public float damageHitratePhysical;

		// Token: 0x04005859 RID: 22617
		[Token(Token = "0x4005859")]
		[FieldOffset(Offset = "0x50")]
		public float damageHitrateMagical;

		// Token: 0x0400585A RID: 22618
		[Token(Token = "0x400585A")]
		[FieldOffset(Offset = "0x54")]
		public bool stunImmune;

		// Token: 0x0400585B RID: 22619
		[Token(Token = "0x400585B")]
		[FieldOffset(Offset = "0x55")]
		public bool sleepImmune;

		// Token: 0x0400585C RID: 22620
		[Token(Token = "0x400585C")]
		[FieldOffset(Offset = "0x56")]
		public bool frozenImmune;

		// Token: 0x0400585D RID: 22621
		[Token(Token = "0x400585D")]
		[FieldOffset(Offset = "0x57")]
		public bool levitateImmune;

		// Token: 0x0400585E RID: 22622
		[Token(Token = "0x400585E")]
		[FieldOffset(Offset = "0x58")]
		public bool disarmedCombatImmune;

		// Token: 0x0400585F RID: 22623
		[Token(Token = "0x400585F")]
		[FieldOffset(Offset = "0x59")]
		public bool fearedImmune;

		// Token: 0x04005860 RID: 22624
		[Token(Token = "0x4005860")]
		[FieldOffset(Offset = "0x5A")]
		public bool palsyImmune;

		// Token: 0x04005861 RID: 22625
		[Token(Token = "0x4005861")]
		[FieldOffset(Offset = "0x5B")]
		public bool attractImmune;
	}
}

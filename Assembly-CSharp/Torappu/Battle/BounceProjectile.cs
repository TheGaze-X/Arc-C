using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Battle
{
	// Token: 0x020023CA RID: 9162
	[Token(Token = "0x20023CA")]
	public class BounceProjectile : Projectile
	{
		// Token: 0x17001D7C RID: 7548
		// (get) Token: 0x0600E90F RID: 59663 RVA: 0x00055380 File Offset: 0x00053580
		[Token(Token = "0x17001D7C")]
		protected override bool stopAfterMaxHit
		{
			[Token(Token = "0x600E90F")]
			[Address(RVA = "0x5F1960", Offset = "0x5F0560", VA = "0x1805F1960", Slot = "38")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17001D7D RID: 7549
		// (get) Token: 0x0600E910 RID: 59664 RVA: 0x00055398 File Offset: 0x00053598
		[Token(Token = "0x17001D7D")]
		protected override bool stopAfterFirstHit
		{
			[Token(Token = "0x600E910")]
			[Address(RVA = "0x5F1900", Offset = "0x5F0500", VA = "0x1805F1900", Slot = "39")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17001D7E RID: 7550
		// (get) Token: 0x0600E911 RID: 59665 RVA: 0x000553B0 File Offset: 0x000535B0
		[Token(Token = "0x17001D7E")]
		protected override bool stopWhenSourceInvalid
		{
			[Token(Token = "0x600E911")]
			[Address(RVA = "0x5F19C0", Offset = "0x5F05C0", VA = "0x1805F19C0", Slot = "40")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17001D7F RID: 7551
		// (get) Token: 0x0600E912 RID: 59666 RVA: 0x000553C8 File Offset: 0x000535C8
		[Token(Token = "0x17001D7F")]
		protected override bool alwaysHitTraceTargetInTheEnd
		{
			[Token(Token = "0x600E912")]
			[Address(RVA = "0x5F17E0", Offset = "0x5F03E0", VA = "0x1805F17E0", Slot = "41")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17001D80 RID: 7552
		// (get) Token: 0x0600E913 RID: 59667 RVA: 0x000553E0 File Offset: 0x000535E0
		[Token(Token = "0x17001D80")]
		protected override bool alwaysHitTraceTargetWhenReached
		{
			[Token(Token = "0x600E913")]
			[Address(RVA = "0x5F1840", Offset = "0x5F0440", VA = "0x1805F1840", Slot = "42")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17001D81 RID: 7553
		// (get) Token: 0x0600E914 RID: 59668 RVA: 0x000553F8 File Offset: 0x000535F8
		[Token(Token = "0x17001D81")]
		protected override bool alwaysReachInTheEnd
		{
			[Token(Token = "0x600E914")]
			[Address(RVA = "0x5F18A0", Offset = "0x5F04A0", VA = "0x1805F18A0", Slot = "43")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x0600E915 RID: 59669 RVA: 0x00055410 File Offset: 0x00053610
		[Token(Token = "0x600E915")]
		[Address(RVA = "0x5F1600", Offset = "0x5F0200", VA = "0x1805F1600", Slot = "47")]
		protected override float GetLifeTime()
		{
			return 0f;
		}

		// Token: 0x0600E916 RID: 59670 RVA: 0x00055428 File Offset: 0x00053628
		[Token(Token = "0x600E916")]
		[Address(RVA = "0x5F1700", Offset = "0x5F0300", VA = "0x1805F1700", Slot = "48")]
		public override int GetMaxHitNum()
		{
			return 0;
		}

		// Token: 0x0600E917 RID: 59671 RVA: 0x00055440 File Offset: 0x00053640
		[Token(Token = "0x600E917")]
		[Address(RVA = "0x5F1590", Offset = "0x5F0190", VA = "0x1805F1590", Slot = "53")]
		protected override bool CheckTargetAlreadyHitAndUpdate(Entity target)
		{
			return default(bool);
		}

		// Token: 0x0600E918 RID: 59672 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E918")]
		[Address(RVA = "0x5F1770", Offset = "0x5F0370", VA = "0x1805F1770")]
		public BounceProjectile()
		{
		}

		// Token: 0x0600E919 RID: 59673 RVA: 0x00055458 File Offset: 0x00053658
		[Token(Token = "0x600E919")]
		[Address(RVA = "0x5F1760", Offset = "0x5F0360", VA = "0x1805F1760")]
		private bool <>xLuaBaseProxy_CheckTargetAlreadyHitAndUpdate(Entity P0)
		{
			return default(bool);
		}

		// Token: 0x0401010F RID: 65807
		[Token(Token = "0x401010F")]
		[FieldOffset(Offset = "0x188")]
		[SerializeField]
		private LifeType _lifeTimeType;

		// Token: 0x04010110 RID: 65808
		[Token(Token = "0x4010110")]
		[FieldOffset(Offset = "0x18C")]
		[SerializeField]
		private float _lifeTime;

		// Token: 0x04010111 RID: 65809
		[Token(Token = "0x4010111")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_stopAfterMaxHit;

		// Token: 0x04010112 RID: 65810
		[Token(Token = "0x4010112")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_stopAfterFirstHit;

		// Token: 0x04010113 RID: 65811
		[Token(Token = "0x4010113")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_stopWhenSourceInvalid;

		// Token: 0x04010114 RID: 65812
		[Token(Token = "0x4010114")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_get_alwaysHitTraceTargetInTheEnd;

		// Token: 0x04010115 RID: 65813
		[Token(Token = "0x4010115")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_get_alwaysHitTraceTargetWhenReached;

		// Token: 0x04010116 RID: 65814
		[Token(Token = "0x4010116")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_get_alwaysReachInTheEnd;

		// Token: 0x04010117 RID: 65815
		[Token(Token = "0x4010117")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_GetLifeTime;

		// Token: 0x04010118 RID: 65816
		[Token(Token = "0x4010118")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_GetMaxHitNum;

		// Token: 0x04010119 RID: 65817
		[Token(Token = "0x4010119")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_CheckTargetAlreadyHitAndUpdate;

		// Token: 0x0401011A RID: 65818
		[Token(Token = "0x401011A")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}

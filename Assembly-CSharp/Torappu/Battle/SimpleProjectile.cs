using System;
using AdvancedInspector;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Battle
{
	// Token: 0x020023E2 RID: 9186
	[Token(Token = "0x20023E2")]
	public class SimpleProjectile : Projectile
	{
		// Token: 0x17001DD9 RID: 7641
		// (get) Token: 0x0600EA71 RID: 60017 RVA: 0x00055C98 File Offset: 0x00053E98
		[Token(Token = "0x17001DD9")]
		private bool needLifeTime
		{
			[Token(Token = "0x600EA71")]
			[Address(RVA = "0x601070", Offset = "0x5FFC70", VA = "0x180601070")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17001DDA RID: 7642
		// (get) Token: 0x0600EA72 RID: 60018 RVA: 0x00055CB0 File Offset: 0x00053EB0
		[Token(Token = "0x17001DDA")]
		private bool limitedHitNum
		{
			[Token(Token = "0x600EA72")]
			[Address(RVA = "0x601010", Offset = "0x5FFC10", VA = "0x180601010")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17001DDB RID: 7643
		// (get) Token: 0x0600EA73 RID: 60019 RVA: 0x00055CC8 File Offset: 0x00053EC8
		[Token(Token = "0x17001DDB")]
		protected override bool stopAfterMaxHit
		{
			[Token(Token = "0x600EA73")]
			[Address(RVA = "0x601130", Offset = "0x5FFD30", VA = "0x180601130", Slot = "38")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17001DDC RID: 7644
		// (get) Token: 0x0600EA74 RID: 60020 RVA: 0x00055CE0 File Offset: 0x00053EE0
		[Token(Token = "0x17001DDC")]
		protected override bool stopAfterFirstHit
		{
			[Token(Token = "0x600EA74")]
			[Address(RVA = "0x6010D0", Offset = "0x5FFCD0", VA = "0x1806010D0", Slot = "39")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17001DDD RID: 7645
		// (get) Token: 0x0600EA75 RID: 60021 RVA: 0x00055CF8 File Offset: 0x00053EF8
		[Token(Token = "0x17001DDD")]
		protected override bool stopWhenSourceInvalid
		{
			[Token(Token = "0x600EA75")]
			[Address(RVA = "0x601190", Offset = "0x5FFD90", VA = "0x180601190", Slot = "40")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17001DDE RID: 7646
		// (get) Token: 0x0600EA76 RID: 60022 RVA: 0x00055D10 File Offset: 0x00053F10
		[Token(Token = "0x17001DDE")]
		protected override bool alwaysHitTraceTargetInTheEnd
		{
			[Token(Token = "0x600EA76")]
			[Address(RVA = "0x600EF0", Offset = "0x5FFAF0", VA = "0x180600EF0", Slot = "41")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17001DDF RID: 7647
		// (get) Token: 0x0600EA77 RID: 60023 RVA: 0x00055D28 File Offset: 0x00053F28
		[Token(Token = "0x17001DDF")]
		protected override bool alwaysHitTraceTargetWhenReached
		{
			[Token(Token = "0x600EA77")]
			[Address(RVA = "0x600F50", Offset = "0x5FFB50", VA = "0x180600F50", Slot = "42")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17001DE0 RID: 7648
		// (get) Token: 0x0600EA78 RID: 60024 RVA: 0x00055D40 File Offset: 0x00053F40
		[Token(Token = "0x17001DE0")]
		protected override bool alwaysReachInTheEnd
		{
			[Token(Token = "0x600EA78")]
			[Address(RVA = "0x600FB0", Offset = "0x5FFBB0", VA = "0x180600FB0", Slot = "43")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x0600EA79 RID: 60025 RVA: 0x00055D58 File Offset: 0x00053F58
		[Token(Token = "0x600EA79")]
		[Address(RVA = "0x600BC0", Offset = "0x5FF7C0", VA = "0x180600BC0", Slot = "47")]
		protected override float GetLifeTime()
		{
			return 0f;
		}

		// Token: 0x0600EA7A RID: 60026 RVA: 0x00055D70 File Offset: 0x00053F70
		[Token(Token = "0x600EA7A")]
		[Address(RVA = "0x600D20", Offset = "0x5FF920", VA = "0x180600D20", Slot = "48")]
		public override int GetMaxHitNum()
		{
			return 0;
		}

		// Token: 0x0600EA7B RID: 60027 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600EA7B")]
		[Address(RVA = "0x600E60", Offset = "0x5FFA60", VA = "0x180600E60")]
		public SimpleProjectile()
		{
		}

		// Token: 0x040102CD RID: 66253
		[Token(Token = "0x40102CD")]
		[FieldOffset(Offset = "0x188")]
		[SerializeField]
		private LifeType _lifeTimeType;

		// Token: 0x040102CE RID: 66254
		[Token(Token = "0x40102CE")]
		[FieldOffset(Offset = "0x18C")]
		[SerializeField]
		private float _lifeTime;

		// Token: 0x040102CF RID: 66255
		[Token(Token = "0x40102CF")]
		[FieldOffset(Offset = "0x190")]
		[SerializeField]
		[Inspect("needLifeTime")]
		private bool _getLifeTimeFromBB;

		// Token: 0x040102D0 RID: 66256
		[Token(Token = "0x40102D0")]
		[FieldOffset(Offset = "0x191")]
		[SerializeField]
		private LifeType _hitNumType;

		// Token: 0x040102D1 RID: 66257
		[Token(Token = "0x40102D1")]
		[FieldOffset(Offset = "0x194")]
		[SerializeField]
		[Inspect("limitedHitNum")]
		private int _maxHitNum;

		// Token: 0x040102D2 RID: 66258
		[Token(Token = "0x40102D2")]
		[FieldOffset(Offset = "0x198")]
		[SerializeField]
		[Inspect("limitedHitNum")]
		private bool _getMaxHitNumFromBB;

		// Token: 0x040102D3 RID: 66259
		[Token(Token = "0x40102D3")]
		[FieldOffset(Offset = "0x1A0")]
		[SerializeField]
		[Inspect("limitedHitNum")]
		private string _maxHitNumBBKey;

		// Token: 0x040102D4 RID: 66260
		[Token(Token = "0x40102D4")]
		[FieldOffset(Offset = "0x1A8")]
		[SerializeField]
		private bool _stopAfterMaxHit;

		// Token: 0x040102D5 RID: 66261
		[Token(Token = "0x40102D5")]
		[FieldOffset(Offset = "0x1A9")]
		[SerializeField]
		private bool _stopAfterFirstHit;

		// Token: 0x040102D6 RID: 66262
		[Token(Token = "0x40102D6")]
		[FieldOffset(Offset = "0x1AA")]
		[SerializeField]
		private bool _stopWhenSourceInvalid;

		// Token: 0x040102D7 RID: 66263
		[Token(Token = "0x40102D7")]
		[FieldOffset(Offset = "0x1AB")]
		[SerializeField]
		private bool _alwaysHitTraceTargetInTheEnd;

		// Token: 0x040102D8 RID: 66264
		[Token(Token = "0x40102D8")]
		[FieldOffset(Offset = "0x1AC")]
		[SerializeField]
		private bool _alwaysHitTraceTargetWhenReached;

		// Token: 0x040102D9 RID: 66265
		[Token(Token = "0x40102D9")]
		[FieldOffset(Offset = "0x1AD")]
		[SerializeField]
		private bool _alwaysReachInTheEnd;

		// Token: 0x040102DA RID: 66266
		[Token(Token = "0x40102DA")]
		[FieldOffset(Offset = "0x1AE")]
		[SerializeField]
		private bool _limitedMaxHitNumToSourceBlockedCnt;

		// Token: 0x040102DB RID: 66267
		[Token(Token = "0x40102DB")]
		[FieldOffset(Offset = "0x1AF")]
		[SerializeField]
		private bool _allowZeroBlockCntLimit;

		// Token: 0x040102DC RID: 66268
		[Token(Token = "0x40102DC")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_needLifeTime;

		// Token: 0x040102DD RID: 66269
		[Token(Token = "0x40102DD")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_limitedHitNum;

		// Token: 0x040102DE RID: 66270
		[Token(Token = "0x40102DE")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_stopAfterMaxHit;

		// Token: 0x040102DF RID: 66271
		[Token(Token = "0x40102DF")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_get_stopAfterFirstHit;

		// Token: 0x040102E0 RID: 66272
		[Token(Token = "0x40102E0")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_get_stopWhenSourceInvalid;

		// Token: 0x040102E1 RID: 66273
		[Token(Token = "0x40102E1")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_get_alwaysHitTraceTargetInTheEnd;

		// Token: 0x040102E2 RID: 66274
		[Token(Token = "0x40102E2")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_get_alwaysHitTraceTargetWhenReached;

		// Token: 0x040102E3 RID: 66275
		[Token(Token = "0x40102E3")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_get_alwaysReachInTheEnd;

		// Token: 0x040102E4 RID: 66276
		[Token(Token = "0x40102E4")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_GetLifeTime;

		// Token: 0x040102E5 RID: 66277
		[Token(Token = "0x40102E5")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_GetMaxHitNum;

		// Token: 0x040102E6 RID: 66278
		[Token(Token = "0x40102E6")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}

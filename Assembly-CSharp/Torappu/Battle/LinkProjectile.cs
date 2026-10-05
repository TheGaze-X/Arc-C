using System;
using System.Collections;
using AdvancedInspector;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Battle
{
	// Token: 0x020023D1 RID: 9169
	[Token(Token = "0x20023D1")]
	public abstract class LinkProjectile : Projectile
	{
		// Token: 0x17001D89 RID: 7561
		// (get) Token: 0x0600E94D RID: 59725 RVA: 0x00055548 File Offset: 0x00053748
		[Token(Token = "0x17001D89")]
		public FP linkDuration
		{
			[Token(Token = "0x600E94D")]
			[Address(RVA = "0x5F4BB0", Offset = "0x5F37B0", VA = "0x1805F4BB0")]
			get
			{
				return default(FP);
			}
		}

		// Token: 0x17001D8A RID: 7562
		// (get) Token: 0x0600E94E RID: 59726 RVA: 0x00055560 File Offset: 0x00053760
		[Token(Token = "0x17001D8A")]
		private bool IsLifeTimeLimited
		{
			[Token(Token = "0x600E94E")]
			[Address(RVA = "0x5F4970", Offset = "0x5F3570", VA = "0x1805F4970")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17001D8B RID: 7563
		// (get) Token: 0x0600E94F RID: 59727 RVA: 0x00055578 File Offset: 0x00053778
		[Token(Token = "0x17001D8B")]
		public ObjectPtr<Entity> linkTarget
		{
			[Token(Token = "0x600E94F")]
			[Address(RVA = "0x5F4C10", Offset = "0x5F3810", VA = "0x1805F4C10")]
			get
			{
				return default(ObjectPtr<Entity>);
			}
		}

		// Token: 0x17001D8C RID: 7564
		// (get) Token: 0x0600E951 RID: 59729 RVA: 0x00055590 File Offset: 0x00053790
		// (set) Token: 0x0600E950 RID: 59728 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17001D8C")]
		public bool isAttachedToTarget
		{
			[Token(Token = "0x600E951")]
			[Address(RVA = "0x5F4B50", Offset = "0x5F3750", VA = "0x1805F4B50")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600E950")]
			[Address(RVA = "0x5F4DB0", Offset = "0x5F39B0", VA = "0x1805F4DB0")]
			set
			{
			}
		}

		// Token: 0x17001D8D RID: 7565
		// (get) Token: 0x0600E952 RID: 59730 RVA: 0x000555A8 File Offset: 0x000537A8
		[Token(Token = "0x17001D8D")]
		protected bool hasSplittedDamage
		{
			[Token(Token = "0x600E952")]
			[Address(RVA = "0x5F4AF0", Offset = "0x5F36F0", VA = "0x1805F4AF0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17001D8E RID: 7566
		// (get) Token: 0x0600E953 RID: 59731 RVA: 0x000555C0 File Offset: 0x000537C0
		[Token(Token = "0x17001D8E")]
		protected override bool stopAfterMaxHit
		{
			[Token(Token = "0x600E953")]
			[Address(RVA = "0x5F4CF0", Offset = "0x5F38F0", VA = "0x1805F4CF0", Slot = "38")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17001D8F RID: 7567
		// (get) Token: 0x0600E954 RID: 59732 RVA: 0x000555D8 File Offset: 0x000537D8
		[Token(Token = "0x17001D8F")]
		protected override bool stopAfterFirstHit
		{
			[Token(Token = "0x600E954")]
			[Address(RVA = "0x5F4C90", Offset = "0x5F3890", VA = "0x1805F4C90", Slot = "39")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17001D90 RID: 7568
		// (get) Token: 0x0600E955 RID: 59733 RVA: 0x000555F0 File Offset: 0x000537F0
		[Token(Token = "0x17001D90")]
		protected override bool stopWhenSourceInvalid
		{
			[Token(Token = "0x600E955")]
			[Address(RVA = "0x5F4D50", Offset = "0x5F3950", VA = "0x1805F4D50", Slot = "40")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17001D91 RID: 7569
		// (get) Token: 0x0600E956 RID: 59734 RVA: 0x00055608 File Offset: 0x00053808
		[Token(Token = "0x17001D91")]
		protected override bool alwaysHitTraceTargetInTheEnd
		{
			[Token(Token = "0x600E956")]
			[Address(RVA = "0x5F49D0", Offset = "0x5F35D0", VA = "0x1805F49D0", Slot = "41")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17001D92 RID: 7570
		// (get) Token: 0x0600E957 RID: 59735 RVA: 0x00055620 File Offset: 0x00053820
		[Token(Token = "0x17001D92")]
		protected override bool alwaysHitTraceTargetWhenReached
		{
			[Token(Token = "0x600E957")]
			[Address(RVA = "0x5F4A30", Offset = "0x5F3630", VA = "0x1805F4A30", Slot = "42")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17001D93 RID: 7571
		// (get) Token: 0x0600E958 RID: 59736 RVA: 0x00055638 File Offset: 0x00053838
		[Token(Token = "0x17001D93")]
		protected override bool alwaysReachInTheEnd
		{
			[Token(Token = "0x600E958")]
			[Address(RVA = "0x5F4A90", Offset = "0x5F3690", VA = "0x1805F4A90", Slot = "43")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x0600E959 RID: 59737 RVA: 0x00055650 File Offset: 0x00053850
		[Token(Token = "0x600E959")]
		[Address(RVA = "0x5F3DB0", Offset = "0x5F29B0", VA = "0x1805F3DB0", Slot = "47")]
		protected override float GetLifeTime()
		{
			return 0f;
		}

		// Token: 0x0600E95A RID: 59738 RVA: 0x00055668 File Offset: 0x00053868
		[Token(Token = "0x600E95A")]
		[Address(RVA = "0x5F32C0", Offset = "0x5F1EC0", VA = "0x1805F32C0", Slot = "48")]
		public override int GetMaxHitNum()
		{
			return 0;
		}

		// Token: 0x0600E95B RID: 59739 RVA: 0x00055680 File Offset: 0x00053880
		[Token(Token = "0x600E95B")]
		[Address(RVA = "0x5F3BE0", Offset = "0x5F27E0", VA = "0x1805F3BE0", Slot = "49")]
		protected override FP GetKeepAlreadyHitTime()
		{
			return default(FP);
		}

		// Token: 0x0600E95C RID: 59740 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E95C")]
		[Address(RVA = "0x5F4570", Offset = "0x5F3170", VA = "0x1805F4570", Slot = "29")]
		protected override void OnReset()
		{
		}

		// Token: 0x0600E95D RID: 59741 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E95D")]
		[Address(RVA = "0x5F41B0", Offset = "0x5F2DB0", VA = "0x1805F41B0", Slot = "30")]
		protected override void OnInit(float initHeight)
		{
		}

		// Token: 0x0600E95E RID: 59742 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E95E")]
		[Address(RVA = "0x5F4620", Offset = "0x5F3220", VA = "0x1805F4620", Slot = "27")]
		public override void OnTick(FP deltaTime)
		{
		}

		// Token: 0x0600E95F RID: 59743 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E95F")]
		[Address(RVA = "0x5F44A0", Offset = "0x5F30A0", VA = "0x1805F44A0", Slot = "50")]
		protected override void OnProjectileBorn()
		{
		}

		// Token: 0x0600E960 RID: 59744 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E960")]
		[Address(RVA = "0x5F3F10", Offset = "0x5F2B10", VA = "0x1805F3F10", Slot = "52")]
		protected override void OnHitTarget(Entity target)
		{
		}

		// Token: 0x0600E961 RID: 59745 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600E961")]
		[Address(RVA = "0x5F3B10", Offset = "0x5F2710", VA = "0x1805F3B10", Slot = "54")]
		protected virtual IEnumerator DoLink(Entity target)
		{
			return null;
		}

		// Token: 0x0600E962 RID: 59746 RVA: 0x00055698 File Offset: 0x00053898
		[Token(Token = "0x600E962")]
		[Address(RVA = "0x5F4750", Offset = "0x5F3350", VA = "0x1805F4750")]
		private bool _InitDamageSplitter()
		{
			return default(bool);
		}

		// Token: 0x0600E963 RID: 59747 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E963")]
		[Address(RVA = "0x5F48F0", Offset = "0x5F34F0", VA = "0x1805F48F0")]
		protected LinkProjectile()
		{
		}

		// Token: 0x0600E964 RID: 59748 RVA: 0x000556B0 File Offset: 0x000538B0
		[Token(Token = "0x600E964")]
		[Address(RVA = "0x5F4710", Offset = "0x5F3310", VA = "0x1805F4710")]
		private FP <>xLuaBaseProxy_GetKeepAlreadyHitTime()
		{
			return default(FP);
		}

		// Token: 0x0600E965 RID: 59749 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E965")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		private void <>xLuaBaseProxy_OnReset()
		{
		}

		// Token: 0x0600E966 RID: 59750 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E966")]
		[Address(RVA = "0x50CDF0", Offset = "0x50B9F0", VA = "0x18050CDF0")]
		private void <>xLuaBaseProxy_OnInit(float P0)
		{
		}

		// Token: 0x0600E967 RID: 59751 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E967")]
		[Address(RVA = "0x5F4740", Offset = "0x5F3340", VA = "0x1805F4740")]
		private void <>xLuaBaseProxy_OnTick(FP P0)
		{
		}

		// Token: 0x0600E968 RID: 59752 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E968")]
		[Address(RVA = "0x5F4730", Offset = "0x5F3330", VA = "0x1805F4730")]
		private void <>xLuaBaseProxy_OnProjectileBorn()
		{
		}

		// Token: 0x0600E969 RID: 59753 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E969")]
		[Address(RVA = "0x5F4720", Offset = "0x5F3320", VA = "0x1805F4720")]
		private void <>xLuaBaseProxy_OnHitTarget(Entity P0)
		{
		}

		// Token: 0x0401014E RID: 65870
		[Token(Token = "0x401014E")]
		[FieldOffset(Offset = "0x188")]
		[SerializeField]
		[Inspect(-1)]
		private LifeType _lifeTimeType;

		// Token: 0x0401014F RID: 65871
		[Token(Token = "0x401014F")]
		[FieldOffset(Offset = "0x18C")]
		[SerializeField]
		[Inspect("IsLifeTimeLimited", -1)]
		private float _lifeTime;

		// Token: 0x04010150 RID: 65872
		[Token(Token = "0x4010150")]
		[FieldOffset(Offset = "0x190")]
		[SerializeField]
		[Inspect("IsLifeTimeLimited")]
		private bool _getLifeTimeFromBB;

		// Token: 0x04010151 RID: 65873
		[Token(Token = "0x4010151")]
		[FieldOffset(Offset = "0x194")]
		[SerializeField]
		[Group("Link")]
		private float _linkDuration;

		// Token: 0x04010152 RID: 65874
		[Token(Token = "0x4010152")]
		[FieldOffset(Offset = "0x198")]
		[SerializeField]
		[Group("Link")]
		private bool _isSilenceable;

		// Token: 0x04010153 RID: 65875
		[Token(Token = "0x4010153")]
		[FieldOffset(Offset = "0x199")]
		[SerializeField]
		[Group("Link")]
		protected bool _keepHitTarget;

		// Token: 0x04010154 RID: 65876
		[Token(Token = "0x4010154")]
		[FieldOffset(Offset = "0x19A")]
		[SerializeField]
		[Group("Link")]
		private bool _splitDamage;

		// Token: 0x04010155 RID: 65877
		[Token(Token = "0x4010155")]
		[FieldOffset(Offset = "0x19B")]
		[SerializeField]
		[Group("Link")]
		private bool _dontHitInvincibleTarget;

		// Token: 0x04010156 RID: 65878
		[Token(Token = "0x4010156")]
		[FieldOffset(Offset = "0x19C")]
		[SerializeField]
		[Group("Link")]
		private int _maxHitTimes;

		// Token: 0x04010157 RID: 65879
		[Token(Token = "0x4010157")]
		[FieldOffset(Offset = "0x1A0")]
		private int m_maxHitTimes;

		// Token: 0x04010158 RID: 65880
		[Token(Token = "0x4010158")]
		[FieldOffset(Offset = "0x1A4")]
		private int m_curHitTimes;

		// Token: 0x04010159 RID: 65881
		[Token(Token = "0x4010159")]
		[FieldOffset(Offset = "0x1A8")]
		private FP m_linkDuration;

		// Token: 0x0401015A RID: 65882
		[Token(Token = "0x401015A")]
		[FieldOffset(Offset = "0x1B0")]
		protected ObjectPtr<Entity> m_linkTarget;

		// Token: 0x0401015B RID: 65883
		[Token(Token = "0x401015B")]
		[FieldOffset(Offset = "0x1C0")]
		protected bool m_isAttachedToTarget;

		// Token: 0x0401015C RID: 65884
		[Token(Token = "0x401015C")]
		[FieldOffset(Offset = "0x1C8")]
		private MeleeModifierSplitter m_damageSplitter;

		// Token: 0x0401015D RID: 65885
		[Token(Token = "0x401015D")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_linkDuration;

		// Token: 0x0401015E RID: 65886
		[Token(Token = "0x401015E")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_IsLifeTimeLimited;

		// Token: 0x0401015F RID: 65887
		[Token(Token = "0x401015F")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_linkTarget;

		// Token: 0x04010160 RID: 65888
		[Token(Token = "0x4010160")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_set_isAttachedToTarget;

		// Token: 0x04010161 RID: 65889
		[Token(Token = "0x4010161")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_get_isAttachedToTarget;

		// Token: 0x04010162 RID: 65890
		[Token(Token = "0x4010162")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_get_hasSplittedDamage;

		// Token: 0x04010163 RID: 65891
		[Token(Token = "0x4010163")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_get_stopAfterMaxHit;

		// Token: 0x04010164 RID: 65892
		[Token(Token = "0x4010164")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_get_stopAfterFirstHit;

		// Token: 0x04010165 RID: 65893
		[Token(Token = "0x4010165")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_get_stopWhenSourceInvalid;

		// Token: 0x04010166 RID: 65894
		[Token(Token = "0x4010166")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_get_alwaysHitTraceTargetInTheEnd;

		// Token: 0x04010167 RID: 65895
		[Token(Token = "0x4010167")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_get_alwaysHitTraceTargetWhenReached;

		// Token: 0x04010168 RID: 65896
		[Token(Token = "0x4010168")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_get_alwaysReachInTheEnd;

		// Token: 0x04010169 RID: 65897
		[Token(Token = "0x4010169")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0_GetLifeTime;

		// Token: 0x0401016A RID: 65898
		[Token(Token = "0x401016A")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0_GetMaxHitNum;

		// Token: 0x0401016B RID: 65899
		[Token(Token = "0x401016B")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0_GetKeepAlreadyHitTime;

		// Token: 0x0401016C RID: 65900
		[Token(Token = "0x401016C")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0_OnReset;

		// Token: 0x0401016D RID: 65901
		[Token(Token = "0x401016D")]
		[FieldOffset(Offset = "0x80")]
		private static DelegateBridge __Hotfix0_OnInit;

		// Token: 0x0401016E RID: 65902
		[Token(Token = "0x401016E")]
		[FieldOffset(Offset = "0x88")]
		private static DelegateBridge __Hotfix0_OnTick;

		// Token: 0x0401016F RID: 65903
		[Token(Token = "0x401016F")]
		[FieldOffset(Offset = "0x90")]
		private static DelegateBridge __Hotfix0_OnProjectileBorn;

		// Token: 0x04010170 RID: 65904
		[Token(Token = "0x4010170")]
		[FieldOffset(Offset = "0x98")]
		private static DelegateBridge __Hotfix0_OnHitTarget;

		// Token: 0x04010171 RID: 65905
		[Token(Token = "0x4010171")]
		[FieldOffset(Offset = "0xA0")]
		private static DelegateBridge __Hotfix0_DoLink;

		// Token: 0x04010172 RID: 65906
		[Token(Token = "0x4010172")]
		[FieldOffset(Offset = "0xA8")]
		private static DelegateBridge __Hotfix0__InitDamageSplitter;

		// Token: 0x04010173 RID: 65907
		[Token(Token = "0x4010173")]
		[FieldOffset(Offset = "0xB0")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}

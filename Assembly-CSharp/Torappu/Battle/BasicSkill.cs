using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using AdvancedInspector;
using Il2CppDummyDll;
using Torappu.Battle.Action;
using Torappu.Battle.Effects;
using Torappu.Battle.Skills;
using UnityEngine;
using UnityEngine.Serialization;
using XLua;

namespace Torappu.Battle
{
	// Token: 0x02002448 RID: 9288
	[Token(Token = "0x2002448")]
	[RequireComponent(typeof(Ability))]
	public abstract class BasicSkill : MonoBehaviour, Attributes.IAttributesModifier, IEffectSource, IProjectileSource, IBuffSource, IActionNodeSource, IHotfixable
	{
		// Token: 0x17001E90 RID: 7824
		// (get) Token: 0x0600ED95 RID: 60821 RVA: 0x00056DF0 File Offset: 0x00054FF0
		[Token(Token = "0x17001E90")]
		public bool isOverloaded
		{
			[Token(Token = "0x600ED95")]
			[Address(RVA = "0x63D800", Offset = "0x63C400", VA = "0x18063D800")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17001E91 RID: 7825
		// (get) Token: 0x0600ED96 RID: 60822 RVA: 0x00056E08 File Offset: 0x00055008
		[Token(Token = "0x17001E91")]
		public long attributeMask
		{
			[Token(Token = "0x600ED96")]
			[Address(RVA = "0x63C860", Offset = "0x63B460", VA = "0x18063C860", Slot = "4")]
			get
			{
				return 0L;
			}
		}

		// Token: 0x17001E92 RID: 7826
		// (get) Token: 0x0600ED97 RID: 60823 RVA: 0x00056E20 File Offset: 0x00055020
		[Token(Token = "0x17001E92")]
		public int triggerCnt
		{
			[Token(Token = "0x600ED97")]
			[Address(RVA = "0x63F130", Offset = "0x63DD30", VA = "0x18063F130")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17001E93 RID: 7827
		// (get) Token: 0x0600ED98 RID: 60824 RVA: 0x00056E38 File Offset: 0x00055038
		[Token(Token = "0x17001E93")]
		public long abnormalFlagMask
		{
			[Token(Token = "0x600ED98")]
			[Address(RVA = "0x63C710", Offset = "0x63B310", VA = "0x18063C710", Slot = "5")]
			get
			{
				return 0L;
			}
		}

		// Token: 0x17001E94 RID: 7828
		// (get) Token: 0x0600ED99 RID: 60825 RVA: 0x00056E50 File Offset: 0x00055050
		[Token(Token = "0x17001E94")]
		public long abnormalImmuneMask
		{
			[Token(Token = "0x600ED99")]
			[Address(RVA = "0x63C7A0", Offset = "0x63B3A0", VA = "0x18063C7A0", Slot = "6")]
			get
			{
				return 0L;
			}
		}

		// Token: 0x17001E95 RID: 7829
		// (get) Token: 0x0600ED9A RID: 60826 RVA: 0x00056E68 File Offset: 0x00055068
		[Token(Token = "0x17001E95")]
		public long abnormalAntiMask
		{
			[Token(Token = "0x600ED9A")]
			[Address(RVA = "0x63C5F0", Offset = "0x63B1F0", VA = "0x18063C5F0", Slot = "7")]
			get
			{
				return 0L;
			}
		}

		// Token: 0x17001E96 RID: 7830
		// (get) Token: 0x0600ED9B RID: 60827 RVA: 0x00056E80 File Offset: 0x00055080
		[Token(Token = "0x17001E96")]
		public long abnormalComboMask
		{
			[Token(Token = "0x600ED9B")]
			[Address(RVA = "0x63C6B0", Offset = "0x63B2B0", VA = "0x18063C6B0", Slot = "8")]
			get
			{
				return 0L;
			}
		}

		// Token: 0x17001E97 RID: 7831
		// (get) Token: 0x0600ED9C RID: 60828 RVA: 0x00056E98 File Offset: 0x00055098
		[Token(Token = "0x17001E97")]
		public long abnormalComboImmuneMask
		{
			[Token(Token = "0x600ED9C")]
			[Address(RVA = "0x63C650", Offset = "0x63B250", VA = "0x18063C650", Slot = "9")]
			get
			{
				return 0L;
			}
		}

		// Token: 0x17001E98 RID: 7832
		// (get) Token: 0x0600ED9D RID: 60829 RVA: 0x00056EB0 File Offset: 0x000550B0
		[Token(Token = "0x17001E98")]
		public virtual bool showSpAsBulletMode
		{
			[Token(Token = "0x600ED9D")]
			[Address(RVA = "0x63ED70", Offset = "0x63D970", VA = "0x18063ED70", Slot = "15")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17001E99 RID: 7833
		// (get) Token: 0x0600ED9E RID: 60830 RVA: 0x00056EC8 File Offset: 0x000550C8
		[Token(Token = "0x17001E99")]
		public virtual bool recoverSpWhenAffecting
		{
			[Token(Token = "0x600ED9E")]
			[Address(RVA = "0x63E830", Offset = "0x63D430", VA = "0x18063E830", Slot = "16")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17001E9A RID: 7834
		// (get) Token: 0x0600ED9F RID: 60831 RVA: 0x00056EE0 File Offset: 0x000550E0
		[Token(Token = "0x17001E9A")]
		public int defaultModeIndex
		{
			[Token(Token = "0x600ED9F")]
			[Address(RVA = "0x63CF20", Offset = "0x63BB20", VA = "0x18063CF20")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17001E9B RID: 7835
		// (get) Token: 0x0600EDA0 RID: 60832 RVA: 0x00056EF8 File Offset: 0x000550F8
		[Token(Token = "0x17001E9B")]
		protected bool useAttackBlackboardModeIndex
		{
			[Token(Token = "0x600EDA0")]
			[Address(RVA = "0x63F190", Offset = "0x63DD90", VA = "0x18063F190")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17001E9C RID: 7836
		// (get) Token: 0x0600EDA1 RID: 60833 RVA: 0x00056F10 File Offset: 0x00055110
		[Token(Token = "0x17001E9C")]
		public virtual bool stateUninterruptible
		{
			[Token(Token = "0x600EDA1")]
			[Address(RVA = "0x63F0D0", Offset = "0x63DCD0", VA = "0x18063F0D0", Slot = "17")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x0600EDA2 RID: 60834 RVA: 0x00056F28 File Offset: 0x00055128
		[Token(Token = "0x600EDA2")]
		[Address(RVA = "0x63BA70", Offset = "0x63A670", VA = "0x18063BA70", Slot = "18")]
		public virtual bool SatisfySkillRangeIdModeIndex(int modeIndex)
		{
			return default(bool);
		}

		// Token: 0x0600EDA3 RID: 60835 RVA: 0x00056F40 File Offset: 0x00055140
		[Token(Token = "0x600EDA3")]
		[Address(RVA = "0x638690", Offset = "0x637290", VA = "0x180638690", Slot = "19")]
		public virtual bool IsAvailable(PlayerSide operationSide = PlayerSide.DEFAULT)
		{
			return default(bool);
		}

		// Token: 0x17001E9D RID: 7837
		// (get) Token: 0x0600EDA4 RID: 60836 RVA: 0x00056F58 File Offset: 0x00055158
		[Token(Token = "0x17001E9D")]
		public bool ownerCanUseSkill
		{
			[Token(Token = "0x600EDA4")]
			[Address(RVA = "0x63DC70", Offset = "0x63C870", VA = "0x18063DC70")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17001E9E RID: 7838
		// (get) Token: 0x0600EDA5 RID: 60837 RVA: 0x00056F70 File Offset: 0x00055170
		[Token(Token = "0x17001E9E")]
		protected bool ownerNotInAbnormalState
		{
			[Token(Token = "0x600EDA5")]
			[Address(RVA = "0x63DF10", Offset = "0x63CB10", VA = "0x18063DF10")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17001E9F RID: 7839
		// (get) Token: 0x0600EDA6 RID: 60838 RVA: 0x00056F88 File Offset: 0x00055188
		[Token(Token = "0x17001E9F")]
		protected bool ownerCanUseInAbnormalState
		{
			[Token(Token = "0x600EDA6")]
			[Address(RVA = "0x63DB80", Offset = "0x63C780", VA = "0x18063DB80")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17001EA0 RID: 7840
		// (get) Token: 0x0600EDA7 RID: 60839 RVA: 0x00056FA0 File Offset: 0x000551A0
		[Token(Token = "0x17001EA0")]
		private bool ownerSkillActivatable
		{
			[Token(Token = "0x600EDA7")]
			[Address(RVA = "0x63DF90", Offset = "0x63CB90", VA = "0x18063DF90")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x0600EDA8 RID: 60840 RVA: 0x00056FB8 File Offset: 0x000551B8
		[Token(Token = "0x600EDA8")]
		[Address(RVA = "0x638D40", Offset = "0x637940", VA = "0x180638D40")]
		public bool IsTriggerable(PlayerSide operationSide = PlayerSide.DEFAULT)
		{
			return default(bool);
		}

		// Token: 0x0600EDA9 RID: 60841 RVA: 0x00056FD0 File Offset: 0x000551D0
		[Token(Token = "0x600EDA9")]
		[Address(RVA = "0x6385D0", Offset = "0x6371D0", VA = "0x1806385D0")]
		public bool IsAutoSkillTriggerable(PlayerSide operationSide = PlayerSide.DEFAULT)
		{
			return default(bool);
		}

		// Token: 0x0600EDAA RID: 60842 RVA: 0x00056FE8 File Offset: 0x000551E8
		[Token(Token = "0x600EDAA")]
		[Address(RVA = "0x638A00", Offset = "0x637600", VA = "0x180638A00")]
		public bool IsOpTriggerable(PlayerSide operationSide = PlayerSide.DEFAULT)
		{
			return default(bool);
		}

		// Token: 0x0600EDAB RID: 60843 RVA: 0x00057000 File Offset: 0x00055200
		[Token(Token = "0x600EDAB")]
		[Address(RVA = "0x6387A0", Offset = "0x6373A0", VA = "0x1806387A0", Slot = "20")]
		public virtual bool IsClickable(PlayerSide side = PlayerSide.DEFAULT)
		{
			return default(bool);
		}

		// Token: 0x0600EDAC RID: 60844 RVA: 0x00057018 File Offset: 0x00055218
		[Token(Token = "0x600EDAC")]
		[Address(RVA = "0x6388F0", Offset = "0x6374F0", VA = "0x1806388F0")]
		public bool IsOpRetriggerable(PlayerSide operationSide = PlayerSide.DEFAULT)
		{
			return default(bool);
		}

		// Token: 0x0600EDAD RID: 60845 RVA: 0x00057030 File Offset: 0x00055230
		[Token(Token = "0x600EDAD")]
		[Address(RVA = "0x638B70", Offset = "0x637770", VA = "0x180638B70", Slot = "21")]
		public virtual bool IsRetriggerClickable(PlayerSide side = PlayerSide.DEFAULT)
		{
			return default(bool);
		}

		// Token: 0x0600EDAE RID: 60846 RVA: 0x00057048 File Offset: 0x00055248
		[Token(Token = "0x600EDAE")]
		[Address(RVA = "0x638B00", Offset = "0x637700", VA = "0x180638B00", Slot = "22")]
		public virtual bool IsRetriggerAvailable(PlayerSide operationSide = PlayerSide.DEFAULT)
		{
			return default(bool);
		}

		// Token: 0x0600EDAF RID: 60847 RVA: 0x00057060 File Offset: 0x00055260
		[Token(Token = "0x600EDAF")]
		[Address(RVA = "0x63F2B0", Offset = "0x63DEB0", VA = "0x18063F2B0", Slot = "23")]
		public virtual bool isRetriggerable()
		{
			return default(bool);
		}

		// Token: 0x0600EDB0 RID: 60848 RVA: 0x00057078 File Offset: 0x00055278
		[Token(Token = "0x600EDB0")]
		[Address(RVA = "0x638CB0", Offset = "0x6378B0", VA = "0x180638CB0")]
		public bool IsSuspendable()
		{
			return default(bool);
		}

		// Token: 0x0600EDB1 RID: 60849 RVA: 0x00057090 File Offset: 0x00055290
		[Token(Token = "0x600EDB1")]
		[Address(RVA = "0x6345F0", Offset = "0x6331F0", VA = "0x1806345F0", Slot = "24")]
		public virtual bool IsDiscardable()
		{
			return default(bool);
		}

		// Token: 0x17001EA1 RID: 7841
		// (get) Token: 0x0600EDB2 RID: 60850 RVA: 0x000570A8 File Offset: 0x000552A8
		[Token(Token = "0x17001EA1")]
		public bool chantSuspendable
		{
			[Token(Token = "0x600EDB2")]
			[Address(RVA = "0x63CE30", Offset = "0x63BA30", VA = "0x18063CE30")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17001EA2 RID: 7842
		// (get) Token: 0x0600EDB3 RID: 60851 RVA: 0x000570C0 File Offset: 0x000552C0
		[Token(Token = "0x17001EA2")]
		public virtual bool isAffecting
		{
			[Token(Token = "0x600EDB3")]
			[Address(RVA = "0x63D4E0", Offset = "0x63C0E0", VA = "0x18063D4E0", Slot = "25")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17001EA3 RID: 7843
		// (get) Token: 0x0600EDB4 RID: 60852 RVA: 0x000570D8 File Offset: 0x000552D8
		// (set) Token: 0x0600EDB5 RID: 60853 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17001EA3")]
		public PlayerSide cachedOperationSide
		{
			[Token(Token = "0x600EDB4")]
			[Address(RVA = "0x63CBE0", Offset = "0x63B7E0", VA = "0x18063CBE0")]
			[CompilerGenerated]
			get
			{
				return PlayerSide.DEFAULT;
			}
			[Token(Token = "0x600EDB5")]
			[Address(RVA = "0x63F390", Offset = "0x63DF90", VA = "0x18063F390")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17001EA4 RID: 7844
		// (get) Token: 0x0600EDB6 RID: 60854 RVA: 0x000570F0 File Offset: 0x000552F0
		[Token(Token = "0x17001EA4")]
		public virtual bool shouldCastLikeAttack
		{
			[Token(Token = "0x600EDB6")]
			[Address(RVA = "0x63ECB0", Offset = "0x63D8B0", VA = "0x18063ECB0", Slot = "26")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17001EA5 RID: 7845
		// (get) Token: 0x0600EDB7 RID: 60855 RVA: 0x00057108 File Offset: 0x00055308
		[Token(Token = "0x17001EA5")]
		public virtual bool shouldChangeToChargeColor
		{
			[Token(Token = "0x600EDB7")]
			[Address(RVA = "0x63ED10", Offset = "0x63D910", VA = "0x18063ED10", Slot = "27")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17001EA6 RID: 7846
		// (get) Token: 0x0600EDB8 RID: 60856 RVA: 0x00057120 File Offset: 0x00055320
		[Token(Token = "0x17001EA6")]
		public virtual bool overrideAudioSignalId
		{
			[Token(Token = "0x600EDB8")]
			[Address(RVA = "0x634E80", Offset = "0x633A80", VA = "0x180634E80", Slot = "28")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17001EA7 RID: 7847
		// (get) Token: 0x0600EDB9 RID: 60857 RVA: 0x00057138 File Offset: 0x00055338
		[Token(Token = "0x17001EA7")]
		public FP overloadRatio
		{
			[Token(Token = "0x600EDB9")]
			[Address(RVA = "0x63DAC0", Offset = "0x63C6C0", VA = "0x18063DAC0")]
			get
			{
				return default(FP);
			}
		}

		// Token: 0x17001EA8 RID: 7848
		// (get) Token: 0x0600EDBA RID: 60858 RVA: 0x00057150 File Offset: 0x00055350
		[Token(Token = "0x17001EA8")]
		public bool alwaysShowSpCount
		{
			[Token(Token = "0x600EDBA")]
			[Address(RVA = "0x63C800", Offset = "0x63B400", VA = "0x18063C800")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17001EA9 RID: 7849
		// (get) Token: 0x0600EDBB RID: 60859 RVA: 0x00057168 File Offset: 0x00055368
		[Token(Token = "0x17001EA9")]
		[Inspect(InspectorLevel.Debug)]
		[ReadOnly]
		public virtual FP remainingTime
		{
			[Token(Token = "0x600EDBB")]
			[Address(RVA = "0x635F10", Offset = "0x634B10", VA = "0x180635F10", Slot = "29")]
			get
			{
				return default(FP);
			}
		}

		// Token: 0x17001EAA RID: 7850
		// (get) Token: 0x0600EDBC RID: 60860 RVA: 0x00057180 File Offset: 0x00055380
		[Token(Token = "0x17001EAA")]
		[Inspect(InspectorLevel.Debug)]
		[ReadOnly]
		public virtual FP remainingProgress
		{
			[Token(Token = "0x600EDBC")]
			[Address(RVA = "0x63EAE0", Offset = "0x63D6E0", VA = "0x18063EAE0", Slot = "30")]
			get
			{
				return default(FP);
			}
		}

		// Token: 0x17001EAB RID: 7851
		// (get) Token: 0x0600EDBD RID: 60861 RVA: 0x00057198 File Offset: 0x00055398
		[Token(Token = "0x17001EAB")]
		[Inspect(InspectorLevel.Debug)]
		[ReadOnly]
		public virtual FP remainingOverloadProgress
		{
			[Token(Token = "0x600EDBD")]
			[Address(RVA = "0x63E8F0", Offset = "0x63D4F0", VA = "0x18063E8F0", Slot = "31")]
			get
			{
				return default(FP);
			}
		}

		// Token: 0x17001EAC RID: 7852
		// (get) Token: 0x0600EDBE RID: 60862 RVA: 0x000571B0 File Offset: 0x000553B0
		[Token(Token = "0x17001EAC")]
		public int availableCnt
		{
			[Token(Token = "0x600EDBE")]
			[Address(RVA = "0x63C8C0", Offset = "0x63B4C0", VA = "0x18063C8C0")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17001EAD RID: 7853
		// (get) Token: 0x0600EDBF RID: 60863 RVA: 0x000571C8 File Offset: 0x000553C8
		[Token(Token = "0x17001EAD")]
		public virtual FP progressToReady
		{
			[Token(Token = "0x600EDBF")]
			[Address(RVA = "0x63E1D0", Offset = "0x63CDD0", VA = "0x18063E1D0", Slot = "32")]
			get
			{
				return default(FP);
			}
		}

		// Token: 0x17001EAE RID: 7854
		// (get) Token: 0x0600EDC0 RID: 60864 RVA: 0x000571E0 File Offset: 0x000553E0
		[Token(Token = "0x17001EAE")]
		public virtual bool spCostZero
		{
			[Token(Token = "0x600EDC0")]
			[Address(RVA = "0x63EDD0", Offset = "0x63D9D0", VA = "0x18063EDD0", Slot = "33")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17001EAF RID: 7855
		// (get) Token: 0x0600EDC1 RID: 60865 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600EDC2 RID: 60866 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17001EAF")]
		public Blackboard blackboard
		{
			[Token(Token = "0x600EDC1")]
			[Address(RVA = "0x63CB80", Offset = "0x63B780", VA = "0x18063CB80")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600EDC2")]
			[Address(RVA = "0x63F310", Offset = "0x63DF10", VA = "0x18063F310")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17001EB0 RID: 7856
		// (get) Token: 0x0600EDC3 RID: 60867 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17001EB0")]
		public Ability ability
		{
			[Token(Token = "0x600EDC3")]
			[Address(RVA = "0x63C590", Offset = "0x63B190", VA = "0x18063C590", Slot = "34")]
			get
			{
				return null;
			}
		}

		// Token: 0x17001EB1 RID: 7857
		// (get) Token: 0x0600EDC4 RID: 60868 RVA: 0x000571F8 File Offset: 0x000553F8
		[Token(Token = "0x17001EB1")]
		public virtual Ability.FamilyGroup familyGroup
		{
			[Token(Token = "0x600EDC4")]
			[Address(RVA = "0x63D080", Offset = "0x63BC80", VA = "0x18063D080", Slot = "35")]
			get
			{
				return Ability.FamilyGroup.ATTACK;
			}
		}

		// Token: 0x17001EB2 RID: 7858
		// (get) Token: 0x0600EDC5 RID: 60869 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17001EB2")]
		public virtual IDrawableRange rangeToShow
		{
			[Token(Token = "0x600EDC5")]
			[Address(RVA = "0x63E4E0", Offset = "0x63D0E0", VA = "0x18063E4E0", Slot = "36")]
			get
			{
				return null;
			}
		}

		// Token: 0x17001EB3 RID: 7859
		// (get) Token: 0x0600EDC6 RID: 60870 RVA: 0x00057210 File Offset: 0x00055410
		[Token(Token = "0x17001EB3")]
		public bool playCharWordVoice
		{
			[Token(Token = "0x600EDC6")]
			[Address(RVA = "0x63E0B0", Offset = "0x63CCB0", VA = "0x18063E0B0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17001EB4 RID: 7860
		// (get) Token: 0x0600EDC7 RID: 60871 RVA: 0x00057228 File Offset: 0x00055428
		[Token(Token = "0x17001EB4")]
		public bool playCharWordWithPassiveType
		{
			[Token(Token = "0x600EDC7")]
			[Address(RVA = "0x63E110", Offset = "0x63CD10", VA = "0x18063E110")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17001EB5 RID: 7861
		// (get) Token: 0x0600EDC8 RID: 60872 RVA: 0x00057240 File Offset: 0x00055440
		[Token(Token = "0x17001EB5")]
		public bool canCastWithNoSp
		{
			[Token(Token = "0x600EDC8")]
			[Address(RVA = "0x63CCB0", Offset = "0x63B8B0", VA = "0x18063CCB0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17001EB6 RID: 7862
		// (get) Token: 0x0600EDC9 RID: 60873 RVA: 0x00057258 File Offset: 0x00055458
		[Token(Token = "0x17001EB6")]
		public bool spEnough
		{
			[Token(Token = "0x600EDC9")]
			[Address(RVA = "0x63EEF0", Offset = "0x63DAF0", VA = "0x18063EEF0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17001EB7 RID: 7863
		// (get) Token: 0x0600EDCA RID: 60874 RVA: 0x00057270 File Offset: 0x00055470
		[Token(Token = "0x17001EB7")]
		protected virtual bool canSkipReduceSp
		{
			[Token(Token = "0x600EDCA")]
			[Address(RVA = "0x634660", Offset = "0x633260", VA = "0x180634660", Slot = "37")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17001EB8 RID: 7864
		// (get) Token: 0x0600EDCB RID: 60875 RVA: 0x00057288 File Offset: 0x00055488
		[Token(Token = "0x17001EB8")]
		protected virtual bool forceToShowRange
		{
			[Token(Token = "0x600EDCB")]
			[Address(RVA = "0x63D0E0", Offset = "0x63BCE0", VA = "0x18063D0E0", Slot = "38")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17001EB9 RID: 7865
		// (get) Token: 0x0600EDCC RID: 60876 RVA: 0x000572A0 File Offset: 0x000554A0
		[Token(Token = "0x17001EB9")]
		protected virtual bool forceUseBaseShowRange
		{
			[Token(Token = "0x600EDCC")]
			[Address(RVA = "0x63D140", Offset = "0x63BD40", VA = "0x18063D140", Slot = "39")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17001EBA RID: 7866
		// (get) Token: 0x0600EDCD RID: 60877 RVA: 0x000572B8 File Offset: 0x000554B8
		[Token(Token = "0x17001EBA")]
		public virtual bool isUsedUp
		{
			[Token(Token = "0x600EDCD")]
			[Address(RVA = "0x63D8C0", Offset = "0x63C4C0", VA = "0x18063D8C0", Slot = "40")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17001EBB RID: 7867
		// (get) Token: 0x0600EDCE RID: 60878 RVA: 0x000572D0 File Offset: 0x000554D0
		// (set) Token: 0x0600EDCF RID: 60879 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17001EBB")]
		protected bool registeredAsModifier
		{
			[Token(Token = "0x600EDCE")]
			[Address(RVA = "0x63E890", Offset = "0x63D490", VA = "0x18063E890")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600EDCF")]
			[Address(RVA = "0x63F400", Offset = "0x63E000", VA = "0x18063F400")]
			set
			{
			}
		}

		// Token: 0x17001EBC RID: 7868
		// (get) Token: 0x0600EDD0 RID: 60880 RVA: 0x000572E8 File Offset: 0x000554E8
		[Token(Token = "0x17001EBC")]
		protected bool useRangeIdModeIndex
		{
			[Token(Token = "0x600EDD0")]
			[Address(RVA = "0x63F1F0", Offset = "0x63DDF0", VA = "0x18063F1F0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17001EBD RID: 7869
		// (get) Token: 0x0600EDD1 RID: 60881 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17001EBD")]
		public SkillData data
		{
			[Token(Token = "0x600EDD1")]
			[Address(RVA = "0x63CEC0", Offset = "0x63BAC0", VA = "0x18063CEC0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17001EBE RID: 7870
		// (get) Token: 0x0600EDD2 RID: 60882 RVA: 0x00057300 File Offset: 0x00055500
		[Token(Token = "0x17001EBE")]
		public bool hidden
		{
			[Token(Token = "0x600EDD2")]
			[Address(RVA = "0x63D3C0", Offset = "0x63BFC0", VA = "0x18063D3C0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17001EBF RID: 7871
		// (get) Token: 0x0600EDD3 RID: 60883 RVA: 0x00057318 File Offset: 0x00055518
		[Token(Token = "0x17001EBF")]
		public bool needToDisplay
		{
			[Token(Token = "0x600EDD3")]
			[Address(RVA = "0x63DA40", Offset = "0x63C640", VA = "0x18063DA40")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17001EC0 RID: 7872
		// (get) Token: 0x0600EDD4 RID: 60884 RVA: 0x00057330 File Offset: 0x00055530
		[Token(Token = "0x17001EC0")]
		public bool needToDisplaySpBar
		{
			[Token(Token = "0x600EDD4")]
			[Address(RVA = "0x63D970", Offset = "0x63C570", VA = "0x18063D970")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17001EC1 RID: 7873
		// (get) Token: 0x0600EDD5 RID: 60885 RVA: 0x00057348 File Offset: 0x00055548
		[Token(Token = "0x17001EC1")]
		public virtual bool isRemoteControlled
		{
			[Token(Token = "0x600EDD5")]
			[Address(RVA = "0x63D860", Offset = "0x63C460", VA = "0x18063D860", Slot = "41")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17001EC2 RID: 7874
		// (get) Token: 0x0600EDD6 RID: 60886 RVA: 0x00057360 File Offset: 0x00055560
		[Token(Token = "0x17001EC2")]
		public virtual bool hideProgressFlag
		{
			[Token(Token = "0x600EDD6")]
			[Address(RVA = "0x63D480", Offset = "0x63C080", VA = "0x18063D480", Slot = "42")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17001EC3 RID: 7875
		// (get) Token: 0x0600EDD7 RID: 60887 RVA: 0x00057378 File Offset: 0x00055578
		[Token(Token = "0x17001EC3")]
		public virtual bool hasPlayedBeginAnim
		{
			[Token(Token = "0x600EDD7")]
			[Address(RVA = "0x63D230", Offset = "0x63BE30", VA = "0x18063D230", Slot = "43")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17001EC4 RID: 7876
		// (get) Token: 0x0600EDD8 RID: 60888 RVA: 0x00057390 File Offset: 0x00055590
		[Token(Token = "0x17001EC4")]
		public RangeIdUsage rangeidUsageType
		{
			[Token(Token = "0x600EDD8")]
			[Address(RVA = "0x63E7D0", Offset = "0x63D3D0", VA = "0x18063E7D0")]
			get
			{
				return RangeIdUsage.NONE;
			}
		}

		// Token: 0x17001EC5 RID: 7877
		// (get) Token: 0x0600EDD9 RID: 60889 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17001EC5")]
		public Character owner
		{
			[Token(Token = "0x600EDD9")]
			[Address(RVA = "0x63E050", Offset = "0x63CC50", VA = "0x18063E050")]
			get
			{
				return null;
			}
		}

		// Token: 0x17001EC6 RID: 7878
		// (get) Token: 0x0600EDDA RID: 60890 RVA: 0x000573A8 File Offset: 0x000555A8
		[Token(Token = "0x17001EC6")]
		public FP escapeTime
		{
			[Token(Token = "0x600EDDA")]
			[Address(RVA = "0x63CF80", Offset = "0x63BB80", VA = "0x18063CF80")]
			get
			{
				return default(FP);
			}
		}

		// Token: 0x17001EC7 RID: 7879
		// (get) Token: 0x0600EDDB RID: 60891 RVA: 0x000573C0 File Offset: 0x000555C0
		[Token(Token = "0x17001EC7")]
		public bool playSkillBeginAnim
		{
			[Token(Token = "0x600EDDB")]
			[Address(RVA = "0x63E170", Offset = "0x63CD70", VA = "0x18063E170")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17001EC8 RID: 7880
		// (get) Token: 0x0600EDDC RID: 60892 RVA: 0x000573D8 File Offset: 0x000555D8
		[Token(Token = "0x17001EC8")]
		public bool hasSkillBeginAnim
		{
			[Token(Token = "0x600EDDC")]
			[Address(RVA = "0x63D290", Offset = "0x63BE90", VA = "0x18063D290")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17001EC9 RID: 7881
		// (get) Token: 0x0600EDDD RID: 60893 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17001EC9")]
		public virtual string beginAnim
		{
			[Token(Token = "0x600EDDD")]
			[Address(RVA = "0x63CA30", Offset = "0x63B630", VA = "0x18063CA30", Slot = "44")]
			get
			{
				return null;
			}
		}

		// Token: 0x17001ECA RID: 7882
		// (get) Token: 0x0600EDDE RID: 60894 RVA: 0x000573F0 File Offset: 0x000555F0
		[Token(Token = "0x17001ECA")]
		public bool hasChant
		{
			[Token(Token = "0x600EDDE")]
			[Address(RVA = "0x63D1A0", Offset = "0x63BDA0", VA = "0x18063D1A0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17001ECB RID: 7883
		// (get) Token: 0x0600EDDF RID: 60895 RVA: 0x00057408 File Offset: 0x00055608
		[Token(Token = "0x17001ECB")]
		public float chantProgress
		{
			[Token(Token = "0x600EDDF")]
			[Address(RVA = "0x63CD70", Offset = "0x63B970", VA = "0x18063CD70")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x17001ECC RID: 7884
		// (get) Token: 0x0600EDE0 RID: 60896 RVA: 0x00057420 File Offset: 0x00055620
		[Token(Token = "0x17001ECC")]
		public bool isInChant
		{
			[Token(Token = "0x600EDE0")]
			[Address(RVA = "0x63D620", Offset = "0x63C220", VA = "0x18063D620")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17001ECD RID: 7885
		// (get) Token: 0x0600EDE1 RID: 60897 RVA: 0x00057438 File Offset: 0x00055638
		[Token(Token = "0x17001ECD")]
		public bool isInExtraChant
		{
			[Token(Token = "0x600EDE1")]
			[Address(RVA = "0x63D6E0", Offset = "0x63C2E0", VA = "0x18063D6E0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17001ECE RID: 7886
		// (get) Token: 0x0600EDE2 RID: 60898 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17001ECE")]
		public ChantBeforeSkill chantBehaviour
		{
			[Token(Token = "0x600EDE2")]
			[Address(RVA = "0x63CD10", Offset = "0x63B910", VA = "0x18063CD10")]
			get
			{
				return null;
			}
		}

		// Token: 0x17001ECF RID: 7887
		// (get) Token: 0x0600EDE3 RID: 60899 RVA: 0x00057450 File Offset: 0x00055650
		[Token(Token = "0x17001ECF")]
		public virtual bool canCastCheck
		{
			[Token(Token = "0x600EDE3")]
			[Address(RVA = "0x63CC40", Offset = "0x63B840", VA = "0x18063CC40", Slot = "45")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17001ED0 RID: 7888
		// (get) Token: 0x0600EDE4 RID: 60900 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17001ED0")]
		public virtual string[] beginEffect
		{
			[Token(Token = "0x600EDE4")]
			[Address(RVA = "0x63CB20", Offset = "0x63B720", VA = "0x18063CB20", Slot = "46")]
			get
			{
				return null;
			}
		}

		// Token: 0x17001ED1 RID: 7889
		// (get) Token: 0x0600EDE5 RID: 60901 RVA: 0x00057468 File Offset: 0x00055668
		[Token(Token = "0x17001ED1")]
		public bool writeDurationToAttackBlackboard
		{
			[Token(Token = "0x600EDE5")]
			[Address(RVA = "0x63F250", Offset = "0x63DE50", VA = "0x18063F250")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17001ED2 RID: 7890
		// (get) Token: 0x0600EDE6 RID: 60902 RVA: 0x00057480 File Offset: 0x00055680
		[Token(Token = "0x17001ED2")]
		public virtual bool isOverloadSkill
		{
			[Token(Token = "0x600EDE6")]
			[Address(RVA = "0x63D7A0", Offset = "0x63C3A0", VA = "0x18063D7A0", Slot = "47")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x0600EDE7 RID: 60903 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600EDE7")]
		[Address(RVA = "0x6368E0", Offset = "0x6354E0", VA = "0x1806368E0", Slot = "48")]
		public virtual void AssignData(SkillData data, Character owner, Blackboard externalBlackboard, UnitDataFlowConfig.Delta modifier)
		{
		}

		// Token: 0x0600EDE8 RID: 60904 RVA: 0x00057498 File Offset: 0x00055698
		[Token(Token = "0x600EDE8")]
		[Address(RVA = "0x637770", Offset = "0x636370", VA = "0x180637770")]
		public bool Cast([Optional] Ability.FinishCallbackDelegate finishCb, PlayerSide operationSide = PlayerSide.DEFAULT)
		{
			return default(bool);
		}

		// Token: 0x0600EDE9 RID: 60905 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600EDE9")]
		[Address(RVA = "0x63BC10", Offset = "0x63A810", VA = "0x18063BC10")]
		public void Tick(FP deltaTime)
		{
		}

		// Token: 0x0600EDEA RID: 60906
		[Token(Token = "0x600EDEA")]
		protected abstract bool DoCast(Ability.FinishCallbackDelegate finishCb, PlayerSide operationSide = PlayerSide.DEFAULT);

		// Token: 0x0600EDEB RID: 60907 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600EDEB")]
		[Address(RVA = "0x63A670", Offset = "0x639270", VA = "0x18063A670")]
		protected void OnSkillStart()
		{
		}

		// Token: 0x0600EDEC RID: 60908 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600EDEC")]
		[Address(RVA = "0x63A110", Offset = "0x638D10", VA = "0x18063A110", Slot = "50")]
		protected virtual void OnSkillEnd()
		{
		}

		// Token: 0x0600EDED RID: 60909
		[Token(Token = "0x600EDED")]
		public abstract bool UseSkill(PlayerSide operationSide = PlayerSide.DEFAULT);

		// Token: 0x0600EDEE RID: 60910 RVA: 0x000574B0 File Offset: 0x000556B0
		[Token(Token = "0x600EDEE")]
		[Address(RVA = "0x63BA00", Offset = "0x63A600", VA = "0x18063BA00", Slot = "52")]
		public virtual bool RetriggerSkill(PlayerSide operationSide = PlayerSide.DEFAULT)
		{
			return default(bool);
		}

		// Token: 0x0600EDEF RID: 60911 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600EDEF")]
		[Address(RVA = "0x638390", Offset = "0x636F90", VA = "0x180638390", Slot = "53")]
		public virtual void InterruptIfNot()
		{
		}

		// Token: 0x0600EDF0 RID: 60912 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600EDF0")]
		[Address(RVA = "0x639A60", Offset = "0x638660", VA = "0x180639A60", Slot = "54")]
		public virtual void OnEnterSkillState()
		{
		}

		// Token: 0x0600EDF1 RID: 60913 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600EDF1")]
		[Address(RVA = "0x63BD80", Offset = "0x63A980", VA = "0x18063BD80", Slot = "55")]
		public virtual void TryPrepare()
		{
		}

		// Token: 0x0600EDF2 RID: 60914 RVA: 0x000574C8 File Offset: 0x000556C8
		[Token(Token = "0x600EDF2")]
		[Address(RVA = "0x637710", Offset = "0x636310", VA = "0x180637710", Slot = "56")]
		public virtual bool CanCastCheckBeforeStart()
		{
			return default(bool);
		}

		// Token: 0x0600EDF3 RID: 60915 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600EDF3")]
		[Address(RVA = "0x639B40", Offset = "0x638740", VA = "0x180639B40", Slot = "57")]
		public virtual void OnInit()
		{
		}

		// Token: 0x0600EDF4 RID: 60916 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600EDF4")]
		[Address(RVA = "0x6393D0", Offset = "0x637FD0", VA = "0x1806393D0", Slot = "58")]
		public virtual void OnBorn()
		{
		}

		// Token: 0x0600EDF5 RID: 60917 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600EDF5")]
		[Address(RVA = "0x634E20", Offset = "0x633A20", VA = "0x180634E20", Slot = "59")]
		public virtual void OnLocate()
		{
		}

		// Token: 0x0600EDF6 RID: 60918 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600EDF6")]
		[Address(RVA = "0x639C80", Offset = "0x638880", VA = "0x180639C80", Slot = "60")]
		public virtual void OnOverload()
		{
		}

		// Token: 0x0600EDF7 RID: 60919 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600EDF7")]
		[Address(RVA = "0x639D50", Offset = "0x638950", VA = "0x180639D50", Slot = "61")]
		public virtual void OnOwnerFinish(Entity.FinishReason reason)
		{
		}

		// Token: 0x0600EDF8 RID: 60920 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600EDF8")]
		[Address(RVA = "0x639750", Offset = "0x638350", VA = "0x180639750", Slot = "62")]
		protected virtual void OnCastSucceed()
		{
		}

		// Token: 0x0600EDF9 RID: 60921 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600EDF9")]
		[Address(RVA = "0x639570", Offset = "0x638170", VA = "0x180639570", Slot = "63")]
		public virtual void OnCastFailedInSkillState()
		{
		}

		// Token: 0x0600EDFA RID: 60922 RVA: 0x000574E0 File Offset: 0x000556E0
		[Token(Token = "0x600EDFA")]
		[Address(RVA = "0x638F80", Offset = "0x637B80", VA = "0x180638F80", Slot = "64")]
		public virtual bool OnBeforeAttack(Ability ability, bool isCombat)
		{
			return default(bool);
		}

		// Token: 0x0600EDFB RID: 60923 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600EDFB")]
		[Address(RVA = "0x638EF0", Offset = "0x637AF0", VA = "0x180638EF0", Slot = "65")]
		public virtual void OnAfterAttack(Ability ability, bool isCombat, Ability.FinishReason reason)
		{
		}

		// Token: 0x0600EDFC RID: 60924 RVA: 0x000574F8 File Offset: 0x000556F8
		[Token(Token = "0x600EDFC")]
		[Address(RVA = "0x6382B0", Offset = "0x636EB0", VA = "0x1806382B0", Slot = "10")]
		public bool GetValue(AttributeType attribute, out FP addition, out FP multiplier, out FP finalAddition, out FP finalScaler)
		{
			return default(bool);
		}

		// Token: 0x0600EDFD RID: 60925 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600EDFD")]
		[Address(RVA = "0x6381F0", Offset = "0x636DF0", VA = "0x1806381F0")]
		public Blackboard GetAttackBlackboard(UnitMode mode)
		{
			return null;
		}

		// Token: 0x0600EDFE RID: 60926 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600EDFE")]
		[Address(RVA = "0x63B210", Offset = "0x639E10", VA = "0x18063B210", Slot = "66")]
		public virtual void PlayBeginEffectAndAudio()
		{
		}

		// Token: 0x0600EDFF RID: 60927 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600EDFF")]
		[Address(RVA = "0x638480", Offset = "0x637080", VA = "0x180638480")]
		public void InterruptStartIfNot()
		{
		}

		// Token: 0x0600EE00 RID: 60928 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600EE00")]
		[Address(RVA = "0x637C40", Offset = "0x636840", VA = "0x180637C40")]
		public void DoStartSkill()
		{
		}

		// Token: 0x0600EE01 RID: 60929 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600EE01")]
		[Address(RVA = "0x63AF10", Offset = "0x639B10", VA = "0x18063AF10", Slot = "67")]
		public virtual IEnumerator PlayBeginAnimation()
		{
			return null;
		}

		// Token: 0x0600EE02 RID: 60930 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600EE02")]
		[Address(RVA = "0x63AFC0", Offset = "0x639BC0", VA = "0x18063AFC0", Slot = "68")]
		public virtual void PlayBeginAudio()
		{
		}

		// Token: 0x0600EE03 RID: 60931 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600EE03")]
		[Address(RVA = "0x6390E0", Offset = "0x637CE0", VA = "0x1806390E0", Slot = "69")]
		public virtual void OnBeforeSkillBeginAnim()
		{
		}

		// Token: 0x0600EE04 RID: 60932 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600EE04")]
		[Address(RVA = "0x639140", Offset = "0x637D40", VA = "0x180639140")]
		public void OnBeforeSkillStart(Action startSkill)
		{
		}

		// Token: 0x0600EE05 RID: 60933 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600EE05")]
		[Address(RVA = "0x639010", Offset = "0x637C10", VA = "0x180639010")]
		private void OnBeforePlayBeginAnimation()
		{
		}

		// Token: 0x0600EE06 RID: 60934 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600EE06")]
		[Address(RVA = "0x637910", Offset = "0x636510", VA = "0x180637910")]
		public void ClearBeginEffect()
		{
		}

		// Token: 0x0600EE07 RID: 60935 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600EE07")]
		[Address(RVA = "0x637B40", Offset = "0x636740", VA = "0x180637B40")]
		public void DealDummySkillBehaviours(Deck deck, Deck.Card card)
		{
		}

		// Token: 0x0600EE08 RID: 60936 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600EE08")]
		[Address(RVA = "0x637EF0", Offset = "0x636AF0", VA = "0x180637EF0", Slot = "70")]
		public virtual void GatherEffects(List<string> effects)
		{
		}

		// Token: 0x0600EE09 RID: 60937 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600EE09")]
		[Address(RVA = "0x6380F0", Offset = "0x636CF0", VA = "0x1806380F0", Slot = "71")]
		public virtual void GatherProjectiles(List<string> projectiles)
		{
		}

		// Token: 0x0600EE0A RID: 60938 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600EE0A")]
		[Address(RVA = "0x637DF0", Offset = "0x6369F0", VA = "0x180637DF0", Slot = "72")]
		public virtual void GatherBuffs(List<BuffData> buffs)
		{
		}

		// Token: 0x0600EE0B RID: 60939 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600EE0B")]
		[Address(RVA = "0x637CD0", Offset = "0x6368D0", VA = "0x180637CD0", Slot = "73")]
		public virtual void GatherActionNodes(List<ActionNode> actions)
		{
		}

		// Token: 0x0600EE0C RID: 60940 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600EE0C")]
		[Address(RVA = "0x63AB40", Offset = "0x639740", VA = "0x18063AB40", Slot = "74")]
		protected virtual void OnTick(FP deltaTime)
		{
		}

		// Token: 0x0600EE0D RID: 60941 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600EE0D")]
		[Address(RVA = "0x63ADC0", Offset = "0x6399C0", VA = "0x18063ADC0")]
		private void OverloadIfNecessary()
		{
		}

		// Token: 0x0600EE0E RID: 60942 RVA: 0x00057510 File Offset: 0x00055710
		[Token(Token = "0x600EE0E")]
		[Address(RVA = "0x63B720", Offset = "0x63A320", VA = "0x18063B720")]
		protected bool ReduceSp(int delta)
		{
			return default(bool);
		}

		// Token: 0x0600EE0F RID: 60943 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600EE0F")]
		[Address(RVA = "0x63BE60", Offset = "0x63AA60", VA = "0x18063BE60", Slot = "75")]
		protected virtual void UpdateSpRecovery()
		{
		}

		// Token: 0x0600EE10 RID: 60944 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600EE10")]
		[Address(RVA = "0x639670", Offset = "0x638270", VA = "0x180639670", Slot = "76")]
		protected virtual void OnCastFinish(Ability ability, Ability.FinishReason reason, bool resetCd)
		{
		}

		// Token: 0x0600EE11 RID: 60945 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600EE11")]
		[Address(RVA = "0x637560", Offset = "0x636160", VA = "0x180637560", Slot = "77")]
		protected virtual void Awake()
		{
		}

		// Token: 0x0600EE12 RID: 60946 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600EE12")]
		[Address(RVA = "0x63C040", Offset = "0x63AC40", VA = "0x18063C040")]
		protected string _GenerateSignalId(SkillData data)
		{
			return null;
		}

		// Token: 0x0600EE13 RID: 60947 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600EE13")]
		[Address(RVA = "0x63C250", Offset = "0x63AE50", VA = "0x18063C250")]
		private void _OnReceiveAttackFinishEvent(object arg)
		{
		}

		// Token: 0x0600EE14 RID: 60948 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600EE14")]
		[Address(RVA = "0x63BF30", Offset = "0x63AB30", VA = "0x18063BF30")]
		private void _ApplyModifierToData(UnitDataFlowConfig.Delta modifier, ref string rangeId)
		{
		}

		// Token: 0x0600EE15 RID: 60949 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600EE15")]
		[Address(RVA = "0x63B610", Offset = "0x63A210", VA = "0x18063B610")]
		public void PostprocessData(Dictionary<string, TalentData> talentMap)
		{
		}

		// Token: 0x0600EE16 RID: 60950 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600EE16")]
		[Address(RVA = "0x63BBA0", Offset = "0x63A7A0", VA = "0x18063BBA0")]
		public void SwitchSkillRangeIdModeIndex(int modeIndex)
		{
		}

		// Token: 0x0600EE17 RID: 60951 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600EE17")]
		[Address(RVA = "0x63BB40", Offset = "0x63A740", VA = "0x18063BB40")]
		public void SwitchSkillCharWordToPassiveType()
		{
		}

		// Token: 0x0600EE18 RID: 60952 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600EE18")]
		[Address(RVA = "0x638E80", Offset = "0x637A80", VA = "0x180638E80")]
		public void ModifyCostMinSp(int sp)
		{
		}

		// Token: 0x0600EE19 RID: 60953 RVA: 0x00057528 File Offset: 0x00055728
		[Token(Token = "0x600EE19")]
		[Address(RVA = "0x63C0E0", Offset = "0x63ACE0", VA = "0x18063C0E0")]
		private bool _IsStackable()
		{
			return default(bool);
		}

		// Token: 0x17001ED3 RID: 7891
		// (get) Token: 0x0600EE1A RID: 60954 RVA: 0x00057540 File Offset: 0x00055740
		[Token(Token = "0x17001ED3")]
		public virtual bool isAvailableToShowStackCount
		{
			[Token(Token = "0x600EE1A")]
			[Address(RVA = "0x63D5C0", Offset = "0x63C1C0", VA = "0x18063D5C0", Slot = "78")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17001ED4 RID: 7892
		// (get) Token: 0x0600EE1B RID: 60955 RVA: 0x00057558 File Offset: 0x00055758
		[Token(Token = "0x17001ED4")]
		public bool hideHudSkillStackCount
		{
			[Token(Token = "0x600EE1B")]
			[Address(RVA = "0x63D420", Offset = "0x63C020", VA = "0x18063D420")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x0600EE1C RID: 60956 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600EE1C")]
		[Address(RVA = "0x63B930", Offset = "0x63A530", VA = "0x18063B930")]
		public void ReplaceBeginAnim(string beginAnim, string beginAnimDown)
		{
		}

		// Token: 0x0600EE1D RID: 60957 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600EE1D")]
		[Address(RVA = "0x637AC0", Offset = "0x6366C0", VA = "0x180637AC0")]
		public void ClearReplaceBeginAnim()
		{
		}

		// Token: 0x0600EE1E RID: 60958 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600EE1E")]
		[Address(RVA = "0x63C4B0", Offset = "0x63B0B0", VA = "0x18063C4B0")]
		protected BasicSkill()
		{
		}

		// Token: 0x040106AE RID: 67246
		[Token(Token = "0x40106AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private int _maxTriggerTime;

		// Token: 0x040106AF RID: 67247
		[Token(Token = "0x40106AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private bool _allowSpRecoveryWhenAffecting;

		// Token: 0x040106B0 RID: 67248
		[Token(Token = "0x40106B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1D")]
		[SerializeField]
		private bool _limitGlobalTriggerTime;

		// Token: 0x040106B1 RID: 67249
		[Token(Token = "0x40106B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1E")]
		[SerializeField]
		private bool _hidden;

		// Token: 0x040106B2 RID: 67250
		[Token(Token = "0x40106B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1F")]
		[SerializeField]
		private bool _showSpBarEvenHidden;

		// Token: 0x040106B3 RID: 67251
		[Token(Token = "0x40106B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private bool _showSpAsBulletMode;

		// Token: 0x040106B4 RID: 67252
		[Token(Token = "0x40106B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x21")]
		[SerializeField]
		private bool _showSpRatioAsProgress;

		// Token: 0x040106B5 RID: 67253
		[Token(Token = "0x40106B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x22")]
		[SerializeField]
		private bool _playCharWordVoice;

		// Token: 0x040106B6 RID: 67254
		[Token(Token = "0x40106B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x23")]
		[SerializeField]
		[Inspect("playCharWordVoice")]
		private bool _playCharWordWithPassiveType;

		// Token: 0x040106B7 RID: 67255
		[Token(Token = "0x40106B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[SerializeField]
		private bool _canCastWithNoSp;

		// Token: 0x040106B8 RID: 67256
		[Token(Token = "0x40106B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x25")]
		[SerializeField]
		private bool _canSilenced;

		// Token: 0x040106B9 RID: 67257
		[Token(Token = "0x40106B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x26")]
		[SerializeField]
		private bool _canUseInAbnormalState;

		// Token: 0x040106BA RID: 67258
		[Token(Token = "0x40106BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		[Group("Mode")]
		private int _defaultModeIndex;

		// Token: 0x040106BB RID: 67259
		[Token(Token = "0x40106BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[SerializeField]
		[FormerlySerializedAs("_blackboardModeIndex")]
		[Group("Mode")]
		private int _attackBlackboardModeIndex;

		// Token: 0x040106BC RID: 67260
		[Token(Token = "0x40106BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		[Group("Mode")]
		[Inspect("useAttackBlackboardModeIndex")]
		private int[] _extraAttackBlackboardModeIndices;

		// Token: 0x040106BD RID: 67261
		[Token(Token = "0x40106BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[SerializeField]
		[Group("Mode")]
		[Tooltip("RangeId to feed into corresponding |UnitMode|.")]
		private int _rangeIdModeIndex;

		// Token: 0x040106BE RID: 67262
		[Token(Token = "0x40106BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[SerializeField]
		[Group("Mode")]
		[Inspect("useRangeIdModeIndex")]
		[Tooltip("Append RangeId to feed into corresponding |UnitMode|.")]
		private int[] _extraRangeIdModeIndices;

		// Token: 0x040106BF RID: 67263
		[Token(Token = "0x40106BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[SerializeField]
		[Group("Mode")]
		[Inspect("useRangeIdModeIndex")]
		private RangeIdUsage _rangeIdUsageType;

		// Token: 0x040106C0 RID: 67264
		[Token(Token = "0x40106C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x49")]
		[Group("Mode")]
		[Inspect("useAttackBlackboardModeIndex")]
		[SerializeField]
		private bool _writeDurationToAttackBlackboard;

		// Token: 0x040106C1 RID: 67265
		[Token(Token = "0x40106C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4A")]
		[SerializeField]
		[Group("Internal")]
		private bool _attachSignalIds;

		// Token: 0x040106C2 RID: 67266
		[Token(Token = "0x40106C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[SerializeField]
		[Group("Internal")]
		private Ability[] _extraAbilities;

		// Token: 0x040106C3 RID: 67267
		[Token(Token = "0x40106C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[SerializeField]
		[Group("Internal")]
		private bool _useEscapeTime;

		// Token: 0x040106C4 RID: 67268
		[Token(Token = "0x40106C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x59")]
		[SerializeField]
		[Group("Internal")]
		private bool _earlySkillFinishAtAttackFinished;

		// Token: 0x040106C5 RID: 67269
		[Token(Token = "0x40106C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5A")]
		[SerializeField]
		[Group("ChargeSkill")]
		private bool _showProgressToNext;

		// Token: 0x040106C6 RID: 67270
		[Token(Token = "0x40106C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5B")]
		[SerializeField]
		[Group("ChargeSkill")]
		private bool _hideSkillStackCount;

		// Token: 0x040106C7 RID: 67271
		[Token(Token = "0x40106C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		[SerializeField]
		[Group("ChargeSkill")]
		private bool _hideHudSkillStackCount;

		// Token: 0x040106C8 RID: 67272
		[Token(Token = "0x40106C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5D")]
		[SerializeField]
		[Group("Animation")]
		private bool _playSkillBeginAnim;

		// Token: 0x040106C9 RID: 67273
		[Token(Token = "0x40106C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[SerializeField]
		[Group("Animation")]
		[Inspect("playSkillBeginAnim")]
		private string _beginAnim;

		// Token: 0x040106CA RID: 67274
		[Token(Token = "0x40106CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[SerializeField]
		[Group("Animation")]
		[Inspect("playSkillBeginAnim")]
		private string _beginAnimDown;

		// Token: 0x040106CB RID: 67275
		[Token(Token = "0x40106CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[Inspect("playSkillBeginAnim")]
		[SerializeField]
		[Group("Animation")]
		private string[] _beginEffect;

		// Token: 0x040106CC RID: 67276
		[Token(Token = "0x40106CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[SerializeField]
		[Group("Animation")]
		[Inspect("playSkillBeginAnim")]
		private bool _useFaceVector;

		// Token: 0x040106CD RID: 67277
		[Token(Token = "0x40106CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		[SerializeField]
		[Group("Animation")]
		[Inspect("playSkillBeginAnim")]
		private TargetValidator _beginAnimValidator;

		// Token: 0x040106CE RID: 67278
		[Token(Token = "0x40106CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		[SerializeField]
		private TargetValidator _availableValidator;

		// Token: 0x040106CF RID: 67279
		[Token(Token = "0x40106CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private int m_triggerCnt;

		// Token: 0x040106D0 RID: 67280
		[Token(Token = "0x40106D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
		private int m_rangeIdModeIndex;

		// Token: 0x040106D1 RID: 67281
		[Token(Token = "0x40106D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private bool m_waitForSkillEnd;

		// Token: 0x040106D2 RID: 67282
		[Token(Token = "0x40106D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x99")]
		private bool m_isEarlyFinished;

		// Token: 0x040106D3 RID: 67283
		[Token(Token = "0x40106D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x9A")]
		private bool m_isOverloaded;

		// Token: 0x040106D4 RID: 67284
		[Token(Token = "0x40106D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x9B")]
		private bool m_playCharWordWithPassiveType;

		// Token: 0x040106D5 RID: 67285
		[Token(Token = "0x40106D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
		private int m_costMinSp;

		// Token: 0x040106D6 RID: 67286
		[Token(Token = "0x40106D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private Character m_owner;

		// Token: 0x040106D7 RID: 67287
		[Token(Token = "0x40106D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private SkillData m_data;

		// Token: 0x040106D8 RID: 67288
		[Token(Token = "0x40106D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private Blackboard m_attackBlackboard;

		// Token: 0x040106D9 RID: 67289
		[Token(Token = "0x40106D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private Ability m_ability;

		// Token: 0x040106DA RID: 67290
		[Token(Token = "0x40106DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private bool m_registeredAsModifier;

		// Token: 0x040106DB RID: 67291
		[Token(Token = "0x40106DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
		private int m_maxTriggerTime;

		// Token: 0x040106DC RID: 67292
		[Token(Token = "0x40106DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		private List<ObjectPtr<Effect>> m_beginEffects;

		// Token: 0x040106DD RID: 67293
		[Token(Token = "0x40106DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		protected BasicSkill.Behaviour[] m_behaviours;

		// Token: 0x040106DE RID: 67294
		[Token(Token = "0x40106DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		private ChantBeforeSkill m_chantBehavior;

		// Token: 0x040106DF RID: 67295
		[Token(Token = "0x40106DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		private Action m_startSkill;

		// Token: 0x040106E0 RID: 67296
		[Token(Token = "0x40106E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		private CoroutineId m_startSkillCoroutine;

		// Token: 0x040106E1 RID: 67297
		[Token(Token = "0x40106E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		private string m_beginAnim;

		// Token: 0x040106E2 RID: 67298
		[Token(Token = "0x40106E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
		private string m_beginAnimDown;

		// Token: 0x040106E5 RID: 67301
		[Token(Token = "0x40106E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_isOverloaded;

		// Token: 0x040106E6 RID: 67302
		[Token(Token = "0x40106E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_attributeMask;

		// Token: 0x040106E7 RID: 67303
		[Token(Token = "0x40106E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_triggerCnt;

		// Token: 0x040106E8 RID: 67304
		[Token(Token = "0x40106E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_get_abnormalFlagMask;

		// Token: 0x040106E9 RID: 67305
		[Token(Token = "0x40106E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_get_abnormalImmuneMask;

		// Token: 0x040106EA RID: 67306
		[Token(Token = "0x40106EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_get_abnormalAntiMask;

		// Token: 0x040106EB RID: 67307
		[Token(Token = "0x40106EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_get_abnormalComboMask;

		// Token: 0x040106EC RID: 67308
		[Token(Token = "0x40106EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_get_abnormalComboImmuneMask;

		// Token: 0x040106ED RID: 67309
		[Token(Token = "0x40106ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_get_showSpAsBulletMode;

		// Token: 0x040106EE RID: 67310
		[Token(Token = "0x40106EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_get_recoverSpWhenAffecting;

		// Token: 0x040106EF RID: 67311
		[Token(Token = "0x40106EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_get_defaultModeIndex;

		// Token: 0x040106F0 RID: 67312
		[Token(Token = "0x40106F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_get_useAttackBlackboardModeIndex;

		// Token: 0x040106F1 RID: 67313
		[Token(Token = "0x40106F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0_get_stateUninterruptible;

		// Token: 0x040106F2 RID: 67314
		[Token(Token = "0x40106F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0_SatisfySkillRangeIdModeIndex;

		// Token: 0x040106F3 RID: 67315
		[Token(Token = "0x40106F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0_IsAvailable;

		// Token: 0x040106F4 RID: 67316
		[Token(Token = "0x40106F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0_get_ownerCanUseSkill;

		// Token: 0x040106F5 RID: 67317
		[Token(Token = "0x40106F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private static DelegateBridge __Hotfix0_get_ownerNotInAbnormalState;

		// Token: 0x040106F6 RID: 67318
		[Token(Token = "0x40106F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private static DelegateBridge __Hotfix0_get_ownerCanUseInAbnormalState;

		// Token: 0x040106F7 RID: 67319
		[Token(Token = "0x40106F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private static DelegateBridge __Hotfix0_get_ownerSkillActivatable;

		// Token: 0x040106F8 RID: 67320
		[Token(Token = "0x40106F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private static DelegateBridge __Hotfix0_IsTriggerable;

		// Token: 0x040106F9 RID: 67321
		[Token(Token = "0x40106F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private static DelegateBridge __Hotfix0_IsAutoSkillTriggerable;

		// Token: 0x040106FA RID: 67322
		[Token(Token = "0x40106FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private static DelegateBridge __Hotfix0_IsOpTriggerable;

		// Token: 0x040106FB RID: 67323
		[Token(Token = "0x40106FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private static DelegateBridge __Hotfix0_IsClickable;

		// Token: 0x040106FC RID: 67324
		[Token(Token = "0x40106FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private static DelegateBridge __Hotfix0_IsOpRetriggerable;

		// Token: 0x040106FD RID: 67325
		[Token(Token = "0x40106FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private static DelegateBridge __Hotfix0_IsRetriggerClickable;

		// Token: 0x040106FE RID: 67326
		[Token(Token = "0x40106FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		private static DelegateBridge __Hotfix0_IsRetriggerAvailable;

		// Token: 0x040106FF RID: 67327
		[Token(Token = "0x40106FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		private static DelegateBridge __Hotfix0_isRetriggerable;

		// Token: 0x04010700 RID: 67328
		[Token(Token = "0x4010700")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		private static DelegateBridge __Hotfix0_IsSuspendable;

		// Token: 0x04010701 RID: 67329
		[Token(Token = "0x4010701")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		private static DelegateBridge __Hotfix0_IsDiscardable;

		// Token: 0x04010702 RID: 67330
		[Token(Token = "0x4010702")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		private static DelegateBridge __Hotfix0_get_chantSuspendable;

		// Token: 0x04010703 RID: 67331
		[Token(Token = "0x4010703")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		private static DelegateBridge __Hotfix0_get_isAffecting;

		// Token: 0x04010704 RID: 67332
		[Token(Token = "0x4010704")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		private static DelegateBridge __Hotfix0_get_cachedOperationSide;

		// Token: 0x04010705 RID: 67333
		[Token(Token = "0x4010705")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
		private static DelegateBridge __Hotfix0_set_cachedOperationSide;

		// Token: 0x04010706 RID: 67334
		[Token(Token = "0x4010706")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
		private static DelegateBridge __Hotfix0_get_shouldCastLikeAttack;

		// Token: 0x04010707 RID: 67335
		[Token(Token = "0x4010707")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
		private static DelegateBridge __Hotfix0_get_shouldChangeToChargeColor;

		// Token: 0x04010708 RID: 67336
		[Token(Token = "0x4010708")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
		private static DelegateBridge __Hotfix0_get_overrideAudioSignalId;

		// Token: 0x04010709 RID: 67337
		[Token(Token = "0x4010709")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
		private static DelegateBridge __Hotfix0_get_overloadRatio;

		// Token: 0x0401070A RID: 67338
		[Token(Token = "0x401070A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
		private static DelegateBridge __Hotfix0_get_alwaysShowSpCount;

		// Token: 0x0401070B RID: 67339
		[Token(Token = "0x401070B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
		private static DelegateBridge __Hotfix0_get_remainingTime;

		// Token: 0x0401070C RID: 67340
		[Token(Token = "0x401070C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
		private static DelegateBridge __Hotfix0_get_remainingProgress;

		// Token: 0x0401070D RID: 67341
		[Token(Token = "0x401070D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x140")]
		private static DelegateBridge __Hotfix0_get_remainingOverloadProgress;

		// Token: 0x0401070E RID: 67342
		[Token(Token = "0x401070E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x148")]
		private static DelegateBridge __Hotfix0_get_availableCnt;

		// Token: 0x0401070F RID: 67343
		[Token(Token = "0x401070F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x150")]
		private static DelegateBridge __Hotfix0_get_progressToReady;

		// Token: 0x04010710 RID: 67344
		[Token(Token = "0x4010710")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x158")]
		private static DelegateBridge __Hotfix0_get_spCostZero;

		// Token: 0x04010711 RID: 67345
		[Token(Token = "0x4010711")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x160")]
		private static DelegateBridge __Hotfix0_get_blackboard;

		// Token: 0x04010712 RID: 67346
		[Token(Token = "0x4010712")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x168")]
		private static DelegateBridge __Hotfix0_set_blackboard;

		// Token: 0x04010713 RID: 67347
		[Token(Token = "0x4010713")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x170")]
		private static DelegateBridge __Hotfix0_get_ability;

		// Token: 0x04010714 RID: 67348
		[Token(Token = "0x4010714")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x178")]
		private static DelegateBridge __Hotfix0_get_familyGroup;

		// Token: 0x04010715 RID: 67349
		[Token(Token = "0x4010715")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x180")]
		private static DelegateBridge __Hotfix0_get_rangeToShow;

		// Token: 0x04010716 RID: 67350
		[Token(Token = "0x4010716")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x188")]
		private static DelegateBridge __Hotfix0_get_playCharWordVoice;

		// Token: 0x04010717 RID: 67351
		[Token(Token = "0x4010717")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x190")]
		private static DelegateBridge __Hotfix0_get_playCharWordWithPassiveType;

		// Token: 0x04010718 RID: 67352
		[Token(Token = "0x4010718")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x198")]
		private static DelegateBridge __Hotfix0_get_canCastWithNoSp;

		// Token: 0x04010719 RID: 67353
		[Token(Token = "0x4010719")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1A0")]
		private static DelegateBridge __Hotfix0_get_spEnough;

		// Token: 0x0401071A RID: 67354
		[Token(Token = "0x401071A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1A8")]
		private static DelegateBridge __Hotfix0_get_canSkipReduceSp;

		// Token: 0x0401071B RID: 67355
		[Token(Token = "0x401071B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1B0")]
		private static DelegateBridge __Hotfix0_get_forceToShowRange;

		// Token: 0x0401071C RID: 67356
		[Token(Token = "0x401071C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1B8")]
		private static DelegateBridge __Hotfix0_get_forceUseBaseShowRange;

		// Token: 0x0401071D RID: 67357
		[Token(Token = "0x401071D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C0")]
		private static DelegateBridge __Hotfix0_get_isUsedUp;

		// Token: 0x0401071E RID: 67358
		[Token(Token = "0x401071E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C8")]
		private static DelegateBridge __Hotfix0_get_registeredAsModifier;

		// Token: 0x0401071F RID: 67359
		[Token(Token = "0x401071F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1D0")]
		private static DelegateBridge __Hotfix0_set_registeredAsModifier;

		// Token: 0x04010720 RID: 67360
		[Token(Token = "0x4010720")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1D8")]
		private static DelegateBridge __Hotfix0_get_useRangeIdModeIndex;

		// Token: 0x04010721 RID: 67361
		[Token(Token = "0x4010721")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1E0")]
		private static DelegateBridge __Hotfix0_get_data;

		// Token: 0x04010722 RID: 67362
		[Token(Token = "0x4010722")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1E8")]
		private static DelegateBridge __Hotfix0_get_hidden;

		// Token: 0x04010723 RID: 67363
		[Token(Token = "0x4010723")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1F0")]
		private static DelegateBridge __Hotfix0_get_needToDisplay;

		// Token: 0x04010724 RID: 67364
		[Token(Token = "0x4010724")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1F8")]
		private static DelegateBridge __Hotfix0_get_needToDisplaySpBar;

		// Token: 0x04010725 RID: 67365
		[Token(Token = "0x4010725")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x200")]
		private static DelegateBridge __Hotfix0_get_isRemoteControlled;

		// Token: 0x04010726 RID: 67366
		[Token(Token = "0x4010726")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x208")]
		private static DelegateBridge __Hotfix0_get_hideProgressFlag;

		// Token: 0x04010727 RID: 67367
		[Token(Token = "0x4010727")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x210")]
		private static DelegateBridge __Hotfix0_get_hasPlayedBeginAnim;

		// Token: 0x04010728 RID: 67368
		[Token(Token = "0x4010728")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x218")]
		private static DelegateBridge __Hotfix0_get_rangeidUsageType;

		// Token: 0x04010729 RID: 67369
		[Token(Token = "0x4010729")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x220")]
		private static DelegateBridge __Hotfix0_get_owner;

		// Token: 0x0401072A RID: 67370
		[Token(Token = "0x401072A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x228")]
		private static DelegateBridge __Hotfix0_get_escapeTime;

		// Token: 0x0401072B RID: 67371
		[Token(Token = "0x401072B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x230")]
		private static DelegateBridge __Hotfix0_get_playSkillBeginAnim;

		// Token: 0x0401072C RID: 67372
		[Token(Token = "0x401072C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x238")]
		private static DelegateBridge __Hotfix0_get_hasSkillBeginAnim;

		// Token: 0x0401072D RID: 67373
		[Token(Token = "0x401072D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x240")]
		private static DelegateBridge __Hotfix0_get_beginAnim;

		// Token: 0x0401072E RID: 67374
		[Token(Token = "0x401072E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x248")]
		private static DelegateBridge __Hotfix0_get_hasChant;

		// Token: 0x0401072F RID: 67375
		[Token(Token = "0x401072F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x250")]
		private static DelegateBridge __Hotfix0_get_chantProgress;

		// Token: 0x04010730 RID: 67376
		[Token(Token = "0x4010730")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x258")]
		private static DelegateBridge __Hotfix0_get_isInChant;

		// Token: 0x04010731 RID: 67377
		[Token(Token = "0x4010731")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x260")]
		private static DelegateBridge __Hotfix0_get_isInExtraChant;

		// Token: 0x04010732 RID: 67378
		[Token(Token = "0x4010732")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x268")]
		private static DelegateBridge __Hotfix0_get_chantBehaviour;

		// Token: 0x04010733 RID: 67379
		[Token(Token = "0x4010733")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x270")]
		private static DelegateBridge __Hotfix0_get_canCastCheck;

		// Token: 0x04010734 RID: 67380
		[Token(Token = "0x4010734")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x278")]
		private static DelegateBridge __Hotfix0_get_beginEffect;

		// Token: 0x04010735 RID: 67381
		[Token(Token = "0x4010735")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x280")]
		private static DelegateBridge __Hotfix0_get_writeDurationToAttackBlackboard;

		// Token: 0x04010736 RID: 67382
		[Token(Token = "0x4010736")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x288")]
		private static DelegateBridge __Hotfix0_get_isOverloadSkill;

		// Token: 0x04010737 RID: 67383
		[Token(Token = "0x4010737")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x290")]
		private static DelegateBridge __Hotfix0_AssignData;

		// Token: 0x04010738 RID: 67384
		[Token(Token = "0x4010738")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x298")]
		private static DelegateBridge __Hotfix0_Cast;

		// Token: 0x04010739 RID: 67385
		[Token(Token = "0x4010739")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2A0")]
		private static DelegateBridge __Hotfix0_Tick;

		// Token: 0x0401073A RID: 67386
		[Token(Token = "0x401073A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2A8")]
		private static DelegateBridge __Hotfix0_OnSkillStart;

		// Token: 0x0401073B RID: 67387
		[Token(Token = "0x401073B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2B0")]
		private static DelegateBridge __Hotfix0_OnSkillEnd;

		// Token: 0x0401073C RID: 67388
		[Token(Token = "0x401073C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2B8")]
		private static DelegateBridge __Hotfix0_RetriggerSkill;

		// Token: 0x0401073D RID: 67389
		[Token(Token = "0x401073D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C0")]
		private static DelegateBridge __Hotfix0_InterruptIfNot;

		// Token: 0x0401073E RID: 67390
		[Token(Token = "0x401073E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C8")]
		private static DelegateBridge __Hotfix0_OnEnterSkillState;

		// Token: 0x0401073F RID: 67391
		[Token(Token = "0x401073F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2D0")]
		private static DelegateBridge __Hotfix0_TryPrepare;

		// Token: 0x04010740 RID: 67392
		[Token(Token = "0x4010740")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2D8")]
		private static DelegateBridge __Hotfix0_CanCastCheckBeforeStart;

		// Token: 0x04010741 RID: 67393
		[Token(Token = "0x4010741")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2E0")]
		private static DelegateBridge __Hotfix0_OnInit;

		// Token: 0x04010742 RID: 67394
		[Token(Token = "0x4010742")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2E8")]
		private static DelegateBridge __Hotfix0_OnBorn;

		// Token: 0x04010743 RID: 67395
		[Token(Token = "0x4010743")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2F0")]
		private static DelegateBridge __Hotfix0_OnLocate;

		// Token: 0x04010744 RID: 67396
		[Token(Token = "0x4010744")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2F8")]
		private static DelegateBridge __Hotfix0_OnOverload;

		// Token: 0x04010745 RID: 67397
		[Token(Token = "0x4010745")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x300")]
		private static DelegateBridge __Hotfix0_OnOwnerFinish;

		// Token: 0x04010746 RID: 67398
		[Token(Token = "0x4010746")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x308")]
		private static DelegateBridge __Hotfix0_OnCastSucceed;

		// Token: 0x04010747 RID: 67399
		[Token(Token = "0x4010747")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x310")]
		private static DelegateBridge __Hotfix0_OnCastFailedInSkillState;

		// Token: 0x04010748 RID: 67400
		[Token(Token = "0x4010748")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x318")]
		private static DelegateBridge __Hotfix0_OnBeforeAttack;

		// Token: 0x04010749 RID: 67401
		[Token(Token = "0x4010749")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x320")]
		private static DelegateBridge __Hotfix0_OnAfterAttack;

		// Token: 0x0401074A RID: 67402
		[Token(Token = "0x401074A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x328")]
		private static DelegateBridge __Hotfix0_GetValue;

		// Token: 0x0401074B RID: 67403
		[Token(Token = "0x401074B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x330")]
		private static DelegateBridge __Hotfix0_GetAttackBlackboard;

		// Token: 0x0401074C RID: 67404
		[Token(Token = "0x401074C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x338")]
		private static DelegateBridge __Hotfix0_PlayBeginEffectAndAudio;

		// Token: 0x0401074D RID: 67405
		[Token(Token = "0x401074D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x340")]
		private static DelegateBridge __Hotfix0_InterruptStartIfNot;

		// Token: 0x0401074E RID: 67406
		[Token(Token = "0x401074E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x348")]
		private static DelegateBridge __Hotfix0_DoStartSkill;

		// Token: 0x0401074F RID: 67407
		[Token(Token = "0x401074F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x350")]
		private static DelegateBridge __Hotfix0_PlayBeginAnimation;

		// Token: 0x04010750 RID: 67408
		[Token(Token = "0x4010750")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x358")]
		private static DelegateBridge __Hotfix0_PlayBeginAudio;

		// Token: 0x04010751 RID: 67409
		[Token(Token = "0x4010751")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x360")]
		private static DelegateBridge __Hotfix0_OnBeforeSkillBeginAnim;

		// Token: 0x04010752 RID: 67410
		[Token(Token = "0x4010752")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x368")]
		private static DelegateBridge __Hotfix0_OnBeforeSkillStart;

		// Token: 0x04010753 RID: 67411
		[Token(Token = "0x4010753")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x370")]
		private static DelegateBridge __Hotfix0_OnBeforePlayBeginAnimation;

		// Token: 0x04010754 RID: 67412
		[Token(Token = "0x4010754")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x378")]
		private static DelegateBridge __Hotfix0_ClearBeginEffect;

		// Token: 0x04010755 RID: 67413
		[Token(Token = "0x4010755")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x380")]
		private static DelegateBridge __Hotfix0_DealDummySkillBehaviours;

		// Token: 0x04010756 RID: 67414
		[Token(Token = "0x4010756")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x388")]
		private static DelegateBridge __Hotfix0_GatherEffects;

		// Token: 0x04010757 RID: 67415
		[Token(Token = "0x4010757")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x390")]
		private static DelegateBridge __Hotfix0_GatherProjectiles;

		// Token: 0x04010758 RID: 67416
		[Token(Token = "0x4010758")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x398")]
		private static DelegateBridge __Hotfix0_GatherBuffs;

		// Token: 0x04010759 RID: 67417
		[Token(Token = "0x4010759")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3A0")]
		private static DelegateBridge __Hotfix0_GatherActionNodes;

		// Token: 0x0401075A RID: 67418
		[Token(Token = "0x401075A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3A8")]
		private static DelegateBridge __Hotfix0_OnTick;

		// Token: 0x0401075B RID: 67419
		[Token(Token = "0x401075B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3B0")]
		private static DelegateBridge __Hotfix0_OverloadIfNecessary;

		// Token: 0x0401075C RID: 67420
		[Token(Token = "0x401075C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3B8")]
		private static DelegateBridge __Hotfix0_ReduceSp;

		// Token: 0x0401075D RID: 67421
		[Token(Token = "0x401075D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C0")]
		private static DelegateBridge __Hotfix0_UpdateSpRecovery;

		// Token: 0x0401075E RID: 67422
		[Token(Token = "0x401075E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C8")]
		private static DelegateBridge __Hotfix0_OnCastFinish;

		// Token: 0x0401075F RID: 67423
		[Token(Token = "0x401075F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3D0")]
		private static DelegateBridge __Hotfix0_Awake;

		// Token: 0x04010760 RID: 67424
		[Token(Token = "0x4010760")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3D8")]
		private static DelegateBridge __Hotfix0__GenerateSignalId;

		// Token: 0x04010761 RID: 67425
		[Token(Token = "0x4010761")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3E0")]
		private static DelegateBridge __Hotfix0__OnReceiveAttackFinishEvent;

		// Token: 0x04010762 RID: 67426
		[Token(Token = "0x4010762")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3E8")]
		private static DelegateBridge __Hotfix0__ApplyModifierToData;

		// Token: 0x04010763 RID: 67427
		[Token(Token = "0x4010763")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3F0")]
		private static DelegateBridge __Hotfix0_PostprocessData;

		// Token: 0x04010764 RID: 67428
		[Token(Token = "0x4010764")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3F8")]
		private static DelegateBridge __Hotfix0_SwitchSkillRangeIdModeIndex;

		// Token: 0x04010765 RID: 67429
		[Token(Token = "0x4010765")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x400")]
		private static DelegateBridge __Hotfix0_SwitchSkillCharWordToPassiveType;

		// Token: 0x04010766 RID: 67430
		[Token(Token = "0x4010766")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x408")]
		private static DelegateBridge __Hotfix0_ModifyCostMinSp;

		// Token: 0x04010767 RID: 67431
		[Token(Token = "0x4010767")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x410")]
		private static DelegateBridge __Hotfix0__IsStackable;

		// Token: 0x04010768 RID: 67432
		[Token(Token = "0x4010768")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x418")]
		private static DelegateBridge __Hotfix0_get_isAvailableToShowStackCount;

		// Token: 0x04010769 RID: 67433
		[Token(Token = "0x4010769")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x420")]
		private static DelegateBridge __Hotfix0_get_hideHudSkillStackCount;

		// Token: 0x0401076A RID: 67434
		[Token(Token = "0x401076A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x428")]
		private static DelegateBridge __Hotfix0_ReplaceBeginAnim;

		// Token: 0x0401076B RID: 67435
		[Token(Token = "0x401076B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x430")]
		private static DelegateBridge __Hotfix0_ClearReplaceBeginAnim;

		// Token: 0x0401076C RID: 67436
		[Token(Token = "0x401076C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x438")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02002449 RID: 9289
		[Token(Token = "0x2002449")]
		public abstract class Behaviour : MonoBehaviour, IHotfixable
		{
			// Token: 0x17001ED5 RID: 7893
			// (get) Token: 0x0600EE1F RID: 60959 RVA: 0x00002050 File Offset: 0x00000250
			// (set) Token: 0x0600EE20 RID: 60960 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x17001ED5")]
			private protected BasicSkill skill
			{
				[Token(Token = "0x600EE1F")]
				[Address(RVA = "0x63FD00", Offset = "0x63E900", VA = "0x18063FD00")]
				[CompilerGenerated]
				protected get
				{
					return null;
				}
				[Token(Token = "0x600EE20")]
				[Address(RVA = "0x63FD60", Offset = "0x63E960", VA = "0x18063FD60")]
				[CompilerGenerated]
				private set
				{
				}
			}

			// Token: 0x17001ED6 RID: 7894
			// (get) Token: 0x0600EE21 RID: 60961 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17001ED6")]
			protected Character owner
			{
				[Token(Token = "0x600EE21")]
				[Address(RVA = "0x63FC10", Offset = "0x63E810", VA = "0x18063FC10")]
				get
				{
					return null;
				}
			}

			// Token: 0x17001ED7 RID: 7895
			// (get) Token: 0x0600EE22 RID: 60962 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17001ED7")]
			protected Blackboard blackboard
			{
				[Token(Token = "0x600EE22")]
				[Address(RVA = "0x63FA30", Offset = "0x63E630", VA = "0x18063FA30")]
				get
				{
					return null;
				}
			}

			// Token: 0x17001ED8 RID: 7896
			// (get) Token: 0x0600EE23 RID: 60963 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17001ED8")]
			protected SkillData data
			{
				[Token(Token = "0x600EE23")]
				[Address(RVA = "0x63FB20", Offset = "0x63E720", VA = "0x18063FB20")]
				get
				{
					return null;
				}
			}

			// Token: 0x0600EE24 RID: 60964 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600EE24")]
			[Address(RVA = "0x63F5C0", Offset = "0x63E1C0", VA = "0x18063F5C0", Slot = "4")]
			public virtual void Init(BasicSkill skill)
			{
			}

			// Token: 0x0600EE25 RID: 60965 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600EE25")]
			[Address(RVA = "0x63F4E0", Offset = "0x63E0E0", VA = "0x18063F4E0", Slot = "5")]
			public virtual void AssignData(Blackboard blackboard)
			{
			}

			// Token: 0x0600EE26 RID: 60966 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600EE26")]
			[Address(RVA = "0x63F730", Offset = "0x63E330", VA = "0x18063F730", Slot = "6")]
			public virtual void OnCastSucceed()
			{
			}

			// Token: 0x0600EE27 RID: 60967 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600EE27")]
			[Address(RVA = "0x63F6D0", Offset = "0x63E2D0", VA = "0x18063F6D0", Slot = "7")]
			public virtual void OnCastFailed()
			{
			}

			// Token: 0x0600EE28 RID: 60968 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600EE28")]
			[Address(RVA = "0x63F970", Offset = "0x63E570", VA = "0x18063F970", Slot = "8")]
			public virtual void PostprocessData(Dictionary<string, TalentData> talentMap)
			{
			}

			// Token: 0x0600EE29 RID: 60969 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600EE29")]
			[Address(RVA = "0x63F8B0", Offset = "0x63E4B0", VA = "0x18063F8B0", Slot = "9")]
			public virtual void OnSkillStart()
			{
			}

			// Token: 0x0600EE2A RID: 60970 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600EE2A")]
			[Address(RVA = "0x63F850", Offset = "0x63E450", VA = "0x18063F850", Slot = "10")]
			public virtual void OnSkillEnd()
			{
			}

			// Token: 0x0600EE2B RID: 60971 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600EE2B")]
			[Address(RVA = "0x63F790", Offset = "0x63E390", VA = "0x18063F790", Slot = "11")]
			public virtual void OnInit()
			{
			}

			// Token: 0x0600EE2C RID: 60972 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600EE2C")]
			[Address(RVA = "0x63F7F0", Offset = "0x63E3F0", VA = "0x18063F7F0", Slot = "12")]
			public virtual void OnOwnerFinish()
			{
			}

			// Token: 0x0600EE2D RID: 60973 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600EE2D")]
			[Address(RVA = "0x63F540", Offset = "0x63E140", VA = "0x18063F540", Slot = "13")]
			public virtual void DealAttachInDummy(Deck deck, Deck.Card card)
			{
			}

			// Token: 0x0600EE2E RID: 60974 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600EE2E")]
			[Address(RVA = "0x63F910", Offset = "0x63E510", VA = "0x18063F910", Slot = "14")]
			public virtual void OnTick(FP deltaTime)
			{
			}

			// Token: 0x0600EE2F RID: 60975 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600EE2F")]
			[Address(RVA = "0x63F670", Offset = "0x63E270", VA = "0x18063F670", Slot = "15")]
			public virtual void OnBeforePlayBeginAnim()
			{
			}

			// Token: 0x0600EE30 RID: 60976 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600EE30")]
			[Address(RVA = "0x63F9D0", Offset = "0x63E5D0", VA = "0x18063F9D0")]
			protected Behaviour()
			{
			}

			// Token: 0x0401076E RID: 67438
			[Token(Token = "0x401076E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_get_skill;

			// Token: 0x0401076F RID: 67439
			[Token(Token = "0x401076F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_set_skill;

			// Token: 0x04010770 RID: 67440
			[Token(Token = "0x4010770")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_get_owner;

			// Token: 0x04010771 RID: 67441
			[Token(Token = "0x4010771")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private static DelegateBridge __Hotfix0_get_blackboard;

			// Token: 0x04010772 RID: 67442
			[Token(Token = "0x4010772")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private static DelegateBridge __Hotfix0_get_data;

			// Token: 0x04010773 RID: 67443
			[Token(Token = "0x4010773")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private static DelegateBridge __Hotfix0_Init;

			// Token: 0x04010774 RID: 67444
			[Token(Token = "0x4010774")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private static DelegateBridge __Hotfix0_AssignData;

			// Token: 0x04010775 RID: 67445
			[Token(Token = "0x4010775")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private static DelegateBridge __Hotfix0_OnCastSucceed;

			// Token: 0x04010776 RID: 67446
			[Token(Token = "0x4010776")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			private static DelegateBridge __Hotfix0_OnCastFailed;

			// Token: 0x04010777 RID: 67447
			[Token(Token = "0x4010777")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			private static DelegateBridge __Hotfix0_PostprocessData;

			// Token: 0x04010778 RID: 67448
			[Token(Token = "0x4010778")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			private static DelegateBridge __Hotfix0_OnSkillStart;

			// Token: 0x04010779 RID: 67449
			[Token(Token = "0x4010779")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			private static DelegateBridge __Hotfix0_OnSkillEnd;

			// Token: 0x0401077A RID: 67450
			[Token(Token = "0x401077A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			private static DelegateBridge __Hotfix0_OnInit;

			// Token: 0x0401077B RID: 67451
			[Token(Token = "0x401077B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
			private static DelegateBridge __Hotfix0_OnOwnerFinish;

			// Token: 0x0401077C RID: 67452
			[Token(Token = "0x401077C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
			private static DelegateBridge __Hotfix0_DealAttachInDummy;

			// Token: 0x0401077D RID: 67453
			[Token(Token = "0x401077D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
			private static DelegateBridge __Hotfix0_OnTick;

			// Token: 0x0401077E RID: 67454
			[Token(Token = "0x401077E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
			private static DelegateBridge __Hotfix0_OnBeforePlayBeginAnim;

			// Token: 0x0401077F RID: 67455
			[Token(Token = "0x401077F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}
	}
}

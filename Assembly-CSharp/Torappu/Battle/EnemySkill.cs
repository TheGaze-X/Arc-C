using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Battle
{
	// Token: 0x020021FB RID: 8699
	[Token(Token = "0x20021FB")]
	[RequireComponent(typeof(Ability))]
	public class EnemySkill : MonoBehaviour, Attributes.IAttributesModifier, IEffectSource, IHotfixable
	{
		// Token: 0x17001ADB RID: 6875
		// (get) Token: 0x0600D9B2 RID: 55730 RVA: 0x0004F038 File Offset: 0x0004D238
		// (set) Token: 0x0600D9B3 RID: 55731 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17001ADB")]
		public bool isEnabled
		{
			[Token(Token = "0x600D9B2")]
			[Address(RVA = "0x35E3C00", Offset = "0x35E2800", VA = "0x1835E3C00")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600D9B3")]
			[Address(RVA = "0x35E4330", Offset = "0x35E2F30", VA = "0x1835E4330")]
			set
			{
			}
		}

		// Token: 0x17001ADC RID: 6876
		// (get) Token: 0x0600D9B4 RID: 55732 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17001ADC")]
		public virtual string skillKey
		{
			[Token(Token = "0x600D9B4")]
			[Address(RVA = "0x35E4170", Offset = "0x35E2D70", VA = "0x1835E4170", Slot = "12")]
			get
			{
				return null;
			}
		}

		// Token: 0x17001ADD RID: 6877
		// (get) Token: 0x0600D9B5 RID: 55733 RVA: 0x0004F050 File Offset: 0x0004D250
		[Token(Token = "0x17001ADD")]
		public int priority
		{
			[Token(Token = "0x600D9B5")]
			[Address(RVA = "0x35E3FA0", Offset = "0x35E2BA0", VA = "0x1835E3FA0")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17001ADE RID: 6878
		// (get) Token: 0x0600D9B6 RID: 55734 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600D9B7 RID: 55735 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17001ADE")]
		public Ability ability
		{
			[Token(Token = "0x600D9B6")]
			[Address(RVA = "0x35E3780", Offset = "0x35E2380", VA = "0x1835E3780")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600D9B7")]
			[Address(RVA = "0x35E4230", Offset = "0x35E2E30", VA = "0x1835E4230")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17001ADF RID: 6879
		// (get) Token: 0x0600D9B8 RID: 55736 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17001ADF")]
		public TargetTrigger trigger
		{
			[Token(Token = "0x600D9B8")]
			[Address(RVA = "0x35E41D0", Offset = "0x35E2DD0", VA = "0x1835E41D0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17001AE0 RID: 6880
		// (get) Token: 0x0600D9B9 RID: 55737 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17001AE0")]
		public PeriodicTimer cooldownTimer
		{
			[Token(Token = "0x600D9B9")]
			[Address(RVA = "0x35E3A80", Offset = "0x35E2680", VA = "0x1835E3A80")]
			get
			{
				return null;
			}
		}

		// Token: 0x17001AE1 RID: 6881
		// (get) Token: 0x0600D9BA RID: 55738 RVA: 0x0004F068 File Offset: 0x0004D268
		[Token(Token = "0x17001AE1")]
		public bool isUsedUp
		{
			[Token(Token = "0x600D9BA")]
			[Address(RVA = "0x35E3DC0", Offset = "0x35E29C0", VA = "0x1835E3DC0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17001AE2 RID: 6882
		// (get) Token: 0x0600D9BB RID: 55739 RVA: 0x0004F080 File Offset: 0x0004D280
		[Token(Token = "0x17001AE2")]
		public bool resetMainAbilityCdWhenCastEnd
		{
			[Token(Token = "0x600D9BB")]
			[Address(RVA = "0x35E4110", Offset = "0x35E2D10", VA = "0x1835E4110")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17001AE3 RID: 6883
		// (get) Token: 0x0600D9BC RID: 55740 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600D9BD RID: 55741 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17001AE3")]
		public UnitMode parentMode
		{
			[Token(Token = "0x600D9BC")]
			[Address(RVA = "0x35E3F40", Offset = "0x35E2B40", VA = "0x1835E3F40")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600D9BD")]
			[Address(RVA = "0x35E4430", Offset = "0x35E3030", VA = "0x1835E4430")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17001AE4 RID: 6884
		// (get) Token: 0x0600D9BE RID: 55742 RVA: 0x0004F098 File Offset: 0x0004D298
		[Token(Token = "0x17001AE4")]
		public bool isRoot
		{
			[Token(Token = "0x600D9BE")]
			[Address(RVA = "0x35E3C90", Offset = "0x35E2890", VA = "0x1835E3C90")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17001AE5 RID: 6885
		// (get) Token: 0x0600D9BF RID: 55743 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600D9C0 RID: 55744 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17001AE5")]
		private protected LevelData.EnemyData.ESkillData data
		{
			[Token(Token = "0x600D9BF")]
			[Address(RVA = "0x35E3AE0", Offset = "0x35E26E0", VA = "0x1835E3AE0")]
			[CompilerGenerated]
			protected get
			{
				return null;
			}
			[Token(Token = "0x600D9C0")]
			[Address(RVA = "0x35E42B0", Offset = "0x35E2EB0", VA = "0x1835E42B0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17001AE6 RID: 6886
		// (get) Token: 0x0600D9C1 RID: 55745 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600D9C2 RID: 55746 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17001AE6")]
		private protected Enemy owner
		{
			[Token(Token = "0x600D9C1")]
			[Address(RVA = "0x35E3EE0", Offset = "0x35E2AE0", VA = "0x1835E3EE0")]
			[CompilerGenerated]
			protected get
			{
				return null;
			}
			[Token(Token = "0x600D9C2")]
			[Address(RVA = "0x35E43B0", Offset = "0x35E2FB0", VA = "0x1835E43B0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17001AE7 RID: 6887
		// (get) Token: 0x0600D9C3 RID: 55747 RVA: 0x0004F0B0 File Offset: 0x0004D2B0
		[Token(Token = "0x17001AE7")]
		protected virtual bool recoverSpWhenAffecting
		{
			[Token(Token = "0x600D9C3")]
			[Address(RVA = "0x35E4050", Offset = "0x35E2C50", VA = "0x1835E4050", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17001AE8 RID: 6888
		// (get) Token: 0x0600D9C4 RID: 55748 RVA: 0x0004F0C8 File Offset: 0x0004D2C8
		[Token(Token = "0x17001AE8")]
		protected virtual bool immuneStunWhenAffecting
		{
			[Token(Token = "0x600D9C4")]
			[Address(RVA = "0x35E3BA0", Offset = "0x35E27A0", VA = "0x1835E3BA0", Slot = "14")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17001AE9 RID: 6889
		// (get) Token: 0x0600D9C5 RID: 55749 RVA: 0x0004F0E0 File Offset: 0x0004D2E0
		[Token(Token = "0x17001AE9")]
		private bool ownerSkillActivatable
		{
			[Token(Token = "0x600D9C5")]
			[Address(RVA = "0x35E3E30", Offset = "0x35E2A30", VA = "0x1835E3E30")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17001AEA RID: 6890
		// (get) Token: 0x0600D9C6 RID: 55750 RVA: 0x0004F0F8 File Offset: 0x0004D2F8
		// (set) Token: 0x0600D9C7 RID: 55751 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17001AEA")]
		protected bool registeredAsModifier
		{
			[Token(Token = "0x600D9C6")]
			[Address(RVA = "0x35E40B0", Offset = "0x35E2CB0", VA = "0x1835E40B0")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600D9C7")]
			[Address(RVA = "0x35E44B0", Offset = "0x35E30B0", VA = "0x1835E44B0")]
			set
			{
			}
		}

		// Token: 0x17001AEB RID: 6891
		// (get) Token: 0x0600D9C8 RID: 55752 RVA: 0x0004F110 File Offset: 0x0004D310
		[Token(Token = "0x17001AEB")]
		public bool isSpCostSkill
		{
			[Token(Token = "0x600D9C8")]
			[Address(RVA = "0x35E3D60", Offset = "0x35E2960", VA = "0x1835E3D60")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17001AEC RID: 6892
		// (get) Token: 0x0600D9C9 RID: 55753 RVA: 0x0004F128 File Offset: 0x0004D328
		[Token(Token = "0x17001AEC")]
		protected Ability.FamilyGroup familyGroup
		{
			[Token(Token = "0x600D9C9")]
			[Address(RVA = "0x35E3B40", Offset = "0x35E2740", VA = "0x1835E3B40")]
			get
			{
				return Ability.FamilyGroup.ATTACK;
			}
		}

		// Token: 0x17001AED RID: 6893
		// (get) Token: 0x0600D9CA RID: 55754 RVA: 0x0004F140 File Offset: 0x0004D340
		[Token(Token = "0x17001AED")]
		public long attributeMask
		{
			[Token(Token = "0x600D9CA")]
			[Address(RVA = "0x35E3A20", Offset = "0x35E2620", VA = "0x1835E3A20", Slot = "4")]
			get
			{
				return 0L;
			}
		}

		// Token: 0x17001AEE RID: 6894
		// (get) Token: 0x0600D9CB RID: 55755 RVA: 0x0004F158 File Offset: 0x0004D358
		[Token(Token = "0x17001AEE")]
		public long abnormalFlagMask
		{
			[Token(Token = "0x600D9CB")]
			[Address(RVA = "0x35E3900", Offset = "0x35E2500", VA = "0x1835E3900", Slot = "5")]
			get
			{
				return 0L;
			}
		}

		// Token: 0x17001AEF RID: 6895
		// (get) Token: 0x0600D9CC RID: 55756 RVA: 0x0004F170 File Offset: 0x0004D370
		[Token(Token = "0x17001AEF")]
		public long abnormalImmuneMask
		{
			[Token(Token = "0x600D9CC")]
			[Address(RVA = "0x35E3990", Offset = "0x35E2590", VA = "0x1835E3990", Slot = "6")]
			get
			{
				return 0L;
			}
		}

		// Token: 0x17001AF0 RID: 6896
		// (get) Token: 0x0600D9CD RID: 55757 RVA: 0x0004F188 File Offset: 0x0004D388
		[Token(Token = "0x17001AF0")]
		public long abnormalAntiMask
		{
			[Token(Token = "0x600D9CD")]
			[Address(RVA = "0x35E37E0", Offset = "0x35E23E0", VA = "0x1835E37E0", Slot = "7")]
			get
			{
				return 0L;
			}
		}

		// Token: 0x17001AF1 RID: 6897
		// (get) Token: 0x0600D9CE RID: 55758 RVA: 0x0004F1A0 File Offset: 0x0004D3A0
		[Token(Token = "0x17001AF1")]
		public long abnormalComboMask
		{
			[Token(Token = "0x600D9CE")]
			[Address(RVA = "0x35E38A0", Offset = "0x35E24A0", VA = "0x1835E38A0", Slot = "8")]
			get
			{
				return 0L;
			}
		}

		// Token: 0x17001AF2 RID: 6898
		// (get) Token: 0x0600D9CF RID: 55759 RVA: 0x0004F1B8 File Offset: 0x0004D3B8
		[Token(Token = "0x17001AF2")]
		public long abnormalComboImmuneMask
		{
			[Token(Token = "0x600D9CF")]
			[Address(RVA = "0x35E3840", Offset = "0x35E2440", VA = "0x1835E3840", Slot = "9")]
			get
			{
				return 0L;
			}
		}

		// Token: 0x0600D9D0 RID: 55760 RVA: 0x0004F1D0 File Offset: 0x0004D3D0
		[Token(Token = "0x600D9D0")]
		[Address(RVA = "0x35E2580", Offset = "0x35E1180", VA = "0x1835E2580", Slot = "10")]
		public bool GetValue(AttributeType attribute, out FP addition, out FP multiplier, out FP finalAddition, out FP finalScaler)
		{
			return default(bool);
		}

		// Token: 0x0600D9D1 RID: 55761 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600D9D1")]
		[Address(RVA = "0x35E1230", Offset = "0x35DFE30", VA = "0x1835E1230", Slot = "15")]
		public virtual void AssignData(LevelData.EnemyData.ESkillData data, Enemy owner)
		{
		}

		// Token: 0x0600D9D2 RID: 55762 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600D9D2")]
		[Address(RVA = "0x35E2660", Offset = "0x35E1260", VA = "0x1835E2660")]
		public void Init()
		{
		}

		// Token: 0x0600D9D3 RID: 55763 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600D9D3")]
		[Address(RVA = "0x35E17F0", Offset = "0x35E03F0", VA = "0x1835E17F0")]
		public void Attach()
		{
		}

		// Token: 0x0600D9D4 RID: 55764 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600D9D4")]
		[Address(RVA = "0x35E22B0", Offset = "0x35E0EB0", VA = "0x1835E22B0")]
		public void Detach()
		{
		}

		// Token: 0x0600D9D5 RID: 55765 RVA: 0x0004F1E8 File Offset: 0x0004D3E8
		[Token(Token = "0x600D9D5")]
		[Address(RVA = "0x35E1BB0", Offset = "0x35E07B0", VA = "0x1835E1BB0")]
		public bool CastToTarget(Entity target, Ability mainAbility, [Optional] Ability.FinishCallbackDelegate finishCb, bool firstAttack = true)
		{
			return default(bool);
		}

		// Token: 0x0600D9D6 RID: 55766 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600D9D6")]
		[Address(RVA = "0x35E2AA0", Offset = "0x35E16A0", VA = "0x1835E2AA0", Slot = "16")]
		public virtual void ResetSkillCooldownIfNeeded()
		{
		}

		// Token: 0x0600D9D7 RID: 55767 RVA: 0x0004F200 File Offset: 0x0004D400
		[Token(Token = "0x600D9D7")]
		[Address(RVA = "0x35E20B0", Offset = "0x35E0CB0", VA = "0x1835E20B0")]
		public bool CheckFamilyMask(Ability.FamilyGroup familyGroup)
		{
			return default(bool);
		}

		// Token: 0x0600D9D8 RID: 55768 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600D9D8")]
		[Address(RVA = "0x35E2C90", Offset = "0x35E1890", VA = "0x1835E2C90")]
		public void SetParentMode(UnitMode parentMode)
		{
		}

		// Token: 0x0600D9D9 RID: 55769 RVA: 0x0004F218 File Offset: 0x0004D418
		[Token(Token = "0x600D9D9")]
		[Address(RVA = "0x35E2130", Offset = "0x35E0D30", VA = "0x1835E2130", Slot = "17")]
		public virtual bool CheckTrigger(bool allowNoTrigger, bool forceRefresh = false)
		{
			return default(bool);
		}

		// Token: 0x0600D9DA RID: 55770 RVA: 0x0004F230 File Offset: 0x0004D430
		[Token(Token = "0x600D9DA")]
		[Address(RVA = "0x35E1E40", Offset = "0x35E0A40", VA = "0x1835E1E40", Slot = "18")]
		public virtual bool CheckAvailable()
		{
			return default(bool);
		}

		// Token: 0x0600D9DB RID: 55771 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600D9DB")]
		[Address(RVA = "0x35E2470", Offset = "0x35E1070", VA = "0x1835E2470", Slot = "11")]
		public void GatherEffects(List<string> effects)
		{
		}

		// Token: 0x0600D9DC RID: 55772 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600D9DC")]
		[Address(RVA = "0x35E2D40", Offset = "0x35E1940", VA = "0x1835E2D40")]
		public void Tick(FP deltaTime)
		{
		}

		// Token: 0x0600D9DD RID: 55773 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600D9DD")]
		[Address(RVA = "0x35E29A0", Offset = "0x35E15A0", VA = "0x1835E29A0", Slot = "19")]
		protected virtual void OnTick(FP deltaTime)
		{
		}

		// Token: 0x0600D9DE RID: 55774 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600D9DE")]
		[Address(RVA = "0x35E2940", Offset = "0x35E1540", VA = "0x1835E2940")]
		protected void OnCastSucceed()
		{
		}

		// Token: 0x0600D9DF RID: 55775 RVA: 0x0004F248 File Offset: 0x0004D448
		[Token(Token = "0x600D9DF")]
		[Address(RVA = "0x35E2BC0", Offset = "0x35E17C0", VA = "0x1835E2BC0")]
		protected bool SetEnabledInternal(bool value, bool force)
		{
			return default(bool);
		}

		// Token: 0x0600D9E0 RID: 55776 RVA: 0x0004F260 File Offset: 0x0004D460
		[Token(Token = "0x600D9E0")]
		[Address(RVA = "0x35E2EF0", Offset = "0x35E1AF0", VA = "0x1835E2EF0")]
		protected bool TryReduceSp(int spCost)
		{
			return default(bool);
		}

		// Token: 0x0600D9E1 RID: 55777 RVA: 0x0004F278 File Offset: 0x0004D478
		[Token(Token = "0x600D9E1")]
		[Address(RVA = "0x35E3180", Offset = "0x35E1D80", VA = "0x1835E3180")]
		private static float _GetRangeRadius(LevelData.EnemyData.ESkillData data, Enemy owner)
		{
			return 0f;
		}

		// Token: 0x0600D9E2 RID: 55778 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600D9E2")]
		[Address(RVA = "0x35E3470", Offset = "0x35E2070", VA = "0x1835E3470")]
		private void _OnCastStart()
		{
		}

		// Token: 0x0600D9E3 RID: 55779 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600D9E3")]
		[Address(RVA = "0x35E3260", Offset = "0x35E1E60", VA = "0x1835E3260")]
		private void _OnCastFinish(Ability ability, Ability.FinishReason reason, bool firstAttack)
		{
		}

		// Token: 0x0600D9E4 RID: 55780 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600D9E4")]
		[Address(RVA = "0x35E3560", Offset = "0x35E2160", VA = "0x1835E3560")]
		private void _UpdateRegisterAsModifier(bool value, bool force)
		{
		}

		// Token: 0x0600D9E5 RID: 55781 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600D9E5")]
		[Address(RVA = "0x35E1A10", Offset = "0x35E0610", VA = "0x1835E1A10")]
		private void Awake()
		{
		}

		// Token: 0x0600D9E6 RID: 55782 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600D9E6")]
		[Address(RVA = "0x35E36C0", Offset = "0x35E22C0", VA = "0x1835E36C0")]
		public EnemySkill()
		{
		}

		// Token: 0x0400EAEF RID: 60143
		[Token(Token = "0x400EAEF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Ability.FamilyGroupMask _familyMask;

		// Token: 0x0400EAF0 RID: 60144
		[Token(Token = "0x400EAF0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private TargetTrigger _trigger;

		// Token: 0x0400EAF1 RID: 60145
		[Token(Token = "0x400EAF1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private bool _checkParentActive;

		// Token: 0x0400EAF2 RID: 60146
		[Token(Token = "0x400EAF2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[SerializeField]
		private int _maxTriggerTime;

		// Token: 0x0400EAF3 RID: 60147
		[Token(Token = "0x400EAF3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		private bool _resetMainAbilityCdWhenCastEnd;

		// Token: 0x0400EAF4 RID: 60148
		[Token(Token = "0x400EAF4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x31")]
		[SerializeField]
		private bool _resetCdWaitFirstPeriod;

		// Token: 0x0400EAF5 RID: 60149
		[Token(Token = "0x400EAF5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[SerializeField]
		private int _overwriteInitCooldown;

		// Token: 0x0400EAF6 RID: 60150
		[Token(Token = "0x400EAF6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[SerializeField]
		private bool _ignoreSilence;

		// Token: 0x0400EAF7 RID: 60151
		[Token(Token = "0x400EAF7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x39")]
		[SerializeField]
		private bool _immuneStunWhenAffecting;

		// Token: 0x0400EAF8 RID: 60152
		[Token(Token = "0x400EAF8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3A")]
		[SerializeField]
		private bool _addEnemyIdToSignalId;

		// Token: 0x0400EAF9 RID: 60153
		[Token(Token = "0x400EAF9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3B")]
		[SerializeField]
		private bool _castLikeAttack;

		// Token: 0x0400EAFA RID: 60154
		[Token(Token = "0x400EAFA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		private int m_spCost;

		// Token: 0x0400EAFB RID: 60155
		[Token(Token = "0x400EAFB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private int m_triggerCnt;

		// Token: 0x0400EAFC RID: 60156
		[Token(Token = "0x400EAFC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		protected PeriodicTimer m_cooldownTimer;

		// Token: 0x0400EAFD RID: 60157
		[Token(Token = "0x400EAFD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private Ability.FinishCallbackDelegate m_finishCb;

		// Token: 0x0400EAFE RID: 60158
		[Token(Token = "0x400EAFE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Ability m_mainAbility;

		// Token: 0x0400EAFF RID: 60159
		[Token(Token = "0x400EAFF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private bool m_registeredAsModifier;

		// Token: 0x0400EB00 RID: 60160
		[Token(Token = "0x400EB00")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		protected EnemySkill.Behaviour[] m_behaviours;

		// Token: 0x0400EB05 RID: 60165
		[Token(Token = "0x400EB05")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_isEnabled;

		// Token: 0x0400EB06 RID: 60166
		[Token(Token = "0x400EB06")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_isEnabled;

		// Token: 0x0400EB07 RID: 60167
		[Token(Token = "0x400EB07")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_skillKey;

		// Token: 0x0400EB08 RID: 60168
		[Token(Token = "0x400EB08")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_get_priority;

		// Token: 0x0400EB09 RID: 60169
		[Token(Token = "0x400EB09")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_get_ability;

		// Token: 0x0400EB0A RID: 60170
		[Token(Token = "0x400EB0A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_set_ability;

		// Token: 0x0400EB0B RID: 60171
		[Token(Token = "0x400EB0B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_get_trigger;

		// Token: 0x0400EB0C RID: 60172
		[Token(Token = "0x400EB0C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_get_cooldownTimer;

		// Token: 0x0400EB0D RID: 60173
		[Token(Token = "0x400EB0D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_get_isUsedUp;

		// Token: 0x0400EB0E RID: 60174
		[Token(Token = "0x400EB0E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_get_resetMainAbilityCdWhenCastEnd;

		// Token: 0x0400EB0F RID: 60175
		[Token(Token = "0x400EB0F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_get_parentMode;

		// Token: 0x0400EB10 RID: 60176
		[Token(Token = "0x400EB10")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_set_parentMode;

		// Token: 0x0400EB11 RID: 60177
		[Token(Token = "0x400EB11")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0_get_isRoot;

		// Token: 0x0400EB12 RID: 60178
		[Token(Token = "0x400EB12")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0_get_data;

		// Token: 0x0400EB13 RID: 60179
		[Token(Token = "0x400EB13")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0_set_data;

		// Token: 0x0400EB14 RID: 60180
		[Token(Token = "0x400EB14")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0_get_owner;

		// Token: 0x0400EB15 RID: 60181
		[Token(Token = "0x400EB15")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private static DelegateBridge __Hotfix0_set_owner;

		// Token: 0x0400EB16 RID: 60182
		[Token(Token = "0x400EB16")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private static DelegateBridge __Hotfix0_get_recoverSpWhenAffecting;

		// Token: 0x0400EB17 RID: 60183
		[Token(Token = "0x400EB17")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private static DelegateBridge __Hotfix0_get_immuneStunWhenAffecting;

		// Token: 0x0400EB18 RID: 60184
		[Token(Token = "0x400EB18")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private static DelegateBridge __Hotfix0_get_ownerSkillActivatable;

		// Token: 0x0400EB19 RID: 60185
		[Token(Token = "0x400EB19")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private static DelegateBridge __Hotfix0_get_registeredAsModifier;

		// Token: 0x0400EB1A RID: 60186
		[Token(Token = "0x400EB1A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private static DelegateBridge __Hotfix0_set_registeredAsModifier;

		// Token: 0x0400EB1B RID: 60187
		[Token(Token = "0x400EB1B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private static DelegateBridge __Hotfix0_get_isSpCostSkill;

		// Token: 0x0400EB1C RID: 60188
		[Token(Token = "0x400EB1C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private static DelegateBridge __Hotfix0_get_familyGroup;

		// Token: 0x0400EB1D RID: 60189
		[Token(Token = "0x400EB1D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private static DelegateBridge __Hotfix0_get_attributeMask;

		// Token: 0x0400EB1E RID: 60190
		[Token(Token = "0x400EB1E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		private static DelegateBridge __Hotfix0_get_abnormalFlagMask;

		// Token: 0x0400EB1F RID: 60191
		[Token(Token = "0x400EB1F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		private static DelegateBridge __Hotfix0_get_abnormalImmuneMask;

		// Token: 0x0400EB20 RID: 60192
		[Token(Token = "0x400EB20")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		private static DelegateBridge __Hotfix0_get_abnormalAntiMask;

		// Token: 0x0400EB21 RID: 60193
		[Token(Token = "0x400EB21")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		private static DelegateBridge __Hotfix0_get_abnormalComboMask;

		// Token: 0x0400EB22 RID: 60194
		[Token(Token = "0x400EB22")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		private static DelegateBridge __Hotfix0_get_abnormalComboImmuneMask;

		// Token: 0x0400EB23 RID: 60195
		[Token(Token = "0x400EB23")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		private static DelegateBridge __Hotfix0_GetValue;

		// Token: 0x0400EB24 RID: 60196
		[Token(Token = "0x400EB24")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		private static DelegateBridge __Hotfix0_AssignData;

		// Token: 0x0400EB25 RID: 60197
		[Token(Token = "0x400EB25")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
		private static DelegateBridge __Hotfix0_Init;

		// Token: 0x0400EB26 RID: 60198
		[Token(Token = "0x400EB26")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
		private static DelegateBridge __Hotfix0_Attach;

		// Token: 0x0400EB27 RID: 60199
		[Token(Token = "0x400EB27")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
		private static DelegateBridge __Hotfix0_Detach;

		// Token: 0x0400EB28 RID: 60200
		[Token(Token = "0x400EB28")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
		private static DelegateBridge __Hotfix0_CastToTarget;

		// Token: 0x0400EB29 RID: 60201
		[Token(Token = "0x400EB29")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
		private static DelegateBridge __Hotfix0_ResetSkillCooldownIfNeeded;

		// Token: 0x0400EB2A RID: 60202
		[Token(Token = "0x400EB2A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
		private static DelegateBridge __Hotfix0_CheckFamilyMask;

		// Token: 0x0400EB2B RID: 60203
		[Token(Token = "0x400EB2B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
		private static DelegateBridge __Hotfix0_SetParentMode;

		// Token: 0x0400EB2C RID: 60204
		[Token(Token = "0x400EB2C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
		private static DelegateBridge __Hotfix0_CheckTrigger;

		// Token: 0x0400EB2D RID: 60205
		[Token(Token = "0x400EB2D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x140")]
		private static DelegateBridge __Hotfix0_CheckAvailable;

		// Token: 0x0400EB2E RID: 60206
		[Token(Token = "0x400EB2E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x148")]
		private static DelegateBridge __Hotfix0_GatherEffects;

		// Token: 0x0400EB2F RID: 60207
		[Token(Token = "0x400EB2F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x150")]
		private static DelegateBridge __Hotfix0_Tick;

		// Token: 0x0400EB30 RID: 60208
		[Token(Token = "0x400EB30")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x158")]
		private static DelegateBridge __Hotfix0_OnTick;

		// Token: 0x0400EB31 RID: 60209
		[Token(Token = "0x400EB31")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x160")]
		private static DelegateBridge __Hotfix0_OnCastSucceed;

		// Token: 0x0400EB32 RID: 60210
		[Token(Token = "0x400EB32")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x168")]
		private static DelegateBridge __Hotfix0_SetEnabledInternal;

		// Token: 0x0400EB33 RID: 60211
		[Token(Token = "0x400EB33")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x170")]
		private static DelegateBridge __Hotfix0_TryReduceSp;

		// Token: 0x0400EB34 RID: 60212
		[Token(Token = "0x400EB34")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x178")]
		private static DelegateBridge __Hotfix0__GetRangeRadius;

		// Token: 0x0400EB35 RID: 60213
		[Token(Token = "0x400EB35")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x180")]
		private static DelegateBridge __Hotfix0__OnCastStart;

		// Token: 0x0400EB36 RID: 60214
		[Token(Token = "0x400EB36")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x188")]
		private static DelegateBridge __Hotfix0__OnCastFinish;

		// Token: 0x0400EB37 RID: 60215
		[Token(Token = "0x400EB37")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x190")]
		private static DelegateBridge __Hotfix0__UpdateRegisterAsModifier;

		// Token: 0x0400EB38 RID: 60216
		[Token(Token = "0x400EB38")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x198")]
		private static DelegateBridge __Hotfix0_Awake;

		// Token: 0x0400EB39 RID: 60217
		[Token(Token = "0x400EB39")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1A0")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x020021FC RID: 8700
		[Token(Token = "0x20021FC")]
		public class Behaviour : MonoBehaviour, IHotfixable
		{
			// Token: 0x17001AF3 RID: 6899
			// (get) Token: 0x0600D9E7 RID: 55783 RVA: 0x00002050 File Offset: 0x00000250
			// (set) Token: 0x0600D9E8 RID: 55784 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x17001AF3")]
			private protected EnemySkill skill
			{
				[Token(Token = "0x600D9E7")]
				[Address(RVA = "0x35F2300", Offset = "0x35F0F00", VA = "0x1835F2300")]
				[CompilerGenerated]
				protected get
				{
					return null;
				}
				[Token(Token = "0x600D9E8")]
				[Address(RVA = "0x35F2360", Offset = "0x35F0F60", VA = "0x1835F2360")]
				[CompilerGenerated]
				private set
				{
				}
			}

			// Token: 0x17001AF4 RID: 6900
			// (get) Token: 0x0600D9E9 RID: 55785 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17001AF4")]
			protected Enemy owner
			{
				[Token(Token = "0x600D9E9")]
				[Address(RVA = "0x35F2250", Offset = "0x35F0E50", VA = "0x1835F2250")]
				get
				{
					return null;
				}
			}

			// Token: 0x17001AF5 RID: 6901
			// (get) Token: 0x0600D9EA RID: 55786 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17001AF5")]
			protected LevelData.EnemyData.ESkillData data
			{
				[Token(Token = "0x600D9EA")]
				[Address(RVA = "0x35F21A0", Offset = "0x35F0DA0", VA = "0x1835F21A0")]
				get
				{
					return null;
				}
			}

			// Token: 0x17001AF6 RID: 6902
			// (get) Token: 0x0600D9EB RID: 55787 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17001AF6")]
			protected Ability ability
			{
				[Token(Token = "0x600D9EB")]
				[Address(RVA = "0x35F20F0", Offset = "0x35F0CF0", VA = "0x1835F20F0")]
				get
				{
					return null;
				}
			}

			// Token: 0x0600D9EC RID: 55788 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600D9EC")]
			[Address(RVA = "0x35F1E00", Offset = "0x35F0A00", VA = "0x1835F1E00", Slot = "4")]
			public virtual void Init(EnemySkill skill)
			{
			}

			// Token: 0x0600D9ED RID: 55789 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600D9ED")]
			[Address(RVA = "0x35F1DA0", Offset = "0x35F09A0", VA = "0x1835F1DA0", Slot = "5")]
			public virtual void AssignData(Blackboard blackboard)
			{
			}

			// Token: 0x0600D9EE RID: 55790 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600D9EE")]
			[Address(RVA = "0x35F1EB0", Offset = "0x35F0AB0", VA = "0x1835F1EB0", Slot = "6")]
			public virtual void OnAttach()
			{
			}

			// Token: 0x0600D9EF RID: 55791 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600D9EF")]
			[Address(RVA = "0x35F1FD0", Offset = "0x35F0BD0", VA = "0x1835F1FD0", Slot = "7")]
			public virtual void OnDetach()
			{
			}

			// Token: 0x0600D9F0 RID: 55792 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600D9F0")]
			[Address(RVA = "0x35F2030", Offset = "0x35F0C30", VA = "0x1835F2030", Slot = "8")]
			public virtual void OnTick(FP deltaTime)
			{
			}

			// Token: 0x0600D9F1 RID: 55793 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600D9F1")]
			[Address(RVA = "0x35F1F70", Offset = "0x35F0B70", VA = "0x1835F1F70", Slot = "9")]
			public virtual void OnCastStart()
			{
			}

			// Token: 0x0600D9F2 RID: 55794 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600D9F2")]
			[Address(RVA = "0x35F1F10", Offset = "0x35F0B10", VA = "0x1835F1F10", Slot = "10")]
			public virtual void OnCastFinish(Ability.FinishReason reason)
			{
			}

			// Token: 0x0600D9F3 RID: 55795 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600D9F3")]
			[Address(RVA = "0x35F2090", Offset = "0x35F0C90", VA = "0x1835F2090")]
			public Behaviour()
			{
			}

			// Token: 0x0400EB3B RID: 60219
			[Token(Token = "0x400EB3B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_get_skill;

			// Token: 0x0400EB3C RID: 60220
			[Token(Token = "0x400EB3C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_set_skill;

			// Token: 0x0400EB3D RID: 60221
			[Token(Token = "0x400EB3D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_get_owner;

			// Token: 0x0400EB3E RID: 60222
			[Token(Token = "0x400EB3E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private static DelegateBridge __Hotfix0_get_data;

			// Token: 0x0400EB3F RID: 60223
			[Token(Token = "0x400EB3F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private static DelegateBridge __Hotfix0_get_ability;

			// Token: 0x0400EB40 RID: 60224
			[Token(Token = "0x400EB40")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private static DelegateBridge __Hotfix0_Init;

			// Token: 0x0400EB41 RID: 60225
			[Token(Token = "0x400EB41")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private static DelegateBridge __Hotfix0_AssignData;

			// Token: 0x0400EB42 RID: 60226
			[Token(Token = "0x400EB42")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private static DelegateBridge __Hotfix0_OnAttach;

			// Token: 0x0400EB43 RID: 60227
			[Token(Token = "0x400EB43")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			private static DelegateBridge __Hotfix0_OnDetach;

			// Token: 0x0400EB44 RID: 60228
			[Token(Token = "0x400EB44")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			private static DelegateBridge __Hotfix0_OnTick;

			// Token: 0x0400EB45 RID: 60229
			[Token(Token = "0x400EB45")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			private static DelegateBridge __Hotfix0_OnCastStart;

			// Token: 0x0400EB46 RID: 60230
			[Token(Token = "0x400EB46")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			private static DelegateBridge __Hotfix0_OnCastFinish;

			// Token: 0x0400EB47 RID: 60231
			[Token(Token = "0x400EB47")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}
	}
}

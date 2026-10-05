using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Battle
{
	// Token: 0x0200246B RID: 9323
	[Token(Token = "0x200246B")]
	[RequireComponent(typeof(Ability))]
	public abstract class BasicTalent : MonoBehaviour, IHotfixable, IBuffSource, IEffectSource
	{
		// Token: 0x17001F1B RID: 7963
		// (get) Token: 0x0600EFE1 RID: 61409 RVA: 0x00058548 File Offset: 0x00056748
		[Token(Token = "0x17001F1B")]
		public bool isValid
		{
			[Token(Token = "0x600EFE1")]
			[Address(RVA = "0x66CA30", Offset = "0x66B630", VA = "0x18066CA30")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17001F1C RID: 7964
		// (get) Token: 0x0600EFE2 RID: 61410 RVA: 0x00058560 File Offset: 0x00056760
		[Token(Token = "0x17001F1C")]
		public virtual bool isAttached
		{
			[Token(Token = "0x600EFE2")]
			[Address(RVA = "0x66C800", Offset = "0x66B400", VA = "0x18066C800", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17001F1D RID: 7965
		// (get) Token: 0x0600EFE3 RID: 61411 RVA: 0x00058578 File Offset: 0x00056778
		[Token(Token = "0x17001F1D")]
		public virtual bool attachInDummy
		{
			[Token(Token = "0x600EFE3")]
			[Address(RVA = "0x66C630", Offset = "0x66B230", VA = "0x18066C630", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17001F1E RID: 7966
		// (get) Token: 0x0600EFE4 RID: 61412 RVA: 0x00058590 File Offset: 0x00056790
		[Token(Token = "0x17001F1E")]
		public virtual bool affectInDeck
		{
			[Token(Token = "0x600EFE4")]
			[Address(RVA = "0x66C3F0", Offset = "0x66AFF0", VA = "0x18066C3F0", Slot = "8")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17001F1F RID: 7967
		// (get) Token: 0x0600EFE5 RID: 61413 RVA: 0x000585A8 File Offset: 0x000567A8
		[Token(Token = "0x17001F1F")]
		public virtual bool overrideDefaultRangeId
		{
			[Token(Token = "0x600EFE5")]
			[Address(RVA = "0x66CAE0", Offset = "0x66B6E0", VA = "0x18066CAE0", Slot = "9")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17001F20 RID: 7968
		// (get) Token: 0x0600EFE6 RID: 61414 RVA: 0x000585C0 File Offset: 0x000567C0
		[Token(Token = "0x17001F20")]
		public virtual bool applyTalentScale
		{
			[Token(Token = "0x600EFE6")]
			[Address(RVA = "0x66C5D0", Offset = "0x66B1D0", VA = "0x18066C5D0", Slot = "10")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17001F21 RID: 7969
		// (get) Token: 0x0600EFE7 RID: 61415 RVA: 0x000585D8 File Offset: 0x000567D8
		[Token(Token = "0x17001F21")]
		public virtual bool scaleCertainKeyFlag
		{
			[Token(Token = "0x600EFE7")]
			[Address(RVA = "0x66CD10", Offset = "0x66B910", VA = "0x18066CD10", Slot = "11")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17001F22 RID: 7970
		// (get) Token: 0x0600EFE8 RID: 61416 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17001F22")]
		protected virtual string[] scaleCertainKeyList
		{
			[Token(Token = "0x600EFE8")]
			[Address(RVA = "0x66CD70", Offset = "0x66B970", VA = "0x18066CD70", Slot = "12")]
			get
			{
				return null;
			}
		}

		// Token: 0x17001F23 RID: 7971
		// (get) Token: 0x0600EFE9 RID: 61417 RVA: 0x000585F0 File Offset: 0x000567F0
		[Token(Token = "0x17001F23")]
		public virtual bool applyTalentRangeBySkill
		{
			[Token(Token = "0x600EFE9")]
			[Address(RVA = "0x66C570", Offset = "0x66B170", VA = "0x18066C570", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17001F24 RID: 7972
		// (get) Token: 0x0600EFEA RID: 61418 RVA: 0x00058608 File Offset: 0x00056808
		[Token(Token = "0x17001F24")]
		public virtual bool applyBlackboardBySkill
		{
			[Token(Token = "0x600EFEA")]
			[Address(RVA = "0x66C4B0", Offset = "0x66B0B0", VA = "0x18066C4B0", Slot = "14")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17001F25 RID: 7973
		// (get) Token: 0x0600EFEB RID: 61419 RVA: 0x00058620 File Offset: 0x00056820
		[Token(Token = "0x17001F25")]
		public virtual bool applyStrBlackboardBySkill
		{
			[Token(Token = "0x600EFEB")]
			[Address(RVA = "0x66C510", Offset = "0x66B110", VA = "0x18066C510", Slot = "15")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17001F26 RID: 7974
		// (get) Token: 0x0600EFEC RID: 61420 RVA: 0x00058638 File Offset: 0x00056838
		[Token(Token = "0x17001F26")]
		public virtual bool writeRangeIdToProjectileBlackboard
		{
			[Token(Token = "0x600EFEC")]
			[Address(RVA = "0x66CED0", Offset = "0x66BAD0", VA = "0x18066CED0", Slot = "16")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17001F27 RID: 7975
		// (get) Token: 0x0600EFED RID: 61421 RVA: 0x00058650 File Offset: 0x00056850
		[Token(Token = "0x17001F27")]
		public bool isRootTalent
		{
			[Token(Token = "0x600EFED")]
			[Address(RVA = "0x66C870", Offset = "0x66B470", VA = "0x18066C870")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17001F28 RID: 7976
		// (get) Token: 0x0600EFEE RID: 61422 RVA: 0x00058668 File Offset: 0x00056868
		[Token(Token = "0x17001F28")]
		public virtual bool affectWhenNotRootTalent
		{
			[Token(Token = "0x600EFEE")]
			[Address(RVA = "0x66C450", Offset = "0x66B050", VA = "0x18066C450", Slot = "17")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17001F29 RID: 7977
		// (get) Token: 0x0600EFEF RID: 61423 RVA: 0x00058680 File Offset: 0x00056880
		[Token(Token = "0x17001F29")]
		public bool isValidRootTalent
		{
			[Token(Token = "0x600EFEF")]
			[Address(RVA = "0x66C940", Offset = "0x66B540", VA = "0x18066C940")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17001F2A RID: 7978
		// (get) Token: 0x0600EFF0 RID: 61424 RVA: 0x00058698 File Offset: 0x00056898
		[Token(Token = "0x17001F2A")]
		public virtual int defaultModeIndex
		{
			[Token(Token = "0x600EFF0")]
			[Address(RVA = "0x66C6F0", Offset = "0x66B2F0", VA = "0x18066C6F0", Slot = "18")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17001F2B RID: 7979
		// (get) Token: 0x0600EFF1 RID: 61425 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17001F2B")]
		public virtual string talentKey
		{
			[Token(Token = "0x600EFF1")]
			[Address(RVA = "0x66CDD0", Offset = "0x66B9D0", VA = "0x18066CDD0", Slot = "19")]
			get
			{
				return null;
			}
		}

		// Token: 0x17001F2C RID: 7980
		// (get) Token: 0x0600EFF2 RID: 61426 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17001F2C")]
		protected string overwriteTalentKey
		{
			[Token(Token = "0x600EFF2")]
			[Address(RVA = "0x66CB40", Offset = "0x66B740", VA = "0x18066CB40")]
			get
			{
				return null;
			}
		}

		// Token: 0x17001F2D RID: 7981
		// (get) Token: 0x0600EFF3 RID: 61427 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17001F2D")]
		public string rangeId
		{
			[Token(Token = "0x600EFF3")]
			[Address(RVA = "0x66CC60", Offset = "0x66B860", VA = "0x18066CC60")]
			get
			{
				return null;
			}
		}

		// Token: 0x17001F2E RID: 7982
		// (get) Token: 0x0600EFF4 RID: 61428 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600EFF5 RID: 61429 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17001F2E")]
		public UnitMode parentMode
		{
			[Token(Token = "0x600EFF4")]
			[Address(RVA = "0x66CC00", Offset = "0x66B800", VA = "0x18066CC00")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600EFF5")]
			[Address(RVA = "0x66D030", Offset = "0x66BC30", VA = "0x18066D030")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17001F2F RID: 7983
		// (get) Token: 0x0600EFF6 RID: 61430 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600EFF7 RID: 61431 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17001F2F")]
		private protected TalentData data
		{
			[Token(Token = "0x600EFF6")]
			[Address(RVA = "0x66C690", Offset = "0x66B290", VA = "0x18066C690")]
			[CompilerGenerated]
			protected get
			{
				return null;
			}
			[Token(Token = "0x600EFF7")]
			[Address(RVA = "0x66CF30", Offset = "0x66BB30", VA = "0x18066CF30")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17001F30 RID: 7984
		// (get) Token: 0x0600EFF8 RID: 61432 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600EFF9 RID: 61433 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17001F30")]
		protected Unit owner
		{
			[Token(Token = "0x600EFF8")]
			[Address(RVA = "0x66CBA0", Offset = "0x66B7A0", VA = "0x18066CBA0")]
			get
			{
				return null;
			}
			[Token(Token = "0x600EFF9")]
			[Address(RVA = "0x66CFB0", Offset = "0x66BBB0", VA = "0x18066CFB0")]
			set
			{
			}
		}

		// Token: 0x17001F31 RID: 7985
		// (get) Token: 0x0600EFFA RID: 61434 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17001F31")]
		protected Blackboard internalBlackboard
		{
			[Token(Token = "0x600EFFA")]
			[Address(RVA = "0x66C750", Offset = "0x66B350", VA = "0x18066C750")]
			get
			{
				return null;
			}
		}

		// Token: 0x17001F32 RID: 7986
		// (get) Token: 0x0600EFFB RID: 61435 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17001F32")]
		public Ability ability
		{
			[Token(Token = "0x600EFFB")]
			[Address(RVA = "0x66C390", Offset = "0x66AF90", VA = "0x18066C390", Slot = "20")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600EFFC RID: 61436 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600EFFC")]
		[Address(RVA = "0x66ACF0", Offset = "0x6698F0", VA = "0x18066ACF0", Slot = "21")]
		public virtual void AssignData(TalentData data, Unit owner, UnitDataFlowConfig.Delta modifier)
		{
		}

		// Token: 0x0600EFFD RID: 61437 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600EFFD")]
		[Address(RVA = "0x66B7F0", Offset = "0x66A3F0", VA = "0x18066B7F0", Slot = "22")]
		public virtual Blackboard GenerateAttackBlackboard(UnitMode mode)
		{
			return null;
		}

		// Token: 0x0600EFFE RID: 61438 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600EFFE")]
		[Address(RVA = "0x66BA10", Offset = "0x66A610", VA = "0x18066BA10", Slot = "23")]
		public virtual Blackboard GetSkillBlackboardFromRawData(TalentData talentData)
		{
			return null;
		}

		// Token: 0x0600EFFF RID: 61439 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600EFFF")]
		[Address(RVA = "0x66B1A0", Offset = "0x669DA0", VA = "0x18066B1A0")]
		public void Attach(Unit owner)
		{
		}

		// Token: 0x0600F000 RID: 61440 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F000")]
		[Address(RVA = "0x66B680", Offset = "0x66A280", VA = "0x18066B680")]
		public void Detach()
		{
		}

		// Token: 0x0600F001 RID: 61441 RVA: 0x000586B0 File Offset: 0x000568B0
		[Token(Token = "0x600F001")]
		[Address(RVA = "0x66BB80", Offset = "0x66A780", VA = "0x18066BB80", Slot = "24")]
		public virtual bool OnBeforeAttack(Ability ability, bool isCombat)
		{
			return default(bool);
		}

		// Token: 0x0600F002 RID: 61442 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F002")]
		[Address(RVA = "0x66BAF0", Offset = "0x66A6F0", VA = "0x18066BAF0", Slot = "25")]
		public virtual void OnAfterAttack(Ability ability, bool isCombat, Ability.FinishReason reason)
		{
		}

		// Token: 0x0600F003 RID: 61443 RVA: 0x000586C8 File Offset: 0x000568C8
		[Token(Token = "0x600F003")]
		[Address(RVA = "0x66B2E0", Offset = "0x669EE0", VA = "0x18066B2E0", Slot = "26")]
		public virtual bool CheckReborn(out Unit.RebornData respawnData)
		{
			return default(bool);
		}

		// Token: 0x0600F004 RID: 61444 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F004")]
		[Address(RVA = "0x66BA80", Offset = "0x66A680", VA = "0x18066BA80")]
		public void MarkInvalid()
		{
		}

		// Token: 0x0600F005 RID: 61445 RVA: 0x000586E0 File Offset: 0x000568E0
		[Token(Token = "0x600F005")]
		[Address(RVA = "0x66B4C0", Offset = "0x66A0C0", VA = "0x18066B4C0")]
		public bool CheckValidBySkillIndex(int index)
		{
			return default(bool);
		}

		// Token: 0x0600F006 RID: 61446 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F006")]
		[Address(RVA = "0x66BCD0", Offset = "0x66A8D0", VA = "0x18066BCD0")]
		public void SetParentMode(UnitMode mode)
		{
		}

		// Token: 0x0600F007 RID: 61447 RVA: 0x000586F8 File Offset: 0x000568F8
		[Token(Token = "0x600F007")]
		[Address(RVA = "0x66B580", Offset = "0x66A180", VA = "0x18066B580")]
		public bool CheckValidModeTalent(UnitMode mode)
		{
			return default(bool);
		}

		// Token: 0x0600F008 RID: 61448 RVA: 0x00058710 File Offset: 0x00056910
		[Token(Token = "0x600F008")]
		[Address(RVA = "0x66B370", Offset = "0x669F70", VA = "0x18066B370")]
		public bool CheckRootOrValidModeTalent(UnitMode mode)
		{
			return default(bool);
		}

		// Token: 0x0600F009 RID: 61449 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F009")]
		[Address(RVA = "0x66BC70", Offset = "0x66A870", VA = "0x18066BC70", Slot = "27")]
		public virtual void ProcessTraitBlackboard(Blackboard blackboard)
		{
		}

		// Token: 0x0600F00A RID: 61450 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F00A")]
		[Address(RVA = "0x66BC10", Offset = "0x66A810", VA = "0x18066BC10", Slot = "28")]
		public virtual void OnRecycle()
		{
		}

		// Token: 0x0600F00B RID: 61451 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600F00B")]
		[Address(RVA = "0x66B860", Offset = "0x66A460", VA = "0x18066B860")]
		public string GetOverrideAttackRangeID()
		{
			return null;
		}

		// Token: 0x0600F00C RID: 61452 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F00C")]
		[Address(RVA = "0x66A3B0", Offset = "0x668FB0", VA = "0x18066A3B0", Slot = "29")]
		protected virtual void DoAttach()
		{
		}

		// Token: 0x0600F00D RID: 61453 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F00D")]
		[Address(RVA = "0x66A420", Offset = "0x669020", VA = "0x18066A420", Slot = "30")]
		protected virtual void DoDetach()
		{
		}

		// Token: 0x0600F00E RID: 61454 RVA: 0x00058728 File Offset: 0x00056928
		[Token(Token = "0x600F00E")]
		[Address(RVA = "0x66C1F0", Offset = "0x66ADF0", VA = "0x18066C1F0")]
		private float _GetRangeRadius(TalentData data, Unit owner)
		{
			return 0f;
		}

		// Token: 0x0600F00F RID: 61455 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600F00F")]
		[Address(RVA = "0x66BD80", Offset = "0x66A980", VA = "0x18066BD80")]
		private Blackboard _CreateBlackboard(Blackboard dataSource, Unit owner)
		{
			return null;
		}

		// Token: 0x0600F010 RID: 61456 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600F010")]
		[Address(RVA = "0x66BFC0", Offset = "0x66ABC0", VA = "0x18066BFC0")]
		private Blackboard _GenerateBlackboardByTalentScale(Blackboard dataSource, Blackboard skillBlackboard)
		{
			return null;
		}

		// Token: 0x0600F011 RID: 61457 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F011")]
		[Address(RVA = "0x66B260", Offset = "0x669E60", VA = "0x18066B260")]
		private void Awake()
		{
		}

		// Token: 0x0600F012 RID: 61458 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F012")]
		[Address(RVA = "0x66B730", Offset = "0x66A330", VA = "0x18066B730", Slot = "31")]
		public virtual void GatherBuffs(List<BuffData> results)
		{
		}

		// Token: 0x0600F013 RID: 61459 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F013")]
		[Address(RVA = "0x66B790", Offset = "0x66A390", VA = "0x18066B790", Slot = "32")]
		public virtual void GatherEffects(List<string> effects)
		{
		}

		// Token: 0x0600F014 RID: 61460 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F014")]
		[Address(RVA = "0x66C330", Offset = "0x66AF30", VA = "0x18066C330")]
		protected BasicTalent()
		{
		}

		// Token: 0x04010945 RID: 67909
		[Token(Token = "0x4010945")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private string _overwriteTalentKey;

		// Token: 0x04010946 RID: 67910
		[Token(Token = "0x4010946")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private bool _overwriteParentRangeId;

		// Token: 0x04010947 RID: 67911
		[Token(Token = "0x4010947")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private List<int> _checkValidBySkillIndex;

		// Token: 0x04010948 RID: 67912
		[Token(Token = "0x4010948")]
		[FieldOffset(Offset = "0x30")]
		private Unit m_owner;

		// Token: 0x04010949 RID: 67913
		[Token(Token = "0x4010949")]
		[FieldOffset(Offset = "0x38")]
		protected Ability m_ability;

		// Token: 0x0401094C RID: 67916
		[Token(Token = "0x401094C")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_isValid;

		// Token: 0x0401094D RID: 67917
		[Token(Token = "0x401094D")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_isAttached;

		// Token: 0x0401094E RID: 67918
		[Token(Token = "0x401094E")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_attachInDummy;

		// Token: 0x0401094F RID: 67919
		[Token(Token = "0x401094F")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_get_affectInDeck;

		// Token: 0x04010950 RID: 67920
		[Token(Token = "0x4010950")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_get_overrideDefaultRangeId;

		// Token: 0x04010951 RID: 67921
		[Token(Token = "0x4010951")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_get_applyTalentScale;

		// Token: 0x04010952 RID: 67922
		[Token(Token = "0x4010952")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_get_scaleCertainKeyFlag;

		// Token: 0x04010953 RID: 67923
		[Token(Token = "0x4010953")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_get_scaleCertainKeyList;

		// Token: 0x04010954 RID: 67924
		[Token(Token = "0x4010954")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_get_applyTalentRangeBySkill;

		// Token: 0x04010955 RID: 67925
		[Token(Token = "0x4010955")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_get_applyBlackboardBySkill;

		// Token: 0x04010956 RID: 67926
		[Token(Token = "0x4010956")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_get_applyStrBlackboardBySkill;

		// Token: 0x04010957 RID: 67927
		[Token(Token = "0x4010957")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_get_writeRangeIdToProjectileBlackboard;

		// Token: 0x04010958 RID: 67928
		[Token(Token = "0x4010958")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0_get_isRootTalent;

		// Token: 0x04010959 RID: 67929
		[Token(Token = "0x4010959")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0_get_affectWhenNotRootTalent;

		// Token: 0x0401095A RID: 67930
		[Token(Token = "0x401095A")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0_get_isValidRootTalent;

		// Token: 0x0401095B RID: 67931
		[Token(Token = "0x401095B")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0_get_defaultModeIndex;

		// Token: 0x0401095C RID: 67932
		[Token(Token = "0x401095C")]
		[FieldOffset(Offset = "0x80")]
		private static DelegateBridge __Hotfix0_get_talentKey;

		// Token: 0x0401095D RID: 67933
		[Token(Token = "0x401095D")]
		[FieldOffset(Offset = "0x88")]
		private static DelegateBridge __Hotfix0_get_overwriteTalentKey;

		// Token: 0x0401095E RID: 67934
		[Token(Token = "0x401095E")]
		[FieldOffset(Offset = "0x90")]
		private static DelegateBridge __Hotfix0_get_rangeId;

		// Token: 0x0401095F RID: 67935
		[Token(Token = "0x401095F")]
		[FieldOffset(Offset = "0x98")]
		private static DelegateBridge __Hotfix0_get_parentMode;

		// Token: 0x04010960 RID: 67936
		[Token(Token = "0x4010960")]
		[FieldOffset(Offset = "0xA0")]
		private static DelegateBridge __Hotfix0_set_parentMode;

		// Token: 0x04010961 RID: 67937
		[Token(Token = "0x4010961")]
		[FieldOffset(Offset = "0xA8")]
		private static DelegateBridge __Hotfix0_get_data;

		// Token: 0x04010962 RID: 67938
		[Token(Token = "0x4010962")]
		[FieldOffset(Offset = "0xB0")]
		private static DelegateBridge __Hotfix0_set_data;

		// Token: 0x04010963 RID: 67939
		[Token(Token = "0x4010963")]
		[FieldOffset(Offset = "0xB8")]
		private static DelegateBridge __Hotfix0_get_owner;

		// Token: 0x04010964 RID: 67940
		[Token(Token = "0x4010964")]
		[FieldOffset(Offset = "0xC0")]
		private static DelegateBridge __Hotfix0_set_owner;

		// Token: 0x04010965 RID: 67941
		[Token(Token = "0x4010965")]
		[FieldOffset(Offset = "0xC8")]
		private static DelegateBridge __Hotfix0_get_internalBlackboard;

		// Token: 0x04010966 RID: 67942
		[Token(Token = "0x4010966")]
		[FieldOffset(Offset = "0xD0")]
		private static DelegateBridge __Hotfix0_get_ability;

		// Token: 0x04010967 RID: 67943
		[Token(Token = "0x4010967")]
		[FieldOffset(Offset = "0xD8")]
		private static DelegateBridge __Hotfix0_AssignData;

		// Token: 0x04010968 RID: 67944
		[Token(Token = "0x4010968")]
		[FieldOffset(Offset = "0xE0")]
		private static DelegateBridge __Hotfix0_GenerateAttackBlackboard;

		// Token: 0x04010969 RID: 67945
		[Token(Token = "0x4010969")]
		[FieldOffset(Offset = "0xE8")]
		private static DelegateBridge __Hotfix0_GetSkillBlackboardFromRawData;

		// Token: 0x0401096A RID: 67946
		[Token(Token = "0x401096A")]
		[FieldOffset(Offset = "0xF0")]
		private static DelegateBridge __Hotfix0_Attach;

		// Token: 0x0401096B RID: 67947
		[Token(Token = "0x401096B")]
		[FieldOffset(Offset = "0xF8")]
		private static DelegateBridge __Hotfix0_Detach;

		// Token: 0x0401096C RID: 67948
		[Token(Token = "0x401096C")]
		[FieldOffset(Offset = "0x100")]
		private static DelegateBridge __Hotfix0_OnBeforeAttack;

		// Token: 0x0401096D RID: 67949
		[Token(Token = "0x401096D")]
		[FieldOffset(Offset = "0x108")]
		private static DelegateBridge __Hotfix0_OnAfterAttack;

		// Token: 0x0401096E RID: 67950
		[Token(Token = "0x401096E")]
		[FieldOffset(Offset = "0x110")]
		private static DelegateBridge __Hotfix0_CheckReborn;

		// Token: 0x0401096F RID: 67951
		[Token(Token = "0x401096F")]
		[FieldOffset(Offset = "0x118")]
		private static DelegateBridge __Hotfix0_MarkInvalid;

		// Token: 0x04010970 RID: 67952
		[Token(Token = "0x4010970")]
		[FieldOffset(Offset = "0x120")]
		private static DelegateBridge __Hotfix0_CheckValidBySkillIndex;

		// Token: 0x04010971 RID: 67953
		[Token(Token = "0x4010971")]
		[FieldOffset(Offset = "0x128")]
		private static DelegateBridge __Hotfix0_SetParentMode;

		// Token: 0x04010972 RID: 67954
		[Token(Token = "0x4010972")]
		[FieldOffset(Offset = "0x130")]
		private static DelegateBridge __Hotfix0_CheckValidModeTalent;

		// Token: 0x04010973 RID: 67955
		[Token(Token = "0x4010973")]
		[FieldOffset(Offset = "0x138")]
		private static DelegateBridge __Hotfix0_CheckRootOrValidModeTalent;

		// Token: 0x04010974 RID: 67956
		[Token(Token = "0x4010974")]
		[FieldOffset(Offset = "0x140")]
		private static DelegateBridge __Hotfix0_ProcessTraitBlackboard;

		// Token: 0x04010975 RID: 67957
		[Token(Token = "0x4010975")]
		[FieldOffset(Offset = "0x148")]
		private static DelegateBridge __Hotfix0_OnRecycle;

		// Token: 0x04010976 RID: 67958
		[Token(Token = "0x4010976")]
		[FieldOffset(Offset = "0x150")]
		private static DelegateBridge __Hotfix0_GetOverrideAttackRangeID;

		// Token: 0x04010977 RID: 67959
		[Token(Token = "0x4010977")]
		[FieldOffset(Offset = "0x158")]
		private static DelegateBridge __Hotfix0_DoAttach;

		// Token: 0x04010978 RID: 67960
		[Token(Token = "0x4010978")]
		[FieldOffset(Offset = "0x160")]
		private static DelegateBridge __Hotfix0_DoDetach;

		// Token: 0x04010979 RID: 67961
		[Token(Token = "0x4010979")]
		[FieldOffset(Offset = "0x168")]
		private static DelegateBridge __Hotfix0__GetRangeRadius;

		// Token: 0x0401097A RID: 67962
		[Token(Token = "0x401097A")]
		[FieldOffset(Offset = "0x170")]
		private static DelegateBridge __Hotfix0__CreateBlackboard;

		// Token: 0x0401097B RID: 67963
		[Token(Token = "0x401097B")]
		[FieldOffset(Offset = "0x178")]
		private static DelegateBridge __Hotfix0__GenerateBlackboardByTalentScale;

		// Token: 0x0401097C RID: 67964
		[Token(Token = "0x401097C")]
		[FieldOffset(Offset = "0x180")]
		private static DelegateBridge __Hotfix0_Awake;

		// Token: 0x0401097D RID: 67965
		[Token(Token = "0x401097D")]
		[FieldOffset(Offset = "0x188")]
		private static DelegateBridge __Hotfix0_GatherBuffs;

		// Token: 0x0401097E RID: 67966
		[Token(Token = "0x401097E")]
		[FieldOffset(Offset = "0x190")]
		private static DelegateBridge __Hotfix0_GatherEffects;

		// Token: 0x0401097F RID: 67967
		[Token(Token = "0x401097F")]
		[FieldOffset(Offset = "0x198")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}

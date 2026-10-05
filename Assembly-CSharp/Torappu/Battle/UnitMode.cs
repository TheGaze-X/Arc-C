using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Serialization;

namespace Torappu.Battle
{
	// Token: 0x02002621 RID: 9761
	[Token(Token = "0x2002621")]
	public class UnitMode : MonoBehaviour, ITalentOwner, IEffectSource
	{
		// Token: 0x170022C9 RID: 8905
		// (get) Token: 0x0600FF7B RID: 65403 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600FF7C RID: 65404 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170022C9")]
		public Unit host
		{
			[Token(Token = "0x600FF7B")]
			[Address(RVA = "0x4E8B00", Offset = "0x4E7700", VA = "0x1804E8B00")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600FF7C")]
			[Address(RVA = "0x789450", Offset = "0x788050", VA = "0x180789450")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170022CA RID: 8906
		// (get) Token: 0x0600FF7D RID: 65405 RVA: 0x00061158 File Offset: 0x0005F358
		// (set) Token: 0x0600FF7E RID: 65406 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170022CA")]
		public int index
		{
			[Token(Token = "0x600FF7D")]
			[Address(RVA = "0x7893A0", Offset = "0x787FA0", VA = "0x1807893A0")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[Token(Token = "0x600FF7E")]
			[Address(RVA = "0x789460", Offset = "0x788060", VA = "0x180789460")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170022CB RID: 8907
		// (get) Token: 0x0600FF7F RID: 65407 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170022CB")]
		public Transform bodyTransform
		{
			[Token(Token = "0x600FF7F")]
			[Address(RVA = "0x4E5A80", Offset = "0x4E4680", VA = "0x1804E5A80")]
			get
			{
				return null;
			}
		}

		// Token: 0x170022CC RID: 8908
		// (get) Token: 0x0600FF80 RID: 65408 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170022CC")]
		public Ability combat
		{
			[Token(Token = "0x600FF80")]
			[Address(RVA = "0x4EA850", Offset = "0x4E9450", VA = "0x1804EA850")]
			get
			{
				return null;
			}
		}

		// Token: 0x170022CD RID: 8909
		// (get) Token: 0x0600FF81 RID: 65409 RVA: 0x00061170 File Offset: 0x0005F370
		[Token(Token = "0x170022CD")]
		public bool hasCombat
		{
			[Token(Token = "0x600FF81")]
			[Address(RVA = "0x789340", Offset = "0x787F40", VA = "0x180789340")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170022CE RID: 8910
		// (get) Token: 0x0600FF82 RID: 65410 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170022CE")]
		public Ability attack
		{
			[Token(Token = "0x600FF82")]
			[Address(RVA = "0x4EE950", Offset = "0x4ED550", VA = "0x1804EE950")]
			get
			{
				return null;
			}
		}

		// Token: 0x170022CF RID: 8911
		// (get) Token: 0x0600FF83 RID: 65411 RVA: 0x00061188 File Offset: 0x0005F388
		[Token(Token = "0x170022CF")]
		public bool hasAttack
		{
			[Token(Token = "0x600FF83")]
			[Address(RVA = "0x7892F0", Offset = "0x787EF0", VA = "0x1807892F0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170022D0 RID: 8912
		// (get) Token: 0x0600FF84 RID: 65412 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170022D0")]
		public TargetTrigger attackTrigger
		{
			[Token(Token = "0x600FF84")]
			[Address(RVA = "0x4EE940", Offset = "0x4ED540", VA = "0x1804EE940")]
			get
			{
				return null;
			}
		}

		// Token: 0x170022D1 RID: 8913
		// (get) Token: 0x0600FF85 RID: 65413 RVA: 0x000611A0 File Offset: 0x0005F3A0
		[Token(Token = "0x170022D1")]
		public bool? alwaysHideHp
		{
			[Token(Token = "0x600FF85")]
			[Address(RVA = "0x789290", Offset = "0x787E90", VA = "0x180789290")]
			get
			{
				return null;
			}
		}

		// Token: 0x170022D2 RID: 8914
		// (get) Token: 0x0600FF86 RID: 65414 RVA: 0x000611B8 File Offset: 0x0005F3B8
		[Token(Token = "0x170022D2")]
		public bool? alwaysHideSp
		{
			[Token(Token = "0x600FF86")]
			[Address(RVA = "0x7892A0", Offset = "0x787EA0", VA = "0x1807892A0")]
			get
			{
				return null;
			}
		}

		// Token: 0x170022D3 RID: 8915
		// (get) Token: 0x0600FF87 RID: 65415 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170022D3")]
		public string rangeId
		{
			[Token(Token = "0x600FF87")]
			[Address(RVA = "0x4FB2F0", Offset = "0x4F9EF0", VA = "0x1804FB2F0")]
			get
			{
				return null;
			}
		}

		// Token: 0x170022D4 RID: 8916
		// (get) Token: 0x0600FF88 RID: 65416 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170022D4")]
		public IDrawableRange rangeToShow
		{
			[Token(Token = "0x600FF88")]
			[Address(RVA = "0x7893B0", Offset = "0x787FB0", VA = "0x1807893B0")]
			get
			{
				return null;
			}
		}

		// Token: 0x170022D5 RID: 8917
		// (get) Token: 0x0600FF89 RID: 65417 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170022D5")]
		public IDrawableRange[] extraRangesToShow
		{
			[Token(Token = "0x600FF89")]
			[Address(RVA = "0x7892B0", Offset = "0x787EB0", VA = "0x1807892B0")]
			get
			{
				return null;
			}
		}

		// Token: 0x170022D6 RID: 8918
		// (get) Token: 0x0600FF8A RID: 65418 RVA: 0x000611D0 File Offset: 0x0005F3D0
		[Token(Token = "0x170022D6")]
		public bool hideUIAttackRange
		{
			[Token(Token = "0x600FF8A")]
			[Address(RVA = "0x789390", Offset = "0x787F90", VA = "0x180789390")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170022D7 RID: 8919
		// (get) Token: 0x0600FF8B RID: 65419 RVA: 0x000611E8 File Offset: 0x0005F3E8
		// (set) Token: 0x0600FF8C RID: 65420 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170022D7")]
		public SourceApplyWay allApplyWay
		{
			[Token(Token = "0x600FF8B")]
			[Address(RVA = "0x789280", Offset = "0x787E80", VA = "0x180789280")]
			[CompilerGenerated]
			get
			{
				return SourceApplyWay.NONE;
			}
			[Token(Token = "0x600FF8C")]
			[Address(RVA = "0x789440", Offset = "0x788040", VA = "0x180789440")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170022D8 RID: 8920
		// (get) Token: 0x0600FF8D RID: 65421 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170022D8")]
		public List<Ability> abilities
		{
			[Token(Token = "0x600FF8D")]
			[Address(RVA = "0x789270", Offset = "0x787E70", VA = "0x180789270")]
			get
			{
				return null;
			}
		}

		// Token: 0x170022D9 RID: 8921
		// (get) Token: 0x0600FF8E RID: 65422 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170022D9")]
		public UnitAnimatorHooker animatorHooker
		{
			[Token(Token = "0x600FF8E")]
			[Address(RVA = "0x4E5A70", Offset = "0x4E4670", VA = "0x1804E5A70")]
			get
			{
				return null;
			}
		}

		// Token: 0x170022DA RID: 8922
		// (get) Token: 0x0600FF8F RID: 65423 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170022DA")]
		public string overrideStartEffect
		{
			[Token(Token = "0x600FF8F")]
			[Address(RVA = "0x4E4070", Offset = "0x4E2C70", VA = "0x1804E4070")]
			get
			{
				return null;
			}
		}

		// Token: 0x170022DB RID: 8923
		// (get) Token: 0x0600FF90 RID: 65424 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170022DB")]
		public string overrideDeadEffect
		{
			[Token(Token = "0x600FF90")]
			[Address(RVA = "0x4EA8A0", Offset = "0x4E94A0", VA = "0x1804EA8A0")]
			get
			{
				return null;
			}
		}

		// Token: 0x170022DC RID: 8924
		// (get) Token: 0x0600FF91 RID: 65425 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600FF92 RID: 65426 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170022DC")]
		public BasicTalent[] talents
		{
			[Token(Token = "0x600FF91")]
			[Address(RVA = "0x789430", Offset = "0x788030", VA = "0x180789430")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600FF92")]
			[Address(RVA = "0x789470", Offset = "0x788070", VA = "0x180789470")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x0600FF93 RID: 65427 RVA: 0x00061200 File Offset: 0x0005F400
		[Token(Token = "0x600FF93")]
		[Address(RVA = "0x787F60", Offset = "0x786B60", VA = "0x180787F60", Slot = "6")]
		public virtual bool InitOnce(Unit host, int index)
		{
			return default(bool);
		}

		// Token: 0x0600FF94 RID: 65428 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600FF94")]
		[Address(RVA = "0x7884F0", Offset = "0x7870F0", VA = "0x1807884F0", Slot = "7")]
		public virtual void OnInit()
		{
		}

		// Token: 0x0600FF95 RID: 65429 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600FF95")]
		[Address(RVA = "0x7881D0", Offset = "0x786DD0", VA = "0x1807881D0", Slot = "8")]
		public virtual void OnActivate(UnitMode oldMode, bool isInit)
		{
		}

		// Token: 0x0600FF96 RID: 65430 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600FF96")]
		[Address(RVA = "0x7883A0", Offset = "0x786FA0", VA = "0x1807883A0", Slot = "9")]
		public virtual void OnInactivate()
		{
		}

		// Token: 0x0600FF97 RID: 65431 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600FF97")]
		[Address(RVA = "0x788050", Offset = "0x786C50", VA = "0x180788050")]
		public void OnAbilityRangeForwardExtendUpdate()
		{
		}

		// Token: 0x0600FF98 RID: 65432 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600FF98")]
		[Address(RVA = "0x787E80", Offset = "0x786A80", VA = "0x180787E80")]
		public string GenerateSignalId(string hostId, string tmplId, string suffix, int index)
		{
			return null;
		}

		// Token: 0x0600FF99 RID: 65433 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600FF99")]
		[Address(RVA = "0x788D20", Offset = "0x787920", VA = "0x180788D20")]
		public void RegisterDynamicAbility(Ability ability, Blackboard blackboard)
		{
		}

		// Token: 0x0600FF9A RID: 65434 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600FF9A")]
		[Address(RVA = "0x787CD0", Offset = "0x7868D0", VA = "0x180787CD0")]
		public void ClearDynamicAbilities()
		{
		}

		// Token: 0x0600FF9B RID: 65435 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600FF9B")]
		[Address(RVA = "0x788E20", Offset = "0x787A20", VA = "0x180788E20")]
		private void _InitAbilities()
		{
		}

		// Token: 0x0600FF9C RID: 65436 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600FF9C")]
		[Address(RVA = "0x788FE0", Offset = "0x787BE0", VA = "0x180788FE0")]
		private void _InitTalents()
		{
		}

		// Token: 0x0600FF9D RID: 65437 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600FF9D")]
		[Address(RVA = "0x788D10", Offset = "0x787910", VA = "0x180788D10", Slot = "4")]
		public void RecollectTalents()
		{
		}

		// Token: 0x0600FF9E RID: 65438 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600FF9E")]
		[Address(RVA = "0x787E10", Offset = "0x786A10", VA = "0x180787E10", Slot = "5")]
		public void GatherEffects(List<string> effects)
		{
		}

		// Token: 0x0600FF9F RID: 65439 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600FF9F")]
		[Address(RVA = "0x7890B0", Offset = "0x787CB0", VA = "0x1807890B0")]
		public UnitMode()
		{
		}

		// Token: 0x04011BCB RID: 72651
		[Token(Token = "0x4011BCB")]
		[NonSerialized]
		public const string COMBAT_DESCRIPTION_SUFFIX = ".combat";

		// Token: 0x04011BCC RID: 72652
		[Token(Token = "0x4011BCC")]
		[NonSerialized]
		public const string ATTACK_DESCRIPTION_SUFFIX = ".attack";

		// Token: 0x04011BCD RID: 72653
		[Token(Token = "0x4011BCD")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Transform _bodyTransform;

		// Token: 0x04011BCE RID: 72654
		[Token(Token = "0x4011BCE")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private UnitAnimatorHooker _animatorHooker;

		// Token: 0x04011BCF RID: 72655
		[Token(Token = "0x4011BCF")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private string _overrideStartEffect;

		// Token: 0x04011BD0 RID: 72656
		[Token(Token = "0x4011BD0")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private string _overrideDeadEffect;

		// Token: 0x04011BD1 RID: 72657
		[Token(Token = "0x4011BD1")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Ability _combat;

		// Token: 0x04011BD2 RID: 72658
		[Token(Token = "0x4011BD2")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Ability _attack;

		// Token: 0x04011BD3 RID: 72659
		[Token(Token = "0x4011BD3")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private TargetTrigger _attackTrigger;

		// Token: 0x04011BD4 RID: 72660
		[Token(Token = "0x4011BD4")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private bool _hideUIAttackRange;

		// Token: 0x04011BD5 RID: 72661
		[Token(Token = "0x4011BD5")]
		[FieldOffset(Offset = "0x51")]
		[SerializeField]
		private bool _updateAttackRangeExtendByAttributeDirty;

		// Token: 0x04011BD6 RID: 72662
		[Token(Token = "0x4011BD6")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private TargetSelector _rangeToShow;

		// Token: 0x04011BD7 RID: 72663
		[Token(Token = "0x4011BD7")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private TargetSelector[] _extraRangesToShow;

		// Token: 0x04011BD8 RID: 72664
		[Token(Token = "0x4011BD8")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		[FormerlySerializedAs("_passiveAbilities")]
		private Ability[] _generalAbilities;

		// Token: 0x04011BD9 RID: 72665
		[Token(Token = "0x4011BD9")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		[FormerlySerializedAs("_addIndexToDescriptionId")]
		private bool _addIndexToSignalId;

		// Token: 0x04011BDA RID: 72666
		[Token(Token = "0x4011BDA")]
		[FieldOffset(Offset = "0x71")]
		[SerializeField]
		private bool _includeIndexZero;

		// Token: 0x04011BDB RID: 72667
		[Token(Token = "0x4011BDB")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private SerializedBool _alwaysHideHp;

		// Token: 0x04011BDC RID: 72668
		[Token(Token = "0x4011BDC")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private SerializedBool _alwaysHideSp;

		// Token: 0x04011BDD RID: 72669
		[Token(Token = "0x4011BDD")]
		[FieldOffset(Offset = "0x88")]
		private bool m_inited;

		// Token: 0x04011BDE RID: 72670
		[Token(Token = "0x4011BDE")]
		[FieldOffset(Offset = "0x90")]
		private List<Ability> m_abilities;

		// Token: 0x04011BDF RID: 72671
		[Token(Token = "0x4011BDF")]
		[FieldOffset(Offset = "0x98")]
		private List<KeyValuePair<Ability, Blackboard>> m_dynaimcAbilites;

		// Token: 0x04011BE0 RID: 72672
		[Token(Token = "0x4011BE0")]
		[FieldOffset(Offset = "0xA0")]
		private string m_rangeId;

		// Token: 0x04011BE3 RID: 72675
		[Token(Token = "0x4011BE3")]
		[FieldOffset(Offset = "0xB8")]
		private IDrawableRange[] m_extraRangesToShow;
	}
}

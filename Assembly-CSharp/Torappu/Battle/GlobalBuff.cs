using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Torappu.ObjectPool;
using UnityEngine;
using XLua;

namespace Torappu.Battle
{
	// Token: 0x02002270 RID: 8816
	[Token(Token = "0x2002270")]
	[Serializable]
	public class GlobalBuff : MonoBehaviour, IBuffSource, IEffectSource, IHotfixable, IReusableObject, IReusable, IPtrObject
	{
		// Token: 0x17001BE8 RID: 7144
		// (get) Token: 0x0600DDBB RID: 56763 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17001BE8")]
		public string overrideCameraEffect
		{
			[Token(Token = "0x600DDBB")]
			[Address(RVA = "0x3637F40", Offset = "0x3636B40", VA = "0x183637F40")]
			get
			{
				return null;
			}
		}

		// Token: 0x17001BE9 RID: 7145
		// (get) Token: 0x0600DDBC RID: 56764 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17001BE9")]
		public string key
		{
			[Token(Token = "0x600DDBC")]
			[Address(RVA = "0x3637EE0", Offset = "0x3636AE0", VA = "0x183637EE0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17001BEA RID: 7146
		// (get) Token: 0x0600DDBD RID: 56765 RVA: 0x00050DA8 File Offset: 0x0004EFA8
		[Token(Token = "0x17001BEA")]
		public bool hasKey
		{
			[Token(Token = "0x600DDBD")]
			[Address(RVA = "0x3637E10", Offset = "0x3636A10", VA = "0x183637E10")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x0600DDBE RID: 56766 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600DDBE")]
		[Address(RVA = "0x362C380", Offset = "0x362AF80", VA = "0x18362C380", Slot = "9")]
		public virtual void OnTick(FP deltaTime)
		{
		}

		// Token: 0x0600DDBF RID: 56767 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600DDBF")]
		[Address(RVA = "0x36363E0", Offset = "0x3634FE0", VA = "0x1836363E0", Slot = "4")]
		public void GatherBuffs(List<BuffData> results)
		{
		}

		// Token: 0x0600DDC0 RID: 56768 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600DDC0")]
		[Address(RVA = "0x3636510", Offset = "0x3635110", VA = "0x183636510", Slot = "10")]
		public virtual void GatherEffects(List<string> effects)
		{
		}

		// Token: 0x0600DDC1 RID: 56769 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600DDC1")]
		[Address(RVA = "0x36366E0", Offset = "0x36352E0", VA = "0x1836366E0", Slot = "11")]
		public virtual void OnInit(LevelData.GlobalBuffData data)
		{
		}

		// Token: 0x0600DDC2 RID: 56770 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600DDC2")]
		[Address(RVA = "0x3636DE0", Offset = "0x36359E0", VA = "0x183636DE0", Slot = "12")]
		public virtual void TryAddBuff(Unit unit, bool isInit = true)
		{
		}

		// Token: 0x0600DDC3 RID: 56771 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600DDC3")]
		[Address(RVA = "0x3637590", Offset = "0x3636190", VA = "0x183637590", Slot = "13")]
		public virtual void TryRemoveBuff(Unit unit, bool isInit = true, bool ignoreVerify = false)
		{
		}

		// Token: 0x0600DDC4 RID: 56772 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600DDC4")]
		[Address(RVA = "0x3636B60", Offset = "0x3635760", VA = "0x183636B60", Slot = "14")]
		public virtual void OnRemoved()
		{
		}

		// Token: 0x0600DDC5 RID: 56773 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600DDC5")]
		[Address(RVA = "0x3637350", Offset = "0x3635F50", VA = "0x183637350")]
		public void TryGetDeckBuff(Unit unit, ref List<DeckBuff> deckBuffs, ref List<Blackboard> blackboards)
		{
		}

		// Token: 0x0600DDC6 RID: 56774 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600DDC6")]
		[Address(RVA = "0x3636580", Offset = "0x3635180", VA = "0x183636580")]
		public void ModifyBlackboard(string blackboardKey, FP value)
		{
		}

		// Token: 0x0600DDC7 RID: 56775 RVA: 0x00050DC0 File Offset: 0x0004EFC0
		[Token(Token = "0x600DDC7")]
		[Address(RVA = "0x3637A20", Offset = "0x3636620", VA = "0x183637A20")]
		private bool _VerifyBuffAddTimes(Unit unit)
		{
			return default(bool);
		}

		// Token: 0x0600DDC8 RID: 56776 RVA: 0x00050DD8 File Offset: 0x0004EFD8
		[Token(Token = "0x600DDC8")]
		[Address(RVA = "0x3637B50", Offset = "0x3636750", VA = "0x183637B50")]
		private bool _VerifyBuffExist(Unit unit)
		{
			return default(bool);
		}

		// Token: 0x0600DDC9 RID: 56777 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600DDC9")]
		[Address(RVA = "0x36378C0", Offset = "0x36364C0", VA = "0x1836378C0")]
		private void _FetchDataFromPrefab()
		{
		}

		// Token: 0x0600DDCA RID: 56778 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600DDCA")]
		[Address(RVA = "0x3637970", Offset = "0x3636570", VA = "0x183637970")]
		private void _OverrideByExtraData(LevelData.GlobalBuffData.ExtraRuntimeData extraData)
		{
		}

		// Token: 0x0600DDCB RID: 56779 RVA: 0x00050DF0 File Offset: 0x0004EFF0
		[Token(Token = "0x600DDCB")]
		[Address(RVA = "0x3637C80", Offset = "0x3636880", VA = "0x183637C80", Slot = "15")]
		protected virtual bool _VerifyTarget(Unit unit)
		{
			return default(bool);
		}

		// Token: 0x0600DDCC RID: 56780 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600DDCC")]
		[Address(RVA = "0x362AB10", Offset = "0x3629710", VA = "0x18362AB10", Slot = "16")]
		public virtual void OnReset()
		{
		}

		// Token: 0x0600DDCD RID: 56781 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600DDCD")]
		[Address(RVA = "0x3636620", Offset = "0x3635220", VA = "0x183636620", Slot = "6")]
		public void OnAllocate()
		{
		}

		// Token: 0x0600DDCE RID: 56782 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600DDCE")]
		[Address(RVA = "0x3636AB0", Offset = "0x36356B0", VA = "0x183636AB0", Slot = "7")]
		public void OnRecycle()
		{
		}

		// Token: 0x17001BEB RID: 7147
		// (get) Token: 0x0600DDCF RID: 56783 RVA: 0x00050E08 File Offset: 0x0004F008
		// (set) Token: 0x0600DDD0 RID: 56784 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17001BEB")]
		public uint instanceUid
		{
			[Token(Token = "0x600DDCF")]
			[Address(RVA = "0x3637E80", Offset = "0x3636A80", VA = "0x183637E80", Slot = "8")]
			[CompilerGenerated]
			get
			{
				return 0U;
			}
			[Token(Token = "0x600DDD0")]
			[Address(RVA = "0x3637FC0", Offset = "0x3636BC0", VA = "0x183637FC0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x0600DDD1 RID: 56785 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600DDD1")]
		[Address(RVA = "0x3637D00", Offset = "0x3636900", VA = "0x183637D00")]
		public GlobalBuff()
		{
		}

		// Token: 0x0400F05C RID: 61532
		[Token(Token = "0x400F05C")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private string _key;

		// Token: 0x0400F05D RID: 61533
		[Token(Token = "0x400F05D")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		protected TargetOptions _options;

		// Token: 0x0400F05E RID: 61534
		[Token(Token = "0x400F05E")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		protected BuffData[] _buffs;

		// Token: 0x0400F05F RID: 61535
		[Token(Token = "0x400F05F")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		private string _overrideCameraEffect;

		// Token: 0x0400F060 RID: 61536
		[Token(Token = "0x400F060")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		private DeckBuff[] _deckBuffs;

		// Token: 0x0400F061 RID: 61537
		[Token(Token = "0x400F061")]
		[FieldOffset(Offset = "0x98")]
		[SerializeField]
		private SideTypeIndex _sourceType;

		// Token: 0x0400F062 RID: 61538
		[Token(Token = "0x400F062")]
		[FieldOffset(Offset = "0xA0")]
		private GlobalBuff.GlobalBuffExtraValidatorDelegate m_extraValidator;

		// Token: 0x0400F063 RID: 61539
		[Token(Token = "0x400F063")]
		[FieldOffset(Offset = "0xA8")]
		private int m_layerMask;

		// Token: 0x0400F064 RID: 61540
		[Token(Token = "0x400F064")]
		[FieldOffset(Offset = "0xB0")]
		private string m_overrideCameraEffect;

		// Token: 0x0400F065 RID: 61541
		[Token(Token = "0x400F065")]
		[FieldOffset(Offset = "0xB8")]
		private int m_buffAddLimitedTimes;

		// Token: 0x0400F066 RID: 61542
		[Token(Token = "0x400F066")]
		[FieldOffset(Offset = "0xC0")]
		private Dictionary<string, int> m_cachedAddedUnits;

		// Token: 0x0400F067 RID: 61543
		[Token(Token = "0x400F067")]
		[FieldOffset(Offset = "0xC8")]
		private bool m_checkExtraProfession;

		// Token: 0x0400F068 RID: 61544
		[Token(Token = "0x400F068")]
		[FieldOffset(Offset = "0xCC")]
		private SideTypeIndex m_sourceType;

		// Token: 0x0400F069 RID: 61545
		[Token(Token = "0x400F069")]
		[FieldOffset(Offset = "0xD0")]
		private TargetOptions m_options;

		// Token: 0x0400F06A RID: 61546
		[Token(Token = "0x400F06A")]
		[FieldOffset(Offset = "0x130")]
		protected Dictionary<ObjectPtr<Entity>, List<uint>> m_targetMap;

		// Token: 0x0400F06B RID: 61547
		[Token(Token = "0x400F06B")]
		[FieldOffset(Offset = "0x138")]
		[NonSerialized]
		public Blackboard blackboard;

		// Token: 0x0400F06C RID: 61548
		[Token(Token = "0x400F06C")]
		[FieldOffset(Offset = "0x0")]
		private static uint s_globalCounter;

		// Token: 0x0400F06E RID: 61550
		[Token(Token = "0x400F06E")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_overrideCameraEffect;

		// Token: 0x0400F06F RID: 61551
		[Token(Token = "0x400F06F")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_key;

		// Token: 0x0400F070 RID: 61552
		[Token(Token = "0x400F070")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_get_hasKey;

		// Token: 0x0400F071 RID: 61553
		[Token(Token = "0x400F071")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_OnTick;

		// Token: 0x0400F072 RID: 61554
		[Token(Token = "0x400F072")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_GatherBuffs;

		// Token: 0x0400F073 RID: 61555
		[Token(Token = "0x400F073")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_GatherEffects;

		// Token: 0x0400F074 RID: 61556
		[Token(Token = "0x400F074")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_OnInit;

		// Token: 0x0400F075 RID: 61557
		[Token(Token = "0x400F075")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_TryAddBuff;

		// Token: 0x0400F076 RID: 61558
		[Token(Token = "0x400F076")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_TryRemoveBuff;

		// Token: 0x0400F077 RID: 61559
		[Token(Token = "0x400F077")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_OnRemoved;

		// Token: 0x0400F078 RID: 61560
		[Token(Token = "0x400F078")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_TryGetDeckBuff;

		// Token: 0x0400F079 RID: 61561
		[Token(Token = "0x400F079")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0_ModifyBlackboard;

		// Token: 0x0400F07A RID: 61562
		[Token(Token = "0x400F07A")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0__VerifyBuffAddTimes;

		// Token: 0x0400F07B RID: 61563
		[Token(Token = "0x400F07B")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0__VerifyBuffExist;

		// Token: 0x0400F07C RID: 61564
		[Token(Token = "0x400F07C")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0__FetchDataFromPrefab;

		// Token: 0x0400F07D RID: 61565
		[Token(Token = "0x400F07D")]
		[FieldOffset(Offset = "0x80")]
		private static DelegateBridge __Hotfix0__OverrideByExtraData;

		// Token: 0x0400F07E RID: 61566
		[Token(Token = "0x400F07E")]
		[FieldOffset(Offset = "0x88")]
		private static DelegateBridge __Hotfix0__VerifyTarget;

		// Token: 0x0400F07F RID: 61567
		[Token(Token = "0x400F07F")]
		[FieldOffset(Offset = "0x90")]
		private static DelegateBridge __Hotfix0_OnReset;

		// Token: 0x0400F080 RID: 61568
		[Token(Token = "0x400F080")]
		[FieldOffset(Offset = "0x98")]
		private static DelegateBridge __Hotfix0_OnAllocate;

		// Token: 0x0400F081 RID: 61569
		[Token(Token = "0x400F081")]
		[FieldOffset(Offset = "0xA0")]
		private static DelegateBridge __Hotfix0_OnRecycle;

		// Token: 0x0400F082 RID: 61570
		[Token(Token = "0x400F082")]
		[FieldOffset(Offset = "0xA8")]
		private static DelegateBridge __Hotfix0_get_instanceUid;

		// Token: 0x0400F083 RID: 61571
		[Token(Token = "0x400F083")]
		[FieldOffset(Offset = "0xB0")]
		private static DelegateBridge __Hotfix0_set_instanceUid;

		// Token: 0x0400F084 RID: 61572
		[Token(Token = "0x400F084")]
		[FieldOffset(Offset = "0xB8")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02002271 RID: 8817
		// (Invoke) Token: 0x0600DDD3 RID: 56787
		[Token(Token = "0x2002271")]
		public delegate bool GlobalBuffExtraValidatorDelegate(Unit unit, Blackboard blackboard);
	}
}

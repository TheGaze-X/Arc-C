using System;
using System.Collections;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.Audio.Middleware;
using Torappu.Battle.Effects;
using UnityEngine;
using XLua;

namespace Torappu.Battle.Skills
{
	// Token: 0x020028B3 RID: 10419
	[Token(Token = "0x20028B3")]
	public class ChantBeforeSkill : BasicSkill.Behaviour, IEffectSource, IBuffSource
	{
		// Token: 0x06011525 RID: 70949 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011525")]
		[Address(RVA = "0x91ECD0", Offset = "0x91D8D0", VA = "0x18091ECD0", Slot = "17")]
		public void GatherBuffs(List<BuffData> results)
		{
		}

		// Token: 0x06011526 RID: 70950 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011526")]
		[Address(RVA = "0x91EDE0", Offset = "0x91D9E0", VA = "0x18091EDE0", Slot = "16")]
		public void GatherEffects(List<string> effects)
		{
		}

		// Token: 0x1700264A RID: 9802
		// (get) Token: 0x06011527 RID: 70951 RVA: 0x0006AA70 File Offset: 0x00068C70
		[Token(Token = "0x1700264A")]
		public float chantProgress
		{
			[Token(Token = "0x6011527")]
			[Address(RVA = "0x920D40", Offset = "0x91F940", VA = "0x180920D40")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x1700264B RID: 9803
		// (get) Token: 0x06011528 RID: 70952 RVA: 0x0006AA88 File Offset: 0x00068C88
		[Token(Token = "0x1700264B")]
		public bool isInChant
		{
			[Token(Token = "0x6011528")]
			[Address(RVA = "0x920F10", Offset = "0x91FB10", VA = "0x180920F10")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700264C RID: 9804
		// (get) Token: 0x06011529 RID: 70953 RVA: 0x0006AAA0 File Offset: 0x00068CA0
		[Token(Token = "0x1700264C")]
		public bool isInExtraChant
		{
			[Token(Token = "0x6011529")]
			[Address(RVA = "0x920FA0", Offset = "0x91FBA0", VA = "0x180920FA0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700264D RID: 9805
		// (get) Token: 0x0601152A RID: 70954 RVA: 0x0006AAB8 File Offset: 0x00068CB8
		[Token(Token = "0x1700264D")]
		public bool chantAvailable
		{
			[Token(Token = "0x601152A")]
			[Address(RVA = "0x920CD0", Offset = "0x91F8D0", VA = "0x180920CD0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700264E RID: 9806
		// (get) Token: 0x0601152B RID: 70955 RVA: 0x0006AAD0 File Offset: 0x00068CD0
		[Token(Token = "0x1700264E")]
		public bool suspendable
		{
			[Token(Token = "0x601152B")]
			[Address(RVA = "0x921010", Offset = "0x91FC10", VA = "0x180921010")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x0601152C RID: 70956 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601152C")]
		[Address(RVA = "0x91EB40", Offset = "0x91D740", VA = "0x18091EB40", Slot = "5")]
		public override void AssignData(Blackboard blackboard)
		{
		}

		// Token: 0x0601152D RID: 70957 RVA: 0x0006AAE8 File Offset: 0x00068CE8
		[Token(Token = "0x601152D")]
		[Address(RVA = "0x91EF30", Offset = "0x91DB30", VA = "0x18091EF30")]
		private ChantBeforeSkill.AnimationBundle GetAnimationBundle()
		{
			return default(ChantBeforeSkill.AnimationBundle);
		}

		// Token: 0x0601152E RID: 70958 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601152E")]
		[Address(RVA = "0x91F3C0", Offset = "0x91DFC0", VA = "0x18091F3C0")]
		public void ReplaceAnimationBundle(string beginAnim, string loopAnim, string endAnim)
		{
		}

		// Token: 0x0601152F RID: 70959 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601152F")]
		[Address(RVA = "0x91EC30", Offset = "0x91D830", VA = "0x18091EC30")]
		public void ClearReplaceAnimationBundle()
		{
		}

		// Token: 0x06011530 RID: 70960 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011530")]
		[Address(RVA = "0x91F160", Offset = "0x91DD60", VA = "0x18091F160", Slot = "14")]
		public override void OnTick(FP deltaTime)
		{
		}

		// Token: 0x06011531 RID: 70961 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011531")]
		[Address(RVA = "0x91F070", Offset = "0x91DC70", VA = "0x18091F070", Slot = "6")]
		public override void OnCastSucceed()
		{
		}

		// Token: 0x06011532 RID: 70962 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011532")]
		[Address(RVA = "0x91F0E0", Offset = "0x91DCE0", VA = "0x18091F0E0", Slot = "10")]
		public override void OnSkillEnd()
		{
		}

		// Token: 0x06011533 RID: 70963 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6011533")]
		[Address(RVA = "0x91F4E0", Offset = "0x91E0E0", VA = "0x18091F4E0")]
		public IEnumerator StartChant()
		{
			return null;
		}

		// Token: 0x06011534 RID: 70964 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011534")]
		[Address(RVA = "0x91FBA0", Offset = "0x91E7A0", VA = "0x18091FBA0")]
		private void _OnChantStart()
		{
		}

		// Token: 0x06011535 RID: 70965 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011535")]
		[Address(RVA = "0x91F840", Offset = "0x91E440", VA = "0x18091F840")]
		private void _OnChantEnd()
		{
		}

		// Token: 0x06011536 RID: 70966 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011536")]
		[Address(RVA = "0x91FF40", Offset = "0x91EB40", VA = "0x18091FF40")]
		private void _OnMainChantSucceed()
		{
		}

		// Token: 0x06011537 RID: 70967 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011537")]
		[Address(RVA = "0x91FDF0", Offset = "0x91E9F0", VA = "0x18091FDF0")]
		private void _OnExtraChantSucceed()
		{
		}

		// Token: 0x06011538 RID: 70968 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011538")]
		[Address(RVA = "0x91EFF0", Offset = "0x91DBF0", VA = "0x18091EFF0")]
		public void InterruptChantIfNot()
		{
		}

		// Token: 0x06011539 RID: 70969 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011539")]
		[Address(RVA = "0x920A20", Offset = "0x91F620", VA = "0x180920A20")]
		public void _ResetChant()
		{
		}

		// Token: 0x0601153A RID: 70970 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601153A")]
		[Address(RVA = "0x91F5B0", Offset = "0x91E1B0", VA = "0x18091F5B0")]
		private void _ClearBuffs()
		{
		}

		// Token: 0x0601153B RID: 70971 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601153B")]
		[Address(RVA = "0x9207A0", Offset = "0x91F3A0", VA = "0x1809207A0")]
		private void _PlayMainChantEffects()
		{
		}

		// Token: 0x0601153C RID: 70972 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601153C")]
		[Address(RVA = "0x920520", Offset = "0x91F120", VA = "0x180920520")]
		private void _PlayExtraChantEffects()
		{
		}

		// Token: 0x0601153D RID: 70973 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601153D")]
		[Address(RVA = "0x920080", Offset = "0x91EC80", VA = "0x180920080")]
		private void _PlayBeforeEndEffects()
		{
		}

		// Token: 0x0601153E RID: 70974 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601153E")]
		[Address(RVA = "0x9202D0", Offset = "0x91EED0", VA = "0x1809202D0")]
		private void _PlayChantSuccessEffects()
		{
		}

		// Token: 0x0601153F RID: 70975 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601153F")]
		[Address(RVA = "0x91F6A0", Offset = "0x91E2A0", VA = "0x18091F6A0")]
		private void _ClearChantDuringEffects()
		{
		}

		// Token: 0x06011540 RID: 70976 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011540")]
		[Address(RVA = "0x920AB0", Offset = "0x91F6B0", VA = "0x180920AB0")]
		public ChantBeforeSkill()
		{
		}

		// Token: 0x06011541 RID: 70977 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011541")]
		[Address(RVA = "0x91F590", Offset = "0x91E190", VA = "0x18091F590")]
		private void <>xLuaBaseProxy_AssignData(Blackboard P0)
		{
		}

		// Token: 0x06011542 RID: 70978 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011542")]
		[Address(RVA = "0x91E1E0", Offset = "0x91CDE0", VA = "0x18091E1E0")]
		private void <>xLuaBaseProxy_OnTick(FP P0)
		{
		}

		// Token: 0x06011543 RID: 70979 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011543")]
		[Address(RVA = "0x91F5A0", Offset = "0x91E1A0", VA = "0x18091F5A0")]
		private void <>xLuaBaseProxy_OnCastSucceed()
		{
		}

		// Token: 0x06011544 RID: 70980 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011544")]
		[Address(RVA = "0x91D770", Offset = "0x91C370", VA = "0x18091D770")]
		private void <>xLuaBaseProxy_OnSkillEnd()
		{
		}

		// Token: 0x040135B1 RID: 79281
		[Token(Token = "0x40135B1")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private ChantBeforeSkill.AnimationBundle _animation;

		// Token: 0x040135B2 RID: 79282
		[Token(Token = "0x40135B2")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private bool _suspendableWhenMainChant;

		// Token: 0x040135B3 RID: 79283
		[Token(Token = "0x40135B3")]
		[FieldOffset(Offset = "0x39")]
		[SerializeField]
		private bool _suspendableWhenExtraChant;

		// Token: 0x040135B4 RID: 79284
		[Token(Token = "0x40135B4")]
		[FieldOffset(Offset = "0x3A")]
		[SerializeField]
		private bool _finishBuffWhenSkillEnd;

		// Token: 0x040135B5 RID: 79285
		[Token(Token = "0x40135B5")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private BuffData[] _buffsWhenStartChant;

		// Token: 0x040135B6 RID: 79286
		[Token(Token = "0x40135B6")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private BuffData[] _buffsWhenMainChantEnd;

		// Token: 0x040135B7 RID: 79287
		[Token(Token = "0x40135B7")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private BuffData[] _buffsWhenExtraChantEnd;

		// Token: 0x040135B8 RID: 79288
		[Token(Token = "0x40135B8")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private string[] _mainChantEffects;

		// Token: 0x040135B9 RID: 79289
		[Token(Token = "0x40135B9")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private string[] _extraChantEffects;

		// Token: 0x040135BA RID: 79290
		[Token(Token = "0x40135BA")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private string[] _chantSuccessEffects;

		// Token: 0x040135BB RID: 79291
		[Token(Token = "0x40135BB")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private string[] _beforeEndEffects;

		// Token: 0x040135BC RID: 79292
		[Token(Token = "0x40135BC")]
		[FieldOffset(Offset = "0x78")]
		private bool m_started;

		// Token: 0x040135BD RID: 79293
		[Token(Token = "0x40135BD")]
		[FieldOffset(Offset = "0x7C")]
		private float m_duration;

		// Token: 0x040135BE RID: 79294
		[Token(Token = "0x40135BE")]
		[FieldOffset(Offset = "0x80")]
		private float m_extraDuration;

		// Token: 0x040135BF RID: 79295
		[Token(Token = "0x40135BF")]
		[FieldOffset(Offset = "0x84")]
		private float m_totalDuration;

		// Token: 0x040135C0 RID: 79296
		[Token(Token = "0x40135C0")]
		[FieldOffset(Offset = "0x88")]
		private PeriodicTimer m_durationTimer;

		// Token: 0x040135C1 RID: 79297
		[Token(Token = "0x40135C1")]
		[FieldOffset(Offset = "0x90")]
		private PeriodicTimer m_extraDurationTimer;

		// Token: 0x040135C2 RID: 79298
		[Token(Token = "0x40135C2")]
		[FieldOffset(Offset = "0x98")]
		private List<uint> m_buffUids;

		// Token: 0x040135C3 RID: 79299
		[Token(Token = "0x40135C3")]
		[FieldOffset(Offset = "0xA0")]
		private List<Effect> m_mainChantEffectList;

		// Token: 0x040135C4 RID: 79300
		[Token(Token = "0x40135C4")]
		[FieldOffset(Offset = "0xA8")]
		private List<Effect> m_extraChantEffectList;

		// Token: 0x040135C5 RID: 79301
		[Token(Token = "0x40135C5")]
		[FieldOffset(Offset = "0xB0")]
		private AudioAtom[] m_atoms;

		// Token: 0x040135C6 RID: 79302
		[Token(Token = "0x40135C6")]
		[FieldOffset(Offset = "0xB8")]
		private bool m_isReplaceAnimation;

		// Token: 0x040135C7 RID: 79303
		[Token(Token = "0x40135C7")]
		[FieldOffset(Offset = "0xC0")]
		private ChantBeforeSkill.AnimationBundle m_replaceAnimation;

		// Token: 0x040135C8 RID: 79304
		[Token(Token = "0x40135C8")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GatherBuffs;

		// Token: 0x040135C9 RID: 79305
		[Token(Token = "0x40135C9")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_GatherEffects;

		// Token: 0x040135CA RID: 79306
		[Token(Token = "0x40135CA")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_chantProgress;

		// Token: 0x040135CB RID: 79307
		[Token(Token = "0x40135CB")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_get_isInChant;

		// Token: 0x040135CC RID: 79308
		[Token(Token = "0x40135CC")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_get_isInExtraChant;

		// Token: 0x040135CD RID: 79309
		[Token(Token = "0x40135CD")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_get_chantAvailable;

		// Token: 0x040135CE RID: 79310
		[Token(Token = "0x40135CE")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_get_suspendable;

		// Token: 0x040135CF RID: 79311
		[Token(Token = "0x40135CF")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_AssignData;

		// Token: 0x040135D0 RID: 79312
		[Token(Token = "0x40135D0")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_GetAnimationBundle;

		// Token: 0x040135D1 RID: 79313
		[Token(Token = "0x40135D1")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_ReplaceAnimationBundle;

		// Token: 0x040135D2 RID: 79314
		[Token(Token = "0x40135D2")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_ClearReplaceAnimationBundle;

		// Token: 0x040135D3 RID: 79315
		[Token(Token = "0x40135D3")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_OnTick;

		// Token: 0x040135D4 RID: 79316
		[Token(Token = "0x40135D4")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0_OnCastSucceed;

		// Token: 0x040135D5 RID: 79317
		[Token(Token = "0x40135D5")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0_OnSkillEnd;

		// Token: 0x040135D6 RID: 79318
		[Token(Token = "0x40135D6")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0_StartChant;

		// Token: 0x040135D7 RID: 79319
		[Token(Token = "0x40135D7")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0__OnChantStart;

		// Token: 0x040135D8 RID: 79320
		[Token(Token = "0x40135D8")]
		[FieldOffset(Offset = "0x80")]
		private static DelegateBridge __Hotfix0__OnChantEnd;

		// Token: 0x040135D9 RID: 79321
		[Token(Token = "0x40135D9")]
		[FieldOffset(Offset = "0x88")]
		private static DelegateBridge __Hotfix0__OnMainChantSucceed;

		// Token: 0x040135DA RID: 79322
		[Token(Token = "0x40135DA")]
		[FieldOffset(Offset = "0x90")]
		private static DelegateBridge __Hotfix0__OnExtraChantSucceed;

		// Token: 0x040135DB RID: 79323
		[Token(Token = "0x40135DB")]
		[FieldOffset(Offset = "0x98")]
		private static DelegateBridge __Hotfix0_InterruptChantIfNot;

		// Token: 0x040135DC RID: 79324
		[Token(Token = "0x40135DC")]
		[FieldOffset(Offset = "0xA0")]
		private static DelegateBridge __Hotfix0__ResetChant;

		// Token: 0x040135DD RID: 79325
		[Token(Token = "0x40135DD")]
		[FieldOffset(Offset = "0xA8")]
		private static DelegateBridge __Hotfix0__ClearBuffs;

		// Token: 0x040135DE RID: 79326
		[Token(Token = "0x40135DE")]
		[FieldOffset(Offset = "0xB0")]
		private static DelegateBridge __Hotfix0__PlayMainChantEffects;

		// Token: 0x040135DF RID: 79327
		[Token(Token = "0x40135DF")]
		[FieldOffset(Offset = "0xB8")]
		private static DelegateBridge __Hotfix0__PlayExtraChantEffects;

		// Token: 0x040135E0 RID: 79328
		[Token(Token = "0x40135E0")]
		[FieldOffset(Offset = "0xC0")]
		private static DelegateBridge __Hotfix0__PlayBeforeEndEffects;

		// Token: 0x040135E1 RID: 79329
		[Token(Token = "0x40135E1")]
		[FieldOffset(Offset = "0xC8")]
		private static DelegateBridge __Hotfix0__PlayChantSuccessEffects;

		// Token: 0x040135E2 RID: 79330
		[Token(Token = "0x40135E2")]
		[FieldOffset(Offset = "0xD0")]
		private static DelegateBridge __Hotfix0__ClearChantDuringEffects;

		// Token: 0x040135E3 RID: 79331
		[Token(Token = "0x40135E3")]
		[FieldOffset(Offset = "0xD8")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x020028B4 RID: 10420
		[Token(Token = "0x20028B4")]
		[Serializable]
		public struct AnimationBundle
		{
			// Token: 0x040135E4 RID: 79332
			[Token(Token = "0x40135E4")]
			[FieldOffset(Offset = "0x0")]
			public string beginAnim;

			// Token: 0x040135E5 RID: 79333
			[Token(Token = "0x40135E5")]
			[FieldOffset(Offset = "0x8")]
			public string loopAnim;

			// Token: 0x040135E6 RID: 79334
			[Token(Token = "0x40135E6")]
			[FieldOffset(Offset = "0x10")]
			public string endAnim;
		}
	}
}

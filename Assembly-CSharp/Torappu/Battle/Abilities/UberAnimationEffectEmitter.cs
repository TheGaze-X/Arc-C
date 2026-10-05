using System;
using System.Collections.Generic;
using AdvancedInspector;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Battle.Abilities
{
	// Token: 0x02002BFF RID: 11263
	[Token(Token = "0x2002BFF")]
	[RequireComponent(typeof(AbstractAnimatedAbility))]
	public class UberAnimationEffectEmitter : UberEffectEmitter
	{
		// Token: 0x06013061 RID: 77921 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6013061")]
		[Address(RVA = "0xAEDC30", Offset = "0xAEC830", VA = "0x180AEDC30", Slot = "6")]
		public override void SetData(Blackboard blackboard)
		{
		}

		// Token: 0x06013062 RID: 77922 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6013062")]
		[Address(RVA = "0xAED120", Offset = "0xAEBD20", VA = "0x180AED120", Slot = "5")]
		public override void Init(AbilityStandard ability)
		{
		}

		// Token: 0x06013063 RID: 77923 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6013063")]
		[Address(RVA = "0xAED700", Offset = "0xAEC300", VA = "0x180AED700", Slot = "7")]
		public override void OnCastStart()
		{
		}

		// Token: 0x06013064 RID: 77924 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6013064")]
		[Address(RVA = "0xAED380", Offset = "0xAEBF80", VA = "0x180AED380", Slot = "9")]
		public override void OnCastFinish(Ability.FinishReason reason)
		{
		}

		// Token: 0x06013065 RID: 77925 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6013065")]
		[Address(RVA = "0xAED4D0", Offset = "0xAEC0D0", VA = "0x180AED4D0", Slot = "11")]
		public override void OnCastOnTarget(Entity target)
		{
		}

		// Token: 0x06013066 RID: 77926 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6013066")]
		[Address(RVA = "0xAEDA40", Offset = "0xAEC640", VA = "0x180AEDA40", Slot = "10")]
		public override void OnEvent(AbilityStandard.Event ev)
		{
		}

		// Token: 0x06013067 RID: 77927 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6013067")]
		[Address(RVA = "0xAECEC0", Offset = "0xAEBAC0", VA = "0x180AECEC0", Slot = "17")]
		public override void GatherEffects(List<string> effects)
		{
		}

		// Token: 0x06013068 RID: 77928 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6013068")]
		[Address(RVA = "0xAEDDB0", Offset = "0xAEC9B0", VA = "0x180AEDDB0")]
		private void _CalculatePlayIndex()
		{
		}

		// Token: 0x06013069 RID: 77929 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6013069")]
		[Address(RVA = "0xAEDED0", Offset = "0xAECAD0", VA = "0x180AEDED0")]
		public UberAnimationEffectEmitter()
		{
		}

		// Token: 0x0601306A RID: 77930 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601306A")]
		[Address(RVA = "0xAC3250", Offset = "0xAC1E50", VA = "0x180AC3250")]
		private void <>xLuaBaseProxy_SetData(Blackboard P0)
		{
		}

		// Token: 0x0601306B RID: 77931 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601306B")]
		[Address(RVA = "0xAE6DD0", Offset = "0xAE59D0", VA = "0x180AE6DD0")]
		private void <>xLuaBaseProxy_Init(AbilityStandard P0)
		{
		}

		// Token: 0x0601306C RID: 77932 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601306C")]
		[Address(RVA = "0xAE6E00", Offset = "0xAE5A00", VA = "0x180AE6E00")]
		private void <>xLuaBaseProxy_OnCastStart()
		{
		}

		// Token: 0x0601306D RID: 77933 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601306D")]
		[Address(RVA = "0xAE6DE0", Offset = "0xAE59E0", VA = "0x180AE6DE0")]
		private void <>xLuaBaseProxy_OnCastFinish(Ability.FinishReason P0)
		{
		}

		// Token: 0x0601306E RID: 77934 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601306E")]
		[Address(RVA = "0xAE6DF0", Offset = "0xAE59F0", VA = "0x180AE6DF0")]
		private void <>xLuaBaseProxy_OnCastOnTarget(Entity P0)
		{
		}

		// Token: 0x0601306F RID: 77935 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601306F")]
		[Address(RVA = "0xAE6E10", Offset = "0xAE5A10", VA = "0x180AE6E10")]
		private void <>xLuaBaseProxy_OnEvent(AbilityStandard.Event P0)
		{
		}

		// Token: 0x06013070 RID: 77936 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6013070")]
		[Address(RVA = "0xAE6DC0", Offset = "0xAE59C0", VA = "0x180AE6DC0")]
		private void <>xLuaBaseProxy_GatherEffects(List<string> P0)
		{
		}

		// Token: 0x040157D0 RID: 88016
		[Token(Token = "0x40157D0")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		[Group("ReplaceAnimationGroup")]
		private string _sourceAnimKey;

		// Token: 0x040157D1 RID: 88017
		[Token(Token = "0x40157D1")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		[Group("ReplaceAnimationGroup")]
		private UberAnimationEffectEmitter.LoopType _loopType;

		// Token: 0x040157D2 RID: 88018
		[Token(Token = "0x40157D2")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		[Group("ReplaceAnimationGroup")]
		private List<UberAnimationEffectEmitter.AnimationEffectPair> _replaceGroup;

		// Token: 0x040157D3 RID: 88019
		[Token(Token = "0x40157D3")]
		[FieldOffset(Offset = "0x70")]
		private AbstractAnimatedAbility m_animatedAbility;

		// Token: 0x040157D4 RID: 88020
		[Token(Token = "0x40157D4")]
		[FieldOffset(Offset = "0x78")]
		private int m_currentIndex;

		// Token: 0x040157D5 RID: 88021
		[Token(Token = "0x40157D5")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_SetData;

		// Token: 0x040157D6 RID: 88022
		[Token(Token = "0x40157D6")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_Init;

		// Token: 0x040157D7 RID: 88023
		[Token(Token = "0x40157D7")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnCastStart;

		// Token: 0x040157D8 RID: 88024
		[Token(Token = "0x40157D8")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnCastFinish;

		// Token: 0x040157D9 RID: 88025
		[Token(Token = "0x40157D9")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_OnCastOnTarget;

		// Token: 0x040157DA RID: 88026
		[Token(Token = "0x40157DA")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_OnEvent;

		// Token: 0x040157DB RID: 88027
		[Token(Token = "0x40157DB")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_GatherEffects;

		// Token: 0x040157DC RID: 88028
		[Token(Token = "0x40157DC")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__CalculatePlayIndex;

		// Token: 0x040157DD RID: 88029
		[Token(Token = "0x40157DD")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02002C00 RID: 11264
		[Token(Token = "0x2002C00")]
		public enum LoopType
		{
			// Token: 0x040157DF RID: 88031
			[Token(Token = "0x40157DF")]
			LOOP,
			// Token: 0x040157E0 RID: 88032
			[Token(Token = "0x40157E0")]
			RANDOM
		}

		// Token: 0x02002C01 RID: 11265
		[Token(Token = "0x2002C01")]
		[Serializable]
		public struct AnimationEffectPair
		{
			// Token: 0x040157E1 RID: 88033
			[Token(Token = "0x40157E1")]
			[FieldOffset(Offset = "0x0")]
			public string anim;

			// Token: 0x040157E2 RID: 88034
			[Token(Token = "0x40157E2")]
			[FieldOffset(Offset = "0x8")]
			public UberEffectEmitter.CastEffectOptions[] effectOptions;

			// Token: 0x040157E3 RID: 88035
			[Token(Token = "0x40157E3")]
			[FieldOffset(Offset = "0x10")]
			public UberEffectEmitter.HitEffectOptions[] hitEffectOptions;
		}
	}
}

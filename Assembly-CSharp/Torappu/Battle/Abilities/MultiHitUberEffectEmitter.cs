using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Battle.Abilities
{
	// Token: 0x02002BF3 RID: 11251
	[Token(Token = "0x2002BF3")]
	public class MultiHitUberEffectEmitter : UberEffectEmitter
	{
		// Token: 0x0601300D RID: 77837 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601300D")]
		[Address(RVA = "0xAE7BE0", Offset = "0xAE67E0", VA = "0x180AE7BE0", Slot = "5")]
		public override void Init(AbilityStandard ability)
		{
		}

		// Token: 0x0601300E RID: 77838 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601300E")]
		[Address(RVA = "0xAE81F0", Offset = "0xAE6DF0", VA = "0x180AE81F0", Slot = "7")]
		public override void OnCastStart()
		{
		}

		// Token: 0x0601300F RID: 77839 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601300F")]
		[Address(RVA = "0xAE7DD0", Offset = "0xAE69D0", VA = "0x180AE7DD0", Slot = "9")]
		public override void OnCastFinish(Ability.FinishReason reason)
		{
		}

		// Token: 0x06013010 RID: 77840 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6013010")]
		[Address(RVA = "0xAE7FD0", Offset = "0xAE6BD0", VA = "0x180AE7FD0", Slot = "11")]
		public override void OnCastOnTarget(Entity target)
		{
		}

		// Token: 0x06013011 RID: 77841 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6013011")]
		[Address(RVA = "0xAE83D0", Offset = "0xAE6FD0", VA = "0x180AE83D0", Slot = "10")]
		public override void OnEvent(AbilityStandard.Event ev)
		{
		}

		// Token: 0x06013012 RID: 77842 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6013012")]
		[Address(RVA = "0xAE79E0", Offset = "0xAE65E0", VA = "0x180AE79E0", Slot = "17")]
		public override void GatherEffects(List<string> effects)
		{
		}

		// Token: 0x06013013 RID: 77843 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6013013")]
		[Address(RVA = "0xAE8560", Offset = "0xAE7160", VA = "0x180AE8560")]
		public MultiHitUberEffectEmitter()
		{
		}

		// Token: 0x06013014 RID: 77844 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6013014")]
		[Address(RVA = "0xAE6DD0", Offset = "0xAE59D0", VA = "0x180AE6DD0")]
		private void <>xLuaBaseProxy_Init(AbilityStandard P0)
		{
		}

		// Token: 0x06013015 RID: 77845 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6013015")]
		[Address(RVA = "0xAE6E00", Offset = "0xAE5A00", VA = "0x180AE6E00")]
		private void <>xLuaBaseProxy_OnCastStart()
		{
		}

		// Token: 0x06013016 RID: 77846 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6013016")]
		[Address(RVA = "0xAE6DE0", Offset = "0xAE59E0", VA = "0x180AE6DE0")]
		private void <>xLuaBaseProxy_OnCastFinish(Ability.FinishReason P0)
		{
		}

		// Token: 0x06013017 RID: 77847 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6013017")]
		[Address(RVA = "0xAE6DF0", Offset = "0xAE59F0", VA = "0x180AE6DF0")]
		private void <>xLuaBaseProxy_OnCastOnTarget(Entity P0)
		{
		}

		// Token: 0x06013018 RID: 77848 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6013018")]
		[Address(RVA = "0xAE6E10", Offset = "0xAE5A10", VA = "0x180AE6E10")]
		private void <>xLuaBaseProxy_OnEvent(AbilityStandard.Event P0)
		{
		}

		// Token: 0x06013019 RID: 77849 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6013019")]
		[Address(RVA = "0xAE6DC0", Offset = "0xAE59C0", VA = "0x180AE6DC0")]
		private void <>xLuaBaseProxy_GatherEffects(List<string> P0)
		{
		}

		// Token: 0x04015762 RID: 87906
		[Token(Token = "0x4015762")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private bool _useRandomHitEffect;

		// Token: 0x04015763 RID: 87907
		[Token(Token = "0x4015763")]
		[FieldOffset(Offset = "0x59")]
		[SerializeField]
		private bool _useLoopHitEffect;

		// Token: 0x04015764 RID: 87908
		[Token(Token = "0x4015764")]
		[FieldOffset(Offset = "0x5A")]
		[SerializeField]
		private bool _keepBaseHitEffect;

		// Token: 0x04015765 RID: 87909
		[Token(Token = "0x4015765")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private MultiHitUberEffectEmitter.HitEffectGroup[] _hitGroups;

		// Token: 0x04015766 RID: 87910
		[Token(Token = "0x4015766")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private MultiHitUberEffectEmitter.CastEffectGroup[] _castGroups;

		// Token: 0x04015767 RID: 87911
		[Token(Token = "0x4015767")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Init;

		// Token: 0x04015768 RID: 87912
		[Token(Token = "0x4015768")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnCastStart;

		// Token: 0x04015769 RID: 87913
		[Token(Token = "0x4015769")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnCastFinish;

		// Token: 0x0401576A RID: 87914
		[Token(Token = "0x401576A")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnCastOnTarget;

		// Token: 0x0401576B RID: 87915
		[Token(Token = "0x401576B")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_OnEvent;

		// Token: 0x0401576C RID: 87916
		[Token(Token = "0x401576C")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_GatherEffects;

		// Token: 0x0401576D RID: 87917
		[Token(Token = "0x401576D")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02002BF4 RID: 11252
		[Token(Token = "0x2002BF4")]
		[Serializable]
		public struct HitEffectGroup
		{
			// Token: 0x0601301A RID: 77850 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x601301A")]
			[Address(RVA = "0xAE5350", Offset = "0xAE3F50", VA = "0x180AE5350", Slot = "3")]
			public override string ToString()
			{
				return null;
			}

			// Token: 0x0401576E RID: 87918
			[Token(Token = "0x401576E")]
			[FieldOffset(Offset = "0x0")]
			public UberEffectEmitter.HitEffectOptions[] effects;
		}

		// Token: 0x02002BF5 RID: 11253
		[Token(Token = "0x2002BF5")]
		[Serializable]
		public struct CastEffectGroup
		{
			// Token: 0x0601301B RID: 77851 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x601301B")]
			[Address(RVA = "0xADE940", Offset = "0xADD540", VA = "0x180ADE940", Slot = "3")]
			public override string ToString()
			{
				return null;
			}

			// Token: 0x0401576F RID: 87919
			[Token(Token = "0x401576F")]
			[FieldOffset(Offset = "0x0")]
			public UberEffectEmitter.CastEffectOptions[] castEffects;
		}
	}
}

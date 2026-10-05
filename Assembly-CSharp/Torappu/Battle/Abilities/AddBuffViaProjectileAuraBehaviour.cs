using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Battle.Abilities
{
	// Token: 0x02002C11 RID: 11281
	[Token(Token = "0x2002C11")]
	public class AddBuffViaProjectileAuraBehaviour : ProjectileAuraAbility.ProjectileAuraBehaviour, IEffectSource, IBuffSource
	{
		// Token: 0x060130D3 RID: 78035 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60130D3")]
		[Address(RVA = "0xB13C70", Offset = "0xB12870", VA = "0x180B13C70", Slot = "5")]
		public override void Init(AbilityStandard ability)
		{
		}

		// Token: 0x060130D4 RID: 78036 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60130D4")]
		[Address(RVA = "0xB13EA0", Offset = "0xB12AA0", VA = "0x180B13EA0", Slot = "16")]
		public override void OnTick(FP deltaTime)
		{
		}

		// Token: 0x060130D5 RID: 78037 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60130D5")]
		[Address(RVA = "0xB13C00", Offset = "0xB12800", VA = "0x180B13C00", Slot = "19")]
		public void GatherEffects(List<string> effects)
		{
		}

		// Token: 0x060130D6 RID: 78038 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60130D6")]
		[Address(RVA = "0xB13B70", Offset = "0xB12770", VA = "0x180B13B70", Slot = "20")]
		public void GatherBuffs(List<BuffData> results)
		{
		}

		// Token: 0x060130D7 RID: 78039 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60130D7")]
		[Address(RVA = "0xB14150", Offset = "0xB12D50", VA = "0x180B14150")]
		private void _ClearBuffs()
		{
		}

		// Token: 0x060130D8 RID: 78040 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60130D8")]
		[Address(RVA = "0xB14240", Offset = "0xB12E40", VA = "0x180B14240")]
		public AddBuffViaProjectileAuraBehaviour()
		{
		}

		// Token: 0x060130D9 RID: 78041 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60130D9")]
		[Address(RVA = "0xAE3FD0", Offset = "0xAE2BD0", VA = "0x180AE3FD0")]
		private void <>xLuaBaseProxy_Init(AbilityStandard P0)
		{
		}

		// Token: 0x060130DA RID: 78042 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60130DA")]
		[Address(RVA = "0xB14140", Offset = "0xB12D40", VA = "0x180B14140")]
		private void <>xLuaBaseProxy_OnTick(FP P0)
		{
		}

		// Token: 0x0401583A RID: 88122
		[Token(Token = "0x401583A")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private BuffData[] _buffs;

		// Token: 0x0401583B RID: 88123
		[Token(Token = "0x401583B")]
		[FieldOffset(Offset = "0x28")]
		private ProjectileAuraAbility m_auraAbility;

		// Token: 0x0401583C RID: 88124
		[Token(Token = "0x401583C")]
		[FieldOffset(Offset = "0x30")]
		private List<uint> m_buffUid;

		// Token: 0x0401583D RID: 88125
		[Token(Token = "0x401583D")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Init;

		// Token: 0x0401583E RID: 88126
		[Token(Token = "0x401583E")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnTick;

		// Token: 0x0401583F RID: 88127
		[Token(Token = "0x401583F")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_GatherEffects;

		// Token: 0x04015840 RID: 88128
		[Token(Token = "0x4015840")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_GatherBuffs;

		// Token: 0x04015841 RID: 88129
		[Token(Token = "0x4015841")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__ClearBuffs;

		// Token: 0x04015842 RID: 88130
		[Token(Token = "0x4015842")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}

using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Battle.Abilities
{
	// Token: 0x02002C22 RID: 11298
	[Token(Token = "0x2002C22")]
	public class ProjectileProbElimateBehaviour : ProjectileAuraAbility.ProjectileAuraBehaviour
	{
		// Token: 0x06013148 RID: 78152 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6013148")]
		[Address(RVA = "0xB20E50", Offset = "0xB1FA50", VA = "0x180B20E50", Slot = "6")]
		public override void SetData(Blackboard blackboard)
		{
		}

		// Token: 0x06013149 RID: 78153 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6013149")]
		[Address(RVA = "0xB20AE0", Offset = "0xB1F6E0", VA = "0x180B20AE0", Slot = "17")]
		public override void OnProjectileEnter(Projectile projectile)
		{
		}

		// Token: 0x0601314A RID: 78154 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601314A")]
		[Address(RVA = "0xB20C30", Offset = "0xB1F830", VA = "0x180B20C30", Slot = "18")]
		public override void OnProjectileExit(Projectile projectile)
		{
		}

		// Token: 0x0601314B RID: 78155 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601314B")]
		[Address(RVA = "0xB20F40", Offset = "0xB1FB40", VA = "0x180B20F40")]
		private void _DoElimateProjectile(Projectile projectile)
		{
		}

		// Token: 0x0601314C RID: 78156 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601314C")]
		[Address(RVA = "0xB20D80", Offset = "0xB1F980", VA = "0x180B20D80", Slot = "15")]
		public override void PreloadSpecialAudioSignals(string abilityId, string tmplId, Action<string, string> preloader)
		{
		}

		// Token: 0x0601314D RID: 78157 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601314D")]
		[Address(RVA = "0xB21110", Offset = "0xB1FD10", VA = "0x180B21110")]
		public ProjectileProbElimateBehaviour()
		{
		}

		// Token: 0x0601314E RID: 78158 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601314E")]
		[Address(RVA = "0xAC3250", Offset = "0xAC1E50", VA = "0x180AC3250")]
		private void <>xLuaBaseProxy_SetData(Blackboard P0)
		{
		}

		// Token: 0x0601314F RID: 78159 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601314F")]
		[Address(RVA = "0xB1A990", Offset = "0xB19590", VA = "0x180B1A990")]
		private void <>xLuaBaseProxy_OnProjectileEnter(Projectile P0)
		{
		}

		// Token: 0x06013150 RID: 78160 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6013150")]
		[Address(RVA = "0xB1A9A0", Offset = "0xB195A0", VA = "0x180B1A9A0")]
		private void <>xLuaBaseProxy_OnProjectileExit(Projectile P0)
		{
		}

		// Token: 0x06013151 RID: 78161 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6013151")]
		[Address(RVA = "0xADA610", Offset = "0xAD9210", VA = "0x180ADA610")]
		private void <>xLuaBaseProxy_PreloadSpecialAudioSignals(string P0, string P1, Action<string, string> P2)
		{
		}

		// Token: 0x040158B8 RID: 88248
		[Token(Token = "0x40158B8")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private bool _eliminateOnEnter;

		// Token: 0x040158B9 RID: 88249
		[Token(Token = "0x40158B9")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private string _effectOnEliminatePos;

		// Token: 0x040158BA RID: 88250
		[Token(Token = "0x40158BA")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private string _audioSignalWhenEliminate;

		// Token: 0x040158BB RID: 88251
		[Token(Token = "0x40158BB")]
		[FieldOffset(Offset = "0x38")]
		private FP m_prob;

		// Token: 0x040158BC RID: 88252
		[Token(Token = "0x40158BC")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_SetData;

		// Token: 0x040158BD RID: 88253
		[Token(Token = "0x40158BD")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnProjectileEnter;

		// Token: 0x040158BE RID: 88254
		[Token(Token = "0x40158BE")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnProjectileExit;

		// Token: 0x040158BF RID: 88255
		[Token(Token = "0x40158BF")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__DoElimateProjectile;

		// Token: 0x040158C0 RID: 88256
		[Token(Token = "0x40158C0")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_PreloadSpecialAudioSignals;

		// Token: 0x040158C1 RID: 88257
		[Token(Token = "0x40158C1")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}

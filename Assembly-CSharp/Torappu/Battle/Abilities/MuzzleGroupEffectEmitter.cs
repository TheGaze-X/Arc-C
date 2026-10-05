using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Battle.Abilities
{
	// Token: 0x02002BF6 RID: 11254
	[Token(Token = "0x2002BF6")]
	[RequireComponent(typeof(RangedAttack))]
	public class MuzzleGroupEffectEmitter : AbstractEffectEmitter
	{
		// Token: 0x0601301C RID: 77852 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601301C")]
		[Address(RVA = "0xAE8660", Offset = "0xAE7260", VA = "0x180AE8660", Slot = "5")]
		public override void Init(AbilityStandard ability)
		{
		}

		// Token: 0x0601301D RID: 77853 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601301D")]
		[Address(RVA = "0xAE87C0", Offset = "0xAE73C0", VA = "0x180AE87C0", Slot = "10")]
		public override void OnEvent(AbilityStandard.Event ev)
		{
		}

		// Token: 0x0601301E RID: 77854 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601301E")]
		[Address(RVA = "0xAE85C0", Offset = "0xAE71C0", VA = "0x180AE85C0", Slot = "17")]
		public override void GatherEffects(List<string> effects)
		{
		}

		// Token: 0x0601301F RID: 77855 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601301F")]
		[Address(RVA = "0xAE8A50", Offset = "0xAE7650", VA = "0x180AE8A50")]
		public MuzzleGroupEffectEmitter()
		{
		}

		// Token: 0x06013020 RID: 77856 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6013020")]
		[Address(RVA = "0xAE3FD0", Offset = "0xAE2BD0", VA = "0x180AE3FD0")]
		private void <>xLuaBaseProxy_Init(AbilityStandard P0)
		{
		}

		// Token: 0x06013021 RID: 77857 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6013021")]
		[Address(RVA = "0xAC2A40", Offset = "0xAC1640", VA = "0x180AC2A40")]
		private void <>xLuaBaseProxy_OnEvent(AbilityStandard.Event P0)
		{
		}

		// Token: 0x04015770 RID: 87920
		[Token(Token = "0x4015770")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private string _muzzleEffect;

		// Token: 0x04015771 RID: 87921
		[Token(Token = "0x4015771")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private AbilityStandard.Event _event;

		// Token: 0x04015772 RID: 87922
		[Token(Token = "0x4015772")]
		[FieldOffset(Offset = "0x30")]
		private RangedAttack m_rangedAttack;

		// Token: 0x04015773 RID: 87923
		[Token(Token = "0x4015773")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Init;

		// Token: 0x04015774 RID: 87924
		[Token(Token = "0x4015774")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnEvent;

		// Token: 0x04015775 RID: 87925
		[Token(Token = "0x4015775")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_GatherEffects;

		// Token: 0x04015776 RID: 87926
		[Token(Token = "0x4015776")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}

using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Battle.Abilities
{
	// Token: 0x02002BED RID: 11245
	[Token(Token = "0x2002BED")]
	public class EndAnimEffectEmitter : AbstractEffectEmitter
	{
		// Token: 0x06012FE3 RID: 77795 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012FE3")]
		[Address(RVA = "0xAE29C0", Offset = "0xAE15C0", VA = "0x180AE29C0", Slot = "10")]
		public override void OnEvent(AbilityStandard.Event ev)
		{
		}

		// Token: 0x06012FE4 RID: 77796 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012FE4")]
		[Address(RVA = "0xAE2AB0", Offset = "0xAE16B0", VA = "0x180AE2AB0")]
		private void _PlayEffectsInNextFrame()
		{
		}

		// Token: 0x06012FE5 RID: 77797 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012FE5")]
		[Address(RVA = "0xAE2930", Offset = "0xAE1530", VA = "0x180AE2930", Slot = "17")]
		public override void GatherEffects(List<string> effects)
		{
		}

		// Token: 0x06012FE6 RID: 77798 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012FE6")]
		[Address(RVA = "0xAE2D70", Offset = "0xAE1970", VA = "0x180AE2D70")]
		public EndAnimEffectEmitter()
		{
		}

		// Token: 0x06012FE7 RID: 77799 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012FE7")]
		[Address(RVA = "0xAC2A40", Offset = "0xAC1640", VA = "0x180AC2A40")]
		private void <>xLuaBaseProxy_OnEvent(AbilityStandard.Event P0)
		{
		}

		// Token: 0x04015730 RID: 87856
		[Token(Token = "0x4015730")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private string[] _effectKeys;

		// Token: 0x04015731 RID: 87857
		[Token(Token = "0x4015731")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnEvent;

		// Token: 0x04015732 RID: 87858
		[Token(Token = "0x4015732")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__PlayEffectsInNextFrame;

		// Token: 0x04015733 RID: 87859
		[Token(Token = "0x4015733")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_GatherEffects;

		// Token: 0x04015734 RID: 87860
		[Token(Token = "0x4015734")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}

using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.Battle.Effects;
using UnityEngine;
using XLua;

namespace Torappu.Battle.Abilities
{
	// Token: 0x02002C1D RID: 11293
	[Token(Token = "0x2002C1D")]
	public class PauseEffectDuringCasting : AbstractEffectEmitter
	{
		// Token: 0x06013127 RID: 78119 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6013127")]
		[Address(RVA = "0xB1D340", Offset = "0xB1BF40", VA = "0x180B1D340", Slot = "10")]
		public override void OnEvent(AbilityStandard.Event ev)
		{
		}

		// Token: 0x06013128 RID: 78120 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6013128")]
		[Address(RVA = "0xB1D2D0", Offset = "0xB1BED0", VA = "0x180B1D2D0", Slot = "9")]
		public override void OnCastFinish(Ability.FinishReason reason)
		{
		}

		// Token: 0x06013129 RID: 78121 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6013129")]
		[Address(RVA = "0xB1D500", Offset = "0xB1C100", VA = "0x180B1D500")]
		private void _OnPause()
		{
		}

		// Token: 0x0601312A RID: 78122 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601312A")]
		[Address(RVA = "0xB1D640", Offset = "0xB1C240", VA = "0x180B1D640")]
		private void _OnUnpause()
		{
		}

		// Token: 0x0601312B RID: 78123 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601312B")]
		[Address(RVA = "0xB1D230", Offset = "0xB1BE30", VA = "0x180B1D230", Slot = "17")]
		public override void GatherEffects(List<string> effects)
		{
		}

		// Token: 0x0601312C RID: 78124 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601312C")]
		[Address(RVA = "0xB1D720", Offset = "0xB1C320", VA = "0x180B1D720")]
		public PauseEffectDuringCasting()
		{
		}

		// Token: 0x0601312D RID: 78125 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601312D")]
		[Address(RVA = "0xAC2A40", Offset = "0xAC1640", VA = "0x180AC2A40")]
		private void <>xLuaBaseProxy_OnEvent(AbilityStandard.Event P0)
		{
		}

		// Token: 0x0601312E RID: 78126 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601312E")]
		[Address(RVA = "0xAC3FE0", Offset = "0xAC2BE0", VA = "0x180AC3FE0")]
		private void <>xLuaBaseProxy_OnCastFinish(Ability.FinishReason P0)
		{
		}

		// Token: 0x04015885 RID: 88197
		[Token(Token = "0x4015885")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private string _effect;

		// Token: 0x04015886 RID: 88198
		[Token(Token = "0x4015886")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private AbilityStandard.Event _startEv;

		// Token: 0x04015887 RID: 88199
		[Token(Token = "0x4015887")]
		[FieldOffset(Offset = "0x2C")]
		[SerializeField]
		private AbilityStandard.Event _endEv;

		// Token: 0x04015888 RID: 88200
		[Token(Token = "0x4015888")]
		[FieldOffset(Offset = "0x30")]
		private ObjectPtr<Effect> m_effectHolder;

		// Token: 0x04015889 RID: 88201
		[Token(Token = "0x4015889")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnEvent;

		// Token: 0x0401588A RID: 88202
		[Token(Token = "0x401588A")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnCastFinish;

		// Token: 0x0401588B RID: 88203
		[Token(Token = "0x401588B")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__OnPause;

		// Token: 0x0401588C RID: 88204
		[Token(Token = "0x401588C")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__OnUnpause;

		// Token: 0x0401588D RID: 88205
		[Token(Token = "0x401588D")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_GatherEffects;

		// Token: 0x0401588E RID: 88206
		[Token(Token = "0x401588E")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}

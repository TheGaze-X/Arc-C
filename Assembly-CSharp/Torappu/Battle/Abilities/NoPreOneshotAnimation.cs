using System;
using System.Collections;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Battle.Abilities
{
	// Token: 0x02002BCB RID: 11211
	[Token(Token = "0x2002BCB")]
	public class NoPreOneshotAnimation : AbilityStandard.Behaviour
	{
		// Token: 0x06012EE7 RID: 77543 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012EE7")]
		[Address(RVA = "0xAC88F0", Offset = "0xAC74F0", VA = "0x180AC88F0", Slot = "10")]
		public override void OnEvent(AbilityStandard.Event ev)
		{
		}

		// Token: 0x06012EE8 RID: 77544 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012EE8")]
		[Address(RVA = "0xAC87B0", Offset = "0xAC73B0", VA = "0x180AC87B0", Slot = "7")]
		public override void OnCastStart()
		{
		}

		// Token: 0x06012EE9 RID: 77545 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012EE9")]
		[Address(RVA = "0xAC8730", Offset = "0xAC7330", VA = "0x180AC8730", Slot = "9")]
		public override void OnCastFinish(Ability.FinishReason reason)
		{
		}

		// Token: 0x06012EEA RID: 77546 RVA: 0x00074058 File Offset: 0x00072258
		[Token(Token = "0x6012EEA")]
		[Address(RVA = "0xAC8970", Offset = "0xAC7570", VA = "0x180AC8970", Slot = "14")]
		public override bool UpdatePlaybackSpeed(AbilityStandard.UpdatePlaybackSpeedTiming timing, out float playbackSpeed)
		{
			return default(bool);
		}

		// Token: 0x06012EEB RID: 77547 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6012EEB")]
		[Address(RVA = "0xAC8680", Offset = "0xAC7280", VA = "0x180AC8680")]
		protected IEnumerator DoPlayAnimation()
		{
			return null;
		}

		// Token: 0x06012EEC RID: 77548 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012EEC")]
		[Address(RVA = "0xAC8B50", Offset = "0xAC7750", VA = "0x180AC8B50")]
		private void _ClearCoroutine()
		{
		}

		// Token: 0x06012EED RID: 77549 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012EED")]
		[Address(RVA = "0xAC8C50", Offset = "0xAC7850", VA = "0x180AC8C50")]
		public NoPreOneshotAnimation()
		{
		}

		// Token: 0x06012EEE RID: 77550 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012EEE")]
		[Address(RVA = "0xAC2A40", Offset = "0xAC1640", VA = "0x180AC2A40")]
		private void <>xLuaBaseProxy_OnEvent(AbilityStandard.Event P0)
		{
		}

		// Token: 0x06012EEF RID: 77551 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012EEF")]
		[Address(RVA = "0xAC2A30", Offset = "0xAC1630", VA = "0x180AC2A30")]
		private void <>xLuaBaseProxy_OnCastStart()
		{
		}

		// Token: 0x06012EF0 RID: 77552 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012EF0")]
		[Address(RVA = "0xAC3FE0", Offset = "0xAC2BE0", VA = "0x180AC3FE0")]
		private void <>xLuaBaseProxy_OnCastFinish(Ability.FinishReason P0)
		{
		}

		// Token: 0x06012EF1 RID: 77553 RVA: 0x00074070 File Offset: 0x00072270
		[Token(Token = "0x6012EF1")]
		[Address(RVA = "0xAC3FF0", Offset = "0xAC2BF0", VA = "0x180AC3FF0")]
		private bool <>xLuaBaseProxy_UpdatePlaybackSpeed(AbilityStandard.UpdatePlaybackSpeedTiming P0, out float P1)
		{
			return default(bool);
		}

		// Token: 0x040155CB RID: 87499
		[Token(Token = "0x40155CB")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private string _animWithPre;

		// Token: 0x040155CC RID: 87500
		[Token(Token = "0x40155CC")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private string _animNoPre;

		// Token: 0x040155CD RID: 87501
		[Token(Token = "0x40155CD")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private string _endAnim;

		// Token: 0x040155CE RID: 87502
		[Token(Token = "0x40155CE")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private float _maxAnimScale;

		// Token: 0x040155CF RID: 87503
		[Token(Token = "0x40155CF")]
		[FieldOffset(Offset = "0x40")]
		private string m_anim;

		// Token: 0x040155D0 RID: 87504
		[Token(Token = "0x40155D0")]
		[FieldOffset(Offset = "0x48")]
		private CoroutineId m_coroutine;

		// Token: 0x040155D1 RID: 87505
		[Token(Token = "0x40155D1")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnEvent;

		// Token: 0x040155D2 RID: 87506
		[Token(Token = "0x40155D2")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnCastStart;

		// Token: 0x040155D3 RID: 87507
		[Token(Token = "0x40155D3")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnCastFinish;

		// Token: 0x040155D4 RID: 87508
		[Token(Token = "0x40155D4")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_UpdatePlaybackSpeed;

		// Token: 0x040155D5 RID: 87509
		[Token(Token = "0x40155D5")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_DoPlayAnimation;

		// Token: 0x040155D6 RID: 87510
		[Token(Token = "0x40155D6")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__ClearCoroutine;

		// Token: 0x040155D7 RID: 87511
		[Token(Token = "0x40155D7")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}

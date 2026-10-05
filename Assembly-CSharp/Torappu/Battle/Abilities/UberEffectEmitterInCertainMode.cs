using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Battle.Abilities
{
	// Token: 0x02002C0A RID: 11274
	[Token(Token = "0x2002C0A")]
	public class UberEffectEmitterInCertainMode : UberEffectEmitter
	{
		// Token: 0x060130B1 RID: 78001 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60130B1")]
		[Address(RVA = "0xB27EA0", Offset = "0xB26AA0", VA = "0x180B27EA0", Slot = "7")]
		public override void OnCastStart()
		{
		}

		// Token: 0x060130B2 RID: 78002 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60130B2")]
		[Address(RVA = "0xB27D90", Offset = "0xB26990", VA = "0x180B27D90", Slot = "9")]
		public override void OnCastFinish(Ability.FinishReason reason)
		{
		}

		// Token: 0x060130B3 RID: 78003 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60130B3")]
		[Address(RVA = "0xB27E10", Offset = "0xB26A10", VA = "0x180B27E10", Slot = "11")]
		public override void OnCastOnTarget(Entity target)
		{
		}

		// Token: 0x060130B4 RID: 78004 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60130B4")]
		[Address(RVA = "0xB27F10", Offset = "0xB26B10", VA = "0x180B27F10", Slot = "10")]
		public override void OnEvent(AbilityStandard.Event ev)
		{
		}

		// Token: 0x060130B5 RID: 78005 RVA: 0x00074748 File Offset: 0x00072948
		[Token(Token = "0x60130B5")]
		[Address(RVA = "0xB27F90", Offset = "0xB26B90", VA = "0x180B27F90")]
		private bool _CheckModeValid()
		{
			return default(bool);
		}

		// Token: 0x060130B6 RID: 78006 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60130B6")]
		[Address(RVA = "0xB280D0", Offset = "0xB26CD0", VA = "0x180B280D0")]
		public UberEffectEmitterInCertainMode()
		{
		}

		// Token: 0x060130B7 RID: 78007 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60130B7")]
		[Address(RVA = "0xAE6E00", Offset = "0xAE5A00", VA = "0x180AE6E00")]
		private void <>xLuaBaseProxy_OnCastStart()
		{
		}

		// Token: 0x060130B8 RID: 78008 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60130B8")]
		[Address(RVA = "0xAE6DE0", Offset = "0xAE59E0", VA = "0x180AE6DE0")]
		private void <>xLuaBaseProxy_OnCastFinish(Ability.FinishReason P0)
		{
		}

		// Token: 0x060130B9 RID: 78009 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60130B9")]
		[Address(RVA = "0xAE6DF0", Offset = "0xAE59F0", VA = "0x180AE6DF0")]
		private void <>xLuaBaseProxy_OnCastOnTarget(Entity P0)
		{
		}

		// Token: 0x060130BA RID: 78010 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60130BA")]
		[Address(RVA = "0xAE6E10", Offset = "0xAE5A10", VA = "0x180AE6E10")]
		private void <>xLuaBaseProxy_OnEvent(AbilityStandard.Event P0)
		{
		}

		// Token: 0x04015817 RID: 88087
		[Token(Token = "0x4015817")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private int _activeMode;

		// Token: 0x04015818 RID: 88088
		[Token(Token = "0x4015818")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnCastStart;

		// Token: 0x04015819 RID: 88089
		[Token(Token = "0x4015819")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnCastFinish;

		// Token: 0x0401581A RID: 88090
		[Token(Token = "0x401581A")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnCastOnTarget;

		// Token: 0x0401581B RID: 88091
		[Token(Token = "0x401581B")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnEvent;

		// Token: 0x0401581C RID: 88092
		[Token(Token = "0x401581C")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__CheckModeValid;

		// Token: 0x0401581D RID: 88093
		[Token(Token = "0x401581D")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}

using System;
using System.Runtime.InteropServices;
using AdvancedInspector;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Battle.Abilities
{
	// Token: 0x02002AC4 RID: 10948
	[Token(Token = "0x2002AC4")]
	public class RangedAttackWithDoubleConfirm : RangedAttack
	{
		// Token: 0x060123B9 RID: 74681 RVA: 0x0006FC18 File Offset: 0x0006DE18
		[Token(Token = "0x60123B9")]
		[Address(RVA = "0xA478E0", Offset = "0xA464E0", VA = "0x180A478E0", Slot = "32")]
		public override bool CastToTarget(Entity target, [Optional] Ability.FinishCallbackDelegate finishCb, bool firstAttack = true)
		{
			return default(bool);
		}

		// Token: 0x060123BA RID: 74682 RVA: 0x0006FC30 File Offset: 0x0006DE30
		[Token(Token = "0x60123BA")]
		[Address(RVA = "0xA47AA0", Offset = "0xA466A0", VA = "0x180A47AA0", Slot = "70")]
		protected override Vector2 GetCastDirectlyMapPosition()
		{
			return default(Vector2);
		}

		// Token: 0x060123BB RID: 74683 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60123BB")]
		[Address(RVA = "0xA47B50", Offset = "0xA46750", VA = "0x180A47B50", Slot = "40")]
		protected override void Reset()
		{
		}

		// Token: 0x060123BC RID: 74684 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60123BC")]
		[Address(RVA = "0xA47C10", Offset = "0xA46810", VA = "0x180A47C10")]
		private void _ResetDoubleConfirm()
		{
		}

		// Token: 0x060123BD RID: 74685 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60123BD")]
		[Address(RVA = "0xA47C80", Offset = "0xA46880", VA = "0x180A47C80")]
		public RangedAttackWithDoubleConfirm()
		{
		}

		// Token: 0x060123BE RID: 74686 RVA: 0x0006FC48 File Offset: 0x0006DE48
		[Token(Token = "0x60123BE")]
		[Address(RVA = "0xA38650", Offset = "0xA37250", VA = "0x180A38650")]
		private bool <>xLuaBaseProxy_CastToTarget(Entity P0, Ability.FinishCallbackDelegate P1, bool P2)
		{
			return default(bool);
		}

		// Token: 0x060123BF RID: 74687 RVA: 0x0006FC60 File Offset: 0x0006DE60
		[Token(Token = "0x60123BF")]
		[Address(RVA = "0xA47C00", Offset = "0xA46800", VA = "0x180A47C00")]
		private Vector2 <>xLuaBaseProxy_GetCastDirectlyMapPosition()
		{
			return default(Vector2);
		}

		// Token: 0x060123C0 RID: 74688 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60123C0")]
		[Address(RVA = "0xA36020", Offset = "0xA34C20", VA = "0x180A36020")]
		private void <>xLuaBaseProxy_Reset()
		{
		}

		// Token: 0x040149F5 RID: 84469
		[Token(Token = "0x40149F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x268")]
		private bool m_hasFirstConfirm;

		// Token: 0x040149F6 RID: 84470
		[Token(Token = "0x40149F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x26C")]
		private Vector2? m_cachedPosition;

		// Token: 0x040149F7 RID: 84471
		[Token(Token = "0x40149F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x278")]
		[SerializeField]
		[Group("DoubleConfirm")]
		private bool _checkCanUseAbilityFlag;

		// Token: 0x040149F8 RID: 84472
		[Token(Token = "0x40149F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x279")]
		[SerializeField]
		[Group("DoubleConfirm")]
		private bool _useCachedPositionForced;

		// Token: 0x040149F9 RID: 84473
		[Token(Token = "0x40149F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_CastToTarget;

		// Token: 0x040149FA RID: 84474
		[Token(Token = "0x40149FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_GetCastDirectlyMapPosition;

		// Token: 0x040149FB RID: 84475
		[Token(Token = "0x40149FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_Reset;

		// Token: 0x040149FC RID: 84476
		[Token(Token = "0x40149FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__ResetDoubleConfirm;

		// Token: 0x040149FD RID: 84477
		[Token(Token = "0x40149FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}

using System;
using Il2CppDummyDll;
using Torappu.UI;
using UnityEngine;
using XLua;

namespace Torappu.Battle.UI
{
	// Token: 0x0200328B RID: 12939
	[Token(Token = "0x200328B")]
	public class Act6FunMainEnemyHudPlugin : UIPluginTalent.UnitTalentUIPlugin
	{
		// Token: 0x06014893 RID: 84115 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014893")]
		[Address(RVA = "0xCC3890", Offset = "0xCC2490", VA = "0x180CC3890", Slot = "9")]
		protected override void DoAttach(Unit owner, UIPluginTalent talent)
		{
		}

		// Token: 0x06014894 RID: 84116 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014894")]
		[Address(RVA = "0xCC3AE0", Offset = "0xCC26E0", VA = "0x180CC3AE0")]
		private void Update()
		{
		}

		// Token: 0x06014895 RID: 84117 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014895")]
		[Address(RVA = "0xCC3DE0", Offset = "0xCC29E0", VA = "0x180CC3DE0")]
		private void _UpdateBlockedState()
		{
		}

		// Token: 0x06014896 RID: 84118 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014896")]
		[Address(RVA = "0xCC3C70", Offset = "0xCC2870", VA = "0x180CC3C70")]
		private void _ToggleInCombatMark()
		{
		}

		// Token: 0x06014897 RID: 84119 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014897")]
		[Address(RVA = "0xCC3F40", Offset = "0xCC2B40", VA = "0x180CC3F40")]
		public Act6FunMainEnemyHudPlugin()
		{
		}

		// Token: 0x06014898 RID: 84120 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014898")]
		[Address(RVA = "0xCC3AD0", Offset = "0xCC26D0", VA = "0x180CC3AD0")]
		private void <>xLuaBaseProxy_DoAttach(Unit P0, UIPluginTalent P1)
		{
		}

		// Token: 0x04018479 RID: 99449
		[Token(Token = "0x4018479")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Entity.MountPointType _followMountPoint;

		// Token: 0x0401847A RID: 99450
		[Token(Token = "0x401847A")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private UIFollower _uiFollower;

		// Token: 0x0401847B RID: 99451
		[Token(Token = "0x401847B")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private AnimationWrapper _animWrapper;

		// Token: 0x0401847C RID: 99452
		[Token(Token = "0x401847C")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private string _animName;

		// Token: 0x0401847D RID: 99453
		[Token(Token = "0x401847D")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private CanvasGroup _defaultMarkCanvasGroup;

		// Token: 0x0401847E RID: 99454
		[Token(Token = "0x401847E")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private CanvasGroup _inCombatMarkCanvasGroup;

		// Token: 0x0401847F RID: 99455
		[Token(Token = "0x401847F")]
		[FieldOffset(Offset = "0x60")]
		private bool m_cachedIsInCombat;

		// Token: 0x04018480 RID: 99456
		[Token(Token = "0x4018480")]
		[FieldOffset(Offset = "0x68")]
		private FadeSwitchTween m_defaultMarkFadeTween;

		// Token: 0x04018481 RID: 99457
		[Token(Token = "0x4018481")]
		[FieldOffset(Offset = "0x70")]
		private FadeSwitchTween m_inCombatMarkFadeTween;

		// Token: 0x04018482 RID: 99458
		[Token(Token = "0x4018482")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_DoAttach;

		// Token: 0x04018483 RID: 99459
		[Token(Token = "0x4018483")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_Update;

		// Token: 0x04018484 RID: 99460
		[Token(Token = "0x4018484")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__UpdateBlockedState;

		// Token: 0x04018485 RID: 99461
		[Token(Token = "0x4018485")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__ToggleInCombatMark;

		// Token: 0x04018486 RID: 99462
		[Token(Token = "0x4018486")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}

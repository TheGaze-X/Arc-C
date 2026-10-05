using System;
using System.Collections;
using Il2CppDummyDll;
using Torappu.Battle;
using UnityEngine;
using XLua;

namespace Torappu.UI.BattleFinish
{
	// Token: 0x020061E7 RID: 25063
	[Token(Token = "0x20061E7")]
	public class BattleFinishDynState : UIPopupState
	{
		// Token: 0x060242AF RID: 148143 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60242AF")]
		[Address(RVA = "0x1ECF2C0", Offset = "0x1ECDEC0", VA = "0x181ECF2C0", Slot = "9")]
		public override IStateBean GetCacheBean()
		{
			return null;
		}

		// Token: 0x060242B0 RID: 148144 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60242B0")]
		[Address(RVA = "0x1ECF5B0", Offset = "0x1ECE1B0", VA = "0x181ECF5B0", Slot = "14")]
		protected override void OnEnter()
		{
		}

		// Token: 0x060242B1 RID: 148145 RVA: 0x000C3480 File Offset: 0x000C1680
		[Token(Token = "0x60242B1")]
		[Address(RVA = "0x1ECFE70", Offset = "0x1ECEA70", VA = "0x181ECFE70")]
		private bool _InitDynBattleFinish()
		{
			return default(bool);
		}

		// Token: 0x060242B2 RID: 148146 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60242B2")]
		[Address(RVA = "0x1ED0040", Offset = "0x1ECEC40", VA = "0x181ED0040")]
		private IEnumerator _ShowEffectCoroutine()
		{
			return null;
		}

		// Token: 0x060242B3 RID: 148147 RVA: 0x000C3498 File Offset: 0x000C1698
		[Token(Token = "0x60242B3")]
		[Address(RVA = "0x1ED03D0", Offset = "0x1ECEFD0", VA = "0x181ED03D0")]
		private static bool _TryGetBattleFinishView(RectTransform container, out IBattleFinishDynView battleFinishView)
		{
			return default(bool);
		}

		// Token: 0x060242B4 RID: 148148 RVA: 0x000C34B0 File Offset: 0x000C16B0
		[Token(Token = "0x60242B4")]
		[Address(RVA = "0x1ED00F0", Offset = "0x1ECECF0", VA = "0x181ED00F0")]
		private static bool _TryGetActivityBattleFinishView(RectTransform container, out IBattleFinishDynView battleFinishView)
		{
			return default(bool);
		}

		// Token: 0x060242B5 RID: 148149 RVA: 0x000C34C8 File Offset: 0x000C16C8
		[Token(Token = "0x60242B5")]
		[Address(RVA = "0x1ED0490", Offset = "0x1ECF090", VA = "0x181ED0490")]
		private static bool _TryGetBusinessBattleFinishView(RectTransform container, out IBattleFinishDynView battleFinishView)
		{
			return default(bool);
		}

		// Token: 0x060242B6 RID: 148150 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60242B6")]
		[Address(RVA = "0x1ECF910", Offset = "0x1ECE510", VA = "0x181ECF910")]
		private static string _GetResPathByBusinessType(BattleStageMeta.BusinessType businessType)
		{
			return null;
		}

		// Token: 0x060242B7 RID: 148151 RVA: 0x000C34E0 File Offset: 0x000C16E0
		[Token(Token = "0x60242B7")]
		[Address(RVA = "0x1ECFB90", Offset = "0x1ECE790", VA = "0x181ECFB90")]
		public static bool _HasActivityOverrideBattleFinish()
		{
			return default(bool);
		}

		// Token: 0x060242B8 RID: 148152 RVA: 0x000C34F8 File Offset: 0x000C16F8
		[Token(Token = "0x60242B8")]
		[Address(RVA = "0x1ECFCF0", Offset = "0x1ECE8F0", VA = "0x181ECFCF0")]
		public static bool _HasBusinessOverrideBattleFinish()
		{
			return default(bool);
		}

		// Token: 0x060242B9 RID: 148153 RVA: 0x000C3510 File Offset: 0x000C1710
		[Token(Token = "0x60242B9")]
		[Address(RVA = "0x1ECF320", Offset = "0x1ECDF20", VA = "0x181ECF320")]
		public static bool HasDynOverrideBattleFinish()
		{
			return default(bool);
		}

		// Token: 0x060242BA RID: 148154 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60242BA")]
		[Address(RVA = "0x1ECF6E0", Offset = "0x1ECE2E0", VA = "0x181ECF6E0", Slot = "23")]
		protected override IEnumerator ShowCoroutine(UIPopupState.TransactionContext context)
		{
			return null;
		}

		// Token: 0x060242BB RID: 148155 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60242BB")]
		[Address(RVA = "0x1ECF380", Offset = "0x1ECDF80", VA = "0x181ECF380", Slot = "24")]
		protected override IEnumerator HideCoroutine(UIPopupState.TransactionContext context)
		{
			return null;
		}

		// Token: 0x060242BC RID: 148156 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60242BC")]
		[Address(RVA = "0x1ECF820", Offset = "0x1ECE420", VA = "0x181ECF820", Slot = "25")]
		protected override void ShowImmediately(UIPopupState.TransactionContext context)
		{
		}

		// Token: 0x060242BD RID: 148157 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60242BD")]
		[Address(RVA = "0x1ECF4C0", Offset = "0x1ECE0C0", VA = "0x181ECF4C0", Slot = "26")]
		protected override void HideImmediately(UIPopupState.TransactionContext context)
		{
		}

		// Token: 0x060242BE RID: 148158 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60242BE")]
		[Address(RVA = "0x1ED0970", Offset = "0x1ECF570", VA = "0x181ED0970")]
		public BattleFinishDynState()
		{
		}

		// Token: 0x060242BF RID: 148159 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60242BF")]
		[Address(RVA = "0xE63450", Offset = "0xE62050", VA = "0x180E63450")]
		private void <>xLuaBaseProxy_OnEnter()
		{
		}

		// Token: 0x04032498 RID: 205976
		[Token(Token = "0x4032498")]
		private const float PASTTIME = 0.2f;

		// Token: 0x04032499 RID: 205977
		[Token(Token = "0x4032499")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private RectTransform _container;

		// Token: 0x0403249A RID: 205978
		[Token(Token = "0x403249A")]
		[FieldOffset(Offset = "0x68")]
		private IBattleFinishDynView m_battleFinishView;

		// Token: 0x0403249B RID: 205979
		[Token(Token = "0x403249B")]
		[FieldOffset(Offset = "0x70")]
		private bool m_isShowEffectEnd;

		// Token: 0x0403249C RID: 205980
		[Token(Token = "0x403249C")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetCacheBean;

		// Token: 0x0403249D RID: 205981
		[Token(Token = "0x403249D")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnEnter;

		// Token: 0x0403249E RID: 205982
		[Token(Token = "0x403249E")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__InitDynBattleFinish;

		// Token: 0x0403249F RID: 205983
		[Token(Token = "0x403249F")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__ShowEffectCoroutine;

		// Token: 0x040324A0 RID: 205984
		[Token(Token = "0x40324A0")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__TryGetBattleFinishView;

		// Token: 0x040324A1 RID: 205985
		[Token(Token = "0x40324A1")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__TryGetActivityBattleFinishView;

		// Token: 0x040324A2 RID: 205986
		[Token(Token = "0x40324A2")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__TryGetBusinessBattleFinishView;

		// Token: 0x040324A3 RID: 205987
		[Token(Token = "0x40324A3")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__GetResPathByBusinessType;

		// Token: 0x040324A4 RID: 205988
		[Token(Token = "0x40324A4")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__HasActivityOverrideBattleFinish;

		// Token: 0x040324A5 RID: 205989
		[Token(Token = "0x40324A5")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0__HasBusinessOverrideBattleFinish;

		// Token: 0x040324A6 RID: 205990
		[Token(Token = "0x40324A6")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_HasDynOverrideBattleFinish;

		// Token: 0x040324A7 RID: 205991
		[Token(Token = "0x40324A7")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_ShowCoroutine;

		// Token: 0x040324A8 RID: 205992
		[Token(Token = "0x40324A8")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0_HideCoroutine;

		// Token: 0x040324A9 RID: 205993
		[Token(Token = "0x40324A9")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0_ShowImmediately;

		// Token: 0x040324AA RID: 205994
		[Token(Token = "0x40324AA")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0_HideImmediately;

		// Token: 0x040324AB RID: 205995
		[Token(Token = "0x40324AB")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}

using System;
using System.Collections;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.CharacterInfo
{
	// Token: 0x02005ED3 RID: 24275
	[Token(Token = "0x2005ED3")]
	public class CharacterInfoPotentialFullState : UIPopupState, IHotfixable
	{
		// Token: 0x06023296 RID: 144022 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6023296")]
		[Address(RVA = "0x1DACAD0", Offset = "0x1DAB6D0", VA = "0x181DACAD0", Slot = "9")]
		public override IStateBean GetCacheBean()
		{
			return null;
		}

		// Token: 0x06023297 RID: 144023 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023297")]
		[Address(RVA = "0x1DACD60", Offset = "0x1DAB960", VA = "0x181DACD60", Slot = "14")]
		protected override void OnEnter()
		{
		}

		// Token: 0x06023298 RID: 144024 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023298")]
		[Address(RVA = "0x1DACF80", Offset = "0x1DABB80", VA = "0x181DACF80", Slot = "15")]
		protected override void OnResume()
		{
		}

		// Token: 0x06023299 RID: 144025 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6023299")]
		[Address(RVA = "0x1DAD040", Offset = "0x1DABC40", VA = "0x181DAD040", Slot = "23")]
		protected override IEnumerator ShowCoroutine(UIPopupState.TransactionContext context)
		{
			return null;
		}

		// Token: 0x0602329A RID: 144026 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602329A")]
		[Address(RVA = "0x1DACB30", Offset = "0x1DAB730", VA = "0x181DACB30", Slot = "24")]
		protected override IEnumerator HideCoroutine(UIPopupState.TransactionContext context)
		{
			return null;
		}

		// Token: 0x0602329B RID: 144027 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602329B")]
		[Address(RVA = "0x1DAD180", Offset = "0x1DABD80", VA = "0x181DAD180", Slot = "25")]
		protected override void ShowImmediately(UIPopupState.TransactionContext context)
		{
		}

		// Token: 0x0602329C RID: 144028 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602329C")]
		[Address(RVA = "0x1DACC70", Offset = "0x1DAB870", VA = "0x181DACC70", Slot = "26")]
		protected override void HideImmediately(UIPopupState.TransactionContext context)
		{
		}

		// Token: 0x0602329D RID: 144029 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602329D")]
		[Address(RVA = "0x1DAD3B0", Offset = "0x1DABFB0", VA = "0x181DAD3B0")]
		private void _OnClick()
		{
		}

		// Token: 0x0602329E RID: 144030 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602329E")]
		[Address(RVA = "0x1DAD2F0", Offset = "0x1DABEF0", VA = "0x181DAD2F0")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0602329F RID: 144031 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602329F")]
		[Address(RVA = "0x1DAD4B0", Offset = "0x1DAC0B0", VA = "0x181DAD4B0")]
		public CharacterInfoPotentialFullState()
		{
		}

		// Token: 0x060232A0 RID: 144032 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60232A0")]
		[Address(RVA = "0xE63450", Offset = "0xE62050", VA = "0x180E63450")]
		private void <>xLuaBaseProxy_OnEnter()
		{
		}

		// Token: 0x060232A1 RID: 144033 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60232A1")]
		[Address(RVA = "0xE0F5F0", Offset = "0xE0E1F0", VA = "0x180E0F5F0")]
		private void <>xLuaBaseProxy_OnResume()
		{
		}

		// Token: 0x04030762 RID: 198498
		[Token(Token = "0x4030762")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private CharacterInfoPotentialFullView _view;

		// Token: 0x04030763 RID: 198499
		[Token(Token = "0x4030763")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private UICommonPageEffectHolder _effectHolder;

		// Token: 0x04030764 RID: 198500
		[Token(Token = "0x4030764")]
		[FieldOffset(Offset = "0x70")]
		private CharacterInfoPotentialStateBean m_stateBean;

		// Token: 0x04030765 RID: 198501
		[Token(Token = "0x4030765")]
		[FieldOffset(Offset = "0x78")]
		private bool m_hasInited;

		// Token: 0x04030766 RID: 198502
		[Token(Token = "0x4030766")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetCacheBean;

		// Token: 0x04030767 RID: 198503
		[Token(Token = "0x4030767")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnEnter;

		// Token: 0x04030768 RID: 198504
		[Token(Token = "0x4030768")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnResume;

		// Token: 0x04030769 RID: 198505
		[Token(Token = "0x4030769")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_ShowCoroutine;

		// Token: 0x0403076A RID: 198506
		[Token(Token = "0x403076A")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_HideCoroutine;

		// Token: 0x0403076B RID: 198507
		[Token(Token = "0x403076B")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_ShowImmediately;

		// Token: 0x0403076C RID: 198508
		[Token(Token = "0x403076C")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_HideImmediately;

		// Token: 0x0403076D RID: 198509
		[Token(Token = "0x403076D")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__OnClick;

		// Token: 0x0403076E RID: 198510
		[Token(Token = "0x403076E")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0403076F RID: 198511
		[Token(Token = "0x403076F")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}

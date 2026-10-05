using System;
using Il2CppDummyDll;
using Torappu.UI;
using UnityEngine;
using XLua;

namespace Torappu.Activity.Act1VHalfIdle
{
	// Token: 0x02007718 RID: 30488
	[Token(Token = "0x2007718")]
	public class Act1VHalfIdleCharSkillUpgradeView : MonoBehaviour, IHotfixable
	{
		// Token: 0x17006480 RID: 25728
		// (get) Token: 0x0602AD55 RID: 175445 RVA: 0x000DA2E0 File Offset: 0x000D84E0
		[Token(Token = "0x17006480")]
		public bool isStable
		{
			[Token(Token = "0x602AD55")]
			[Address(RVA = "0x269CD80", Offset = "0x269B980", VA = "0x18269CD80")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x0602AD56 RID: 175446 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602AD56")]
		[Address(RVA = "0x269CC00", Offset = "0x269B800", VA = "0x18269CC00")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0602AD57 RID: 175447 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602AD57")]
		[Address(RVA = "0x269C920", Offset = "0x269B520", VA = "0x18269C920")]
		public void Render(Act1VHalfIdleCharUpgradeViewModel viewModel)
		{
		}

		// Token: 0x0602AD58 RID: 175448 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602AD58")]
		[Address(RVA = "0x269C7B0", Offset = "0x269B3B0", VA = "0x18269C7B0")]
		public void RegisterTutorialGO()
		{
		}

		// Token: 0x0602AD59 RID: 175449 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602AD59")]
		[Address(RVA = "0x269CD20", Offset = "0x269B920", VA = "0x18269CD20")]
		public Act1VHalfIdleCharSkillUpgradeView()
		{
		}

		// Token: 0x0403DBC9 RID: 252873
		[Token(Token = "0x403DBC9")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Act1VHalfIdleCharSkillUpgradeFullView _upgradeFullView;

		// Token: 0x0403DBCA RID: 252874
		[Token(Token = "0x403DBCA")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Act1VHalfIdleCharSkillUpgradeNotFullView _upgradeNotFullView;

		// Token: 0x0403DBCB RID: 252875
		[Token(Token = "0x403DBCB")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private UIAnimationLocation _animFullViewShow;

		// Token: 0x0403DBCC RID: 252876
		[Token(Token = "0x403DBCC")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private CanvasGroup _canvasNotFullView;

		// Token: 0x0403DBCD RID: 252877
		[Token(Token = "0x403DBCD")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private GameObject _pnlSkillUpgradeGO;

		// Token: 0x0403DBCE RID: 252878
		[Token(Token = "0x403DBCE")]
		[FieldOffset(Offset = "0x48")]
		private bool m_inited;

		// Token: 0x0403DBCF RID: 252879
		[Token(Token = "0x403DBCF")]
		[FieldOffset(Offset = "0x50")]
		private Act1VHalfIdleCharSkillUpgradeView.SwitchTween m_switchTween;

		// Token: 0x0403DBD0 RID: 252880
		[Token(Token = "0x403DBD0")]
		[FieldOffset(Offset = "0x58")]
		private int m_cachedInitSeqNum;

		// Token: 0x0403DBD1 RID: 252881
		[Token(Token = "0x403DBD1")]
		[FieldOffset(Offset = "0x5C")]
		private int m_cachedSwitchCharSeqNum;

		// Token: 0x0403DBD2 RID: 252882
		[Token(Token = "0x403DBD2")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_isStable;

		// Token: 0x0403DBD3 RID: 252883
		[Token(Token = "0x403DBD3")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0403DBD4 RID: 252884
		[Token(Token = "0x403DBD4")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0403DBD5 RID: 252885
		[Token(Token = "0x403DBD5")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_RegisterTutorialGO;

		// Token: 0x0403DBD6 RID: 252886
		[Token(Token = "0x403DBD6")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02007719 RID: 30489
		[Token(Token = "0x2007719")]
		private class SwitchTween : UISwitchTween
		{
			// Token: 0x0602AD5A RID: 175450 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602AD5A")]
			[Address(RVA = "0x26A99E0", Offset = "0x26A85E0", VA = "0x1826A99E0")]
			public SwitchTween(Act1VHalfIdleCharSkillUpgradeView closure)
			{
			}

			// Token: 0x0602AD5B RID: 175451 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x602AD5B")]
			[Address(RVA = "0x26A8BE0", Offset = "0x26A77E0", VA = "0x1826A8BE0", Slot = "5")]
			protected override UISwitchTween.ITweenHandler GenerateTweenOfHide()
			{
				return null;
			}

			// Token: 0x0602AD5C RID: 175452 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x602AD5C")]
			[Address(RVA = "0x26A9060", Offset = "0x26A7C60", VA = "0x1826A9060", Slot = "4")]
			protected override UISwitchTween.ITweenHandler GenerateTweenOfShow()
			{
				return null;
			}

			// Token: 0x0602AD5D RID: 175453 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602AD5D")]
			[Address(RVA = "0x26A80F0", Offset = "0x26A6CF0", VA = "0x1826A80F0", Slot = "9")]
			protected override void AfterHideEffect()
			{
			}

			// Token: 0x0602AD5E RID: 175454 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602AD5E")]
			[Address(RVA = "0x26A8360", Offset = "0x26A6F60", VA = "0x1826A8360", Slot = "8")]
			protected override void AfterShowEffect()
			{
			}

			// Token: 0x0602AD5F RID: 175455 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602AD5F")]
			[Address(RVA = "0x26A87F0", Offset = "0x26A73F0", VA = "0x1826A87F0", Slot = "6")]
			protected override void BeforeShowEffect()
			{
			}

			// Token: 0x0602AD60 RID: 175456 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602AD60")]
			[Address(RVA = "0x26A8450", Offset = "0x26A7050", VA = "0x1826A8450", Slot = "7")]
			protected override void BeforeHideEffect()
			{
			}

			// Token: 0x0602AD61 RID: 175457 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602AD61")]
			[Address(RVA = "0x26A9890", Offset = "0x26A8490", VA = "0x1826A9890", Slot = "10")]
			protected override void ResetToState(bool isShow)
			{
			}

			// Token: 0x0602AD62 RID: 175458 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602AD62")]
			[Address(RVA = "0x9C2DA0", Offset = "0x9C19A0", VA = "0x1809C2DA0")]
			private void <>xLuaBaseProxy_AfterHideEffect()
			{
			}

			// Token: 0x0602AD63 RID: 175459 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602AD63")]
			[Address(RVA = "0xECEC90", Offset = "0xECD890", VA = "0x180ECEC90")]
			private void <>xLuaBaseProxy_AfterShowEffect()
			{
			}

			// Token: 0x0602AD64 RID: 175460 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602AD64")]
			[Address(RVA = "0xDFAF10", Offset = "0xDF9B10", VA = "0x180DFAF10")]
			private void <>xLuaBaseProxy_BeforeShowEffect()
			{
			}

			// Token: 0x0602AD65 RID: 175461 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602AD65")]
			[Address(RVA = "0x10A4B70", Offset = "0x10A3770", VA = "0x1810A4B70")]
			private void <>xLuaBaseProxy_BeforeHideEffect()
			{
			}

			// Token: 0x0602AD66 RID: 175462 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602AD66")]
			[Address(RVA = "0x9B38B0", Offset = "0x9B24B0", VA = "0x1809B38B0")]
			private void <>xLuaBaseProxy_ResetToState(bool P0)
			{
			}

			// Token: 0x0403DBD7 RID: 252887
			[Token(Token = "0x403DBD7")]
			[FieldOffset(Offset = "0x48")]
			private Act1VHalfIdleCharSkillUpgradeView m_closure;

			// Token: 0x0403DBD8 RID: 252888
			[Token(Token = "0x403DBD8")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x0403DBD9 RID: 252889
			[Token(Token = "0x403DBD9")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_GenerateTweenOfHide;

			// Token: 0x0403DBDA RID: 252890
			[Token(Token = "0x403DBDA")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_GenerateTweenOfShow;

			// Token: 0x0403DBDB RID: 252891
			[Token(Token = "0x403DBDB")]
			[FieldOffset(Offset = "0x18")]
			private static DelegateBridge __Hotfix0_AfterHideEffect;

			// Token: 0x0403DBDC RID: 252892
			[Token(Token = "0x403DBDC")]
			[FieldOffset(Offset = "0x20")]
			private static DelegateBridge __Hotfix0_AfterShowEffect;

			// Token: 0x0403DBDD RID: 252893
			[Token(Token = "0x403DBDD")]
			[FieldOffset(Offset = "0x28")]
			private static DelegateBridge __Hotfix0_BeforeShowEffect;

			// Token: 0x0403DBDE RID: 252894
			[Token(Token = "0x403DBDE")]
			[FieldOffset(Offset = "0x30")]
			private static DelegateBridge __Hotfix0_BeforeHideEffect;

			// Token: 0x0403DBDF RID: 252895
			[Token(Token = "0x403DBDF")]
			[FieldOffset(Offset = "0x38")]
			private static DelegateBridge __Hotfix0_ResetToState;
		}
	}
}

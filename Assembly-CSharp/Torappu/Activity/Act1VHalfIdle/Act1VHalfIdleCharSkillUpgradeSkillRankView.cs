using System;
using Il2CppDummyDll;
using Torappu.UI;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Activity.Act1VHalfIdle
{
	// Token: 0x02007716 RID: 30486
	[Token(Token = "0x2007716")]
	public class Act1VHalfIdleCharSkillUpgradeSkillRankView : MonoBehaviour, IHotfixable
	{
		// Token: 0x0602AD43 RID: 175427 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602AD43")]
		[Address(RVA = "0x269C4D0", Offset = "0x269B0D0", VA = "0x18269C4D0")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0602AD44 RID: 175428 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602AD44")]
		[Address(RVA = "0x269C1A0", Offset = "0x269ADA0", VA = "0x18269C1A0")]
		public void Render(Act1VHalfIdleCharUpgradeViewModel viewModel, int skillRank)
		{
		}

		// Token: 0x0602AD45 RID: 175429 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602AD45")]
		[Address(RVA = "0x269C5F0", Offset = "0x269B1F0", VA = "0x18269C5F0")]
		private void _RenderPnlRank(int skillRank)
		{
		}

		// Token: 0x0602AD46 RID: 175430 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602AD46")]
		[Address(RVA = "0x269C6A0", Offset = "0x269B2A0", VA = "0x18269C6A0")]
		private void _RenderPnlSpecialized(int specializedLevel)
		{
		}

		// Token: 0x0602AD47 RID: 175431 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602AD47")]
		[Address(RVA = "0x269C750", Offset = "0x269B350", VA = "0x18269C750")]
		public Act1VHalfIdleCharSkillUpgradeSkillRankView()
		{
		}

		// Token: 0x0403DBB2 RID: 252850
		[Token(Token = "0x403DBB2")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private CanvasGroup _canvasRank;

		// Token: 0x0403DBB3 RID: 252851
		[Token(Token = "0x403DBB3")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private CanvasGroup _canvasSpecialized;

		// Token: 0x0403DBB4 RID: 252852
		[Token(Token = "0x403DBB4")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Text _textSkillRank;

		// Token: 0x0403DBB5 RID: 252853
		[Token(Token = "0x403DBB5")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Image _imgSpecialized;

		// Token: 0x0403DBB6 RID: 252854
		[Token(Token = "0x403DBB6")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Sprite[] _specializedIcons;

		// Token: 0x0403DBB7 RID: 252855
		[Token(Token = "0x403DBB7")]
		[FieldOffset(Offset = "0x40")]
		private bool m_inited;

		// Token: 0x0403DBB8 RID: 252856
		[Token(Token = "0x403DBB8")]
		[FieldOffset(Offset = "0x48")]
		private Act1VHalfIdleCharSkillUpgradeSkillRankView.SwitchTween m_switchTween;

		// Token: 0x0403DBB9 RID: 252857
		[Token(Token = "0x403DBB9")]
		[FieldOffset(Offset = "0x50")]
		private int m_cachedInitSeqNum;

		// Token: 0x0403DBBA RID: 252858
		[Token(Token = "0x403DBBA")]
		[FieldOffset(Offset = "0x54")]
		private int m_cachedSwitchCharSeqNum;

		// Token: 0x0403DBBB RID: 252859
		[Token(Token = "0x403DBBB")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0403DBBC RID: 252860
		[Token(Token = "0x403DBBC")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0403DBBD RID: 252861
		[Token(Token = "0x403DBBD")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__RenderPnlRank;

		// Token: 0x0403DBBE RID: 252862
		[Token(Token = "0x403DBBE")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__RenderPnlSpecialized;

		// Token: 0x0403DBBF RID: 252863
		[Token(Token = "0x403DBBF")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02007717 RID: 30487
		[Token(Token = "0x2007717")]
		private class SwitchTween : UISwitchTween
		{
			// Token: 0x0602AD48 RID: 175432 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602AD48")]
			[Address(RVA = "0x26A9AE0", Offset = "0x26A86E0", VA = "0x1826A9AE0")]
			public SwitchTween(Act1VHalfIdleCharSkillUpgradeSkillRankView closure)
			{
			}

			// Token: 0x0602AD49 RID: 175433 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x602AD49")]
			[Address(RVA = "0x26A8CE0", Offset = "0x26A78E0", VA = "0x1826A8CE0", Slot = "5")]
			protected override UISwitchTween.ITweenHandler GenerateTweenOfHide()
			{
				return null;
			}

			// Token: 0x0602AD4A RID: 175434 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x602AD4A")]
			[Address(RVA = "0x26A9380", Offset = "0x26A7F80", VA = "0x1826A9380", Slot = "4")]
			protected override UISwitchTween.ITweenHandler GenerateTweenOfShow()
			{
				return null;
			}

			// Token: 0x0602AD4B RID: 175435 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602AD4B")]
			[Address(RVA = "0x26A8170", Offset = "0x26A6D70", VA = "0x1826A8170", Slot = "9")]
			protected override void AfterHideEffect()
			{
			}

			// Token: 0x0602AD4C RID: 175436 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602AD4C")]
			[Address(RVA = "0x26A8260", Offset = "0x26A6E60", VA = "0x1826A8260", Slot = "8")]
			protected override void AfterShowEffect()
			{
			}

			// Token: 0x0602AD4D RID: 175437 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602AD4D")]
			[Address(RVA = "0x26A8770", Offset = "0x26A7370", VA = "0x1826A8770", Slot = "6")]
			protected override void BeforeShowEffect()
			{
			}

			// Token: 0x0602AD4E RID: 175438 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602AD4E")]
			[Address(RVA = "0x26A84D0", Offset = "0x26A70D0", VA = "0x1826A84D0", Slot = "7")]
			protected override void BeforeHideEffect()
			{
			}

			// Token: 0x0602AD4F RID: 175439 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602AD4F")]
			[Address(RVA = "0x26A9510", Offset = "0x26A8110", VA = "0x1826A9510", Slot = "10")]
			protected override void ResetToState(bool isShow)
			{
			}

			// Token: 0x0602AD50 RID: 175440 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602AD50")]
			[Address(RVA = "0x9C2DA0", Offset = "0x9C19A0", VA = "0x1809C2DA0")]
			private void <>xLuaBaseProxy_AfterHideEffect()
			{
			}

			// Token: 0x0602AD51 RID: 175441 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602AD51")]
			[Address(RVA = "0xECEC90", Offset = "0xECD890", VA = "0x180ECEC90")]
			private void <>xLuaBaseProxy_AfterShowEffect()
			{
			}

			// Token: 0x0602AD52 RID: 175442 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602AD52")]
			[Address(RVA = "0xDFAF10", Offset = "0xDF9B10", VA = "0x180DFAF10")]
			private void <>xLuaBaseProxy_BeforeShowEffect()
			{
			}

			// Token: 0x0602AD53 RID: 175443 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602AD53")]
			[Address(RVA = "0x10A4B70", Offset = "0x10A3770", VA = "0x1810A4B70")]
			private void <>xLuaBaseProxy_BeforeHideEffect()
			{
			}

			// Token: 0x0602AD54 RID: 175444 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602AD54")]
			[Address(RVA = "0x9B38B0", Offset = "0x9B24B0", VA = "0x1809B38B0")]
			private void <>xLuaBaseProxy_ResetToState(bool P0)
			{
			}

			// Token: 0x0403DBC0 RID: 252864
			[Token(Token = "0x403DBC0")]
			[FieldOffset(Offset = "0x48")]
			private Act1VHalfIdleCharSkillUpgradeSkillRankView m_closure;

			// Token: 0x0403DBC1 RID: 252865
			[Token(Token = "0x403DBC1")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x0403DBC2 RID: 252866
			[Token(Token = "0x403DBC2")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_GenerateTweenOfHide;

			// Token: 0x0403DBC3 RID: 252867
			[Token(Token = "0x403DBC3")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_GenerateTweenOfShow;

			// Token: 0x0403DBC4 RID: 252868
			[Token(Token = "0x403DBC4")]
			[FieldOffset(Offset = "0x18")]
			private static DelegateBridge __Hotfix0_AfterHideEffect;

			// Token: 0x0403DBC5 RID: 252869
			[Token(Token = "0x403DBC5")]
			[FieldOffset(Offset = "0x20")]
			private static DelegateBridge __Hotfix0_AfterShowEffect;

			// Token: 0x0403DBC6 RID: 252870
			[Token(Token = "0x403DBC6")]
			[FieldOffset(Offset = "0x28")]
			private static DelegateBridge __Hotfix0_BeforeShowEffect;

			// Token: 0x0403DBC7 RID: 252871
			[Token(Token = "0x403DBC7")]
			[FieldOffset(Offset = "0x30")]
			private static DelegateBridge __Hotfix0_BeforeHideEffect;

			// Token: 0x0403DBC8 RID: 252872
			[Token(Token = "0x403DBC8")]
			[FieldOffset(Offset = "0x38")]
			private static DelegateBridge __Hotfix0_ResetToState;
		}
	}
}

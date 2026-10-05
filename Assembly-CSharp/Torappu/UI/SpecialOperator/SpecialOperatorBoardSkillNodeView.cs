using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.SpecialOperator
{
	// Token: 0x02003E9B RID: 16027
	[Token(Token = "0x2003E9B")]
	public class SpecialOperatorBoardSkillNodeView : SpecialOperatorPointViewBase
	{
		// Token: 0x17003B60 RID: 15200
		// (get) Token: 0x06018E2B RID: 101931 RVA: 0x0009C528 File Offset: 0x0009A728
		[Token(Token = "0x17003B60")]
		public override SpecialOperatorPointViewType viewType
		{
			[Token(Token = "0x6018E2B")]
			[Address(RVA = "0x1191C00", Offset = "0x1190800", VA = "0x181191C00", Slot = "6")]
			get
			{
				return SpecialOperatorPointViewType.NONE;
			}
		}

		// Token: 0x06018E2C RID: 101932 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018E2C")]
		[Address(RVA = "0x1191900", Offset = "0x1190500", VA = "0x181191900")]
		private void _InitIfNot()
		{
		}

		// Token: 0x06018E2D RID: 101933 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018E2D")]
		[Address(RVA = "0x11911C0", Offset = "0x118FDC0", VA = "0x1811911C0", Slot = "5")]
		protected override void OnInit()
		{
		}

		// Token: 0x06018E2E RID: 101934 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018E2E")]
		[Address(RVA = "0x1191360", Offset = "0x118FF60", VA = "0x181191360", Slot = "4")]
		protected override void OnRender()
		{
		}

		// Token: 0x06018E2F RID: 101935 RVA: 0x0009C540 File Offset: 0x0009A740
		[Token(Token = "0x6018E2F")]
		[Address(RVA = "0x1191750", Offset = "0x1190350", VA = "0x181191750")]
		private SpecialOperatorBoardSkillNodeView.RenderState _CalcRenderState(SpecialOperatorBoardSkillNode skillNodeModel)
		{
			return SpecialOperatorBoardSkillNodeView.RenderState.ICON;
		}

		// Token: 0x06018E30 RID: 101936 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018E30")]
		[Address(RVA = "0x1191A20", Offset = "0x1190620", VA = "0x181191A20")]
		private void _SetUnlockAnim(bool isUnlock, bool isFastMode)
		{
		}

		// Token: 0x06018E31 RID: 101937 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018E31")]
		[Address(RVA = "0x11910D0", Offset = "0x118FCD0", VA = "0x1811910D0")]
		public void OnClick()
		{
		}

		// Token: 0x06018E32 RID: 101938 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018E32")]
		[Address(RVA = "0x1191B50", Offset = "0x1190750", VA = "0x181191B50")]
		public SpecialOperatorBoardSkillNodeView()
		{
		}

		// Token: 0x06018E33 RID: 101939 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018E33")]
		[Address(RVA = "0x118ECE0", Offset = "0x118D8E0", VA = "0x18118ECE0")]
		private void <>xLuaBaseProxy_OnInit()
		{
		}

		// Token: 0x06018E34 RID: 101940 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018E34")]
		[Address(RVA = "0x118ED40", Offset = "0x118D940", VA = "0x18118ED40")]
		private void <>xLuaBaseProxy_OnRender()
		{
		}

		// Token: 0x0401EAC1 RID: 125633
		[Token(Token = "0x401EAC1")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Image _icon;

		// Token: 0x0401EAC2 RID: 125634
		[Token(Token = "0x401EAC2")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Text _name;

		// Token: 0x0401EAC3 RID: 125635
		[Token(Token = "0x401EAC3")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private GameObject _panelIcon;

		// Token: 0x0401EAC4 RID: 125636
		[Token(Token = "0x401EAC4")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private GameObject _panelIconLock;

		// Token: 0x0401EAC5 RID: 125637
		[Token(Token = "0x401EAC5")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private GameObject _panelLock;

		// Token: 0x0401EAC6 RID: 125638
		[Token(Token = "0x401EAC6")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private GameObject _panelLockpre;

		// Token: 0x0401EAC7 RID: 125639
		[Token(Token = "0x401EAC7")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private GameObject _panelCanUnlock;

		// Token: 0x0401EAC8 RID: 125640
		[Token(Token = "0x401EAC8")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private GameObject _panelTag;

		// Token: 0x0401EAC9 RID: 125641
		[Token(Token = "0x401EAC9")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private Text _rank;

		// Token: 0x0401EACA RID: 125642
		[Token(Token = "0x401EACA")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private GameObject _panelSp;

		// Token: 0x0401EACB RID: 125643
		[Token(Token = "0x401EACB")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private GameObject[] _spIcons;

		// Token: 0x0401EACC RID: 125644
		[Token(Token = "0x401EACC")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		private UIAnimationLocation _unlockAnim;

		// Token: 0x0401EACD RID: 125645
		[Token(Token = "0x401EACD")]
		[FieldOffset(Offset = "0x98")]
		private bool m_isInited;

		// Token: 0x0401EACE RID: 125646
		[Token(Token = "0x401EACE")]
		[FieldOffset(Offset = "0xA0")]
		private string m_nodeId;

		// Token: 0x0401EACF RID: 125647
		[Token(Token = "0x401EACF")]
		[FieldOffset(Offset = "0xA8")]
		private UIStateFinder m_stateFinder;

		// Token: 0x0401EAD0 RID: 125648
		[Token(Token = "0x401EAD0")]
		[FieldOffset(Offset = "0xB8")]
		private AnimationSwitchTween m_unlockTween;

		// Token: 0x0401EAD1 RID: 125649
		[Token(Token = "0x401EAD1")]
		[FieldOffset(Offset = "0xC0")]
		private string m_skillId;

		// Token: 0x0401EAD2 RID: 125650
		[Token(Token = "0x401EAD2")]
		[FieldOffset(Offset = "0xC8")]
		private UIPageFinder m_pageFinder;

		// Token: 0x0401EAD3 RID: 125651
		[Token(Token = "0x401EAD3")]
		[FieldOffset(Offset = "0xD8")]
		private int m_cachedEnterSeq;

		// Token: 0x0401EAD4 RID: 125652
		[Token(Token = "0x401EAD4")]
		[FieldOffset(Offset = "0xDC")]
		private SpecialOperatorBoardSkillNodeView.RenderState m_renderState;

		// Token: 0x0401EAD5 RID: 125653
		[Token(Token = "0x401EAD5")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_viewType;

		// Token: 0x0401EAD6 RID: 125654
		[Token(Token = "0x401EAD6")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0401EAD7 RID: 125655
		[Token(Token = "0x401EAD7")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnInit;

		// Token: 0x0401EAD8 RID: 125656
		[Token(Token = "0x401EAD8")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnRender;

		// Token: 0x0401EAD9 RID: 125657
		[Token(Token = "0x401EAD9")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__CalcRenderState;

		// Token: 0x0401EADA RID: 125658
		[Token(Token = "0x401EADA")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__SetUnlockAnim;

		// Token: 0x0401EADB RID: 125659
		[Token(Token = "0x401EADB")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_OnClick;

		// Token: 0x0401EADC RID: 125660
		[Token(Token = "0x401EADC")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02003E9C RID: 16028
		[Token(Token = "0x2003E9C")]
		private enum RenderState
		{
			// Token: 0x0401EADE RID: 125662
			[Token(Token = "0x401EADE")]
			ICON,
			// Token: 0x0401EADF RID: 125663
			[Token(Token = "0x401EADF")]
			LOCK,
			// Token: 0x0401EAE0 RID: 125664
			[Token(Token = "0x401EAE0")]
			LOCK_PRE,
			// Token: 0x0401EAE1 RID: 125665
			[Token(Token = "0x401EAE1")]
			CAN_UNLOCK,
			// Token: 0x0401EAE2 RID: 125666
			[Token(Token = "0x401EAE2")]
			UNLOCK,
			// Token: 0x0401EAE3 RID: 125667
			[Token(Token = "0x401EAE3")]
			ICON_LOCK
		}
	}
}

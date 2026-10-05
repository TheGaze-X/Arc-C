using System;
using System.Collections.Generic;
using AdvancedInspector;
using DG.Tweening;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.SandboxPerm.SandboxV2
{
	// Token: 0x0200414B RID: 16715
	[Token(Token = "0x200414B")]
	public class SandboxV2BasementStatusView : MonoBehaviour, IHotfixable
	{
		// Token: 0x06019D10 RID: 105744 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019D10")]
		[Address(RVA = "0x12A2910", Offset = "0x12A1510", VA = "0x1812A2910")]
		public void Render(SandboxV2DungeonNodeViewModel nodeViewModel, SandboxV2DungeonViewModel dungeonViewModel)
		{
		}

		// Token: 0x06019D11 RID: 105745 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019D11")]
		[Address(RVA = "0x12A2870", Offset = "0x12A1470", VA = "0x1812A2870")]
		public void OnClickUpgradeBtn()
		{
		}

		// Token: 0x06019D12 RID: 105746 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019D12")]
		[Address(RVA = "0x12A3240", Offset = "0x12A1E40", VA = "0x1812A3240")]
		public SandboxV2BasementStatusView()
		{
		}

		// Token: 0x04020671 RID: 132721
		[Token(Token = "0x4020671")]
		private const string BASEMENT_HEALTH_VALUE_FORMAT = "{0}%";

		// Token: 0x04020672 RID: 132722
		[Token(Token = "0x4020672")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		[Group("Basement HP")]
		private Text _basementHpInfoText;

		// Token: 0x04020673 RID: 132723
		[Token(Token = "0x4020673")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		[Group("Basement HP")]
		private Text _basementHpText;

		// Token: 0x04020674 RID: 132724
		[Token(Token = "0x4020674")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		[Group("Basement HP")]
		private SandboxV2CircleProgressBar _basementHpBar;

		// Token: 0x04020675 RID: 132725
		[Token(Token = "0x4020675")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		[Group("Basement HP")]
		private UISlicedCircleBar _basementHpValue;

		// Token: 0x04020676 RID: 132726
		[Token(Token = "0x4020676")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		[Group("Basement Level")]
		private Text _basementLevelText;

		// Token: 0x04020677 RID: 132727
		[Token(Token = "0x4020677")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		[Group("Basement Level")]
		private Text _basementLevelInfoText;

		// Token: 0x04020678 RID: 132728
		[Token(Token = "0x4020678")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		[Group("Basement Icon")]
		private UIAtlasImage _basementBkg;

		// Token: 0x04020679 RID: 132729
		[Token(Token = "0x4020679")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		[Group("Basement Stage")]
		private UIAtlasImage _basementIcon;

		// Token: 0x0402067A RID: 132730
		[Token(Token = "0x402067A")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		[Group("Basement Stage")]
		private Text _basementStageNameText;

		// Token: 0x0402067B RID: 132731
		[Token(Token = "0x402067B")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		[Group("Upgrade")]
		private GameObject _pnlCanUpgrade;

		// Token: 0x0402067C RID: 132732
		[Token(Token = "0x402067C")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		[Group("Upgrade")]
		private GameObject _pnlUpgradeBtn;

		// Token: 0x0402067D RID: 132733
		[Token(Token = "0x402067D")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private List<SandboxV2NodeType> _supportedNodeType;

		// Token: 0x0402067E RID: 132734
		[Token(Token = "0x402067E")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private UIAnimationLocation _animIntro;

		// Token: 0x0402067F RID: 132735
		[Token(Token = "0x402067F")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		private UIAnimationLocation _animLoop;

		// Token: 0x04020680 RID: 132736
		[Token(Token = "0x4020680")]
		[FieldOffset(Offset = "0x98")]
		private UIPageFinder m_pageFinder;

		// Token: 0x04020681 RID: 132737
		[Token(Token = "0x4020681")]
		[FieldOffset(Offset = "0xA8")]
		private UIStateFinder m_stateFinder;

		// Token: 0x04020682 RID: 132738
		[Token(Token = "0x4020682")]
		[FieldOffset(Offset = "0xB8")]
		private SandboxV2DungeonViewConfig m_dungeonViewConfig;

		// Token: 0x04020683 RID: 132739
		[Token(Token = "0x4020683")]
		[FieldOffset(Offset = "0xC0")]
		private SandboxV2NodeType m_cachedNodeType;

		// Token: 0x04020684 RID: 132740
		[Token(Token = "0x4020684")]
		[FieldOffset(Offset = "0xC4")]
		private bool m_cachedIsEnemyRush;

		// Token: 0x04020685 RID: 132741
		[Token(Token = "0x4020685")]
		[FieldOffset(Offset = "0xC5")]
		private bool m_cachedIsMaxBasementLevel;

		// Token: 0x04020686 RID: 132742
		[Token(Token = "0x4020686")]
		[FieldOffset(Offset = "0xC8")]
		private SandboxV2DungeonViewModel.SeqNumChecker m_nodeSelectChecker;

		// Token: 0x04020687 RID: 132743
		[Token(Token = "0x4020687")]
		[FieldOffset(Offset = "0xD8")]
		private Tween m_tween;

		// Token: 0x04020688 RID: 132744
		[Token(Token = "0x4020688")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x04020689 RID: 132745
		[Token(Token = "0x4020689")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnClickUpgradeBtn;

		// Token: 0x0402068A RID: 132746
		[Token(Token = "0x402068A")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}

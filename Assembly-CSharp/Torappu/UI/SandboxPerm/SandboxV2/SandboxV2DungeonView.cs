using System;
using Il2CppDummyDll;
using Torappu.DataBind;
using UnityEngine;
using XLua;

namespace Torappu.UI.SandboxPerm.SandboxV2
{
	// Token: 0x0200428E RID: 17038
	[Token(Token = "0x200428E")]
	public class SandboxV2DungeonView : DataBinder<SandboxV2DungeonProperty>
	{
		// Token: 0x0601A3FD RID: 107517 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A3FD")]
		[Address(RVA = "0x133DA00", Offset = "0x133C600", VA = "0x18133DA00")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0601A3FE RID: 107518 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A3FE")]
		[Address(RVA = "0x133D600", Offset = "0x133C200", VA = "0x18133D600", Slot = "7")]
		public override void OnValueChanged(SandboxV2DungeonProperty property)
		{
		}

		// Token: 0x0601A3FF RID: 107519 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A3FF")]
		[Address(RVA = "0x133DC90", Offset = "0x133C890", VA = "0x18133DC90")]
		private void _TutorialOnly_TryRaiseNodePreviewRoutedAVGSignal()
		{
		}

		// Token: 0x0601A400 RID: 107520 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601A400")]
		[Address(RVA = "0x133D820", Offset = "0x133C420", VA = "0x18133D820")]
		public GameObject TutorialOnly_GetCookPanelBtnGo()
		{
			return null;
		}

		// Token: 0x0601A401 RID: 107521 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601A401")]
		[Address(RVA = "0x133D990", Offset = "0x133C590", VA = "0x18133D990")]
		public GameObject TutorialOnly_GetWorkbenchPanelBtnGo()
		{
			return null;
		}

		// Token: 0x0601A402 RID: 107522 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601A402")]
		[Address(RVA = "0x133D910", Offset = "0x133C510", VA = "0x18133D910")]
		public GameObject TutorialOnly_GetSphereBtnGo()
		{
			return null;
		}

		// Token: 0x0601A403 RID: 107523 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601A403")]
		[Address(RVA = "0x133D890", Offset = "0x133C490", VA = "0x18133D890")]
		public GameObject TutorialOnly_GetCrossDayBtnGo()
		{
			return null;
		}

		// Token: 0x0601A404 RID: 107524 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601A404")]
		[Address(RVA = "0x133D7A0", Offset = "0x133C3A0", VA = "0x18133D7A0")]
		public GameObject TutorialOnly_GetBottomBarHomeBtnGo()
		{
			return null;
		}

		// Token: 0x0601A405 RID: 107525 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A405")]
		[Address(RVA = "0x133E000", Offset = "0x133CC00", VA = "0x18133E000")]
		public SandboxV2DungeonView()
		{
		}

		// Token: 0x040213B8 RID: 136120
		[Token(Token = "0x40213B8")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private SandboxV2NodePreviewView _nodePreviewViewPrefab;

		// Token: 0x040213B9 RID: 136121
		[Token(Token = "0x40213B9")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private RectTransform _nodePreviewViewHolder;

		// Token: 0x040213BA RID: 136122
		[Token(Token = "0x40213BA")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private CanvasGroup _nodePreviewViewAlphaHandler;

		// Token: 0x040213BB RID: 136123
		[Token(Token = "0x40213BB")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private RectTransform _homeTipViewHolder;

		// Token: 0x040213BC RID: 136124
		[Token(Token = "0x40213BC")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private SandboxV2DungeonSideBar _sideBar;

		// Token: 0x040213BD RID: 136125
		[Token(Token = "0x40213BD")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private SandboxV2DungeonBottomBar _bottomBar;

		// Token: 0x040213BE RID: 136126
		[Token(Token = "0x40213BE")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private RectTransform _topBarContainer;

		// Token: 0x040213BF RID: 136127
		[Token(Token = "0x40213BF")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private SandboxV2TopBarPanelView _topBarPrefab;

		// Token: 0x040213C0 RID: 136128
		[Token(Token = "0x40213C0")]
		[FieldOffset(Offset = "0x60")]
		private bool m_inited;

		// Token: 0x040213C1 RID: 136129
		[Token(Token = "0x40213C1")]
		[FieldOffset(Offset = "0x68")]
		private SandboxV2DungeonViewModel.SeqNumChecker m_nodeSelectChecker;

		// Token: 0x040213C2 RID: 136130
		[Token(Token = "0x40213C2")]
		[FieldOffset(Offset = "0x78")]
		private SandboxV2DungeonViewModel.SeqNumChecker m_dungeonDataChangeChecker;

		// Token: 0x040213C3 RID: 136131
		[Token(Token = "0x40213C3")]
		[FieldOffset(Offset = "0x88")]
		private UIPageFinder m_pageFinder;

		// Token: 0x040213C4 RID: 136132
		[Token(Token = "0x40213C4")]
		[FieldOffset(Offset = "0x98")]
		private SandboxV2NodePreviewView m_nodePreviewView;

		// Token: 0x040213C5 RID: 136133
		[Token(Token = "0x40213C5")]
		[FieldOffset(Offset = "0xA0")]
		private UISwitchTween m_nodePreviewViewShowTween;

		// Token: 0x040213C6 RID: 136134
		[Token(Token = "0x40213C6")]
		[FieldOffset(Offset = "0xA8")]
		private SandboxV2DungeonHomeTipView m_homeTipView;

		// Token: 0x040213C7 RID: 136135
		[Token(Token = "0x40213C7")]
		[FieldOffset(Offset = "0xB0")]
		private SandboxV2TopBarPanelView m_topBarView;

		// Token: 0x040213C8 RID: 136136
		[Token(Token = "0x40213C8")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x040213C9 RID: 136137
		[Token(Token = "0x40213C9")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnValueChanged;

		// Token: 0x040213CA RID: 136138
		[Token(Token = "0x40213CA")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__TutorialOnly_TryRaiseNodePreviewRoutedAVGSignal;

		// Token: 0x040213CB RID: 136139
		[Token(Token = "0x40213CB")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_TutorialOnly_GetCookPanelBtnGo;

		// Token: 0x040213CC RID: 136140
		[Token(Token = "0x40213CC")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_TutorialOnly_GetWorkbenchPanelBtnGo;

		// Token: 0x040213CD RID: 136141
		[Token(Token = "0x40213CD")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_TutorialOnly_GetSphereBtnGo;

		// Token: 0x040213CE RID: 136142
		[Token(Token = "0x40213CE")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_TutorialOnly_GetCrossDayBtnGo;

		// Token: 0x040213CF RID: 136143
		[Token(Token = "0x40213CF")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_TutorialOnly_GetBottomBarHomeBtnGo;

		// Token: 0x040213D0 RID: 136144
		[Token(Token = "0x40213D0")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x0200428F RID: 17039
		[Token(Token = "0x200428F")]
		private class PreviewViewShowTween : UISwitchTween
		{
			// Token: 0x0601A406 RID: 107526 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601A406")]
			[Address(RVA = "0x13294F0", Offset = "0x13280F0", VA = "0x1813294F0")]
			public PreviewViewShowTween(SandboxV2DungeonView closure)
			{
			}

			// Token: 0x0601A407 RID: 107527 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x601A407")]
			[Address(RVA = "0x13292B0", Offset = "0x1327EB0", VA = "0x1813292B0", Slot = "5")]
			protected override UISwitchTween.ITweenHandler GenerateTweenOfHide()
			{
				return null;
			}

			// Token: 0x0601A408 RID: 107528 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x601A408")]
			[Address(RVA = "0x1329370", Offset = "0x1327F70", VA = "0x181329370", Slot = "4")]
			protected override UISwitchTween.ITweenHandler GenerateTweenOfShow()
			{
				return null;
			}

			// Token: 0x0601A409 RID: 107529 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601A409")]
			[Address(RVA = "0x13291A0", Offset = "0x1327DA0", VA = "0x1813291A0", Slot = "7")]
			protected override void BeforeHideEffect()
			{
			}

			// Token: 0x0601A40A RID: 107530 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601A40A")]
			[Address(RVA = "0x1329090", Offset = "0x1327C90", VA = "0x181329090", Slot = "9")]
			protected override void AfterHideEffect()
			{
			}

			// Token: 0x0601A40B RID: 107531 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601A40B")]
			[Address(RVA = "0x1329220", Offset = "0x1327E20", VA = "0x181329220", Slot = "6")]
			protected override void BeforeShowEffect()
			{
			}

			// Token: 0x0601A40C RID: 107532 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601A40C")]
			[Address(RVA = "0x1329120", Offset = "0x1327D20", VA = "0x181329120", Slot = "8")]
			protected override void AfterShowEffect()
			{
			}

			// Token: 0x0601A40D RID: 107533 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601A40D")]
			[Address(RVA = "0x1329430", Offset = "0x1328030", VA = "0x181329430", Slot = "10")]
			protected override void ResetToState(bool isShow)
			{
			}

			// Token: 0x0601A40E RID: 107534 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601A40E")]
			[Address(RVA = "0x10A4B70", Offset = "0x10A3770", VA = "0x1810A4B70")]
			private void <>xLuaBaseProxy_BeforeHideEffect()
			{
			}

			// Token: 0x0601A40F RID: 107535 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601A40F")]
			[Address(RVA = "0x9C2DA0", Offset = "0x9C19A0", VA = "0x1809C2DA0")]
			private void <>xLuaBaseProxy_AfterHideEffect()
			{
			}

			// Token: 0x0601A410 RID: 107536 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601A410")]
			[Address(RVA = "0xDFAF10", Offset = "0xDF9B10", VA = "0x180DFAF10")]
			private void <>xLuaBaseProxy_BeforeShowEffect()
			{
			}

			// Token: 0x0601A411 RID: 107537 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601A411")]
			[Address(RVA = "0xECEC90", Offset = "0xECD890", VA = "0x180ECEC90")]
			private void <>xLuaBaseProxy_AfterShowEffect()
			{
			}

			// Token: 0x0601A412 RID: 107538 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601A412")]
			[Address(RVA = "0x9B38B0", Offset = "0x9B24B0", VA = "0x1809B38B0")]
			private void <>xLuaBaseProxy_ResetToState(bool P0)
			{
			}

			// Token: 0x040213D1 RID: 136145
			[Token(Token = "0x40213D1")]
			[FieldOffset(Offset = "0x48")]
			private SandboxV2DungeonView m_closure;

			// Token: 0x040213D2 RID: 136146
			[Token(Token = "0x40213D2")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x040213D3 RID: 136147
			[Token(Token = "0x40213D3")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_GenerateTweenOfHide;

			// Token: 0x040213D4 RID: 136148
			[Token(Token = "0x40213D4")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_GenerateTweenOfShow;

			// Token: 0x040213D5 RID: 136149
			[Token(Token = "0x40213D5")]
			[FieldOffset(Offset = "0x18")]
			private static DelegateBridge __Hotfix0_BeforeHideEffect;

			// Token: 0x040213D6 RID: 136150
			[Token(Token = "0x40213D6")]
			[FieldOffset(Offset = "0x20")]
			private static DelegateBridge __Hotfix0_AfterHideEffect;

			// Token: 0x040213D7 RID: 136151
			[Token(Token = "0x40213D7")]
			[FieldOffset(Offset = "0x28")]
			private static DelegateBridge __Hotfix0_BeforeShowEffect;

			// Token: 0x040213D8 RID: 136152
			[Token(Token = "0x40213D8")]
			[FieldOffset(Offset = "0x30")]
			private static DelegateBridge __Hotfix0_AfterShowEffect;

			// Token: 0x040213D9 RID: 136153
			[Token(Token = "0x40213D9")]
			[FieldOffset(Offset = "0x38")]
			private static DelegateBridge __Hotfix0_ResetToState;
		}
	}
}

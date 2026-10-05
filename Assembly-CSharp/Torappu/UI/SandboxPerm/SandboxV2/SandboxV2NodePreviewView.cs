using System;
using AdvancedInspector;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.SandboxPerm.SandboxV2
{
	// Token: 0x02004277 RID: 17015
	[Token(Token = "0x2004277")]
	public class SandboxV2NodePreviewView : MonoBehaviour, IHotfixable
	{
		// Token: 0x0601A36D RID: 107373 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A36D")]
		[Address(RVA = "0x1320A00", Offset = "0x131F600", VA = "0x181320A00")]
		public void Render(SandboxV2DungeonNodeViewModel nodeViewModel, SandboxV2DungeonViewModel dungeonViewModel)
		{
		}

		// Token: 0x0601A36E RID: 107374 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A36E")]
		[Address(RVA = "0x1321330", Offset = "0x131FF30", VA = "0x181321330")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0601A36F RID: 107375 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A36F")]
		[Address(RVA = "0x1320240", Offset = "0x131EE40", VA = "0x181320240")]
		public void CloseWeatherAndZoneBuffDetail()
		{
		}

		// Token: 0x0601A370 RID: 107376 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A370")]
		[Address(RVA = "0x1320820", Offset = "0x131F420", VA = "0x181320820")]
		public void OnSupplyBtnClicked()
		{
		}

		// Token: 0x0601A371 RID: 107377 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A371")]
		[Address(RVA = "0x1320910", Offset = "0x131F510", VA = "0x181320910")]
		public void OnUpgradeBtnClicked()
		{
		}

		// Token: 0x0601A372 RID: 107378 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A372")]
		[Address(RVA = "0x1320560", Offset = "0x131F160", VA = "0x181320560")]
		public void OnMapBtnClicked()
		{
		}

		// Token: 0x0601A373 RID: 107379 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A373")]
		[Address(RVA = "0x1320470", Offset = "0x131F070", VA = "0x181320470")]
		public void OnEnemyDetailBtnClicked()
		{
		}

		// Token: 0x0601A374 RID: 107380 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A374")]
		[Address(RVA = "0x1320380", Offset = "0x131EF80", VA = "0x181320380")]
		public void OnDropDetailBtnClicked()
		{
		}

		// Token: 0x0601A375 RID: 107381 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A375")]
		[Address(RVA = "0x1320650", Offset = "0x131F250", VA = "0x181320650")]
		public void OnStartBattleBtnClicked()
		{
		}

		// Token: 0x0601A376 RID: 107382 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601A376")]
		[Address(RVA = "0x1321210", Offset = "0x131FE10", VA = "0x181321210")]
		public GameObject TutorialOnly_GetStartBattleGo()
		{
			return null;
		}

		// Token: 0x0601A377 RID: 107383 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601A377")]
		[Address(RVA = "0x1321280", Offset = "0x131FE80", VA = "0x181321280")]
		public GameObject TutorialOnly_GetWeatherPreviewBtnGo()
		{
			return null;
		}

		// Token: 0x0601A378 RID: 107384 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601A378")]
		[Address(RVA = "0x1321140", Offset = "0x131FD40", VA = "0x181321140")]
		public GameObject TutorialOnly_GetNodeNamePnl()
		{
			return null;
		}

		// Token: 0x0601A379 RID: 107385 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601A379")]
		[Address(RVA = "0x1321080", Offset = "0x131FC80", VA = "0x181321080")]
		public GameObject TutorialOnly_GetNodeApCostPnl()
		{
			return null;
		}

		// Token: 0x0601A37A RID: 107386 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601A37A")]
		[Address(RVA = "0x13210E0", Offset = "0x131FCE0", VA = "0x1813210E0")]
		public GameObject TutorialOnly_GetNodeCurrApPnl()
		{
			return null;
		}

		// Token: 0x0601A37B RID: 107387 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601A37B")]
		[Address(RVA = "0x13211A0", Offset = "0x131FDA0", VA = "0x1813211A0")]
		public GameObject TutorialOnly_GetNodeUpgradeBtn()
		{
			return null;
		}

		// Token: 0x0601A37C RID: 107388 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A37C")]
		[Address(RVA = "0x1321420", Offset = "0x1320020", VA = "0x181321420")]
		public SandboxV2NodePreviewView()
		{
		}

		// Token: 0x040212D6 RID: 135894
		[Token(Token = "0x40212D6")]
		private const int MAX_AP_POINT = 4;

		// Token: 0x040212D7 RID: 135895
		[Token(Token = "0x40212D7")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		[Group("Ap")]
		private GameObject _pnlAp;

		// Token: 0x040212D8 RID: 135896
		[Token(Token = "0x40212D8")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		[Group("Ap")]
		private UIAtlasImage[] _apPoints;

		// Token: 0x040212D9 RID: 135897
		[Token(Token = "0x40212D9")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		[Group("Ap")]
		private Color _apToUseColor;

		// Token: 0x040212DA RID: 135898
		[Token(Token = "0x40212DA")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		[Group("Ap")]
		private Color _apUsedColor;

		// Token: 0x040212DB RID: 135899
		[Token(Token = "0x40212DB")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		[Group("Ap")]
		private GameObject _tutorialApPanel;

		// Token: 0x040212DC RID: 135900
		[Token(Token = "0x40212DC")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		[Group("Node Title")]
		private GameObject _titlePanel;

		// Token: 0x040212DD RID: 135901
		[Token(Token = "0x40212DD")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		[Group("Node Title")]
		private GameObject _tutorialTitlePanel;

		// Token: 0x040212DE RID: 135902
		[Token(Token = "0x40212DE")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		[Group("Node Title")]
		private Text _nodeTypeText;

		// Token: 0x040212DF RID: 135903
		[Token(Token = "0x40212DF")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		[Group("Node Title")]
		private Text _nodeStageText;

		// Token: 0x040212E0 RID: 135904
		[Token(Token = "0x40212E0")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		[Group("Node Title")]
		private Image _nodeSprite;

		// Token: 0x040212E1 RID: 135905
		[Token(Token = "0x40212E1")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		[Group("Node Title")]
		private Transform _weatherContainer;

		// Token: 0x040212E2 RID: 135906
		[Token(Token = "0x40212E2")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		[Group("Node Title")]
		private SandboxV2NodePreviewWeatherView _weatherViewPrefab;

		// Token: 0x040212E3 RID: 135907
		[Token(Token = "0x40212E3")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		private Text _nodeInfoText;

		// Token: 0x040212E4 RID: 135908
		[Token(Token = "0x40212E4")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		private SandboxV2NodePreviewSupplyView _supplyView;

		// Token: 0x040212E5 RID: 135909
		[Token(Token = "0x40212E5")]
		[FieldOffset(Offset = "0x98")]
		[SerializeField]
		private SandboxV2NodePreviewUpgradeView _upgradeView;

		// Token: 0x040212E6 RID: 135910
		[Token(Token = "0x40212E6")]
		[FieldOffset(Offset = "0xA0")]
		[SerializeField]
		private SandboxV2NodePreviewEnemyView _enemyView;

		// Token: 0x040212E7 RID: 135911
		[Token(Token = "0x40212E7")]
		[FieldOffset(Offset = "0xA8")]
		[SerializeField]
		private SandboxV2NodePreviewDropNpcView _dropNpcView;

		// Token: 0x040212E8 RID: 135912
		[Token(Token = "0x40212E8")]
		[FieldOffset(Offset = "0xB0")]
		[SerializeField]
		private SandboxV2NodePreviewNodeBuffView _nodeBuffView;

		// Token: 0x040212E9 RID: 135913
		[Token(Token = "0x40212E9")]
		[FieldOffset(Offset = "0xB8")]
		[SerializeField]
		private SandboxV2NodePreviewStartBattleView _startBattleView;

		// Token: 0x040212EA RID: 135914
		[Token(Token = "0x40212EA")]
		[FieldOffset(Offset = "0xC0")]
		[SerializeField]
		private Button _btnStartBattle;

		// Token: 0x040212EB RID: 135915
		[Token(Token = "0x40212EB")]
		[FieldOffset(Offset = "0xC8")]
		[SerializeField]
		private GameObject _tutorialApCostPnl;

		// Token: 0x040212EC RID: 135916
		[Token(Token = "0x40212EC")]
		[FieldOffset(Offset = "0xD0")]
		[SerializeField]
		private Button _tutorialUpgradeBtn;

		// Token: 0x040212ED RID: 135917
		[Token(Token = "0x40212ED")]
		[FieldOffset(Offset = "0xD8")]
		[SerializeField]
		[Group("Image Glow")]
		private UIAtlasImage _imgGlow;

		// Token: 0x040212EE RID: 135918
		[Token(Token = "0x40212EE")]
		[FieldOffset(Offset = "0xE0")]
		[SerializeField]
		[Group("Image Glow")]
		private Color _colorEnemyRush;

		// Token: 0x040212EF RID: 135919
		[Token(Token = "0x40212EF")]
		[FieldOffset(Offset = "0xF0")]
		[SerializeField]
		private GameObject _pnlApBkg;

		// Token: 0x040212F0 RID: 135920
		[Token(Token = "0x40212F0")]
		[FieldOffset(Offset = "0xF8")]
		private string m_cachedNodeId;

		// Token: 0x040212F1 RID: 135921
		[Token(Token = "0x40212F1")]
		[FieldOffset(Offset = "0x100")]
		private SandboxV2NodeType m_cachedNodeType;

		// Token: 0x040212F2 RID: 135922
		[Token(Token = "0x40212F2")]
		[FieldOffset(Offset = "0x104")]
		private SandboxV2NodeStartBattleFuncType m_cachedStartBattleFuncType;

		// Token: 0x040212F3 RID: 135923
		[Token(Token = "0x40212F3")]
		[FieldOffset(Offset = "0x108")]
		private UIPageFinder m_pageFinder;

		// Token: 0x040212F4 RID: 135924
		[Token(Token = "0x40212F4")]
		[FieldOffset(Offset = "0x118")]
		private SandboxV2NodePreviewWeatherView m_weatherView;

		// Token: 0x040212F5 RID: 135925
		[Token(Token = "0x40212F5")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x040212F6 RID: 135926
		[Token(Token = "0x40212F6")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x040212F7 RID: 135927
		[Token(Token = "0x40212F7")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_CloseWeatherAndZoneBuffDetail;

		// Token: 0x040212F8 RID: 135928
		[Token(Token = "0x40212F8")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnSupplyBtnClicked;

		// Token: 0x040212F9 RID: 135929
		[Token(Token = "0x40212F9")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_OnUpgradeBtnClicked;

		// Token: 0x040212FA RID: 135930
		[Token(Token = "0x40212FA")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_OnMapBtnClicked;

		// Token: 0x040212FB RID: 135931
		[Token(Token = "0x40212FB")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_OnEnemyDetailBtnClicked;

		// Token: 0x040212FC RID: 135932
		[Token(Token = "0x40212FC")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_OnDropDetailBtnClicked;

		// Token: 0x040212FD RID: 135933
		[Token(Token = "0x40212FD")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_OnStartBattleBtnClicked;

		// Token: 0x040212FE RID: 135934
		[Token(Token = "0x40212FE")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_TutorialOnly_GetStartBattleGo;

		// Token: 0x040212FF RID: 135935
		[Token(Token = "0x40212FF")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_TutorialOnly_GetWeatherPreviewBtnGo;

		// Token: 0x04021300 RID: 135936
		[Token(Token = "0x4021300")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_TutorialOnly_GetNodeNamePnl;

		// Token: 0x04021301 RID: 135937
		[Token(Token = "0x4021301")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0_TutorialOnly_GetNodeApCostPnl;

		// Token: 0x04021302 RID: 135938
		[Token(Token = "0x4021302")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0_TutorialOnly_GetNodeCurrApPnl;

		// Token: 0x04021303 RID: 135939
		[Token(Token = "0x4021303")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0_TutorialOnly_GetNodeUpgradeBtn;

		// Token: 0x04021304 RID: 135940
		[Token(Token = "0x4021304")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}

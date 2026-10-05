using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using Torappu.Battle;
using Torappu.UI.Stage;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.ActivityStage
{
	// Token: 0x02006C8E RID: 27790
	[Token(Token = "0x2006C8E")]
	public class TemplateActivityMapPreviewView : MonoBehaviour, IHotfixable
	{
		// Token: 0x06027A5C RID: 162396 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027A5C")]
		[Address(RVA = "0x22E0EB0", Offset = "0x22DFAB0", VA = "0x1822E0EB0")]
		public void SetConfig(TemplateActivityMapPreviewView.Config config)
		{
		}

		// Token: 0x06027A5D RID: 162397 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027A5D")]
		[Address(RVA = "0x22E0860", Offset = "0x22DF460", VA = "0x1822E0860")]
		public void Render(IStageSelectHandler selectHandler, [Optional] TemplateActivityMapPreviewView.BattleMeta battleMeta)
		{
		}

		// Token: 0x06027A5E RID: 162398 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6027A5E")]
		[Address(RVA = "0x22E1610", Offset = "0x22E0210", VA = "0x1822E1610")]
		private StagePreviewEventHolder _GenEventHolder()
		{
			return null;
		}

		// Token: 0x17005DB1 RID: 23985
		// (get) Token: 0x06027A5F RID: 162399 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17005DB1")]
		public StagePreviewNormalView normalPanel
		{
			[Token(Token = "0x6027A5F")]
			[Address(RVA = "0x22E2670", Offset = "0x22E1270", VA = "0x1822E2670")]
			get
			{
				return null;
			}
		}

		// Token: 0x17005DB2 RID: 23986
		// (get) Token: 0x06027A60 RID: 162400 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17005DB2")]
		public StagePreviewHardView hardPanel
		{
			[Token(Token = "0x6027A60")]
			[Address(RVA = "0x22E2520", Offset = "0x22E1120", VA = "0x1822E2520")]
			get
			{
				return null;
			}
		}

		// Token: 0x06027A61 RID: 162401 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6027A61")]
		private T _InstInfoPanel<T>(Transform container, string path) where T : StagePreviewInfoBasicPanel
		{
			return null;
		}

		// Token: 0x06027A62 RID: 162402 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027A62")]
		[Address(RVA = "0x22E1510", Offset = "0x22E0110", VA = "0x1822E1510")]
		private void _ClearBlurSprite()
		{
		}

		// Token: 0x06027A63 RID: 162403 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027A63")]
		[Address(RVA = "0x22DFF30", Offset = "0x22DEB30", VA = "0x1822DFF30")]
		public void CloseTips()
		{
		}

		// Token: 0x06027A64 RID: 162404 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027A64")]
		[Address(RVA = "0x22E06F0", Offset = "0x22DF2F0", VA = "0x1822E06F0")]
		public void OnStartBattleClick()
		{
		}

		// Token: 0x06027A65 RID: 162405 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027A65")]
		[Address(RVA = "0x22E0350", Offset = "0x22DEF50", VA = "0x1822E0350")]
		public void OnOpenEnemyClick()
		{
		}

		// Token: 0x06027A66 RID: 162406 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027A66")]
		[Address(RVA = "0x22E0530", Offset = "0x22DF130", VA = "0x1822E0530")]
		public void OnOpenRewardClick()
		{
		}

		// Token: 0x06027A67 RID: 162407 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027A67")]
		[Address(RVA = "0x22E01F0", Offset = "0x22DEDF0", VA = "0x1822E01F0")]
		public void OnBeSpecial()
		{
		}

		// Token: 0x06027A68 RID: 162408 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027A68")]
		[Address(RVA = "0x22E0160", Offset = "0x22DED60", VA = "0x1822E0160")]
		public void OnBeNormal()
		{
		}

		// Token: 0x06027A69 RID: 162409 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027A69")]
		[Address(RVA = "0x22E05E0", Offset = "0x22DF1E0", VA = "0x1822E05E0")]
		public void OnOpenRewardHolder()
		{
		}

		// Token: 0x06027A6A RID: 162410 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027A6A")]
		[Address(RVA = "0x22E0780", Offset = "0x22DF380", VA = "0x1822E0780")]
		public void OnStartPractiseClick()
		{
		}

		// Token: 0x06027A6B RID: 162411 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027A6B")]
		[Address(RVA = "0x22E00A0", Offset = "0x22DECA0", VA = "0x1822E00A0")]
		public void OnAutoBattleSwitchClick()
		{
		}

		// Token: 0x06027A6C RID: 162412 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027A6C")]
		[Address(RVA = "0x22E0280", Offset = "0x22DEE80", VA = "0x1822E0280")]
		public void OnLockedHardBattleClick()
		{
		}

		// Token: 0x06027A6D RID: 162413 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6027A6D")]
		[Address(RVA = "0x22E1950", Offset = "0x22E0550", VA = "0x1822E1950")]
		private StageViewModel _GetCurrentSelectedStageViewModel()
		{
			return null;
		}

		// Token: 0x06027A6E RID: 162414 RVA: 0x000CEF70 File Offset: 0x000CD170
		[Token(Token = "0x6027A6E")]
		[Address(RVA = "0x22E1080", Offset = "0x22DFC80", VA = "0x1822E1080")]
		private bool _CheckCostBeforeStartBattle()
		{
			return default(bool);
		}

		// Token: 0x06027A6F RID: 162415 RVA: 0x000CEF88 File Offset: 0x000CD188
		[Token(Token = "0x6027A6F")]
		[Address(RVA = "0x22E0F30", Offset = "0x22DFB30", VA = "0x1822E0F30")]
		private bool _CheckApBeforeStartBattle(int apCost)
		{
			return default(bool);
		}

		// Token: 0x06027A70 RID: 162416 RVA: 0x000CEFA0 File Offset: 0x000CD1A0
		[Token(Token = "0x6027A70")]
		[Address(RVA = "0x22E12D0", Offset = "0x22DFED0", VA = "0x1822E12D0")]
		private bool _CheckEtBeforeStartBattle(string etItemId, int etCost)
		{
			return default(bool);
		}

		// Token: 0x06027A71 RID: 162417 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027A71")]
		[Address(RVA = "0x22E19B0", Offset = "0x22E05B0", VA = "0x1822E19B0")]
		private void _GoToSquad(bool isPractice)
		{
		}

		// Token: 0x06027A72 RID: 162418 RVA: 0x000CEFB8 File Offset: 0x000CD1B8
		[Token(Token = "0x6027A72")]
		[Address(RVA = "0x22E1400", Offset = "0x22E0000", VA = "0x1822E1400")]
		private bool _CheckNeedToLoadBattleLog(out bool allowNoBattleLog)
		{
			return default(bool);
		}

		// Token: 0x06027A73 RID: 162419 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027A73")]
		[Address(RVA = "0x22E1FC0", Offset = "0x22E0BC0", VA = "0x1822E1FC0")]
		private void _OnGoToSquad(bool isPractice)
		{
		}

		// Token: 0x06027A74 RID: 162420 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027A74")]
		[Address(RVA = "0x22E2470", Offset = "0x22E1070", VA = "0x1822E2470")]
		public TemplateActivityMapPreviewView()
		{
		}

		// Token: 0x040383DA RID: 230362
		[Token(Token = "0x40383DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Transform _normalContainer;

		// Token: 0x040383DB RID: 230363
		[Token(Token = "0x40383DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Transform _hardContainer;

		// Token: 0x040383DC RID: 230364
		[Token(Token = "0x40383DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private GameObject _mapTips;

		// Token: 0x040383DD RID: 230365
		[Token(Token = "0x40383DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Image _imageMapTips;

		// Token: 0x040383DE RID: 230366
		[Token(Token = "0x40383DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Image _backTips;

		// Token: 0x040383DF RID: 230367
		[Token(Token = "0x40383DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[SerializeField]
		private TemplateActivityResourceBar _resBar;

		// Token: 0x040383E0 RID: 230368
		[Token(Token = "0x40383E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[NonSerialized]
		public PreviewConfigViewProperty previewConfigProperty;

		// Token: 0x040383E1 RID: 230369
		[Token(Token = "0x40383E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[NonSerialized]
		public TemplateActivityMapPreviewView.Config config;

		// Token: 0x040383E2 RID: 230370
		[Token(Token = "0x40383E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private StagePreviewNormalView m_normalPanel;

		// Token: 0x040383E3 RID: 230371
		[Token(Token = "0x40383E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private StagePreviewHardView m_hardPanel;

		// Token: 0x040383E4 RID: 230372
		[Token(Token = "0x40383E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private StageViewModel m_selectStage;

		// Token: 0x040383E5 RID: 230373
		[Token(Token = "0x40383E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private StageViewModel m_selectStageHard;

		// Token: 0x040383E6 RID: 230374
		[Token(Token = "0x40383E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private StageViewModel m_selectStageNormal;

		// Token: 0x040383E7 RID: 230375
		[Token(Token = "0x40383E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private SpecialStageType m_stageSelectType;

		// Token: 0x040383E8 RID: 230376
		[Token(Token = "0x40383E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private TemplateActivityMapPreviewView.BattleMeta m_battleMeta;

		// Token: 0x040383E9 RID: 230377
		[Token(Token = "0x40383E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private UIPageFinder m_pageFinder;

		// Token: 0x040383EA RID: 230378
		[Token(Token = "0x40383EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_SetConfig;

		// Token: 0x040383EB RID: 230379
		[Token(Token = "0x40383EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x040383EC RID: 230380
		[Token(Token = "0x40383EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__GenEventHolder;

		// Token: 0x040383ED RID: 230381
		[Token(Token = "0x40383ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_get_normalPanel;

		// Token: 0x040383EE RID: 230382
		[Token(Token = "0x40383EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_get_hardPanel;

		// Token: 0x040383EF RID: 230383
		[Token(Token = "0x40383EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__InstInfoPanel;

		// Token: 0x040383F0 RID: 230384
		[Token(Token = "0x40383F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__ClearBlurSprite;

		// Token: 0x040383F1 RID: 230385
		[Token(Token = "0x40383F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_CloseTips;

		// Token: 0x040383F2 RID: 230386
		[Token(Token = "0x40383F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_OnStartBattleClick;

		// Token: 0x040383F3 RID: 230387
		[Token(Token = "0x40383F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_OnOpenEnemyClick;

		// Token: 0x040383F4 RID: 230388
		[Token(Token = "0x40383F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_OnOpenRewardClick;

		// Token: 0x040383F5 RID: 230389
		[Token(Token = "0x40383F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_OnBeSpecial;

		// Token: 0x040383F6 RID: 230390
		[Token(Token = "0x40383F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0_OnBeNormal;

		// Token: 0x040383F7 RID: 230391
		[Token(Token = "0x40383F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0_OnOpenRewardHolder;

		// Token: 0x040383F8 RID: 230392
		[Token(Token = "0x40383F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0_OnStartPractiseClick;

		// Token: 0x040383F9 RID: 230393
		[Token(Token = "0x40383F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0_OnAutoBattleSwitchClick;

		// Token: 0x040383FA RID: 230394
		[Token(Token = "0x40383FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private static DelegateBridge __Hotfix0_OnLockedHardBattleClick;

		// Token: 0x040383FB RID: 230395
		[Token(Token = "0x40383FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private static DelegateBridge __Hotfix0__GetCurrentSelectedStageViewModel;

		// Token: 0x040383FC RID: 230396
		[Token(Token = "0x40383FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private static DelegateBridge __Hotfix0__CheckCostBeforeStartBattle;

		// Token: 0x040383FD RID: 230397
		[Token(Token = "0x40383FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private static DelegateBridge __Hotfix0__CheckApBeforeStartBattle;

		// Token: 0x040383FE RID: 230398
		[Token(Token = "0x40383FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private static DelegateBridge __Hotfix0__CheckEtBeforeStartBattle;

		// Token: 0x040383FF RID: 230399
		[Token(Token = "0x40383FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private static DelegateBridge __Hotfix0__GoToSquad;

		// Token: 0x04038400 RID: 230400
		[Token(Token = "0x4038400")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private static DelegateBridge __Hotfix0__CheckNeedToLoadBattleLog;

		// Token: 0x04038401 RID: 230401
		[Token(Token = "0x4038401")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private static DelegateBridge __Hotfix0__OnGoToSquad;

		// Token: 0x04038402 RID: 230402
		[Token(Token = "0x4038402")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02006C8F RID: 27791
		[Token(Token = "0x2006C8F")]
		public class Config
		{
			// Token: 0x06027A75 RID: 162421 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6027A75")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public Config()
			{
			}

			// Token: 0x04038403 RID: 230403
			[Token(Token = "0x4038403")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public UIStringEvent onBeHard;

			// Token: 0x04038404 RID: 230404
			[Token(Token = "0x4038404")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public UIStringEvent onBeNormal;

			// Token: 0x04038405 RID: 230405
			[Token(Token = "0x4038405")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public UIStringEvent onOpenEnemyHandBook;

			// Token: 0x04038406 RID: 230406
			[Token(Token = "0x4038406")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public UIStringEvent onOpenRewards;

			// Token: 0x04038407 RID: 230407
			[Token(Token = "0x4038407")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public bool isRetro;

			// Token: 0x04038408 RID: 230408
			[Token(Token = "0x4038408")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x31")]
			public bool showStoryReplayFlag;
		}

		// Token: 0x02006C90 RID: 27792
		[Token(Token = "0x2006C90")]
		public class BattleMeta
		{
			// Token: 0x06027A76 RID: 162422 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6027A76")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public BattleMeta()
			{
			}

			// Token: 0x04038409 RID: 230409
			[Token(Token = "0x4038409")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public DataBundle battleBundle;

			// Token: 0x0403840A RID: 230410
			[Token(Token = "0x403840A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public BattleStageMeta stageMeta;
		}
	}
}

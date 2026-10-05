using System;
using System.Collections;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.UI;
using UnityEngine;
using XLua;

namespace Torappu.Activity.Act1VHalfIdle
{
	// Token: 0x0200771D RID: 30493
	[Token(Token = "0x200771D")]
	public class Act1VHalfIdleCharUpgradeState : PopupFadeState, IValueMsgReceiver
	{
		// Token: 0x0602AD6F RID: 175471 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602AD6F")]
		[Address(RVA = "0x269E160", Offset = "0x269CD60", VA = "0x18269E160")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0602AD70 RID: 175472 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602AD70")]
		[Address(RVA = "0x26A00A0", Offset = "0x269ECA0", VA = "0x1826A00A0")]
		private void _SetStableLock(int signal)
		{
		}

		// Token: 0x0602AD71 RID: 175473 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602AD71")]
		[Address(RVA = "0x26A03A0", Offset = "0x269EFA0", VA = "0x1826A03A0")]
		private void _UnsetStableLock(int signal)
		{
		}

		// Token: 0x0602AD72 RID: 175474 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602AD72")]
		[Address(RVA = "0x269D330", Offset = "0x269BF30", VA = "0x18269D330", Slot = "9")]
		public override IStateBean GetCacheBean()
		{
			return null;
		}

		// Token: 0x0602AD73 RID: 175475 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602AD73")]
		[Address(RVA = "0x269D480", Offset = "0x269C080", VA = "0x18269D480", Slot = "14")]
		protected override void OnEnter()
		{
		}

		// Token: 0x0602AD74 RID: 175476 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602AD74")]
		[Address(RVA = "0x269DF10", Offset = "0x269CB10", VA = "0x18269DF10", Slot = "15")]
		protected override void OnResume()
		{
		}

		// Token: 0x0602AD75 RID: 175477 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602AD75")]
		[Address(RVA = "0x269D810", Offset = "0x269C410", VA = "0x18269D810", Slot = "18")]
		protected override void OnExit()
		{
		}

		// Token: 0x0602AD76 RID: 175478 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602AD76")]
		[Address(RVA = "0x269D420", Offset = "0x269C020", VA = "0x18269D420")]
		private void OnDestroy()
		{
		}

		// Token: 0x0602AD77 RID: 175479 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602AD77")]
		[Address(RVA = "0x269D880", Offset = "0x269C480", VA = "0x18269D880", Slot = "31")]
		public void OnMessage(int key, ValueBundle msg)
		{
		}

		// Token: 0x0602AD78 RID: 175480 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602AD78")]
		[Address(RVA = "0x269E330", Offset = "0x269CF30", VA = "0x18269E330")]
		private void _OnCharPreviewClicked()
		{
		}

		// Token: 0x0602AD79 RID: 175481 RVA: 0x000DA2F8 File Offset: 0x000D84F8
		[Token(Token = "0x602AD79")]
		[Address(RVA = "0x269DFE0", Offset = "0x269CBE0", VA = "0x18269DFE0")]
		private bool _CheckIsEvolveSkin(string charId, string skinId)
		{
			return default(bool);
		}

		// Token: 0x0602AD7A RID: 175482 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602AD7A")]
		[Address(RVA = "0x269E660", Offset = "0x269D260", VA = "0x18269E660")]
		private void _OnCharSwitchClicked(int offset)
		{
		}

		// Token: 0x0602AD7B RID: 175483 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602AD7B")]
		[Address(RVA = "0x269F750", Offset = "0x269E350", VA = "0x18269F750")]
		private void _OnSkillUpgradeRankChanged(int offset)
		{
		}

		// Token: 0x0602AD7C RID: 175484 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602AD7C")]
		[Address(RVA = "0x269F920", Offset = "0x269E520", VA = "0x18269F920")]
		private void _OnSkillUpgradeRankMinClicked()
		{
		}

		// Token: 0x0602AD7D RID: 175485 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602AD7D")]
		[Address(RVA = "0x269F840", Offset = "0x269E440", VA = "0x18269F840")]
		private void _OnSkillUpgradeRankMaxClicked()
		{
		}

		// Token: 0x0602AD7E RID: 175486 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602AD7E")]
		[Address(RVA = "0x269ED50", Offset = "0x269D950", VA = "0x18269ED50")]
		private void _OnLevelUpgradeLevelChanged(int offset)
		{
		}

		// Token: 0x0602AD7F RID: 175487 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602AD7F")]
		[Address(RVA = "0x269F060", Offset = "0x269DC60", VA = "0x18269F060")]
		private void _OnLevelUpgradeLevelMinClicked()
		{
		}

		// Token: 0x0602AD80 RID: 175488 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602AD80")]
		[Address(RVA = "0x269EE40", Offset = "0x269DA40", VA = "0x18269EE40")]
		private void _OnLevelUpgradeLevelMaxClicked()
		{
		}

		// Token: 0x0602AD81 RID: 175489 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602AD81")]
		[Address(RVA = "0x269F1B0", Offset = "0x269DDB0", VA = "0x18269F1B0")]
		private void _OnLevelUpgradeLevelUpgradeClicked()
		{
		}

		// Token: 0x0602AD82 RID: 175490 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602AD82")]
		[Address(RVA = "0x269FA70", Offset = "0x269E670", VA = "0x18269FA70")]
		private void _OnSkillUpgradeSkillUpgradeClicked()
		{
		}

		// Token: 0x0602AD83 RID: 175491 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602AD83")]
		[Address(RVA = "0x269F270", Offset = "0x269DE70", VA = "0x18269F270")]
		private void _OnLevelUpgrade()
		{
		}

		// Token: 0x0602AD84 RID: 175492 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602AD84")]
		[Address(RVA = "0x269E870", Offset = "0x269D470", VA = "0x18269E870")]
		private void _OnEliteUpgrade()
		{
		}

		// Token: 0x0602AD85 RID: 175493 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602AD85")]
		[Address(RVA = "0x269FAF0", Offset = "0x269E6F0", VA = "0x18269FAF0")]
		private void _OnSkillUpgrade()
		{
		}

		// Token: 0x0602AD86 RID: 175494 RVA: 0x000DA310 File Offset: 0x000D8510
		[Token(Token = "0x602AD86")]
		[Address(RVA = "0x269E200", Offset = "0x269CE00", VA = "0x18269E200")]
		private bool _IsUIStable()
		{
			return default(bool);
		}

		// Token: 0x0602AD87 RID: 175495 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602AD87")]
		[Address(RVA = "0x269D390", Offset = "0x269BF90", VA = "0x18269D390")]
		public void OnBtnBackClicked()
		{
		}

		// Token: 0x0602AD88 RID: 175496 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602AD88")]
		[Address(RVA = "0x26A0200", Offset = "0x269EE00", VA = "0x1826A0200")]
		private void _TryRaiseAVGSignal()
		{
		}

		// Token: 0x0602AD89 RID: 175497 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602AD89")]
		[Address(RVA = "0x26A0120", Offset = "0x269ED20", VA = "0x1826A0120")]
		private void _StopTutorialCoroutine()
		{
		}

		// Token: 0x0602AD8A RID: 175498 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602AD8A")]
		[Address(RVA = "0x26A0420", Offset = "0x269F020", VA = "0x1826A0420")]
		private IEnumerator _WaitAndRaiseSignal()
		{
			return null;
		}

		// Token: 0x0602AD8B RID: 175499 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602AD8B")]
		[Address(RVA = "0x26A04D0", Offset = "0x269F0D0", VA = "0x1826A04D0")]
		public Act1VHalfIdleCharUpgradeState()
		{
		}

		// Token: 0x0602AD8C RID: 175500 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602AD8C")]
		[Address(RVA = "0xE63450", Offset = "0xE62050", VA = "0x180E63450")]
		private void <>xLuaBaseProxy_OnEnter()
		{
		}

		// Token: 0x0602AD8D RID: 175501 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602AD8D")]
		[Address(RVA = "0xE0F5F0", Offset = "0xE0E1F0", VA = "0x180E0F5F0")]
		private void <>xLuaBaseProxy_OnResume()
		{
		}

		// Token: 0x0602AD8E RID: 175502 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602AD8E")]
		[Address(RVA = "0xE63460", Offset = "0xE62060", VA = "0x180E63460")]
		private void <>xLuaBaseProxy_OnExit()
		{
		}

		// Token: 0x0403DBF5 RID: 252917
		[Token(Token = "0x403DBF5")]
		[NonSerialized]
		public const int MSG_ON_CHAR_PREVIEW_CLICKED = 0;

		// Token: 0x0403DBF6 RID: 252918
		[Token(Token = "0x403DBF6")]
		[NonSerialized]
		public const int MSG_ON_LEVEL_UPGRADE_LEVEL_CHANGED = 1;

		// Token: 0x0403DBF7 RID: 252919
		[Token(Token = "0x403DBF7")]
		[NonSerialized]
		public const int MSG_ON_LEVEL_UPGRADE_LEVEL_MIN_CLICKED = 2;

		// Token: 0x0403DBF8 RID: 252920
		[Token(Token = "0x403DBF8")]
		[NonSerialized]
		public const int MSG_ON_LEVEL_UPGRADE_LEVEL_MAX_CLICKED = 3;

		// Token: 0x0403DBF9 RID: 252921
		[Token(Token = "0x403DBF9")]
		[NonSerialized]
		public const int MSG_ON_LEVEL_UPGRADE_LEVEL_UPGRADE_CLICKED = 4;

		// Token: 0x0403DBFA RID: 252922
		[Token(Token = "0x403DBFA")]
		[NonSerialized]
		public const int MSG_ON_CHAR_SWITCH_CLICKED = 5;

		// Token: 0x0403DBFB RID: 252923
		[Token(Token = "0x403DBFB")]
		[NonSerialized]
		public const int MSG_ON_SKILL_UPGRADE_RANK_CHANGED = 6;

		// Token: 0x0403DBFC RID: 252924
		[Token(Token = "0x403DBFC")]
		[NonSerialized]
		public const int MSG_ON_SKILL_UPGRADE_RANK_MIN_CLICKED = 7;

		// Token: 0x0403DBFD RID: 252925
		[Token(Token = "0x403DBFD")]
		[NonSerialized]
		public const int MSG_ON_SKILL_UPGRADE_RANK_MAX_CLICKED = 8;

		// Token: 0x0403DBFE RID: 252926
		[Token(Token = "0x403DBFE")]
		[NonSerialized]
		public const int MSG_ON_SKILL_UPGRADE_SKILL_UPGRADE_CLICKED = 9;

		// Token: 0x0403DBFF RID: 252927
		[Token(Token = "0x403DBFF")]
		[NonSerialized]
		public const int LOCK_SIGNAL_SEND_REQUEST = 0;

		// Token: 0x0403DC00 RID: 252928
		[Token(Token = "0x403DC00")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private Act1VHalfIdleCharUpgradeView _view;

		// Token: 0x0403DC01 RID: 252929
		[Token(Token = "0x403DC01")]
		[FieldOffset(Offset = "0x78")]
		private Act1VHalfIdleCharUpgradeState.StateBean m_stateBean;

		// Token: 0x0403DC02 RID: 252930
		[Token(Token = "0x403DC02")]
		[FieldOffset(Offset = "0x80")]
		private bool m_inited;

		// Token: 0x0403DC03 RID: 252931
		[Token(Token = "0x403DC03")]
		[FieldOffset(Offset = "0x84")]
		private int m_stableLock;

		// Token: 0x0403DC04 RID: 252932
		[Token(Token = "0x403DC04")]
		[FieldOffset(Offset = "0x88")]
		private Coroutine m_tutorialCoroutine;

		// Token: 0x0403DC05 RID: 252933
		[Token(Token = "0x403DC05")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0403DC06 RID: 252934
		[Token(Token = "0x403DC06")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__SetStableLock;

		// Token: 0x0403DC07 RID: 252935
		[Token(Token = "0x403DC07")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__UnsetStableLock;

		// Token: 0x0403DC08 RID: 252936
		[Token(Token = "0x403DC08")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_GetCacheBean;

		// Token: 0x0403DC09 RID: 252937
		[Token(Token = "0x403DC09")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_OnEnter;

		// Token: 0x0403DC0A RID: 252938
		[Token(Token = "0x403DC0A")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_OnResume;

		// Token: 0x0403DC0B RID: 252939
		[Token(Token = "0x403DC0B")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_OnExit;

		// Token: 0x0403DC0C RID: 252940
		[Token(Token = "0x403DC0C")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_OnDestroy;

		// Token: 0x0403DC0D RID: 252941
		[Token(Token = "0x403DC0D")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_OnMessage;

		// Token: 0x0403DC0E RID: 252942
		[Token(Token = "0x403DC0E")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0__OnCharPreviewClicked;

		// Token: 0x0403DC0F RID: 252943
		[Token(Token = "0x403DC0F")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0__CheckIsEvolveSkin;

		// Token: 0x0403DC10 RID: 252944
		[Token(Token = "0x403DC10")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0__OnCharSwitchClicked;

		// Token: 0x0403DC11 RID: 252945
		[Token(Token = "0x403DC11")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0__OnSkillUpgradeRankChanged;

		// Token: 0x0403DC12 RID: 252946
		[Token(Token = "0x403DC12")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0__OnSkillUpgradeRankMinClicked;

		// Token: 0x0403DC13 RID: 252947
		[Token(Token = "0x403DC13")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0__OnSkillUpgradeRankMaxClicked;

		// Token: 0x0403DC14 RID: 252948
		[Token(Token = "0x403DC14")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0__OnLevelUpgradeLevelChanged;

		// Token: 0x0403DC15 RID: 252949
		[Token(Token = "0x403DC15")]
		[FieldOffset(Offset = "0x80")]
		private static DelegateBridge __Hotfix0__OnLevelUpgradeLevelMinClicked;

		// Token: 0x0403DC16 RID: 252950
		[Token(Token = "0x403DC16")]
		[FieldOffset(Offset = "0x88")]
		private static DelegateBridge __Hotfix0__OnLevelUpgradeLevelMaxClicked;

		// Token: 0x0403DC17 RID: 252951
		[Token(Token = "0x403DC17")]
		[FieldOffset(Offset = "0x90")]
		private static DelegateBridge __Hotfix0__OnLevelUpgradeLevelUpgradeClicked;

		// Token: 0x0403DC18 RID: 252952
		[Token(Token = "0x403DC18")]
		[FieldOffset(Offset = "0x98")]
		private static DelegateBridge __Hotfix0__OnSkillUpgradeSkillUpgradeClicked;

		// Token: 0x0403DC19 RID: 252953
		[Token(Token = "0x403DC19")]
		[FieldOffset(Offset = "0xA0")]
		private static DelegateBridge __Hotfix0__OnLevelUpgrade;

		// Token: 0x0403DC1A RID: 252954
		[Token(Token = "0x403DC1A")]
		[FieldOffset(Offset = "0xA8")]
		private static DelegateBridge __Hotfix0__OnEliteUpgrade;

		// Token: 0x0403DC1B RID: 252955
		[Token(Token = "0x403DC1B")]
		[FieldOffset(Offset = "0xB0")]
		private static DelegateBridge __Hotfix0__OnSkillUpgrade;

		// Token: 0x0403DC1C RID: 252956
		[Token(Token = "0x403DC1C")]
		[FieldOffset(Offset = "0xB8")]
		private static DelegateBridge __Hotfix0__IsUIStable;

		// Token: 0x0403DC1D RID: 252957
		[Token(Token = "0x403DC1D")]
		[FieldOffset(Offset = "0xC0")]
		private static DelegateBridge __Hotfix0_OnBtnBackClicked;

		// Token: 0x0403DC1E RID: 252958
		[Token(Token = "0x403DC1E")]
		[FieldOffset(Offset = "0xC8")]
		private static DelegateBridge __Hotfix0__TryRaiseAVGSignal;

		// Token: 0x0403DC1F RID: 252959
		[Token(Token = "0x403DC1F")]
		[FieldOffset(Offset = "0xD0")]
		private static DelegateBridge __Hotfix0__StopTutorialCoroutine;

		// Token: 0x0403DC20 RID: 252960
		[Token(Token = "0x403DC20")]
		[FieldOffset(Offset = "0xD8")]
		private static DelegateBridge __Hotfix0__WaitAndRaiseSignal;

		// Token: 0x0403DC21 RID: 252961
		[Token(Token = "0x403DC21")]
		[FieldOffset(Offset = "0xE0")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x0200771E RID: 30494
		[Token(Token = "0x200771E")]
		public class StateBean : IStateBean, IHotfixable
		{
			// Token: 0x17006481 RID: 25729
			// (get) Token: 0x0602AD8F RID: 175503 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17006481")]
			public string selectedCharInstId
			{
				[Token(Token = "0x602AD8F")]
				[Address(RVA = "0x26A7FF0", Offset = "0x26A6BF0", VA = "0x1826A7FF0")]
				get
				{
					return null;
				}
			}

			// Token: 0x0602AD90 RID: 175504 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602AD90")]
			[Address(RVA = "0x26A7C20", Offset = "0x26A6820", VA = "0x1826A7C20")]
			public void LoadData(Act1VHalfIdleCharUpgradePage.Param param)
			{
			}

			// Token: 0x0602AD91 RID: 175505 RVA: 0x000DA328 File Offset: 0x000D8528
			[Token(Token = "0x602AD91")]
			[Address(RVA = "0x26A7DE0", Offset = "0x26A69E0", VA = "0x1826A7DE0")]
			public bool SetSelectedCharIndex(bool isLeft)
			{
				return default(bool);
			}

			// Token: 0x0602AD92 RID: 175506 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602AD92")]
			[Address(RVA = "0x26A7F00", Offset = "0x26A6B00", VA = "0x1826A7F00")]
			public StateBean()
			{
			}

			// Token: 0x0403DC22 RID: 252962
			[Token(Token = "0x403DC22")]
			[FieldOffset(Offset = "0x10")]
			public Act1VHalfIdleCharUpgradeProperty property;

			// Token: 0x0403DC23 RID: 252963
			[Token(Token = "0x403DC23")]
			[FieldOffset(Offset = "0x18")]
			public string actId;

			// Token: 0x0403DC24 RID: 252964
			[Token(Token = "0x403DC24")]
			[FieldOffset(Offset = "0x20")]
			public int selectedCharIndex;

			// Token: 0x0403DC25 RID: 252965
			[Token(Token = "0x403DC25")]
			[FieldOffset(Offset = "0x28")]
			public List<string> charList;

			// Token: 0x0403DC26 RID: 252966
			[Token(Token = "0x403DC26")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_get_selectedCharInstId;

			// Token: 0x0403DC27 RID: 252967
			[Token(Token = "0x403DC27")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_LoadData;

			// Token: 0x0403DC28 RID: 252968
			[Token(Token = "0x403DC28")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_SetSelectedCharIndex;

			// Token: 0x0403DC29 RID: 252969
			[Token(Token = "0x403DC29")]
			[FieldOffset(Offset = "0x18")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}
	}
}

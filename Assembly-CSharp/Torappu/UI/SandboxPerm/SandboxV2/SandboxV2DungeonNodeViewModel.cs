using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.SandboxPerm.SandboxV2
{
	// Token: 0x020042BF RID: 17087
	[Token(Token = "0x20042BF")]
	public abstract class SandboxV2DungeonNodeViewModel : IHotfixable
	{
		// Token: 0x17003E5F RID: 15967
		// (get) Token: 0x0601A48A RID: 107658 RVA: 0x000A0B00 File Offset: 0x0009ED00
		[Token(Token = "0x17003E5F")]
		public bool unlocked
		{
			[Token(Token = "0x601A48A")]
			[Address(RVA = "0x1339F50", Offset = "0x1338B50", VA = "0x181339F50")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x0601A48B RID: 107659 RVA: 0x000A0B18 File Offset: 0x0009ED18
		[Token(Token = "0x601A48B")]
		[Address(RVA = "0x1336F70", Offset = "0x1335B70", VA = "0x181336F70")]
		public SandboxV2Const.SandboxV2BattleBgmType GetBattleBgmType()
		{
			return SandboxV2Const.SandboxV2BattleBgmType.NONE;
		}

		// Token: 0x0601A48C RID: 107660 RVA: 0x000A0B30 File Offset: 0x0009ED30
		[Token(Token = "0x601A48C")]
		[Address(RVA = "0x13376E0", Offset = "0x13362E0", VA = "0x1813376E0")]
		private SandboxV2Const.SandboxV2BattleBgmType _GetEnemyRushBgmType()
		{
			return SandboxV2Const.SandboxV2BattleBgmType.NONE;
		}

		// Token: 0x17003E60 RID: 15968
		// (get) Token: 0x0601A48D RID: 107661 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17003E60")]
		public string weatherId
		{
			[Token(Token = "0x601A48D")]
			[Address(RVA = "0x1339FB0", Offset = "0x1338BB0", VA = "0x181339FB0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17003E61 RID: 15969
		// (get) Token: 0x0601A48E RID: 107662 RVA: 0x000A0B48 File Offset: 0x0009ED48
		[Token(Token = "0x17003E61")]
		public SandboxV2NodeAppearanceType appearanceType
		{
			[Token(Token = "0x601A48E")]
			[Address(RVA = "0x1339340", Offset = "0x1337F40", VA = "0x181339340")]
			get
			{
				return SandboxV2NodeAppearanceType.NONE;
			}
		}

		// Token: 0x17003E62 RID: 15970
		// (get) Token: 0x0601A48F RID: 107663 RVA: 0x000A0B60 File Offset: 0x0009ED60
		[Token(Token = "0x17003E62")]
		public bool cleared
		{
			[Token(Token = "0x601A48F")]
			[Address(RVA = "0x1339490", Offset = "0x1338090", VA = "0x181339490")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17003E63 RID: 15971
		// (get) Token: 0x0601A490 RID: 107664 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17003E63")]
		public string nodeDesc
		{
			[Token(Token = "0x601A490")]
			[Address(RVA = "0x13398C0", Offset = "0x13384C0", VA = "0x1813398C0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17003E64 RID: 15972
		// (get) Token: 0x0601A491 RID: 107665 RVA: 0x000A0B78 File Offset: 0x0009ED78
		[Token(Token = "0x17003E64")]
		public bool canSelectWhenEmergency
		{
			[Token(Token = "0x601A491")]
			[Address(RVA = "0x1339410", Offset = "0x1338010", VA = "0x181339410")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17003E65 RID: 15973
		// (get) Token: 0x0601A492 RID: 107666 RVA: 0x000A0B90 File Offset: 0x0009ED90
		[Token(Token = "0x17003E65")]
		public bool isConstruct
		{
			[Token(Token = "0x601A492")]
			[Address(RVA = "0x1339760", Offset = "0x1338360", VA = "0x181339760")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17003E66 RID: 15974
		// (get) Token: 0x0601A493 RID: 107667 RVA: 0x000A0BA8 File Offset: 0x0009EDA8
		[Token(Token = "0x17003E66")]
		public SandboxV2DungeonProgressViewModel progress
		{
			[Token(Token = "0x601A493")]
			[Address(RVA = "0x1339C50", Offset = "0x1338850", VA = "0x181339C50")]
			get
			{
				return default(SandboxV2DungeonProgressViewModel);
			}
		}

		// Token: 0x17003E67 RID: 15975
		// (get) Token: 0x0601A494 RID: 107668 RVA: 0x000A0BC0 File Offset: 0x0009EDC0
		[Token(Token = "0x17003E67")]
		public SandboxV2NodeStartBattleFuncType startBattleFuncType
		{
			[Token(Token = "0x601A494")]
			[Address(RVA = "0x1339E70", Offset = "0x1338A70", VA = "0x181339E70")]
			get
			{
				return SandboxV2NodeStartBattleFuncType.NONE;
			}
		}

		// Token: 0x17003E68 RID: 15976
		// (get) Token: 0x0601A495 RID: 107669 RVA: 0x000A0BD8 File Offset: 0x0009EDD8
		[Token(Token = "0x17003E68")]
		public SandboxV2EnemyDetailShowType enemyDetailShowType
		{
			[Token(Token = "0x601A495")]
			[Address(RVA = "0x1339680", Offset = "0x1338280", VA = "0x181339680")]
			get
			{
				return SandboxV2EnemyDetailShowType.NONE;
			}
		}

		// Token: 0x17003E69 RID: 15977
		// (get) Token: 0x0601A496 RID: 107670 RVA: 0x000A0BF0 File Offset: 0x0009EDF0
		[Token(Token = "0x17003E69")]
		public int apCost
		{
			[Token(Token = "0x601A496")]
			[Address(RVA = "0x1339260", Offset = "0x1337E60", VA = "0x181339260")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17003E6A RID: 15978
		// (get) Token: 0x0601A497 RID: 107671 RVA: 0x000A0C08 File Offset: 0x0009EE08
		[Token(Token = "0x17003E6A")]
		public bool showTitle
		{
			[Token(Token = "0x601A497")]
			[Address(RVA = "0x1339D90", Offset = "0x1338990", VA = "0x181339D90")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17003E6B RID: 15979
		// (get) Token: 0x0601A498 RID: 107672 RVA: 0x000A0C20 File Offset: 0x0009EE20
		[Token(Token = "0x17003E6B")]
		public bool isUpgradable
		{
			[Token(Token = "0x601A498")]
			[Address(RVA = "0x13397E0", Offset = "0x13383E0", VA = "0x1813397E0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17003E6C RID: 15980
		// (get) Token: 0x0601A499 RID: 107673 RVA: 0x000A0C38 File Offset: 0x0009EE38
		[Token(Token = "0x17003E6C")]
		public SandboxV2NodeSelectionShowType nodeSelectionShowType
		{
			[Token(Token = "0x601A499")]
			[Address(RVA = "0x1339A20", Offset = "0x1338620", VA = "0x181339A20")]
			get
			{
				return SandboxV2NodeSelectionShowType.NONE;
			}
		}

		// Token: 0x17003E6D RID: 15981
		// (get) Token: 0x0601A49A RID: 107674 RVA: 0x000A0C50 File Offset: 0x0009EE50
		[Token(Token = "0x17003E6D")]
		public SandboxV2DungeonNodeFocusPosType nodeFocusPosTypeOnSelected
		{
			[Token(Token = "0x601A49A")]
			[Address(RVA = "0x1339940", Offset = "0x1338540", VA = "0x181339940")]
			get
			{
				return SandboxV2DungeonNodeFocusPosType.MIDDLE_LEFT;
			}
		}

		// Token: 0x0601A49B RID: 107675 RVA: 0x000A0C68 File Offset: 0x0009EE68
		[Token(Token = "0x601A49B")]
		[Address(RVA = "0x132A130", Offset = "0x1328D30", VA = "0x18132A130", Slot = "4")]
		protected virtual bool IsConstructNode()
		{
			return default(bool);
		}

		// Token: 0x0601A49C RID: 107676 RVA: 0x000A0C80 File Offset: 0x0009EE80
		[Token(Token = "0x601A49C")]
		[Address(RVA = "0x1329670", Offset = "0x1328270", VA = "0x181329670", Slot = "5")]
		protected virtual bool IsCleared()
		{
			return default(bool);
		}

		// Token: 0x0601A49D RID: 107677 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601A49D")]
		[Address(RVA = "0x132DFC0", Offset = "0x132CBC0", VA = "0x18132DFC0", Slot = "6")]
		protected virtual string GetNodeDesc()
		{
			return null;
		}

		// Token: 0x0601A49E RID: 107678 RVA: 0x000A0C98 File Offset: 0x0009EE98
		[Token(Token = "0x601A49E")]
		[Address(RVA = "0x132DF50", Offset = "0x132CB50", VA = "0x18132DF50", Slot = "7")]
		protected virtual bool CanSelectWhenEmergency()
		{
			return default(bool);
		}

		// Token: 0x0601A49F RID: 107679 RVA: 0x000A0CB0 File Offset: 0x0009EEB0
		[Token(Token = "0x601A49F")]
		[Address(RVA = "0x132A190", Offset = "0x1328D90", VA = "0x18132A190", Slot = "8")]
		protected virtual bool IsUpgradable()
		{
			return default(bool);
		}

		// Token: 0x0601A4A0 RID: 107680 RVA: 0x000A0CC8 File Offset: 0x0009EEC8
		[Token(Token = "0x601A4A0")]
		[Address(RVA = "0x132A070", Offset = "0x1328C70", VA = "0x18132A070", Slot = "9")]
		protected virtual SandboxV2EnemyDetailShowType GetNodeEnemyDetailShowType()
		{
			return SandboxV2EnemyDetailShowType.NONE;
		}

		// Token: 0x0601A4A1 RID: 107681 RVA: 0x000A0CE0 File Offset: 0x0009EEE0
		[Token(Token = "0x601A4A1")]
		[Address(RVA = "0x132A0D0", Offset = "0x1328CD0", VA = "0x18132A0D0", Slot = "10")]
		protected virtual SandboxV2NodeStartBattleFuncType GetNodeStartBattleFuncType()
		{
			return SandboxV2NodeStartBattleFuncType.NONE;
		}

		// Token: 0x0601A4A2 RID: 107682 RVA: 0x000A0CF8 File Offset: 0x0009EEF8
		[Token(Token = "0x601A4A2")]
		[Address(RVA = "0x132A010", Offset = "0x1328C10", VA = "0x18132A010", Slot = "11")]
		protected virtual int GetNodeActionCost()
		{
			return 0;
		}

		// Token: 0x0601A4A3 RID: 107683 RVA: 0x000A0D10 File Offset: 0x0009EF10
		[Token(Token = "0x601A4A3")]
		[Address(RVA = "0x1329810", Offset = "0x1328410", VA = "0x181329810", Slot = "12")]
		protected virtual SandboxV2DungeonProgressViewModel GetProgressViewModel()
		{
			return default(SandboxV2DungeonProgressViewModel);
		}

		// Token: 0x0601A4A4 RID: 107684 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A4A4")]
		[Address(RVA = "0x13298A0", Offset = "0x13284A0", VA = "0x1813298A0", Slot = "13")]
		protected virtual void UpdateCustomData(SandboxV2DungeonNodeViewModel.UpdateParam updateParam)
		{
		}

		// Token: 0x0601A4A5 RID: 107685 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A4A5")]
		[Address(RVA = "0x1337800", Offset = "0x1336400", VA = "0x181337800")]
		private void _UpdateBasicData(SandboxV2DungeonNodeViewModel.UpdateParam updateParam)
		{
		}

		// Token: 0x0601A4A6 RID: 107686 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A4A6")]
		[Address(RVA = "0x1337B50", Offset = "0x1336750", VA = "0x181337B50")]
		private void _UpdateData(SandboxV2DungeonNodeViewModel.UpdateParam updateParam)
		{
		}

		// Token: 0x0601A4A7 RID: 107687 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A4A7")]
		[Address(RVA = "0x13371E0", Offset = "0x1335DE0", VA = "0x1813371E0")]
		public void LoadData(SandboxV2DungeonNodeViewModel.LoadParam loadParam)
		{
		}

		// Token: 0x0601A4A8 RID: 107688 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A4A8")]
		[Address(RVA = "0x1337440", Offset = "0x1336040", VA = "0x181337440")]
		public void UpdateData(SandboxV2DungeonNodeViewModel.UpdateParam updateParam)
		{
		}

		// Token: 0x0601A4A9 RID: 107689 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A4A9")]
		[Address(RVA = "0x13387C0", Offset = "0x13373C0", VA = "0x1813387C0")]
		private void _UpdateUpgradesData(SandboxV2DungeonNodeViewModel.UpdateParam updateParam)
		{
		}

		// Token: 0x0601A4AA RID: 107690 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A4AA")]
		[Address(RVA = "0x13384C0", Offset = "0x13370C0", VA = "0x1813384C0")]
		private void _UpdateNpcData(SandboxV2DungeonNodeViewModel.UpdateParam updateParam)
		{
		}

		// Token: 0x0601A4AB RID: 107691 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A4AB")]
		[Address(RVA = "0x1337EB0", Offset = "0x1336AB0", VA = "0x181337EB0")]
		private void _UpdateEventData(SandboxV2DungeonNodeViewModel.UpdateParam updateParam)
		{
		}

		// Token: 0x0601A4AC RID: 107692 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A4AC")]
		[Address(RVA = "0x1338220", Offset = "0x1336E20", VA = "0x181338220")]
		private void _UpdateNodeBuffData(SandboxV2DungeonNodeViewModel.UpdateParam updateParam)
		{
		}

		// Token: 0x0601A4AD RID: 107693 RVA: 0x000A0D28 File Offset: 0x0009EF28
		[Token(Token = "0x601A4AD")]
		[Address(RVA = "0x1337130", Offset = "0x1335D30", VA = "0x181337130", Slot = "14")]
		public virtual Vector2 GetConnectorOffset(Vector2 otherNodePos)
		{
			return default(Vector2);
		}

		// Token: 0x0601A4AE RID: 107694 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A4AE")]
		[Address(RVA = "0x13375B0", Offset = "0x13361B0", VA = "0x1813375B0")]
		private void _AddFloat(SandboxV2DungeonFloatViewModel nodeFloat)
		{
		}

		// Token: 0x0601A4AF RID: 107695 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A4AF")]
		private void _AddFloatFromGroup<T>(IList<T> group) where T : SandboxV2DungeonFloatViewModel
		{
		}

		// Token: 0x0601A4B0 RID: 107696 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A4B0")]
		[Address(RVA = "0x1336980", Offset = "0x1335580", VA = "0x181336980")]
		public void GenerateFloatViewModel()
		{
		}

		// Token: 0x0601A4B1 RID: 107697 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601A4B1")]
		[Address(RVA = "0x1336220", Offset = "0x1334E20", VA = "0x181336220")]
		public static SandboxV2DungeonNodeViewModel CreateNodeViewModel(SandboxV2NodeType nodeType)
		{
			return null;
		}

		// Token: 0x0601A4B2 RID: 107698 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A4B2")]
		protected static void GetNodeStageEntityHpRatio<TPlayerEntity>(List<TPlayerEntity> entities, out bool isAllDead, out float hpRatio) where TPlayerEntity : PlayerSandboxV2.Dungeon.EntityStatus
		{
		}

		// Token: 0x0601A4B3 RID: 107699 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A4B3")]
		[Address(RVA = "0x1338C80", Offset = "0x1337880", VA = "0x181338C80")]
		protected SandboxV2DungeonNodeViewModel()
		{
		}

		// Token: 0x04021511 RID: 136465
		[Token(Token = "0x4021511")]
		private const int RARE_ANIMAL_SINGLE_HP_RATIO_FULL = 10000;

		// Token: 0x04021512 RID: 136466
		[Token(Token = "0x4021512")]
		[FieldOffset(Offset = "0x10")]
		public string topicId;

		// Token: 0x04021513 RID: 136467
		[Token(Token = "0x4021513")]
		[FieldOffset(Offset = "0x18")]
		public string nodeId;

		// Token: 0x04021514 RID: 136468
		[Token(Token = "0x4021514")]
		[FieldOffset(Offset = "0x20")]
		public string zoneId;

		// Token: 0x04021515 RID: 136469
		[Token(Token = "0x4021515")]
		[FieldOffset(Offset = "0x28")]
		public bool isCenterNode;

		// Token: 0x04021516 RID: 136470
		[Token(Token = "0x4021516")]
		[FieldOffset(Offset = "0x2C")]
		public Vector2 pos;

		// Token: 0x04021517 RID: 136471
		[Token(Token = "0x4021517")]
		[FieldOffset(Offset = "0x38")]
		public Dictionary<string, string> connection;

		// Token: 0x04021518 RID: 136472
		[Token(Token = "0x4021518")]
		[FieldOffset(Offset = "0x40")]
		public SandboxV2NodeType nodeType;

		// Token: 0x04021519 RID: 136473
		[Token(Token = "0x4021519")]
		[FieldOffset(Offset = "0x48")]
		public string nodeTypeName;

		// Token: 0x0402151A RID: 136474
		[Token(Token = "0x402151A")]
		[FieldOffset(Offset = "0x50")]
		public string nodeTypeIconId;

		// Token: 0x0402151B RID: 136475
		[Token(Token = "0x402151B")]
		[FieldOffset(Offset = "0x58")]
		public float focusDistance;

		// Token: 0x0402151C RID: 136476
		[Token(Token = "0x402151C")]
		[FieldOffset(Offset = "0x5C")]
		public int focusDistanceIndex;

		// Token: 0x0402151D RID: 136477
		[Token(Token = "0x402151D")]
		[FieldOffset(Offset = "0x60")]
		public float centerMinDistance;

		// Token: 0x0402151E RID: 136478
		[Token(Token = "0x402151E")]
		[FieldOffset(Offset = "0x68")]
		public string nodeStageId;

		// Token: 0x0402151F RID: 136479
		[Token(Token = "0x402151F")]
		[FieldOffset(Offset = "0x70")]
		public string levelId;

		// Token: 0x04021520 RID: 136480
		[Token(Token = "0x4021520")]
		[FieldOffset(Offset = "0x78")]
		public string nodeName;

		// Token: 0x04021521 RID: 136481
		[Token(Token = "0x4021521")]
		[FieldOffset(Offset = "0x80")]
		public string stageDesc;

		// Token: 0x04021522 RID: 136482
		[Token(Token = "0x4021522")]
		[FieldOffset(Offset = "0x88")]
		public int actionCost;

		// Token: 0x04021523 RID: 136483
		[Token(Token = "0x4021523")]
		[FieldOffset(Offset = "0x8C")]
		public int actionCostEnemyRush;

		// Token: 0x04021524 RID: 136484
		[Token(Token = "0x4021524")]
		[FieldOffset(Offset = "0x90")]
		public SandboxV2WeatherType nodeWeatherType;

		// Token: 0x04021525 RID: 136485
		[Token(Token = "0x4021525")]
		[FieldOffset(Offset = "0x94")]
		public int nodeWeatherRank;

		// Token: 0x04021526 RID: 136486
		[Token(Token = "0x4021526")]
		[FieldOffset(Offset = "0x98")]
		public SandboxV2WeatherData nodeWeatherData;

		// Token: 0x04021527 RID: 136487
		[Token(Token = "0x4021527")]
		[FieldOffset(Offset = "0xA0")]
		public SandboxV2NodeState nodeState;

		// Token: 0x04021528 RID: 136488
		[Token(Token = "0x4021528")]
		[FieldOffset(Offset = "0xA4")]
		public PlayerSandboxV2.StageState stageState;

		// Token: 0x04021529 RID: 136489
		[Token(Token = "0x4021529")]
		[FieldOffset(Offset = "0xA8")]
		public Dictionary<string, int> upgrades;

		// Token: 0x0402152A RID: 136490
		[Token(Token = "0x402152A")]
		[FieldOffset(Offset = "0xB0")]
		public List<string> completedUpgrades;

		// Token: 0x0402152B RID: 136491
		[Token(Token = "0x402152B")]
		[FieldOffset(Offset = "0xB8")]
		public SandboxV2DungeonEnemyRushGroupViewModel enemyRushGroup;

		// Token: 0x0402152C RID: 136492
		[Token(Token = "0x402152C")]
		[FieldOffset(Offset = "0xC0")]
		public SandboxV2DungeonRareAnimalGroupViewModel rareAnimalGroup;

		// Token: 0x0402152D RID: 136493
		[Token(Token = "0x402152D")]
		[FieldOffset(Offset = "0xC8")]
		public List<SandboxV2DungeonNpcViewModel> npcGroup;

		// Token: 0x0402152E RID: 136494
		[Token(Token = "0x402152E")]
		[FieldOffset(Offset = "0xD0")]
		public SandboxV2DungeonEventGroupViewModel eventGroup;

		// Token: 0x0402152F RID: 136495
		[Token(Token = "0x402152F")]
		[FieldOffset(Offset = "0xD8")]
		public SandboxV2DungeonRiftFloatViewModel riftFloat;

		// Token: 0x04021530 RID: 136496
		[Token(Token = "0x4021530")]
		[FieldOffset(Offset = "0xE0")]
		public SandboxV2DungeonFloatGroupViewModel floatGroup;

		// Token: 0x04021531 RID: 136497
		[Token(Token = "0x4021531")]
		[FieldOffset(Offset = "0xE8")]
		public SandboxV2DungeonNodeDropViewModel nodeDropViewModel;

		// Token: 0x04021532 RID: 136498
		[Token(Token = "0x4021532")]
		[FieldOffset(Offset = "0xF0")]
		public SandboxV2DungeonNodeBuffViewModel nodeBuffViewModel;

		// Token: 0x04021533 RID: 136499
		[Token(Token = "0x4021533")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_unlocked;

		// Token: 0x04021534 RID: 136500
		[Token(Token = "0x4021534")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_GetBattleBgmType;

		// Token: 0x04021535 RID: 136501
		[Token(Token = "0x4021535")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__GetEnemyRushBgmType;

		// Token: 0x04021536 RID: 136502
		[Token(Token = "0x4021536")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_get_weatherId;

		// Token: 0x04021537 RID: 136503
		[Token(Token = "0x4021537")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_get_appearanceType;

		// Token: 0x04021538 RID: 136504
		[Token(Token = "0x4021538")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_get_cleared;

		// Token: 0x04021539 RID: 136505
		[Token(Token = "0x4021539")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_get_nodeDesc;

		// Token: 0x0402153A RID: 136506
		[Token(Token = "0x402153A")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_get_canSelectWhenEmergency;

		// Token: 0x0402153B RID: 136507
		[Token(Token = "0x402153B")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_get_isConstruct;

		// Token: 0x0402153C RID: 136508
		[Token(Token = "0x402153C")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_get_progress;

		// Token: 0x0402153D RID: 136509
		[Token(Token = "0x402153D")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_get_startBattleFuncType;

		// Token: 0x0402153E RID: 136510
		[Token(Token = "0x402153E")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_get_enemyDetailShowType;

		// Token: 0x0402153F RID: 136511
		[Token(Token = "0x402153F")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0_get_apCost;

		// Token: 0x04021540 RID: 136512
		[Token(Token = "0x4021540")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0_get_showTitle;

		// Token: 0x04021541 RID: 136513
		[Token(Token = "0x4021541")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0_get_isUpgradable;

		// Token: 0x04021542 RID: 136514
		[Token(Token = "0x4021542")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0_get_nodeSelectionShowType;

		// Token: 0x04021543 RID: 136515
		[Token(Token = "0x4021543")]
		[FieldOffset(Offset = "0x80")]
		private static DelegateBridge __Hotfix0_get_nodeFocusPosTypeOnSelected;

		// Token: 0x04021544 RID: 136516
		[Token(Token = "0x4021544")]
		[FieldOffset(Offset = "0x88")]
		private static DelegateBridge __Hotfix0_IsConstructNode;

		// Token: 0x04021545 RID: 136517
		[Token(Token = "0x4021545")]
		[FieldOffset(Offset = "0x90")]
		private static DelegateBridge __Hotfix0_IsCleared;

		// Token: 0x04021546 RID: 136518
		[Token(Token = "0x4021546")]
		[FieldOffset(Offset = "0x98")]
		private static DelegateBridge __Hotfix0_GetNodeDesc;

		// Token: 0x04021547 RID: 136519
		[Token(Token = "0x4021547")]
		[FieldOffset(Offset = "0xA0")]
		private static DelegateBridge __Hotfix0_CanSelectWhenEmergency;

		// Token: 0x04021548 RID: 136520
		[Token(Token = "0x4021548")]
		[FieldOffset(Offset = "0xA8")]
		private static DelegateBridge __Hotfix0_IsUpgradable;

		// Token: 0x04021549 RID: 136521
		[Token(Token = "0x4021549")]
		[FieldOffset(Offset = "0xB0")]
		private static DelegateBridge __Hotfix0_GetNodeEnemyDetailShowType;

		// Token: 0x0402154A RID: 136522
		[Token(Token = "0x402154A")]
		[FieldOffset(Offset = "0xB8")]
		private static DelegateBridge __Hotfix0_GetNodeStartBattleFuncType;

		// Token: 0x0402154B RID: 136523
		[Token(Token = "0x402154B")]
		[FieldOffset(Offset = "0xC0")]
		private static DelegateBridge __Hotfix0_GetNodeActionCost;

		// Token: 0x0402154C RID: 136524
		[Token(Token = "0x402154C")]
		[FieldOffset(Offset = "0xC8")]
		private static DelegateBridge __Hotfix0_GetProgressViewModel;

		// Token: 0x0402154D RID: 136525
		[Token(Token = "0x402154D")]
		[FieldOffset(Offset = "0xD0")]
		private static DelegateBridge __Hotfix0_UpdateCustomData;

		// Token: 0x0402154E RID: 136526
		[Token(Token = "0x402154E")]
		[FieldOffset(Offset = "0xD8")]
		private static DelegateBridge __Hotfix0__UpdateBasicData;

		// Token: 0x0402154F RID: 136527
		[Token(Token = "0x402154F")]
		[FieldOffset(Offset = "0xE0")]
		private static DelegateBridge __Hotfix0__UpdateData;

		// Token: 0x04021550 RID: 136528
		[Token(Token = "0x4021550")]
		[FieldOffset(Offset = "0xE8")]
		private static DelegateBridge __Hotfix0_LoadData;

		// Token: 0x04021551 RID: 136529
		[Token(Token = "0x4021551")]
		[FieldOffset(Offset = "0xF0")]
		private static DelegateBridge __Hotfix0_UpdateData;

		// Token: 0x04021552 RID: 136530
		[Token(Token = "0x4021552")]
		[FieldOffset(Offset = "0xF8")]
		private static DelegateBridge __Hotfix0__UpdateUpgradesData;

		// Token: 0x04021553 RID: 136531
		[Token(Token = "0x4021553")]
		[FieldOffset(Offset = "0x100")]
		private static DelegateBridge __Hotfix0__UpdateNpcData;

		// Token: 0x04021554 RID: 136532
		[Token(Token = "0x4021554")]
		[FieldOffset(Offset = "0x108")]
		private static DelegateBridge __Hotfix0__UpdateEventData;

		// Token: 0x04021555 RID: 136533
		[Token(Token = "0x4021555")]
		[FieldOffset(Offset = "0x110")]
		private static DelegateBridge __Hotfix0__UpdateNodeBuffData;

		// Token: 0x04021556 RID: 136534
		[Token(Token = "0x4021556")]
		[FieldOffset(Offset = "0x118")]
		private static DelegateBridge __Hotfix0_GetConnectorOffset;

		// Token: 0x04021557 RID: 136535
		[Token(Token = "0x4021557")]
		[FieldOffset(Offset = "0x120")]
		private static DelegateBridge __Hotfix0__AddFloat;

		// Token: 0x04021558 RID: 136536
		[Token(Token = "0x4021558")]
		[FieldOffset(Offset = "0x128")]
		private static DelegateBridge __Hotfix0__AddFloatFromGroup;

		// Token: 0x04021559 RID: 136537
		[Token(Token = "0x4021559")]
		[FieldOffset(Offset = "0x130")]
		private static DelegateBridge __Hotfix0_GenerateFloatViewModel;

		// Token: 0x0402155A RID: 136538
		[Token(Token = "0x402155A")]
		[FieldOffset(Offset = "0x138")]
		private static DelegateBridge __Hotfix0_CreateNodeViewModel;

		// Token: 0x0402155B RID: 136539
		[Token(Token = "0x402155B")]
		[FieldOffset(Offset = "0x140")]
		private static DelegateBridge __Hotfix0_GetNodeStageEntityHpRatio;

		// Token: 0x0402155C RID: 136540
		[Token(Token = "0x402155C")]
		[FieldOffset(Offset = "0x148")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x020042C0 RID: 17088
		[Token(Token = "0x20042C0")]
		public struct LoadParam
		{
			// Token: 0x0402155D RID: 136541
			[Token(Token = "0x402155D")]
			[FieldOffset(Offset = "0x0")]
			public string topicId;

			// Token: 0x0402155E RID: 136542
			[Token(Token = "0x402155E")]
			[FieldOffset(Offset = "0x8")]
			public string nodeId;

			// Token: 0x0402155F RID: 136543
			[Token(Token = "0x402155F")]
			[FieldOffset(Offset = "0x10")]
			public string centerNodeId;

			// Token: 0x04021560 RID: 136544
			[Token(Token = "0x4021560")]
			[FieldOffset(Offset = "0x18")]
			public SandboxV2Data topicDetailData;

			// Token: 0x04021561 RID: 136545
			[Token(Token = "0x4021561")]
			[FieldOffset(Offset = "0x20")]
			public PlayerSandboxV2.Dungeon.Node playerNodeData;

			// Token: 0x04021562 RID: 136546
			[Token(Token = "0x4021562")]
			[FieldOffset(Offset = "0x28")]
			public SandboxV2MapData mapData;
		}

		// Token: 0x020042C1 RID: 17089
		[Token(Token = "0x20042C1")]
		public struct UpdateParam
		{
			// Token: 0x04021563 RID: 136547
			[Token(Token = "0x4021563")]
			[FieldOffset(Offset = "0x0")]
			public SandboxV2Data topicDetailData;

			// Token: 0x04021564 RID: 136548
			[Token(Token = "0x4021564")]
			[FieldOffset(Offset = "0x8")]
			public PlayerSandboxV2 playerTopicData;

			// Token: 0x04021565 RID: 136549
			[Token(Token = "0x4021565")]
			[FieldOffset(Offset = "0x10")]
			public PlayerSandboxV2.Dungeon playerDungeonData;

			// Token: 0x04021566 RID: 136550
			[Token(Token = "0x4021566")]
			[FieldOffset(Offset = "0x18")]
			public PlayerSandboxV2.Dungeon.Node playerNodeData;

			// Token: 0x04021567 RID: 136551
			[Token(Token = "0x4021567")]
			[FieldOffset(Offset = "0x20")]
			public PlayerSandboxV2.Dungeon.NodeStage playerStageData;

			// Token: 0x04021568 RID: 136552
			[Token(Token = "0x4021568")]
			[FieldOffset(Offset = "0x28")]
			public List<PlayerSandboxV2.Dungeon.NpcGroup.Npc> playerNpcData;

			// Token: 0x04021569 RID: 136553
			[Token(Token = "0x4021569")]
			[FieldOffset(Offset = "0x30")]
			public List<PlayerSandboxV2.Dungeon.EventGroup.Event> playerEventData;

			// Token: 0x0402156A RID: 136554
			[Token(Token = "0x402156A")]
			[FieldOffset(Offset = "0x38")]
			public SandboxV2DungeonGameflowViewModel gameflowViewModel;
		}
	}
}

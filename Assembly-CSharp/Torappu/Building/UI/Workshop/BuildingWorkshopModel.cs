using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using Torappu.UI;
using Torappu.UI.Atlas;
using XLua;

namespace Torappu.Building.UI.Workshop
{
	// Token: 0x02001BC6 RID: 7110
	[Token(Token = "0x2001BC6")]
	public class BuildingWorkshopModel : IWorkshopSession, IHotfixable
	{
		// Token: 0x0600B147 RID: 45383 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B147")]
		[Address(RVA = "0x32C5C80", Offset = "0x32C4880", VA = "0x1832C5C80")]
		public BuildingWorkshopModel(RoomSlotModel roomSlotModel, [Optional] BuildingWorkshopModel.TargetItemInfo targetItemInfo)
		{
		}

		// Token: 0x0600B148 RID: 45384 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B148")]
		[Address(RVA = "0x32C5B80", Offset = "0x32C4780", VA = "0x1832C5B80")]
		private BuildingWorkshopModel()
		{
		}

		// Token: 0x1700150C RID: 5388
		// (get) Token: 0x0600B149 RID: 45385 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700150C")]
		public IBasicRoomModel basicRoomModel
		{
			[Token(Token = "0x600B149")]
			[Address(RVA = "0x32C6460", Offset = "0x32C5060", VA = "0x1832C6460", Slot = "5")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700150D RID: 5389
		// (get) Token: 0x0600B14A RID: 45386 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700150D")]
		public string slotId
		{
			[Token(Token = "0x600B14A")]
			[Address(RVA = "0x32C6C00", Offset = "0x32C5800", VA = "0x1832C6C00", Slot = "4")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700150E RID: 5390
		// (get) Token: 0x0600B14B RID: 45387 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700150E")]
		public IEnumerable<IWorkshopFormula> formulas
		{
			[Token(Token = "0x600B14B")]
			[Address(RVA = "0x32C6A50", Offset = "0x32C5650", VA = "0x1832C6A50", Slot = "6")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700150F RID: 5391
		// (get) Token: 0x0600B14C RID: 45388 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600B14D RID: 45389 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700150F")]
		public IWorkshopFormula currentFormula
		{
			[Token(Token = "0x600B14C")]
			[Address(RVA = "0x32C66E0", Offset = "0x32C52E0", VA = "0x1832C66E0", Slot = "7")]
			get
			{
				return null;
			}
			[Token(Token = "0x600B14D")]
			[Address(RVA = "0x32C6CD0", Offset = "0x32C58D0", VA = "0x1832C6CD0", Slot = "8")]
			set
			{
			}
		}

		// Token: 0x17001510 RID: 5392
		// (get) Token: 0x0600B14E RID: 45390 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17001510")]
		public Stack<IWorkshopFormula> backStack
		{
			[Token(Token = "0x600B14E")]
			[Address(RVA = "0x32C6400", Offset = "0x32C5000", VA = "0x1832C6400")]
			get
			{
				return null;
			}
		}

		// Token: 0x17001511 RID: 5393
		// (get) Token: 0x0600B14F RID: 45391 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17001511")]
		public IWorkshopStationaryCharacter stationaryCharacter
		{
			[Token(Token = "0x600B14F")]
			[Address(RVA = "0x32C6C70", Offset = "0x32C5870", VA = "0x1832C6C70", Slot = "9")]
			get
			{
				return null;
			}
		}

		// Token: 0x17001512 RID: 5394
		// (get) Token: 0x0600B150 RID: 45392 RVA: 0x00043950 File Offset: 0x00041B50
		[Token(Token = "0x17001512")]
		public int extraOutcomeProbPercent
		{
			[Token(Token = "0x600B150")]
			[Address(RVA = "0x32C6740", Offset = "0x32C5340", VA = "0x1832C6740", Slot = "10")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17001513 RID: 5395
		// (get) Token: 0x0600B151 RID: 45393 RVA: 0x00043968 File Offset: 0x00041B68
		[Token(Token = "0x17001513")]
		public float additionalExtraOutcomeProbPercent
		{
			[Token(Token = "0x600B151")]
			[Address(RVA = "0x32C5F40", Offset = "0x32C4B40", VA = "0x1832C5F40", Slot = "11")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x17001514 RID: 5396
		// (get) Token: 0x0600B152 RID: 45394 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17001514")]
		public string currFormulaType
		{
			[Token(Token = "0x600B152")]
			[Address(RVA = "0x32C65B0", Offset = "0x32C51B0", VA = "0x1832C65B0")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600B153 RID: 45395 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B153")]
		[Address(RVA = "0x32C2AF0", Offset = "0x32C16F0", VA = "0x1832C2AF0")]
		public void LoadCurrentCharacter()
		{
		}

		// Token: 0x0600B154 RID: 45396 RVA: 0x00043980 File Offset: 0x00041B80
		[Token(Token = "0x600B154")]
		[Address(RVA = "0x32C2F50", Offset = "0x32C1B50", VA = "0x1832C2F50", Slot = "12")]
		public int MaxWorkCount(int curSelectCount, out MaxCountLimitReason limitedReason)
		{
			return 0;
		}

		// Token: 0x0600B155 RID: 45397 RVA: 0x00043998 File Offset: 0x00041B98
		[Token(Token = "0x600B155")]
		[Address(RVA = "0x32C4DD0", Offset = "0x32C39D0", VA = "0x1832C4DD0")]
		private int _MaxCountWithGold()
		{
			return 0;
		}

		// Token: 0x0600B156 RID: 45398 RVA: 0x000439B0 File Offset: 0x00041BB0
		[Token(Token = "0x600B156")]
		[Address(RVA = "0x32C50A0", Offset = "0x32C3CA0", VA = "0x1832C50A0")]
		private int _MaxCountWithMood(int curSelectCount)
		{
			return 0;
		}

		// Token: 0x17001515 RID: 5397
		// (get) Token: 0x0600B157 RID: 45399 RVA: 0x000439C8 File Offset: 0x00041BC8
		// (set) Token: 0x0600B158 RID: 45400 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17001515")]
		public bool itemProtection
		{
			[Token(Token = "0x600B157")]
			[Address(RVA = "0x32C6BA0", Offset = "0x32C57A0", VA = "0x1832C6BA0", Slot = "13")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600B158")]
			[Address(RVA = "0x32C6D50", Offset = "0x32C5950", VA = "0x1832C6D50", Slot = "14")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17001516 RID: 5398
		// (get) Token: 0x0600B159 RID: 45401 RVA: 0x000439E0 File Offset: 0x00041BE0
		[Token(Token = "0x17001516")]
		private long gold
		{
			[Token(Token = "0x600B159")]
			[Address(RVA = "0x32C6B00", Offset = "0x32C5700", VA = "0x1832C6B00")]
			get
			{
				return 0L;
			}
		}

		// Token: 0x0600B15A RID: 45402 RVA: 0x000439F8 File Offset: 0x00041BF8
		[Token(Token = "0x600B15A")]
		[Address(RVA = "0x32C49F0", Offset = "0x32C35F0", VA = "0x1832C49F0")]
		private long _GetSingleMoodCost(BuildingWorkshopModel.Formula formula)
		{
			return 0L;
		}

		// Token: 0x0600B15B RID: 45403 RVA: 0x00043A10 File Offset: 0x00041C10
		[Token(Token = "0x600B15B")]
		[Address(RVA = "0x32C4570", Offset = "0x32C3170", VA = "0x1832C4570")]
		private long _GetMoodBuffByFormula(BuildingWorkshopModel.Formula formula)
		{
			return 0L;
		}

		// Token: 0x0600B15C RID: 45404 RVA: 0x00043A28 File Offset: 0x00041C28
		[Token(Token = "0x600B15C")]
		[Address(RVA = "0x32C39D0", Offset = "0x32C25D0", VA = "0x1832C39D0")]
		private static bool TryGetMoodBuffCost(PlayerBuildingWorkshopBuff buff, BuildingWorkshopModel.Formula formula, out long changeVal)
		{
			return default(bool);
		}

		// Token: 0x0600B15D RID: 45405 RVA: 0x00043A40 File Offset: 0x00041C40
		[Token(Token = "0x600B15D")]
		[Address(RVA = "0x32C38A0", Offset = "0x32C24A0", VA = "0x1832C38A0")]
		private static bool TryGetMoodBuffCostRe(PlayerBuildingWorkshopBuff buff, BuildingWorkshopModel.Formula formula, out long changeVal)
		{
			return default(bool);
		}

		// Token: 0x0600B15E RID: 45406 RVA: 0x00043A58 File Offset: 0x00041C58
		[Token(Token = "0x600B15E")]
		[Address(RVA = "0x32C3750", Offset = "0x32C2350", VA = "0x1832C3750")]
		private static bool TryGetMoodBuffCostFormula(PlayerBuildingWorkshopBuff buff, BuildingWorkshopModel.Formula formula, out long changeVal)
		{
			return default(bool);
		}

		// Token: 0x0600B15F RID: 45407 RVA: 0x00043A70 File Offset: 0x00041C70
		[Token(Token = "0x600B15F")]
		[Address(RVA = "0x32C3630", Offset = "0x32C2230", VA = "0x1832C3630")]
		private static bool TryGetMoodBuffCostForce(PlayerBuildingWorkshopBuff buff, BuildingWorkshopModel.Formula formula, out long changeVal)
		{
			return default(bool);
		}

		// Token: 0x0600B160 RID: 45408 RVA: 0x00043A88 File Offset: 0x00041C88
		[Token(Token = "0x600B160")]
		[Address(RVA = "0x32C34A0", Offset = "0x32C20A0", VA = "0x1832C34A0")]
		private static bool TryGetMoodBuffCostDevide(PlayerBuildingWorkshopBuff buff, BuildingWorkshopModel.Formula formula, out long changeResultVal)
		{
			return default(bool);
		}

		// Token: 0x0600B161 RID: 45409 RVA: 0x00043AA0 File Offset: 0x00041CA0
		[Token(Token = "0x600B161")]
		[Address(RVA = "0x32C4180", Offset = "0x32C2D80", VA = "0x1832C4180")]
		private bool _CheckSingleIngredient(IFormulaItem ingredient, int count)
		{
			return default(bool);
		}

		// Token: 0x0600B162 RID: 45410 RVA: 0x00043AB8 File Offset: 0x00041CB8
		[Token(Token = "0x600B162")]
		[Address(RVA = "0x32C2890", Offset = "0x32C1490", VA = "0x1832C2890", Slot = "15")]
		public int GetMoodCostByCount(int count, out bool overload)
		{
			return 0;
		}

		// Token: 0x0600B163 RID: 45411 RVA: 0x00043AD0 File Offset: 0x00041CD0
		[Token(Token = "0x600B163")]
		[Address(RVA = "0x32C2640", Offset = "0x32C1240", VA = "0x1832C2640", Slot = "16")]
		public int GetGoldCostByCount(int count)
		{
			return 0;
		}

		// Token: 0x0600B164 RID: 45412 RVA: 0x00043AE8 File Offset: 0x00041CE8
		[Token(Token = "0x600B164")]
		[Address(RVA = "0x32C3FF0", Offset = "0x32C2BF0", VA = "0x1832C3FF0")]
		private bool _CheckGoldFreeByFormula(BuildingWorkshopModel.Formula formula)
		{
			return default(bool);
		}

		// Token: 0x0600B165 RID: 45413 RVA: 0x00043B00 File Offset: 0x00041D00
		[Token(Token = "0x600B165")]
		[Address(RVA = "0x32C4450", Offset = "0x32C3050", VA = "0x1832C4450")]
		private int _GetLeftCount(int count, BuildingWorkshopModel.Formula formula)
		{
			return 0;
		}

		// Token: 0x0600B166 RID: 45414 RVA: 0x00043B18 File Offset: 0x00041D18
		[Token(Token = "0x600B166")]
		[Address(RVA = "0x32C1C30", Offset = "0x32C0830", VA = "0x1832C1C30", Slot = "17")]
		public WorkshopCheckResult CheckAsFormula(IWorkshopFormula formula, int count, IWorkshopStationaryCharacter character)
		{
			return WorkshopCheckResult.OK;
		}

		// Token: 0x0600B167 RID: 45415 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B167")]
		[Address(RVA = "0x32C5890", Offset = "0x32C4490", VA = "0x1832C5890")]
		private void _WorkAsSynthesis(BuildingWorkshopModel.Formula formula, int count, Action<WorkResult> resultHandler)
		{
		}

		// Token: 0x0600B168 RID: 45416 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B168")]
		[Address(RVA = "0x32C5570", Offset = "0x32C4170", VA = "0x1832C5570")]
		private void _WorkAsDecomposition(BuildingWorkshopModel.FurnitureDestructFormula formula, int count, Action<WorkResult> resultHandler)
		{
		}

		// Token: 0x0600B169 RID: 45417 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B169")]
		[Address(RVA = "0x32C3DE0", Offset = "0x32C29E0", VA = "0x1832C3DE0", Slot = "18")]
		public void WorkAsFormula(IWorkshopFormula formula, int count, IWorkshopStationaryCharacter character, Action<WorkResult> resultHandler)
		{
		}

		// Token: 0x0600B16A RID: 45418 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B16A")]
		[Address(RVA = "0x32C3430", Offset = "0x32C2030", VA = "0x1832C3430")]
		public void RefreshModel()
		{
		}

		// Token: 0x0600B16B RID: 45419 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B16B")]
		[Address(RVA = "0x32C2200", Offset = "0x32C0E00", VA = "0x1832C2200", Slot = "19")]
		public void ClearFormulaCache()
		{
		}

		// Token: 0x0600B16C RID: 45420 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B16C")]
		[Address(RVA = "0x32C2290", Offset = "0x32C0E90", VA = "0x1832C2290", Slot = "20")]
		public void ClearTargetItemInfoAndRebuildTree()
		{
		}

		// Token: 0x0600B16D RID: 45421 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600B16D")]
		[Address(RVA = "0x32C2300", Offset = "0x32C0F00", VA = "0x1832C2300")]
		public IWorkshopFormula FindFormulaByItemId(string itemId)
		{
			return null;
		}

		// Token: 0x0600B16E RID: 45422 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B16E")]
		[Address(RVA = "0x32C4270", Offset = "0x32C2E70", VA = "0x1832C4270")]
		private void _CreateFormulaTreeByCurrent()
		{
		}

		// Token: 0x0600B16F RID: 45423 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B16F")]
		[Address(RVA = "0x32C3B00", Offset = "0x32C2700", VA = "0x1832C3B00")]
		public void UpdateFormulaTreeToIngredient(string ingredientItemId)
		{
		}

		// Token: 0x0600B170 RID: 45424 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B170")]
		[Address(RVA = "0x32C3D30", Offset = "0x32C2930", VA = "0x1832C3D30")]
		public void UpdateFormulaTreeToParent(string curFormulaItemId)
		{
		}

		// Token: 0x0600B171 RID: 45425 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600B171")]
		[Address(RVA = "0x32C2A30", Offset = "0x32C1630", VA = "0x1832C2A30")]
		public IWorkshopFormula GetParentFormula()
		{
			return null;
		}

		// Token: 0x0600B172 RID: 45426 RVA: 0x00043B30 File Offset: 0x00041D30
		[Token(Token = "0x600B172")]
		[Address(RVA = "0x32C2000", Offset = "0x32C0C00", VA = "0x1832C2000")]
		public bool CheckIsNodeCanShowJumpBtn(string ingredientItemId)
		{
			return default(bool);
		}

		// Token: 0x0600B173 RID: 45427 RVA: 0x00043B48 File Offset: 0x00041D48
		[Token(Token = "0x600B173")]
		[Address(RVA = "0x32C1E00", Offset = "0x32C0A00", VA = "0x1832C1E00")]
		public bool CheckIfIngredientCanProcess(string ingredientItemId)
		{
			return default(bool);
		}

		// Token: 0x0600B174 RID: 45428 RVA: 0x00043B60 File Offset: 0x00041D60
		[Token(Token = "0x600B174")]
		[Address(RVA = "0x32C1D60", Offset = "0x32C0960", VA = "0x1832C1D60")]
		public bool CheckIfHaveTargetAmount()
		{
			return default(bool);
		}

		// Token: 0x0600B175 RID: 45429 RVA: 0x00043B78 File Offset: 0x00041D78
		[Token(Token = "0x600B175")]
		[Address(RVA = "0x32C1BA0", Offset = "0x32C07A0", VA = "0x1832C1BA0")]
		public int CalcCurrentRequiredCount()
		{
			return 0;
		}

		// Token: 0x0400ABAB RID: 43947
		[Token(Token = "0x400ABAB")]
		private const string ALL_FORMULA_KEY = "all";

		// Token: 0x0400ABAC RID: 43948
		[Token(Token = "0x400ABAC")]
		private const int MAX_COUNT = 99;

		// Token: 0x0400ABAD RID: 43949
		[Token(Token = "0x400ABAD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private RoomSlotModel m_roomSlotModel;

		// Token: 0x0400ABAE RID: 43950
		[Token(Token = "0x400ABAE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private BuildingWorkshopModel.TargetItemInfo m_targetItemInfo;

		// Token: 0x0400ABAF RID: 43951
		[Token(Token = "0x400ABAF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private BuildingWorkshopModel.StationaryCharacter m_cachedCharacter;

		// Token: 0x0400ABB0 RID: 43952
		[Token(Token = "0x400ABB0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private List<BuildingWorkshopModel.Formula> m_formulaCache;

		// Token: 0x0400ABB1 RID: 43953
		[Token(Token = "0x400ABB1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private IWorkshopFormula m_currentFormula;

		// Token: 0x0400ABB2 RID: 43954
		[Token(Token = "0x400ABB2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private BuildingWorkshopModel.WRoomViewModel m_basicRoomModel;

		// Token: 0x0400ABB3 RID: 43955
		[Token(Token = "0x400ABB3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private BuildingWorkShopFormulaTree m_formulaTree;

		// Token: 0x0400ABB4 RID: 43956
		[Token(Token = "0x400ABB4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private Stack<IWorkshopFormula> m_backStack;

		// Token: 0x0400ABB6 RID: 43958
		[Token(Token = "0x400ABB6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Dictionary<string, IWorkshopFormula> m_cachedIngredientFormulaDict;

		// Token: 0x0400ABB7 RID: 43959
		[Token(Token = "0x400ABB7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x0400ABB8 RID: 43960
		[Token(Token = "0x400ABB8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix1_ctor;

		// Token: 0x0400ABB9 RID: 43961
		[Token(Token = "0x400ABB9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_basicRoomModel;

		// Token: 0x0400ABBA RID: 43962
		[Token(Token = "0x400ABBA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_get_slotId;

		// Token: 0x0400ABBB RID: 43963
		[Token(Token = "0x400ABBB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_get_formulas;

		// Token: 0x0400ABBC RID: 43964
		[Token(Token = "0x400ABBC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_get_currentFormula;

		// Token: 0x0400ABBD RID: 43965
		[Token(Token = "0x400ABBD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_set_currentFormula;

		// Token: 0x0400ABBE RID: 43966
		[Token(Token = "0x400ABBE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_get_backStack;

		// Token: 0x0400ABBF RID: 43967
		[Token(Token = "0x400ABBF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_get_stationaryCharacter;

		// Token: 0x0400ABC0 RID: 43968
		[Token(Token = "0x400ABC0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_get_extraOutcomeProbPercent;

		// Token: 0x0400ABC1 RID: 43969
		[Token(Token = "0x400ABC1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_get_additionalExtraOutcomeProbPercent;

		// Token: 0x0400ABC2 RID: 43970
		[Token(Token = "0x400ABC2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_get_currFormulaType;

		// Token: 0x0400ABC3 RID: 43971
		[Token(Token = "0x400ABC3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0_LoadCurrentCharacter;

		// Token: 0x0400ABC4 RID: 43972
		[Token(Token = "0x400ABC4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0_MaxWorkCount;

		// Token: 0x0400ABC5 RID: 43973
		[Token(Token = "0x400ABC5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0__MaxCountWithGold;

		// Token: 0x0400ABC6 RID: 43974
		[Token(Token = "0x400ABC6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0__MaxCountWithMood;

		// Token: 0x0400ABC7 RID: 43975
		[Token(Token = "0x400ABC7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private static DelegateBridge __Hotfix0_get_itemProtection;

		// Token: 0x0400ABC8 RID: 43976
		[Token(Token = "0x400ABC8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private static DelegateBridge __Hotfix0_set_itemProtection;

		// Token: 0x0400ABC9 RID: 43977
		[Token(Token = "0x400ABC9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private static DelegateBridge __Hotfix0_get_gold;

		// Token: 0x0400ABCA RID: 43978
		[Token(Token = "0x400ABCA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private static DelegateBridge __Hotfix0__GetSingleMoodCost;

		// Token: 0x0400ABCB RID: 43979
		[Token(Token = "0x400ABCB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private static DelegateBridge __Hotfix0__GetMoodBuffByFormula;

		// Token: 0x0400ABCC RID: 43980
		[Token(Token = "0x400ABCC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private static DelegateBridge __Hotfix0_TryGetMoodBuffCost;

		// Token: 0x0400ABCD RID: 43981
		[Token(Token = "0x400ABCD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private static DelegateBridge __Hotfix0_TryGetMoodBuffCostRe;

		// Token: 0x0400ABCE RID: 43982
		[Token(Token = "0x400ABCE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private static DelegateBridge __Hotfix0_TryGetMoodBuffCostFormula;

		// Token: 0x0400ABCF RID: 43983
		[Token(Token = "0x400ABCF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private static DelegateBridge __Hotfix0_TryGetMoodBuffCostForce;

		// Token: 0x0400ABD0 RID: 43984
		[Token(Token = "0x400ABD0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		private static DelegateBridge __Hotfix0_TryGetMoodBuffCostDevide;

		// Token: 0x0400ABD1 RID: 43985
		[Token(Token = "0x400ABD1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		private static DelegateBridge __Hotfix0__CheckSingleIngredient;

		// Token: 0x0400ABD2 RID: 43986
		[Token(Token = "0x400ABD2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		private static DelegateBridge __Hotfix0_GetMoodCostByCount;

		// Token: 0x0400ABD3 RID: 43987
		[Token(Token = "0x400ABD3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		private static DelegateBridge __Hotfix0_GetGoldCostByCount;

		// Token: 0x0400ABD4 RID: 43988
		[Token(Token = "0x400ABD4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		private static DelegateBridge __Hotfix0__CheckGoldFreeByFormula;

		// Token: 0x0400ABD5 RID: 43989
		[Token(Token = "0x400ABD5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		private static DelegateBridge __Hotfix0__GetLeftCount;

		// Token: 0x0400ABD6 RID: 43990
		[Token(Token = "0x400ABD6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		private static DelegateBridge __Hotfix0_CheckAsFormula;

		// Token: 0x0400ABD7 RID: 43991
		[Token(Token = "0x400ABD7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
		private static DelegateBridge __Hotfix0__WorkAsSynthesis;

		// Token: 0x0400ABD8 RID: 43992
		[Token(Token = "0x400ABD8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
		private static DelegateBridge __Hotfix0__WorkAsDecomposition;

		// Token: 0x0400ABD9 RID: 43993
		[Token(Token = "0x400ABD9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
		private static DelegateBridge __Hotfix0_WorkAsFormula;

		// Token: 0x0400ABDA RID: 43994
		[Token(Token = "0x400ABDA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
		private static DelegateBridge __Hotfix0_RefreshModel;

		// Token: 0x0400ABDB RID: 43995
		[Token(Token = "0x400ABDB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
		private static DelegateBridge __Hotfix0_ClearFormulaCache;

		// Token: 0x0400ABDC RID: 43996
		[Token(Token = "0x400ABDC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
		private static DelegateBridge __Hotfix0_ClearTargetItemInfoAndRebuildTree;

		// Token: 0x0400ABDD RID: 43997
		[Token(Token = "0x400ABDD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
		private static DelegateBridge __Hotfix0_FindFormulaByItemId;

		// Token: 0x0400ABDE RID: 43998
		[Token(Token = "0x400ABDE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
		private static DelegateBridge __Hotfix0__CreateFormulaTreeByCurrent;

		// Token: 0x0400ABDF RID: 43999
		[Token(Token = "0x400ABDF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x140")]
		private static DelegateBridge __Hotfix0_UpdateFormulaTreeToIngredient;

		// Token: 0x0400ABE0 RID: 44000
		[Token(Token = "0x400ABE0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x148")]
		private static DelegateBridge __Hotfix0_UpdateFormulaTreeToParent;

		// Token: 0x0400ABE1 RID: 44001
		[Token(Token = "0x400ABE1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x150")]
		private static DelegateBridge __Hotfix0_GetParentFormula;

		// Token: 0x0400ABE2 RID: 44002
		[Token(Token = "0x400ABE2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x158")]
		private static DelegateBridge __Hotfix0_CheckIsNodeCanShowJumpBtn;

		// Token: 0x0400ABE3 RID: 44003
		[Token(Token = "0x400ABE3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x160")]
		private static DelegateBridge __Hotfix0_CheckIfIngredientCanProcess;

		// Token: 0x0400ABE4 RID: 44004
		[Token(Token = "0x400ABE4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x168")]
		private static DelegateBridge __Hotfix0_CheckIfHaveTargetAmount;

		// Token: 0x0400ABE5 RID: 44005
		[Token(Token = "0x400ABE5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x170")]
		private static DelegateBridge __Hotfix0_CalcCurrentRequiredCount;

		// Token: 0x02001BC7 RID: 7111
		[Token(Token = "0x2001BC7")]
		private class FormulaItem : IFormulaItem, IHotfixable
		{
			// Token: 0x0600B176 RID: 45430 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600B176")]
			[Address(RVA = "0x32CB9A0", Offset = "0x32CA5A0", VA = "0x1832CB9A0")]
			public FormulaItem(string itemId, int count, BuildingWorkshopModel.FormulaItem.SubType subType = BuildingWorkshopModel.FormulaItem.SubType.NORMAL)
			{
			}

			// Token: 0x17001517 RID: 5399
			// (get) Token: 0x0600B177 RID: 45431 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17001517")]
			public UIItemViewModel model
			{
				[Token(Token = "0x600B177")]
				[Address(RVA = "0x32CBAD0", Offset = "0x32CA6D0", VA = "0x1832CBAD0", Slot = "4")]
				get
				{
					return null;
				}
			}

			// Token: 0x17001518 RID: 5400
			// (get) Token: 0x0600B178 RID: 45432 RVA: 0x00043B90 File Offset: 0x00041D90
			[Token(Token = "0x17001518")]
			public int storage
			{
				[Token(Token = "0x600B178")]
				[Address(RVA = "0x32CBBC0", Offset = "0x32CA7C0", VA = "0x1832CBBC0", Slot = "5")]
				get
				{
					return 0;
				}
			}

			// Token: 0x0400ABE6 RID: 44006
			[Token(Token = "0x400ABE6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private string m_itemId;

			// Token: 0x0400ABE7 RID: 44007
			[Token(Token = "0x400ABE7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private int m_count;

			// Token: 0x0400ABE8 RID: 44008
			[Token(Token = "0x400ABE8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			private BuildingWorkshopModel.FormulaItem.SubType m_subType;

			// Token: 0x0400ABE9 RID: 44009
			[Token(Token = "0x400ABE9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private UIItemViewModel m_itemModelCache;

			// Token: 0x0400ABEA RID: 44010
			[Token(Token = "0x400ABEA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x0400ABEB RID: 44011
			[Token(Token = "0x400ABEB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_get_model;

			// Token: 0x0400ABEC RID: 44012
			[Token(Token = "0x400ABEC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_get_storage;

			// Token: 0x02001BC8 RID: 7112
			[Token(Token = "0x2001BC8")]
			public enum SubType
			{
				// Token: 0x0400ABEE RID: 44014
				[Token(Token = "0x400ABEE")]
				NORMAL,
				// Token: 0x0400ABEF RID: 44015
				[Token(Token = "0x400ABEF")]
				DIYITEM
			}
		}

		// Token: 0x02001BC9 RID: 7113
		[Token(Token = "0x2001BC9")]
		private class Formula : IWorkshopFormula, IHotfixable
		{
			// Token: 0x0600B179 RID: 45433 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600B179")]
			[Address(RVA = "0x32CBCE0", Offset = "0x32CA8E0", VA = "0x1832CBCE0")]
			public Formula(BuildingData.WorkshopFormula workshopFormula)
			{
			}

			// Token: 0x17001519 RID: 5401
			// (get) Token: 0x0600B17A RID: 45434 RVA: 0x00043BA8 File Offset: 0x00041DA8
			[Token(Token = "0x17001519")]
			public int id
			{
				[Token(Token = "0x600B17A")]
				[Address(RVA = "0x32CC0F0", Offset = "0x32CACF0", VA = "0x1832CC0F0", Slot = "4")]
				get
				{
					return 0;
				}
			}

			// Token: 0x1700151A RID: 5402
			// (get) Token: 0x0600B17B RID: 45435 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x1700151A")]
			public IFormulaItem outcome
			{
				[Token(Token = "0x600B17B")]
				[Address(RVA = "0x32CC6A0", Offset = "0x32CB2A0", VA = "0x1832CC6A0", Slot = "5")]
				get
				{
					return null;
				}
			}

			// Token: 0x1700151B RID: 5403
			// (get) Token: 0x0600B17C RID: 45436 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x1700151B")]
			public IFormulaItem ingredient1
			{
				[Token(Token = "0x600B17C")]
				[Address(RVA = "0x32CC180", Offset = "0x32CAD80", VA = "0x1832CC180", Slot = "6")]
				get
				{
					return null;
				}
			}

			// Token: 0x1700151C RID: 5404
			// (get) Token: 0x0600B17D RID: 45437 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x1700151C")]
			public IFormulaItem ingredient2
			{
				[Token(Token = "0x600B17D")]
				[Address(RVA = "0x32CC2E0", Offset = "0x32CAEE0", VA = "0x1832CC2E0", Slot = "7")]
				get
				{
					return null;
				}
			}

			// Token: 0x1700151D RID: 5405
			// (get) Token: 0x0600B17E RID: 45438 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x1700151D")]
			public IFormulaItem ingredient3
			{
				[Token(Token = "0x600B17E")]
				[Address(RVA = "0x32CC450", Offset = "0x32CB050", VA = "0x1832CC450", Slot = "8")]
				get
				{
					return null;
				}
			}

			// Token: 0x1700151E RID: 5406
			// (get) Token: 0x0600B17F RID: 45439 RVA: 0x00043BC0 File Offset: 0x00041DC0
			[Token(Token = "0x1700151E")]
			public int costGoldCount
			{
				[Token(Token = "0x600B17F")]
				[Address(RVA = "0x32CBED0", Offset = "0x32CAAD0", VA = "0x1832CBED0", Slot = "9")]
				get
				{
					return 0;
				}
			}

			// Token: 0x1700151F RID: 5407
			// (get) Token: 0x0600B180 RID: 45440 RVA: 0x00043BD8 File Offset: 0x00041DD8
			[Token(Token = "0x1700151F")]
			public long moodCost
			{
				[Token(Token = "0x600B180")]
				[Address(RVA = "0x32CC630", Offset = "0x32CB230", VA = "0x1832CC630")]
				get
				{
					return 0L;
				}
			}

			// Token: 0x17001520 RID: 5408
			// (get) Token: 0x0600B181 RID: 45441 RVA: 0x00043BF0 File Offset: 0x00041DF0
			[Token(Token = "0x17001520")]
			public bool canBeProtected
			{
				[Token(Token = "0x600B181")]
				[Address(RVA = "0x32CBE70", Offset = "0x32CAA70", VA = "0x1832CBE70", Slot = "10")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x17001521 RID: 5409
			// (get) Token: 0x0600B182 RID: 45442 RVA: 0x00043C08 File Offset: 0x00041E08
			[Token(Token = "0x17001521")]
			public int filterIndex
			{
				[Token(Token = "0x600B182")]
				[Address(RVA = "0x32CBFC0", Offset = "0x32CABC0", VA = "0x1832CBFC0", Slot = "11")]
				get
				{
					return 0;
				}
			}

			// Token: 0x17001522 RID: 5410
			// (get) Token: 0x0600B183 RID: 45443 RVA: 0x00043C20 File Offset: 0x00041E20
			[Token(Token = "0x17001522")]
			public int extraOutcomePercent
			{
				[Token(Token = "0x600B183")]
				[Address(RVA = "0x32CBF40", Offset = "0x32CAB40", VA = "0x1832CBF40")]
				get
				{
					return 0;
				}
			}

			// Token: 0x17001523 RID: 5411
			// (get) Token: 0x0600B184 RID: 45444 RVA: 0x00043C38 File Offset: 0x00041E38
			[Token(Token = "0x17001523")]
			public bool unlocked
			{
				[Token(Token = "0x600B184")]
				[Address(RVA = "0x32CC850", Offset = "0x32CB450", VA = "0x1832CC850", Slot = "12")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x17001524 RID: 5412
			// (get) Token: 0x0600B185 RID: 45445 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17001524")]
			public string unlockMessage
			{
				[Token(Token = "0x600B185")]
				[Address(RVA = "0x32CC7F0", Offset = "0x32CB3F0", VA = "0x1832CC7F0", Slot = "13")]
				get
				{
					return null;
				}
			}

			// Token: 0x17001525 RID: 5413
			// (get) Token: 0x0600B186 RID: 45446 RVA: 0x00043C50 File Offset: 0x00041E50
			[Token(Token = "0x17001525")]
			public int apCost
			{
				[Token(Token = "0x600B186")]
				[Address(RVA = "0x32CBD70", Offset = "0x32CA970", VA = "0x1832CBD70", Slot = "14")]
				get
				{
					return 0;
				}
			}

			// Token: 0x17001526 RID: 5414
			// (get) Token: 0x0600B187 RID: 45447 RVA: 0x00043C68 File Offset: 0x00041E68
			[Token(Token = "0x17001526")]
			public BuildingData.FormulaItemType formulaType
			{
				[Token(Token = "0x600B187")]
				[Address(RVA = "0x32CC080", Offset = "0x32CAC80", VA = "0x1832CC080")]
				get
				{
					return BuildingData.FormulaItemType.NONE;
				}
			}

			// Token: 0x17001527 RID: 5415
			// (get) Token: 0x0600B188 RID: 45448 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17001527")]
			public string buffType
			{
				[Token(Token = "0x600B188")]
				[Address(RVA = "0x32CBE00", Offset = "0x32CAA00", VA = "0x1832CBE00")]
				get
				{
					return null;
				}
			}

			// Token: 0x17001528 RID: 5416
			// (get) Token: 0x0600B189 RID: 45449 RVA: 0x00043C80 File Offset: 0x00041E80
			[Token(Token = "0x17001528")]
			public int sortId
			{
				[Token(Token = "0x600B189")]
				[Address(RVA = "0x32CC780", Offset = "0x32CB380", VA = "0x1832CC780", Slot = "15")]
				get
				{
					return 0;
				}
			}

			// Token: 0x17001529 RID: 5417
			// (get) Token: 0x0600B18A RID: 45450 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17001529")]
			public string itemId
			{
				[Token(Token = "0x600B18A")]
				[Address(RVA = "0x32CC5C0", Offset = "0x32CB1C0", VA = "0x1832CC5C0")]
				get
				{
					return null;
				}
			}

			// Token: 0x0400ABF0 RID: 44016
			[Token(Token = "0x400ABF0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private BuildingData.WorkshopFormula m_workshopFormula;

			// Token: 0x0400ABF1 RID: 44017
			[Token(Token = "0x400ABF1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private BuildingWorkshopModel.FormulaItem m_outcome;

			// Token: 0x0400ABF2 RID: 44018
			[Token(Token = "0x400ABF2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private BuildingWorkshopModel.FormulaItem m_ingredient1;

			// Token: 0x0400ABF3 RID: 44019
			[Token(Token = "0x400ABF3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private BuildingWorkshopModel.FormulaItem m_ingredient2;

			// Token: 0x0400ABF4 RID: 44020
			[Token(Token = "0x400ABF4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private BuildingWorkshopModel.FormulaItem m_ingredient3;

			// Token: 0x0400ABF5 RID: 44021
			[Token(Token = "0x400ABF5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private string m_unlockString;

			// Token: 0x0400ABF6 RID: 44022
			[Token(Token = "0x400ABF6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			private int m_cachedId;

			// Token: 0x0400ABF7 RID: 44023
			[Token(Token = "0x400ABF7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x0400ABF8 RID: 44024
			[Token(Token = "0x400ABF8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_get_id;

			// Token: 0x0400ABF9 RID: 44025
			[Token(Token = "0x400ABF9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_get_outcome;

			// Token: 0x0400ABFA RID: 44026
			[Token(Token = "0x400ABFA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private static DelegateBridge __Hotfix0_get_ingredient1;

			// Token: 0x0400ABFB RID: 44027
			[Token(Token = "0x400ABFB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private static DelegateBridge __Hotfix0_get_ingredient2;

			// Token: 0x0400ABFC RID: 44028
			[Token(Token = "0x400ABFC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private static DelegateBridge __Hotfix0_get_ingredient3;

			// Token: 0x0400ABFD RID: 44029
			[Token(Token = "0x400ABFD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private static DelegateBridge __Hotfix0_get_costGoldCount;

			// Token: 0x0400ABFE RID: 44030
			[Token(Token = "0x400ABFE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private static DelegateBridge __Hotfix0_get_moodCost;

			// Token: 0x0400ABFF RID: 44031
			[Token(Token = "0x400ABFF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			private static DelegateBridge __Hotfix0_get_canBeProtected;

			// Token: 0x0400AC00 RID: 44032
			[Token(Token = "0x400AC00")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			private static DelegateBridge __Hotfix0_get_filterIndex;

			// Token: 0x0400AC01 RID: 44033
			[Token(Token = "0x400AC01")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			private static DelegateBridge __Hotfix0_get_extraOutcomePercent;

			// Token: 0x0400AC02 RID: 44034
			[Token(Token = "0x400AC02")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			private static DelegateBridge __Hotfix0_get_unlocked;

			// Token: 0x0400AC03 RID: 44035
			[Token(Token = "0x400AC03")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			private static DelegateBridge __Hotfix0_get_unlockMessage;

			// Token: 0x0400AC04 RID: 44036
			[Token(Token = "0x400AC04")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
			private static DelegateBridge __Hotfix0_get_apCost;

			// Token: 0x0400AC05 RID: 44037
			[Token(Token = "0x400AC05")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
			private static DelegateBridge __Hotfix0_get_formulaType;

			// Token: 0x0400AC06 RID: 44038
			[Token(Token = "0x400AC06")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
			private static DelegateBridge __Hotfix0_get_buffType;

			// Token: 0x0400AC07 RID: 44039
			[Token(Token = "0x400AC07")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
			private static DelegateBridge __Hotfix0_get_sortId;

			// Token: 0x0400AC08 RID: 44040
			[Token(Token = "0x400AC08")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
			private static DelegateBridge __Hotfix0_get_itemId;
		}

		// Token: 0x02001BCA RID: 7114
		[Token(Token = "0x2001BCA")]
		private class FurnitureDestructFormula : IWorkshopFormula, IHotfixable
		{
			// Token: 0x0600B18B RID: 45451 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600B18B")]
			[Address(RVA = "0x32CC8B0", Offset = "0x32CB4B0", VA = "0x1832CC8B0")]
			public FurnitureDestructFormula(string ingredientId, string outcomeId, int outcomeCount, int byProductPercentage)
			{
			}

			// Token: 0x1700152A RID: 5418
			// (get) Token: 0x0600B18C RID: 45452 RVA: 0x00043C98 File Offset: 0x00041E98
			[Token(Token = "0x1700152A")]
			public int id
			{
				[Token(Token = "0x600B18C")]
				[Address(RVA = "0x32CCBB0", Offset = "0x32CB7B0", VA = "0x1832CCBB0", Slot = "4")]
				get
				{
					return 0;
				}
			}

			// Token: 0x1700152B RID: 5419
			// (get) Token: 0x0600B18D RID: 45453 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x1700152B")]
			public IFormulaItem outcome
			{
				[Token(Token = "0x600B18D")]
				[Address(RVA = "0x32CCE00", Offset = "0x32CBA00", VA = "0x1832CCE00", Slot = "5")]
				get
				{
					return null;
				}
			}

			// Token: 0x1700152C RID: 5420
			// (get) Token: 0x0600B18E RID: 45454 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x1700152C")]
			public IFormulaItem ingredient1
			{
				[Token(Token = "0x600B18E")]
				[Address(RVA = "0x32CCC10", Offset = "0x32CB810", VA = "0x1832CCC10", Slot = "6")]
				get
				{
					return null;
				}
			}

			// Token: 0x1700152D RID: 5421
			// (get) Token: 0x0600B18F RID: 45455 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x1700152D")]
			public IFormulaItem ingredient2
			{
				[Token(Token = "0x600B18F")]
				[Address(RVA = "0x32CCCE0", Offset = "0x32CB8E0", VA = "0x1832CCCE0", Slot = "7")]
				get
				{
					return null;
				}
			}

			// Token: 0x1700152E RID: 5422
			// (get) Token: 0x0600B190 RID: 45456 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x1700152E")]
			public IFormulaItem ingredient3
			{
				[Token(Token = "0x600B190")]
				[Address(RVA = "0x32CCD40", Offset = "0x32CB940", VA = "0x1832CCD40", Slot = "8")]
				get
				{
					return null;
				}
			}

			// Token: 0x1700152F RID: 5423
			// (get) Token: 0x0600B191 RID: 45457 RVA: 0x00043CB0 File Offset: 0x00041EB0
			[Token(Token = "0x1700152F")]
			public int costGoldCount
			{
				[Token(Token = "0x600B191")]
				[Address(RVA = "0x32CCA90", Offset = "0x32CB690", VA = "0x1832CCA90", Slot = "9")]
				get
				{
					return 0;
				}
			}

			// Token: 0x17001530 RID: 5424
			// (get) Token: 0x0600B192 RID: 45458 RVA: 0x00043CC8 File Offset: 0x00041EC8
			[Token(Token = "0x17001530")]
			public bool canBeProtected
			{
				[Token(Token = "0x600B192")]
				[Address(RVA = "0x32CCA30", Offset = "0x32CB630", VA = "0x1832CCA30", Slot = "10")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x17001531 RID: 5425
			// (get) Token: 0x0600B193 RID: 45459 RVA: 0x00043CE0 File Offset: 0x00041EE0
			[Token(Token = "0x17001531")]
			public int filterIndex
			{
				[Token(Token = "0x600B193")]
				[Address(RVA = "0x32CCAF0", Offset = "0x32CB6F0", VA = "0x1832CCAF0", Slot = "11")]
				get
				{
					return 0;
				}
			}

			// Token: 0x17001532 RID: 5426
			// (get) Token: 0x0600B194 RID: 45460 RVA: 0x00043CF8 File Offset: 0x00041EF8
			[Token(Token = "0x17001532")]
			public bool unlocked
			{
				[Token(Token = "0x600B194")]
				[Address(RVA = "0x32CCFB0", Offset = "0x32CBBB0", VA = "0x1832CCFB0", Slot = "12")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x17001533 RID: 5427
			// (get) Token: 0x0600B195 RID: 45461 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17001533")]
			public string unlockMessage
			{
				[Token(Token = "0x600B195")]
				[Address(RVA = "0x32CCF40", Offset = "0x32CBB40", VA = "0x1832CCF40", Slot = "13")]
				get
				{
					return null;
				}
			}

			// Token: 0x17001534 RID: 5428
			// (get) Token: 0x0600B196 RID: 45462 RVA: 0x00043D10 File Offset: 0x00041F10
			[Token(Token = "0x17001534")]
			public int byProductPercentage
			{
				[Token(Token = "0x600B196")]
				[Address(RVA = "0x32CC9D0", Offset = "0x32CB5D0", VA = "0x1832CC9D0")]
				get
				{
					return 0;
				}
			}

			// Token: 0x17001535 RID: 5429
			// (get) Token: 0x0600B197 RID: 45463 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17001535")]
			public string furniId
			{
				[Token(Token = "0x600B197")]
				[Address(RVA = "0x32CCB50", Offset = "0x32CB750", VA = "0x1832CCB50")]
				get
				{
					return null;
				}
			}

			// Token: 0x17001536 RID: 5430
			// (get) Token: 0x0600B198 RID: 45464 RVA: 0x00043D28 File Offset: 0x00041F28
			[Token(Token = "0x17001536")]
			public int apCost
			{
				[Token(Token = "0x600B198")]
				[Address(RVA = "0x32CC970", Offset = "0x32CB570", VA = "0x1832CC970", Slot = "14")]
				get
				{
					return 0;
				}
			}

			// Token: 0x17001537 RID: 5431
			// (get) Token: 0x0600B199 RID: 45465 RVA: 0x00043D40 File Offset: 0x00041F40
			[Token(Token = "0x17001537")]
			public long moodCost
			{
				[Token(Token = "0x600B199")]
				[Address(RVA = "0x32CCDA0", Offset = "0x32CB9A0", VA = "0x1832CCDA0")]
				get
				{
					return 0L;
				}
			}

			// Token: 0x17001538 RID: 5432
			// (get) Token: 0x0600B19A RID: 45466 RVA: 0x00043D58 File Offset: 0x00041F58
			[Token(Token = "0x17001538")]
			public int sortId
			{
				[Token(Token = "0x600B19A")]
				[Address(RVA = "0x32CCEE0", Offset = "0x32CBAE0", VA = "0x1832CCEE0", Slot = "15")]
				get
				{
					return 0;
				}
			}

			// Token: 0x0400AC09 RID: 44041
			[Token(Token = "0x400AC09")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private string m_ingredientId;

			// Token: 0x0400AC0A RID: 44042
			[Token(Token = "0x400AC0A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private string m_outcomeId;

			// Token: 0x0400AC0B RID: 44043
			[Token(Token = "0x400AC0B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private int m_outcomeCount;

			// Token: 0x0400AC0C RID: 44044
			[Token(Token = "0x400AC0C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			private int m_byProductPercentage;

			// Token: 0x0400AC0D RID: 44045
			[Token(Token = "0x400AC0D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private BuildingWorkshopModel.FormulaItem m_outcomeItem;

			// Token: 0x0400AC0E RID: 44046
			[Token(Token = "0x400AC0E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private BuildingWorkshopModel.FormulaItem m_ingredientItem;

			// Token: 0x0400AC0F RID: 44047
			[Token(Token = "0x400AC0F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x0400AC10 RID: 44048
			[Token(Token = "0x400AC10")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_get_id;

			// Token: 0x0400AC11 RID: 44049
			[Token(Token = "0x400AC11")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_get_outcome;

			// Token: 0x0400AC12 RID: 44050
			[Token(Token = "0x400AC12")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private static DelegateBridge __Hotfix0_get_ingredient1;

			// Token: 0x0400AC13 RID: 44051
			[Token(Token = "0x400AC13")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private static DelegateBridge __Hotfix0_get_ingredient2;

			// Token: 0x0400AC14 RID: 44052
			[Token(Token = "0x400AC14")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private static DelegateBridge __Hotfix0_get_ingredient3;

			// Token: 0x0400AC15 RID: 44053
			[Token(Token = "0x400AC15")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private static DelegateBridge __Hotfix0_get_costGoldCount;

			// Token: 0x0400AC16 RID: 44054
			[Token(Token = "0x400AC16")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private static DelegateBridge __Hotfix0_get_canBeProtected;

			// Token: 0x0400AC17 RID: 44055
			[Token(Token = "0x400AC17")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			private static DelegateBridge __Hotfix0_get_filterIndex;

			// Token: 0x0400AC18 RID: 44056
			[Token(Token = "0x400AC18")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			private static DelegateBridge __Hotfix0_get_unlocked;

			// Token: 0x0400AC19 RID: 44057
			[Token(Token = "0x400AC19")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			private static DelegateBridge __Hotfix0_get_unlockMessage;

			// Token: 0x0400AC1A RID: 44058
			[Token(Token = "0x400AC1A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			private static DelegateBridge __Hotfix0_get_byProductPercentage;

			// Token: 0x0400AC1B RID: 44059
			[Token(Token = "0x400AC1B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			private static DelegateBridge __Hotfix0_get_furniId;

			// Token: 0x0400AC1C RID: 44060
			[Token(Token = "0x400AC1C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
			private static DelegateBridge __Hotfix0_get_apCost;

			// Token: 0x0400AC1D RID: 44061
			[Token(Token = "0x400AC1D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
			private static DelegateBridge __Hotfix0_get_moodCost;

			// Token: 0x0400AC1E RID: 44062
			[Token(Token = "0x400AC1E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
			private static DelegateBridge __Hotfix0_get_sortId;
		}

		// Token: 0x02001BCB RID: 7115
		[Token(Token = "0x2001BCB")]
		private class Buff : IWorkshopBuildingBuff, IHotfixable
		{
			// Token: 0x0600B19B RID: 45467 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600B19B")]
			[Address(RVA = "0x32BAEA0", Offset = "0x32B9AA0", VA = "0x1832BAEA0")]
			public Buff()
			{
			}

			// Token: 0x0600B19C RID: 45468 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600B19C")]
			[Address(RVA = "0x32BAC20", Offset = "0x32B9820", VA = "0x1832BAC20")]
			public void Setup(BuildingCharModel charModel)
			{
			}

			// Token: 0x17001539 RID: 5433
			// (get) Token: 0x0600B19D RID: 45469 RVA: 0x00043D70 File Offset: 0x00041F70
			[Token(Token = "0x17001539")]
			public BuildingBuffDescStruct buffDesc
			{
				[Token(Token = "0x600B19D")]
				[Address(RVA = "0x32BAF00", Offset = "0x32B9B00", VA = "0x1832BAF00", Slot = "4")]
				get
				{
					return default(BuildingBuffDescStruct);
				}
			}

			// Token: 0x0400AC1F RID: 44063
			[Token(Token = "0x400AC1F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private BuildingBuffDescStruct m_targetBuff;

			// Token: 0x0400AC20 RID: 44064
			[Token(Token = "0x400AC20")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
			private List<BuildingBuffDescStruct> m_buffs;

			// Token: 0x0400AC21 RID: 44065
			[Token(Token = "0x400AC21")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x0400AC22 RID: 44066
			[Token(Token = "0x400AC22")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_Setup;

			// Token: 0x0400AC23 RID: 44067
			[Token(Token = "0x400AC23")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_get_buffDesc;
		}

		// Token: 0x02001BCC RID: 7116
		[Token(Token = "0x2001BCC")]
		private class StationaryCharacter : IWorkshopStationaryCharacter, IHotfixable
		{
			// Token: 0x0600B19E RID: 45470 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600B19E")]
			[Address(RVA = "0x32CF840", Offset = "0x32CE440", VA = "0x1832CF840")]
			public void Setup(BuildingCharModel buildingChar)
			{
			}

			// Token: 0x1700153A RID: 5434
			// (get) Token: 0x0600B19F RID: 45471 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x1700153A")]
			public string charId
			{
				[Token(Token = "0x600B19F")]
				[Address(RVA = "0x32CFFD0", Offset = "0x32CEBD0", VA = "0x1832CFFD0", Slot = "4")]
				get
				{
					return null;
				}
			}

			// Token: 0x1700153B RID: 5435
			// (get) Token: 0x0600B1A0 RID: 45472 RVA: 0x00043D88 File Offset: 0x00041F88
			[Token(Token = "0x1700153B")]
			public int instId
			{
				[Token(Token = "0x600B1A0")]
				[Address(RVA = "0x32D0030", Offset = "0x32CEC30", VA = "0x1832D0030")]
				get
				{
					return 0;
				}
			}

			// Token: 0x1700153C RID: 5436
			// (get) Token: 0x0600B1A1 RID: 45473 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x1700153C")]
			public string name
			{
				[Token(Token = "0x600B1A1")]
				[Address(RVA = "0x32D02B0", Offset = "0x32CEEB0", VA = "0x1832D02B0", Slot = "5")]
				get
				{
					return null;
				}
			}

			// Token: 0x1700153D RID: 5437
			// (get) Token: 0x0600B1A2 RID: 45474 RVA: 0x00043DA0 File Offset: 0x00041FA0
			[Token(Token = "0x1700153D")]
			public SpriteRenderData portrait
			{
				[Token(Token = "0x600B1A2")]
				[Address(RVA = "0x32D0340", Offset = "0x32CEF40", VA = "0x1832D0340", Slot = "6")]
				get
				{
					return default(SpriteRenderData);
				}
			}

			// Token: 0x1700153E RID: 5438
			// (get) Token: 0x0600B1A3 RID: 45475 RVA: 0x00043DB8 File Offset: 0x00041FB8
			[Token(Token = "0x1700153E")]
			public int mood
			{
				[Token(Token = "0x600B1A3")]
				[Address(RVA = "0x32D0170", Offset = "0x32CED70", VA = "0x1832D0170", Slot = "8")]
				get
				{
					return 0;
				}
			}

			// Token: 0x1700153F RID: 5439
			// (get) Token: 0x0600B1A4 RID: 45476 RVA: 0x00043DD0 File Offset: 0x00041FD0
			[Token(Token = "0x1700153F")]
			public long manpower
			{
				[Token(Token = "0x600B1A4")]
				[Address(RVA = "0x32D0090", Offset = "0x32CEC90", VA = "0x1832D0090", Slot = "7")]
				get
				{
					return 0L;
				}
			}

			// Token: 0x17001540 RID: 5440
			// (get) Token: 0x0600B1A5 RID: 45477 RVA: 0x00043DE8 File Offset: 0x00041FE8
			[Token(Token = "0x17001540")]
			public int realMood
			{
				[Token(Token = "0x600B1A5")]
				[Address(RVA = "0x32D03F0", Offset = "0x32CEFF0", VA = "0x1832D03F0")]
				get
				{
					return 0;
				}
			}

			// Token: 0x17001541 RID: 5441
			// (get) Token: 0x0600B1A6 RID: 45478 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17001541")]
			public IWorkshopBuildingBuff buildingBuff
			{
				[Token(Token = "0x600B1A6")]
				[Address(RVA = "0x32CFE50", Offset = "0x32CEA50", VA = "0x1832CFE50", Slot = "11")]
				get
				{
					return null;
				}
			}

			// Token: 0x17001542 RID: 5442
			// (get) Token: 0x0600B1A7 RID: 45479 RVA: 0x00043E00 File Offset: 0x00042000
			[Token(Token = "0x17001542")]
			public int maxMood
			{
				[Token(Token = "0x600B1A7")]
				[Address(RVA = "0x32D00F0", Offset = "0x32CECF0", VA = "0x1832D00F0", Slot = "9")]
				get
				{
					return 0;
				}
			}

			// Token: 0x17001543 RID: 5443
			// (get) Token: 0x0600B1A8 RID: 45480 RVA: 0x00043E18 File Offset: 0x00042018
			[Token(Token = "0x17001543")]
			public CharManpowerState mpState
			{
				[Token(Token = "0x600B1A8")]
				[Address(RVA = "0x32D01F0", Offset = "0x32CEDF0", VA = "0x1832D01F0", Slot = "10")]
				get
				{
					return CharManpowerState.NONE;
				}
			}

			// Token: 0x0600B1A9 RID: 45481 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600B1A9")]
			[Address(RVA = "0x32CFD60", Offset = "0x32CE960", VA = "0x1832CFD60")]
			public StationaryCharacter()
			{
			}

			// Token: 0x0400AC24 RID: 44068
			[Token(Token = "0x400AC24")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private BuildingCharModel m_buildingChar;

			// Token: 0x0400AC25 RID: 44069
			[Token(Token = "0x400AC25")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
			private CharacterCardViewModel m_cardViewModel;

			// Token: 0x0400AC26 RID: 44070
			[Token(Token = "0x400AC26")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
			private SpriteRenderData m_portraitSprite;

			// Token: 0x0400AC27 RID: 44071
			[Token(Token = "0x400AC27")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
			private BuildingWorkshopModel.Buff m_buff;

			// Token: 0x0400AC28 RID: 44072
			[Token(Token = "0x400AC28")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_Setup;

			// Token: 0x0400AC29 RID: 44073
			[Token(Token = "0x400AC29")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_get_charId;

			// Token: 0x0400AC2A RID: 44074
			[Token(Token = "0x400AC2A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_get_instId;

			// Token: 0x0400AC2B RID: 44075
			[Token(Token = "0x400AC2B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private static DelegateBridge __Hotfix0_get_name;

			// Token: 0x0400AC2C RID: 44076
			[Token(Token = "0x400AC2C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private static DelegateBridge __Hotfix0_get_portrait;

			// Token: 0x0400AC2D RID: 44077
			[Token(Token = "0x400AC2D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private static DelegateBridge __Hotfix0_get_mood;

			// Token: 0x0400AC2E RID: 44078
			[Token(Token = "0x400AC2E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private static DelegateBridge __Hotfix0_get_manpower;

			// Token: 0x0400AC2F RID: 44079
			[Token(Token = "0x400AC2F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private static DelegateBridge __Hotfix0_get_realMood;

			// Token: 0x0400AC30 RID: 44080
			[Token(Token = "0x400AC30")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			private static DelegateBridge __Hotfix0_get_buildingBuff;

			// Token: 0x0400AC31 RID: 44081
			[Token(Token = "0x400AC31")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			private static DelegateBridge __Hotfix0_get_maxMood;

			// Token: 0x0400AC32 RID: 44082
			[Token(Token = "0x400AC32")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			private static DelegateBridge __Hotfix0_get_mpState;

			// Token: 0x0400AC33 RID: 44083
			[Token(Token = "0x400AC33")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}

		// Token: 0x02001BCD RID: 7117
		[Token(Token = "0x2001BCD")]
		private class WRoomViewModel : IBasicRoomModel, IHotfixable
		{
			// Token: 0x0600B1AA RID: 45482 RVA: 0x00043E30 File Offset: 0x00042030
			[Token(Token = "0x600B1AA")]
			[Address(RVA = "0x32D20A0", Offset = "0x32D0CA0", VA = "0x1832D20A0", Slot = "4")]
			public BasicRoomInfoModel GetRoomInfo()
			{
				return default(BasicRoomInfoModel);
			}

			// Token: 0x0600B1AB RID: 45483 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600B1AB")]
			[Address(RVA = "0x32D2130", Offset = "0x32D0D30", VA = "0x1832D2130")]
			public WRoomViewModel()
			{
			}

			// Token: 0x0400AC34 RID: 44084
			[Token(Token = "0x400AC34")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public BasicRoomInfoModel roomInfo;

			// Token: 0x0400AC35 RID: 44085
			[Token(Token = "0x400AC35")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_GetRoomInfo;

			// Token: 0x0400AC36 RID: 44086
			[Token(Token = "0x400AC36")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}

		// Token: 0x02001BCE RID: 7118
		[Token(Token = "0x2001BCE")]
		public class TargetItemInfo : IHotfixable
		{
			// Token: 0x17001544 RID: 5444
			// (get) Token: 0x0600B1AC RID: 45484 RVA: 0x00043E48 File Offset: 0x00042048
			// (set) Token: 0x0600B1AD RID: 45485 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x17001544")]
			public bool needShowTargetAmountInfo
			{
				[Token(Token = "0x600B1AC")]
				[Address(RVA = "0x32D05A0", Offset = "0x32CF1A0", VA = "0x1832D05A0")]
				[CompilerGenerated]
				get
				{
					return default(bool);
				}
				[Token(Token = "0x600B1AD")]
				[Address(RVA = "0x32D0600", Offset = "0x32CF200", VA = "0x1832D0600")]
				[CompilerGenerated]
				private set
				{
				}
			}

			// Token: 0x0600B1AE RID: 45486 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600B1AE")]
			[Address(RVA = "0x32D0450", Offset = "0x32CF050", VA = "0x1832D0450")]
			public void FindIfNeedShowTargetAmountInfo(BuildingWorkShopFormulaTree formulaTree)
			{
			}

			// Token: 0x0600B1AF RID: 45487 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600B1AF")]
			[Address(RVA = "0x32D0540", Offset = "0x32CF140", VA = "0x1832D0540")]
			public TargetItemInfo()
			{
			}

			// Token: 0x0400AC37 RID: 44087
			[Token(Token = "0x400AC37")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public string itemId;

			// Token: 0x0400AC38 RID: 44088
			[Token(Token = "0x400AC38")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public int targetAmount;

			// Token: 0x0400AC3A RID: 44090
			[Token(Token = "0x400AC3A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_get_needShowTargetAmountInfo;

			// Token: 0x0400AC3B RID: 44091
			[Token(Token = "0x400AC3B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_set_needShowTargetAmountInfo;

			// Token: 0x0400AC3C RID: 44092
			[Token(Token = "0x400AC3C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_FindIfNeedShowTargetAmountInfo;

			// Token: 0x0400AC3D RID: 44093
			[Token(Token = "0x400AC3D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}
	}
}

using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.SandboxPerm.SandboxV2
{
	// Token: 0x0200443A RID: 17466
	[Token(Token = "0x200443A")]
	public class SandboxV2SquadModel : IHotfixable
	{
		// Token: 0x17003F47 RID: 16199
		// (get) Token: 0x0601AADD RID: 109277 RVA: 0x000A2D38 File Offset: 0x000A0F38
		[Token(Token = "0x17003F47")]
		public int squadIndex
		{
			[Token(Token = "0x601AADD")]
			[Address(RVA = "0x13D0EC0", Offset = "0x13CFAC0", VA = "0x1813D0EC0")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17003F48 RID: 16200
		// (get) Token: 0x0601AADE RID: 109278 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17003F48")]
		public List<SandboxV2SquadCharModel> charList
		{
			[Token(Token = "0x601AADE")]
			[Address(RVA = "0x13D0DA0", Offset = "0x13CF9A0", VA = "0x1813D0DA0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17003F49 RID: 16201
		// (get) Token: 0x0601AADF RID: 109279 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17003F49")]
		public List<SandboxV2SquadToolModel> toolList
		{
			[Token(Token = "0x601AADF")]
			[Address(RVA = "0x13D0F80", Offset = "0x13CFB80", VA = "0x1813D0F80")]
			get
			{
				return null;
			}
		}

		// Token: 0x17003F4A RID: 16202
		// (get) Token: 0x0601AAE0 RID: 109280 RVA: 0x000A2D50 File Offset: 0x000A0F50
		[Token(Token = "0x17003F4A")]
		public int squadToolCapacity
		{
			[Token(Token = "0x601AAE0")]
			[Address(RVA = "0x13D0F20", Offset = "0x13CFB20", VA = "0x1813D0F20")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17003F4B RID: 16203
		// (get) Token: 0x0601AAE1 RID: 109281 RVA: 0x000A2D68 File Offset: 0x000A0F68
		[Token(Token = "0x17003F4B")]
		public int squadCharCapacity
		{
			[Token(Token = "0x601AAE1")]
			[Address(RVA = "0x13D0E60", Offset = "0x13CFA60", VA = "0x1813D0E60")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17003F4C RID: 16204
		// (get) Token: 0x0601AAE2 RID: 109282 RVA: 0x000A2D80 File Offset: 0x000A0F80
		[Token(Token = "0x17003F4C")]
		public bool isWithoutDrinkCost
		{
			[Token(Token = "0x601AAE2")]
			[Address(RVA = "0x13D0E00", Offset = "0x13CFA00", VA = "0x1813D0E00")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x0601AAE3 RID: 109283 RVA: 0x000A2D98 File Offset: 0x000A0F98
		[Token(Token = "0x601AAE3")]
		[Address(RVA = "0x13CDEF0", Offset = "0x13CCAF0", VA = "0x1813CDEF0")]
		public bool CheckIfSquadChanged(string topicId)
		{
			return default(bool);
		}

		// Token: 0x0601AAE4 RID: 109284 RVA: 0x000A2DB0 File Offset: 0x000A0FB0
		[Token(Token = "0x601AAE4")]
		[Address(RVA = "0x13D0180", Offset = "0x13CED80", VA = "0x1813D0180")]
		private bool _CheckIfCharListChanged(List<PlayerSquadItem> slots)
		{
			return default(bool);
		}

		// Token: 0x0601AAE5 RID: 109285 RVA: 0x000A2DC8 File Offset: 0x000A0FC8
		[Token(Token = "0x601AAE5")]
		[Address(RVA = "0x13D02C0", Offset = "0x13CEEC0", VA = "0x1813D02C0")]
		private bool _CheckIfToolListChanged(List<string> tools)
		{
			return default(bool);
		}

		// Token: 0x0601AAE6 RID: 109286 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601AAE6")]
		[Address(RVA = "0x13CE250", Offset = "0x13CCE50", VA = "0x1813CE250")]
		public void ClearSquad(string topicId)
		{
		}

		// Token: 0x0601AAE7 RID: 109287 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601AAE7")]
		[Address(RVA = "0x13CF960", Offset = "0x13CE560", VA = "0x1813CF960")]
		public void UpdateCharPlayerData()
		{
		}

		// Token: 0x0601AAE8 RID: 109288 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601AAE8")]
		[Address(RVA = "0x13CF8C0", Offset = "0x13CE4C0", VA = "0x1813CF8C0")]
		public void UpdateCharList(string topicId, List<SandboxV2CharSquad> selectCharList)
		{
		}

		// Token: 0x0601AAE9 RID: 109289 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601AAE9")]
		[Address(RVA = "0x13CFA30", Offset = "0x13CE630", VA = "0x1813CFA30")]
		public void UpdateChar(string topicId, int editIndex, List<SandboxV2CharSquad> selectCharList)
		{
		}

		// Token: 0x0601AAEA RID: 109290 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601AAEA")]
		[Address(RVA = "0x13CFC80", Offset = "0x13CE880", VA = "0x1813CFC80")]
		public void UpdateToolPlayerData()
		{
		}

		// Token: 0x0601AAEB RID: 109291 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601AAEB")]
		[Address(RVA = "0x13CF780", Offset = "0x13CE380", VA = "0x1813CF780")]
		public void RebuildToolList()
		{
		}

		// Token: 0x0601AAEC RID: 109292 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601AAEC")]
		[Address(RVA = "0x13CFBE0", Offset = "0x13CE7E0", VA = "0x1813CFBE0")]
		public void UpdateToolList(string topicId, List<string> selectToolList)
		{
		}

		// Token: 0x0601AAED RID: 109293 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601AAED")]
		[Address(RVA = "0x13CFD50", Offset = "0x13CE950", VA = "0x1813CFD50")]
		public void UpdateTool(string topicId, int editIndex, List<string> selectToolList)
		{
		}

		// Token: 0x0601AAEE RID: 109294 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601AAEE")]
		[Address(RVA = "0x13CE440", Offset = "0x13CD040", VA = "0x1813CE440")]
		public List<int> GenCharInstIdList(int ignoreInstId = -1)
		{
			return null;
		}

		// Token: 0x0601AAEF RID: 109295 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601AAEF")]
		[Address(RVA = "0x13CEB80", Offset = "0x13CD780", VA = "0x1813CEB80")]
		public List<string> GenToolIdList()
		{
			return null;
		}

		// Token: 0x0601AAF0 RID: 109296 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601AAF0")]
		[Address(RVA = "0x13CE5C0", Offset = "0x13CD1C0", VA = "0x1813CE5C0")]
		public ListDict<int, SandboxV2CharSquad> GenCharSquadList(int ignoreInstId = -1)
		{
			return null;
		}

		// Token: 0x0601AAF1 RID: 109297 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601AAF1")]
		[Address(RVA = "0x13CECC0", Offset = "0x13CD8C0", VA = "0x1813CECC0")]
		public SandboxV2SquadCharModel GetCharModelBy(int instId)
		{
			return null;
		}

		// Token: 0x0601AAF2 RID: 109298 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601AAF2")]
		[Address(RVA = "0x13CDBD0", Offset = "0x13CC7D0", VA = "0x1813CDBD0")]
		public List<SandboxV2SlotStatus> CalcSlotStatusList()
		{
			return null;
		}

		// Token: 0x0601AAF3 RID: 109299 RVA: 0x000A2DE0 File Offset: 0x000A0FE0
		[Token(Token = "0x601AAF3")]
		[Address(RVA = "0x13CDE10", Offset = "0x13CCA10", VA = "0x1813CDE10")]
		public SandboxV2SquadModel.SquadScale CalcSquadScale()
		{
			return default(SandboxV2SquadModel.SquadScale);
		}

		// Token: 0x0601AAF4 RID: 109300 RVA: 0x000A2DF8 File Offset: 0x000A0FF8
		[Token(Token = "0x601AAF4")]
		[Address(RVA = "0x13CDB70", Offset = "0x13CC770", VA = "0x1813CDB70")]
		public int CalcDrinkCost()
		{
			return 0;
		}

		// Token: 0x0601AAF5 RID: 109301 RVA: 0x000A2E10 File Offset: 0x000A1010
		[Token(Token = "0x601AAF5")]
		[Address(RVA = "0x13CFEB0", Offset = "0x13CEAB0", VA = "0x1813CFEB0")]
		private int _CalcDrinkCost()
		{
			return 0;
		}

		// Token: 0x0601AAF6 RID: 109302 RVA: 0x000A2E28 File Offset: 0x000A1028
		[Token(Token = "0x601AAF6")]
		[Address(RVA = "0x13CDB00", Offset = "0x13CC700", VA = "0x1813CDB00")]
		public int CalcDisplayToolCount()
		{
			return 0;
		}

		// Token: 0x0601AAF7 RID: 109303 RVA: 0x000A2E40 File Offset: 0x000A1040
		[Token(Token = "0x601AAF7")]
		[Address(RVA = "0x13D00A0", Offset = "0x13CECA0", VA = "0x1813D00A0")]
		private int _CalcTotalToolCount()
		{
			return 0;
		}

		// Token: 0x0601AAF8 RID: 109304 RVA: 0x000A2E58 File Offset: 0x000A1058
		[Token(Token = "0x601AAF8")]
		[Address(RVA = "0x13CFF90", Offset = "0x13CEB90", VA = "0x1813CFF90")]
		private int _CalcTotalCharCount(bool skipUsedChar)
		{
			return 0;
		}

		// Token: 0x0601AAF9 RID: 109305 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601AAF9")]
		[Address(RVA = "0x13CF390", Offset = "0x13CDF90", VA = "0x1813CF390")]
		public void Init(string topicId, int squadIdx, PlayerSandboxV2.Troop troop, SandboxV2SquadPanelShowMode showMode)
		{
		}

		// Token: 0x0601AAFA RID: 109306 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601AAFA")]
		[Address(RVA = "0x13D03F0", Offset = "0x13CEFF0", VA = "0x1813D03F0")]
		private void _InitCharList(List<PlayerSquadItem> playerSlotList, bool isTutorial)
		{
		}

		// Token: 0x0601AAFB RID: 109307 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601AAFB")]
		[Address(RVA = "0x13D07A0", Offset = "0x13CF3A0", VA = "0x1813D07A0")]
		private void _InitToolList(List<string> playerToolList)
		{
		}

		// Token: 0x0601AAFC RID: 109308 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601AAFC")]
		[Address(RVA = "0x13D0900", Offset = "0x13CF500", VA = "0x1813D0900")]
		private void _UpdateCharList(string topicId, List<SandboxV2CharSquad> selectCharList)
		{
		}

		// Token: 0x0601AAFD RID: 109309 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601AAFD")]
		[Address(RVA = "0x13D0AE0", Offset = "0x13CF6E0", VA = "0x1813D0AE0")]
		private void _UpdateToolList(string topicId, List<string> selectToolList)
		{
		}

		// Token: 0x0601AAFE RID: 109310 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601AAFE")]
		[Address(RVA = "0x13CE7F0", Offset = "0x13CD3F0", VA = "0x1813CE7F0")]
		public List<RequestSquadSlot> GenRequestSlotList()
		{
			return null;
		}

		// Token: 0x0601AAFF RID: 109311 RVA: 0x000A2E70 File Offset: 0x000A1070
		[Token(Token = "0x601AAFF")]
		[Address(RVA = "0x13CF660", Offset = "0x13CE260", VA = "0x1813CF660")]
		public bool IsDrinkEnough(string topicId)
		{
			return default(bool);
		}

		// Token: 0x0601AB00 RID: 109312 RVA: 0x000A2E88 File Offset: 0x000A1088
		[Token(Token = "0x601AB00")]
		[Address(RVA = "0x13CF5F0", Offset = "0x13CE1F0", VA = "0x1813CF5F0")]
		public bool IsCharEmpty()
		{
			return default(bool);
		}

		// Token: 0x0601AB01 RID: 109313 RVA: 0x000A2EA0 File Offset: 0x000A10A0
		[Token(Token = "0x601AB01")]
		[Address(RVA = "0x13CF710", Offset = "0x13CE310", VA = "0x1813CF710")]
		public bool IsLargeSquad()
		{
			return default(bool);
		}

		// Token: 0x0601AB02 RID: 109314 RVA: 0x000A2EB8 File Offset: 0x000A10B8
		[Token(Token = "0x601AB02")]
		[Address(RVA = "0x13CF190", Offset = "0x13CDD90", VA = "0x1813CF190")]
		public bool HasCharAbnormal()
		{
			return default(bool);
		}

		// Token: 0x0601AB03 RID: 109315 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601AB03")]
		[Address(RVA = "0x13CE2E0", Offset = "0x13CCEE0", VA = "0x1813CE2E0")]
		public List<AdvancedCharacterInst> GenBattleSlots()
		{
			return null;
		}

		// Token: 0x0601AB04 RID: 109316 RVA: 0x000A2ED0 File Offset: 0x000A10D0
		[Token(Token = "0x601AB04")]
		[Address(RVA = "0x13CEDC0", Offset = "0x13CD9C0", VA = "0x1813CEDC0")]
		public CharUISkinStruct GetRandomCharSkin()
		{
			return default(CharUISkinStruct);
		}

		// Token: 0x0601AB05 RID: 109317 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601AB05")]
		[Address(RVA = "0x13CEA20", Offset = "0x13CD620", VA = "0x1813CEA20")]
		public Dictionary<string, int> GenToolDict()
		{
			return null;
		}

		// Token: 0x0601AB06 RID: 109318 RVA: 0x000A2EE8 File Offset: 0x000A10E8
		[Token(Token = "0x601AB06")]
		[Address(RVA = "0x13CF2A0", Offset = "0x13CDEA0", VA = "0x1813CF2A0")]
		public bool HasToolLack()
		{
			return default(bool);
		}

		// Token: 0x0601AB07 RID: 109319 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601AB07")]
		[Address(RVA = "0x13D0C50", Offset = "0x13CF850", VA = "0x1813D0C50")]
		public SandboxV2SquadModel()
		{
		}

		// Token: 0x040220F2 RID: 139506
		[Token(Token = "0x40220F2")]
		[FieldOffset(Offset = "0x10")]
		private List<SandboxV2SquadToolModel> m_toolList;

		// Token: 0x040220F3 RID: 139507
		[Token(Token = "0x40220F3")]
		[FieldOffset(Offset = "0x18")]
		private List<SandboxV2SquadCharModel> m_charList;

		// Token: 0x040220F4 RID: 139508
		[Token(Token = "0x40220F4")]
		[FieldOffset(Offset = "0x20")]
		private List<SandboxV2SlotStatus> m_slotStatusList;

		// Token: 0x040220F5 RID: 139509
		[Token(Token = "0x40220F5")]
		[FieldOffset(Offset = "0x28")]
		private int m_index;

		// Token: 0x040220F6 RID: 139510
		[Token(Token = "0x40220F6")]
		[FieldOffset(Offset = "0x30")]
		private string m_topicId;

		// Token: 0x040220F7 RID: 139511
		[Token(Token = "0x40220F7")]
		[FieldOffset(Offset = "0x38")]
		private int m_squadCharCapacity;

		// Token: 0x040220F8 RID: 139512
		[Token(Token = "0x40220F8")]
		[FieldOffset(Offset = "0x3C")]
		private int m_miniSquadCharCapacity;

		// Token: 0x040220F9 RID: 139513
		[Token(Token = "0x40220F9")]
		[FieldOffset(Offset = "0x40")]
		private int m_emptySquadDrinkCost;

		// Token: 0x040220FA RID: 139514
		[Token(Token = "0x40220FA")]
		[FieldOffset(Offset = "0x44")]
		private int m_miniSquadDrinkCost;

		// Token: 0x040220FB RID: 139515
		[Token(Token = "0x40220FB")]
		[FieldOffset(Offset = "0x48")]
		private int m_normalSquadDrinkCost;

		// Token: 0x040220FC RID: 139516
		[Token(Token = "0x40220FC")]
		[FieldOffset(Offset = "0x4C")]
		private int m_toolboxCapacity;

		// Token: 0x040220FD RID: 139517
		[Token(Token = "0x40220FD")]
		[FieldOffset(Offset = "0x50")]
		private SandboxV2SquadPanelShowMode m_showMode;

		// Token: 0x040220FE RID: 139518
		[Token(Token = "0x40220FE")]
		[FieldOffset(Offset = "0x54")]
		private bool m_isTutorial;

		// Token: 0x040220FF RID: 139519
		[Token(Token = "0x40220FF")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_squadIndex;

		// Token: 0x04022100 RID: 139520
		[Token(Token = "0x4022100")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_charList;

		// Token: 0x04022101 RID: 139521
		[Token(Token = "0x4022101")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_toolList;

		// Token: 0x04022102 RID: 139522
		[Token(Token = "0x4022102")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_get_squadToolCapacity;

		// Token: 0x04022103 RID: 139523
		[Token(Token = "0x4022103")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_get_squadCharCapacity;

		// Token: 0x04022104 RID: 139524
		[Token(Token = "0x4022104")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_get_isWithoutDrinkCost;

		// Token: 0x04022105 RID: 139525
		[Token(Token = "0x4022105")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_CheckIfSquadChanged;

		// Token: 0x04022106 RID: 139526
		[Token(Token = "0x4022106")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__CheckIfCharListChanged;

		// Token: 0x04022107 RID: 139527
		[Token(Token = "0x4022107")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__CheckIfToolListChanged;

		// Token: 0x04022108 RID: 139528
		[Token(Token = "0x4022108")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_ClearSquad;

		// Token: 0x04022109 RID: 139529
		[Token(Token = "0x4022109")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_UpdateCharPlayerData;

		// Token: 0x0402210A RID: 139530
		[Token(Token = "0x402210A")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_UpdateCharList;

		// Token: 0x0402210B RID: 139531
		[Token(Token = "0x402210B")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0_UpdateChar;

		// Token: 0x0402210C RID: 139532
		[Token(Token = "0x402210C")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0_UpdateToolPlayerData;

		// Token: 0x0402210D RID: 139533
		[Token(Token = "0x402210D")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0_RebuildToolList;

		// Token: 0x0402210E RID: 139534
		[Token(Token = "0x402210E")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0_UpdateToolList;

		// Token: 0x0402210F RID: 139535
		[Token(Token = "0x402210F")]
		[FieldOffset(Offset = "0x80")]
		private static DelegateBridge __Hotfix0_UpdateTool;

		// Token: 0x04022110 RID: 139536
		[Token(Token = "0x4022110")]
		[FieldOffset(Offset = "0x88")]
		private static DelegateBridge __Hotfix0_GenCharInstIdList;

		// Token: 0x04022111 RID: 139537
		[Token(Token = "0x4022111")]
		[FieldOffset(Offset = "0x90")]
		private static DelegateBridge __Hotfix0_GenToolIdList;

		// Token: 0x04022112 RID: 139538
		[Token(Token = "0x4022112")]
		[FieldOffset(Offset = "0x98")]
		private static DelegateBridge __Hotfix0_GenCharSquadList;

		// Token: 0x04022113 RID: 139539
		[Token(Token = "0x4022113")]
		[FieldOffset(Offset = "0xA0")]
		private static DelegateBridge __Hotfix0_GetCharModelBy;

		// Token: 0x04022114 RID: 139540
		[Token(Token = "0x4022114")]
		[FieldOffset(Offset = "0xA8")]
		private static DelegateBridge __Hotfix0_CalcSlotStatusList;

		// Token: 0x04022115 RID: 139541
		[Token(Token = "0x4022115")]
		[FieldOffset(Offset = "0xB0")]
		private static DelegateBridge __Hotfix0_CalcSquadScale;

		// Token: 0x04022116 RID: 139542
		[Token(Token = "0x4022116")]
		[FieldOffset(Offset = "0xB8")]
		private static DelegateBridge __Hotfix0_CalcDrinkCost;

		// Token: 0x04022117 RID: 139543
		[Token(Token = "0x4022117")]
		[FieldOffset(Offset = "0xC0")]
		private static DelegateBridge __Hotfix0__CalcDrinkCost;

		// Token: 0x04022118 RID: 139544
		[Token(Token = "0x4022118")]
		[FieldOffset(Offset = "0xC8")]
		private static DelegateBridge __Hotfix0_CalcDisplayToolCount;

		// Token: 0x04022119 RID: 139545
		[Token(Token = "0x4022119")]
		[FieldOffset(Offset = "0xD0")]
		private static DelegateBridge __Hotfix0__CalcTotalToolCount;

		// Token: 0x0402211A RID: 139546
		[Token(Token = "0x402211A")]
		[FieldOffset(Offset = "0xD8")]
		private static DelegateBridge __Hotfix0__CalcTotalCharCount;

		// Token: 0x0402211B RID: 139547
		[Token(Token = "0x402211B")]
		[FieldOffset(Offset = "0xE0")]
		private static DelegateBridge __Hotfix0_Init;

		// Token: 0x0402211C RID: 139548
		[Token(Token = "0x402211C")]
		[FieldOffset(Offset = "0xE8")]
		private static DelegateBridge __Hotfix0__InitCharList;

		// Token: 0x0402211D RID: 139549
		[Token(Token = "0x402211D")]
		[FieldOffset(Offset = "0xF0")]
		private static DelegateBridge __Hotfix0__InitToolList;

		// Token: 0x0402211E RID: 139550
		[Token(Token = "0x402211E")]
		[FieldOffset(Offset = "0xF8")]
		private static DelegateBridge __Hotfix0__UpdateCharList;

		// Token: 0x0402211F RID: 139551
		[Token(Token = "0x402211F")]
		[FieldOffset(Offset = "0x100")]
		private static DelegateBridge __Hotfix0__UpdateToolList;

		// Token: 0x04022120 RID: 139552
		[Token(Token = "0x4022120")]
		[FieldOffset(Offset = "0x108")]
		private static DelegateBridge __Hotfix0_GenRequestSlotList;

		// Token: 0x04022121 RID: 139553
		[Token(Token = "0x4022121")]
		[FieldOffset(Offset = "0x110")]
		private static DelegateBridge __Hotfix0_IsDrinkEnough;

		// Token: 0x04022122 RID: 139554
		[Token(Token = "0x4022122")]
		[FieldOffset(Offset = "0x118")]
		private static DelegateBridge __Hotfix0_IsCharEmpty;

		// Token: 0x04022123 RID: 139555
		[Token(Token = "0x4022123")]
		[FieldOffset(Offset = "0x120")]
		private static DelegateBridge __Hotfix0_IsLargeSquad;

		// Token: 0x04022124 RID: 139556
		[Token(Token = "0x4022124")]
		[FieldOffset(Offset = "0x128")]
		private static DelegateBridge __Hotfix0_HasCharAbnormal;

		// Token: 0x04022125 RID: 139557
		[Token(Token = "0x4022125")]
		[FieldOffset(Offset = "0x130")]
		private static DelegateBridge __Hotfix0_GenBattleSlots;

		// Token: 0x04022126 RID: 139558
		[Token(Token = "0x4022126")]
		[FieldOffset(Offset = "0x138")]
		private static DelegateBridge __Hotfix0_GetRandomCharSkin;

		// Token: 0x04022127 RID: 139559
		[Token(Token = "0x4022127")]
		[FieldOffset(Offset = "0x140")]
		private static DelegateBridge __Hotfix0_GenToolDict;

		// Token: 0x04022128 RID: 139560
		[Token(Token = "0x4022128")]
		[FieldOffset(Offset = "0x148")]
		private static DelegateBridge __Hotfix0_HasToolLack;

		// Token: 0x04022129 RID: 139561
		[Token(Token = "0x4022129")]
		[FieldOffset(Offset = "0x150")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x0200443B RID: 17467
		[Token(Token = "0x200443B")]
		public struct SquadScale
		{
			// Token: 0x0402212A RID: 139562
			[Token(Token = "0x402212A")]
			[FieldOffset(Offset = "0x0")]
			public int currentCharLimit;

			// Token: 0x0402212B RID: 139563
			[Token(Token = "0x402212B")]
			[FieldOffset(Offset = "0x4")]
			public int nextCharLimit;
		}
	}
}

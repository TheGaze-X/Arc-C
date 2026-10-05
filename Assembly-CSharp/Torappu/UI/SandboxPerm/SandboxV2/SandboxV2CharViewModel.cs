using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Torappu.UI.CharSelect;
using UnityEngine;
using XLua;

namespace Torappu.UI.SandboxPerm.SandboxV2
{
	// Token: 0x02004056 RID: 16470
	[Token(Token = "0x2004056")]
	public class SandboxV2CharViewModel : IBasicCharInfo, IHotfixable, IComparable<SandboxV2CharViewModel>
	{
		// Token: 0x17003C9A RID: 15514
		// (get) Token: 0x0601978C RID: 104332 RVA: 0x0009E2B0 File Offset: 0x0009C4B0
		// (set) Token: 0x0601978D RID: 104333 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17003C9A")]
		public Color rarityColor
		{
			[Token(Token = "0x601978C")]
			[Address(RVA = "0x12374C0", Offset = "0x12360C0", VA = "0x1812374C0")]
			[CompilerGenerated]
			get
			{
				return default(Color);
			}
			[Token(Token = "0x601978D")]
			[Address(RVA = "0x1237540", Offset = "0x1236140", VA = "0x181237540")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17003C9B RID: 15515
		// (get) Token: 0x0601978E RID: 104334 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17003C9B")]
		public BasicCharInfoModel basicCharInfo
		{
			[Token(Token = "0x601978E")]
			[Address(RVA = "0x12373D0", Offset = "0x1235FD0", VA = "0x1812373D0", Slot = "4")]
			get
			{
				return null;
			}
		}

		// Token: 0x17003C9C RID: 15516
		// (get) Token: 0x0601978F RID: 104335 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17003C9C")]
		public string currentEquipId
		{
			[Token(Token = "0x601978F")]
			[Address(RVA = "0x1237430", Offset = "0x1236030", VA = "0x181237430")]
			get
			{
				return null;
			}
		}

		// Token: 0x06019790 RID: 104336 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019790")]
		[Address(RVA = "0x1235700", Offset = "0x1234300", VA = "0x181235700")]
		public void ApplyCharSelect(SandboxV2CharSquad charSquad)
		{
		}

		// Token: 0x06019791 RID: 104337 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019791")]
		[Address(RVA = "0x1235BF0", Offset = "0x12347F0", VA = "0x181235BF0")]
		public void ApplySkillSelect(string selectSkill)
		{
		}

		// Token: 0x06019792 RID: 104338 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019792")]
		[Address(RVA = "0x12357D0", Offset = "0x12343D0", VA = "0x1812357D0")]
		public void ApplyEquipId(string equipId)
		{
		}

		// Token: 0x06019793 RID: 104339 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019793")]
		[Address(RVA = "0x1236FB0", Offset = "0x1235BB0", VA = "0x181236FB0")]
		public SandboxV2CharViewModel(string topicId, PlayerCharacter playerChar)
		{
		}

		// Token: 0x06019794 RID: 104340 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019794")]
		[Address(RVA = "0x12360F0", Offset = "0x1234CF0", VA = "0x1812360F0")]
		public void InitSelectPartIfNot()
		{
		}

		// Token: 0x06019795 RID: 104341 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019795")]
		[Address(RVA = "0x1236360", Offset = "0x1234F60", VA = "0x181236360")]
		public void UpdatePlayerData(bool skipLoadSkillIcon = false)
		{
		}

		// Token: 0x06019796 RID: 104342 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019796")]
		[Address(RVA = "0x12369B0", Offset = "0x12355B0", VA = "0x1812369B0")]
		private void _UpdatePlayerData(PlayerSandboxV2 playerSandboxV2, PlayerCharacter playerChar, CharacterData charData)
		{
		}

		// Token: 0x06019797 RID: 104343 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019797")]
		[Address(RVA = "0x1236880", Offset = "0x1235480", VA = "0x181236880")]
		private void _UpdateFoodModel(PlayerSandboxV2 playerSandbox)
		{
		}

		// Token: 0x06019798 RID: 104344 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019798")]
		[Address(RVA = "0x1236710", Offset = "0x1235310", VA = "0x181236710")]
		private void _InitLogisticsRelatedData(string topicId, CharacterData characterData, PlayerCharacter playerChar)
		{
		}

		// Token: 0x06019799 RID: 104345 RVA: 0x0009E2C8 File Offset: 0x0009C4C8
		[Token(Token = "0x6019799")]
		[Address(RVA = "0x1235C80", Offset = "0x1234880", VA = "0x181235C80", Slot = "5")]
		public int CompareTo(SandboxV2CharViewModel obj)
		{
			return 0;
		}

		// Token: 0x0401FBD9 RID: 130009
		[Token(Token = "0x401FBD9")]
		[FieldOffset(Offset = "0x10")]
		private BasicCharInfoModel m_basicInfoModel;

		// Token: 0x0401FBDA RID: 130010
		[Token(Token = "0x401FBDA")]
		[FieldOffset(Offset = "0x18")]
		public string topicId;

		// Token: 0x0401FBDB RID: 130011
		[Token(Token = "0x401FBDB")]
		[FieldOffset(Offset = "0x20")]
		public int instId;

		// Token: 0x0401FBDC RID: 130012
		[Token(Token = "0x401FBDC")]
		[FieldOffset(Offset = "0x24")]
		public bool isInited;

		// Token: 0x0401FBDD RID: 130013
		[Token(Token = "0x401FBDD")]
		[FieldOffset(Offset = "0x25")]
		public bool ifFetchPlayerData;

		// Token: 0x0401FBDE RID: 130014
		[Token(Token = "0x401FBDE")]
		[FieldOffset(Offset = "0x28")]
		public string selectedSkillId;

		// Token: 0x0401FBDF RID: 130015
		[Token(Token = "0x401FBDF")]
		[FieldOffset(Offset = "0x30")]
		public string cacheCurrentEquipId;

		// Token: 0x0401FBE0 RID: 130016
		[Token(Token = "0x401FBE0")]
		[FieldOffset(Offset = "0x38")]
		public string cacheTmplId;

		// Token: 0x0401FBE1 RID: 130017
		[Token(Token = "0x401FBE1")]
		[FieldOffset(Offset = "0x40")]
		public bool isFocused;

		// Token: 0x0401FBE2 RID: 130018
		[Token(Token = "0x401FBE2")]
		[FieldOffset(Offset = "0x44")]
		public int selectIndex;

		// Token: 0x0401FBE3 RID: 130019
		[Token(Token = "0x401FBE3")]
		[FieldOffset(Offset = "0x48")]
		public int expedtionRemainTime;

		// Token: 0x0401FBE4 RID: 130020
		[Token(Token = "0x401FBE4")]
		[FieldOffset(Offset = "0x4C")]
		public bool showIndex;

		// Token: 0x0401FBE5 RID: 130021
		[Token(Token = "0x401FBE5")]
		[FieldOffset(Offset = "0x50")]
		public int logisticsBeanCount;

		// Token: 0x0401FBE7 RID: 130023
		[Token(Token = "0x401FBE7")]
		[FieldOffset(Offset = "0x68")]
		public SandboxV2CharFoodModel foodGroupViewModel;

		// Token: 0x0401FBE8 RID: 130024
		[Token(Token = "0x401FBE8")]
		[FieldOffset(Offset = "0x70")]
		public CharSelectSkillGroupViewModel skillGroupViewModel;

		// Token: 0x0401FBE9 RID: 130025
		[Token(Token = "0x401FBE9")]
		[FieldOffset(Offset = "0x78")]
		public CharSelectBranchGroupViewModel branchGroupViewModel;

		// Token: 0x0401FBEA RID: 130026
		[Token(Token = "0x401FBEA")]
		[FieldOffset(Offset = "0x80")]
		public AttackRangeDescModel attackRange;

		// Token: 0x0401FBEB RID: 130027
		[Token(Token = "0x401FBEB")]
		[FieldOffset(Offset = "0x90")]
		public SandboxV2CharStatus charStatus;

		// Token: 0x0401FBEC RID: 130028
		[Token(Token = "0x401FBEC")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_rarityColor;

		// Token: 0x0401FBED RID: 130029
		[Token(Token = "0x401FBED")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_rarityColor;

		// Token: 0x0401FBEE RID: 130030
		[Token(Token = "0x401FBEE")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_basicCharInfo;

		// Token: 0x0401FBEF RID: 130031
		[Token(Token = "0x401FBEF")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_get_currentEquipId;

		// Token: 0x0401FBF0 RID: 130032
		[Token(Token = "0x401FBF0")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_ApplyCharSelect;

		// Token: 0x0401FBF1 RID: 130033
		[Token(Token = "0x401FBF1")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_ApplySkillSelect;

		// Token: 0x0401FBF2 RID: 130034
		[Token(Token = "0x401FBF2")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_ApplyEquipId;

		// Token: 0x0401FBF3 RID: 130035
		[Token(Token = "0x401FBF3")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x0401FBF4 RID: 130036
		[Token(Token = "0x401FBF4")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_InitSelectPartIfNot;

		// Token: 0x0401FBF5 RID: 130037
		[Token(Token = "0x401FBF5")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_UpdatePlayerData;

		// Token: 0x0401FBF6 RID: 130038
		[Token(Token = "0x401FBF6")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0__UpdatePlayerData;

		// Token: 0x0401FBF7 RID: 130039
		[Token(Token = "0x401FBF7")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0__UpdateFoodModel;

		// Token: 0x0401FBF8 RID: 130040
		[Token(Token = "0x401FBF8")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0__InitLogisticsRelatedData;

		// Token: 0x0401FBF9 RID: 130041
		[Token(Token = "0x401FBF9")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0_CompareTo;
	}
}

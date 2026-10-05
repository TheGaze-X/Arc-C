using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.SandboxPerm.SandboxV2
{
	// Token: 0x020042B6 RID: 17078
	[Token(Token = "0x20042B6")]
	public class SandboxV2DungeonNodeUpgradeViewModel : IHotfixable
	{
		// Token: 0x17003E5D RID: 15965
		// (get) Token: 0x0601A483 RID: 107651 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17003E5D")]
		public string topicId
		{
			[Token(Token = "0x601A483")]
			[Address(RVA = "0x13361C0", Offset = "0x1334DC0", VA = "0x1813361C0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17003E5E RID: 15966
		// (get) Token: 0x0601A484 RID: 107652 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17003E5E")]
		public List<SandboxV2DungeonNodeUpgradeItemViewModel> items
		{
			[Token(Token = "0x601A484")]
			[Address(RVA = "0x1336160", Offset = "0x1334D60", VA = "0x181336160")]
			get
			{
				return null;
			}
		}

		// Token: 0x0601A485 RID: 107653 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A485")]
		[Address(RVA = "0x13355A0", Offset = "0x13341A0", VA = "0x1813355A0")]
		public void LoadData(string topicId, Dictionary<string, int> upgrades, List<string> completedUpgrades)
		{
		}

		// Token: 0x0601A486 RID: 107654 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A486")]
		[Address(RVA = "0x1335AF0", Offset = "0x13346F0", VA = "0x181335AF0")]
		public void RefreshPlayerData()
		{
		}

		// Token: 0x0601A487 RID: 107655 RVA: 0x000A0AE8 File Offset: 0x0009ECE8
		[Token(Token = "0x601A487")]
		[Address(RVA = "0x1335E30", Offset = "0x1334A30", VA = "0x181335E30")]
		private static int _SearchItemInBackpack(SandboxV2Data gameData, PlayerSandboxV2 playerData, SandboxPermItemType itemType, SandboxV2ItemTrapTag itemTag, int rarity)
		{
			return 0;
		}

		// Token: 0x0601A488 RID: 107656 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A488")]
		[Address(RVA = "0x13360B0", Offset = "0x1334CB0", VA = "0x1813360B0")]
		public SandboxV2DungeonNodeUpgradeViewModel()
		{
		}

		// Token: 0x040214E0 RID: 136416
		[Token(Token = "0x40214E0")]
		[FieldOffset(Offset = "0x10")]
		private readonly List<SandboxV2DungeonNodeUpgradeItemViewModel> m_items;

		// Token: 0x040214E1 RID: 136417
		[Token(Token = "0x40214E1")]
		[FieldOffset(Offset = "0x18")]
		private string m_topicId;

		// Token: 0x040214E2 RID: 136418
		[Token(Token = "0x40214E2")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_topicId;

		// Token: 0x040214E3 RID: 136419
		[Token(Token = "0x40214E3")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_items;

		// Token: 0x040214E4 RID: 136420
		[Token(Token = "0x40214E4")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_LoadData;

		// Token: 0x040214E5 RID: 136421
		[Token(Token = "0x40214E5")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_RefreshPlayerData;

		// Token: 0x040214E6 RID: 136422
		[Token(Token = "0x40214E6")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__SearchItemInBackpack;

		// Token: 0x040214E7 RID: 136423
		[Token(Token = "0x40214E7")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}

using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.Campaign
{
	// Token: 0x0200614E RID: 24910
	[Token(Token = "0x200614E")]
	public class CampaignZoneMapZoneViewModel : IHotfixable
	{
		// Token: 0x06023F6B RID: 147307 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023F6B")]
		[Address(RVA = "0x1EAF060", Offset = "0x1EADC60", VA = "0x181EAF060")]
		public void LoadData(string id, [Optional] Dictionary<string, long> endTsDict)
		{
		}

		// Token: 0x06023F6C RID: 147308 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023F6C")]
		[Address(RVA = "0x1EAF4D0", Offset = "0x1EAE0D0", VA = "0x181EAF4D0")]
		public void RefreshPlayerData()
		{
		}

		// Token: 0x06023F6D RID: 147309 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023F6D")]
		[Address(RVA = "0x1EAF5A0", Offset = "0x1EAE1A0", VA = "0x181EAF5A0")]
		public CampaignZoneMapZoneViewModel()
		{
		}

		// Token: 0x04031F07 RID: 204551
		[Token(Token = "0x4031F07")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public string zoneId;

		// Token: 0x04031F08 RID: 204552
		[Token(Token = "0x4031F08")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public string zoneName;

		// Token: 0x04031F09 RID: 204553
		[Token(Token = "0x4031F09")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Dictionary<string, CampaignZoneMapStageViewModel> stageDict;

		// Token: 0x04031F0A RID: 204554
		[Token(Token = "0x4031F0A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public List<CampaignZoneMapStageViewModel> stageList;

		// Token: 0x04031F0B RID: 204555
		[Token(Token = "0x4031F0B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_LoadData;

		// Token: 0x04031F0C RID: 204556
		[Token(Token = "0x4031F0C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_RefreshPlayerData;

		// Token: 0x04031F0D RID: 204557
		[Token(Token = "0x4031F0D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}

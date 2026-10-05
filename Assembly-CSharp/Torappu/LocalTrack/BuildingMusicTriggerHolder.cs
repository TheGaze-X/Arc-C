using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using XLua;

namespace Torappu.LocalTrack
{
	// Token: 0x0200207E RID: 8318
	[Token(Token = "0x200207E")]
	public class BuildingMusicTriggerHolder : PlayerTrackTriggerHolder<BuildingMusicTrigger>
	{
		// Token: 0x0600CD2C RID: 52524 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600CD2C")]
		[Address(RVA = "0x34FB710", Offset = "0x34FA310", VA = "0x1834FB710", Slot = "9")]
		protected override IList<string> CreatePlayerDataPathList()
		{
			return null;
		}

		// Token: 0x0600CD2D RID: 52525 RVA: 0x00049F38 File Offset: 0x00048138
		[Token(Token = "0x600CD2D")]
		[Address(RVA = "0x34FB610", Offset = "0x34FA210", VA = "0x1834FB610", Slot = "10")]
		protected override bool CheckIfToTrigger(BuildingMusicTrigger trigger, PlayerDataModel prevData, PlayerDataModel curData)
		{
			return default(bool);
		}

		// Token: 0x0600CD2E RID: 52526 RVA: 0x00049F50 File Offset: 0x00048150
		[Token(Token = "0x600CD2E")]
		[Address(RVA = "0x34FB820", Offset = "0x34FA420", VA = "0x1834FB820")]
		private bool _CheckMusicUnlocked(string bgmId, PlayerDataModel data)
		{
			return default(bool);
		}

		// Token: 0x0600CD2F RID: 52527 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CD2F")]
		[Address(RVA = "0x34FB920", Offset = "0x34FA520", VA = "0x1834FB920")]
		public BuildingMusicTriggerHolder()
		{
		}

		// Token: 0x0400D86D RID: 55405
		[Token(Token = "0x400D86D")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_CreatePlayerDataPathList;

		// Token: 0x0400D86E RID: 55406
		[Token(Token = "0x400D86E")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_CheckIfToTrigger;

		// Token: 0x0400D86F RID: 55407
		[Token(Token = "0x400D86F")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__CheckMusicUnlocked;

		// Token: 0x0400D870 RID: 55408
		[Token(Token = "0x400D870")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}

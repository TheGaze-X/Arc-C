using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.Stage
{
	// Token: 0x0200679B RID: 26523
	[Token(Token = "0x200679B")]
	public class StageZoneWeeklyRewardViewModel : IHotfixable
	{
		// Token: 0x060260A7 RID: 155815 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60260A7")]
		[Address(RVA = "0x2126AB0", Offset = "0x21256B0", VA = "0x182126AB0")]
		public void LoadData()
		{
		}

		// Token: 0x060260A8 RID: 155816 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60260A8")]
		[Address(RVA = "0x2126B30", Offset = "0x2125730", VA = "0x182126B30")]
		public StageZoneWeeklyRewardViewModel()
		{
		}

		// Token: 0x0403586B RID: 219243
		[Token(Token = "0x403586B")]
		[FieldOffset(Offset = "0x10")]
		public StageZoneCampaignViewModel campaignViewModel;

		// Token: 0x0403586C RID: 219244
		[Token(Token = "0x403586C")]
		[FieldOffset(Offset = "0x18")]
		public StageZoneClimbTowerViewModel climbTowerViewModel;

		// Token: 0x0403586D RID: 219245
		[Token(Token = "0x403586D")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_LoadData;

		// Token: 0x0403586E RID: 219246
		[Token(Token = "0x403586E")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}

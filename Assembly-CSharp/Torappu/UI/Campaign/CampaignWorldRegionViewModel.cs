using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.Campaign
{
	// Token: 0x02006102 RID: 24834
	[Token(Token = "0x2006102")]
	public class CampaignWorldRegionViewModel : IHotfixable
	{
		// Token: 0x06023E4B RID: 147019 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023E4B")]
		[Address(RVA = "0x1E8D7F0", Offset = "0x1E8C3F0", VA = "0x181E8D7F0")]
		public void LoadData(string regionId, CampaignWorldViewModel context)
		{
		}

		// Token: 0x06023E4C RID: 147020 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023E4C")]
		[Address(RVA = "0x1E8DBE0", Offset = "0x1E8C7E0", VA = "0x181E8DBE0")]
		public CampaignWorldRegionViewModel()
		{
		}

		// Token: 0x04031CCD RID: 203981
		[Token(Token = "0x4031CCD")]
		[FieldOffset(Offset = "0x10")]
		public string id;

		// Token: 0x04031CCE RID: 203982
		[Token(Token = "0x4031CCE")]
		[FieldOffset(Offset = "0x18")]
		public bool isUnknown;

		// Token: 0x04031CCF RID: 203983
		[Token(Token = "0x4031CCF")]
		[FieldOffset(Offset = "0x19")]
		public bool isRotate;

		// Token: 0x04031CD0 RID: 203984
		[Token(Token = "0x4031CD0")]
		[FieldOffset(Offset = "0x1A")]
		public bool isFirstTimeDetected;

		// Token: 0x04031CD1 RID: 203985
		[Token(Token = "0x4031CD1")]
		[FieldOffset(Offset = "0x1B")]
		public bool isShowFog;

		// Token: 0x04031CD2 RID: 203986
		[Token(Token = "0x4031CD2")]
		[FieldOffset(Offset = "0x20")]
		public List<CampaignWorldZoneViewModel> zoneModels;

		// Token: 0x04031CD3 RID: 203987
		[Token(Token = "0x4031CD3")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_LoadData;

		// Token: 0x04031CD4 RID: 203988
		[Token(Token = "0x4031CD4")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}

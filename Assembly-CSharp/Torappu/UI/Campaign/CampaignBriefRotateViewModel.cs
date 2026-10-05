using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.Campaign
{
	// Token: 0x020060C8 RID: 24776
	[Token(Token = "0x20060C8")]
	public class CampaignBriefRotateViewModel : IHotfixable
	{
		// Token: 0x17005499 RID: 21657
		// (get) Token: 0x06023D0D RID: 146701 RVA: 0x000C2220 File Offset: 0x000C0420
		[Token(Token = "0x17005499")]
		public bool isValid
		{
			[Token(Token = "0x6023D0D")]
			[Address(RVA = "0x1E6D660", Offset = "0x1E6C260", VA = "0x181E6D660")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06023D0E RID: 146702 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023D0E")]
		[Address(RVA = "0x1E6D330", Offset = "0x1E6BF30", VA = "0x181E6D330")]
		public void LoadData()
		{
		}

		// Token: 0x06023D0F RID: 146703 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023D0F")]
		[Address(RVA = "0x1E6D600", Offset = "0x1E6C200", VA = "0x181E6D600")]
		public CampaignBriefRotateViewModel()
		{
		}

		// Token: 0x04031AB0 RID: 203440
		[Token(Token = "0x4031AB0")]
		[FieldOffset(Offset = "0x10")]
		public string stageId;

		// Token: 0x04031AB1 RID: 203441
		[Token(Token = "0x4031AB1")]
		[FieldOffset(Offset = "0x18")]
		public string stageName;

		// Token: 0x04031AB2 RID: 203442
		[Token(Token = "0x4031AB2")]
		[FieldOffset(Offset = "0x20")]
		public string zoneName;

		// Token: 0x04031AB3 RID: 203443
		[Token(Token = "0x4031AB3")]
		[FieldOffset(Offset = "0x28")]
		public string remainTimeStr;

		// Token: 0x04031AB4 RID: 203444
		[Token(Token = "0x4031AB4")]
		[FieldOffset(Offset = "0x30")]
		public Sprite spriteZoneIcon;

		// Token: 0x04031AB5 RID: 203445
		[Token(Token = "0x4031AB5")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_isValid;

		// Token: 0x04031AB6 RID: 203446
		[Token(Token = "0x4031AB6")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_LoadData;

		// Token: 0x04031AB7 RID: 203447
		[Token(Token = "0x4031AB7")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}

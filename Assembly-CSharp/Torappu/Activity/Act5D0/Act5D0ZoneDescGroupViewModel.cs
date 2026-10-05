using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.UI.ActivityStage.Extern;

namespace Torappu.Activity.Act5D0
{
	// Token: 0x02007202 RID: 29186
	[Token(Token = "0x2007202")]
	public class Act5D0ZoneDescGroupViewModel
	{
		// Token: 0x06029639 RID: 169529 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029639")]
		[Address(RVA = "0x24C3AF0", Offset = "0x24C26F0", VA = "0x1824C3AF0")]
		public void LoadGameData(ActivityBasicInfo actBasicInfo, List<ActivityZoneViewModel> actZoneModels)
		{
		}

		// Token: 0x0602963A RID: 169530 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602963A")]
		[Address(RVA = "0x24C3E30", Offset = "0x24C2A30", VA = "0x1824C3E30")]
		public Act5D0ZoneDescGroupViewModel()
		{
		}

		// Token: 0x0403B1EF RID: 242159
		[Token(Token = "0x403B1EF")]
		[FieldOffset(Offset = "0x10")]
		public string selectedZoneId;

		// Token: 0x0403B1F0 RID: 242160
		[Token(Token = "0x403B1F0")]
		[FieldOffset(Offset = "0x18")]
		public List<Act5D0ZoneDescModel> zoneDescModels;
	}
}

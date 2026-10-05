using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.UI.ActivityStage.Extern;

namespace Torappu.Activity.Act3D0
{
	// Token: 0x02007429 RID: 29737
	[Token(Token = "0x2007429")]
	public class Act3D0ZoneDescGroupViewModel
	{
		// Token: 0x06029F95 RID: 171925 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029F95")]
		[Address(RVA = "0x2591840", Offset = "0x2590440", VA = "0x182591840")]
		public void LoadGameData(ActivityBasicInfo actBasicInfo, List<ActivityZoneViewModel> actZoneModels)
		{
		}

		// Token: 0x06029F96 RID: 171926 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029F96")]
		[Address(RVA = "0x2591B80", Offset = "0x2590780", VA = "0x182591B80")]
		public Act3D0ZoneDescGroupViewModel()
		{
		}

		// Token: 0x0403C2E4 RID: 246500
		[Token(Token = "0x403C2E4")]
		[FieldOffset(Offset = "0x10")]
		public string selectedZoneId;

		// Token: 0x0403C2E5 RID: 246501
		[Token(Token = "0x403C2E5")]
		[FieldOffset(Offset = "0x18")]
		public List<Act3D0ZoneDescModel> zoneDescModels;
	}
}

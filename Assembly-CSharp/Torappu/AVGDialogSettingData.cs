using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x02000FE8 RID: 4072
	[Token(Token = "0x2000FE8")]
	public class AVGDialogSettingData
	{
		// Token: 0x06006D3F RID: 27967 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006D3F")]
		[Address(RVA = "0x20FE2C0", Offset = "0x20FCEC0", VA = "0x1820FE2C0")]
		public AVGDialogSettingData()
		{
		}

		// Token: 0x04005651 RID: 22097
		[Token(Token = "0x4005651")]
		[FieldOffset(Offset = "0x10")]
		public int defaultPresetId;

		// Token: 0x04005652 RID: 22098
		[Token(Token = "0x4005652")]
		[FieldOffset(Offset = "0x18")]
		public List<AVGDialogPresetData> presetList;
	}
}

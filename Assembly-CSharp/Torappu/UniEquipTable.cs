using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x020013AF RID: 5039
	[Token(Token = "0x20013AF")]
	public class UniEquipTable
	{
		// Token: 0x0600739B RID: 29595 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600739B")]
		[Address(RVA = "0x22161A0", Offset = "0x2214DA0", VA = "0x1822161A0")]
		public UniEquipTable()
		{
		}

		// Token: 0x04006FFD RID: 28669
		[Token(Token = "0x4006FFD")]
		[FieldOffset(Offset = "0x10")]
		public Dictionary<string, UniEquipData> equipDict;

		// Token: 0x04006FFE RID: 28670
		[Token(Token = "0x4006FFE")]
		[FieldOffset(Offset = "0x18")]
		public Dictionary<string, UniEquipMissionData> missionList;

		// Token: 0x04006FFF RID: 28671
		[Token(Token = "0x4006FFF")]
		[FieldOffset(Offset = "0x20")]
		public Dictionary<string, SubProfessionData> subProfDict;

		// Token: 0x04007000 RID: 28672
		[Token(Token = "0x4007000")]
		[FieldOffset(Offset = "0x28")]
		public Dictionary<string, int> subProfToProfDict;

		// Token: 0x04007001 RID: 28673
		[Token(Token = "0x4007001")]
		[FieldOffset(Offset = "0x30")]
		public Dictionary<string, List<string>> charEquip;

		// Token: 0x04007002 RID: 28674
		[Token(Token = "0x4007002")]
		[FieldOffset(Offset = "0x38")]
		public List<UniEquipTypeInfo> equipTypeInfos;

		// Token: 0x04007003 RID: 28675
		[Token(Token = "0x4007003")]
		[FieldOffset(Offset = "0x40")]
		public List<UniEquipTimeInfo> equipTrackDict;
	}
}

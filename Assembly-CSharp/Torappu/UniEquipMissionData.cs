using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x020013B6 RID: 5046
	[Token(Token = "0x20013B6")]
	public class UniEquipMissionData
	{
		// Token: 0x060073A3 RID: 29603 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60073A3")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public UniEquipMissionData()
		{
		}

		// Token: 0x0400702E RID: 28718
		[Token(Token = "0x400702E")]
		[FieldOffset(Offset = "0x10")]
		public string template;

		// Token: 0x0400702F RID: 28719
		[Token(Token = "0x400702F")]
		[FieldOffset(Offset = "0x18")]
		public string desc;

		// Token: 0x04007030 RID: 28720
		[Token(Token = "0x4007030")]
		[FieldOffset(Offset = "0x20")]
		public List<string> paramList;

		// Token: 0x04007031 RID: 28721
		[Token(Token = "0x4007031")]
		[FieldOffset(Offset = "0x28")]
		public string uniEquipMissionId;

		// Token: 0x04007032 RID: 28722
		[Token(Token = "0x4007032")]
		[FieldOffset(Offset = "0x30")]
		public int uniEquipMissionSort;

		// Token: 0x04007033 RID: 28723
		[Token(Token = "0x4007033")]
		[FieldOffset(Offset = "0x38")]
		public string uniEquipId;

		// Token: 0x04007034 RID: 28724
		[Token(Token = "0x4007034")]
		[FieldOffset(Offset = "0x40")]
		public string jumpStageId;
	}
}

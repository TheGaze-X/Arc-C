using System;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x02000E7A RID: 3706
	[Token(Token = "0x2000E7A")]
	public class DynEntrySwitchInfo : IComparable
	{
		// Token: 0x06006B44 RID: 27460 RVA: 0x00031278 File Offset: 0x0002F478
		[Token(Token = "0x6006B44")]
		[Address(RVA = "0x20098A0", Offset = "0x20084A0", VA = "0x1820098A0", Slot = "4")]
		public int CompareTo(object obj)
		{
			return 0;
		}

		// Token: 0x06006B45 RID: 27461 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006B45")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public DynEntrySwitchInfo()
		{
		}

		// Token: 0x04004E0D RID: 19981
		[Token(Token = "0x4004E0D")]
		[FieldOffset(Offset = "0x10")]
		public string entryId;

		// Token: 0x04004E0E RID: 19982
		[Token(Token = "0x4004E0E")]
		[FieldOffset(Offset = "0x18")]
		public int sortId;

		// Token: 0x04004E0F RID: 19983
		[Token(Token = "0x4004E0F")]
		[FieldOffset(Offset = "0x20")]
		public string stageId;

		// Token: 0x04004E10 RID: 19984
		[Token(Token = "0x4004E10")]
		[FieldOffset(Offset = "0x28")]
		public string signalId;
	}
}

using System;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x020013CB RID: 5067
	[Token(Token = "0x20013CB")]
	[Serializable]
	public class RecordRewardServerData
	{
		// Token: 0x060073BB RID: 29627 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60073BB")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public RecordRewardServerData()
		{
		}

		// Token: 0x040070B3 RID: 28851
		[Token(Token = "0x40070B3")]
		[FieldOffset(Offset = "0x10")]
		public string stageId;

		// Token: 0x040070B4 RID: 28852
		[Token(Token = "0x40070B4")]
		[FieldOffset(Offset = "0x18")]
		public ItemBundle[] rewards;
	}
}

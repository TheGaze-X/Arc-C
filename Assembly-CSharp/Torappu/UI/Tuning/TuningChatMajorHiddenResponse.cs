using System;
using Il2CppDummyDll;

namespace Torappu.UI.Tuning
{
	// Token: 0x02003D0E RID: 15630
	[Token(Token = "0x2003D0E")]
	public class TuningChatMajorHiddenResponse : TuningChatCommitResponse
	{
		// Token: 0x060185F4 RID: 99828 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60185F4")]
		[Address(RVA = "0x1022FA0", Offset = "0x1021BA0", VA = "0x181022FA0")]
		public TuningChatMajorHiddenResponse()
		{
		}

		// Token: 0x0401DCDE RID: 122078
		[Token(Token = "0x401DCDE")]
		[FieldOffset(Offset = "0x40")]
		public int tryTimes;

		// Token: 0x0401DCDF RID: 122079
		[Token(Token = "0x401DCDF")]
		[FieldOffset(Offset = "0x48")]
		public string answer;

		// Token: 0x0401DCE0 RID: 122080
		[Token(Token = "0x401DCE0")]
		[FieldOffset(Offset = "0x50")]
		public bool openRare;
	}
}

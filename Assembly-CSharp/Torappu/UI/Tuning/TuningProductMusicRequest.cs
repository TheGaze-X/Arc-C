using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu.UI.Tuning
{
	// Token: 0x02003D12 RID: 15634
	[Token(Token = "0x2003D12")]
	public class TuningProductMusicRequest
	{
		// Token: 0x060185F8 RID: 99832 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60185F8")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public TuningProductMusicRequest()
		{
		}

		// Token: 0x0401DCE5 RID: 122085
		[Token(Token = "0x401DCE5")]
		[FieldOffset(Offset = "0x10")]
		public string actId;

		// Token: 0x0401DCE6 RID: 122086
		[Token(Token = "0x401DCE6")]
		[FieldOffset(Offset = "0x18")]
		public List<string> fragments;

		// Token: 0x0401DCE7 RID: 122087
		[Token(Token = "0x401DCE7")]
		[FieldOffset(Offset = "0x20")]
		public string orcheId;
	}
}

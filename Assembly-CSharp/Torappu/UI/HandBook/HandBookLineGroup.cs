using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu.UI.HandBook
{
	// Token: 0x020066BF RID: 26303
	[Token(Token = "0x20066BF")]
	public class HandBookLineGroup
	{
		// Token: 0x06025C5B RID: 154715 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025C5B")]
		[Address(RVA = "0x20BD740", Offset = "0x20BC340", VA = "0x1820BD740")]
		public void InitData(Dictionary<int, HandBookLineViewModel> lineDB)
		{
		}

		// Token: 0x06025C5C RID: 154716 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6025C5C")]
		[Address(RVA = "0x20BD5B0", Offset = "0x20BC1B0", VA = "0x1820BD5B0")]
		public List<string> GetConnected(string charID)
		{
			return null;
		}

		// Token: 0x06025C5D RID: 154717 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025C5D")]
		[Address(RVA = "0x20BDA70", Offset = "0x20BC670", VA = "0x1820BDA70")]
		public HandBookLineGroup()
		{
		}

		// Token: 0x040351A0 RID: 217504
		[Token(Token = "0x40351A0")]
		[FieldOffset(Offset = "0x10")]
		private ListDict<int, HandBookLineViewModel> m_lines;

		// Token: 0x040351A1 RID: 217505
		[Token(Token = "0x40351A1")]
		[FieldOffset(Offset = "0x18")]
		private Dictionary<string, int> m_cardID;
	}
}

using System;
using Il2CppDummyDll;

namespace Torappu.UI
{
	// Token: 0x020036B1 RID: 14001
	[Token(Token = "0x20036B1")]
	[Serializable]
	public class PredefinedAssistData
	{
		// Token: 0x06016410 RID: 91152 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6016410")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public PredefinedAssistData()
		{
		}

		// Token: 0x0401AC30 RID: 109616
		[Token(Token = "0x401AC30")]
		[FieldOffset(Offset = "0x10")]
		public CharQuery charQuery;

		// Token: 0x0401AC31 RID: 109617
		[Token(Token = "0x401AC31")]
		[FieldOffset(Offset = "0x28")]
		public int skillSelectIndex;
	}
}

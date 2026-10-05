using System;
using Il2CppDummyDll;

namespace Torappu.Activity.ActMultiV3
{
	// Token: 0x02006EB0 RID: 28336
	[Token(Token = "0x2006EB0")]
	public class ActMultiV3BattleOutMeta
	{
		// Token: 0x06028507 RID: 165127 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028507")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public ActMultiV3BattleOutMeta()
		{
		}

		// Token: 0x040394AE RID: 234670
		[Token(Token = "0x40394AE")]
		[FieldOffset(Offset = "0x10")]
		public long endTs;

		// Token: 0x040394AF RID: 234671
		[Token(Token = "0x40394AF")]
		[FieldOffset(Offset = "0x18")]
		public BattleFinishRspData data;
	}
}

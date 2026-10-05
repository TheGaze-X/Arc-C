using System;
using Il2CppDummyDll;

namespace Torappu.UI
{
	// Token: 0x02003B6A RID: 15210
	[Token(Token = "0x2003B6A")]
	public class SquadSceneParam : ISceneParam
	{
		// Token: 0x06017DBB RID: 97723 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017DBB")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public SquadSceneParam()
		{
		}

		// Token: 0x0401CD30 RID: 118064
		[Token(Token = "0x401CD30")]
		[FieldOffset(Offset = "0x10")]
		public ISceneParam backParam;

		// Token: 0x0401CD31 RID: 118065
		[Token(Token = "0x401CD31")]
		[FieldOffset(Offset = "0x18")]
		public string stageId;

		// Token: 0x0401CD32 RID: 118066
		[Token(Token = "0x401CD32")]
		[FieldOffset(Offset = "0x20")]
		public bool isPractice;
	}
}

using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.EnemyHandBook
{
	// Token: 0x02004F31 RID: 20273
	[Token(Token = "0x2004F31")]
	public class EnemyHandBookPage : StateEnginePage
	{
		// Token: 0x0601E32B RID: 123691 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E32B")]
		[Address(RVA = "0x17E9B70", Offset = "0x17E8770", VA = "0x1817E9B70")]
		public EnemyHandBookPage()
		{
		}

		// Token: 0x040283DD RID: 164829
		[Token(Token = "0x40283DD")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02004F32 RID: 20274
		[Token(Token = "0x2004F32")]
		public class Param
		{
			// Token: 0x0601E32C RID: 123692 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601E32C")]
			[Address(RVA = "0x17F4B80", Offset = "0x17F3780", VA = "0x1817F4B80")]
			public Param()
			{
			}

			// Token: 0x040283DE RID: 164830
			[Token(Token = "0x40283DE")]
			[FieldOffset(Offset = "0x10")]
			public List<EnemyHandBookEverViewModel> enemyList;

			// Token: 0x040283DF RID: 164831
			[Token(Token = "0x40283DF")]
			[FieldOffset(Offset = "0x18")]
			public bool disableNewFlag;

			// Token: 0x040283E0 RID: 164832
			[Token(Token = "0x40283E0")]
			[FieldOffset(Offset = "0x19")]
			public bool needShuffleHide;
		}
	}
}

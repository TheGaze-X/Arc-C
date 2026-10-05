using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.Building
{
	// Token: 0x020017FF RID: 6143
	[Token(Token = "0x20017FF")]
	public class BuildingVisitorModel : IHotfixable
	{
		// Token: 0x06009B69 RID: 39785 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009B69")]
		[Address(RVA = "0x315EE80", Offset = "0x315DA80", VA = "0x18315EE80")]
		public BuildingVisitorModel()
		{
		}

		// Token: 0x040091EC RID: 37356
		[Token(Token = "0x40091EC")]
		[FieldOffset(Offset = "0x10")]
		public string uid;

		// Token: 0x040091ED RID: 37357
		[Token(Token = "0x40091ED")]
		[FieldOffset(Offset = "0x18")]
		public string nickName;

		// Token: 0x040091EE RID: 37358
		[Token(Token = "0x40091EE")]
		[FieldOffset(Offset = "0x20")]
		public string charId;

		// Token: 0x040091EF RID: 37359
		[Token(Token = "0x40091EF")]
		[FieldOffset(Offset = "0x28")]
		public string skinId;

		// Token: 0x040091F0 RID: 37360
		[Token(Token = "0x40091F0")]
		[FieldOffset(Offset = "0x30")]
		public int level;

		// Token: 0x040091F1 RID: 37361
		[Token(Token = "0x40091F1")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}

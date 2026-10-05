using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.Activity.Act7fun
{
	// Token: 0x0200719B RID: 29083
	[Token(Token = "0x200719B")]
	public class Act7FunSpineDisplayItemModel : IHotfixable
	{
		// Token: 0x06029442 RID: 169026 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029442")]
		[Address(RVA = "0x24BD850", Offset = "0x24BC450", VA = "0x1824BD850")]
		public Act7FunSpineDisplayItemModel()
		{
		}

		// Token: 0x0403AEF8 RID: 241400
		[Token(Token = "0x403AEF8")]
		[FieldOffset(Offset = "0x10")]
		public int holderId;

		// Token: 0x0403AEF9 RID: 241401
		[Token(Token = "0x403AEF9")]
		[FieldOffset(Offset = "0x14")]
		public bool isLeft;

		// Token: 0x0403AEFA RID: 241402
		[Token(Token = "0x403AEFA")]
		[FieldOffset(Offset = "0x18")]
		public string charId;

		// Token: 0x0403AEFB RID: 241403
		[Token(Token = "0x403AEFB")]
		[FieldOffset(Offset = "0x20")]
		public string animId;

		// Token: 0x0403AEFC RID: 241404
		[Token(Token = "0x403AEFC")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}

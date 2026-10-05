using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.Activity.Act12D6
{
	// Token: 0x02007AF3 RID: 31475
	[Token(Token = "0x2007AF3")]
	public class BuffObjViewHolder : IHotfixable
	{
		// Token: 0x0602C139 RID: 180537 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602C139")]
		[Address(RVA = "0x2801100", Offset = "0x27FFD00", VA = "0x182801100")]
		public BuffObjViewHolder()
		{
		}

		// Token: 0x0403FDEE RID: 261614
		[Token(Token = "0x403FDEE")]
		[FieldOffset(Offset = "0x10")]
		public Act12D6OuterBuffItemView view;

		// Token: 0x0403FDEF RID: 261615
		[Token(Token = "0x403FDEF")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}

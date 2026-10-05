using System;
using Il2CppDummyDll;

namespace Torappu.Activity.Act1Lock
{
	// Token: 0x02007859 RID: 30809
	[Token(Token = "0x2007859")]
	public class StageKeyDropData
	{
		// Token: 0x0602B324 RID: 176932 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B324")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public StageKeyDropData()
		{
		}

		// Token: 0x0403E742 RID: 255810
		[Token(Token = "0x403E742")]
		[FieldOffset(Offset = "0x10")]
		public string stageKey;

		// Token: 0x0403E743 RID: 255811
		[Token(Token = "0x403E743")]
		[FieldOffset(Offset = "0x18")]
		public int count;
	}
}

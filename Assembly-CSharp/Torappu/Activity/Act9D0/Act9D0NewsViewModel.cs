using System;
using Il2CppDummyDll;

namespace Torappu.Activity.Act9D0
{
	// Token: 0x02007187 RID: 29063
	[Token(Token = "0x2007187")]
	public class Act9D0NewsViewModel : Act9D0Data.ActivityNewsInfo
	{
		// Token: 0x170061A5 RID: 24997
		// (get) Token: 0x0602940D RID: 168973 RVA: 0x000D4E20 File Offset: 0x000D3020
		[Token(Token = "0x170061A5")]
		public bool unread
		{
			[Token(Token = "0x602940D")]
			[Address(RVA = "0x24A0CE0", Offset = "0x249F8E0", VA = "0x1824A0CE0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x0602940E RID: 168974 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602940E")]
		[Address(RVA = "0x4E9D30", Offset = "0x4E8930", VA = "0x1804E9D30")]
		public Act9D0NewsViewModel()
		{
		}

		// Token: 0x0403AEB7 RID: 241335
		[Token(Token = "0x403AEB7")]
		[FieldOffset(Offset = "0x70")]
		public long readTs;
	}
}

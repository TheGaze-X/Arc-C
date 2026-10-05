using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace Torappu.Battle.Douququ
{
	// Token: 0x02002A48 RID: 10824
	[Token(Token = "0x2002A48")]
	public class Act5FunNpcWithWeight : IItemWithWeight
	{
		// Token: 0x17002785 RID: 10117
		// (get) Token: 0x06011F96 RID: 73622 RVA: 0x0006DED8 File Offset: 0x0006C0D8
		// (set) Token: 0x06011F97 RID: 73623 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17002785")]
		public float weightValue
		{
			[Token(Token = "0x6011F96")]
			[Address(RVA = "0x5B4650", Offset = "0x5B3250", VA = "0x1805B4650", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6011F97")]
			[Address(RVA = "0x5B4660", Offset = "0x5B3260", VA = "0x1805B4660")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x06011F98 RID: 73624 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011F98")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public Act5FunNpcWithWeight()
		{
		}

		// Token: 0x040144A8 RID: 83112
		[Token(Token = "0x40144A8")]
		[FieldOffset(Offset = "0x10")]
		public string npcId;
	}
}

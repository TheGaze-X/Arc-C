using System;
using Il2CppDummyDll;

namespace Torappu.UI.Stage
{
	// Token: 0x020069F8 RID: 27128
	[Token(Token = "0x20069F8")]
	public class ZoneOpenDetailState
	{
		// Token: 0x17005B90 RID: 23440
		// (get) Token: 0x06026CB0 RID: 158896 RVA: 0x000CC600 File Offset: 0x000CA800
		[Token(Token = "0x17005B90")]
		public bool isOpen
		{
			[Token(Token = "0x6026CB0")]
			[Address(RVA = "0x21DB650", Offset = "0x21DA250", VA = "0x1821DB650")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17005B91 RID: 23441
		// (get) Token: 0x06026CB1 RID: 158897 RVA: 0x000CC618 File Offset: 0x000CA818
		[Token(Token = "0x17005B91")]
		public bool willOpenToday
		{
			[Token(Token = "0x6026CB1")]
			[Address(RVA = "0x21DB6D0", Offset = "0x21DA2D0", VA = "0x1821DB6D0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17005B92 RID: 23442
		// (get) Token: 0x06026CB2 RID: 158898 RVA: 0x000CC630 File Offset: 0x000CA830
		[Token(Token = "0x17005B92")]
		public bool isForcedOpen
		{
			[Token(Token = "0x6026CB2")]
			[Address(RVA = "0x21DB5E0", Offset = "0x21DA1E0", VA = "0x1821DB5E0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06026CB3 RID: 158899 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026CB3")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public ZoneOpenDetailState()
		{
		}

		// Token: 0x04036CE4 RID: 224484
		[Token(Token = "0x4036CE4")]
		[FieldOffset(Offset = "0x10")]
		public ZoneOpenState openState;

		// Token: 0x04036CE5 RID: 224485
		[Token(Token = "0x4036CE5")]
		[FieldOffset(Offset = "0x18")]
		public long openTimeStamp;

		// Token: 0x04036CE6 RID: 224486
		[Token(Token = "0x4036CE6")]
		[FieldOffset(Offset = "0x20")]
		public long closeTimeStamp;
	}
}

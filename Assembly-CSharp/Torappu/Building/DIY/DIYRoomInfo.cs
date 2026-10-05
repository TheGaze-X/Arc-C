using System;
using Il2CppDummyDll;

namespace Torappu.Building.DIY
{
	// Token: 0x0200188D RID: 6285
	[Token(Token = "0x200188D")]
	public class DIYRoomInfo
	{
		// Token: 0x170011E2 RID: 4578
		// (get) Token: 0x06009EF2 RID: 40690 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170011E2")]
		public IDIYRoomTemplate data
		{
			[Token(Token = "0x6009EF2")]
			[Address(RVA = "0x4EC5A0", Offset = "0x4EB1A0", VA = "0x1804EC5A0")]
			get
			{
				return null;
			}
		}

		// Token: 0x170011E3 RID: 4579
		// (get) Token: 0x06009EF3 RID: 40691 RVA: 0x0003DFF8 File Offset: 0x0003C1F8
		[Token(Token = "0x170011E3")]
		public int index
		{
			[Token(Token = "0x6009EF3")]
			[Address(RVA = "0x4EA860", Offset = "0x4E9460", VA = "0x1804EA860")]
			get
			{
				return 0;
			}
		}

		// Token: 0x06009EF4 RID: 40692 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009EF4")]
		[Address(RVA = "0x13D53A0", Offset = "0x13D3FA0", VA = "0x1813D53A0")]
		public DIYRoomInfo(IDIYRoomTemplate template, int index)
		{
		}

		// Token: 0x040095A3 RID: 38307
		[Token(Token = "0x40095A3")]
		[FieldOffset(Offset = "0x10")]
		private IDIYRoomTemplate m_data;

		// Token: 0x040095A4 RID: 38308
		[Token(Token = "0x40095A4")]
		[FieldOffset(Offset = "0x18")]
		private int m_index;
	}
}

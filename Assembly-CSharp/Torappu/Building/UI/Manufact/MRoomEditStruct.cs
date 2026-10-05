using System;
using Il2CppDummyDll;

namespace Torappu.Building.UI.Manufact
{
	// Token: 0x02001D90 RID: 7568
	[Token(Token = "0x2001D90")]
	public struct MRoomEditStruct
	{
		// Token: 0x170016A2 RID: 5794
		// (get) Token: 0x0600BAAD RID: 47789 RVA: 0x00045D50 File Offset: 0x00043F50
		[Token(Token = "0x170016A2")]
		public bool isEmpty
		{
			[Token(Token = "0x600BAAD")]
			[Address(RVA = "0xDF9A30", Offset = "0xDF8630", VA = "0x180DF9A30")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x0400B9F5 RID: 47605
		[Token(Token = "0x400B9F5")]
		[FieldOffset(Offset = "0x0")]
		public static MRoomEditStruct EMPTY;

		// Token: 0x0400B9F6 RID: 47606
		[Token(Token = "0x400B9F6")]
		[FieldOffset(Offset = "0x0")]
		private bool m_isEmpty;

		// Token: 0x0400B9F7 RID: 47607
		[Token(Token = "0x400B9F7")]
		[FieldOffset(Offset = "0x8")]
		public BuildingData.ManufactFormula formula;

		// Token: 0x0400B9F8 RID: 47608
		[Token(Token = "0x400B9F8")]
		[FieldOffset(Offset = "0x10")]
		public int itemCount;
	}
}

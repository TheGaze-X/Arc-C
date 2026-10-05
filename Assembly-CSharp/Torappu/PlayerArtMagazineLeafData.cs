using System;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x02000C0A RID: 3082
	[Token(Token = "0x2000C0A")]
	public class PlayerArtMagazineLeafData : ArtMagazineLeafData
	{
		// Token: 0x060068A0 RID: 26784 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60068A0")]
		[Address(RVA = "0x4E9D30", Offset = "0x4E8930", VA = "0x1804E9D30")]
		public PlayerArtMagazineLeafData()
		{
		}

		// Token: 0x04003EDA RID: 16090
		[Token(Token = "0x4003EDA")]
		[FieldOffset(Offset = "0x28")]
		public long getTs;

		// Token: 0x04003EDB RID: 16091
		[Token(Token = "0x4003EDB")]
		[FieldOffset(Offset = "0x30")]
		public int version;
	}
}

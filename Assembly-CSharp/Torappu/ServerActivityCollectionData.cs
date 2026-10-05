using System;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x02000DF7 RID: 3575
	[Token(Token = "0x2000DF7")]
	public class ServerActivityCollectionData : ActivityCollectionData
	{
		// Token: 0x06006ACA RID: 27338 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006ACA")]
		[Address(RVA = "0x200CD40", Offset = "0x200B940", VA = "0x18200CD40")]
		public ServerActivityCollectionData()
		{
		}

		// Token: 0x04004A20 RID: 18976
		[Token(Token = "0x4004A20")]
		[FieldOffset(Offset = "0x28")]
		public new ServerActivityCollectionData.Consts consts;

		// Token: 0x02000DF8 RID: 3576
		[Token(Token = "0x2000DF8")]
		public new class Consts : ActivityCollectionData.Consts
		{
			// Token: 0x06006ACB RID: 27339 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6006ACB")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public Consts()
			{
			}

			// Token: 0x04004A21 RID: 18977
			[Token(Token = "0x4004A21")]
			[FieldOffset(Offset = "0x40")]
			public int mailDuration;

			// Token: 0x04004A22 RID: 18978
			[Token(Token = "0x4004A22")]
			[FieldOffset(Offset = "0x44")]
			public int conversionVolume;

			// Token: 0x04004A23 RID: 18979
			[Token(Token = "0x4004A23")]
			[FieldOffset(Offset = "0x48")]
			public string pointId;
		}
	}
}

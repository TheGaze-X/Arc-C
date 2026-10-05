using System;
using Il2CppDummyDll;

namespace YoStar.SDK
{
	// Token: 0x0200004D RID: 77
	[Token(Token = "0x200004D")]
	public class SDKConfigJsonData
	{
		// Token: 0x17000039 RID: 57
		// (get) Token: 0x060001EC RID: 492 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060001ED RID: 493 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x17000039")]
		public string Version
		{
			[Token(Token = "0x60001EC")]
			[Address(RVA = "0x5BE20A0", Offset = "0x5BE0CA0", VA = "0x185BE20A0")]
			get
			{
				return null;
			}
			[Token(Token = "0x60001ED")]
			[Address(RVA = "0x4EEA40", Offset = "0x4ED640", VA = "0x1804EEA40")]
			set
			{
			}
		}

		// Token: 0x1700003A RID: 58
		// (get) Token: 0x060001EE RID: 494 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060001EF RID: 495 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x1700003A")]
		public Regions Regions
		{
			[Token(Token = "0x60001EE")]
			[Address(RVA = "0x5BE2020", Offset = "0x5BE0C20", VA = "0x185BE2020")]
			get
			{
				return null;
			}
			[Token(Token = "0x60001EF")]
			[Address(RVA = "0x4EC670", Offset = "0x4EB270", VA = "0x1804EC670")]
			set
			{
			}
		}

		// Token: 0x1700003B RID: 59
		// (get) Token: 0x060001F0 RID: 496 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060001F1 RID: 497 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x1700003B")]
		public Plist Plist
		{
			[Token(Token = "0x60001F0")]
			[Address(RVA = "0x5BE1FA0", Offset = "0x5BE0BA0", VA = "0x185BE1FA0")]
			get
			{
				return null;
			}
			[Token(Token = "0x60001F1")]
			[Address(RVA = "0x4E6EC0", Offset = "0x4E5AC0", VA = "0x1804E6EC0")]
			set
			{
			}
		}

		// Token: 0x060001F2 RID: 498 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x60001F2")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public SDKConfigJsonData()
		{
		}

		// Token: 0x0400013D RID: 317
		[Token(Token = "0x400013D")]
		[FieldOffset(Offset = "0x10")]
		private string version;

		// Token: 0x0400013E RID: 318
		[Token(Token = "0x400013E")]
		[FieldOffset(Offset = "0x18")]
		private Regions regions;

		// Token: 0x0400013F RID: 319
		[Token(Token = "0x400013F")]
		[FieldOffset(Offset = "0x20")]
		private Plist plist;
	}
}

using System;
using Il2CppDummyDll;

namespace ICSharpCode.SharpZipLib.Zip
{
	// Token: 0x0200005C RID: 92
	[Token(Token = "0x200005C")]
	public class NTTaggedData : ITaggedData
	{
		// Token: 0x170000D0 RID: 208
		// (get) Token: 0x06000387 RID: 903 RVA: 0x00003C00 File Offset: 0x00001E00
		[Token(Token = "0x170000D0")]
		public short TagID
		{
			[Token(Token = "0x6000387")]
			[Address(RVA = "0x2114980", Offset = "0x2113580", VA = "0x182114980", Slot = "4")]
			get
			{
				return 0;
			}
		}

		// Token: 0x06000388 RID: 904 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000388")]
		[Address(RVA = "0x4A5DEB0", Offset = "0x4A5CAB0", VA = "0x184A5DEB0", Slot = "5")]
		public void SetData(byte[] data, int index, int count)
		{
		}

		// Token: 0x06000389 RID: 905 RVA: 0x0000230A File Offset: 0x0000050A
		[Token(Token = "0x6000389")]
		[Address(RVA = "0x4A5DA60", Offset = "0x4A5C660", VA = "0x184A5DA60", Slot = "6")]
		public byte[] GetData()
		{
			return null;
		}

		// Token: 0x0600038A RID: 906 RVA: 0x00003C18 File Offset: 0x00001E18
		[Token(Token = "0x600038A")]
		[Address(RVA = "0x4A5DE50", Offset = "0x4A5CA50", VA = "0x184A5DE50")]
		public static bool IsValidValue(DateTime value)
		{
			return default(bool);
		}

		// Token: 0x170000D1 RID: 209
		// (get) Token: 0x0600038B RID: 907 RVA: 0x00003C30 File Offset: 0x00001E30
		// (set) Token: 0x0600038C RID: 908 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170000D1")]
		public DateTime LastModificationTime
		{
			[Token(Token = "0x600038B")]
			[Address(RVA = "0x4E5A80", Offset = "0x4E4680", VA = "0x1804E5A80")]
			get
			{
				return default(DateTime);
			}
			[Token(Token = "0x600038C")]
			[Address(RVA = "0x4A5E3E0", Offset = "0x4A5CFE0", VA = "0x184A5E3E0")]
			set
			{
			}
		}

		// Token: 0x170000D2 RID: 210
		// (get) Token: 0x0600038D RID: 909 RVA: 0x00003C48 File Offset: 0x00001E48
		// (set) Token: 0x0600038E RID: 910 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170000D2")]
		public DateTime CreateTime
		{
			[Token(Token = "0x600038D")]
			[Address(RVA = "0x4E5A70", Offset = "0x4E4670", VA = "0x1804E5A70")]
			get
			{
				return default(DateTime);
			}
			[Token(Token = "0x600038E")]
			[Address(RVA = "0x4A5E2E0", Offset = "0x4A5CEE0", VA = "0x184A5E2E0")]
			set
			{
			}
		}

		// Token: 0x170000D3 RID: 211
		// (get) Token: 0x0600038F RID: 911 RVA: 0x00003C60 File Offset: 0x00001E60
		// (set) Token: 0x06000390 RID: 912 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170000D3")]
		public DateTime LastAccessTime
		{
			[Token(Token = "0x600038F")]
			[Address(RVA = "0x4EC5A0", Offset = "0x4EB1A0", VA = "0x1804EC5A0")]
			get
			{
				return default(DateTime);
			}
			[Token(Token = "0x6000390")]
			[Address(RVA = "0x4A5E360", Offset = "0x4A5CF60", VA = "0x184A5E360")]
			set
			{
			}
		}

		// Token: 0x06000391 RID: 913 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000391")]
		[Address(RVA = "0x4A5E270", Offset = "0x4A5CE70", VA = "0x184A5E270")]
		public NTTaggedData()
		{
		}

		// Token: 0x040002A2 RID: 674
		[Token(Token = "0x40002A2")]
		[FieldOffset(Offset = "0x10")]
		private DateTime _lastAccessTime;

		// Token: 0x040002A3 RID: 675
		[Token(Token = "0x40002A3")]
		[FieldOffset(Offset = "0x18")]
		private DateTime _lastModificationTime;

		// Token: 0x040002A4 RID: 676
		[Token(Token = "0x40002A4")]
		[FieldOffset(Offset = "0x20")]
		private DateTime _createTime;
	}
}

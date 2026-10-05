using System;
using Il2CppDummyDll;

namespace ICSharpCode.SharpZipLib.Zip
{
	// Token: 0x0200005A RID: 90
	[Token(Token = "0x200005A")]
	public class ExtendedUnixData : ITaggedData
	{
		// Token: 0x170000CB RID: 203
		// (get) Token: 0x0600037A RID: 890 RVA: 0x00003B70 File Offset: 0x00001D70
		[Token(Token = "0x170000CB")]
		public short TagID
		{
			[Token(Token = "0x600037A")]
			[Address(RVA = "0x4A5D430", Offset = "0x4A5C030", VA = "0x184A5D430", Slot = "4")]
			get
			{
				return 0;
			}
		}

		// Token: 0x0600037B RID: 891 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600037B")]
		[Address(RVA = "0x4A5CE60", Offset = "0x4A5BA60", VA = "0x184A5CE60", Slot = "5")]
		public void SetData(byte[] data, int index, int count)
		{
		}

		// Token: 0x0600037C RID: 892 RVA: 0x0000230A File Offset: 0x0000050A
		[Token(Token = "0x600037C")]
		[Address(RVA = "0x4A5C800", Offset = "0x4A5B400", VA = "0x184A5C800", Slot = "6")]
		public byte[] GetData()
		{
			return null;
		}

		// Token: 0x0600037D RID: 893 RVA: 0x00003B88 File Offset: 0x00001D88
		[Token(Token = "0x600037D")]
		[Address(RVA = "0x4A5CD50", Offset = "0x4A5B950", VA = "0x184A5CD50")]
		public static bool IsValidValue(DateTime value)
		{
			return default(bool);
		}

		// Token: 0x170000CC RID: 204
		// (get) Token: 0x0600037E RID: 894 RVA: 0x00003BA0 File Offset: 0x00001DA0
		// (set) Token: 0x0600037F RID: 895 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170000CC")]
		public DateTime ModificationTime
		{
			[Token(Token = "0x600037E")]
			[Address(RVA = "0x4E5A80", Offset = "0x4E4680", VA = "0x1804E5A80")]
			get
			{
				return default(DateTime);
			}
			[Token(Token = "0x600037F")]
			[Address(RVA = "0x4A5D560", Offset = "0x4A5C160", VA = "0x184A5D560")]
			set
			{
			}
		}

		// Token: 0x170000CD RID: 205
		// (get) Token: 0x06000380 RID: 896 RVA: 0x00003BB8 File Offset: 0x00001DB8
		// (set) Token: 0x06000381 RID: 897 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170000CD")]
		public DateTime AccessTime
		{
			[Token(Token = "0x6000380")]
			[Address(RVA = "0x4E5A70", Offset = "0x4E4670", VA = "0x1804E5A70")]
			get
			{
				return default(DateTime);
			}
			[Token(Token = "0x6000381")]
			[Address(RVA = "0x4A5D440", Offset = "0x4A5C040", VA = "0x184A5D440")]
			set
			{
			}
		}

		// Token: 0x170000CE RID: 206
		// (get) Token: 0x06000382 RID: 898 RVA: 0x00003BD0 File Offset: 0x00001DD0
		// (set) Token: 0x06000383 RID: 899 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170000CE")]
		public DateTime CreateTime
		{
			[Token(Token = "0x6000382")]
			[Address(RVA = "0x4E4070", Offset = "0x4E2C70", VA = "0x1804E4070")]
			get
			{
				return default(DateTime);
			}
			[Token(Token = "0x6000383")]
			[Address(RVA = "0x4A5D4D0", Offset = "0x4A5C0D0", VA = "0x184A5D4D0")]
			set
			{
			}
		}

		// Token: 0x170000CF RID: 207
		// (get) Token: 0x06000384 RID: 900 RVA: 0x00003BE8 File Offset: 0x00001DE8
		// (set) Token: 0x06000385 RID: 901 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170000CF")]
		private ExtendedUnixData.Flags Include
		{
			[Token(Token = "0x6000384")]
			[Address(RVA = "0x4E6300", Offset = "0x4E4F00", VA = "0x1804E6300")]
			get
			{
				return (ExtendedUnixData.Flags)0;
			}
			[Token(Token = "0x6000385")]
			[Address(RVA = "0x4E63E0", Offset = "0x4E4FE0", VA = "0x1804E63E0")]
			set
			{
			}
		}

		// Token: 0x06000386 RID: 902 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000386")]
		[Address(RVA = "0x4A5D370", Offset = "0x4A5BF70", VA = "0x184A5D370")]
		public ExtendedUnixData()
		{
		}

		// Token: 0x0400029A RID: 666
		[Token(Token = "0x400029A")]
		[FieldOffset(Offset = "0x10")]
		private ExtendedUnixData.Flags _flags;

		// Token: 0x0400029B RID: 667
		[Token(Token = "0x400029B")]
		[FieldOffset(Offset = "0x18")]
		private DateTime _modificationTime;

		// Token: 0x0400029C RID: 668
		[Token(Token = "0x400029C")]
		[FieldOffset(Offset = "0x20")]
		private DateTime _lastAccessTime;

		// Token: 0x0400029D RID: 669
		[Token(Token = "0x400029D")]
		[FieldOffset(Offset = "0x28")]
		private DateTime _createTime;

		// Token: 0x0200005B RID: 91
		[Token(Token = "0x200005B")]
		[Flags]
		public enum Flags : byte
		{
			// Token: 0x0400029F RID: 671
			[Token(Token = "0x400029F")]
			ModificationTime = 1,
			// Token: 0x040002A0 RID: 672
			[Token(Token = "0x40002A0")]
			AccessTime = 2,
			// Token: 0x040002A1 RID: 673
			[Token(Token = "0x40002A1")]
			CreateTime = 4
		}
	}
}

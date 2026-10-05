using System;
using Il2CppDummyDll;

namespace ICSharpCode.SharpZipLib.Core
{
	// Token: 0x0200001B RID: 27
	[Token(Token = "0x200001B")]
	public class ExtendedPathFilter : PathFilter
	{
		// Token: 0x060000C4 RID: 196 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000C4")]
		[Address(RVA = "0x4A3B0D0", Offset = "0x4A39CD0", VA = "0x184A3B0D0")]
		public ExtendedPathFilter(string filter, long minSize, long maxSize)
		{
		}

		// Token: 0x060000C5 RID: 197 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000C5")]
		[Address(RVA = "0x4A3B1A0", Offset = "0x4A39DA0", VA = "0x184A3B1A0")]
		public ExtendedPathFilter(string filter, DateTime minDate, DateTime maxDate)
		{
		}

		// Token: 0x060000C6 RID: 198 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000C6")]
		[Address(RVA = "0x4A3AFE0", Offset = "0x4A39BE0", VA = "0x184A3AFE0")]
		public ExtendedPathFilter(string filter, long minSize, long maxSize, DateTime minDate, DateTime maxDate)
		{
		}

		// Token: 0x060000C7 RID: 199 RVA: 0x00002478 File Offset: 0x00000678
		[Token(Token = "0x60000C7")]
		[Address(RVA = "0x4A3AEA0", Offset = "0x4A39AA0", VA = "0x184A3AEA0", Slot = "5")]
		public override bool IsMatch(string name)
		{
			return default(bool);
		}

		// Token: 0x1700001D RID: 29
		// (get) Token: 0x060000C8 RID: 200 RVA: 0x00002490 File Offset: 0x00000690
		// (set) Token: 0x060000C9 RID: 201 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700001D")]
		public long MinSize
		{
			[Token(Token = "0x60000C8")]
			[Address(RVA = "0x4E5A80", Offset = "0x4E4680", VA = "0x1804E5A80")]
			get
			{
				return 0L;
			}
			[Token(Token = "0x60000C9")]
			[Address(RVA = "0x4A3B4B0", Offset = "0x4A3A0B0", VA = "0x184A3B4B0")]
			set
			{
			}
		}

		// Token: 0x1700001E RID: 30
		// (get) Token: 0x060000CA RID: 202 RVA: 0x000024A8 File Offset: 0x000006A8
		// (set) Token: 0x060000CB RID: 203 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700001E")]
		public long MaxSize
		{
			[Token(Token = "0x60000CA")]
			[Address(RVA = "0x4E5A70", Offset = "0x4E4670", VA = "0x1804E5A70")]
			get
			{
				return 0L;
			}
			[Token(Token = "0x60000CB")]
			[Address(RVA = "0x4A3B350", Offset = "0x4A39F50", VA = "0x184A3B350")]
			set
			{
			}
		}

		// Token: 0x1700001F RID: 31
		// (get) Token: 0x060000CC RID: 204 RVA: 0x000024C0 File Offset: 0x000006C0
		// (set) Token: 0x060000CD RID: 205 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700001F")]
		public DateTime MinDate
		{
			[Token(Token = "0x60000CC")]
			[Address(RVA = "0x4E4070", Offset = "0x4E2C70", VA = "0x1804E4070")]
			get
			{
				return default(DateTime);
			}
			[Token(Token = "0x60000CD")]
			[Address(RVA = "0x4A3B3D0", Offset = "0x4A39FD0", VA = "0x184A3B3D0")]
			set
			{
			}
		}

		// Token: 0x17000020 RID: 32
		// (get) Token: 0x060000CE RID: 206 RVA: 0x000024D8 File Offset: 0x000006D8
		// (set) Token: 0x060000CF RID: 207 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000020")]
		public DateTime MaxDate
		{
			[Token(Token = "0x60000CE")]
			[Address(RVA = "0x4EA8A0", Offset = "0x4E94A0", VA = "0x1804EA8A0")]
			get
			{
				return default(DateTime);
			}
			[Token(Token = "0x60000CF")]
			[Address(RVA = "0x4A3B270", Offset = "0x4A39E70", VA = "0x184A3B270")]
			set
			{
			}
		}

		// Token: 0x04000083 RID: 131
		[Token(Token = "0x4000083")]
		[FieldOffset(Offset = "0x18")]
		private long minSize_;

		// Token: 0x04000084 RID: 132
		[Token(Token = "0x4000084")]
		[FieldOffset(Offset = "0x20")]
		private long maxSize_;

		// Token: 0x04000085 RID: 133
		[Token(Token = "0x4000085")]
		[FieldOffset(Offset = "0x28")]
		private DateTime minDate_;

		// Token: 0x04000086 RID: 134
		[Token(Token = "0x4000086")]
		[FieldOffset(Offset = "0x30")]
		private DateTime maxDate_;
	}
}

using System;
using System.IO;
using System.Runtime.CompilerServices;
using System.Text;
using Il2CppDummyDll;
using Newtonsoft.Json.Shims;

namespace Newtonsoft.Json.Bson
{
	// Token: 0x0200011F RID: 287
	[Token(Token = "0x200011F")]
	[Preserve]
	internal class BsonBinaryWriter
	{
		// Token: 0x1700022C RID: 556
		// (get) Token: 0x06000B33 RID: 2867 RVA: 0x00006090 File Offset: 0x00004290
		// (set) Token: 0x06000B34 RID: 2868 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700022C")]
		public DateTimeKind DateTimeKindHandling
		{
			[Token(Token = "0x6000B33")]
			[Address(RVA = "0x4EA890", Offset = "0x4E9490", VA = "0x1804EA890")]
			[CompilerGenerated]
			get
			{
				return DateTimeKind.Unspecified;
			}
			[Token(Token = "0x6000B34")]
			[Address(RVA = "0x4EAC20", Offset = "0x4E9820", VA = "0x1804EAC20")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x06000B35 RID: 2869 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000B35")]
		[Address(RVA = "0x4DFE400", Offset = "0x4DFD000", VA = "0x184DFE400")]
		public BsonBinaryWriter(BinaryWriter writer)
		{
		}

		// Token: 0x06000B36 RID: 2870 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000B36")]
		[Address(RVA = "0x4DFD370", Offset = "0x4DFBF70", VA = "0x184DFD370")]
		public void Flush()
		{
		}

		// Token: 0x06000B37 RID: 2871 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000B37")]
		[Address(RVA = "0x4DFD330", Offset = "0x4DFBF30", VA = "0x184DFD330")]
		public void Close()
		{
		}

		// Token: 0x06000B38 RID: 2872 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000B38")]
		[Address(RVA = "0x4DFE140", Offset = "0x4DFCD40", VA = "0x184DFE140")]
		public void WriteToken(BsonToken t)
		{
		}

		// Token: 0x06000B39 RID: 2873 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000B39")]
		[Address(RVA = "0x4DFD490", Offset = "0x4DFC090", VA = "0x184DFD490")]
		private void WriteTokenInternal(BsonToken t)
		{
		}

		// Token: 0x06000B3A RID: 2874 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000B3A")]
		[Address(RVA = "0x4DFD3B0", Offset = "0x4DFBFB0", VA = "0x184DFD3B0")]
		private void WriteString(string s, int byteCount, int? calculatedlengthPrefix)
		{
		}

		// Token: 0x06000B3B RID: 2875 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000B3B")]
		[Address(RVA = "0x4DFE170", Offset = "0x4DFCD70", VA = "0x184DFE170")]
		public void WriteUtf8Bytes(string s, int byteCount)
		{
		}

		// Token: 0x06000B3C RID: 2876 RVA: 0x000060A8 File Offset: 0x000042A8
		[Token(Token = "0x6000B3C")]
		[Address(RVA = "0x5BA110", Offset = "0x5B8D10", VA = "0x1805BA110")]
		private int CalculateSize(int stringByteCount)
		{
			return 0;
		}

		// Token: 0x06000B3D RID: 2877 RVA: 0x000060C0 File Offset: 0x000042C0
		[Token(Token = "0x6000B3D")]
		[Address(RVA = "0x4DFCCD0", Offset = "0x4DFB8D0", VA = "0x184DFCCD0")]
		private int CalculateSizeWithLength(int stringByteCount, bool includeSize)
		{
			return 0;
		}

		// Token: 0x06000B3E RID: 2878 RVA: 0x000060D8 File Offset: 0x000042D8
		[Token(Token = "0x6000B3E")]
		[Address(RVA = "0x4DFCCE0", Offset = "0x4DFB8E0", VA = "0x184DFCCE0")]
		private int CalculateSize(BsonToken t)
		{
			return 0;
		}

		// Token: 0x0400042C RID: 1068
		[Token(Token = "0x400042C")]
		[FieldOffset(Offset = "0x0")]
		private static readonly Encoding Encoding;

		// Token: 0x0400042D RID: 1069
		[Token(Token = "0x400042D")]
		[FieldOffset(Offset = "0x10")]
		private readonly BinaryWriter _writer;

		// Token: 0x0400042E RID: 1070
		[Token(Token = "0x400042E")]
		[FieldOffset(Offset = "0x18")]
		private byte[] _largeByteBuffer;
	}
}

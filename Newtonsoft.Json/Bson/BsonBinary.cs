using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Newtonsoft.Json.Shims;

namespace Newtonsoft.Json.Bson
{
	// Token: 0x02000128 RID: 296
	[Token(Token = "0x2000128")]
	[Preserve]
	internal class BsonBinary : BsonValue
	{
		// Token: 0x17000239 RID: 569
		// (get) Token: 0x06000B7B RID: 2939 RVA: 0x000062D0 File Offset: 0x000044D0
		// (set) Token: 0x06000B7C RID: 2940 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000239")]
		public BsonBinaryType BinaryType
		{
			[Token(Token = "0x6000B7B")]
			[Address(RVA = "0xAE5EF0", Offset = "0xAE4AF0", VA = "0x180AE5EF0")]
			[CompilerGenerated]
			get
			{
				return BsonBinaryType.Binary;
			}
			[Token(Token = "0x6000B7C")]
			[Address(RVA = "0x17F30F0", Offset = "0x17F1CF0", VA = "0x1817F30F0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x06000B7D RID: 2941 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000B7D")]
		[Address(RVA = "0x4DFE440", Offset = "0x4DFD040", VA = "0x184DFE440")]
		public BsonBinary(byte[] value, BsonBinaryType binaryType)
		{
		}
	}
}

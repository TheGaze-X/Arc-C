using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Newtonsoft.Json.Shims;

namespace Newtonsoft.Json.Bson
{
	// Token: 0x02000123 RID: 291
	[Token(Token = "0x2000123")]
	[Preserve]
	internal abstract class BsonToken
	{
		// Token: 0x17000230 RID: 560
		// (get) Token: 0x06000B63 RID: 2915
		[Token(Token = "0x17000230")]
		public abstract BsonType Type { [Token(Token = "0x6000B63")] get; }

		// Token: 0x17000231 RID: 561
		// (get) Token: 0x06000B64 RID: 2916 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06000B65 RID: 2917 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000231")]
		public BsonToken Parent
		{
			[Token(Token = "0x6000B64")]
			[Address(RVA = "0x4EC5A0", Offset = "0x4EB1A0", VA = "0x1804EC5A0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000B65")]
			[Address(RVA = "0x4EEA40", Offset = "0x4ED640", VA = "0x1804EEA40")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000232 RID: 562
		// (get) Token: 0x06000B66 RID: 2918 RVA: 0x00006240 File Offset: 0x00004440
		// (set) Token: 0x06000B67 RID: 2919 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000232")]
		public int CalculatedSize
		{
			[Token(Token = "0x6000B66")]
			[Address(RVA = "0x4EA860", Offset = "0x4E9460", VA = "0x1804EA860")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[Token(Token = "0x6000B67")]
			[Address(RVA = "0x4EA9A0", Offset = "0x4E95A0", VA = "0x1804EA9A0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x06000B68 RID: 2920 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000B68")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		protected BsonToken()
		{
		}
	}
}

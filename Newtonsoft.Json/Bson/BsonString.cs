using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Newtonsoft.Json.Shims;

namespace Newtonsoft.Json.Bson
{
	// Token: 0x02000127 RID: 295
	[Token(Token = "0x2000127")]
	[Preserve]
	internal class BsonString : BsonValue
	{
		// Token: 0x17000237 RID: 567
		// (get) Token: 0x06000B76 RID: 2934 RVA: 0x000062A0 File Offset: 0x000044A0
		// (set) Token: 0x06000B77 RID: 2935 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000237")]
		public int ByteCount
		{
			[Token(Token = "0x6000B76")]
			[Address(RVA = "0xC91700", Offset = "0xC90300", VA = "0x180C91700")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[Token(Token = "0x6000B77")]
			[Address(RVA = "0xF82EE0", Offset = "0xF81AE0", VA = "0x180F82EE0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000238 RID: 568
		// (get) Token: 0x06000B78 RID: 2936 RVA: 0x000062B8 File Offset: 0x000044B8
		// (set) Token: 0x06000B79 RID: 2937 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000238")]
		public bool IncludeLength
		{
			[Token(Token = "0x6000B78")]
			[Address(RVA = "0x2033950", Offset = "0x2032550", VA = "0x182033950")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000B79")]
			[Address(RVA = "0x2033A00", Offset = "0x2032600", VA = "0x182033A00")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x06000B7A RID: 2938 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000B7A")]
		[Address(RVA = "0x4E00EC0", Offset = "0x4DFFAC0", VA = "0x184E00EC0")]
		public BsonString(object value, bool includeLength)
		{
		}
	}
}

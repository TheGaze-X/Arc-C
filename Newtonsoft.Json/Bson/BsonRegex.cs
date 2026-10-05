using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Newtonsoft.Json.Shims;

namespace Newtonsoft.Json.Bson
{
	// Token: 0x02000129 RID: 297
	[Token(Token = "0x2000129")]
	[Preserve]
	internal class BsonRegex : BsonToken
	{
		// Token: 0x1700023A RID: 570
		// (get) Token: 0x06000B7E RID: 2942 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06000B7F RID: 2943 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700023A")]
		public BsonString Pattern
		{
			[Token(Token = "0x6000B7E")]
			[Address(RVA = "0x4E5A70", Offset = "0x4E4670", VA = "0x1804E5A70")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000B7F")]
			[Address(RVA = "0x4E6EC0", Offset = "0x4E5AC0", VA = "0x1804E6EC0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x1700023B RID: 571
		// (get) Token: 0x06000B80 RID: 2944 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06000B81 RID: 2945 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700023B")]
		public BsonString Options
		{
			[Token(Token = "0x6000B80")]
			[Address(RVA = "0x4E4070", Offset = "0x4E2C70", VA = "0x1804E4070")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000B81")]
			[Address(RVA = "0x4E6EB0", Offset = "0x4E5AB0", VA = "0x1804E6EB0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x06000B82 RID: 2946 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000B82")]
		[Address(RVA = "0x4E00DC0", Offset = "0x4DFF9C0", VA = "0x184E00DC0")]
		public BsonRegex(string pattern, string options)
		{
		}

		// Token: 0x1700023C RID: 572
		// (get) Token: 0x06000B83 RID: 2947 RVA: 0x000062E8 File Offset: 0x000044E8
		[Token(Token = "0x1700023C")]
		public override BsonType Type
		{
			[Token(Token = "0x6000B83")]
			[Address(RVA = "0x4E00EB0", Offset = "0x4DFFAB0", VA = "0x184E00EB0", Slot = "4")]
			get
			{
				return (BsonType)0;
			}
		}
	}
}

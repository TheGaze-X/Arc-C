using System;
using Il2CppDummyDll;
using Newtonsoft.Json.Shims;

namespace Newtonsoft.Json.Bson
{
	// Token: 0x02000126 RID: 294
	[Token(Token = "0x2000126")]
	[Preserve]
	internal class BsonValue : BsonToken
	{
		// Token: 0x06000B73 RID: 2931 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000B73")]
		[Address(RVA = "0x4E00F10", Offset = "0x4DFFB10", VA = "0x184E00F10")]
		public BsonValue(object value, BsonType type)
		{
		}

		// Token: 0x17000235 RID: 565
		// (get) Token: 0x06000B74 RID: 2932 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000235")]
		public object Value
		{
			[Token(Token = "0x6000B74")]
			[Address(RVA = "0x4E5A70", Offset = "0x4E4670", VA = "0x1804E5A70")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000236 RID: 566
		// (get) Token: 0x06000B75 RID: 2933 RVA: 0x00006288 File Offset: 0x00004488
		[Token(Token = "0x17000236")]
		public override BsonType Type
		{
			[Token(Token = "0x6000B75")]
			[Address(RVA = "0x73B8F0", Offset = "0x73A4F0", VA = "0x18073B8F0", Slot = "4")]
			get
			{
				return (BsonType)0;
			}
		}

		// Token: 0x04000450 RID: 1104
		[Token(Token = "0x4000450")]
		[FieldOffset(Offset = "0x20")]
		private readonly object _value;

		// Token: 0x04000451 RID: 1105
		[Token(Token = "0x4000451")]
		[FieldOffset(Offset = "0x28")]
		private readonly BsonType _type;
	}
}

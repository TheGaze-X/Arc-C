using System;
using System.Collections;
using System.Collections.Generic;
using Il2CppDummyDll;
using Newtonsoft.Json.Shims;

namespace Newtonsoft.Json.Bson
{
	// Token: 0x02000125 RID: 293
	[Token(Token = "0x2000125")]
	[Preserve]
	internal class BsonArray : BsonToken, IEnumerable<BsonToken>, IEnumerable
	{
		// Token: 0x06000B6E RID: 2926 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000B6E")]
		[Address(RVA = "0x4DFCB30", Offset = "0x4DFB730", VA = "0x184DFCB30")]
		public void Add(BsonToken token)
		{
		}

		// Token: 0x17000234 RID: 564
		// (get) Token: 0x06000B6F RID: 2927 RVA: 0x00006270 File Offset: 0x00004470
		[Token(Token = "0x17000234")]
		public override BsonType Type
		{
			[Token(Token = "0x6000B6F")]
			[Address(RVA = "0x4DFCCC0", Offset = "0x4DFB8C0", VA = "0x184DFCCC0", Slot = "4")]
			get
			{
				return (BsonType)0;
			}
		}

		// Token: 0x06000B70 RID: 2928 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000B70")]
		[Address(RVA = "0x4DFCBA0", Offset = "0x4DFB7A0", VA = "0x184DFCBA0", Slot = "5")]
		public IEnumerator<BsonToken> GetEnumerator()
		{
			return null;
		}

		// Token: 0x06000B71 RID: 2929 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000B71")]
		[Address(RVA = "0x4DFCC20", Offset = "0x4DFB820", VA = "0x184DFCC20", Slot = "6")]
		private IEnumerator GetEnumerator()
		{
			return null;
		}

		// Token: 0x06000B72 RID: 2930 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000B72")]
		[Address(RVA = "0x4DFCC30", Offset = "0x4DFB830", VA = "0x184DFCC30")]
		public BsonArray()
		{
		}

		// Token: 0x0400044F RID: 1103
		[Token(Token = "0x400044F")]
		[FieldOffset(Offset = "0x20")]
		private readonly List<BsonToken> _children;
	}
}

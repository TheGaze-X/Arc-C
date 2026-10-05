using System;
using System.Collections;
using System.Collections.Generic;
using Il2CppDummyDll;
using Newtonsoft.Json.Shims;

namespace Newtonsoft.Json.Bson
{
	// Token: 0x02000124 RID: 292
	[Token(Token = "0x2000124")]
	[Preserve]
	internal class BsonObject : BsonToken, IEnumerable<BsonProperty>, IEnumerable
	{
		// Token: 0x06000B69 RID: 2921 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000B69")]
		[Address(RVA = "0x4DFE570", Offset = "0x4DFD170", VA = "0x184DFE570")]
		public void Add(string name, BsonToken token)
		{
		}

		// Token: 0x17000233 RID: 563
		// (get) Token: 0x06000B6A RID: 2922 RVA: 0x00006258 File Offset: 0x00004458
		[Token(Token = "0x17000233")]
		public override BsonType Type
		{
			[Token(Token = "0x6000B6A")]
			[Address(RVA = "0x4DFE7B0", Offset = "0x4DFD3B0", VA = "0x184DFE7B0", Slot = "4")]
			get
			{
				return (BsonType)0;
			}
		}

		// Token: 0x06000B6B RID: 2923 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000B6B")]
		[Address(RVA = "0x4DFE690", Offset = "0x4DFD290", VA = "0x184DFE690", Slot = "5")]
		public IEnumerator<BsonProperty> GetEnumerator()
		{
			return null;
		}

		// Token: 0x06000B6C RID: 2924 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000B6C")]
		[Address(RVA = "0x4DFE710", Offset = "0x4DFD310", VA = "0x184DFE710", Slot = "6")]
		private IEnumerator GetEnumerator()
		{
			return null;
		}

		// Token: 0x06000B6D RID: 2925 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000B6D")]
		[Address(RVA = "0x4DFE720", Offset = "0x4DFD320", VA = "0x184DFE720")]
		public BsonObject()
		{
		}

		// Token: 0x0400044E RID: 1102
		[Token(Token = "0x400044E")]
		[FieldOffset(Offset = "0x20")]
		private readonly List<BsonProperty> _children;
	}
}

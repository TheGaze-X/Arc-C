using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace FullInspector.Internal
{
	// Token: 0x02007CAC RID: 31916
	[Token(Token = "0x2007CAC")]
	public class ListSerializationOperator : ISerializationOperator
	{
		// Token: 0x0602C94A RID: 182602 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602C94A")]
		[Address(RVA = "0x28620A0", Offset = "0x2860CA0", VA = "0x1828620A0", Slot = "4")]
		public UnityEngine.Object RetrieveObjectReference(int storageId)
		{
			return null;
		}

		// Token: 0x0602C94B RID: 182603 RVA: 0x000E0F40 File Offset: 0x000DF140
		[Token(Token = "0x602C94B")]
		[Address(RVA = "0x2862160", Offset = "0x2860D60", VA = "0x182862160", Slot = "5")]
		public int StoreObjectReference(UnityEngine.Object obj)
		{
			return 0;
		}

		// Token: 0x0602C94C RID: 182604 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602C94C")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public ListSerializationOperator()
		{
		}

		// Token: 0x040403D4 RID: 263124
		[Token(Token = "0x40403D4")]
		[FieldOffset(Offset = "0x10")]
		public List<UnityEngine.Object> SerializedObjects;
	}
}

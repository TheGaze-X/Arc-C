using System;
using Il2CppDummyDll;
using UnityEngine;

namespace FullInspector
{
	// Token: 0x02007BD1 RID: 31697
	[Token(Token = "0x2007BD1")]
	public class NotSupportedSerializationOperator : ISerializationOperator
	{
		// Token: 0x0602C5D5 RID: 181717 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602C5D5")]
		[Address(RVA = "0x2862230", Offset = "0x2860E30", VA = "0x182862230", Slot = "4")]
		public UnityEngine.Object RetrieveObjectReference(int storageId)
		{
			return null;
		}

		// Token: 0x0602C5D6 RID: 181718 RVA: 0x000DFBA8 File Offset: 0x000DDDA8
		[Token(Token = "0x602C5D6")]
		[Address(RVA = "0x2862290", Offset = "0x2860E90", VA = "0x182862290", Slot = "5")]
		public int StoreObjectReference(UnityEngine.Object obj)
		{
			return 0;
		}

		// Token: 0x0602C5D7 RID: 181719 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602C5D7")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public NotSupportedSerializationOperator()
		{
		}
	}
}

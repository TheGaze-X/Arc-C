using System;
using System.Runtime.Serialization;
using Il2CppDummyDll;

namespace System.Collections.Generic
{
	// Token: 0x02000630 RID: 1584
	[Token(Token = "0x2000630")]
	[System.Serializable]
	internal sealed class SByteEnumEqualityComparer<T> : EnumEqualityComparer<T>, System.Runtime.Serialization.ISerializable where T : struct
	{
		// Token: 0x06002FBD RID: 12221 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002FBD")]
		public SByteEnumEqualityComparer()
		{
		}

		// Token: 0x06002FBE RID: 12222 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002FBE")]
		public SByteEnumEqualityComparer(System.Runtime.Serialization.SerializationInfo information, System.Runtime.Serialization.StreamingContext context)
		{
		}

		// Token: 0x06002FBF RID: 12223 RVA: 0x00019E30 File Offset: 0x00018030
		[Token(Token = "0x6002FBF")]
		public override int GetHashCode(T obj)
		{
			return 0;
		}
	}
}

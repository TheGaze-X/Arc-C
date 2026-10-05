using System;
using System.Runtime.Serialization;
using Il2CppDummyDll;

namespace System.Collections.Generic
{
	// Token: 0x02000631 RID: 1585
	[Token(Token = "0x2000631")]
	[System.Serializable]
	internal sealed class ShortEnumEqualityComparer<T> : EnumEqualityComparer<T>, System.Runtime.Serialization.ISerializable where T : struct
	{
		// Token: 0x06002FC0 RID: 12224 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002FC0")]
		public ShortEnumEqualityComparer()
		{
		}

		// Token: 0x06002FC1 RID: 12225 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002FC1")]
		public ShortEnumEqualityComparer(System.Runtime.Serialization.SerializationInfo information, System.Runtime.Serialization.StreamingContext context)
		{
		}

		// Token: 0x06002FC2 RID: 12226 RVA: 0x00019E48 File Offset: 0x00018048
		[Token(Token = "0x6002FC2")]
		public override int GetHashCode(T obj)
		{
			return 0;
		}
	}
}

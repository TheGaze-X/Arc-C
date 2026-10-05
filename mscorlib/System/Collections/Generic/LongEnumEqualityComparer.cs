using System;
using System.Runtime.Serialization;
using Il2CppDummyDll;

namespace System.Collections.Generic
{
	// Token: 0x02000632 RID: 1586
	[Token(Token = "0x2000632")]
	[System.Serializable]
	internal sealed class LongEnumEqualityComparer<T> : EqualityComparer<T>, System.Runtime.Serialization.ISerializable where T : struct
	{
		// Token: 0x06002FC3 RID: 12227 RVA: 0x00019E60 File Offset: 0x00018060
		[Token(Token = "0x6002FC3")]
		public override bool Equals(T x, T y)
		{
			return default(bool);
		}

		// Token: 0x06002FC4 RID: 12228 RVA: 0x00019E78 File Offset: 0x00018078
		[Token(Token = "0x6002FC4")]
		public override int GetHashCode(T obj)
		{
			return 0;
		}

		// Token: 0x06002FC5 RID: 12229 RVA: 0x00019E90 File Offset: 0x00018090
		[Token(Token = "0x6002FC5")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		// Token: 0x06002FC6 RID: 12230 RVA: 0x00019EA8 File Offset: 0x000180A8
		[Token(Token = "0x6002FC6")]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06002FC7 RID: 12231 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002FC7")]
		public LongEnumEqualityComparer()
		{
		}

		// Token: 0x06002FC8 RID: 12232 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002FC8")]
		public LongEnumEqualityComparer(System.Runtime.Serialization.SerializationInfo information, System.Runtime.Serialization.StreamingContext context)
		{
		}

		// Token: 0x06002FC9 RID: 12233 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002FC9")]
		public void GetObjectData(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context)
		{
		}
	}
}

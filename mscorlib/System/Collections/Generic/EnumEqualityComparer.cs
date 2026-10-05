using System;
using System.Runtime.Serialization;
using Il2CppDummyDll;

namespace System.Collections.Generic
{
	// Token: 0x0200062F RID: 1583
	[Token(Token = "0x200062F")]
	[System.Serializable]
	internal class EnumEqualityComparer<T> : EqualityComparer<T>, System.Runtime.Serialization.ISerializable where T : struct
	{
		// Token: 0x06002FB6 RID: 12214 RVA: 0x00019DD0 File Offset: 0x00017FD0
		[Token(Token = "0x6002FB6")]
		public override bool Equals(T x, T y)
		{
			return default(bool);
		}

		// Token: 0x06002FB7 RID: 12215 RVA: 0x00019DE8 File Offset: 0x00017FE8
		[Token(Token = "0x6002FB7")]
		public override int GetHashCode(T obj)
		{
			return 0;
		}

		// Token: 0x06002FB8 RID: 12216 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002FB8")]
		public EnumEqualityComparer()
		{
		}

		// Token: 0x06002FB9 RID: 12217 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002FB9")]
		protected EnumEqualityComparer(System.Runtime.Serialization.SerializationInfo information, System.Runtime.Serialization.StreamingContext context)
		{
		}

		// Token: 0x06002FBA RID: 12218 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002FBA")]
		public void GetObjectData(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context)
		{
		}

		// Token: 0x06002FBB RID: 12219 RVA: 0x00019E00 File Offset: 0x00018000
		[Token(Token = "0x6002FBB")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		// Token: 0x06002FBC RID: 12220 RVA: 0x00019E18 File Offset: 0x00018018
		[Token(Token = "0x6002FBC")]
		public override int GetHashCode()
		{
			return 0;
		}
	}
}

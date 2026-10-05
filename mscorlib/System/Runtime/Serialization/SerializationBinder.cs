using System;
using Il2CppDummyDll;

namespace System.Runtime.Serialization
{
	// Token: 0x020003F7 RID: 1015
	[Token(Token = "0x20003F7")]
	[System.Serializable]
	public abstract class SerializationBinder
	{
		// Token: 0x06001F96 RID: 8086 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001F96")]
		[Address(RVA = "0x4BAA7B0", Offset = "0x4BA93B0", VA = "0x184BAA7B0", Slot = "4")]
		public virtual void BindToName(System.Type serializedType, out string assemblyName, out string typeName)
		{
		}

		// Token: 0x06001F97 RID: 8087
		[Token(Token = "0x6001F97")]
		public abstract System.Type BindToType(string assemblyName, string typeName);

		// Token: 0x06001F98 RID: 8088 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001F98")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		protected SerializationBinder()
		{
		}
	}
}

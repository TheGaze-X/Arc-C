using System;
using System.Runtime.Serialization;
using Il2CppDummyDll;

namespace System.Runtime.CompilerServices
{
	// Token: 0x020004A2 RID: 1186
	[Token(Token = "0x20004A2")]
	[System.Serializable]
	public sealed class RuntimeWrappedException : System.Exception
	{
		// Token: 0x060022E1 RID: 8929 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60022E1")]
		[Address(RVA = "0x4BE62D0", Offset = "0x4BE4ED0", VA = "0x184BE62D0")]
		public RuntimeWrappedException(object thrownObject)
		{
		}

		// Token: 0x060022E2 RID: 8930 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60022E2")]
		[Address(RVA = "0x4BE61E0", Offset = "0x4BE4DE0", VA = "0x184BE61E0")]
		private RuntimeWrappedException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context)
		{
		}

		// Token: 0x060022E3 RID: 8931 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60022E3")]
		[Address(RVA = "0x4BE60E0", Offset = "0x4BE4CE0", VA = "0x184BE60E0", Slot = "12")]
		public override void GetObjectData(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context)
		{
		}

		// Token: 0x060022E4 RID: 8932 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60022E4")]
		[Address(RVA = "0x4BE61B0", Offset = "0x4BE4DB0", VA = "0x184BE61B0")]
		internal RuntimeWrappedException()
		{
		}

		// Token: 0x040013E2 RID: 5090
		[Token(Token = "0x40013E2")]
		[FieldOffset(Offset = "0x90")]
		private object _wrappedException;
	}
}

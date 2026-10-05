using System;
using System.Runtime.Serialization;
using Il2CppDummyDll;

namespace System.Reflection
{
	// Token: 0x0200050F RID: 1295
	[Token(Token = "0x200050F")]
	[System.CLSCompliant(false)]
	public sealed class Pointer : System.Runtime.Serialization.ISerializable
	{
		// Token: 0x060024E2 RID: 9442 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60024E2")]
		[Address(RVA = "0x4BDBE90", Offset = "0x4BDAA90", VA = "0x184BDBE90")]
		private unsafe Pointer(void* ptr, System.Type ptrType)
		{
		}

		// Token: 0x060024E3 RID: 9443 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x60024E3")]
		[Address(RVA = "0x4BDBC40", Offset = "0x4BDA840", VA = "0x184BDBC40")]
		public unsafe static object Box(void* ptr, System.Type type)
		{
			return null;
		}

		// Token: 0x060024E4 RID: 9444 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60024E4")]
		[Address(RVA = "0x4BDBE40", Offset = "0x4BDAA40", VA = "0x184BDBE40", Slot = "4")]
		private void GetObjectData(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context)
		{
		}

		// Token: 0x04001531 RID: 5425
		[Token(Token = "0x4001531")]
		[FieldOffset(Offset = "0x10")]
		private unsafe readonly void* _ptr;

		// Token: 0x04001532 RID: 5426
		[Token(Token = "0x4001532")]
		[FieldOffset(Offset = "0x18")]
		private readonly System.Type _ptrType;
	}
}

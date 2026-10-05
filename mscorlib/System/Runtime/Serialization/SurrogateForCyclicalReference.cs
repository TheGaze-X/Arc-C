using System;
using Il2CppDummyDll;

namespace System.Runtime.Serialization
{
	// Token: 0x020003FF RID: 1023
	[Token(Token = "0x20003FF")]
	internal sealed class SurrogateForCyclicalReference : ISerializationSurrogate
	{
		// Token: 0x06001FC8 RID: 8136 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001FC8")]
		[Address(RVA = "0x4BB0A10", Offset = "0x4BAF610", VA = "0x184BB0A10", Slot = "4")]
		public void GetObjectData(object obj, SerializationInfo info, StreamingContext context)
		{
		}

		// Token: 0x06001FC9 RID: 8137 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6001FC9")]
		[Address(RVA = "0x4BB0B10", Offset = "0x4BAF710", VA = "0x184BB0B10", Slot = "5")]
		public object SetObjectData(object obj, SerializationInfo info, StreamingContext context, ISurrogateSelector selector)
		{
			return null;
		}

		// Token: 0x040010BB RID: 4283
		[Token(Token = "0x40010BB")]
		[FieldOffset(Offset = "0x10")]
		private ISerializationSurrogate innerSurrogate;
	}
}

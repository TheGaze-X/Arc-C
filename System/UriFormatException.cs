using System;
using System.Runtime.Serialization;
using Il2CppDummyDll;

namespace System
{
	// Token: 0x020000BF RID: 191
	[Token(Token = "0x20000BF")]
	[Serializable]
	public class UriFormatException : FormatException, ISerializable
	{
		// Token: 0x06000414 RID: 1044 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000414")]
		[Address(RVA = "0x504EE00", Offset = "0x504DA00", VA = "0x18504EE00")]
		public UriFormatException()
		{
		}

		// Token: 0x06000415 RID: 1045 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000415")]
		[Address(RVA = "0x504EDE0", Offset = "0x504D9E0", VA = "0x18504EDE0")]
		public UriFormatException(string textString)
		{
		}

		// Token: 0x06000416 RID: 1046 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000416")]
		[Address(RVA = "0x4AE1A60", Offset = "0x4AE0660", VA = "0x184AE1A60")]
		protected UriFormatException(SerializationInfo serializationInfo, StreamingContext streamingContext)
		{
		}

		// Token: 0x06000417 RID: 1047 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000417")]
		[Address(RVA = "0x504EDC0", Offset = "0x504D9C0", VA = "0x18504EDC0", Slot = "4")]
		private void GetObjectData(SerializationInfo serializationInfo, StreamingContext streamingContext)
		{
		}
	}
}

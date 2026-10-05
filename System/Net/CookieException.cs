using System;
using System.Runtime.Serialization;
using Il2CppDummyDll;

namespace System.Net
{
	// Token: 0x020002EF RID: 751
	[Token(Token = "0x20002EF")]
	[Serializable]
	public class CookieException : FormatException, ISerializable
	{
		// Token: 0x060014BD RID: 5309 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60014BD")]
		[Address(RVA = "0x504EE00", Offset = "0x504DA00", VA = "0x18504EE00")]
		public CookieException()
		{
		}

		// Token: 0x060014BE RID: 5310 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60014BE")]
		[Address(RVA = "0x504EDE0", Offset = "0x504D9E0", VA = "0x18504EDE0")]
		internal CookieException(string message)
		{
		}

		// Token: 0x060014BF RID: 5311 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60014BF")]
		[Address(RVA = "0x504EDF0", Offset = "0x504D9F0", VA = "0x18504EDF0")]
		internal CookieException(string message, Exception inner)
		{
		}

		// Token: 0x060014C0 RID: 5312 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60014C0")]
		[Address(RVA = "0x4AE1A60", Offset = "0x4AE0660", VA = "0x184AE1A60")]
		protected CookieException(SerializationInfo serializationInfo, StreamingContext streamingContext)
		{
		}

		// Token: 0x060014C1 RID: 5313 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60014C1")]
		[Address(RVA = "0x504EDC0", Offset = "0x504D9C0", VA = "0x18504EDC0", Slot = "4")]
		private void GetObjectData(SerializationInfo serializationInfo, StreamingContext streamingContext)
		{
		}

		// Token: 0x060014C2 RID: 5314 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60014C2")]
		[Address(RVA = "0x504EDC0", Offset = "0x504D9C0", VA = "0x18504EDC0", Slot = "12")]
		public override void GetObjectData(SerializationInfo serializationInfo, StreamingContext streamingContext)
		{
		}
	}
}

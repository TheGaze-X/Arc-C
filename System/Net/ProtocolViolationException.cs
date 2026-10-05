using System;
using System.Runtime.Serialization;
using Il2CppDummyDll;

namespace System.Net
{
	// Token: 0x020002BD RID: 701
	[Token(Token = "0x20002BD")]
	[Serializable]
	public class ProtocolViolationException : InvalidOperationException, ISerializable
	{
		// Token: 0x06001377 RID: 4983 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001377")]
		[Address(RVA = "0x505C240", Offset = "0x505AE40", VA = "0x18505C240")]
		public ProtocolViolationException()
		{
		}

		// Token: 0x06001378 RID: 4984 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001378")]
		[Address(RVA = "0x505C250", Offset = "0x505AE50", VA = "0x18505C250")]
		public ProtocolViolationException(string message)
		{
		}

		// Token: 0x06001379 RID: 4985 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001379")]
		[Address(RVA = "0x4AE1A60", Offset = "0x4AE0660", VA = "0x184AE1A60")]
		protected ProtocolViolationException(SerializationInfo serializationInfo, StreamingContext streamingContext)
		{
		}

		// Token: 0x0600137A RID: 4986 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600137A")]
		[Address(RVA = "0x504EDC0", Offset = "0x504D9C0", VA = "0x18504EDC0", Slot = "4")]
		private void GetObjectData(SerializationInfo serializationInfo, StreamingContext streamingContext)
		{
		}

		// Token: 0x0600137B RID: 4987 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600137B")]
		[Address(RVA = "0x504EDC0", Offset = "0x504D9C0", VA = "0x18504EDC0", Slot = "12")]
		public override void GetObjectData(SerializationInfo serializationInfo, StreamingContext streamingContext)
		{
		}
	}
}

using System;
using System.Runtime.Serialization;
using Il2CppDummyDll;

namespace System.Net
{
	// Token: 0x020002BF RID: 703
	[Token(Token = "0x20002BF")]
	[Serializable]
	public class WebException : InvalidOperationException, ISerializable
	{
		// Token: 0x06001387 RID: 4999 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001387")]
		[Address(RVA = "0x505FFC0", Offset = "0x505EBC0", VA = "0x18505FFC0")]
		public WebException()
		{
		}

		// Token: 0x06001388 RID: 5000 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001388")]
		[Address(RVA = "0x5060450", Offset = "0x505F050", VA = "0x185060450")]
		public WebException(string message)
		{
		}

		// Token: 0x06001389 RID: 5001 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001389")]
		[Address(RVA = "0x50601B0", Offset = "0x505EDB0", VA = "0x1850601B0")]
		public WebException(string message, Exception innerException)
		{
		}

		// Token: 0x0600138A RID: 5002 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600138A")]
		[Address(RVA = "0x505FFE0", Offset = "0x505EBE0", VA = "0x18505FFE0")]
		public WebException(string message, WebExceptionStatus status)
		{
		}

		// Token: 0x0600138B RID: 5003 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600138B")]
		[Address(RVA = "0x5060030", Offset = "0x505EC30", VA = "0x185060030")]
		internal WebException(string message, WebExceptionStatus status, WebExceptionInternalStatus internalStatus, Exception innerException)
		{
		}

		// Token: 0x0600138C RID: 5004 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600138C")]
		[Address(RVA = "0x50601D0", Offset = "0x505EDD0", VA = "0x1850601D0")]
		public WebException(string message, Exception innerException, WebExceptionStatus status, WebResponse response)
		{
		}

		// Token: 0x0600138D RID: 5005 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600138D")]
		[Address(RVA = "0x5060280", Offset = "0x505EE80", VA = "0x185060280")]
		internal WebException(string message, string data, Exception innerException, WebExceptionStatus status, WebResponse response)
		{
		}

		// Token: 0x0600138E RID: 5006 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600138E")]
		[Address(RVA = "0x50600F0", Offset = "0x505ECF0", VA = "0x1850600F0")]
		internal WebException(string message, Exception innerException, WebExceptionStatus status, WebResponse response, WebExceptionInternalStatus internalStatus)
		{
		}

		// Token: 0x0600138F RID: 5007 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600138F")]
		[Address(RVA = "0x5060360", Offset = "0x505EF60", VA = "0x185060360")]
		internal WebException(string message, string data, Exception innerException, WebExceptionStatus status, WebResponse response, WebExceptionInternalStatus internalStatus)
		{
		}

		// Token: 0x06001390 RID: 5008 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001390")]
		[Address(RVA = "0x5060000", Offset = "0x505EC00", VA = "0x185060000")]
		protected WebException(SerializationInfo serializationInfo, StreamingContext streamingContext)
		{
		}

		// Token: 0x06001391 RID: 5009 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001391")]
		[Address(RVA = "0x505FF60", Offset = "0x505EB60", VA = "0x18505FF60", Slot = "4")]
		private void GetObjectData(SerializationInfo serializationInfo, StreamingContext streamingContext)
		{
		}

		// Token: 0x06001392 RID: 5010 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001392")]
		[Address(RVA = "0x504EDC0", Offset = "0x504D9C0", VA = "0x18504EDC0", Slot = "12")]
		public override void GetObjectData(SerializationInfo serializationInfo, StreamingContext streamingContext)
		{
		}

		// Token: 0x17000415 RID: 1045
		// (get) Token: 0x06001393 RID: 5011 RVA: 0x00009648 File Offset: 0x00007848
		[Token(Token = "0x17000415")]
		public WebExceptionStatus Status
		{
			[Token(Token = "0x6001393")]
			[Address(RVA = "0x4D67380", Offset = "0x4D65F80", VA = "0x184D67380")]
			get
			{
				return WebExceptionStatus.Success;
			}
		}

		// Token: 0x17000416 RID: 1046
		// (get) Token: 0x06001394 RID: 5012 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000416")]
		public WebResponse Response
		{
			[Token(Token = "0x6001394")]
			[Address(RVA = "0xF93800", Offset = "0xF92400", VA = "0x180F93800")]
			get
			{
				return null;
			}
		}

		// Token: 0x04000A74 RID: 2676
		[Token(Token = "0x4000A74")]
		[FieldOffset(Offset = "0x90")]
		private WebExceptionStatus m_Status;

		// Token: 0x04000A75 RID: 2677
		[Token(Token = "0x4000A75")]
		[FieldOffset(Offset = "0x98")]
		private WebResponse m_Response;

		// Token: 0x04000A76 RID: 2678
		[Token(Token = "0x4000A76")]
		[FieldOffset(Offset = "0xA0")]
		[NonSerialized]
		private WebExceptionInternalStatus m_InternalStatus;
	}
}

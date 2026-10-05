using System;
using Il2CppDummyDll;
using Vuplex.WebView.Internal;

namespace Vuplex.WebView
{
	// Token: 0x0200005E RID: 94
	[Token(Token = "0x200005E")]
	[Serializable]
	public class StandaloneClientCertificateRequestedEventArgs : EventArgs
	{
		// Token: 0x0600024B RID: 587 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600024B")]
		[Address(RVA = "0x5BBABF0", Offset = "0x5BB97F0", VA = "0x185BBABF0")]
		private StandaloneClientCertificateRequestedEventArgs(CertificateRequestedMessage message, Action<StandaloneX509Certificate> selectCallback)
		{
		}

		// Token: 0x0600024C RID: 588 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600024C")]
		[Address(RVA = "0x5BBA850", Offset = "0x5BB9450", VA = "0x185BBA850", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x0600024D RID: 589 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600024D")]
		[Address(RVA = "0x5BBA7C0", Offset = "0x5BB93C0", VA = "0x185BBA7C0")]
		internal static StandaloneClientCertificateRequestedEventArgs FromMessageJson(string serializedMessage, Action<StandaloneX509Certificate> selectCallback)
		{
			return null;
		}

		// Token: 0x0400012C RID: 300
		[Token(Token = "0x400012C")]
		[FieldOffset(Offset = "0x10")]
		public readonly StandaloneX509Certificate[] Certificates;

		// Token: 0x0400012D RID: 301
		[Token(Token = "0x400012D")]
		[FieldOffset(Offset = "0x18")]
		public readonly string Host;

		// Token: 0x0400012E RID: 302
		[Token(Token = "0x400012E")]
		[FieldOffset(Offset = "0x20")]
		public readonly int Port;

		// Token: 0x0400012F RID: 303
		[Token(Token = "0x400012F")]
		[FieldOffset(Offset = "0x24")]
		public readonly bool IsProxy;

		// Token: 0x04000130 RID: 304
		[Token(Token = "0x4000130")]
		[FieldOffset(Offset = "0x28")]
		public readonly Action<StandaloneX509Certificate> Select;
	}
}

using System;
using Il2CppDummyDll;

namespace System.Net
{
	// Token: 0x02000328 RID: 808
	[Token(Token = "0x2000328")]
	internal sealed class ListenerPrefix
	{
		// Token: 0x0600168E RID: 5774 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600168E")]
		[Address(RVA = "0x5086130", Offset = "0x5084D30", VA = "0x185086130")]
		public ListenerPrefix(string prefix)
		{
		}

		// Token: 0x0600168F RID: 5775 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600168F")]
		[Address(RVA = "0x4EC5A0", Offset = "0x4EB1A0", VA = "0x1804EC5A0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x170004E6 RID: 1254
		// (get) Token: 0x06001690 RID: 5776 RVA: 0x0000A4A0 File Offset: 0x000086A0
		[Token(Token = "0x170004E6")]
		public bool Secure
		{
			[Token(Token = "0x6001690")]
			[Address(RVA = "0xAE5EF0", Offset = "0xAE4AF0", VA = "0x180AE5EF0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170004E7 RID: 1255
		// (get) Token: 0x06001691 RID: 5777 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170004E7")]
		public string Host
		{
			[Token(Token = "0x6001691")]
			[Address(RVA = "0x4E5A80", Offset = "0x4E4680", VA = "0x1804E5A80")]
			get
			{
				return null;
			}
		}

		// Token: 0x170004E8 RID: 1256
		// (get) Token: 0x06001692 RID: 5778 RVA: 0x0000A4B8 File Offset: 0x000086B8
		[Token(Token = "0x170004E8")]
		public int Port
		{
			[Token(Token = "0x6001692")]
			[Address(RVA = "0x4D6B920", Offset = "0x4D6A520", VA = "0x184D6B920")]
			get
			{
				return 0;
			}
		}

		// Token: 0x170004E9 RID: 1257
		// (get) Token: 0x06001693 RID: 5779 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170004E9")]
		public string Path
		{
			[Token(Token = "0x6001693")]
			[Address(RVA = "0x4E4070", Offset = "0x4E2C70", VA = "0x1804E4070")]
			get
			{
				return null;
			}
		}

		// Token: 0x06001694 RID: 5780 RVA: 0x0000A4D0 File Offset: 0x000086D0
		[Token(Token = "0x6001694")]
		[Address(RVA = "0x5085D20", Offset = "0x5084920", VA = "0x185085D20", Slot = "0")]
		public override bool Equals(object o)
		{
			return default(bool);
		}

		// Token: 0x06001695 RID: 5781 RVA: 0x0000A4E8 File Offset: 0x000086E8
		[Token(Token = "0x6001695")]
		[Address(RVA = "0x2824310", Offset = "0x2822F10", VA = "0x182824310", Slot = "2")]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06001696 RID: 5782 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001696")]
		[Address(RVA = "0x5085D90", Offset = "0x5084990", VA = "0x185085D90")]
		private void Parse(string uri)
		{
		}

		// Token: 0x06001697 RID: 5783 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001697")]
		[Address(RVA = "0x5085920", Offset = "0x5084520", VA = "0x185085920")]
		public static void CheckUri(string uri)
		{
		}

		// Token: 0x04000CB8 RID: 3256
		[Token(Token = "0x4000CB8")]
		[FieldOffset(Offset = "0x10")]
		private string original;

		// Token: 0x04000CB9 RID: 3257
		[Token(Token = "0x4000CB9")]
		[FieldOffset(Offset = "0x18")]
		private string host;

		// Token: 0x04000CBA RID: 3258
		[Token(Token = "0x4000CBA")]
		[FieldOffset(Offset = "0x20")]
		private ushort port;

		// Token: 0x04000CBB RID: 3259
		[Token(Token = "0x4000CBB")]
		[FieldOffset(Offset = "0x28")]
		private string path;

		// Token: 0x04000CBC RID: 3260
		[Token(Token = "0x4000CBC")]
		[FieldOffset(Offset = "0x30")]
		private bool secure;

		// Token: 0x04000CBD RID: 3261
		[Token(Token = "0x4000CBD")]
		[FieldOffset(Offset = "0x38")]
		public HttpListener Listener;
	}
}

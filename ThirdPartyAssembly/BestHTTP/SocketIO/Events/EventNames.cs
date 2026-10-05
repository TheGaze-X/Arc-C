using System;
using Il2CppDummyDll;

namespace BestHTTP.SocketIO.Events
{
	// Token: 0x02000529 RID: 1321
	[Token(Token = "0x2000529")]
	public static class EventNames
	{
		// Token: 0x06002BF9 RID: 11257 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002BF9")]
		[Address(RVA = "0x53E8DE0", Offset = "0x53E79E0", VA = "0x1853E8DE0")]
		public static string GetNameFor(SocketIOEventTypes type)
		{
			return null;
		}

		// Token: 0x06002BFA RID: 11258 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002BFA")]
		[Address(RVA = "0x53E8D60", Offset = "0x53E7960", VA = "0x1853E8D60")]
		public static string GetNameFor(TransportEventTypes transEvent)
		{
			return null;
		}

		// Token: 0x06002BFB RID: 11259 RVA: 0x00012960 File Offset: 0x00010B60
		[Token(Token = "0x6002BFB")]
		[Address(RVA = "0x53E8E60", Offset = "0x53E7A60", VA = "0x1853E8E60")]
		public static bool IsBlacklisted(string eventName)
		{
			return default(bool);
		}

		// Token: 0x040018DE RID: 6366
		[Token(Token = "0x40018DE")]
		public const string Connect = "connect";

		// Token: 0x040018DF RID: 6367
		[Token(Token = "0x40018DF")]
		public const string Disconnect = "disconnect";

		// Token: 0x040018E0 RID: 6368
		[Token(Token = "0x40018E0")]
		public const string Event = "event";

		// Token: 0x040018E1 RID: 6369
		[Token(Token = "0x40018E1")]
		public const string Ack = "ack";

		// Token: 0x040018E2 RID: 6370
		[Token(Token = "0x40018E2")]
		public const string Error = "error";

		// Token: 0x040018E3 RID: 6371
		[Token(Token = "0x40018E3")]
		public const string BinaryEvent = "binaryevent";

		// Token: 0x040018E4 RID: 6372
		[Token(Token = "0x40018E4")]
		public const string BinaryAck = "binaryack";

		// Token: 0x040018E5 RID: 6373
		[Token(Token = "0x40018E5")]
		[FieldOffset(Offset = "0x0")]
		private static string[] SocketIONames;

		// Token: 0x040018E6 RID: 6374
		[Token(Token = "0x40018E6")]
		[FieldOffset(Offset = "0x8")]
		private static string[] TransportNames;

		// Token: 0x040018E7 RID: 6375
		[Token(Token = "0x40018E7")]
		[FieldOffset(Offset = "0x10")]
		private static string[] BlacklistedEvents;
	}
}

using System;
using Il2CppDummyDll;

namespace UnityEngine
{
	// Token: 0x020000DB RID: 219
	[Token(Token = "0x20000DB")]
	internal interface IPlayerEditorConnectionNative
	{
		// Token: 0x0600088B RID: 2187
		[Token(Token = "0x600088B")]
		void Initialize();

		// Token: 0x0600088C RID: 2188
		[Token(Token = "0x600088C")]
		void DisconnectAll();

		// Token: 0x0600088D RID: 2189
		[Token(Token = "0x600088D")]
		void SendMessage(Guid messageId, byte[] data, int playerId);

		// Token: 0x0600088E RID: 2190
		[Token(Token = "0x600088E")]
		bool TrySendMessage(Guid messageId, byte[] data, int playerId);

		// Token: 0x0600088F RID: 2191
		[Token(Token = "0x600088F")]
		void Poll();

		// Token: 0x06000890 RID: 2192
		[Token(Token = "0x6000890")]
		void RegisterInternal(Guid messageId);

		// Token: 0x06000891 RID: 2193
		[Token(Token = "0x6000891")]
		void UnregisterInternal(Guid messageId);

		// Token: 0x06000892 RID: 2194
		[Token(Token = "0x6000892")]
		bool IsConnected();
	}
}

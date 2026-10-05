using System;
using Il2CppDummyDll;
using UnityEngine.Events;

namespace UnityEngine.Networking.PlayerConnection
{
	// Token: 0x02000234 RID: 564
	[Token(Token = "0x2000234")]
	public interface IEditorPlayerConnection
	{
		// Token: 0x06000D45 RID: 3397
		[Token(Token = "0x6000D45")]
		void Register(Guid messageId, UnityAction<MessageEventArgs> callback);

		// Token: 0x06000D46 RID: 3398
		[Token(Token = "0x6000D46")]
		void RegisterConnection(UnityAction<int> callback);

		// Token: 0x06000D47 RID: 3399
		[Token(Token = "0x6000D47")]
		void RegisterDisconnection(UnityAction<int> callback);

		// Token: 0x06000D48 RID: 3400
		[Token(Token = "0x6000D48")]
		void Send(Guid messageId, byte[] data);
	}
}

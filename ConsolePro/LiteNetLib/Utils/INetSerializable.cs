using System;
using Il2CppDummyDll;

namespace FlyingWormConsole3.LiteNetLib.Utils
{
	// Token: 0x02000046 RID: 70
	[Token(Token = "0x2000046")]
	public interface INetSerializable
	{
		// Token: 0x0600019D RID: 413
		[Token(Token = "0x600019D")]
		void Serialize(NetDataWriter writer);

		// Token: 0x0600019E RID: 414
		[Token(Token = "0x600019E")]
		void Deserialize(NetDataReader reader);
	}
}

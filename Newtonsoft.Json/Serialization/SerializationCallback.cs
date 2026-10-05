using System;
using System.Runtime.Serialization;
using Il2CppDummyDll;
using Newtonsoft.Json.Shims;

namespace Newtonsoft.Json.Serialization
{
	// Token: 0x0200009A RID: 154
	// (Invoke) Token: 0x06000550 RID: 1360
	[Token(Token = "0x200009A")]
	[Preserve]
	public delegate void SerializationCallback(object o, StreamingContext context);
}

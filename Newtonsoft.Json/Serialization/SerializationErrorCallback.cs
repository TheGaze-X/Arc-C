using System;
using System.Runtime.Serialization;
using Il2CppDummyDll;
using Newtonsoft.Json.Shims;

namespace Newtonsoft.Json.Serialization
{
	// Token: 0x0200009B RID: 155
	// (Invoke) Token: 0x06000554 RID: 1364
	[Token(Token = "0x200009B")]
	[Preserve]
	public delegate void SerializationErrorCallback(object o, StreamingContext context, ErrorContext errorContext);
}

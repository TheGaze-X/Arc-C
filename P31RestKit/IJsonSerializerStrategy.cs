using System;
using Il2CppDummyDll;

namespace Prime31
{
	// Token: 0x02000022 RID: 34
	[Token(Token = "0x2000022")]
	public interface IJsonSerializerStrategy
	{
		// Token: 0x060000D7 RID: 215
		[Token(Token = "0x60000D7")]
		bool serializeNonPrimitiveObject(object input, out object output);

		// Token: 0x060000D8 RID: 216
		[Token(Token = "0x60000D8")]
		object deserializeObject(object value, Type type);
	}
}

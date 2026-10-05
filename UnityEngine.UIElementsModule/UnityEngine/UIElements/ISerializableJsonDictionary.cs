using System;
using Il2CppDummyDll;

namespace UnityEngine.UIElements
{
	// Token: 0x0200003A RID: 58
	[Token(Token = "0x200003A")]
	internal interface ISerializableJsonDictionary
	{
		// Token: 0x0600013F RID: 319
		[Token(Token = "0x600013F")]
		void Set<T>(string key, T value) where T : class;

		// Token: 0x06000140 RID: 320
		[Token(Token = "0x6000140")]
		void Overwrite(object obj, string key);

		// Token: 0x06000141 RID: 321
		[Token(Token = "0x6000141")]
		bool ContainsKey(string key);
	}
}

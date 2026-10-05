using System;
using System.Collections;
using Il2CppDummyDll;

namespace LitJson
{
	// Token: 0x02000477 RID: 1143
	[Token(Token = "0x2000477")]
	public interface IOrderedDictionary : IDictionary, ICollection, IEnumerable
	{
		// Token: 0x0600247C RID: 9340
		[Token(Token = "0x600247C")]
		IDictionaryEnumerator GetEnumerator();

		// Token: 0x0600247D RID: 9341
		[Token(Token = "0x600247D")]
		void Insert(int index, object key, object value);

		// Token: 0x0600247E RID: 9342
		[Token(Token = "0x600247E")]
		void RemoveAt(int index);

		// Token: 0x170004D8 RID: 1240
		[Token(Token = "0x170004D8")]
		object this[int index]
		{
			[Token(Token = "0x600247F")]
			get;
			[Token(Token = "0x6002480")]
			set;
		}
	}
}

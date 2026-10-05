using System;
using Il2CppDummyDll;

namespace System.Collections.Specialized
{
	// Token: 0x0200023F RID: 575
	[Token(Token = "0x200023F")]
	public interface IOrderedDictionary : IDictionary, ICollection, IEnumerable
	{
		// Token: 0x17000319 RID: 793
		[Token(Token = "0x17000319")]
		object this[int index]
		{
			[Token(Token = "0x6000F9A")]
			get;
			[Token(Token = "0x6000F9B")]
			set;
		}

		// Token: 0x06000F9C RID: 3996
		[Token(Token = "0x6000F9C")]
		IDictionaryEnumerator GetEnumerator();

		// Token: 0x06000F9D RID: 3997
		[Token(Token = "0x6000F9D")]
		void Insert(int index, object key, object value);

		// Token: 0x06000F9E RID: 3998
		[Token(Token = "0x6000F9E")]
		void RemoveAt(int index);
	}
}

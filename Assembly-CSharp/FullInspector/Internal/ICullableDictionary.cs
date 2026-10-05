using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace FullInspector.Internal
{
	// Token: 0x02007C7E RID: 31870
	[Token(Token = "0x2007C7E")]
	public interface ICullableDictionary<TKey, TValue>
	{
		// Token: 0x1700683A RID: 26682
		[Token(Token = "0x1700683A")]
		TValue this[TKey key]
		{
			[Token(Token = "0x602C860")]
			get;
			[Token(Token = "0x602C861")]
			set;
		}

		// Token: 0x0602C862 RID: 182370
		[Token(Token = "0x602C862")]
		bool TryGetValue(TKey key, out TValue value);

		// Token: 0x0602C863 RID: 182371
		[Token(Token = "0x602C863")]
		void BeginCullZone();

		// Token: 0x0602C864 RID: 182372
		[Token(Token = "0x602C864")]
		void EndCullZone();

		// Token: 0x1700683B RID: 26683
		// (get) Token: 0x0602C865 RID: 182373
		[Token(Token = "0x1700683B")]
		IEnumerable<KeyValuePair<TKey, TValue>> Items { [Token(Token = "0x602C865")] get; }

		// Token: 0x1700683C RID: 26684
		// (get) Token: 0x0602C866 RID: 182374
		[Token(Token = "0x1700683C")]
		bool IsEmpty { [Token(Token = "0x602C866")] get; }
	}
}

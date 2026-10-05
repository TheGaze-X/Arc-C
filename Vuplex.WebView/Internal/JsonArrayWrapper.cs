using System;
using Il2CppDummyDll;

namespace Vuplex.WebView.Internal
{
	// Token: 0x02000087 RID: 135
	[Token(Token = "0x2000087")]
	[Serializable]
	public class JsonArrayWrapper<T>
	{
		// Token: 0x0600041B RID: 1051 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600041B")]
		public JsonArrayWrapper()
		{
		}

		// Token: 0x0600041C RID: 1052 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600041C")]
		public JsonArrayWrapper(T[] items)
		{
		}

		// Token: 0x040001E7 RID: 487
		[Token(Token = "0x40001E7")]
		[FieldOffset(Offset = "0x0")]
		public T[] Items;
	}
}

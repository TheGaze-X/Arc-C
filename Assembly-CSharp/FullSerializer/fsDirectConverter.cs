using System;
using Il2CppDummyDll;

namespace FullSerializer
{
	// Token: 0x02007B6F RID: 31599
	[Token(Token = "0x2007B6F")]
	public abstract class fsDirectConverter : fsBaseConverter
	{
		// Token: 0x170067A1 RID: 26529
		// (get) Token: 0x0602C3A2 RID: 181154
		[Token(Token = "0x170067A1")]
		public abstract Type ModelType { [Token(Token = "0x602C3A2")] get; }

		// Token: 0x0602C3A3 RID: 181155 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602C3A3")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		protected fsDirectConverter()
		{
		}
	}
}

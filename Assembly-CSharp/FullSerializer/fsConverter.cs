using System;
using Il2CppDummyDll;

namespace FullSerializer
{
	// Token: 0x02007B6C RID: 31596
	[Token(Token = "0x2007B6C")]
	public abstract class fsConverter : fsBaseConverter
	{
		// Token: 0x0602C37E RID: 181118
		[Token(Token = "0x602C37E")]
		public abstract bool CanProcess(Type type);

		// Token: 0x0602C37F RID: 181119 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602C37F")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		protected fsConverter()
		{
		}
	}
}

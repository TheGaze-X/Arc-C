using System;
using Il2CppDummyDll;

namespace System.Net
{
	// Token: 0x020002F1 RID: 753
	[Token(Token = "0x20002F1")]
	internal class FileWebRequestCreator : IWebRequestCreate
	{
		// Token: 0x060014E2 RID: 5346 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60014E2")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		internal FileWebRequestCreator()
		{
		}

		// Token: 0x060014E3 RID: 5347 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60014E3")]
		[Address(RVA = "0x5053A60", Offset = "0x5052660", VA = "0x185053A60", Slot = "4")]
		public WebRequest Create(Uri uri)
		{
			return null;
		}
	}
}

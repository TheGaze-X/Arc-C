using System;
using Il2CppDummyDll;

namespace UnityEngine.UI
{
	// Token: 0x02000098 RID: 152
	[Token(Token = "0x2000098")]
	public abstract class TextAspects
	{
		// Token: 0x060005B8 RID: 1464
		[Token(Token = "0x60005B8")]
		public abstract void ProcessTextToShow(Text text, ref string textToShow, ref bool textNotFound);

		// Token: 0x060005B9 RID: 1465
		[Token(Token = "0x60005B9")]
		public abstract void SetText(Text text, string textToShow, string value, out bool isVerticesDirty, out bool isLayoutDirty);

		// Token: 0x060005BA RID: 1466 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60005BA")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		protected TextAspects()
		{
		}
	}
}

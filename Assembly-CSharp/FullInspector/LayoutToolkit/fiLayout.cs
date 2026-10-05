using System;
using Il2CppDummyDll;
using UnityEngine;

namespace FullInspector.LayoutToolkit
{
	// Token: 0x02007C61 RID: 31841
	[Token(Token = "0x2007C61")]
	public abstract class fiLayout
	{
		// Token: 0x0602C802 RID: 182274
		[Token(Token = "0x602C802")]
		public abstract bool RespondsTo(string id);

		// Token: 0x0602C803 RID: 182275
		[Token(Token = "0x602C803")]
		public abstract Rect GetSectionRect(string id, Rect initial);

		// Token: 0x17006828 RID: 26664
		// (get) Token: 0x0602C804 RID: 182276
		[Token(Token = "0x17006828")]
		public abstract float Height { [Token(Token = "0x602C804")] get; }

		// Token: 0x0602C805 RID: 182277 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602C805")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		protected fiLayout()
		{
		}
	}
}

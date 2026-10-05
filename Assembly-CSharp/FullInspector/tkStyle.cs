using System;
using Il2CppDummyDll;

namespace FullInspector
{
	// Token: 0x02007C52 RID: 31826
	[Token(Token = "0x2007C52")]
	public abstract class tkStyle<T, TContext>
	{
		// Token: 0x0602C7C4 RID: 182212
		[Token(Token = "0x602C7C4")]
		public abstract void Activate(T obj, TContext context);

		// Token: 0x0602C7C5 RID: 182213
		[Token(Token = "0x602C7C5")]
		public abstract void Deactivate(T obj, TContext context);

		// Token: 0x0602C7C6 RID: 182214 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602C7C6")]
		protected tkStyle()
		{
		}
	}
}

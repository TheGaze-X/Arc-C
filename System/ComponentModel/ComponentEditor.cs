using System;
using Il2CppDummyDll;

namespace System.ComponentModel
{
	// Token: 0x02000174 RID: 372
	[Token(Token = "0x2000174")]
	public abstract class ComponentEditor
	{
		// Token: 0x0600096B RID: 2411 RVA: 0x000058E0 File Offset: 0x00003AE0
		[Token(Token = "0x600096B")]
		[Address(RVA = "0x513B130", Offset = "0x5139D30", VA = "0x18513B130")]
		public bool EditComponent(object component)
		{
			return default(bool);
		}

		// Token: 0x0600096C RID: 2412
		[Token(Token = "0x600096C")]
		public abstract bool EditComponent(ITypeDescriptorContext context, object component);

		// Token: 0x0600096D RID: 2413 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600096D")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		protected ComponentEditor()
		{
		}
	}
}

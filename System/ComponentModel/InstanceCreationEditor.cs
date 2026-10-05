using System;
using Il2CppDummyDll;

namespace System.ComponentModel
{
	// Token: 0x020001B3 RID: 435
	[Token(Token = "0x20001B3")]
	public abstract class InstanceCreationEditor
	{
		// Token: 0x17000240 RID: 576
		// (get) Token: 0x06000B20 RID: 2848 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000240")]
		public virtual string Text
		{
			[Token(Token = "0x6000B20")]
			[Address(RVA = "0x51472A0", Offset = "0x5145EA0", VA = "0x1851472A0", Slot = "4")]
			get
			{
				return null;
			}
		}

		// Token: 0x06000B21 RID: 2849
		[Token(Token = "0x6000B21")]
		public abstract object CreateInstance(ITypeDescriptorContext context, Type instanceType);

		// Token: 0x06000B22 RID: 2850 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000B22")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		protected InstanceCreationEditor()
		{
		}
	}
}

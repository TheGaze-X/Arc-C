using System;
using Il2CppDummyDll;

namespace CriWare.CriMana.Detail
{
	// Token: 0x02000147 RID: 327
	[Token(Token = "0x2000147")]
	[AttributeUsage(AttributeTargets.Class)]
	public class RendererResourceFactoryPriorityAttribute : Attribute
	{
		// Token: 0x060009EC RID: 2540 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60009EC")]
		[Address(RVA = "0x1FF21E0", Offset = "0x1FF0DE0", VA = "0x181FF21E0")]
		public RendererResourceFactoryPriorityAttribute(int priority)
		{
		}

		// Token: 0x0400060B RID: 1547
		[Token(Token = "0x400060B")]
		[FieldOffset(Offset = "0x10")]
		public readonly int priority;
	}
}

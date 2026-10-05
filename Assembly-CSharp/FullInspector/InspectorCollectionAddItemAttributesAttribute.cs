using System;
using System.Reflection;
using Il2CppDummyDll;

namespace FullInspector
{
	// Token: 0x02007BF0 RID: 31728
	[Token(Token = "0x2007BF0")]
	[AttributeUsage(AttributeTargets.Property | AttributeTargets.Field)]
	public sealed class InspectorCollectionAddItemAttributesAttribute : Attribute
	{
		// Token: 0x0602C658 RID: 181848 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602C658")]
		[Address(RVA = "0x2860DF0", Offset = "0x285F9F0", VA = "0x182860DF0")]
		public InspectorCollectionAddItemAttributesAttribute(Type attributes)
		{
		}

		// Token: 0x04040290 RID: 262800
		[Token(Token = "0x4040290")]
		[FieldOffset(Offset = "0x10")]
		public MemberInfo AttributeProvider;
	}
}

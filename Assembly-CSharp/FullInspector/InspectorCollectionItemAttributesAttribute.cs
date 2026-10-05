using System;
using System.Reflection;
using Il2CppDummyDll;

namespace FullInspector
{
	// Token: 0x02007BF1 RID: 31729
	[Token(Token = "0x2007BF1")]
	[AttributeUsage(AttributeTargets.Property | AttributeTargets.Field)]
	public sealed class InspectorCollectionItemAttributesAttribute : Attribute
	{
		// Token: 0x0602C659 RID: 181849 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602C659")]
		[Address(RVA = "0x2860FE0", Offset = "0x285FBE0", VA = "0x182860FE0")]
		public InspectorCollectionItemAttributesAttribute(Type attributes)
		{
		}

		// Token: 0x04040291 RID: 262801
		[Token(Token = "0x4040291")]
		[FieldOffset(Offset = "0x10")]
		public MemberInfo AttributeProvider;
	}
}

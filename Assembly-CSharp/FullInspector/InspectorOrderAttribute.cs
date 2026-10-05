using System;
using System.Reflection;
using Il2CppDummyDll;

namespace FullInspector
{
	// Token: 0x02007BB4 RID: 31668
	[Token(Token = "0x2007BB4")]
	[AttributeUsage(AttributeTargets.Method | AttributeTargets.Property | AttributeTargets.Field)]
	public sealed class InspectorOrderAttribute : Attribute
	{
		// Token: 0x0602C51F RID: 181535 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602C51F")]
		[Address(RVA = "0x2861660", Offset = "0x2860260", VA = "0x182861660")]
		public InspectorOrderAttribute(double order)
		{
		}

		// Token: 0x0602C520 RID: 181536 RVA: 0x000DF8F0 File Offset: 0x000DDAF0
		[Token(Token = "0x602C520")]
		[Address(RVA = "0x28615E0", Offset = "0x28601E0", VA = "0x1828615E0")]
		public static double GetInspectorOrder(MemberInfo memberInfo)
		{
			return 0.0;
		}

		// Token: 0x04040204 RID: 262660
		[Token(Token = "0x4040204")]
		[FieldOffset(Offset = "0x10")]
		public double Order;
	}
}

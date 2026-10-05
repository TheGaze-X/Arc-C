using System;
using Il2CppDummyDll;

namespace System.Runtime.InteropServices
{
	// Token: 0x02000472 RID: 1138
	[Token(Token = "0x2000472")]
	[System.AttributeUsage(System.AttributeTargets.Assembly, Inherited = false)]
	[ComVisible(true)]
	public sealed class ComCompatibleVersionAttribute : System.Attribute
	{
		// Token: 0x06002233 RID: 8755 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002233")]
		[Address(RVA = "0x4BB4950", Offset = "0x4BB3550", VA = "0x184BB4950")]
		public ComCompatibleVersionAttribute(int major, int minor, int build, int revision)
		{
		}

		// Token: 0x040013A0 RID: 5024
		[Token(Token = "0x40013A0")]
		[FieldOffset(Offset = "0x10")]
		internal int _major;

		// Token: 0x040013A1 RID: 5025
		[Token(Token = "0x40013A1")]
		[FieldOffset(Offset = "0x14")]
		internal int _minor;

		// Token: 0x040013A2 RID: 5026
		[Token(Token = "0x40013A2")]
		[FieldOffset(Offset = "0x18")]
		internal int _build;

		// Token: 0x040013A3 RID: 5027
		[Token(Token = "0x40013A3")]
		[FieldOffset(Offset = "0x1C")]
		internal int _revision;
	}
}

using System;
using System.Reflection;
using Il2CppDummyDll;
using UnityEngine.Bindings;
using UnityEngine.Scripting;

namespace UnityEngine.Rendering
{
	// Token: 0x0200026D RID: 621
	[Token(Token = "0x200026D")]
	[UsedByNativeCode]
	[DefaultMember("Item")]
	[NativeHeader("Runtime/Export/Math/SphericalHarmonicsL2.bindings.h")]
	public struct SphericalHarmonicsL2 : IEquatable<SphericalHarmonicsL2>
	{
		// Token: 0x06000DFD RID: 3581 RVA: 0x00006ED0 File Offset: 0x000050D0
		[Token(Token = "0x6000DFD")]
		[Address(RVA = "0x59877F0", Offset = "0x59863F0", VA = "0x1859877F0", Slot = "2")]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06000DFE RID: 3582 RVA: 0x00006EE8 File Offset: 0x000050E8
		[Token(Token = "0x6000DFE")]
		[Address(RVA = "0x59875D0", Offset = "0x59861D0", VA = "0x1859875D0", Slot = "0")]
		public override bool Equals(object other)
		{
			return default(bool);
		}

		// Token: 0x06000DFF RID: 3583 RVA: 0x00006F00 File Offset: 0x00005100
		[Token(Token = "0x6000DFF")]
		[Address(RVA = "0x5987730", Offset = "0x5986330", VA = "0x185987730", Slot = "4")]
		public bool Equals(SphericalHarmonicsL2 other)
		{
			return default(bool);
		}

		// Token: 0x06000E00 RID: 3584 RVA: 0x00006F18 File Offset: 0x00005118
		[Token(Token = "0x6000E00")]
		[Address(RVA = "0x59879C0", Offset = "0x59865C0", VA = "0x1859879C0")]
		public static bool operator ==(SphericalHarmonicsL2 lhs, SphericalHarmonicsL2 rhs)
		{
			return default(bool);
		}

		// Token: 0x04000751 RID: 1873
		[Token(Token = "0x4000751")]
		[FieldOffset(Offset = "0x0")]
		private float shr0;

		// Token: 0x04000752 RID: 1874
		[Token(Token = "0x4000752")]
		[FieldOffset(Offset = "0x4")]
		private float shr1;

		// Token: 0x04000753 RID: 1875
		[Token(Token = "0x4000753")]
		[FieldOffset(Offset = "0x8")]
		private float shr2;

		// Token: 0x04000754 RID: 1876
		[Token(Token = "0x4000754")]
		[FieldOffset(Offset = "0xC")]
		private float shr3;

		// Token: 0x04000755 RID: 1877
		[Token(Token = "0x4000755")]
		[FieldOffset(Offset = "0x10")]
		private float shr4;

		// Token: 0x04000756 RID: 1878
		[Token(Token = "0x4000756")]
		[FieldOffset(Offset = "0x14")]
		private float shr5;

		// Token: 0x04000757 RID: 1879
		[Token(Token = "0x4000757")]
		[FieldOffset(Offset = "0x18")]
		private float shr6;

		// Token: 0x04000758 RID: 1880
		[Token(Token = "0x4000758")]
		[FieldOffset(Offset = "0x1C")]
		private float shr7;

		// Token: 0x04000759 RID: 1881
		[Token(Token = "0x4000759")]
		[FieldOffset(Offset = "0x20")]
		private float shr8;

		// Token: 0x0400075A RID: 1882
		[Token(Token = "0x400075A")]
		[FieldOffset(Offset = "0x24")]
		private float shg0;

		// Token: 0x0400075B RID: 1883
		[Token(Token = "0x400075B")]
		[FieldOffset(Offset = "0x28")]
		private float shg1;

		// Token: 0x0400075C RID: 1884
		[Token(Token = "0x400075C")]
		[FieldOffset(Offset = "0x2C")]
		private float shg2;

		// Token: 0x0400075D RID: 1885
		[Token(Token = "0x400075D")]
		[FieldOffset(Offset = "0x30")]
		private float shg3;

		// Token: 0x0400075E RID: 1886
		[Token(Token = "0x400075E")]
		[FieldOffset(Offset = "0x34")]
		private float shg4;

		// Token: 0x0400075F RID: 1887
		[Token(Token = "0x400075F")]
		[FieldOffset(Offset = "0x38")]
		private float shg5;

		// Token: 0x04000760 RID: 1888
		[Token(Token = "0x4000760")]
		[FieldOffset(Offset = "0x3C")]
		private float shg6;

		// Token: 0x04000761 RID: 1889
		[Token(Token = "0x4000761")]
		[FieldOffset(Offset = "0x40")]
		private float shg7;

		// Token: 0x04000762 RID: 1890
		[Token(Token = "0x4000762")]
		[FieldOffset(Offset = "0x44")]
		private float shg8;

		// Token: 0x04000763 RID: 1891
		[Token(Token = "0x4000763")]
		[FieldOffset(Offset = "0x48")]
		private float shb0;

		// Token: 0x04000764 RID: 1892
		[Token(Token = "0x4000764")]
		[FieldOffset(Offset = "0x4C")]
		private float shb1;

		// Token: 0x04000765 RID: 1893
		[Token(Token = "0x4000765")]
		[FieldOffset(Offset = "0x50")]
		private float shb2;

		// Token: 0x04000766 RID: 1894
		[Token(Token = "0x4000766")]
		[FieldOffset(Offset = "0x54")]
		private float shb3;

		// Token: 0x04000767 RID: 1895
		[Token(Token = "0x4000767")]
		[FieldOffset(Offset = "0x58")]
		private float shb4;

		// Token: 0x04000768 RID: 1896
		[Token(Token = "0x4000768")]
		[FieldOffset(Offset = "0x5C")]
		private float shb5;

		// Token: 0x04000769 RID: 1897
		[Token(Token = "0x4000769")]
		[FieldOffset(Offset = "0x60")]
		private float shb6;

		// Token: 0x0400076A RID: 1898
		[Token(Token = "0x400076A")]
		[FieldOffset(Offset = "0x64")]
		private float shb7;

		// Token: 0x0400076B RID: 1899
		[Token(Token = "0x400076B")]
		[FieldOffset(Offset = "0x68")]
		private float shb8;
	}
}

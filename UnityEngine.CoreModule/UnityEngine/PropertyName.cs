using System;
using Il2CppDummyDll;
using UnityEngine.Scripting;

namespace UnityEngine
{
	// Token: 0x020000E9 RID: 233
	[Token(Token = "0x20000E9")]
	[UsedByNativeCode]
	public struct PropertyName : IEquatable<PropertyName>
	{
		// Token: 0x060008C1 RID: 2241 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60008C1")]
		[Address(RVA = "0x5950540", Offset = "0x594F140", VA = "0x185950540")]
		public PropertyName(string name)
		{
		}

		// Token: 0x060008C2 RID: 2242 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60008C2")]
		[Address(RVA = "0x8493B0", Offset = "0x847FB0", VA = "0x1808493B0")]
		public PropertyName(PropertyName other)
		{
		}

		// Token: 0x060008C3 RID: 2243 RVA: 0x00005A18 File Offset: 0x00003C18
		[Token(Token = "0x60008C3")]
		[Address(RVA = "0x59504D0", Offset = "0x594F0D0", VA = "0x1859504D0")]
		public static bool IsNullOrEmpty(PropertyName prop)
		{
			return default(bool);
		}

		// Token: 0x060008C4 RID: 2244 RVA: 0x00005A30 File Offset: 0x00003C30
		[Token(Token = "0x60008C4")]
		[Address(RVA = "0x59505A0", Offset = "0x594F1A0", VA = "0x1859505A0")]
		public static bool operator ==(PropertyName lhs, PropertyName rhs)
		{
			return default(bool);
		}

		// Token: 0x060008C5 RID: 2245 RVA: 0x00005A48 File Offset: 0x00003C48
		[Token(Token = "0x60008C5")]
		[Address(RVA = "0x566200", Offset = "0x564E00", VA = "0x180566200", Slot = "2")]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x060008C6 RID: 2246 RVA: 0x00005A60 File Offset: 0x00003C60
		[Token(Token = "0x60008C6")]
		[Address(RVA = "0x5950440", Offset = "0x594F040", VA = "0x185950440", Slot = "0")]
		public override bool Equals(object other)
		{
			return default(bool);
		}

		// Token: 0x060008C7 RID: 2247 RVA: 0x00005A78 File Offset: 0x00003C78
		[Token(Token = "0x60008C7")]
		[Address(RVA = "0x5921240", Offset = "0x591FE40", VA = "0x185921240", Slot = "4")]
		public bool Equals(PropertyName other)
		{
			return default(bool);
		}

		// Token: 0x060008C8 RID: 2248 RVA: 0x00005A90 File Offset: 0x00003C90
		[Token(Token = "0x60008C8")]
		[Address(RVA = "0x59503F0", Offset = "0x594EFF0", VA = "0x1859503F0")]
		public static implicit operator PropertyName(string name)
		{
			return default(PropertyName);
		}

		// Token: 0x060008C9 RID: 2249 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60008C9")]
		[Address(RVA = "0x59504E0", Offset = "0x594F0E0", VA = "0x1859504E0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x04000489 RID: 1161
		[Token(Token = "0x4000489")]
		[FieldOffset(Offset = "0x0")]
		internal int id;
	}
}

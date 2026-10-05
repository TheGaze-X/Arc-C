using System;
using Il2CppDummyDll;
using UnityEngine.Bindings;
using UnityEngine.Scripting;

namespace UnityEngine.XR
{
	// Token: 0x02000019 RID: 25
	[Token(Token = "0x2000019")]
	[NativeHeader("Modules/XR/Subsystems/Meshing/XRMeshBindings.h")]
	[UsedByNativeCode]
	public struct MeshId : IEquatable<MeshId>
	{
		// Token: 0x06000028 RID: 40 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000028")]
		[Address(RVA = "0x5BA30C0", Offset = "0x5BA1CC0", VA = "0x185BA30C0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06000029 RID: 41 RVA: 0x00002280 File Offset: 0x00000480
		[Token(Token = "0x6000029")]
		[Address(RVA = "0x5BA3090", Offset = "0x5BA1C90", VA = "0x185BA3090", Slot = "2")]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x0600002A RID: 42 RVA: 0x00002298 File Offset: 0x00000498
		[Token(Token = "0x600002A")]
		[Address(RVA = "0x5BA2FB0", Offset = "0x5BA1BB0", VA = "0x185BA2FB0", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		// Token: 0x0600002B RID: 43 RVA: 0x000022B0 File Offset: 0x000004B0
		[Token(Token = "0x600002B")]
		[Address(RVA = "0x5BA3070", Offset = "0x5BA1C70", VA = "0x185BA3070", Slot = "4")]
		public bool Equals(MeshId other)
		{
			return default(bool);
		}

		// Token: 0x04000069 RID: 105
		[Token(Token = "0x4000069")]
		[FieldOffset(Offset = "0x0")]
		private static MeshId s_InvalidId;

		// Token: 0x0400006A RID: 106
		[Token(Token = "0x400006A")]
		[FieldOffset(Offset = "0x0")]
		private ulong m_SubId1;

		// Token: 0x0400006B RID: 107
		[Token(Token = "0x400006B")]
		[FieldOffset(Offset = "0x8")]
		private ulong m_SubId2;
	}
}

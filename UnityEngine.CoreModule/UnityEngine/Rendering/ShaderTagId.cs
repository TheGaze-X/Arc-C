using System;
using Il2CppDummyDll;

namespace UnityEngine.Rendering
{
	// Token: 0x02000278 RID: 632
	[Token(Token = "0x2000278")]
	public struct ShaderTagId : IEquatable<ShaderTagId>
	{
		// Token: 0x06000E3C RID: 3644 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000E3C")]
		[Address(RVA = "0x59872C0", Offset = "0x5985EC0", VA = "0x1859872C0")]
		public ShaderTagId(string name)
		{
		}

		// Token: 0x06000E3D RID: 3645 RVA: 0x00006FF0 File Offset: 0x000051F0
		[Token(Token = "0x6000E3D")]
		[Address(RVA = "0x5987210", Offset = "0x5985E10", VA = "0x185987210", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		// Token: 0x06000E3E RID: 3646 RVA: 0x00007008 File Offset: 0x00005208
		[Token(Token = "0x6000E3E")]
		[Address(RVA = "0x5921240", Offset = "0x591FE40", VA = "0x185921240", Slot = "4")]
		public bool Equals(ShaderTagId other)
		{
			return default(bool);
		}

		// Token: 0x06000E3F RID: 3647 RVA: 0x00007020 File Offset: 0x00005220
		[Token(Token = "0x6000E3F")]
		[Address(RVA = "0x59872A0", Offset = "0x5985EA0", VA = "0x1859872A0", Slot = "2")]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x04000791 RID: 1937
		[Token(Token = "0x4000791")]
		[FieldOffset(Offset = "0x0")]
		private int m_Id;
	}
}

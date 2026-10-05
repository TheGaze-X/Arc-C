using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace UnityEngine.UIElements
{
	// Token: 0x02000212 RID: 530
	[Token(Token = "0x2000212")]
	internal struct TextureId
	{
		// Token: 0x06000E12 RID: 3602 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000E12")]
		[Address(RVA = "0x5B13E20", Offset = "0x5B12A20", VA = "0x185B13E20")]
		public TextureId(int index)
		{
		}

		// Token: 0x17000339 RID: 825
		// (get) Token: 0x06000E13 RID: 3603 RVA: 0x00006F78 File Offset: 0x00005178
		[Token(Token = "0x17000339")]
		public int index
		{
			[Token(Token = "0x6000E13")]
			[Address(RVA = "0x5B13E30", Offset = "0x5B12A30", VA = "0x185B13E30")]
			get
			{
				return 0;
			}
		}

		// Token: 0x06000E14 RID: 3604 RVA: 0x00006F90 File Offset: 0x00005190
		[Token(Token = "0x6000E14")]
		[Address(RVA = "0x5B13CD0", Offset = "0x5B128D0", VA = "0x185B13CD0")]
		public float ConvertToGpu()
		{
			return 0f;
		}

		// Token: 0x06000E15 RID: 3605 RVA: 0x00006FA8 File Offset: 0x000051A8
		[Token(Token = "0x6000E15")]
		[Address(RVA = "0x5B13D20", Offset = "0x5B12920", VA = "0x185B13D20", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		// Token: 0x06000E16 RID: 3606 RVA: 0x00006FC0 File Offset: 0x000051C0
		[Token(Token = "0x6000E16")]
		[Address(RVA = "0x5B13DC0", Offset = "0x5B129C0", VA = "0x185B13DC0", Slot = "2")]
		[MethodImpl(256)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06000E17 RID: 3607 RVA: 0x00006FD8 File Offset: 0x000051D8
		[Token(Token = "0x6000E17")]
		[Address(RVA = "0x59505A0", Offset = "0x594F1A0", VA = "0x1859505A0")]
		[MethodImpl(256)]
		public static bool operator ==(TextureId left, TextureId right)
		{
			return default(bool);
		}

		// Token: 0x06000E18 RID: 3608 RVA: 0x00006FF0 File Offset: 0x000051F0
		[Token(Token = "0x6000E18")]
		[Address(RVA = "0x5B13E40", Offset = "0x5B12A40", VA = "0x185B13E40")]
		[MethodImpl(256)]
		public static bool operator !=(TextureId left, TextureId right)
		{
			return default(bool);
		}

		// Token: 0x04000788 RID: 1928
		[Token(Token = "0x4000788")]
		[FieldOffset(Offset = "0x0")]
		private readonly int m_Index;

		// Token: 0x04000789 RID: 1929
		[Token(Token = "0x4000789")]
		[FieldOffset(Offset = "0x0")]
		public static readonly TextureId invalid;
	}
}

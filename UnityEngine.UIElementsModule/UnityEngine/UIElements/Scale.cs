using System;
using Il2CppDummyDll;

namespace UnityEngine.UIElements
{
	// Token: 0x0200022A RID: 554
	[Token(Token = "0x200022A")]
	public struct Scale : IEquatable<Scale>
	{
		// Token: 0x06000F7A RID: 3962 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000F7A")]
		[Address(RVA = "0x5B202D0", Offset = "0x5B1EED0", VA = "0x185B202D0")]
		public Scale(Vector3 scale)
		{
		}

		// Token: 0x06000F7B RID: 3963 RVA: 0x000083A0 File Offset: 0x000065A0
		[Token(Token = "0x6000F7B")]
		[Address(RVA = "0x5B20190", Offset = "0x5B1ED90", VA = "0x185B20190")]
		internal static Scale Initial()
		{
			return default(Scale);
		}

		// Token: 0x06000F7C RID: 3964 RVA: 0x000083B8 File Offset: 0x000065B8
		[Token(Token = "0x6000F7C")]
		[Address(RVA = "0x5B20220", Offset = "0x5B1EE20", VA = "0x185B20220")]
		public static Scale None()
		{
			return default(Scale);
		}

		// Token: 0x170003C6 RID: 966
		// (get) Token: 0x06000F7D RID: 3965 RVA: 0x000083D0 File Offset: 0x000065D0
		[Token(Token = "0x170003C6")]
		public Vector3 value
		{
			[Token(Token = "0x6000F7D")]
			[Address(RVA = "0x361F7D0", Offset = "0x361E3D0", VA = "0x18361F7D0")]
			get
			{
				return default(Vector3);
			}
		}

		// Token: 0x06000F7E RID: 3966 RVA: 0x000083E8 File Offset: 0x000065E8
		[Token(Token = "0x6000F7E")]
		[Address(RVA = "0x5B20310", Offset = "0x5B1EF10", VA = "0x185B20310")]
		public static bool operator ==(Scale lhs, Scale rhs)
		{
			return default(bool);
		}

		// Token: 0x06000F7F RID: 3967 RVA: 0x00008400 File Offset: 0x00006600
		[Token(Token = "0x6000F7F")]
		[Address(RVA = "0x5B20380", Offset = "0x5B1EF80", VA = "0x185B20380")]
		public static bool operator !=(Scale lhs, Scale rhs)
		{
			return default(bool);
		}

		// Token: 0x06000F80 RID: 3968 RVA: 0x00008418 File Offset: 0x00006618
		[Token(Token = "0x6000F80")]
		[Address(RVA = "0x5B20010", Offset = "0x5B1EC10", VA = "0x185B20010", Slot = "4")]
		public bool Equals(Scale other)
		{
			return default(bool);
		}

		// Token: 0x06000F81 RID: 3969 RVA: 0x00008430 File Offset: 0x00006630
		[Token(Token = "0x6000F81")]
		[Address(RVA = "0x5B20060", Offset = "0x5B1EC60", VA = "0x185B20060", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		// Token: 0x06000F82 RID: 3970 RVA: 0x00008448 File Offset: 0x00006648
		[Token(Token = "0x6000F82")]
		[Address(RVA = "0x5B20130", Offset = "0x5B1ED30", VA = "0x185B20130", Slot = "2")]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06000F83 RID: 3971 RVA: 0x0000212A File Offset: 0x0000032A
		[Token(Token = "0x6000F83")]
		[Address(RVA = "0x5B202C0", Offset = "0x5B1EEC0", VA = "0x185B202C0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x0400080B RID: 2059
		[Token(Token = "0x400080B")]
		[FieldOffset(Offset = "0x0")]
		private Vector3 m_Scale;

		// Token: 0x0400080C RID: 2060
		[Token(Token = "0x400080C")]
		[FieldOffset(Offset = "0xC")]
		private bool m_IsNone;
	}
}

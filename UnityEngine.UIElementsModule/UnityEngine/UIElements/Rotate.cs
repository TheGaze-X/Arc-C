using System;
using Il2CppDummyDll;

namespace UnityEngine.UIElements
{
	// Token: 0x02000229 RID: 553
	[Token(Token = "0x2000229")]
	public struct Rotate : IEquatable<Rotate>
	{
		// Token: 0x06000F6D RID: 3949 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000F6D")]
		[Address(RVA = "0x5B1FDE0", Offset = "0x5B1E9E0", VA = "0x185B1FDE0")]
		public Rotate(Angle angle)
		{
		}

		// Token: 0x06000F6E RID: 3950 RVA: 0x000082B0 File Offset: 0x000064B0
		[Token(Token = "0x6000F6E")]
		[Address(RVA = "0x5B1FBF0", Offset = "0x5B1E7F0", VA = "0x185B1FBF0")]
		internal static Rotate Initial()
		{
			return default(Rotate);
		}

		// Token: 0x06000F6F RID: 3951 RVA: 0x000082C8 File Offset: 0x000064C8
		[Token(Token = "0x6000F6F")]
		[Address(RVA = "0x5B1FC80", Offset = "0x5B1E880", VA = "0x185B1FC80")]
		public static Rotate None()
		{
			return default(Rotate);
		}

		// Token: 0x170003C4 RID: 964
		// (get) Token: 0x06000F70 RID: 3952 RVA: 0x000082E0 File Offset: 0x000064E0
		// (set) Token: 0x06000F71 RID: 3953 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170003C4")]
		public Angle angle
		{
			[Token(Token = "0x6000F70")]
			[Address(RVA = "0x925550", Offset = "0x924150", VA = "0x180925550")]
			get
			{
				return default(Angle);
			}
			[Token(Token = "0x6000F71")]
			[Address(RVA = "0x925680", Offset = "0x924280", VA = "0x180925680")]
			set
			{
			}
		}

		// Token: 0x170003C5 RID: 965
		// (get) Token: 0x06000F72 RID: 3954 RVA: 0x000082F8 File Offset: 0x000064F8
		[Token(Token = "0x170003C5")]
		internal Vector3 axis
		{
			[Token(Token = "0x6000F72")]
			[Address(RVA = "0x40076E0", Offset = "0x40062E0", VA = "0x1840076E0")]
			get
			{
				return default(Vector3);
			}
		}

		// Token: 0x06000F73 RID: 3955 RVA: 0x00008310 File Offset: 0x00006510
		[Token(Token = "0x6000F73")]
		[Address(RVA = "0x5B1FE30", Offset = "0x5B1EA30", VA = "0x185B1FE30")]
		public static bool operator ==(Rotate lhs, Rotate rhs)
		{
			return default(bool);
		}

		// Token: 0x06000F74 RID: 3956 RVA: 0x00008328 File Offset: 0x00006528
		[Token(Token = "0x6000F74")]
		[Address(RVA = "0x5B1FF20", Offset = "0x5B1EB20", VA = "0x185B1FF20")]
		public static bool operator !=(Rotate lhs, Rotate rhs)
		{
			return default(bool);
		}

		// Token: 0x06000F75 RID: 3957 RVA: 0x00008340 File Offset: 0x00006540
		[Token(Token = "0x6000F75")]
		[Address(RVA = "0x5B1FA50", Offset = "0x5B1E650", VA = "0x185B1FA50", Slot = "4")]
		public bool Equals(Rotate other)
		{
			return default(bool);
		}

		// Token: 0x06000F76 RID: 3958 RVA: 0x00008358 File Offset: 0x00006558
		[Token(Token = "0x6000F76")]
		[Address(RVA = "0x5B1F9B0", Offset = "0x5B1E5B0", VA = "0x185B1F9B0", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		// Token: 0x06000F77 RID: 3959 RVA: 0x00008370 File Offset: 0x00006570
		[Token(Token = "0x6000F77")]
		[Address(RVA = "0x5B1FB20", Offset = "0x5B1E720", VA = "0x185B1FB20", Slot = "2")]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06000F78 RID: 3960 RVA: 0x0000212A File Offset: 0x0000032A
		[Token(Token = "0x6000F78")]
		[Address(RVA = "0x5B1FD80", Offset = "0x5B1E980", VA = "0x185B1FD80", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06000F79 RID: 3961 RVA: 0x00008388 File Offset: 0x00006588
		[Token(Token = "0x6000F79")]
		[Address(RVA = "0x5B1FD20", Offset = "0x5B1E920", VA = "0x185B1FD20")]
		internal Quaternion ToQuaternion()
		{
			return default(Quaternion);
		}

		// Token: 0x04000808 RID: 2056
		[Token(Token = "0x4000808")]
		[FieldOffset(Offset = "0x0")]
		private Angle m_Angle;

		// Token: 0x04000809 RID: 2057
		[Token(Token = "0x4000809")]
		[FieldOffset(Offset = "0x8")]
		private Vector3 m_Axis;

		// Token: 0x0400080A RID: 2058
		[Token(Token = "0x400080A")]
		[FieldOffset(Offset = "0x14")]
		private bool m_IsNone;
	}
}

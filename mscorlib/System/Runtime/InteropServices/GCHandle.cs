using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace System.Runtime.InteropServices
{
	// Token: 0x02000476 RID: 1142
	[Token(Token = "0x2000476")]
	[ComVisible(true)]
	public struct GCHandle
	{
		// Token: 0x06002248 RID: 8776 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002248")]
		[Address(RVA = "0x925680", Offset = "0x924280", VA = "0x180925680")]
		private GCHandle(System.IntPtr h)
		{
		}

		// Token: 0x06002249 RID: 8777 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002249")]
		[Address(RVA = "0x4BB5480", Offset = "0x4BB4080", VA = "0x184BB5480")]
		private GCHandle(object obj)
		{
		}

		// Token: 0x0600224A RID: 8778 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600224A")]
		[Address(RVA = "0x4BB5410", Offset = "0x4BB4010", VA = "0x184BB5410")]
		internal GCHandle(object value, GCHandleType type)
		{
		}

		// Token: 0x1700046E RID: 1134
		// (get) Token: 0x0600224B RID: 8779 RVA: 0x00013C20 File Offset: 0x00011E20
		[Token(Token = "0x1700046E")]
		public bool IsAllocated
		{
			[Token(Token = "0x600224B")]
			[Address(RVA = "0x4BB54E0", Offset = "0x4BB40E0", VA = "0x184BB54E0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700046F RID: 1135
		// (get) Token: 0x0600224C RID: 8780 RVA: 0x000020CA File Offset: 0x000002CA
		// (set) Token: 0x0600224D RID: 8781 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700046F")]
		public object Target
		{
			[Token(Token = "0x600224C")]
			[Address(RVA = "0x4BB5530", Offset = "0x4BB4130", VA = "0x184BB5530")]
			get
			{
				return null;
			}
			[Token(Token = "0x600224D")]
			[Address(RVA = "0x4BB55E0", Offset = "0x4BB41E0", VA = "0x184BB55E0")]
			set
			{
			}
		}

		// Token: 0x0600224E RID: 8782 RVA: 0x00013C38 File Offset: 0x00011E38
		[Token(Token = "0x600224E")]
		[Address(RVA = "0x4BB4FA0", Offset = "0x4BB3BA0", VA = "0x184BB4FA0")]
		public System.IntPtr AddrOfPinnedObject()
		{
			return 0;
		}

		// Token: 0x0600224F RID: 8783 RVA: 0x00013C50 File Offset: 0x00011E50
		[Token(Token = "0x600224F")]
		[Address(RVA = "0x4BB5100", Offset = "0x4BB3D00", VA = "0x184BB5100")]
		public static GCHandle Alloc(object value)
		{
			return default(GCHandle);
		}

		// Token: 0x06002250 RID: 8784 RVA: 0x00013C68 File Offset: 0x00011E68
		[Token(Token = "0x6002250")]
		[Address(RVA = "0x4BB50A0", Offset = "0x4BB3CA0", VA = "0x184BB50A0")]
		public static GCHandle Alloc(object value, GCHandleType type)
		{
			return default(GCHandle);
		}

		// Token: 0x06002251 RID: 8785 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002251")]
		[Address(RVA = "0x4BB5200", Offset = "0x4BB3E00", VA = "0x184BB5200")]
		public void Free()
		{
		}

		// Token: 0x06002252 RID: 8786 RVA: 0x00013C80 File Offset: 0x00011E80
		[Token(Token = "0x6002252")]
		[Address(RVA = "0xEB5120", Offset = "0xEB3D20", VA = "0x180EB5120")]
		public static explicit operator System.IntPtr(GCHandle value)
		{
			return 0;
		}

		// Token: 0x06002253 RID: 8787 RVA: 0x00013C98 File Offset: 0x00011E98
		[Token(Token = "0x6002253")]
		[Address(RVA = "0x4BB52E0", Offset = "0x4BB3EE0", VA = "0x184BB52E0")]
		public static explicit operator GCHandle(System.IntPtr value)
		{
			return default(GCHandle);
		}

		// Token: 0x06002254 RID: 8788
		[Token(Token = "0x6002254")]
		[Address(RVA = "0x4BB5150", Offset = "0x4BB3D50", VA = "0x184BB5150")]
		[MethodImpl(4096)]
		private static extern bool CheckCurrentDomain(System.IntPtr handle);

		// Token: 0x06002255 RID: 8789
		[Token(Token = "0x6002255")]
		[Address(RVA = "0x4BB5400", Offset = "0x4BB4000", VA = "0x184BB5400")]
		[MethodImpl(4096)]
		private static extern object GetTarget(System.IntPtr handle);

		// Token: 0x06002256 RID: 8790
		[Token(Token = "0x6002256")]
		[Address(RVA = "0x4BB53F0", Offset = "0x4BB3FF0", VA = "0x184BB53F0")]
		[MethodImpl(4096)]
		private static extern System.IntPtr GetTargetHandle(object obj, System.IntPtr handle, GCHandleType type);

		// Token: 0x06002257 RID: 8791
		[Token(Token = "0x6002257")]
		[Address(RVA = "0x4BB51F0", Offset = "0x4BB3DF0", VA = "0x184BB51F0")]
		[MethodImpl(4096)]
		private static extern void FreeHandle(System.IntPtr handle);

		// Token: 0x06002258 RID: 8792
		[Token(Token = "0x6002258")]
		[Address(RVA = "0x4BB53E0", Offset = "0x4BB3FE0", VA = "0x184BB53E0")]
		[MethodImpl(4096)]
		private static extern System.IntPtr GetAddrOfPinnedObject(System.IntPtr handle);

		// Token: 0x06002259 RID: 8793 RVA: 0x00013CB0 File Offset: 0x00011EB0
		[Token(Token = "0x6002259")]
		[Address(RVA = "0x7E7450", Offset = "0x7E6050", VA = "0x1807E7450")]
		public static bool operator ==(GCHandle a, GCHandle b)
		{
			return default(bool);
		}

		// Token: 0x0600225A RID: 8794 RVA: 0x00013CC8 File Offset: 0x00011EC8
		[Token(Token = "0x600225A")]
		[Address(RVA = "0x4BB5160", Offset = "0x4BB3D60", VA = "0x184BB5160", Slot = "0")]
		public override bool Equals(object o)
		{
			return default(bool);
		}

		// Token: 0x0600225B RID: 8795 RVA: 0x00013CE0 File Offset: 0x00011EE0
		[Token(Token = "0x600225B")]
		[Address(RVA = "0x4AB0F20", Offset = "0x4AAFB20", VA = "0x184AB0F20", Slot = "2")]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x0600225C RID: 8796 RVA: 0x00013CF8 File Offset: 0x00011EF8
		[Token(Token = "0x600225C")]
		[Address(RVA = "0x4BB52E0", Offset = "0x4BB3EE0", VA = "0x184BB52E0")]
		public static GCHandle FromIntPtr(System.IntPtr value)
		{
			return default(GCHandle);
		}

		// Token: 0x0600225D RID: 8797 RVA: 0x00013D10 File Offset: 0x00011F10
		[Token(Token = "0x600225D")]
		[Address(RVA = "0xEB5120", Offset = "0xEB3D20", VA = "0x180EB5120")]
		public static System.IntPtr ToIntPtr(GCHandle value)
		{
			return 0;
		}

		// Token: 0x040013B3 RID: 5043
		[Token(Token = "0x40013B3")]
		[FieldOffset(Offset = "0x0")]
		private System.IntPtr handle;
	}
}

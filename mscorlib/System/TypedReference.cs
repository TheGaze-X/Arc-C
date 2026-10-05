using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;
using Il2CppDummyDll;

namespace System
{
	// Token: 0x02000192 RID: 402
	[Token(Token = "0x2000192")]
	[System.CLSCompliant(false)]
	[System.Runtime.InteropServices.ComVisible(true)]
	[NonVersionable]
	public ref struct TypedReference
	{
		// Token: 0x06000F12 RID: 3858 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6000F12")]
		[Address(RVA = "0x4D45610", Offset = "0x4D44210", VA = "0x184D45610")]
		[System.CLSCompliant(false)]
		public static System.TypedReference MakeTypedReference(object target, System.Reflection.FieldInfo[] flds)
		{
			return null;
		}

		// Token: 0x06000F13 RID: 3859
		[Token(Token = "0x6000F13")]
		[Address(RVA = "0x4D45600", Offset = "0x4D44200", VA = "0x184D45600")]
		[MethodImpl(4096)]
		private unsafe static extern void InternalMakeTypedReference(void* result, object target, System.IntPtr[] flds, RuntimeType lastFieldType);

		// Token: 0x06000F14 RID: 3860 RVA: 0x0000CFC0 File Offset: 0x0000B1C0
		[Token(Token = "0x6000F14")]
		[Address(RVA = "0x4D45540", Offset = "0x4D44140", VA = "0x184D45540", Slot = "2")]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06000F15 RID: 3861 RVA: 0x0000CFD8 File Offset: 0x0000B1D8
		[Token(Token = "0x6000F15")]
		[Address(RVA = "0x4D454D0", Offset = "0x4D440D0", VA = "0x184D454D0", Slot = "0")]
		public override bool Equals(object o)
		{
			return default(bool);
		}

		// Token: 0x17000150 RID: 336
		// (get) Token: 0x06000F16 RID: 3862 RVA: 0x0000CFF0 File Offset: 0x0000B1F0
		[Token(Token = "0x17000150")]
		internal bool IsNull
		{
			[Token(Token = "0x6000F16")]
			[Address(RVA = "0x4D45BF0", Offset = "0x4D447F0", VA = "0x184D45BF0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06000F17 RID: 3863 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000F17")]
		[Address(RVA = "0x4D45B90", Offset = "0x4D44790", VA = "0x184D45B90")]
		[System.CLSCompliant(false)]
		public static void SetTypedReference(System.TypedReference target, object value)
		{
		}

		// Token: 0x040006BF RID: 1727
		[Token(Token = "0x40006BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private System.RuntimeTypeHandle type;

		// Token: 0x040006C0 RID: 1728
		[Token(Token = "0x40006C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private System.IntPtr Value;

		// Token: 0x040006C1 RID: 1729
		[Token(Token = "0x40006C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private System.IntPtr Type;
	}
}

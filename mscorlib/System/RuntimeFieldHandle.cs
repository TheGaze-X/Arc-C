using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.ConstrainedExecution;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using Il2CppDummyDll;

namespace System
{
	// Token: 0x020001BD RID: 445
	[Token(Token = "0x20001BD")]
	[System.Runtime.InteropServices.ComVisible(true)]
	[System.Serializable]
	public struct RuntimeFieldHandle : System.Runtime.Serialization.ISerializable
	{
		// Token: 0x0600102E RID: 4142 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600102E")]
		[Address(RVA = "0x925680", Offset = "0x924280", VA = "0x180925680")]
		internal RuntimeFieldHandle(System.IntPtr v)
		{
		}

		// Token: 0x0600102F RID: 4143 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600102F")]
		[Address(RVA = "0x4D3D3B0", Offset = "0x4D3BFB0", VA = "0x184D3D3B0")]
		private RuntimeFieldHandle(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context)
		{
		}

		// Token: 0x17000175 RID: 373
		// (get) Token: 0x06001030 RID: 4144 RVA: 0x0000D4E8 File Offset: 0x0000B6E8
		[Token(Token = "0x17000175")]
		public System.IntPtr Value
		{
			[Token(Token = "0x6001030")]
			[Address(RVA = "0x925550", Offset = "0x924150", VA = "0x180925550")]
			get
			{
				return 0;
			}
		}

		// Token: 0x06001031 RID: 4145 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001031")]
		[Address(RVA = "0x4D3D190", Offset = "0x4D3BD90", VA = "0x184D3D190", Slot = "4")]
		public void GetObjectData(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context)
		{
		}

		// Token: 0x06001032 RID: 4146 RVA: 0x0000D500 File Offset: 0x0000B700
		[Token(Token = "0x6001032")]
		[Address(RVA = "0x4D3D0A0", Offset = "0x4D3BCA0", VA = "0x184D3D0A0", Slot = "0")]
		[System.Runtime.ConstrainedExecution.ReliabilityContract(System.Runtime.ConstrainedExecution.Consistency.WillNotCorruptState, System.Runtime.ConstrainedExecution.Cer.Success)]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		// Token: 0x06001033 RID: 4147 RVA: 0x0000D518 File Offset: 0x0000B718
		[Token(Token = "0x6001033")]
		[Address(RVA = "0x849260", Offset = "0x847E60", VA = "0x180849260", Slot = "2")]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06001034 RID: 4148
		[Token(Token = "0x6001034")]
		[Address(RVA = "0x4D3D3A0", Offset = "0x4D3BFA0", VA = "0x184D3D3A0")]
		[MethodImpl(4096)]
		private static extern void SetValueInternal(System.Reflection.FieldInfo fi, object obj, object value);

		// Token: 0x06001035 RID: 4149 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001035")]
		[Address(RVA = "0x4D3D3A0", Offset = "0x4D3BFA0", VA = "0x184D3D3A0")]
		internal static void SetValue(RuntimeFieldInfo field, object obj, object value, RuntimeType fieldType, System.Reflection.FieldAttributes fieldAttr, RuntimeType declaringType, ref bool domainInitialized)
		{
		}

		// Token: 0x06001036 RID: 4150
		[Token(Token = "0x6001036")]
		[Address(RVA = "0x4D3D390", Offset = "0x4D3BF90", VA = "0x184D3D390")]
		[MethodImpl(4096)]
		internal unsafe static extern void SetValueDirect(RuntimeFieldInfo field, RuntimeType fieldType, void* pTypedRef, object value, RuntimeType contextType);

		// Token: 0x04000783 RID: 1923
		[Token(Token = "0x4000783")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private System.IntPtr value;
	}
}

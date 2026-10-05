using System;
using System.Runtime.CompilerServices;
using System.Runtime.ConstrainedExecution;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace System
{
	// Token: 0x020001BA RID: 442
	[Token(Token = "0x20001BA")]
	[System.Runtime.InteropServices.ComVisible(true)]
	[System.Runtime.InteropServices.ClassInterface(System.Runtime.InteropServices.ClassInterfaceType.AutoDual)]
	[System.Serializable]
	public class Object
	{
		// Token: 0x06001022 RID: 4130 RVA: 0x0000D488 File Offset: 0x0000B688
		[Token(Token = "0x6001022")]
		[Address(RVA = "0x3D28B20", Offset = "0x3D27720", VA = "0x183D28B20", Slot = "0")]
		public virtual bool Equals(object obj)
		{
			return default(bool);
		}

		// Token: 0x06001023 RID: 4131 RVA: 0x0000D4A0 File Offset: 0x0000B6A0
		[Token(Token = "0x6001023")]
		[Address(RVA = "0x4ED030", Offset = "0x4EBC30", VA = "0x1804ED030")]
		public static bool Equals(object objA, object objB)
		{
			return default(bool);
		}

		// Token: 0x06001024 RID: 4132 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001024")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70")]
		[System.Runtime.ConstrainedExecution.ReliabilityContract(System.Runtime.ConstrainedExecution.Consistency.WillNotCorruptState, System.Runtime.ConstrainedExecution.Cer.MayFail)]
		public Object()
		{
		}

		// Token: 0x06001025 RID: 4133 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001025")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70", Slot = "1")]
		[System.Runtime.ConstrainedExecution.ReliabilityContract(System.Runtime.ConstrainedExecution.Consistency.WillNotCorruptState, System.Runtime.ConstrainedExecution.Cer.Success)]
		protected virtual void Finalize()
		{
		}

		// Token: 0x06001026 RID: 4134 RVA: 0x0000D4B8 File Offset: 0x0000B6B8
		[Token(Token = "0x6001026")]
		[Address(RVA = "0x4D3BA00", Offset = "0x4D3A600", VA = "0x184D3BA00", Slot = "2")]
		public virtual int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06001027 RID: 4135
		[Token(Token = "0x6001027")]
		[Address(RVA = "0x4D3BA10", Offset = "0x4D3A610", VA = "0x184D3BA10")]
		[MethodImpl(4096)]
		public extern System.Type GetType();

		// Token: 0x06001028 RID: 4136
		[Token(Token = "0x6001028")]
		[Address(RVA = "0x4D31AC0", Offset = "0x4D306C0", VA = "0x184D31AC0")]
		[MethodImpl(4096)]
		protected extern object MemberwiseClone();

		// Token: 0x06001029 RID: 4137 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6001029")]
		[Address(RVA = "0x4D3BA20", Offset = "0x4D3A620", VA = "0x184D3BA20", Slot = "3")]
		public virtual string ToString()
		{
			return null;
		}

		// Token: 0x0600102A RID: 4138 RVA: 0x0000D4D0 File Offset: 0x0000B6D0
		[Token(Token = "0x600102A")]
		[Address(RVA = "0x3D28B20", Offset = "0x3D27720", VA = "0x183D28B20")]
		[System.Runtime.ConstrainedExecution.ReliabilityContract(System.Runtime.ConstrainedExecution.Consistency.WillNotCorruptState, System.Runtime.ConstrainedExecution.Cer.Success)]
		public static bool ReferenceEquals(object objA, object objB)
		{
			return default(bool);
		}

		// Token: 0x0600102B RID: 4139
		[Token(Token = "0x600102B")]
		[Address(RVA = "0x4D3BA00", Offset = "0x4D3A600", VA = "0x184D3BA00")]
		[MethodImpl(4096)]
		internal static extern int InternalGetHashCode(object o);

		// Token: 0x0600102C RID: 4140 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600102C")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70")]
		private void FieldGetter(string typeName, string fieldName, ref object val)
		{
		}

		// Token: 0x0600102D RID: 4141 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600102D")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70")]
		private void FieldSetter(string typeName, string fieldName, object val)
		{
		}
	}
}

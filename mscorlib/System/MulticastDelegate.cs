using System;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using Il2CppDummyDll;

namespace System
{
	// Token: 0x020001B8 RID: 440
	[Token(Token = "0x20001B8")]
	[System.Runtime.InteropServices.ComVisible(true)]
	[System.Serializable]
	[StructLayout(0)]
	public abstract class MulticastDelegate : System.Delegate
	{
		// Token: 0x06001016 RID: 4118 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001016")]
		[Address(RVA = "0x4D33C40", Offset = "0x4D32840", VA = "0x184D33C40", Slot = "9")]
		public override void GetObjectData(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context)
		{
		}

		// Token: 0x06001017 RID: 4119 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6001017")]
		[Address(RVA = "0x4D3AEE0", Offset = "0x4D39AE0", VA = "0x184D3AEE0", Slot = "6")]
		protected sealed override object DynamicInvokeImpl(object[] args)
		{
			return null;
		}

		// Token: 0x06001018 RID: 4120 RVA: 0x0000D428 File Offset: 0x0000B628
		[Token(Token = "0x6001018")]
		[Address(RVA = "0x4D3AFA0", Offset = "0x4D39BA0", VA = "0x184D3AFA0", Slot = "0")]
		public sealed override bool Equals(object obj)
		{
			return default(bool);
		}

		// Token: 0x06001019 RID: 4121 RVA: 0x0000D440 File Offset: 0x0000B640
		[Token(Token = "0x6001019")]
		[Address(RVA = "0x4D33A20", Offset = "0x4D32620", VA = "0x184D33A20", Slot = "2")]
		public sealed override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x0600101A RID: 4122 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x600101A")]
		[Address(RVA = "0x4D3B230", Offset = "0x4D39E30", VA = "0x184D3B230", Slot = "8")]
		protected override System.Reflection.MethodInfo GetMethodImpl()
		{
			return null;
		}

		// Token: 0x0600101B RID: 4123 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x600101B")]
		[Address(RVA = "0x4D3B150", Offset = "0x4D39D50", VA = "0x184D3B150", Slot = "10")]
		public sealed override System.Delegate[] GetInvocationList()
		{
			return null;
		}

		// Token: 0x0600101C RID: 4124 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x600101C")]
		[Address(RVA = "0x4D3AB20", Offset = "0x4D39720", VA = "0x184D3AB20", Slot = "11")]
		protected sealed override System.Delegate CombineImpl(System.Delegate follow)
		{
			return null;
		}

		// Token: 0x0600101D RID: 4125 RVA: 0x0000D458 File Offset: 0x0000B658
		[Token(Token = "0x600101D")]
		[Address(RVA = "0x4D3B350", Offset = "0x4D39F50", VA = "0x184D3B350")]
		private int LastIndexOf(System.Delegate[] haystack, System.Delegate[] needle)
		{
			return 0;
		}

		// Token: 0x0600101E RID: 4126 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x600101E")]
		[Address(RVA = "0x4D3B490", Offset = "0x4D3A090", VA = "0x184D3B490", Slot = "12")]
		protected sealed override System.Delegate RemoveImpl(System.Delegate value)
		{
			return null;
		}

		// Token: 0x04000778 RID: 1912
		[Token(Token = "0x4000778")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private System.Delegate[] delegates;
	}
}

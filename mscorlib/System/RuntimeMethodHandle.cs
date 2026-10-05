using System;
using System.Reflection;
using System.Runtime.ConstrainedExecution;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using Il2CppDummyDll;

namespace System
{
	// Token: 0x020001BE RID: 446
	[Token(Token = "0x20001BE")]
	[System.Runtime.InteropServices.ComVisible(true)]
	[System.Serializable]
	public struct RuntimeMethodHandle : System.Runtime.Serialization.ISerializable
	{
		// Token: 0x06001037 RID: 4151 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001037")]
		[Address(RVA = "0x925680", Offset = "0x924280", VA = "0x180925680")]
		internal RuntimeMethodHandle(System.IntPtr v)
		{
		}

		// Token: 0x06001038 RID: 4152 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001038")]
		[Address(RVA = "0x4D3DA80", Offset = "0x4D3C680", VA = "0x184D3DA80")]
		private RuntimeMethodHandle(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context)
		{
		}

		// Token: 0x17000176 RID: 374
		// (get) Token: 0x06001039 RID: 4153 RVA: 0x0000D530 File Offset: 0x0000B730
		[Token(Token = "0x17000176")]
		public System.IntPtr Value
		{
			[Token(Token = "0x6001039")]
			[Address(RVA = "0x925550", Offset = "0x924150", VA = "0x180925550")]
			get
			{
				return 0;
			}
		}

		// Token: 0x0600103A RID: 4154 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600103A")]
		[Address(RVA = "0x4D3D830", Offset = "0x4D3C430", VA = "0x184D3D830", Slot = "4")]
		public void GetObjectData(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context)
		{
		}

		// Token: 0x0600103B RID: 4155 RVA: 0x0000D548 File Offset: 0x0000B748
		[Token(Token = "0x600103B")]
		[Address(RVA = "0x4D3D740", Offset = "0x4D3C340", VA = "0x184D3D740", Slot = "0")]
		[System.Runtime.ConstrainedExecution.ReliabilityContract(System.Runtime.ConstrainedExecution.Consistency.WillNotCorruptState, System.Runtime.ConstrainedExecution.Cer.Success)]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		// Token: 0x0600103C RID: 4156 RVA: 0x0000D560 File Offset: 0x0000B760
		[Token(Token = "0x600103C")]
		[Address(RVA = "0x849260", Offset = "0x847E60", VA = "0x180849260", Slot = "2")]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x0600103D RID: 4157 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x600103D")]
		[Address(RVA = "0x4D3D5D0", Offset = "0x4D3C1D0", VA = "0x184D3D5D0")]
		internal static string ConstructInstantiation(RuntimeMethodInfo method, TypeNameFormatFlags format)
		{
			return null;
		}

		// Token: 0x0600103E RID: 4158 RVA: 0x0000D578 File Offset: 0x0000B778
		[Token(Token = "0x600103E")]
		[Address(RVA = "0x4D3DA30", Offset = "0x4D3C630", VA = "0x184D3DA30")]
		internal bool IsNullHandle()
		{
			return default(bool);
		}

		// Token: 0x04000784 RID: 1924
		[Token(Token = "0x4000784")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private System.IntPtr value;
	}
}

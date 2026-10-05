using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace Mono
{
	// Token: 0x02000032 RID: 50
	[Token(Token = "0x2000032")]
	internal struct RuntimeClassHandle
	{
		// Token: 0x0600005A RID: 90 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600005A")]
		[Address(RVA = "0x925680", Offset = "0x924280", VA = "0x180925680")]
		internal unsafe RuntimeClassHandle(RuntimeStructs.MonoClass* value)
		{
		}

		// Token: 0x0600005B RID: 91 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600005B")]
		[Address(RVA = "0x4AB0E00", Offset = "0x4AAFA00", VA = "0x184AB0E00")]
		internal RuntimeClassHandle(System.IntPtr ptr)
		{
		}

		// Token: 0x17000005 RID: 5
		// (get) Token: 0x0600005C RID: 92 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x17000005")]
		internal unsafe RuntimeStructs.MonoClass* Value
		{
			[Token(Token = "0x600005C")]
			[Address(RVA = "0x925550", Offset = "0x924150", VA = "0x180925550")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600005D RID: 93 RVA: 0x00002238 File Offset: 0x00000438
		[Token(Token = "0x600005D")]
		[Address(RVA = "0x4AB0CB0", Offset = "0x4AAF8B0", VA = "0x184AB0CB0", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		// Token: 0x0600005E RID: 94 RVA: 0x00002250 File Offset: 0x00000450
		[Token(Token = "0x600005E")]
		[Address(RVA = "0x4AB0DB0", Offset = "0x4AAF9B0", VA = "0x184AB0DB0", Slot = "2")]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x0600005F RID: 95
		[Token(Token = "0x600005F")]
		[Address(RVA = "0x4AB0DE0", Offset = "0x4AAF9E0", VA = "0x184AB0DE0")]
		[MethodImpl(4096)]
		internal unsafe static extern System.IntPtr GetTypeFromClass(RuntimeStructs.MonoClass* klass);

		// Token: 0x06000060 RID: 96 RVA: 0x00002268 File Offset: 0x00000468
		[Token(Token = "0x6000060")]
		[Address(RVA = "0x4AB0DF0", Offset = "0x4AAF9F0", VA = "0x184AB0DF0")]
		internal System.RuntimeTypeHandle GetTypeHandle()
		{
			return default(System.RuntimeTypeHandle);
		}

		// Token: 0x04000112 RID: 274
		[Token(Token = "0x4000112")]
		[FieldOffset(Offset = "0x0")]
		private unsafe RuntimeStructs.MonoClass* value;
	}
}

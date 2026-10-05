using System;
using System.Runtime.ConstrainedExecution;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace System
{
	// Token: 0x020000D6 RID: 214
	[Token(Token = "0x20000D6")]
	internal sealed class Gen2GcCallback : System.Runtime.ConstrainedExecution.CriticalFinalizerObject
	{
		// Token: 0x0600071A RID: 1818 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600071A")]
		[Address(RVA = "0x4E9D30", Offset = "0x4E8930", VA = "0x1804E9D30")]
		private Gen2GcCallback()
		{
		}

		// Token: 0x0600071B RID: 1819 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600071B")]
		[Address(RVA = "0x4CC4CF0", Offset = "0x4CC38F0", VA = "0x184CC4CF0")]
		public static void Register(System.Func<object, bool> callback, object targetObj)
		{
		}

		// Token: 0x0600071C RID: 1820 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600071C")]
		[Address(RVA = "0x4CC4D80", Offset = "0x4CC3980", VA = "0x184CC4D80")]
		private void Setup(System.Func<object, bool> callback, object targetObj)
		{
		}

		// Token: 0x0600071D RID: 1821 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600071D")]
		[Address(RVA = "0x4CC4BE0", Offset = "0x4CC37E0", VA = "0x184CC4BE0", Slot = "1")]
		protected override void Finalize()
		{
		}

		// Token: 0x0400033D RID: 829
		[Token(Token = "0x400033D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private System.Func<object, bool> _callback;

		// Token: 0x0400033E RID: 830
		[Token(Token = "0x400033E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private System.Runtime.InteropServices.GCHandle _weakTargetObj;
	}
}

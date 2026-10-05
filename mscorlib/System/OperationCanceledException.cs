using System;
using System.Runtime.Serialization;
using System.Threading;
using Il2CppDummyDll;

namespace System
{
	// Token: 0x0200011D RID: 285
	[Token(Token = "0x200011D")]
	[System.Serializable]
	public class OperationCanceledException : System.SystemException
	{
		// Token: 0x170000A6 RID: 166
		// (get) Token: 0x0600098A RID: 2442 RVA: 0x00009510 File Offset: 0x00007710
		// (set) Token: 0x0600098B RID: 2443 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170000A6")]
		public System.Threading.CancellationToken CancellationToken
		{
			[Token(Token = "0x600098A")]
			[Address(RVA = "0x789270", Offset = "0x787E70", VA = "0x180789270")]
			get
			{
				return default(System.Threading.CancellationToken);
			}
			[Token(Token = "0x600098B")]
			[Address(RVA = "0x4CEC7F0", Offset = "0x4CEB3F0", VA = "0x184CEC7F0")]
			private set
			{
			}
		}

		// Token: 0x0600098C RID: 2444 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600098C")]
		[Address(RVA = "0x4CEC740", Offset = "0x4CEB340", VA = "0x184CEC740")]
		public OperationCanceledException()
		{
		}

		// Token: 0x0600098D RID: 2445 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600098D")]
		[Address(RVA = "0x4CEC790", Offset = "0x4CEB390", VA = "0x184CEC790")]
		public OperationCanceledException(string message)
		{
		}

		// Token: 0x0600098E RID: 2446 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600098E")]
		[Address(RVA = "0x4CEC7B0", Offset = "0x4CEB3B0", VA = "0x184CEC7B0")]
		public OperationCanceledException(string message, System.Threading.CancellationToken token)
		{
		}

		// Token: 0x0600098F RID: 2447 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600098F")]
		[Address(RVA = "0x4AED430", Offset = "0x4AEC030", VA = "0x184AED430")]
		protected OperationCanceledException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context)
		{
		}

		// Token: 0x04000472 RID: 1138
		[Token(Token = "0x4000472")]
		[FieldOffset(Offset = "0x90")]
		[System.NonSerialized]
		private System.Threading.CancellationToken _cancellationToken;
	}
}

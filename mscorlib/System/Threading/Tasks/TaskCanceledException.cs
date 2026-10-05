using System;
using System.Runtime.Serialization;
using Il2CppDummyDll;

namespace System.Threading.Tasks
{
	// Token: 0x02000243 RID: 579
	[Token(Token = "0x2000243")]
	[System.Serializable]
	public class TaskCanceledException : System.OperationCanceledException
	{
		// Token: 0x06001395 RID: 5013 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001395")]
		[Address(RVA = "0x4AE1B20", Offset = "0x4AE0720", VA = "0x184AE1B20")]
		public TaskCanceledException()
		{
		}

		// Token: 0x06001396 RID: 5014 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001396")]
		[Address(RVA = "0x4AE1A80", Offset = "0x4AE0680", VA = "0x184AE1A80")]
		public TaskCanceledException(Task task)
		{
		}

		// Token: 0x06001397 RID: 5015 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001397")]
		[Address(RVA = "0x4AE1A60", Offset = "0x4AE0660", VA = "0x184AE1A60")]
		protected TaskCanceledException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context)
		{
		}

		// Token: 0x04000B08 RID: 2824
		[Token(Token = "0x4000B08")]
		[FieldOffset(Offset = "0x98")]
		[System.NonSerialized]
		private readonly Task _canceledTask;
	}
}

using System;
using System.Runtime.Serialization;
using Il2CppDummyDll;

namespace System.Threading
{
	// Token: 0x020001E7 RID: 487
	[Token(Token = "0x20001E7")]
	[System.Serializable]
	public class AbandonedMutexException : System.SystemException
	{
		// Token: 0x06001190 RID: 4496 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001190")]
		[Address(RVA = "0x4D47D10", Offset = "0x4D46910", VA = "0x184D47D10")]
		public AbandonedMutexException()
		{
		}

		// Token: 0x06001191 RID: 4497 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001191")]
		[Address(RVA = "0x4D47D60", Offset = "0x4D46960", VA = "0x184D47D60")]
		public AbandonedMutexException(int location, WaitHandle handle)
		{
		}

		// Token: 0x06001192 RID: 4498 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001192")]
		[Address(RVA = "0x4D47E20", Offset = "0x4D46A20", VA = "0x184D47E20")]
		protected AbandonedMutexException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context)
		{
		}

		// Token: 0x06001193 RID: 4499 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001193")]
		[Address(RVA = "0x4D47C90", Offset = "0x4D46890", VA = "0x184D47C90")]
		private void SetupException(int location, WaitHandle handle)
		{
		}

		// Token: 0x040009E7 RID: 2535
		[Token(Token = "0x40009E7")]
		[FieldOffset(Offset = "0x90")]
		private int _mutexIndex;

		// Token: 0x040009E8 RID: 2536
		[Token(Token = "0x40009E8")]
		[FieldOffset(Offset = "0x98")]
		private Mutex _mutex;
	}
}

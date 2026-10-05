using System;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using Il2CppDummyDll;

namespace System.Security
{
	// Token: 0x020002C4 RID: 708
	[Token(Token = "0x20002C4")]
	[System.Runtime.InteropServices.ComVisible(true)]
	[System.Serializable]
	public class SecurityException : System.SystemException
	{
		// Token: 0x060017CE RID: 6094 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60017CE")]
		[Address(RVA = "0x4B1B1E0", Offset = "0x4B19DE0", VA = "0x184B1B1E0")]
		public SecurityException()
		{
		}

		// Token: 0x060017CF RID: 6095 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60017CF")]
		[Address(RVA = "0x4B1B1A0", Offset = "0x4B19DA0", VA = "0x184B1B1A0")]
		public SecurityException(string message)
		{
		}

		// Token: 0x060017D0 RID: 6096 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60017D0")]
		[Address(RVA = "0x4B1B230", Offset = "0x4B19E30", VA = "0x184B1B230")]
		protected SecurityException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context)
		{
		}

		// Token: 0x060017D1 RID: 6097 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60017D1")]
		[Address(RVA = "0x4B1B1C0", Offset = "0x4B19DC0", VA = "0x184B1B1C0")]
		public SecurityException(string message, System.Exception inner)
		{
		}

		// Token: 0x060017D2 RID: 6098 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60017D2")]
		[Address(RVA = "0x4B1B100", Offset = "0x4B19D00", VA = "0x184B1B100", Slot = "12")]
		public override void GetObjectData(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context)
		{
		}

		// Token: 0x060017D3 RID: 6099 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x60017D3")]
		[Address(RVA = "0x4B1B190", Offset = "0x4B19D90", VA = "0x184B1B190", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x04000CD7 RID: 3287
		[Token(Token = "0x4000CD7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private string permissionState;
	}
}

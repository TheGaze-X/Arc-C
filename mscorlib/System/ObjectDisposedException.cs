using System;
using System.Runtime.Serialization;
using Il2CppDummyDll;

namespace System
{
	// Token: 0x0200011B RID: 283
	[Token(Token = "0x200011B")]
	[System.Serializable]
	public class ObjectDisposedException : System.InvalidOperationException
	{
		// Token: 0x0600097F RID: 2431 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600097F")]
		[Address(RVA = "0x4CEC450", Offset = "0x4CEB050", VA = "0x184CEC450")]
		private ObjectDisposedException()
		{
		}

		// Token: 0x06000980 RID: 2432 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000980")]
		[Address(RVA = "0x4CEC500", Offset = "0x4CEB100", VA = "0x184CEC500")]
		public ObjectDisposedException(string objectName)
		{
		}

		// Token: 0x06000981 RID: 2433 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000981")]
		[Address(RVA = "0x4CEC4B0", Offset = "0x4CEB0B0", VA = "0x184CEC4B0")]
		public ObjectDisposedException(string objectName, string message)
		{
		}

		// Token: 0x06000982 RID: 2434 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000982")]
		[Address(RVA = "0x4CEC3C0", Offset = "0x4CEAFC0", VA = "0x184CEC3C0")]
		protected ObjectDisposedException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context)
		{
		}

		// Token: 0x06000983 RID: 2435 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000983")]
		[Address(RVA = "0x4CEC2C0", Offset = "0x4CEAEC0", VA = "0x184CEC2C0", Slot = "12")]
		public override void GetObjectData(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context)
		{
		}

		// Token: 0x170000A3 RID: 163
		// (get) Token: 0x06000984 RID: 2436 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x170000A3")]
		public override string Message
		{
			[Token(Token = "0x6000984")]
			[Address(RVA = "0x4CEC570", Offset = "0x4CEB170", VA = "0x184CEC570", Slot = "5")]
			get
			{
				return null;
			}
		}

		// Token: 0x170000A4 RID: 164
		// (get) Token: 0x06000985 RID: 2437 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x170000A4")]
		public string ObjectName
		{
			[Token(Token = "0x6000985")]
			[Address(RVA = "0x4CEC630", Offset = "0x4CEB230", VA = "0x184CEC630")]
			get
			{
				return null;
			}
		}

		// Token: 0x0400046F RID: 1135
		[Token(Token = "0x400046F")]
		[FieldOffset(Offset = "0x90")]
		private string _objectName;
	}
}

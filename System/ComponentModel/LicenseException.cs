using System;
using System.Runtime.Serialization;
using Il2CppDummyDll;

namespace System.ComponentModel
{
	// Token: 0x0200020C RID: 524
	[Token(Token = "0x200020C")]
	[Serializable]
	public class LicenseException : SystemException
	{
		// Token: 0x06000DC5 RID: 3525 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000DC5")]
		[Address(RVA = "0x515D5F0", Offset = "0x515C1F0", VA = "0x18515D5F0")]
		public LicenseException(Type type)
		{
		}

		// Token: 0x06000DC6 RID: 3526 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000DC6")]
		[Address(RVA = "0x515D1F0", Offset = "0x515BDF0", VA = "0x18515D1F0")]
		public LicenseException(Type type, object instance)
		{
		}

		// Token: 0x06000DC7 RID: 3527 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000DC7")]
		[Address(RVA = "0x515D190", Offset = "0x515BD90", VA = "0x18515D190")]
		public LicenseException(Type type, object instance, string message)
		{
		}

		// Token: 0x06000DC8 RID: 3528 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000DC8")]
		[Address(RVA = "0x515D120", Offset = "0x515BD20", VA = "0x18515D120")]
		public LicenseException(Type type, object instance, string message, Exception innerException)
		{
		}

		// Token: 0x06000DC9 RID: 3529 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000DC9")]
		[Address(RVA = "0x515D3E0", Offset = "0x515BFE0", VA = "0x18515D3E0")]
		protected LicenseException(SerializationInfo info, StreamingContext context)
		{
		}

		// Token: 0x170002E3 RID: 739
		// (get) Token: 0x06000DCA RID: 3530 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170002E3")]
		public Type LicensedType
		{
			[Token(Token = "0x6000DCA")]
			[Address(RVA = "0x789270", Offset = "0x787E70", VA = "0x180789270")]
			get
			{
				return null;
			}
		}

		// Token: 0x06000DCB RID: 3531 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000DCB")]
		[Address(RVA = "0x515D020", Offset = "0x515BC20", VA = "0x18515D020", Slot = "12")]
		public override void GetObjectData(SerializationInfo info, StreamingContext context)
		{
		}

		// Token: 0x04000796 RID: 1942
		[Token(Token = "0x4000796")]
		[FieldOffset(Offset = "0x90")]
		private Type type;

		// Token: 0x04000797 RID: 1943
		[Token(Token = "0x4000797")]
		[FieldOffset(Offset = "0x98")]
		private object instance;
	}
}

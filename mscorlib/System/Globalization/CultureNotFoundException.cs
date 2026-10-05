using System;
using System.Runtime.Serialization;
using Il2CppDummyDll;

namespace System.Globalization
{
	// Token: 0x0200055C RID: 1372
	[Token(Token = "0x200055C")]
	[System.Serializable]
	public class CultureNotFoundException : System.ArgumentException
	{
		// Token: 0x06002895 RID: 10389 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002895")]
		[Address(RVA = "0x4C10E40", Offset = "0x4C0FA40", VA = "0x184C10E40")]
		public CultureNotFoundException()
		{
		}

		// Token: 0x06002896 RID: 10390 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002896")]
		[Address(RVA = "0x4C10E20", Offset = "0x4C0FA20", VA = "0x184C10E20")]
		public CultureNotFoundException(string paramName, string message)
		{
		}

		// Token: 0x06002897 RID: 10391 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002897")]
		[Address(RVA = "0x4C10E80", Offset = "0x4C0FA80", VA = "0x184C10E80")]
		protected CultureNotFoundException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context)
		{
		}

		// Token: 0x06002898 RID: 10392 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002898")]
		[Address(RVA = "0x4C10CD0", Offset = "0x4C0F8D0", VA = "0x184C10CD0", Slot = "12")]
		public override void GetObjectData(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context)
		{
		}

		// Token: 0x170005D9 RID: 1497
		// (get) Token: 0x06002899 RID: 10393 RVA: 0x00016668 File Offset: 0x00014868
		[Token(Token = "0x170005D9")]
		public virtual int? InvalidCultureId
		{
			[Token(Token = "0x6002899")]
			[Address(RVA = "0x4FB2F0", Offset = "0x4F9EF0", VA = "0x1804FB2F0", Slot = "14")]
			get
			{
				return null;
			}
		}

		// Token: 0x170005DA RID: 1498
		// (get) Token: 0x0600289A RID: 10394 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x170005DA")]
		public virtual string InvalidCultureName
		{
			[Token(Token = "0x600289A")]
			[Address(RVA = "0xF93800", Offset = "0xF92400", VA = "0x180F93800", Slot = "15")]
			get
			{
				return null;
			}
		}

		// Token: 0x170005DB RID: 1499
		// (get) Token: 0x0600289B RID: 10395 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x170005DB")]
		private static string DefaultMessage
		{
			[Token(Token = "0x600289B")]
			[Address(RVA = "0x4C11050", Offset = "0x4C0FC50", VA = "0x184C11050")]
			get
			{
				return null;
			}
		}

		// Token: 0x170005DC RID: 1500
		// (get) Token: 0x0600289C RID: 10396 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x170005DC")]
		private string FormatedInvalidCultureId
		{
			[Token(Token = "0x600289C")]
			[Address(RVA = "0x4C11080", Offset = "0x4C0FC80", VA = "0x184C11080")]
			get
			{
				return null;
			}
		}

		// Token: 0x170005DD RID: 1501
		// (get) Token: 0x0600289D RID: 10397 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x170005DD")]
		public override string Message
		{
			[Token(Token = "0x600289D")]
			[Address(RVA = "0x4C111D0", Offset = "0x4C0FDD0", VA = "0x184C111D0", Slot = "5")]
			get
			{
				return null;
			}
		}

		// Token: 0x040016A8 RID: 5800
		[Token(Token = "0x40016A8")]
		[FieldOffset(Offset = "0x98")]
		private string _invalidCultureName;

		// Token: 0x040016A9 RID: 5801
		[Token(Token = "0x40016A9")]
		[FieldOffset(Offset = "0xA0")]
		private int? _invalidCultureId;
	}
}

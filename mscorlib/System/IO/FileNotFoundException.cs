using System;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using Il2CppDummyDll;

namespace System.IO
{
	// Token: 0x0200064B RID: 1611
	[Token(Token = "0x200064B")]
	[System.Serializable]
	public class FileNotFoundException : IOException
	{
		// Token: 0x06003040 RID: 12352 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003040")]
		[Address(RVA = "0x4C5E5C0", Offset = "0x4C5D1C0", VA = "0x184C5E5C0")]
		public FileNotFoundException()
		{
		}

		// Token: 0x06003041 RID: 12353 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003041")]
		[Address(RVA = "0x4C5E6D0", Offset = "0x4C5D2D0", VA = "0x184C5E6D0")]
		public FileNotFoundException(string message)
		{
		}

		// Token: 0x06003042 RID: 12354 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003042")]
		[Address(RVA = "0x4C5E6F0", Offset = "0x4C5D2F0", VA = "0x184C5E6F0")]
		public FileNotFoundException(string message, string fileName)
		{
		}

		// Token: 0x170007C3 RID: 1987
		// (get) Token: 0x06003043 RID: 12355 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x170007C3")]
		public override string Message
		{
			[Token(Token = "0x6003043")]
			[Address(RVA = "0x4C5E730", Offset = "0x4C5D330", VA = "0x184C5E730", Slot = "5")]
			get
			{
				return null;
			}
		}

		// Token: 0x06003044 RID: 12356 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003044")]
		[Address(RVA = "0x4C5E2A0", Offset = "0x4C5CEA0", VA = "0x184C5E2A0")]
		private void SetMessageField()
		{
		}

		// Token: 0x170007C4 RID: 1988
		// (get) Token: 0x06003045 RID: 12357 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x170007C4")]
		public string FileName
		{
			[Token(Token = "0x6003045")]
			[Address(RVA = "0x789270", Offset = "0x787E70", VA = "0x180789270")]
			[System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				return null;
			}
		}

		// Token: 0x170007C5 RID: 1989
		// (get) Token: 0x06003046 RID: 12358 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x170007C5")]
		public string FusionLog
		{
			[Token(Token = "0x6003046")]
			[Address(RVA = "0xF93800", Offset = "0xF92400", VA = "0x180F93800")]
			[System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				return null;
			}
		}

		// Token: 0x06003047 RID: 12359 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6003047")]
		[Address(RVA = "0x4C5E370", Offset = "0x4C5CF70", VA = "0x184C5E370", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06003048 RID: 12360 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003048")]
		[Address(RVA = "0x4C5E610", Offset = "0x4C5D210", VA = "0x184C5E610")]
		protected FileNotFoundException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context)
		{
		}

		// Token: 0x06003049 RID: 12361 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003049")]
		[Address(RVA = "0x4C5E180", Offset = "0x4C5CD80", VA = "0x184C5E180", Slot = "12")]
		public override void GetObjectData(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context)
		{
		}
	}
}

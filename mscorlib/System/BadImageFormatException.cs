using System;
using System.Runtime.Serialization;
using Il2CppDummyDll;

namespace System
{
	// Token: 0x020000BA RID: 186
	[Token(Token = "0x20000BA")]
	[System.Serializable]
	public class BadImageFormatException : System.SystemException
	{
		// Token: 0x0600046C RID: 1132 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600046C")]
		[Address(RVA = "0x4CA5990", Offset = "0x4CA4590", VA = "0x184CA5990")]
		public BadImageFormatException()
		{
		}

		// Token: 0x0600046D RID: 1133 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600046D")]
		[Address(RVA = "0x4CA5930", Offset = "0x4CA4530", VA = "0x184CA5930")]
		public BadImageFormatException(string message)
		{
		}

		// Token: 0x0600046E RID: 1134 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600046E")]
		[Address(RVA = "0x4CA5910", Offset = "0x4CA4510", VA = "0x184CA5910")]
		public BadImageFormatException(string message, System.Exception inner)
		{
		}

		// Token: 0x0600046F RID: 1135 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600046F")]
		[Address(RVA = "0x4CA5950", Offset = "0x4CA4550", VA = "0x184CA5950")]
		public BadImageFormatException(string message, string fileName)
		{
		}

		// Token: 0x06000470 RID: 1136 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000470")]
		[Address(RVA = "0x4CA5850", Offset = "0x4CA4450", VA = "0x184CA5850")]
		protected BadImageFormatException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context)
		{
		}

		// Token: 0x06000471 RID: 1137 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000471")]
		[Address(RVA = "0x4CA5460", Offset = "0x4CA4060", VA = "0x184CA5460", Slot = "12")]
		public override void GetObjectData(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context)
		{
		}

		// Token: 0x1700006B RID: 107
		// (get) Token: 0x06000472 RID: 1138 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x1700006B")]
		public override string Message
		{
			[Token(Token = "0x6000472")]
			[Address(RVA = "0x4CA59E0", Offset = "0x4CA45E0", VA = "0x184CA59E0", Slot = "5")]
			get
			{
				return null;
			}
		}

		// Token: 0x06000473 RID: 1139 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000473")]
		[Address(RVA = "0x4CA5580", Offset = "0x4CA4180", VA = "0x184CA5580")]
		private void SetMessageField()
		{
		}

		// Token: 0x06000474 RID: 1140 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6000474")]
		[Address(RVA = "0x4CA5600", Offset = "0x4CA4200", VA = "0x184CA5600", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x040002CB RID: 715
		[Token(Token = "0x40002CB")]
		[FieldOffset(Offset = "0x90")]
		private string _fileName;

		// Token: 0x040002CC RID: 716
		[Token(Token = "0x40002CC")]
		[FieldOffset(Offset = "0x98")]
		private string _fusionLog;
	}
}

using System;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using Il2CppDummyDll;

namespace System.Reflection
{
	// Token: 0x02000513 RID: 1299
	[Token(Token = "0x2000513")]
	[System.Serializable]
	public sealed class ReflectionTypeLoadException : System.SystemException, System.Runtime.Serialization.ISerializable
	{
		// Token: 0x060024FA RID: 9466 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60024FA")]
		[Address(RVA = "0x4BDC460", Offset = "0x4BDB060", VA = "0x184BDC460")]
		public ReflectionTypeLoadException(System.Type[] classes, System.Exception[] exceptions)
		{
		}

		// Token: 0x060024FB RID: 9467 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60024FB")]
		[Address(RVA = "0x4BDC320", Offset = "0x4BDAF20", VA = "0x184BDC320")]
		private ReflectionTypeLoadException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context)
		{
		}

		// Token: 0x060024FC RID: 9468 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60024FC")]
		[Address(RVA = "0x4BDC1F0", Offset = "0x4BDADF0", VA = "0x184BDC1F0", Slot = "12")]
		public override void GetObjectData(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context)
		{
		}

		// Token: 0x170004E7 RID: 1255
		// (get) Token: 0x060024FD RID: 9469 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x170004E7")]
		public System.Type[] Types
		{
			[Token(Token = "0x60024FD")]
			[Address(RVA = "0x789270", Offset = "0x787E70", VA = "0x180789270")]
			[System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				return null;
			}
		}

		// Token: 0x170004E8 RID: 1256
		// (get) Token: 0x060024FE RID: 9470 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x170004E8")]
		public System.Exception[] LoaderExceptions
		{
			[Token(Token = "0x60024FE")]
			[Address(RVA = "0xF93800", Offset = "0xF92400", VA = "0x180F93800")]
			[System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				return null;
			}
		}

		// Token: 0x170004E9 RID: 1257
		// (get) Token: 0x060024FF RID: 9471 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x170004E9")]
		public override string Message
		{
			[Token(Token = "0x60024FF")]
			[Address(RVA = "0x4BDC4C0", Offset = "0x4BDB0C0", VA = "0x184BDC4C0", Slot = "5")]
			get
			{
				return null;
			}
		}

		// Token: 0x06002500 RID: 9472 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6002500")]
		[Address(RVA = "0x4BDC310", Offset = "0x4BDAF10", VA = "0x184BDC310", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06002501 RID: 9473 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6002501")]
		[Address(RVA = "0x4BDC0A0", Offset = "0x4BDACA0", VA = "0x184BDC0A0")]
		private string CreateString(bool isMessage)
		{
			return null;
		}
	}
}

using System;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using Il2CppDummyDll;

namespace System.ComponentModel
{
	// Token: 0x020001EE RID: 494
	[Token(Token = "0x20001EE")]
	[Serializable]
	public class WarningException : SystemException
	{
		// Token: 0x06000D23 RID: 3363 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000D23")]
		[Address(RVA = "0x51768D0", Offset = "0x51754D0", VA = "0x1851768D0")]
		public WarningException()
		{
		}

		// Token: 0x06000D24 RID: 3364 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000D24")]
		[Address(RVA = "0x5176BA0", Offset = "0x51757A0", VA = "0x185176BA0")]
		public WarningException(string message)
		{
		}

		// Token: 0x06000D25 RID: 3365 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000D25")]
		[Address(RVA = "0x5176B50", Offset = "0x5175750", VA = "0x185176B50")]
		public WarningException(string message, string helpUrl)
		{
		}

		// Token: 0x06000D26 RID: 3366 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000D26")]
		[Address(RVA = "0x4B87B10", Offset = "0x4B86710", VA = "0x184B87B10")]
		public WarningException(string message, Exception innerException)
		{
		}

		// Token: 0x06000D27 RID: 3367 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000D27")]
		[Address(RVA = "0x5176920", Offset = "0x5175520", VA = "0x185176920")]
		public WarningException(string message, string helpUrl, string helpTopic)
		{
		}

		// Token: 0x06000D28 RID: 3368 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000D28")]
		[Address(RVA = "0x5176980", Offset = "0x5175580", VA = "0x185176980")]
		protected WarningException(SerializationInfo info, StreamingContext context)
		{
		}

		// Token: 0x170002B2 RID: 690
		// (get) Token: 0x06000D29 RID: 3369 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170002B2")]
		public string HelpUrl
		{
			[Token(Token = "0x6000D29")]
			[Address(RVA = "0x789270", Offset = "0x787E70", VA = "0x180789270")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		// Token: 0x170002B3 RID: 691
		// (get) Token: 0x06000D2A RID: 3370 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170002B3")]
		public string HelpTopic
		{
			[Token(Token = "0x6000D2A")]
			[Address(RVA = "0xF93800", Offset = "0xF92400", VA = "0x180F93800")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		// Token: 0x06000D2B RID: 3371 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000D2B")]
		[Address(RVA = "0x5176820", Offset = "0x5175420", VA = "0x185176820", Slot = "12")]
		public override void GetObjectData(SerializationInfo info, StreamingContext context)
		{
		}
	}
}

using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace System.Runtime.Serialization
{
	// Token: 0x02000414 RID: 1044
	[Token(Token = "0x2000414")]
	[System.Runtime.InteropServices.ComVisible(true)]
	[System.Serializable]
	public readonly struct StreamingContext
	{
		// Token: 0x06002077 RID: 8311 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002077")]
		[Address(RVA = "0x4BB09E0", Offset = "0x4BAF5E0", VA = "0x184BB09E0")]
		public StreamingContext(StreamingContextStates state)
		{
		}

		// Token: 0x06002078 RID: 8312 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002078")]
		[Address(RVA = "0x4BB0A00", Offset = "0x4BAF600", VA = "0x184BB0A00")]
		public StreamingContext(StreamingContextStates state, object additional)
		{
		}

		// Token: 0x06002079 RID: 8313 RVA: 0x00013620 File Offset: 0x00011820
		[Token(Token = "0x6002079")]
		[Address(RVA = "0x4BB0930", Offset = "0x4BAF530", VA = "0x184BB0930", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		// Token: 0x0600207A RID: 8314 RVA: 0x00013638 File Offset: 0x00011838
		[Token(Token = "0x600207A")]
		[Address(RVA = "0x116A510", Offset = "0x1169110", VA = "0x18116A510", Slot = "2")]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x17000456 RID: 1110
		// (get) Token: 0x0600207B RID: 8315 RVA: 0x00013650 File Offset: 0x00011850
		[Token(Token = "0x17000456")]
		public StreamingContextStates State
		{
			[Token(Token = "0x600207B")]
			[Address(RVA = "0x116A510", Offset = "0x1169110", VA = "0x18116A510")]
			get
			{
				return (StreamingContextStates)0;
			}
		}

		// Token: 0x04001101 RID: 4353
		[Token(Token = "0x4001101")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		internal readonly object m_additionalContext;

		// Token: 0x04001102 RID: 4354
		[Token(Token = "0x4001102")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		internal readonly StreamingContextStates m_state;
	}
}

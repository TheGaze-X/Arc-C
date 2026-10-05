using System;
using System.Runtime.Serialization;
using Il2CppDummyDll;
using UnityEngine.Scripting;

namespace UnityEngine
{
	// Token: 0x02000115 RID: 277
	[Token(Token = "0x2000115")]
	[RequiredByNativeCode]
	[Serializable]
	public class UnityException : Exception
	{
		// Token: 0x060009E8 RID: 2536 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60009E8")]
		[Address(RVA = "0x5978090", Offset = "0x5976C90", VA = "0x185978090")]
		public UnityException()
		{
		}

		// Token: 0x060009E9 RID: 2537 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60009E9")]
		[Address(RVA = "0x5978180", Offset = "0x5976D80", VA = "0x185978180")]
		public UnityException(string message)
		{
		}

		// Token: 0x060009EA RID: 2538 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60009EA")]
		[Address(RVA = "0x5978100", Offset = "0x5976D00", VA = "0x185978100")]
		protected UnityException(SerializationInfo info, StreamingContext context)
		{
		}
	}
}

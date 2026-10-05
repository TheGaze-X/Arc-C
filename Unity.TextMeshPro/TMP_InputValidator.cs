using System;
using Il2CppDummyDll;
using UnityEngine;

namespace TMPro
{
	// Token: 0x02000062 RID: 98
	[Token(Token = "0x2000062")]
	[Serializable]
	public abstract class TMP_InputValidator : ScriptableObject
	{
		// Token: 0x06000384 RID: 900
		[Token(Token = "0x6000384")]
		public abstract char Validate(ref string text, ref int pos, char ch);

		// Token: 0x06000385 RID: 901 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000385")]
		[Address(RVA = "0x4F4B00", Offset = "0x4F3700", VA = "0x1804F4B00")]
		protected TMP_InputValidator()
		{
		}
	}
}

using System;
using System.Runtime.Serialization;
using Il2CppDummyDll;

namespace System.ComponentModel
{
	// Token: 0x02000168 RID: 360
	[Token(Token = "0x2000168")]
	[Serializable]
	public class InvalidEnumArgumentException : ArgumentException
	{
		// Token: 0x0600091F RID: 2335 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600091F")]
		[Address(RVA = "0x5123AF0", Offset = "0x51226F0", VA = "0x185123AF0")]
		public InvalidEnumArgumentException()
		{
		}

		// Token: 0x06000920 RID: 2336 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000920")]
		[Address(RVA = "0x3699C70", Offset = "0x3698870", VA = "0x183699C70")]
		public InvalidEnumArgumentException(string message)
		{
		}

		// Token: 0x06000921 RID: 2337 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000921")]
		[Address(RVA = "0x5123AE0", Offset = "0x51226E0", VA = "0x185123AE0")]
		public InvalidEnumArgumentException(string message, Exception innerException)
		{
		}

		// Token: 0x06000922 RID: 2338 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000922")]
		[Address(RVA = "0x5123B00", Offset = "0x5122700", VA = "0x185123B00")]
		public InvalidEnumArgumentException(string argumentName, int invalidValue, Type enumClass)
		{
		}

		// Token: 0x06000923 RID: 2339 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000923")]
		[Address(RVA = "0x4ADC410", Offset = "0x4ADB010", VA = "0x184ADC410")]
		protected InvalidEnumArgumentException(SerializationInfo info, StreamingContext context)
		{
		}
	}
}

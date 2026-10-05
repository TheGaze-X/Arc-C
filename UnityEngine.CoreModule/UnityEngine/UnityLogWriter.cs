using System;
using System.IO;
using System.Runtime.CompilerServices;
using System.Text;
using Il2CppDummyDll;
using UnityEngine.Bindings;

namespace UnityEngine
{
	// Token: 0x020000CB RID: 203
	[Token(Token = "0x20000CB")]
	[NativeHeader("Runtime/Export/Logging/UnityLogWriter.bindings.h")]
	internal class UnityLogWriter : TextWriter
	{
		// Token: 0x060006AD RID: 1709 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60006AD")]
		[Address(RVA = "0x5953200", Offset = "0x5951E00", VA = "0x185953200")]
		[ThreadAndSerializationSafe]
		public static void WriteStringToUnityLog(string s)
		{
		}

		// Token: 0x060006AE RID: 1710
		[Token(Token = "0x60006AE")]
		[Address(RVA = "0x59531C0", Offset = "0x5951DC0", VA = "0x1859531C0")]
		[FreeFunction(IsThreadSafe = true)]
		[MethodImpl(4096)]
		private static extern void WriteStringToUnityLogImpl(string s);

		// Token: 0x060006AF RID: 1711 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60006AF")]
		[Address(RVA = "0x5947FF0", Offset = "0x5946BF0", VA = "0x185947FF0")]
		public static void Init()
		{
		}

		// Token: 0x17000195 RID: 405
		// (get) Token: 0x060006B0 RID: 1712 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000195")]
		public override Encoding Encoding
		{
			[Token(Token = "0x60006B0")]
			[Address(RVA = "0x59533A0", Offset = "0x5951FA0", VA = "0x1859533A0", Slot = "11")]
			get
			{
				return null;
			}
		}

		// Token: 0x060006B1 RID: 1713 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60006B1")]
		[Address(RVA = "0x5953280", Offset = "0x5951E80", VA = "0x185953280", Slot = "13")]
		public override void Write(char value)
		{
		}

		// Token: 0x060006B2 RID: 1714 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60006B2")]
		[Address(RVA = "0x5953240", Offset = "0x5951E40", VA = "0x185953240", Slot = "17")]
		public override void Write(string s)
		{
		}

		// Token: 0x060006B3 RID: 1715 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60006B3")]
		[Address(RVA = "0x5953300", Offset = "0x5951F00", VA = "0x185953300", Slot = "15")]
		public override void Write(char[] buffer, int index, int count)
		{
		}

		// Token: 0x060006B4 RID: 1716 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60006B4")]
		[Address(RVA = "0x5953350", Offset = "0x5951F50", VA = "0x185953350")]
		public UnityLogWriter()
		{
		}
	}
}

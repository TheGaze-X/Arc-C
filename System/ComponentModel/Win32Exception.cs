using System;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using Il2CppDummyDll;

namespace System.ComponentModel
{
	// Token: 0x02000227 RID: 551
	[Token(Token = "0x2000227")]
	[Serializable]
	public class Win32Exception : ExternalException, ISerializable
	{
		// Token: 0x06000F47 RID: 3911 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000F47")]
		[Address(RVA = "0x5198670", Offset = "0x5197270", VA = "0x185198670")]
		public Win32Exception()
		{
		}

		// Token: 0x06000F48 RID: 3912 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000F48")]
		[Address(RVA = "0x5198820", Offset = "0x5197420", VA = "0x185198820")]
		public Win32Exception(int error)
		{
		}

		// Token: 0x06000F49 RID: 3913 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000F49")]
		[Address(RVA = "0x51987F0", Offset = "0x51973F0", VA = "0x1851987F0")]
		public Win32Exception(int error, string message)
		{
		}

		// Token: 0x06000F4A RID: 3914 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000F4A")]
		[Address(RVA = "0x5198770", Offset = "0x5197370", VA = "0x185198770")]
		public Win32Exception(string message)
		{
		}

		// Token: 0x06000F4B RID: 3915 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000F4B")]
		[Address(RVA = "0x51985F0", Offset = "0x51971F0", VA = "0x1851985F0")]
		public Win32Exception(string message, Exception innerException)
		{
		}

		// Token: 0x06000F4C RID: 3916 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000F4C")]
		[Address(RVA = "0x51986E0", Offset = "0x51972E0", VA = "0x1851986E0")]
		protected Win32Exception(SerializationInfo info, StreamingContext context)
		{
		}

		// Token: 0x1700030F RID: 783
		// (get) Token: 0x06000F4D RID: 3917 RVA: 0x000079B0 File Offset: 0x00005BB0
		[Token(Token = "0x1700030F")]
		public int NativeErrorCode
		{
			[Token(Token = "0x6000F4D")]
			[Address(RVA = "0x4D67380", Offset = "0x4D65F80", VA = "0x184D67380")]
			get
			{
				return 0;
			}
		}

		// Token: 0x06000F4E RID: 3918 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000F4E")]
		[Address(RVA = "0x5198520", Offset = "0x5197120", VA = "0x185198520", Slot = "12")]
		public override void GetObjectData(SerializationInfo info, StreamingContext context)
		{
		}

		// Token: 0x06000F4F RID: 3919 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000F4F")]
		[Address(RVA = "0x5197A50", Offset = "0x5196650", VA = "0x185197A50")]
		internal static string GetErrorMessage(int error)
		{
			return null;
		}

		// Token: 0x04000803 RID: 2051
		[Token(Token = "0x4000803")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private readonly int nativeErrorCode;
	}
}

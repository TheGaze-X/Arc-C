using System;
using Il2CppDummyDll;

namespace GCloud.UQM
{
	// Token: 0x02000014 RID: 20
	[Token(Token = "0x2000014")]
	public class RetArgsWrapper
	{
		// Token: 0x17000004 RID: 4
		// (get) Token: 0x060000F2 RID: 242 RVA: 0x00002190 File Offset: 0x00000390
		[Token(Token = "0x17000004")]
		public int MethodId
		{
			[Token(Token = "0x60000F2")]
			[Address(RVA = "0x4EA8B0", Offset = "0x4E94B0", VA = "0x1804EA8B0")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17000005 RID: 5
		// (get) Token: 0x060000F3 RID: 243 RVA: 0x000021A8 File Offset: 0x000003A8
		[Token(Token = "0x17000005")]
		public int CrashType
		{
			[Token(Token = "0x60000F3")]
			[Address(RVA = "0x4EEB30", Offset = "0x4ED730", VA = "0x1804EEB30")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17000006 RID: 6
		// (get) Token: 0x060000F4 RID: 244 RVA: 0x000021C0 File Offset: 0x000003C0
		[Token(Token = "0x17000006")]
		public int LogUploadResult
		{
			[Token(Token = "0x60000F4")]
			[Address(RVA = "0x4EA860", Offset = "0x4E9460", VA = "0x1804EA860")]
			get
			{
				return 0;
			}
		}

		// Token: 0x060000F5 RID: 245 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000F5")]
		[Address(RVA = "0x4B2E6C0", Offset = "0x4B2D2C0", VA = "0x184B2E6C0")]
		public RetArgsWrapper(int _methodId, int _crashType, int _logUploadResult)
		{
		}

		// Token: 0x04000036 RID: 54
		[Token(Token = "0x4000036")]
		[FieldOffset(Offset = "0x10")]
		private readonly int methodId;

		// Token: 0x04000037 RID: 55
		[Token(Token = "0x4000037")]
		[FieldOffset(Offset = "0x14")]
		private readonly int crashType;

		// Token: 0x04000038 RID: 56
		[Token(Token = "0x4000038")]
		[FieldOffset(Offset = "0x18")]
		private readonly int logUploadResult;
	}
}

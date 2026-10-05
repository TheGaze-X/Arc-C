using System;
using System.Collections.Generic;
using AliyunSLS;
using Il2CppDummyDll;

namespace YoStar.SDK.AliHelper
{
	// Token: 0x020002DF RID: 735
	[Token(Token = "0x20002DF")]
	public class AliLogHelper
	{
		// Token: 0x06001054 RID: 4180 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6001054")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		private AliLogHelper()
		{
		}

		// Token: 0x06001055 RID: 4181 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001055")]
		[Address(RVA = "0x5CCF0C0", Offset = "0x5CCDCC0", VA = "0x185CCF0C0")]
		public static AliLogHelper getInstance()
		{
			return null;
		}

		// Token: 0x06001056 RID: 4182 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6001056")]
		[Address(RVA = "0x5CCEE30", Offset = "0x5CCDA30", VA = "0x185CCEE30")]
		public static void ParseEnable()
		{
		}

		// Token: 0x06001057 RID: 4183 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6001057")]
		[Address(RVA = "0x5CCF270", Offset = "0x5CCDE70", VA = "0x185CCF270")]
		public void init()
		{
		}

		// Token: 0x06001058 RID: 4184 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6001058")]
		[Address(RVA = "0x5CCFEC0", Offset = "0x5CCEAC0", VA = "0x185CCFEC0")]
		public void setLogSendCallback()
		{
		}

		// Token: 0x06001059 RID: 4185 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6001059")]
		[Address(RVA = "0x5CCFA80", Offset = "0x5CCE680", VA = "0x185CCFA80")]
		private void onLogSendDone(string configName, LogResult result, long logBytes, long compressedBytes, string errorMessage)
		{
		}

		// Token: 0x0600105A RID: 4186 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x600105A")]
		[Address(RVA = "0x5CCF010", Offset = "0x5CCDC10", VA = "0x185CCF010")]
		public void addLog(Dictionary<string, string> log)
		{
		}

		// Token: 0x04000DBF RID: 3519
		[Token(Token = "0x4000DBF")]
		[FieldOffset(Offset = "0x0")]
		public static bool isEnable;

		// Token: 0x04000DC0 RID: 3520
		[Token(Token = "0x4000DC0")]
		[FieldOffset(Offset = "0x1")]
		public static bool isInit;

		// Token: 0x04000DC1 RID: 3521
		[Token(Token = "0x4000DC1")]
		[FieldOffset(Offset = "0x8")]
		private static AliLogHelper mInstance;

		// Token: 0x04000DC2 RID: 3522
		[Token(Token = "0x4000DC2")]
		[FieldOffset(Offset = "0x10")]
		private static object lockObj;

		// Token: 0x04000DC3 RID: 3523
		[Token(Token = "0x4000DC3")]
		[FieldOffset(Offset = "0x10")]
		private AliyunLogSDK aliyunLogSDK;
	}
}

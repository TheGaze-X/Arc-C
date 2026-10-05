using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace AliyunSLS
{
	// Token: 0x0200000F RID: 15
	[Token(Token = "0x200000F")]
	public sealed class AliyunLogSDK : Platform
	{
		// Token: 0x06000056 RID: 86 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6000056")]
		[Address(RVA = "0x5BDF260", Offset = "0x5BDDE60", VA = "0x185BDF260")]
		public AliyunLogSDK()
		{
		}

		// Token: 0x06000057 RID: 87 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6000057")]
		[Address(RVA = "0x5BDF190", Offset = "0x5BDDD90", VA = "0x185BDF190", Slot = "1")]
		protected override void Finalize()
		{
		}

		// Token: 0x06000058 RID: 88 RVA: 0x00002144 File Offset: 0x00000344
		[Token(Token = "0x6000058")]
		[Address(RVA = "0x5BDF370", Offset = "0x5BDDF70", VA = "0x185BDF370", Slot = "12")]
		public LogResult addLog(Dictionary<string, string> log)
		{
			return LogResult.OK;
		}

		// Token: 0x06000059 RID: 89 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6000059")]
		[Address(RVA = "0x5BDF550", Offset = "0x5BDE150", VA = "0x185BDF550", Slot = "13")]
		public void destroy()
		{
		}

		// Token: 0x0600005A RID: 90 RVA: 0x0000215C File Offset: 0x0000035C
		[Token(Token = "0x600005A")]
		[Address(RVA = "0x5BDF5A0", Offset = "0x5BDE1A0", VA = "0x185BDF5A0", Slot = "4")]
		public LogResult init(string endpoint, string project, string logstore, string accessKeyId, string accessKeySecret, string accessKeyToken)
		{
			return LogResult.OK;
		}

		// Token: 0x0600005B RID: 91 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x600005B")]
		[Address(RVA = "0x5BDF870", Offset = "0x5BDE470", VA = "0x185BDF870", Slot = "5")]
		public void setOnLogSendCallback(AliyunLogSDK.OnLogSendCallback callback)
		{
		}

		// Token: 0x0600005C RID: 92 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x600005C")]
		[Address(RVA = "0x5BDF6B0", Offset = "0x5BDE2B0", VA = "0x185BDF6B0", Slot = "6")]
		public void setAccessKey(string accessKeyId, string accessKeySecret, string accessKeyToken)
		{
		}

		// Token: 0x0600005D RID: 93 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x600005D")]
		[Address(RVA = "0x5BDF7B0", Offset = "0x5BDE3B0", VA = "0x185BDF7B0", Slot = "7")]
		public void setEndpoint(string endpoint)
		{
		}

		// Token: 0x0600005E RID: 94 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x600005E")]
		[Address(RVA = "0x5BDF950", Offset = "0x5BDE550", VA = "0x185BDF950", Slot = "8")]
		public void setProject(string project)
		{
		}

		// Token: 0x0600005F RID: 95 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x600005F")]
		[Address(RVA = "0x5BDF810", Offset = "0x5BDE410", VA = "0x185BDF810", Slot = "9")]
		public void setLogstore(string logstore)
		{
		}

		// Token: 0x06000060 RID: 96 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6000060")]
		[Address(RVA = "0x5BDF460", Offset = "0x5BDE060", VA = "0x185BDF460", Slot = "10")]
		public void addTag(string key, string value)
		{
		}

		// Token: 0x06000061 RID: 97 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6000061")]
		[Address(RVA = "0x5BDF9B0", Offset = "0x5BDE5B0", VA = "0x185BDF9B0", Slot = "11")]
		public void setTopic(string topic)
		{
		}

		// Token: 0x04000043 RID: 67
		[Token(Token = "0x4000043")]
		[FieldOffset(Offset = "0x10")]
		private Platform platformImpl;

		// Token: 0x02000010 RID: 16
		// (Invoke) Token: 0x06000063 RID: 99
		[Token(Token = "0x2000010")]
		public delegate void OnLogSendCallback(string configName, LogResult result, long logBytes, long compressedBytes, string errorMessage);
	}
}

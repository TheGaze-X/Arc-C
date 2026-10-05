using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace AliyunSLS
{
	// Token: 0x02000012 RID: 18
	[Token(Token = "0x2000012")]
	public interface Platform
	{
		// Token: 0x06000066 RID: 102
		[Token(Token = "0x6000066")]
		LogResult init(string endpoint, string project, string logstore, string accessKeyId, string accessKeySecret, string accessKeyToken);

		// Token: 0x06000067 RID: 103
		[Token(Token = "0x6000067")]
		void setOnLogSendCallback(AliyunLogSDK.OnLogSendCallback callback);

		// Token: 0x06000068 RID: 104
		[Token(Token = "0x6000068")]
		void setAccessKey(string accessKeyId, string accessKeySecret, string accessKeyToken);

		// Token: 0x06000069 RID: 105
		[Token(Token = "0x6000069")]
		void setEndpoint(string endpoint);

		// Token: 0x0600006A RID: 106
		[Token(Token = "0x600006A")]
		void setProject(string project);

		// Token: 0x0600006B RID: 107
		[Token(Token = "0x600006B")]
		void setLogstore(string logstore);

		// Token: 0x0600006C RID: 108
		[Token(Token = "0x600006C")]
		void addTag(string key, string value);

		// Token: 0x0600006D RID: 109
		[Token(Token = "0x600006D")]
		void setTopic(string topic);

		// Token: 0x0600006E RID: 110
		[Token(Token = "0x600006E")]
		LogResult addLog(Dictionary<string, string> log);

		// Token: 0x0600006F RID: 111
		[Token(Token = "0x600006F")]
		void destroy();
	}
}

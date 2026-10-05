using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using AOT;
using Il2CppDummyDll;

namespace AliyunSLS
{
	// Token: 0x02000013 RID: 19
	[Token(Token = "0x2000013")]
	public class WindowsImpl : Platform
	{
		// Token: 0x06000070 RID: 112 RVA: 0x00002174 File Offset: 0x00000374
		[Token(Token = "0x6000070")]
		[Address(RVA = "0x5BF15F0", Offset = "0x5BF01F0", VA = "0x185BF15F0", Slot = "4")]
		public LogResult init(string endpoint, string project, string logstore, string accessKeyId, string accessKeySecret, string accessKeyToken)
		{
			return LogResult.OK;
		}

		// Token: 0x06000071 RID: 113 RVA: 0x0000218C File Offset: 0x0000038C
		[Token(Token = "0x6000071")]
		[Address(RVA = "0x5BF08A0", Offset = "0x5BEF4A0", VA = "0x185BF08A0", Slot = "12")]
		public LogResult addLog(Dictionary<string, string> log)
		{
			return LogResult.OK;
		}

		// Token: 0x06000072 RID: 114 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6000072")]
		[Address(RVA = "0x5BF1A60", Offset = "0x5BF0660", VA = "0x185BF1A60", Slot = "5")]
		public void setOnLogSendCallback(AliyunLogSDK.OnLogSendCallback callback)
		{
		}

		// Token: 0x06000073 RID: 115 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6000073")]
		[Address(RVA = "0x5BF1520", Offset = "0x5BF0120", VA = "0x185BF1520")]
		private void callLogSendCallback(string configName, int result, long logBytes, long compressedBytes, string errorMessage)
		{
		}

		// Token: 0x06000074 RID: 116 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6000074")]
		[Address(RVA = "0x5BF1770", Offset = "0x5BF0370", VA = "0x185BF1770", Slot = "6")]
		public void setAccessKey(string accessKeyId, string accessKeySecret, string accessKeyToken)
		{
		}

		// Token: 0x06000075 RID: 117 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6000075")]
		[Address(RVA = "0x5BF18A0", Offset = "0x5BF04A0", VA = "0x185BF18A0", Slot = "7")]
		public void setEndpoint(string endpoint)
		{
		}

		// Token: 0x06000076 RID: 118 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6000076")]
		[Address(RVA = "0x5BF1C70", Offset = "0x5BF0870", VA = "0x185BF1C70", Slot = "8")]
		public void setProject(string project)
		{
		}

		// Token: 0x06000077 RID: 119 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6000077")]
		[Address(RVA = "0x5BF1980", Offset = "0x5BF0580", VA = "0x185BF1980", Slot = "9")]
		public void setLogstore(string logstore)
		{
		}

		// Token: 0x06000078 RID: 120 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6000078")]
		[Address(RVA = "0x5BF0C40", Offset = "0x5BEF840", VA = "0x185BF0C40", Slot = "10")]
		public void addTag(string key, string value)
		{
		}

		// Token: 0x06000079 RID: 121 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6000079")]
		[Address(RVA = "0x5BF1D50", Offset = "0x5BF0950", VA = "0x185BF1D50", Slot = "11")]
		public void setTopic(string topic)
		{
		}

		// Token: 0x0600007A RID: 122 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x600007A")]
		[Address(RVA = "0x5BF1540", Offset = "0x5BF0140", VA = "0x185BF1540", Slot = "13")]
		public void destroy()
		{
		}

		// Token: 0x0600007B RID: 123 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x600007B")]
		[Address(RVA = "0x5BF0730", Offset = "0x5BEF330", VA = "0x185BF0730")]
		[MonoPInvokeCallback(typeof(AliyunLogSDK.OnLogSendCallback))]
		private static void InternalLogSendDoneCallback(string configName, int result, long logBytes, long compressedBytes, string errorMessage, IntPtr userParams)
		{
		}

		// Token: 0x0600007C RID: 124
		[Token(Token = "0x600007C")]
		[Address(RVA = "0x5BF0F60", Offset = "0x5BEFB60", VA = "0x185BF0F60")]
		[PreserveSig]
		private static extern IntPtr aliyun_log_create(string endpoint, string project, string logstore, string accessKeyId, string accessKeySecret, string accessKeyToken);

		// Token: 0x0600007D RID: 125
		[Token(Token = "0x600007D")]
		[Address(RVA = "0x5BF0D40", Offset = "0x5BEF940", VA = "0x185BF0D40")]
		[PreserveSig]
		private static extern int aliyun_log_add_log(IntPtr aliyunLog, int length, string[] extensions);

		// Token: 0x0600007E RID: 126
		[Token(Token = "0x600007E")]
		[Address(RVA = "0x5BF10B0", Offset = "0x5BEFCB0", VA = "0x185BF10B0")]
		[PreserveSig]
		private static extern void aliyun_log_destroy(IntPtr aliyunLog);

		// Token: 0x0600007F RID: 127
		[Token(Token = "0x600007F")]
		[Address(RVA = "0x5BF13F0", Offset = "0x5BEFFF0", VA = "0x185BF13F0")]
		[PreserveSig]
		private static extern void aliyun_log_set_send_done_function(WindowsImpl.log_send_done_callback callback);

		// Token: 0x06000080 RID: 128
		[Token(Token = "0x6000080")]
		[Address(RVA = "0x5BF1130", Offset = "0x5BEFD30", VA = "0x185BF1130")]
		[PreserveSig]
		private static extern void aliyun_log_set_accesskey(IntPtr aliyunLog, string accessKeyId, string accessKeySecret, string accessKeyToken);

		// Token: 0x06000081 RID: 129
		[Token(Token = "0x6000081")]
		[Address(RVA = "0x5BF1210", Offset = "0x5BEFE10", VA = "0x185BF1210")]
		[PreserveSig]
		private static extern void aliyun_log_set_endpoint(IntPtr aliyunLog, string endpoint);

		// Token: 0x06000082 RID: 130
		[Token(Token = "0x6000082")]
		[Address(RVA = "0x5BF1350", Offset = "0x5BEFF50", VA = "0x185BF1350")]
		[PreserveSig]
		private static extern void aliyun_log_set_project(IntPtr aliyunLog, string project);

		// Token: 0x06000083 RID: 131
		[Token(Token = "0x6000083")]
		[Address(RVA = "0x5BF12B0", Offset = "0x5BEFEB0", VA = "0x185BF12B0")]
		[PreserveSig]
		private static extern void aliyun_log_set_logstore(IntPtr aliyunLog, string logstore);

		// Token: 0x06000084 RID: 132
		[Token(Token = "0x6000084")]
		[Address(RVA = "0x5BF0EA0", Offset = "0x5BEFAA0", VA = "0x185BF0EA0")]
		[PreserveSig]
		private static extern void aliyun_log_add_tag(IntPtr aliyunLog, string key, string value);

		// Token: 0x06000085 RID: 133
		[Token(Token = "0x6000085")]
		[Address(RVA = "0x5BF1480", Offset = "0x5BF0080", VA = "0x185BF1480")]
		[PreserveSig]
		private static extern void aliyun_log_set_topic(IntPtr aliyunLog, string topic);

		// Token: 0x06000086 RID: 134 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6000086")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public WindowsImpl()
		{
		}

		// Token: 0x04000050 RID: 80
		[Token(Token = "0x4000050")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private IntPtr token;

		// Token: 0x04000051 RID: 81
		[Token(Token = "0x4000051")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private AliyunLogSDK.OnLogSendCallback logSendCallback;

		// Token: 0x04000052 RID: 82
		[Token(Token = "0x4000052")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static Dictionary<IntPtr, WindowsImpl> sCallbackCachedImpl;

		// Token: 0x02000014 RID: 20
		// (Invoke) Token: 0x06000089 RID: 137
		[Token(Token = "0x2000014")]
		public delegate void log_send_done_callback(string configName, int result, long logBytes, long compressedBytes, string errorMessage, IntPtr userParams);
	}
}

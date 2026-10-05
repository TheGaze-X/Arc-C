using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using AOT;
using Il2CppDummyDll;

namespace AliyunSLS
{
	// Token: 0x02000028 RID: 40
	[Token(Token = "0x2000028")]
	public sealed class Unity4SLS
	{
		// Token: 0x060000B0 RID: 176 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x60000B0")]
		[Address(RVA = "0x5BE8130", Offset = "0x5BE6D30", VA = "0x185BE8130")]
		[MonoPInvokeCallback(typeof(complete_callback))]
		public static void CommonStaticCallbackWrapper(int type, string content, string context, string error)
		{
		}

		// Token: 0x060000B1 RID: 177 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x60000B1")]
		[Address(RVA = "0x5BE8D10", Offset = "0x5BE7910", VA = "0x185BE8D10")]
		public static void Initialize(Credentials credentials)
		{
		}

		// Token: 0x060000B2 RID: 178 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x60000B2")]
		[Address(RVA = "0x5BE9700", Offset = "0x5BE8300", VA = "0x185BE9700")]
		public static void RegisterCredentialsCallback(callback_delegate callback)
		{
		}

		// Token: 0x060000B3 RID: 179 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x60000B3")]
		[Address(RVA = "0x5BE98A0", Offset = "0x5BE84A0", VA = "0x185BE98A0")]
		public static void RegisterLogCallback(log_callback callback)
		{
		}

		// Token: 0x060000B4 RID: 180 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x60000B4")]
		[Address(RVA = "0x5BE8A80", Offset = "0x5BE7680", VA = "0x185BE8A80")]
		public static void GetLocalDeviceNum(string context, callback_response local_complete_callback)
		{
		}

		// Token: 0x060000B5 RID: 181 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x60000B5")]
		[Address(RVA = "0x5BE9DE0", Offset = "0x5BE89E0", VA = "0x185BE9DE0")]
		public static void SetLogLevel(SLSLogLevel level)
		{
		}

		// Token: 0x060000B6 RID: 182 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x60000B6")]
		[Address(RVA = "0x5BE9B50", Offset = "0x5BE8750", VA = "0x185BE9B50")]
		public static void SetCredentials(Credentials credentials)
		{
		}

		// Token: 0x060000B7 RID: 183 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x60000B7")]
		[Address(RVA = "0x5BE9F50", Offset = "0x5BE8B50", VA = "0x185BE9F50")]
		public static void SetUserInfo(UserInfo info)
		{
		}

		// Token: 0x060000B8 RID: 184 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x60000B8")]
		[Address(RVA = "0x5BF0400", Offset = "0x5BEF000", VA = "0x185BF0400")]
		public static void setDeviceId(string deviceId)
		{
		}

		// Token: 0x060000B9 RID: 185 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x60000B9")]
		[Address(RVA = "0x5BE9D40", Offset = "0x5BE8940", VA = "0x185BE9D40")]
		public static void SetExtra(string key, Dictionary<string, string> values)
		{
		}

		// Token: 0x060000BA RID: 186 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x60000BA")]
		[Address(RVA = "0x5BE9CB0", Offset = "0x5BE88B0", VA = "0x185BE9CB0")]
		public static void SetExtra(string key, string value)
		{
		}

		// Token: 0x060000BB RID: 187 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x60000BB")]
		[Address(RVA = "0x5BE9A60", Offset = "0x5BE8660", VA = "0x185BE9A60")]
		public static void RemoveExtra(string key)
		{
		}

		// Token: 0x060000BC RID: 188 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x60000BC")]
		[Address(RVA = "0x5BE8060", Offset = "0x5BE6C60", VA = "0x185BE8060")]
		public static void ClearExtra()
		{
		}

		// Token: 0x060000BD RID: 189 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x60000BD")]
		[Address(RVA = "0x5BE8830", Offset = "0x5BE7430", VA = "0x185BE8830")]
		public static void Destroy()
		{
		}

		// Token: 0x060000BE RID: 190 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x60000BE")]
		[Address(RVA = "0x5BE8CC0", Offset = "0x5BE78C0", VA = "0x185BE8CC0")]
		public static void Http(HttpRequest request)
		{
		}

		// Token: 0x060000BF RID: 191 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x60000BF")]
		[Address(RVA = "0x5BE96B0", Offset = "0x5BE82B0", VA = "0x185BE96B0")]
		public static void Ping(PingRequest request)
		{
		}

		// Token: 0x060000C0 RID: 192 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x60000C0")]
		[Address(RVA = "0x5BE9FE0", Offset = "0x5BE8BE0", VA = "0x185BE9FE0")]
		public static void TcpPing(TcpPingRequest request)
		{
		}

		// Token: 0x060000C1 RID: 193 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x60000C1")]
		[Address(RVA = "0x5BEA030", Offset = "0x5BE8C30", VA = "0x185BEA030")]
		public static void UdpPing(UdpRequest request)
		{
		}

		// Token: 0x060000C2 RID: 194 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x60000C2")]
		[Address(RVA = "0x5BE8A30", Offset = "0x5BE7630", VA = "0x185BE8A30")]
		public static void Dns(DnsRequest request)
		{
		}

		// Token: 0x060000C3 RID: 195 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x60000C3")]
		[Address(RVA = "0x5BE9660", Offset = "0x5BE8260", VA = "0x185BE9660")]
		public static void Mtr(MtrRequest request)
		{
		}

		// Token: 0x060000C4 RID: 196 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x60000C4")]
		[Address(RVA = "0x5BE89F0", Offset = "0x5BE75F0", VA = "0x185BE89F0")]
		public static void DisableExNetworkInfo()
		{
		}

		// Token: 0x060000C5 RID: 197 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x60000C5")]
		[Address(RVA = "0x5BE9E20", Offset = "0x5BE8A20", VA = "0x185BE9E20")]
		public static void SetMultiplePortsDetect(bool enable)
		{
		}

		// Token: 0x060000C6 RID: 198 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x60000C6")]
		[Address(RVA = "0x5BE9E60", Offset = "0x5BE8A60", VA = "0x185BE9E60")]
		public static void SetPolicyDomain(string domain)
		{
		}

		// Token: 0x060000C7 RID: 199 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x60000C7")]
		[Address(RVA = "0x5BE9FA0", Offset = "0x5BE8BA0", VA = "0x185BE9FA0")]
		public static void SetUserTags(string[] tags)
		{
		}

		// Token: 0x060000C8 RID: 200 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x60000C8")]
		[Address(RVA = "0x5BE9990", Offset = "0x5BE8590", VA = "0x185BE9990")]
		public static void RegisterResponseCallback(callback_response callback)
		{
		}

		// Token: 0x060000C9 RID: 201 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x60000C9")]
		[Address(RVA = "0x5BEA080", Offset = "0x5BE8C80", VA = "0x185BEA080")]
		public static void UpdateExtensions(Dictionary<string, string> extension)
		{
		}

		// Token: 0x060000CA RID: 202 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x60000CA")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70")]
		private void ReleaseCallback()
		{
		}

		// Token: 0x060000CB RID: 203 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x60000CB")]
		[Address(RVA = "0x5BEBD90", Offset = "0x5BEA990", VA = "0x185BEBD90")]
		private static void _InitServer()
		{
		}

		// Token: 0x060000CC RID: 204 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x60000CC")]
		[Address(RVA = "0x5BEDB20", Offset = "0x5BEC720", VA = "0x185BEDB20")]
		private static void _ShutServer()
		{
		}

		// Token: 0x060000CD RID: 205 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x60000CD")]
		[Address(RVA = "0x5BEB7E0", Offset = "0x5BEA3E0", VA = "0x185BEB7E0")]
		private static void _InitSLS(Credentials credentials)
		{
		}

		// Token: 0x060000CE RID: 206 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x60000CE")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70")]
		private static void _SetLogLevel(SLSLogLevel level)
		{
		}

		// Token: 0x060000CF RID: 207 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x60000CF")]
		[Address(RVA = "0x5BED440", Offset = "0x5BEC040", VA = "0x185BED440")]
		private static void _SetCredentials(Credentials credentials)
		{
		}

		// Token: 0x060000D0 RID: 208 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x60000D0")]
		[Address(RVA = "0x5BED0E0", Offset = "0x5BEBCE0", VA = "0x185BED0E0")]
		private static void _RegisterCredentialsCallback(callback_delegate callback)
		{
		}

		// Token: 0x060000D1 RID: 209 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x60000D1")]
		[Address(RVA = "0x5BED700", Offset = "0x5BEC300", VA = "0x185BED700")]
		private static void _SetUserInfo(UserInfo info)
		{
		}

		// Token: 0x060000D2 RID: 210 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x60000D2")]
		[Address(RVA = "0x5BEEF10", Offset = "0x5BEDB10", VA = "0x185BEEF10")]
		private static void _setDeviceId(string deviceId)
		{
		}

		// Token: 0x060000D3 RID: 211 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x60000D3")]
		[Address(RVA = "0x5BED570", Offset = "0x5BEC170", VA = "0x185BED570")]
		private static void _SetExtra(string key, Dictionary<string, string> values)
		{
		}

		// Token: 0x060000D4 RID: 212 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x60000D4")]
		[Address(RVA = "0x5BED5E0", Offset = "0x5BEC1E0", VA = "0x185BED5E0")]
		private static void _SetExtra(string key, string value)
		{
		}

		// Token: 0x060000D5 RID: 213 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x60000D5")]
		[Address(RVA = "0x5BED380", Offset = "0x5BEBF80", VA = "0x185BED380")]
		private static void _RemoveExtra(string key)
		{
		}

		// Token: 0x060000D6 RID: 214 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x60000D6")]
		[Address(RVA = "0x5BEA0D0", Offset = "0x5BE8CD0", VA = "0x185BEA0D0")]
		private static void _ClearExtra()
		{
		}

		// Token: 0x060000D7 RID: 215 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x60000D7")]
		[Address(RVA = "0x5BEA170", Offset = "0x5BE8D70", VA = "0x185BEA170")]
		private static void _Destroy()
		{
		}

		// Token: 0x060000D8 RID: 216 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x60000D8")]
		[Address(RVA = "0x5BEAE00", Offset = "0x5BE9A00", VA = "0x185BEAE00")]
		private static void _Http(HttpRequest request)
		{
		}

		// Token: 0x060000D9 RID: 217 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x60000D9")]
		[Address(RVA = "0x5BEC990", Offset = "0x5BEB590", VA = "0x185BEC990")]
		public static void _Ping(PingRequest request)
		{
		}

		// Token: 0x060000DA RID: 218 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x60000DA")]
		[Address(RVA = "0x5BEDBE0", Offset = "0x5BEC7E0", VA = "0x185BEDBE0")]
		public static void _TcpPing(TcpPingRequest request)
		{
		}

		// Token: 0x060000DB RID: 219 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x60000DB")]
		[Address(RVA = "0x5BEE400", Offset = "0x5BED000", VA = "0x185BEE400")]
		public static void _UdpPing(UdpRequest request)
		{
		}

		// Token: 0x060000DC RID: 220 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x60000DC")]
		[Address(RVA = "0x5BEA300", Offset = "0x5BE8F00", VA = "0x185BEA300")]
		public static void _Dns(DnsRequest request)
		{
		}

		// Token: 0x060000DD RID: 221 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x60000DD")]
		[Address(RVA = "0x5BEC0B0", Offset = "0x5BEACB0", VA = "0x185BEC0B0")]
		public static void _Mtr(MtrRequest request)
		{
		}

		// Token: 0x060000DE RID: 222 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000DE")]
		[Address(RVA = "0x5BE8560", Offset = "0x5BE7160", VA = "0x185BE8560")]
		private static string[] ConvertDictionaryToArray(Dictionary<string, string> dictionary)
		{
			return null;
		}

		// Token: 0x060000DF RID: 223 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x60000DF")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70")]
		public static void _DisableExNetworkInfo()
		{
		}

		// Token: 0x060000E0 RID: 224 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x60000E0")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70")]
		public static void _SetMultiplePortsDetect(bool enable)
		{
		}

		// Token: 0x060000E1 RID: 225 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x60000E1")]
		[Address(RVA = "0x5BED640", Offset = "0x5BEC240", VA = "0x185BED640")]
		public static void _SetPolicyDomain(string domain)
		{
		}

		// Token: 0x060000E2 RID: 226 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x60000E2")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70")]
		public static void _SetUserTags(string[] tags)
		{
		}

		// Token: 0x060000E3 RID: 227 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x60000E3")]
		[Address(RVA = "0x5BED310", Offset = "0x5BEBF10", VA = "0x185BED310")]
		public static void _RegisterResponseCallback(callback_response callback)
		{
		}

		// Token: 0x060000E4 RID: 228 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x60000E4")]
		[Address(RVA = "0x5BED250", Offset = "0x5BEBE50", VA = "0x185BED250")]
		private static void _RegisterLogCallback(log_callback callback)
		{
		}

		// Token: 0x060000E5 RID: 229 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x60000E5")]
		[Address(RVA = "0x5BEABF0", Offset = "0x5BE97F0", VA = "0x185BEABF0")]
		private static void _GetLocalDeviceNum(string context, callback_response local_complete_callback)
		{
		}

		// Token: 0x060000E6 RID: 230 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x60000E6")]
		[Address(RVA = "0x5BEE9D0", Offset = "0x5BED5D0", VA = "0x185BEE9D0")]
		public static void _UpdateExtensions(Dictionary<string, string> extension)
		{
		}

		// Token: 0x060000E7 RID: 231 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x60000E7")]
		[Address(RVA = "0x5BE8D60", Offset = "0x5BE7960", VA = "0x185BE8D60")]
		private static void InternalMessageHandle(string message)
		{
		}

		// Token: 0x060000E8 RID: 232 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x60000E8")]
		[Address(RVA = "0x5BE9510", Offset = "0x5BE8110", VA = "0x185BE9510")]
		[MonoPInvokeCallback(typeof(log_callback))]
		private static void InternalWinLogCallback(string log)
		{
		}

		// Token: 0x060000E9 RID: 233 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x60000E9")]
		[Address(RVA = "0x5BE8F30", Offset = "0x5BE7B30", VA = "0x185BE8F30")]
		[MonoPInvokeCallback(typeof(callback_delegate))]
		private static void InternalWinCompleteCallback(string context, string uuid, string content)
		{
		}

		// Token: 0x060000EA RID: 234 RVA: 0x000021D4 File Offset: 0x000003D4
		[Token(Token = "0x60000EA")]
		[Address(RVA = "0x5BF04A0", Offset = "0x5BEF0A0", VA = "0x185BF04A0")]
		private static ReqType toType(string method)
		{
			return ReqType.HTTP;
		}

		// Token: 0x060000EB RID: 235 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x60000EB")]
		[Address(RVA = "0x5BE95B0", Offset = "0x5BE81B0", VA = "0x185BE95B0")]
		[MonoPInvokeCallback(typeof(Unity4SLS.WinTokenExpCallback))]
		private static void InternalWinTokenExpCallback()
		{
		}

		// Token: 0x060000EC RID: 236
		[Token(Token = "0x60000EC")]
		[Address(RVA = "0x5BEF530", Offset = "0x5BEE130", VA = "0x185BEF530")]
		[PreserveSig]
		private static extern void _sls_init(bool play_mode, string secret_key, string device_id, string accessKeyId, string accessKeySecret, string securityToken, string[] extensions, int length);

		// Token: 0x060000ED RID: 237
		[Token(Token = "0x60000ED")]
		[Address(RVA = "0x5BEFE60", Offset = "0x5BEEA60", VA = "0x185BEFE60")]
		[PreserveSig]
		private static extern void _sls_set_policy_domain(string domain);

		// Token: 0x060000EE RID: 238
		[Token(Token = "0x60000EE")]
		[Address(RVA = "0x5BF02B0", Offset = "0x5BEEEB0", VA = "0x185BF02B0")]
		[PreserveSig]
		private static extern void _sls_update_extention(string[] extensions, int length);

		// Token: 0x060000EF RID: 239
		[Token(Token = "0x60000EF")]
		[Address(RVA = "0x5BEFB20", Offset = "0x5BEE720", VA = "0x185BEFB20")]
		[PreserveSig]
		private static extern void _sls_register_log_callback(log_callback callback);

		// Token: 0x060000F0 RID: 240
		[Token(Token = "0x60000F0")]
		[Address(RVA = "0x5BEF270", Offset = "0x5BEDE70", VA = "0x185BEF270")]
		[PreserveSig]
		private static extern int _sls_get_local_device_num(string context, string detect_uid);

		// Token: 0x060000F1 RID: 241
		[Token(Token = "0x60000F1")]
		[Address(RVA = "0x5BEFA90", Offset = "0x5BEE690", VA = "0x185BEFA90")]
		[PreserveSig]
		private static extern void _sls_register_credentials_callback(Unity4SLS.WinTokenExpCallback callback);

		// Token: 0x060000F2 RID: 242
		[Token(Token = "0x60000F2")]
		[Address(RVA = "0x5BEFC40", Offset = "0x5BEE840", VA = "0x185BEFC40")]
		[PreserveSig]
		private static extern void _sls_set_credentials(string accessKeyId, string accessKeySecret, string accessToken);

		// Token: 0x060000F3 RID: 243
		[Token(Token = "0x60000F3")]
		[Address(RVA = "0x5BEF8E0", Offset = "0x5BEE4E0", VA = "0x185BEF8E0")]
		[PreserveSig]
		private static extern void _sls_ping(string domain, string context, int size, int maxTimes, int timeout, string detect_uid, string[] ext, int length);

		// Token: 0x060000F4 RID: 244
		[Token(Token = "0x60000F4")]
		[Address(RVA = "0x5BF00F0", Offset = "0x5BEECF0", VA = "0x185BF00F0")]
		[PreserveSig]
		private static extern void _sls_tcpping(string domain, string context, int size, int maxTimes, int timeout, int port, string detect_uid, string[] ext, int length);

		// Token: 0x060000F5 RID: 245
		[Token(Token = "0x60000F5")]
		[Address(RVA = "0x5BEF060", Offset = "0x5BEDC60", VA = "0x185BEF060")]
		[PreserveSig]
		private static extern void _sls_dns(string domain, string context, int size, int maxTimes, int timeout, string type, string nameServer, string detect_uid, string[] ext, int length);

		// Token: 0x060000F6 RID: 246
		[Token(Token = "0x60000F6")]
		[Address(RVA = "0x5BEF720", Offset = "0x5BEE320", VA = "0x185BEF720")]
		[PreserveSig]
		private static extern void _sls_mtr(string domain, string context, int size, int maxTimes, int timeout, int maxTTL, int maxPaths, string detect_uid, string[] ext, int length);

		// Token: 0x060000F7 RID: 247
		[Token(Token = "0x60000F7")]
		[Address(RVA = "0x5BEF330", Offset = "0x5BEDF30", VA = "0x185BEF330")]
		[PreserveSig]
		private static extern void _sls_http(string domain, string context, int size, int maxTimes, int timeout, string ip, bool headerOnly, int downloadBytesLimit, string detect_uid, string[] ext, int length);

		// Token: 0x060000F8 RID: 248
		[Token(Token = "0x60000F8")]
		[Address(RVA = "0x5BEFF70", Offset = "0x5BEEB70", VA = "0x185BEFF70")]
		[PreserveSig]
		private static extern void _sls_set_userinfo(string uid, string channel, string[] ext, int length);

		// Token: 0x060000F9 RID: 249
		[Token(Token = "0x60000F9")]
		[Address(RVA = "0x5BEFD10", Offset = "0x5BEE910", VA = "0x185BEFD10")]
		[PreserveSig]
		private static extern void _sls_set_extra(string key, string value);

		// Token: 0x060000FA RID: 250
		[Token(Token = "0x60000FA")]
		[Address(RVA = "0x5BEFBB0", Offset = "0x5BEE7B0", VA = "0x185BEFBB0")]
		[PreserveSig]
		private static extern void _sls_remove_extra(string key);

		// Token: 0x060000FB RID: 251
		[Token(Token = "0x60000FB")]
		[Address(RVA = "0x5BEEF80", Offset = "0x5BEDB80", VA = "0x185BEEF80")]
		[PreserveSig]
		private static extern void _sls_clear_extra();

		// Token: 0x060000FC RID: 252
		[Token(Token = "0x60000FC")]
		[Address(RVA = "0x5BEEFF0", Offset = "0x5BEDBF0", VA = "0x185BEEFF0")]
		[PreserveSig]
		private static extern void _sls_destroy();

		// Token: 0x060000FD RID: 253
		[Token(Token = "0x60000FD")]
		[Address(RVA = "0x5BEFDC0", Offset = "0x5BEE9C0", VA = "0x185BEFDC0")]
		[PreserveSig]
		private static extern bool _sls_set_pipe_name(string pipeName);

		// Token: 0x060000FE RID: 254
		[Token(Token = "0x60000FE")]
		[Address(RVA = "0x5BEFEF0", Offset = "0x5BEEAF0", VA = "0x185BEFEF0")]
		[PreserveSig]
		private static extern bool _sls_set_server_port(int port);

		// Token: 0x060000FF RID: 255 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x60000FF")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70")]
		private void Start()
		{
		}

		// Token: 0x06000100 RID: 256 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6000100")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70")]
		private void Update()
		{
		}

		// Token: 0x06000101 RID: 257 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6000101")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public Unity4SLS()
		{
		}

		// Token: 0x0400008B RID: 139
		[Token(Token = "0x400008B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static callback_delegate s_callback_delegate;

		// Token: 0x0400008C RID: 140
		[Token(Token = "0x400008C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static callback_response s_callback_response;

		// Token: 0x0400008D RID: 141
		[Token(Token = "0x400008D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private static Dictionary<string, callback_response> detect_callback_map;

		// Token: 0x0400008E RID: 142
		[Token(Token = "0x400008E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private static Dictionary<string, string> context_map;

		// Token: 0x0400008F RID: 143
		[Token(Token = "0x400008F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private static TCPServer tcpServer;

		// Token: 0x04000090 RID: 144
		[Token(Token = "0x4000090")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private static log_callback s_log_callback;

		// Token: 0x04000091 RID: 145
		[Token(Token = "0x4000091")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private static string s_device_id;

		// Token: 0x02000029 RID: 41
		[Token(Token = "0x2000029")]
		[Serializable]
		public class DetectionResult
		{
			// Token: 0x06000103 RID: 259 RVA: 0x0000206A File Offset: 0x0000026A
			[Token(Token = "0x6000103")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public DetectionResult()
			{
			}

			// Token: 0x04000092 RID: 146
			[Token(Token = "0x4000092")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public string strace_id;

			// Token: 0x04000093 RID: 147
			[Token(Token = "0x4000093")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public string method;
		}

		// Token: 0x0200002A RID: 42
		[Token(Token = "0x200002A")]
		[Serializable]
		public class MessageData
		{
			// Token: 0x06000104 RID: 260 RVA: 0x0000206A File Offset: 0x0000026A
			[Token(Token = "0x6000104")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public MessageData()
			{
			}

			// Token: 0x04000094 RID: 148
			[Token(Token = "0x4000094")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public string type;

			// Token: 0x04000095 RID: 149
			[Token(Token = "0x4000095")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public string context;

			// Token: 0x04000096 RID: 150
			[Token(Token = "0x4000096")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public string message;
		}

		// Token: 0x0200002B RID: 43
		// (Invoke) Token: 0x06000106 RID: 262
		[Token(Token = "0x200002B")]
		public delegate void win_complete_callback(string context, string content);

		// Token: 0x0200002C RID: 44
		// (Invoke) Token: 0x0600010A RID: 266
		[Token(Token = "0x200002C")]
		public delegate void WinTokenExpCallback();
	}
}

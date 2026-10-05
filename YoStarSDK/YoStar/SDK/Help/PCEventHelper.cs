using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UDatasdk;

namespace YoStar.SDK.Help
{
	// Token: 0x02000216 RID: 534
	[Token(Token = "0x2000216")]
	public class PCEventHelper
	{
		// Token: 0x06000DCD RID: 3533 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6000DCD")]
		[Address(RVA = "0x5C8AD30", Offset = "0x5C89930", VA = "0x185C8AD30")]
		public static void RegisterEventCallback()
		{
		}

		// Token: 0x06000DCE RID: 3534 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6000DCE")]
		[Address(RVA = "0x5C8A930", Offset = "0x5C89530", VA = "0x185C8A930")]
		public static void Init([Optional] Action<InitRet> callback)
		{
		}

		// Token: 0x06000DCF RID: 3535 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6000DCF")]
		[Address(RVA = "0x5C8AC10", Offset = "0x5C89810", VA = "0x185C8AC10")]
		public static void OnPause()
		{
		}

		// Token: 0x06000DD0 RID: 3536 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6000DD0")]
		[Address(RVA = "0x5C8ACE0", Offset = "0x5C898E0", VA = "0x185C8ACE0")]
		public static void OnResume()
		{
		}

		// Token: 0x06000DD1 RID: 3537 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6000DD1")]
		[Address(RVA = "0x5C8B620", Offset = "0x5C8A220", VA = "0x185C8B620")]
		public static void Track(string eventName, [Optional] Dictionary<string, object> eventParam, [Optional] Dictionary<string, object> extraParam)
		{
		}

		// Token: 0x06000DD2 RID: 3538 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6000DD2")]
		[Address(RVA = "0x5C8B240", Offset = "0x5C89E40", VA = "0x185C8B240")]
		private static void Track(string eventName, string eventParam = "")
		{
		}

		// Token: 0x06000DD3 RID: 3539 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6000DD3")]
		[Address(RVA = "0x5C8A4C0", Offset = "0x5C890C0", VA = "0x185C8A4C0")]
		public static void GeeTestEvent(int resultCode, string lotNumber = "")
		{
		}

		// Token: 0x06000DD4 RID: 3540 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000DD4")]
		[Address(RVA = "0x5C8A330", Offset = "0x5C88F30", VA = "0x185C8A330")]
		private static Dictionary<string, object> CommonData()
		{
			return null;
		}

		// Token: 0x06000DD5 RID: 3541 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000DD5")]
		[Address(RVA = "0x5C8ADE0", Offset = "0x5C899E0", VA = "0x185C8ADE0")]
		private static Dictionary<string, object> RoleInfo(string eventName)
		{
			return null;
		}

		// Token: 0x06000DD6 RID: 3542 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6000DD6")]
		[Address(RVA = "0x5C8AC60", Offset = "0x5C89860", VA = "0x185C8AC60")]
		private static void OnReportEventRespone(ReportEventRet ret)
		{
		}

		// Token: 0x06000DD7 RID: 3543 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6000DD7")]
		[Address(RVA = "0x5C8B0F0", Offset = "0x5C89CF0", VA = "0x185C8B0F0")]
		public static void TrackPay(string eventName, [Optional] Dictionary<string, object> eventParam, [Optional] Dictionary<string, object> extraParam)
		{
		}

		// Token: 0x06000DD8 RID: 3544 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000DD8")]
		[Address(RVA = "0x5C8A720", Offset = "0x5C89320", VA = "0x185C8A720")]
		public static string GetPayTypeEvent(PayType payType)
		{
			return null;
		}

		// Token: 0x06000DD9 RID: 3545 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6000DD9")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public PCEventHelper()
		{
		}
	}
}

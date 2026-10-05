using System;
using System.Diagnostics;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

namespace YoStar.SDK.UI
{
	// Token: 0x02000165 RID: 357
	[Token(Token = "0x2000165")]
	public class EmailInputPanel : MonoBehaviour
	{
		// Token: 0x060008F3 RID: 2291 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x60008F3")]
		[Address(RVA = "0x5C5FF60", Offset = "0x5C5EB60", VA = "0x185C5FF60")]
		private void Awake()
		{
		}

		// Token: 0x060008F4 RID: 2292 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x60008F4")]
		[Address(RVA = "0x5C610D0", Offset = "0x5C5FCD0", VA = "0x185C610D0")]
		private void Update()
		{
		}

		// Token: 0x060008F5 RID: 2293 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x60008F5")]
		[Address(RVA = "0x5C605F0", Offset = "0x5C5F1F0", VA = "0x185C605F0")]
		private void CodeClearButtonActiveInputField(string content)
		{
		}

		// Token: 0x060008F6 RID: 2294 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x60008F6")]
		[Address(RVA = "0x5C606A0", Offset = "0x5C5F2A0", VA = "0x185C606A0")]
		private void EmailClearButtonActiveInputField(string content)
		{
		}

		// Token: 0x1700009D RID: 157
		// (get) Token: 0x060008F8 RID: 2296 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060008F7 RID: 2295 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x1700009D")]
		public string EmailContent
		{
			[Token(Token = "0x60008F8")]
			[Address(RVA = "0x5C61190", Offset = "0x5C5FD90", VA = "0x185C61190")]
			get
			{
				return null;
			}
			[Token(Token = "0x60008F7")]
			[Address(RVA = "0x5C612D0", Offset = "0x5C5FED0", VA = "0x185C612D0")]
			set
			{
			}
		}

		// Token: 0x1700009E RID: 158
		// (get) Token: 0x060008FA RID: 2298 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060008F9 RID: 2297 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x1700009E")]
		public string CodeContent
		{
			[Token(Token = "0x60008FA")]
			[Address(RVA = "0x5C61140", Offset = "0x5C5FD40", VA = "0x185C61140")]
			get
			{
				return null;
			}
			[Token(Token = "0x60008F9")]
			[Address(RVA = "0x5C61220", Offset = "0x5C5FE20", VA = "0x185C61220")]
			set
			{
			}
		}

		// Token: 0x1700009F RID: 159
		// (set) Token: 0x060008FB RID: 2299 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x1700009F")]
		public string EmailPlaceholderContent
		{
			[Token(Token = "0x60008FB")]
			[Address(RVA = "0x5C612F0", Offset = "0x5C5FEF0", VA = "0x185C612F0")]
			set
			{
			}
		}

		// Token: 0x170000A0 RID: 160
		// (set) Token: 0x060008FC RID: 2300 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x170000A0")]
		public string CodePlaceholderContent
		{
			[Token(Token = "0x60008FC")]
			[Address(RVA = "0x5C61240", Offset = "0x5C5FE40", VA = "0x185C61240")]
			set
			{
			}
		}

		// Token: 0x170000A1 RID: 161
		// (get) Token: 0x060008FD RID: 2301 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170000A1")]
		public InputField EmailInputField
		{
			[Token(Token = "0x60008FD")]
			[Address(RVA = "0x4E5A80", Offset = "0x4E4680", VA = "0x1804E5A80")]
			get
			{
				return null;
			}
		}

		// Token: 0x170000A2 RID: 162
		// (get) Token: 0x060008FE RID: 2302 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170000A2")]
		public InputField CodeInputField
		{
			[Token(Token = "0x60008FE")]
			[Address(RVA = "0x4E5A70", Offset = "0x4E4670", VA = "0x1804E5A70")]
			get
			{
				return null;
			}
		}

		// Token: 0x170000A3 RID: 163
		// (set) Token: 0x060008FF RID: 2303 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x170000A3")]
		public Action SendAction
		{
			[Token(Token = "0x60008FF")]
			[Address(RVA = "0x514D10", Offset = "0x513910", VA = "0x180514D10")]
			set
			{
			}
		}

		// Token: 0x06000900 RID: 2304 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6000900")]
		[Address(RVA = "0x5C60750", Offset = "0x5C5F350", VA = "0x185C60750")]
		private void OnClearAction(Button button)
		{
		}

		// Token: 0x06000901 RID: 2305 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6000901")]
		[Address(RVA = "0x5C60940", Offset = "0x5C5F540", VA = "0x185C60940")]
		private void OnSendCode()
		{
		}

		// Token: 0x06000902 RID: 2306 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6000902")]
		[Address(RVA = "0x5C60B80", Offset = "0x5C5F780", VA = "0x185C60B80")]
		public void SendCodeResult(bool isSuccess, int code)
		{
		}

		// Token: 0x06000903 RID: 2307 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6000903")]
		[Address(RVA = "0x5C60D90", Offset = "0x5C5F990", VA = "0x185C60D90")]
		private void StartCountdown()
		{
		}

		// Token: 0x06000904 RID: 2308 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6000904")]
		[Address(RVA = "0x5C60930", Offset = "0x5C5F530", VA = "0x185C60930")]
		private void OnCodeTFValueChanged(string value)
		{
		}

		// Token: 0x06000905 RID: 2309 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6000905")]
		[Address(RVA = "0x5C609E0", Offset = "0x5C5F5E0", VA = "0x185C609E0")]
		private void OnValueChanged(string value)
		{
		}

		// Token: 0x06000906 RID: 2310 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6000906")]
		[Address(RVA = "0x5C60DF0", Offset = "0x5C5F9F0", VA = "0x185C60DF0")]
		private void UpdataTime()
		{
		}

		// Token: 0x06000907 RID: 2311 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6000907")]
		[Address(RVA = "0x5C61130", Offset = "0x5C5FD30", VA = "0x185C61130")]
		public EmailInputPanel()
		{
		}

		// Token: 0x040005AE RID: 1454
		[Token(Token = "0x40005AE")]
		[FieldOffset(Offset = "0x18")]
		private InputField emailIF;

		// Token: 0x040005AF RID: 1455
		[Token(Token = "0x40005AF")]
		[FieldOffset(Offset = "0x20")]
		private InputField codeIF;

		// Token: 0x040005B0 RID: 1456
		[Token(Token = "0x40005B0")]
		[FieldOffset(Offset = "0x28")]
		private Button sendBtn;

		// Token: 0x040005B1 RID: 1457
		[Token(Token = "0x40005B1")]
		[FieldOffset(Offset = "0x30")]
		private Button emailClearButton;

		// Token: 0x040005B2 RID: 1458
		[Token(Token = "0x40005B2")]
		[FieldOffset(Offset = "0x38")]
		private Button codeClearButton;

		// Token: 0x040005B3 RID: 1459
		[Token(Token = "0x40005B3")]
		[FieldOffset(Offset = "0x40")]
		private int countdownTime;

		// Token: 0x040005B4 RID: 1460
		[Token(Token = "0x40005B4")]
		[FieldOffset(Offset = "0x48")]
		private Stopwatch stopwatch;

		// Token: 0x040005B5 RID: 1461
		[Token(Token = "0x40005B5")]
		[FieldOffset(Offset = "0x50")]
		private bool isCountingDown;

		// Token: 0x040005B6 RID: 1462
		[Token(Token = "0x40005B6")]
		[FieldOffset(Offset = "0x58")]
		private Action sendAction;
	}
}

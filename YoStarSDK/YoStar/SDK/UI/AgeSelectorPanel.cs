using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine.UI;
using YoStar.SDK.View;

namespace YoStar.SDK.UI
{
	// Token: 0x02000136 RID: 310
	[Token(Token = "0x2000136")]
	public class AgeSelectorPanel : BasePanel
	{
		// Token: 0x060007FA RID: 2042 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x60007FA")]
		[Address(RVA = "0x5C3F060", Offset = "0x5C3DC60", VA = "0x185C3F060")]
		public void Close()
		{
		}

		// Token: 0x060007FB RID: 2043 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x60007FB")]
		[Address(RVA = "0x5C3FDB0", Offset = "0x5C3E9B0", VA = "0x185C3FDB0", Slot = "9")]
		public override void OnCreate()
		{
		}

		// Token: 0x060007FC RID: 2044 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x60007FC")]
		[Address(RVA = "0x5C3F350", Offset = "0x5C3DF50", VA = "0x185C3F350", Slot = "6")]
		public override void InitView()
		{
		}

		// Token: 0x060007FD RID: 2045 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x60007FD")]
		[Address(RVA = "0x5C40340", Offset = "0x5C3EF40", VA = "0x185C40340")]
		private void Start()
		{
		}

		// Token: 0x060007FE RID: 2046 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x60007FE")]
		[Address(RVA = "0x5C3FFD0", Offset = "0x5C3EBD0", VA = "0x185C3FFD0")]
		private void OnYearOrMonthChanged(string value)
		{
		}

		// Token: 0x060007FF RID: 2047 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x60007FF")]
		[Address(RVA = "0x5C409D0", Offset = "0x5C3F5D0", VA = "0x185C409D0")]
		private void UpdateDaysDropdown(int year, int month)
		{
		}

		// Token: 0x06000800 RID: 2048 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6000800")]
		[Address(RVA = "0x5C3F1F0", Offset = "0x5C3DDF0", VA = "0x185C3F1F0")]
		private void ConfirmAgainAsync()
		{
		}

		// Token: 0x06000801 RID: 2049 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6000801")]
		[Address(RVA = "0x5C3F290", Offset = "0x5C3DE90", VA = "0x185C3F290")]
		public void GoPay()
		{
		}

		// Token: 0x06000802 RID: 2050 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6000802")]
		[Address(RVA = "0x5C402A0", Offset = "0x5C3EEA0", VA = "0x185C402A0")]
		private void Pay()
		{
		}

		// Token: 0x06000803 RID: 2051 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6000803")]
		[Address(RVA = "0x4EC010", Offset = "0x4EAC10", VA = "0x1804EC010")]
		public AgeSelectorPanel()
		{
		}

		// Token: 0x040004CB RID: 1227
		[Token(Token = "0x40004CB")]
		[FieldOffset(Offset = "0x50")]
		private YMDDropdown yearDropdown;

		// Token: 0x040004CC RID: 1228
		[Token(Token = "0x40004CC")]
		[FieldOffset(Offset = "0x58")]
		private YMDDropdown monthDropdown;

		// Token: 0x040004CD RID: 1229
		[Token(Token = "0x40004CD")]
		[FieldOffset(Offset = "0x60")]
		private YMDDropdown dayDropdown;

		// Token: 0x040004CE RID: 1230
		[Token(Token = "0x40004CE")]
		[FieldOffset(Offset = "0x68")]
		private int selectedYear;

		// Token: 0x040004CF RID: 1231
		[Token(Token = "0x40004CF")]
		[FieldOffset(Offset = "0x6C")]
		private int selectedMonth;

		// Token: 0x040004D0 RID: 1232
		[Token(Token = "0x40004D0")]
		[FieldOffset(Offset = "0x70")]
		private int selectedDay;

		// Token: 0x040004D1 RID: 1233
		[Token(Token = "0x40004D1")]
		[FieldOffset(Offset = "0x78")]
		private Text title;

		// Token: 0x040004D2 RID: 1234
		[Token(Token = "0x40004D2")]
		[FieldOffset(Offset = "0x80")]
		private Text customText;

		// Token: 0x040004D3 RID: 1235
		[Token(Token = "0x40004D3")]
		[FieldOffset(Offset = "0x88")]
		private Button close;

		// Token: 0x040004D4 RID: 1236
		[Token(Token = "0x40004D4")]
		[FieldOffset(Offset = "0x90")]
		private Button confirm;

		// Token: 0x040004D5 RID: 1237
		[Token(Token = "0x40004D5")]
		[FieldOffset(Offset = "0x98")]
		private DateTime currentDate;

		// Token: 0x040004D6 RID: 1238
		[Token(Token = "0x40004D6")]
		[FieldOffset(Offset = "0xA0")]
		private Dictionary<string, object> eventParam;

		// Token: 0x040004D7 RID: 1239
		[Token(Token = "0x40004D7")]
		[FieldOffset(Offset = "0xA8")]
		private AgeSelectorConfig ageSelectorConfig;
	}
}

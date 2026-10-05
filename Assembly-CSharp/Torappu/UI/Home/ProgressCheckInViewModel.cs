using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.Home
{
	// Token: 0x02004B67 RID: 19303
	[Token(Token = "0x2004B67")]
	public class ProgressCheckInViewModel : IHotfixable
	{
		// Token: 0x0601D0E4 RID: 119012 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D0E4")]
		[Address(RVA = "0x16AE5E0", Offset = "0x16AD1E0", VA = "0x1816AE5E0")]
		public void LoadData()
		{
		}

		// Token: 0x0601D0E5 RID: 119013 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D0E5")]
		[Address(RVA = "0x16AE6E0", Offset = "0x16AD2E0", VA = "0x1816AE6E0")]
		private void _Reset()
		{
		}

		// Token: 0x0601D0E6 RID: 119014 RVA: 0x000AA268 File Offset: 0x000A8468
		[Token(Token = "0x601D0E6")]
		[Address(RVA = "0x16AEEA0", Offset = "0x16ADAA0", VA = "0x1816AEEA0")]
		private bool _TryLoadReturnProgressData()
		{
			return default(bool);
		}

		// Token: 0x0601D0E7 RID: 119015 RVA: 0x000AA280 File Offset: 0x000A8480
		[Token(Token = "0x601D0E7")]
		[Address(RVA = "0x16AE780", Offset = "0x16AD380", VA = "0x1816AE780")]
		private bool _TryLoadNewProgressData()
		{
			return default(bool);
		}

		// Token: 0x0601D0E8 RID: 119016 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D0E8")]
		[Address(RVA = "0x16AF580", Offset = "0x16AE180", VA = "0x1816AF580")]
		public ProgressCheckInViewModel()
		{
		}

		// Token: 0x040261D3 RID: 156115
		[Token(Token = "0x40261D3")]
		private const int DAY_THRES = 86400;

		// Token: 0x040261D4 RID: 156116
		[Token(Token = "0x40261D4")]
		[FieldOffset(Offset = "0x10")]
		public List<ProgressCheckInItem> itemList;

		// Token: 0x040261D5 RID: 156117
		[Token(Token = "0x40261D5")]
		[FieldOffset(Offset = "0x18")]
		public bool isValid;

		// Token: 0x040261D6 RID: 156118
		[Token(Token = "0x40261D6")]
		[FieldOffset(Offset = "0x1C")]
		public int currentCheckInDay;

		// Token: 0x040261D7 RID: 156119
		[Token(Token = "0x40261D7")]
		[FieldOffset(Offset = "0x20")]
		public string title;

		// Token: 0x040261D8 RID: 156120
		[Token(Token = "0x40261D8")]
		[FieldOffset(Offset = "0x28")]
		public string remainTimeDesc;

		// Token: 0x040261D9 RID: 156121
		[Token(Token = "0x40261D9")]
		[FieldOffset(Offset = "0x30")]
		public string iconId;

		// Token: 0x040261DA RID: 156122
		[Token(Token = "0x40261DA")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_LoadData;

		// Token: 0x040261DB RID: 156123
		[Token(Token = "0x40261DB")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__Reset;

		// Token: 0x040261DC RID: 156124
		[Token(Token = "0x40261DC")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__TryLoadReturnProgressData;

		// Token: 0x040261DD RID: 156125
		[Token(Token = "0x40261DD")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__TryLoadNewProgressData;

		// Token: 0x040261DE RID: 156126
		[Token(Token = "0x40261DE")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}

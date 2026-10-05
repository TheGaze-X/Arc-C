using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using XLua;

namespace Torappu.AVG
{
	// Token: 0x02001F38 RID: 7992
	[Token(Token = "0x2001F38")]
	public class AVGReaderModeViewModel : IHotfixable
	{
		// Token: 0x1700178F RID: 6031
		// (get) Token: 0x0600C6B3 RID: 50867 RVA: 0x000488B8 File Offset: 0x00046AB8
		[Token(Token = "0x1700178F")]
		public int cellCount
		{
			[Token(Token = "0x600C6B3")]
			[Address(RVA = "0x34826F0", Offset = "0x34812F0", VA = "0x1834826F0")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17001790 RID: 6032
		// (get) Token: 0x0600C6B4 RID: 50868 RVA: 0x000488D0 File Offset: 0x00046AD0
		[Token(Token = "0x17001790")]
		public int version
		{
			[Token(Token = "0x600C6B4")]
			[Address(RVA = "0x34827C0", Offset = "0x34813C0", VA = "0x1834827C0")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17001791 RID: 6033
		// (get) Token: 0x0600C6B5 RID: 50869 RVA: 0x000488E8 File Offset: 0x00046AE8
		// (set) Token: 0x0600C6B6 RID: 50870 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17001791")]
		public bool settingChanged
		{
			[Token(Token = "0x600C6B5")]
			[Address(RVA = "0x3482760", Offset = "0x3481360", VA = "0x183482760")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600C6B6")]
			[Address(RVA = "0x3482820", Offset = "0x3481420", VA = "0x183482820")]
			set
			{
			}
		}

		// Token: 0x0600C6B7 RID: 50871 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C6B7")]
		[Address(RVA = "0x3481D60", Offset = "0x3480960", VA = "0x183481D60")]
		public void AddDialogCell(string dialogName, string dialogContent, bool isCurrent = true)
		{
		}

		// Token: 0x0600C6B8 RID: 50872 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C6B8")]
		[Address(RVA = "0x3481BD0", Offset = "0x34807D0", VA = "0x183481BD0")]
		public void AddDecisionCell(string optionString, int decisionIndex, int decisionLineNumber)
		{
		}

		// Token: 0x0600C6B9 RID: 50873 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C6B9")]
		[Address(RVA = "0x3481ED0", Offset = "0x3480AD0", VA = "0x183481ED0")]
		public void AddEndtipCell()
		{
		}

		// Token: 0x0600C6BA RID: 50874 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C6BA")]
		[Address(RVA = "0x34822E0", Offset = "0x3480EE0", VA = "0x1834822E0")]
		public void UpdateCell(int index, [Optional] string dialogName, [Optional] string dialogContent, [Optional] bool? isCurrent, [Optional] bool? isDecision, [Optional] int? decisionIndex, [Optional] int? decisionLineNumber, [Optional] bool? isEndtip)
		{
		}

		// Token: 0x0600C6BB RID: 50875 RVA: 0x00048900 File Offset: 0x00046B00
		[Token(Token = "0x600C6BB")]
		[Address(RVA = "0x3482540", Offset = "0x3481140", VA = "0x183482540")]
		public bool UpdateDecisionCellByLine(int decisionLineNumber, int decisionIndex)
		{
			return default(bool);
		}

		// Token: 0x0600C6BC RID: 50876 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C6BC")]
		[Address(RVA = "0x3482030", Offset = "0x3480C30", VA = "0x183482030")]
		public void ClearAll()
		{
		}

		// Token: 0x0600C6BD RID: 50877 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600C6BD")]
		[Address(RVA = "0x34820D0", Offset = "0x3480CD0", VA = "0x1834820D0")]
		public AVGReaderModeCellData GetCell(int index)
		{
			return null;
		}

		// Token: 0x0600C6BE RID: 50878 RVA: 0x00048918 File Offset: 0x00046B18
		[Token(Token = "0x600C6BE")]
		[Address(RVA = "0x3482180", Offset = "0x3480D80", VA = "0x183482180")]
		public bool IsCellChanged(int index, AVGReaderModeCellData other)
		{
			return default(bool);
		}

		// Token: 0x0600C6BF RID: 50879 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C6BF")]
		[Address(RVA = "0x3482640", Offset = "0x3481240", VA = "0x183482640")]
		public AVGReaderModeViewModel()
		{
		}

		// Token: 0x0400CC24 RID: 52260
		[Token(Token = "0x400CC24")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private List<AVGReaderModeCellData> m_cells;

		// Token: 0x0400CC25 RID: 52261
		[Token(Token = "0x400CC25")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private int m_version;

		// Token: 0x0400CC26 RID: 52262
		[Token(Token = "0x400CC26")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		private bool m_settingChanged;

		// Token: 0x0400CC27 RID: 52263
		[Token(Token = "0x400CC27")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_cellCount;

		// Token: 0x0400CC28 RID: 52264
		[Token(Token = "0x400CC28")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_version;

		// Token: 0x0400CC29 RID: 52265
		[Token(Token = "0x400CC29")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_settingChanged;

		// Token: 0x0400CC2A RID: 52266
		[Token(Token = "0x400CC2A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_set_settingChanged;

		// Token: 0x0400CC2B RID: 52267
		[Token(Token = "0x400CC2B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_AddDialogCell;

		// Token: 0x0400CC2C RID: 52268
		[Token(Token = "0x400CC2C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_AddDecisionCell;

		// Token: 0x0400CC2D RID: 52269
		[Token(Token = "0x400CC2D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_AddEndtipCell;

		// Token: 0x0400CC2E RID: 52270
		[Token(Token = "0x400CC2E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_UpdateCell;

		// Token: 0x0400CC2F RID: 52271
		[Token(Token = "0x400CC2F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_UpdateDecisionCellByLine;

		// Token: 0x0400CC30 RID: 52272
		[Token(Token = "0x400CC30")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_ClearAll;

		// Token: 0x0400CC31 RID: 52273
		[Token(Token = "0x400CC31")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_GetCell;

		// Token: 0x0400CC32 RID: 52274
		[Token(Token = "0x400CC32")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_IsCellChanged;

		// Token: 0x0400CC33 RID: 52275
		[Token(Token = "0x400CC33")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}

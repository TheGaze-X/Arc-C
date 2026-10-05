using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI
{
	// Token: 0x02003745 RID: 14149
	[Token(Token = "0x2003745")]
	public class UIPayCostCheckView : PageSingleComponent
	{
		// Token: 0x060167B5 RID: 92085 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60167B5")]
		[Address(RVA = "0xEEE8A0", Offset = "0xEED4A0", VA = "0x180EEE8A0", Slot = "5")]
		protected override void OnCreate()
		{
		}

		// Token: 0x060167B6 RID: 92086 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60167B6")]
		[Address(RVA = "0xEEE710", Offset = "0xEED310", VA = "0x180EEE710")]
		public static UIPayCostCheckView GetActiveInst()
		{
			return null;
		}

		// Token: 0x060167B7 RID: 92087 RVA: 0x00091608 File Offset: 0x0008F808
		[Token(Token = "0x60167B7")]
		[Address(RVA = "0xEEE620", Offset = "0xEED220", VA = "0x180EEE620")]
		public bool CheckNeedBuyDiamond(int costNum)
		{
			return default(bool);
		}

		// Token: 0x060167B8 RID: 92088 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60167B8")]
		[Address(RVA = "0xEEECF0", Offset = "0xEED8F0", VA = "0x180EEECF0")]
		private void _OnConfirmed()
		{
		}

		// Token: 0x060167B9 RID: 92089 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60167B9")]
		[Address(RVA = "0xEEEC60", Offset = "0xEED860", VA = "0x180EEEC60")]
		private void _OnCanceled()
		{
		}

		// Token: 0x060167BA RID: 92090 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60167BA")]
		[Address(RVA = "0xEEE910", Offset = "0xEED510", VA = "0x180EEE910")]
		private void _InitIfNot()
		{
		}

		// Token: 0x060167BB RID: 92091 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60167BB")]
		[Address(RVA = "0xEEEDA0", Offset = "0xEED9A0", VA = "0x180EEEDA0")]
		public UIPayCostCheckView()
		{
		}

		// Token: 0x060167BC RID: 92092 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60167BC")]
		[Address(RVA = "0xEE5F30", Offset = "0xEE4B30", VA = "0x180EE5F30")]
		private void <>xLuaBaseProxy_OnCreate()
		{
		}

		// Token: 0x0401B13E RID: 110910
		[Token(Token = "0x401B13E")]
		[FieldOffset(Offset = "0x20")]
		private UIPayCostCheckContent m_content;

		// Token: 0x0401B13F RID: 110911
		[Token(Token = "0x401B13F")]
		[FieldOffset(Offset = "0x28")]
		private bool m_isInited;

		// Token: 0x0401B140 RID: 110912
		[Token(Token = "0x401B140")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnCreate;

		// Token: 0x0401B141 RID: 110913
		[Token(Token = "0x401B141")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_GetActiveInst;

		// Token: 0x0401B142 RID: 110914
		[Token(Token = "0x401B142")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_CheckNeedBuyDiamond;

		// Token: 0x0401B143 RID: 110915
		[Token(Token = "0x401B143")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__OnConfirmed;

		// Token: 0x0401B144 RID: 110916
		[Token(Token = "0x401B144")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__OnCanceled;

		// Token: 0x0401B145 RID: 110917
		[Token(Token = "0x401B145")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0401B146 RID: 110918
		[Token(Token = "0x401B146")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}

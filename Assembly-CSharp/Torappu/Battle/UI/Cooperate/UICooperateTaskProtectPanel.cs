using System;
using Il2CppDummyDll;
using Torappu.Battle.Cooperate;
using XLua;

namespace Torappu.Battle.UI.Cooperate
{
	// Token: 0x020033F7 RID: 13303
	[Token(Token = "0x20033F7")]
	public class UICooperateTaskProtectPanel : UICooperateTaskPanel
	{
		// Token: 0x17003258 RID: 12888
		// (get) Token: 0x060153BA RID: 86970 RVA: 0x0008ABE8 File Offset: 0x00088DE8
		[Token(Token = "0x17003258")]
		public override CoopStageType type
		{
			[Token(Token = "0x60153BA")]
			[Address(RVA = "0xDC0270", Offset = "0xDBEE70", VA = "0x180DC0270", Slot = "4")]
			get
			{
				return CoopStageType.BASIC;
			}
		}

		// Token: 0x060153BB RID: 86971 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60153BB")]
		[Address(RVA = "0xDBF780", Offset = "0xDBE380", VA = "0x180DBF780", Slot = "5")]
		public override void LoadDataFromBuff(ObjectPtr<Buff> buff)
		{
		}

		// Token: 0x060153BC RID: 86972 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60153BC")]
		[Address(RVA = "0xDBF630", Offset = "0xDBE230", VA = "0x180DBF630", Slot = "6")]
		public override void GetProgerss(int curScore)
		{
		}

		// Token: 0x060153BD RID: 86973 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60153BD")]
		[Address(RVA = "0xDBFC10", Offset = "0xDBE810", VA = "0x180DBFC10", Slot = "7")]
		public override void UpdatePanelFixed()
		{
		}

		// Token: 0x060153BE RID: 86974 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60153BE")]
		[Address(RVA = "0xDBFDB0", Offset = "0xDBE9B0", VA = "0x180DBFDB0", Slot = "8")]
		public override void UpdatePanel()
		{
		}

		// Token: 0x060153BF RID: 86975 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60153BF")]
		[Address(RVA = "0xDC01D0", Offset = "0xDBEDD0", VA = "0x180DC01D0")]
		public UICooperateTaskProtectPanel()
		{
		}

		// Token: 0x060153C0 RID: 86976 RVA: 0x0008AC00 File Offset: 0x00088E00
		[Token(Token = "0x60153C0")]
		[Address(RVA = "0xDBF3E0", Offset = "0xDBDFE0", VA = "0x180DBF3E0")]
		private CoopStageType <>xLuaBaseProxy_get_type()
		{
			return CoopStageType.BASIC;
		}

		// Token: 0x060153C1 RID: 86977 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60153C1")]
		[Address(RVA = "0xDAA920", Offset = "0xDA9520", VA = "0x180DAA920")]
		private void <>xLuaBaseProxy_LoadDataFromBuff(ObjectPtr<Buff> P0)
		{
		}

		// Token: 0x060153C2 RID: 86978 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60153C2")]
		[Address(RVA = "0xDBDC30", Offset = "0xDBC830", VA = "0x180DBDC30")]
		private void <>xLuaBaseProxy_GetProgerss(int P0)
		{
		}

		// Token: 0x060153C3 RID: 86979 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60153C3")]
		[Address(RVA = "0xDAA940", Offset = "0xDA9540", VA = "0x180DAA940")]
		private void <>xLuaBaseProxy_UpdatePanelFixed()
		{
		}

		// Token: 0x060153C4 RID: 86980 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60153C4")]
		[Address(RVA = "0xDBF040", Offset = "0xDBDC40", VA = "0x180DBF040")]
		private void <>xLuaBaseProxy_UpdatePanel()
		{
		}

		// Token: 0x040195E3 RID: 103907
		[Token(Token = "0x40195E3")]
		private const string POINT = "point";

		// Token: 0x040195E4 RID: 103908
		[Token(Token = "0x40195E4")]
		[FieldOffset(Offset = "0x70")]
		private int m_totalCnt;

		// Token: 0x040195E5 RID: 103909
		[Token(Token = "0x40195E5")]
		[FieldOffset(Offset = "0x74")]
		private int m_cachedTotalCnt;

		// Token: 0x040195E6 RID: 103910
		[Token(Token = "0x40195E6")]
		[FieldOffset(Offset = "0x78")]
		private int m_basicTotalCnt;

		// Token: 0x040195E7 RID: 103911
		[Token(Token = "0x40195E7")]
		[FieldOffset(Offset = "0x7C")]
		private int m_curCnt;

		// Token: 0x040195E8 RID: 103912
		[Token(Token = "0x40195E8")]
		[FieldOffset(Offset = "0x80")]
		private FP m_basicAccomplish;

		// Token: 0x040195E9 RID: 103913
		[Token(Token = "0x40195E9")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_type;

		// Token: 0x040195EA RID: 103914
		[Token(Token = "0x40195EA")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_LoadDataFromBuff;

		// Token: 0x040195EB RID: 103915
		[Token(Token = "0x40195EB")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_GetProgerss;

		// Token: 0x040195EC RID: 103916
		[Token(Token = "0x40195EC")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_UpdatePanelFixed;

		// Token: 0x040195ED RID: 103917
		[Token(Token = "0x40195ED")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_UpdatePanel;

		// Token: 0x040195EE RID: 103918
		[Token(Token = "0x40195EE")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}

using System;
using Il2CppDummyDll;
using Torappu.Battle.Cooperate;
using XLua;

namespace Torappu.Battle.UI.Cooperate
{
	// Token: 0x020033F9 RID: 13305
	[Token(Token = "0x20033F9")]
	public class UICooperateTaskTargetPanel : UICooperateTaskPanel
	{
		// Token: 0x1700325A RID: 12890
		// (get) Token: 0x060153D0 RID: 86992 RVA: 0x0008AC48 File Offset: 0x00088E48
		[Token(Token = "0x1700325A")]
		public override CoopStageType type
		{
			[Token(Token = "0x60153D0")]
			[Address(RVA = "0xDC23C0", Offset = "0xDC0FC0", VA = "0x180DC23C0", Slot = "4")]
			get
			{
				return CoopStageType.BASIC;
			}
		}

		// Token: 0x060153D1 RID: 86993 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60153D1")]
		[Address(RVA = "0xDC16C0", Offset = "0xDC02C0", VA = "0x180DC16C0", Slot = "5")]
		public override void LoadDataFromBuff(ObjectPtr<Buff> buff)
		{
		}

		// Token: 0x060153D2 RID: 86994 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60153D2")]
		[Address(RVA = "0xDC1570", Offset = "0xDC0170", VA = "0x180DC1570", Slot = "6")]
		public override void GetProgerss(int curScore)
		{
		}

		// Token: 0x060153D3 RID: 86995 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60153D3")]
		[Address(RVA = "0xDC1D60", Offset = "0xDC0960", VA = "0x180DC1D60", Slot = "7")]
		public override void UpdatePanelFixed()
		{
		}

		// Token: 0x060153D4 RID: 86996 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60153D4")]
		[Address(RVA = "0xDC1F00", Offset = "0xDC0B00", VA = "0x180DC1F00", Slot = "8")]
		public override void UpdatePanel()
		{
		}

		// Token: 0x060153D5 RID: 86997 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60153D5")]
		[Address(RVA = "0xDC2320", Offset = "0xDC0F20", VA = "0x180DC2320")]
		public UICooperateTaskTargetPanel()
		{
		}

		// Token: 0x060153D6 RID: 86998 RVA: 0x0008AC60 File Offset: 0x00088E60
		[Token(Token = "0x60153D6")]
		[Address(RVA = "0xDBF3E0", Offset = "0xDBDFE0", VA = "0x180DBF3E0")]
		private CoopStageType <>xLuaBaseProxy_get_type()
		{
			return CoopStageType.BASIC;
		}

		// Token: 0x060153D7 RID: 86999 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60153D7")]
		[Address(RVA = "0xDAA920", Offset = "0xDA9520", VA = "0x180DAA920")]
		private void <>xLuaBaseProxy_LoadDataFromBuff(ObjectPtr<Buff> P0)
		{
		}

		// Token: 0x060153D8 RID: 87000 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60153D8")]
		[Address(RVA = "0xDBDC30", Offset = "0xDBC830", VA = "0x180DBDC30")]
		private void <>xLuaBaseProxy_GetProgerss(int P0)
		{
		}

		// Token: 0x060153D9 RID: 87001 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60153D9")]
		[Address(RVA = "0xDAA940", Offset = "0xDA9540", VA = "0x180DAA940")]
		private void <>xLuaBaseProxy_UpdatePanelFixed()
		{
		}

		// Token: 0x060153DA RID: 87002 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60153DA")]
		[Address(RVA = "0xDBF040", Offset = "0xDBDC40", VA = "0x180DBF040")]
		private void <>xLuaBaseProxy_UpdatePanel()
		{
		}

		// Token: 0x040195FA RID: 103930
		[Token(Token = "0x40195FA")]
		[FieldOffset(Offset = "0x70")]
		private int m_totalCnt;

		// Token: 0x040195FB RID: 103931
		[Token(Token = "0x40195FB")]
		[FieldOffset(Offset = "0x74")]
		private int m_basicTotalCnt;

		// Token: 0x040195FC RID: 103932
		[Token(Token = "0x40195FC")]
		[FieldOffset(Offset = "0x78")]
		private int m_curCnt;

		// Token: 0x040195FD RID: 103933
		[Token(Token = "0x40195FD")]
		[FieldOffset(Offset = "0x7C")]
		private int m_cachedCurCnt;

		// Token: 0x040195FE RID: 103934
		[Token(Token = "0x40195FE")]
		[FieldOffset(Offset = "0x80")]
		private FP m_basicAccomplish;

		// Token: 0x040195FF RID: 103935
		[Token(Token = "0x40195FF")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_type;

		// Token: 0x04019600 RID: 103936
		[Token(Token = "0x4019600")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_LoadDataFromBuff;

		// Token: 0x04019601 RID: 103937
		[Token(Token = "0x4019601")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_GetProgerss;

		// Token: 0x04019602 RID: 103938
		[Token(Token = "0x4019602")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_UpdatePanelFixed;

		// Token: 0x04019603 RID: 103939
		[Token(Token = "0x4019603")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_UpdatePanel;

		// Token: 0x04019604 RID: 103940
		[Token(Token = "0x4019604")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}

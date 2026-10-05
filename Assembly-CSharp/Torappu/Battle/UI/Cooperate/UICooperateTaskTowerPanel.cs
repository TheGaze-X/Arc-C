using System;
using Il2CppDummyDll;
using Torappu.Battle.Cooperate;
using XLua;

namespace Torappu.Battle.UI.Cooperate
{
	// Token: 0x020033FA RID: 13306
	[Token(Token = "0x20033FA")]
	public class UICooperateTaskTowerPanel : UICooperateTaskPanel
	{
		// Token: 0x1700325B RID: 12891
		// (get) Token: 0x060153DB RID: 87003 RVA: 0x0008AC78 File Offset: 0x00088E78
		[Token(Token = "0x1700325B")]
		public override CoopStageType type
		{
			[Token(Token = "0x60153DB")]
			[Address(RVA = "0xDC3270", Offset = "0xDC1E70", VA = "0x180DC3270", Slot = "4")]
			get
			{
				return CoopStageType.BASIC;
			}
		}

		// Token: 0x060153DC RID: 87004 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60153DC")]
		[Address(RVA = "0xDC2570", Offset = "0xDC1170", VA = "0x180DC2570", Slot = "5")]
		public override void LoadDataFromBuff(ObjectPtr<Buff> buff)
		{
		}

		// Token: 0x060153DD RID: 87005 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60153DD")]
		[Address(RVA = "0xDC2420", Offset = "0xDC1020", VA = "0x180DC2420", Slot = "6")]
		public override void GetProgerss(int curScore)
		{
		}

		// Token: 0x060153DE RID: 87006 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60153DE")]
		[Address(RVA = "0xDC2C10", Offset = "0xDC1810", VA = "0x180DC2C10", Slot = "7")]
		public override void UpdatePanelFixed()
		{
		}

		// Token: 0x060153DF RID: 87007 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60153DF")]
		[Address(RVA = "0xDC2DB0", Offset = "0xDC19B0", VA = "0x180DC2DB0", Slot = "8")]
		public override void UpdatePanel()
		{
		}

		// Token: 0x060153E0 RID: 87008 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60153E0")]
		[Address(RVA = "0xDC31D0", Offset = "0xDC1DD0", VA = "0x180DC31D0")]
		public UICooperateTaskTowerPanel()
		{
		}

		// Token: 0x060153E1 RID: 87009 RVA: 0x0008AC90 File Offset: 0x00088E90
		[Token(Token = "0x60153E1")]
		[Address(RVA = "0xDBF3E0", Offset = "0xDBDFE0", VA = "0x180DBF3E0")]
		private CoopStageType <>xLuaBaseProxy_get_type()
		{
			return CoopStageType.BASIC;
		}

		// Token: 0x060153E2 RID: 87010 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60153E2")]
		[Address(RVA = "0xDAA920", Offset = "0xDA9520", VA = "0x180DAA920")]
		private void <>xLuaBaseProxy_LoadDataFromBuff(ObjectPtr<Buff> P0)
		{
		}

		// Token: 0x060153E3 RID: 87011 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60153E3")]
		[Address(RVA = "0xDBDC30", Offset = "0xDBC830", VA = "0x180DBDC30")]
		private void <>xLuaBaseProxy_GetProgerss(int P0)
		{
		}

		// Token: 0x060153E4 RID: 87012 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60153E4")]
		[Address(RVA = "0xDAA940", Offset = "0xDA9540", VA = "0x180DAA940")]
		private void <>xLuaBaseProxy_UpdatePanelFixed()
		{
		}

		// Token: 0x060153E5 RID: 87013 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60153E5")]
		[Address(RVA = "0xDBF040", Offset = "0xDBDC40", VA = "0x180DBF040")]
		private void <>xLuaBaseProxy_UpdatePanel()
		{
		}

		// Token: 0x04019605 RID: 103941
		[Token(Token = "0x4019605")]
		private const string POINT = "point";

		// Token: 0x04019606 RID: 103942
		[Token(Token = "0x4019606")]
		[FieldOffset(Offset = "0x70")]
		private int m_totalCnt;

		// Token: 0x04019607 RID: 103943
		[Token(Token = "0x4019607")]
		[FieldOffset(Offset = "0x74")]
		private int m_basicTotalCnt;

		// Token: 0x04019608 RID: 103944
		[Token(Token = "0x4019608")]
		[FieldOffset(Offset = "0x78")]
		private int m_curCnt;

		// Token: 0x04019609 RID: 103945
		[Token(Token = "0x4019609")]
		[FieldOffset(Offset = "0x7C")]
		private int m_cachedCurCnt;

		// Token: 0x0401960A RID: 103946
		[Token(Token = "0x401960A")]
		[FieldOffset(Offset = "0x80")]
		private FP m_basicAccomplish;

		// Token: 0x0401960B RID: 103947
		[Token(Token = "0x401960B")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_type;

		// Token: 0x0401960C RID: 103948
		[Token(Token = "0x401960C")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_LoadDataFromBuff;

		// Token: 0x0401960D RID: 103949
		[Token(Token = "0x401960D")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_GetProgerss;

		// Token: 0x0401960E RID: 103950
		[Token(Token = "0x401960E")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_UpdatePanelFixed;

		// Token: 0x0401960F RID: 103951
		[Token(Token = "0x401960F")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_UpdatePanel;

		// Token: 0x04019610 RID: 103952
		[Token(Token = "0x4019610")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}

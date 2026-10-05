using System;
using Il2CppDummyDll;
using Torappu.Battle.Cooperate;
using XLua;

namespace Torappu.Battle.UI.Cooperate
{
	// Token: 0x020033F8 RID: 13304
	[Token(Token = "0x20033F8")]
	public class UICooperateTaskSurvivePanel : UICooperateTaskPanel
	{
		// Token: 0x17003259 RID: 12889
		// (get) Token: 0x060153C5 RID: 86981 RVA: 0x0008AC18 File Offset: 0x00088E18
		[Token(Token = "0x17003259")]
		public override CoopStageType type
		{
			[Token(Token = "0x60153C5")]
			[Address(RVA = "0xDC1510", Offset = "0xDC0110", VA = "0x180DC1510", Slot = "4")]
			get
			{
				return CoopStageType.BASIC;
			}
		}

		// Token: 0x060153C6 RID: 86982 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60153C6")]
		[Address(RVA = "0xDC05B0", Offset = "0xDBF1B0", VA = "0x180DC05B0", Slot = "5")]
		public override void LoadDataFromBuff(ObjectPtr<Buff> buff)
		{
		}

		// Token: 0x060153C7 RID: 86983 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60153C7")]
		[Address(RVA = "0xDC02D0", Offset = "0xDBEED0", VA = "0x180DC02D0", Slot = "6")]
		public override void GetProgerss(int curScore)
		{
		}

		// Token: 0x060153C8 RID: 86984 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60153C8")]
		[Address(RVA = "0xDC0BF0", Offset = "0xDBF7F0", VA = "0x180DC0BF0", Slot = "7")]
		public override void UpdatePanelFixed()
		{
		}

		// Token: 0x060153C9 RID: 86985 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60153C9")]
		[Address(RVA = "0xDC0E20", Offset = "0xDBFA20", VA = "0x180DC0E20", Slot = "8")]
		public override void UpdatePanel()
		{
		}

		// Token: 0x060153CA RID: 86986 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60153CA")]
		[Address(RVA = "0xDC1470", Offset = "0xDC0070", VA = "0x180DC1470")]
		public UICooperateTaskSurvivePanel()
		{
		}

		// Token: 0x060153CB RID: 86987 RVA: 0x0008AC30 File Offset: 0x00088E30
		[Token(Token = "0x60153CB")]
		[Address(RVA = "0xDBF3E0", Offset = "0xDBDFE0", VA = "0x180DBF3E0")]
		private CoopStageType <>xLuaBaseProxy_get_type()
		{
			return CoopStageType.BASIC;
		}

		// Token: 0x060153CC RID: 86988 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60153CC")]
		[Address(RVA = "0xDAA920", Offset = "0xDA9520", VA = "0x180DAA920")]
		private void <>xLuaBaseProxy_LoadDataFromBuff(ObjectPtr<Buff> P0)
		{
		}

		// Token: 0x060153CD RID: 86989 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60153CD")]
		[Address(RVA = "0xDBDC30", Offset = "0xDBC830", VA = "0x180DBDC30")]
		private void <>xLuaBaseProxy_GetProgerss(int P0)
		{
		}

		// Token: 0x060153CE RID: 86990 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60153CE")]
		[Address(RVA = "0xDAA940", Offset = "0xDA9540", VA = "0x180DAA940")]
		private void <>xLuaBaseProxy_UpdatePanelFixed()
		{
		}

		// Token: 0x060153CF RID: 86991 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60153CF")]
		[Address(RVA = "0xDBF040", Offset = "0xDBDC40", VA = "0x180DBF040")]
		private void <>xLuaBaseProxy_UpdatePanel()
		{
		}

		// Token: 0x040195EF RID: 103919
		[Token(Token = "0x40195EF")]
		[FieldOffset(Offset = "0x70")]
		private FP m_basicAccomplish;

		// Token: 0x040195F0 RID: 103920
		[Token(Token = "0x40195F0")]
		[FieldOffset(Offset = "0x78")]
		private FP m_advanceTime;

		// Token: 0x040195F1 RID: 103921
		[Token(Token = "0x40195F1")]
		[FieldOffset(Offset = "0x80")]
		private FP m_basicTime;

		// Token: 0x040195F2 RID: 103922
		[Token(Token = "0x40195F2")]
		[FieldOffset(Offset = "0x88")]
		private FP m_passTime;

		// Token: 0x040195F3 RID: 103923
		[Token(Token = "0x40195F3")]
		[FieldOffset(Offset = "0x90")]
		private FP m_remainingTime;

		// Token: 0x040195F4 RID: 103924
		[Token(Token = "0x40195F4")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_type;

		// Token: 0x040195F5 RID: 103925
		[Token(Token = "0x40195F5")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_LoadDataFromBuff;

		// Token: 0x040195F6 RID: 103926
		[Token(Token = "0x40195F6")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_GetProgerss;

		// Token: 0x040195F7 RID: 103927
		[Token(Token = "0x40195F7")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_UpdatePanelFixed;

		// Token: 0x040195F8 RID: 103928
		[Token(Token = "0x40195F8")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_UpdatePanel;

		// Token: 0x040195F9 RID: 103929
		[Token(Token = "0x40195F9")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}

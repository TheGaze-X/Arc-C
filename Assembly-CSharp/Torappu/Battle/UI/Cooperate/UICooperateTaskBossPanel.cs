using System;
using Il2CppDummyDll;
using Torappu.Battle.Cooperate;
using XLua;

namespace Torappu.Battle.UI.Cooperate
{
	// Token: 0x020033F1 RID: 13297
	[Token(Token = "0x20033F1")]
	public class UICooperateTaskBossPanel : UICooperateTaskPanel
	{
		// Token: 0x1700324F RID: 12879
		// (get) Token: 0x0601537A RID: 86906 RVA: 0x0008AAF8 File Offset: 0x00088CF8
		[Token(Token = "0x1700324F")]
		public override CoopStageType type
		{
			[Token(Token = "0x601537A")]
			[Address(RVA = "0xDAAFE0", Offset = "0xDA9BE0", VA = "0x180DAAFE0", Slot = "4")]
			get
			{
				return CoopStageType.BASIC;
			}
		}

		// Token: 0x0601537B RID: 86907 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601537B")]
		[Address(RVA = "0xDAA600", Offset = "0xDA9200", VA = "0x180DAA600", Slot = "5")]
		public override void LoadDataFromBuff(ObjectPtr<Buff> buff)
		{
		}

		// Token: 0x0601537C RID: 86908 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601537C")]
		[Address(RVA = "0xDAA350", Offset = "0xDA8F50", VA = "0x180DAA350", Slot = "6")]
		public override void GetProgerss(int curScore)
		{
		}

		// Token: 0x0601537D RID: 86909 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601537D")]
		[Address(RVA = "0xDAA970", Offset = "0xDA9570", VA = "0x180DAA970", Slot = "7")]
		public override void UpdatePanelFixed()
		{
		}

		// Token: 0x0601537E RID: 86910 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601537E")]
		[Address(RVA = "0xDAAAD0", Offset = "0xDA96D0", VA = "0x180DAAAD0", Slot = "8")]
		public override void UpdatePanel()
		{
		}

		// Token: 0x0601537F RID: 86911 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601537F")]
		[Address(RVA = "0xDAAF80", Offset = "0xDA9B80", VA = "0x180DAAF80")]
		public UICooperateTaskBossPanel()
		{
		}

		// Token: 0x06015380 RID: 86912 RVA: 0x0008AB10 File Offset: 0x00088D10
		[Token(Token = "0x6015380")]
		[Address(RVA = "0xDAA960", Offset = "0xDA9560", VA = "0x180DAA960")]
		private CoopStageType <>xLuaBaseProxy_get_type()
		{
			return CoopStageType.BASIC;
		}

		// Token: 0x06015381 RID: 86913 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015381")]
		[Address(RVA = "0xDAA920", Offset = "0xDA9520", VA = "0x180DAA920")]
		private void <>xLuaBaseProxy_LoadDataFromBuff(ObjectPtr<Buff> P0)
		{
		}

		// Token: 0x06015382 RID: 86914 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015382")]
		[Address(RVA = "0xDAA910", Offset = "0xDA9510", VA = "0x180DAA910")]
		private void <>xLuaBaseProxy_GetProgerss(int P0)
		{
		}

		// Token: 0x06015383 RID: 86915 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015383")]
		[Address(RVA = "0xDAA940", Offset = "0xDA9540", VA = "0x180DAA940")]
		private void <>xLuaBaseProxy_UpdatePanelFixed()
		{
		}

		// Token: 0x06015384 RID: 86916 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015384")]
		[Address(RVA = "0xDAA950", Offset = "0xDA9550", VA = "0x180DAA950")]
		private void <>xLuaBaseProxy_UpdatePanel()
		{
		}

		// Token: 0x04019586 RID: 103814
		[Token(Token = "0x4019586")]
		public const string SCORE_FORMAT_BOSS = "{0}/{1}%";

		// Token: 0x04019587 RID: 103815
		[Token(Token = "0x4019587")]
		private const string POINT_RATIO_HP = "point_ratio_hp";

		// Token: 0x04019588 RID: 103816
		[Token(Token = "0x4019588")]
		[FieldOffset(Offset = "0x70")]
		private FP m_totalCnt;

		// Token: 0x04019589 RID: 103817
		[Token(Token = "0x4019589")]
		[FieldOffset(Offset = "0x78")]
		private FP m_basicTotalCnt;

		// Token: 0x0401958A RID: 103818
		[Token(Token = "0x401958A")]
		[FieldOffset(Offset = "0x80")]
		private FP m_curCnt;

		// Token: 0x0401958B RID: 103819
		[Token(Token = "0x401958B")]
		[FieldOffset(Offset = "0x88")]
		private FP m_cachedCurCnt;

		// Token: 0x0401958C RID: 103820
		[Token(Token = "0x401958C")]
		[FieldOffset(Offset = "0x90")]
		private FP m_basicAccomplish;

		// Token: 0x0401958D RID: 103821
		[Token(Token = "0x401958D")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_type;

		// Token: 0x0401958E RID: 103822
		[Token(Token = "0x401958E")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_LoadDataFromBuff;

		// Token: 0x0401958F RID: 103823
		[Token(Token = "0x401958F")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_GetProgerss;

		// Token: 0x04019590 RID: 103824
		[Token(Token = "0x4019590")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_UpdatePanelFixed;

		// Token: 0x04019591 RID: 103825
		[Token(Token = "0x4019591")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_UpdatePanel;

		// Token: 0x04019592 RID: 103826
		[Token(Token = "0x4019592")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}

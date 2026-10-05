using System;
using Il2CppDummyDll;
using Torappu.Battle.Cooperate;
using XLua;

namespace Torappu.Battle.UI.Cooperate
{
	// Token: 0x020033F2 RID: 13298
	[Token(Token = "0x20033F2")]
	public class UICooperateTaskCarPanel : UICooperateTaskPanel
	{
		// Token: 0x17003250 RID: 12880
		// (get) Token: 0x06015385 RID: 86917 RVA: 0x0008AB28 File Offset: 0x00088D28
		[Token(Token = "0x17003250")]
		public override CoopStageType type
		{
			[Token(Token = "0x6015385")]
			[Address(RVA = "0xDABAD0", Offset = "0xDAA6D0", VA = "0x180DABAD0", Slot = "4")]
			get
			{
				return CoopStageType.BASIC;
			}
		}

		// Token: 0x06015386 RID: 86918 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015386")]
		[Address(RVA = "0xDAB220", Offset = "0xDA9E20", VA = "0x180DAB220", Slot = "5")]
		public override void LoadDataFromBuff(ObjectPtr<Buff> buff)
		{
		}

		// Token: 0x06015387 RID: 86919 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015387")]
		[Address(RVA = "0xDAB040", Offset = "0xDA9C40", VA = "0x180DAB040", Slot = "6")]
		public override void GetProgerss(int curScore)
		{
		}

		// Token: 0x06015388 RID: 86920 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015388")]
		[Address(RVA = "0xDAB550", Offset = "0xDAA150", VA = "0x180DAB550", Slot = "7")]
		public override void UpdatePanelFixed()
		{
		}

		// Token: 0x06015389 RID: 86921 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015389")]
		[Address(RVA = "0xDAB6B0", Offset = "0xDAA2B0", VA = "0x180DAB6B0", Slot = "8")]
		public override void UpdatePanel()
		{
		}

		// Token: 0x0601538A RID: 86922 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601538A")]
		[Address(RVA = "0xDABA70", Offset = "0xDAA670", VA = "0x180DABA70")]
		public UICooperateTaskCarPanel()
		{
		}

		// Token: 0x0601538B RID: 86923 RVA: 0x0008AB40 File Offset: 0x00088D40
		[Token(Token = "0x601538B")]
		[Address(RVA = "0xDAA960", Offset = "0xDA9560", VA = "0x180DAA960")]
		private CoopStageType <>xLuaBaseProxy_get_type()
		{
			return CoopStageType.BASIC;
		}

		// Token: 0x0601538C RID: 86924 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601538C")]
		[Address(RVA = "0xDAA920", Offset = "0xDA9520", VA = "0x180DAA920")]
		private void <>xLuaBaseProxy_LoadDataFromBuff(ObjectPtr<Buff> P0)
		{
		}

		// Token: 0x0601538D RID: 86925 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601538D")]
		[Address(RVA = "0xDAA910", Offset = "0xDA9510", VA = "0x180DAA910")]
		private void <>xLuaBaseProxy_GetProgerss(int P0)
		{
		}

		// Token: 0x0601538E RID: 86926 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601538E")]
		[Address(RVA = "0xDAA940", Offset = "0xDA9540", VA = "0x180DAA940")]
		private void <>xLuaBaseProxy_UpdatePanelFixed()
		{
		}

		// Token: 0x0601538F RID: 86927 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601538F")]
		[Address(RVA = "0xDAA950", Offset = "0xDA9550", VA = "0x180DAA950")]
		private void <>xLuaBaseProxy_UpdatePanel()
		{
		}

		// Token: 0x04019593 RID: 103827
		[Token(Token = "0x4019593")]
		private const int TOLERANT_FONT_SCALE = 10;

		// Token: 0x04019594 RID: 103828
		[Token(Token = "0x4019594")]
		private const string CUR_DIST = "cur_dist";

		// Token: 0x04019595 RID: 103829
		[Token(Token = "0x4019595")]
		[FieldOffset(Offset = "0x70")]
		private FP m_curDist;

		// Token: 0x04019596 RID: 103830
		[Token(Token = "0x4019596")]
		[FieldOffset(Offset = "0x78")]
		private FP m_cachedCurDist;

		// Token: 0x04019597 RID: 103831
		[Token(Token = "0x4019597")]
		[FieldOffset(Offset = "0x80")]
		private FP m_maxDist;

		// Token: 0x04019598 RID: 103832
		[Token(Token = "0x4019598")]
		[FieldOffset(Offset = "0x88")]
		private FP m_basicDist;

		// Token: 0x04019599 RID: 103833
		[Token(Token = "0x4019599")]
		[FieldOffset(Offset = "0x90")]
		private FP m_basicAccomplish;

		// Token: 0x0401959A RID: 103834
		[Token(Token = "0x401959A")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_type;

		// Token: 0x0401959B RID: 103835
		[Token(Token = "0x401959B")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_LoadDataFromBuff;

		// Token: 0x0401959C RID: 103836
		[Token(Token = "0x401959C")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_GetProgerss;

		// Token: 0x0401959D RID: 103837
		[Token(Token = "0x401959D")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_UpdatePanelFixed;

		// Token: 0x0401959E RID: 103838
		[Token(Token = "0x401959E")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_UpdatePanel;

		// Token: 0x0401959F RID: 103839
		[Token(Token = "0x401959F")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}

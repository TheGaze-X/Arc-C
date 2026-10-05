using System;
using Il2CppDummyDll;
using Torappu.Battle.Cooperate;
using XLua;

namespace Torappu.Battle.UI.Cooperate
{
	// Token: 0x020033F5 RID: 13301
	[Token(Token = "0x20033F5")]
	public class UICooperateTaskKillPanel : UICooperateTaskPanel
	{
		// Token: 0x17003251 RID: 12881
		// (get) Token: 0x06015398 RID: 86936 RVA: 0x0008AB58 File Offset: 0x00088D58
		[Token(Token = "0x17003251")]
		public override CoopStageType type
		{
			[Token(Token = "0x6015398")]
			[Address(RVA = "0xDACE30", Offset = "0xDABA30", VA = "0x180DACE30", Slot = "4")]
			get
			{
				return CoopStageType.BASIC;
			}
		}

		// Token: 0x06015399 RID: 86937 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015399")]
		[Address(RVA = "0xDAC690", Offset = "0xDAB290", VA = "0x180DAC690", Slot = "5")]
		public override void LoadDataFromBuff(ObjectPtr<Buff> buff)
		{
		}

		// Token: 0x0601539A RID: 86938 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601539A")]
		[Address(RVA = "0xDAC580", Offset = "0xDAB180", VA = "0x180DAC580", Slot = "6")]
		public override void GetProgerss(int curScore)
		{
		}

		// Token: 0x0601539B RID: 86939 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601539B")]
		[Address(RVA = "0xDAC9C0", Offset = "0xDAB5C0", VA = "0x180DAC9C0", Slot = "7")]
		public override void UpdatePanelFixed()
		{
		}

		// Token: 0x0601539C RID: 86940 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601539C")]
		[Address(RVA = "0xDACAE0", Offset = "0xDAB6E0", VA = "0x180DACAE0", Slot = "8")]
		public override void UpdatePanel()
		{
		}

		// Token: 0x0601539D RID: 86941 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601539D")]
		[Address(RVA = "0xDACDD0", Offset = "0xDAB9D0", VA = "0x180DACDD0")]
		public UICooperateTaskKillPanel()
		{
		}

		// Token: 0x0601539E RID: 86942 RVA: 0x0008AB70 File Offset: 0x00088D70
		[Token(Token = "0x601539E")]
		[Address(RVA = "0xDAA960", Offset = "0xDA9560", VA = "0x180DAA960")]
		private CoopStageType <>xLuaBaseProxy_get_type()
		{
			return CoopStageType.BASIC;
		}

		// Token: 0x0601539F RID: 86943 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601539F")]
		[Address(RVA = "0xDAA920", Offset = "0xDA9520", VA = "0x180DAA920")]
		private void <>xLuaBaseProxy_LoadDataFromBuff(ObjectPtr<Buff> P0)
		{
		}

		// Token: 0x060153A0 RID: 86944 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60153A0")]
		[Address(RVA = "0xDAA910", Offset = "0xDA9510", VA = "0x180DAA910")]
		private void <>xLuaBaseProxy_GetProgerss(int P0)
		{
		}

		// Token: 0x060153A1 RID: 86945 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60153A1")]
		[Address(RVA = "0xDAA940", Offset = "0xDA9540", VA = "0x180DAA940")]
		private void <>xLuaBaseProxy_UpdatePanelFixed()
		{
		}

		// Token: 0x060153A2 RID: 86946 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60153A2")]
		[Address(RVA = "0xDAA950", Offset = "0xDA9550", VA = "0x180DAA950")]
		private void <>xLuaBaseProxy_UpdatePanel()
		{
		}

		// Token: 0x040195B2 RID: 103858
		[Token(Token = "0x40195B2")]
		[FieldOffset(Offset = "0x70")]
		private int m_totalCnt;

		// Token: 0x040195B3 RID: 103859
		[Token(Token = "0x40195B3")]
		[FieldOffset(Offset = "0x74")]
		private int m_basicTotalCnt;

		// Token: 0x040195B4 RID: 103860
		[Token(Token = "0x40195B4")]
		[FieldOffset(Offset = "0x78")]
		private int m_curCnt;

		// Token: 0x040195B5 RID: 103861
		[Token(Token = "0x40195B5")]
		[FieldOffset(Offset = "0x7C")]
		private int m_cachedCurCnt;

		// Token: 0x040195B6 RID: 103862
		[Token(Token = "0x40195B6")]
		[FieldOffset(Offset = "0x80")]
		private FP m_basicAccomplish;

		// Token: 0x040195B7 RID: 103863
		[Token(Token = "0x40195B7")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_type;

		// Token: 0x040195B8 RID: 103864
		[Token(Token = "0x40195B8")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_LoadDataFromBuff;

		// Token: 0x040195B9 RID: 103865
		[Token(Token = "0x40195B9")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_GetProgerss;

		// Token: 0x040195BA RID: 103866
		[Token(Token = "0x40195BA")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_UpdatePanelFixed;

		// Token: 0x040195BB RID: 103867
		[Token(Token = "0x40195BB")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_UpdatePanel;

		// Token: 0x040195BC RID: 103868
		[Token(Token = "0x40195BC")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}

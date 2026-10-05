using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.CharacterInfo
{
	// Token: 0x02005F16 RID: 24342
	[Token(Token = "0x2005F16")]
	public class CharacterLvlupSpOpStateBean : IStateBean, IHotfixable
	{
		// Token: 0x06023438 RID: 144440 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023438")]
		[Address(RVA = "0x1DC7A20", Offset = "0x1DC6620", VA = "0x181DC7A20")]
		public void LoadData(CharacterLvlupPage.Param param)
		{
		}

		// Token: 0x06023439 RID: 144441 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023439")]
		[Address(RVA = "0x1DC7D80", Offset = "0x1DC6980", VA = "0x181DC7D80")]
		public CharacterLvlupSpOpStateBean()
		{
		}

		// Token: 0x0403099D RID: 199069
		[Token(Token = "0x403099D")]
		[FieldOffset(Offset = "0x10")]
		public CharacterIllustViewProperty illustProperty;

		// Token: 0x0403099E RID: 199070
		[Token(Token = "0x403099E")]
		[FieldOffset(Offset = "0x18")]
		public SpecialOperatorInfoViewProperty spOpInfoProperty;

		// Token: 0x0403099F RID: 199071
		[Token(Token = "0x403099F")]
		[FieldOffset(Offset = "0x20")]
		public int charInstId;

		// Token: 0x040309A0 RID: 199072
		[Token(Token = "0x40309A0")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_LoadData;

		// Token: 0x040309A1 RID: 199073
		[Token(Token = "0x40309A1")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}

using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.Tuning
{
	// Token: 0x02003CEC RID: 15596
	[Token(Token = "0x2003CEC")]
	public class TuningOrcheModel : IHotfixable
	{
		// Token: 0x17003A11 RID: 14865
		// (get) Token: 0x0601852F RID: 99631 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17003A11")]
		public string orcheId
		{
			[Token(Token = "0x601852F")]
			[Address(RVA = "0x10D96D0", Offset = "0x10D82D0", VA = "0x1810D96D0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17003A12 RID: 14866
		// (get) Token: 0x06018530 RID: 99632 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17003A12")]
		public string orcheName
		{
			[Token(Token = "0x6018530")]
			[Address(RVA = "0x10D9730", Offset = "0x10D8330", VA = "0x1810D9730")]
			get
			{
				return null;
			}
		}

		// Token: 0x17003A13 RID: 14867
		// (get) Token: 0x06018531 RID: 99633 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17003A13")]
		public string orcheDesc
		{
			[Token(Token = "0x6018531")]
			[Address(RVA = "0x10D9670", Offset = "0x10D8270", VA = "0x1810D9670")]
			get
			{
				return null;
			}
		}

		// Token: 0x17003A14 RID: 14868
		// (get) Token: 0x06018532 RID: 99634 RVA: 0x0009A020 File Offset: 0x00098220
		[Token(Token = "0x17003A14")]
		public int sortId
		{
			[Token(Token = "0x6018532")]
			[Address(RVA = "0x10D9790", Offset = "0x10D8390", VA = "0x1810D9790")]
			get
			{
				return 0;
			}
		}

		// Token: 0x06018533 RID: 99635 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018533")]
		[Address(RVA = "0x10D9560", Offset = "0x10D8160", VA = "0x1810D9560")]
		public void LoadData(Act29SideData.Act29SideOrcheData orcheData)
		{
		}

		// Token: 0x06018534 RID: 99636 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018534")]
		[Address(RVA = "0x10D9610", Offset = "0x10D8210", VA = "0x1810D9610")]
		public TuningOrcheModel()
		{
		}

		// Token: 0x0401DB7A RID: 121722
		[Token(Token = "0x401DB7A")]
		[FieldOffset(Offset = "0x10")]
		private string m_orcheId;

		// Token: 0x0401DB7B RID: 121723
		[Token(Token = "0x401DB7B")]
		[FieldOffset(Offset = "0x18")]
		private string m_orcheName;

		// Token: 0x0401DB7C RID: 121724
		[Token(Token = "0x401DB7C")]
		[FieldOffset(Offset = "0x20")]
		private string m_orcheDesc;

		// Token: 0x0401DB7D RID: 121725
		[Token(Token = "0x401DB7D")]
		[FieldOffset(Offset = "0x28")]
		private int m_sortId;

		// Token: 0x0401DB7E RID: 121726
		[Token(Token = "0x401DB7E")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_orcheId;

		// Token: 0x0401DB7F RID: 121727
		[Token(Token = "0x401DB7F")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_orcheName;

		// Token: 0x0401DB80 RID: 121728
		[Token(Token = "0x401DB80")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_orcheDesc;

		// Token: 0x0401DB81 RID: 121729
		[Token(Token = "0x401DB81")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_get_sortId;

		// Token: 0x0401DB82 RID: 121730
		[Token(Token = "0x401DB82")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_LoadData;

		// Token: 0x0401DB83 RID: 121731
		[Token(Token = "0x401DB83")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}

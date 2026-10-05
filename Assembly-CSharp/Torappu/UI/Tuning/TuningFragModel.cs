using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.Tuning
{
	// Token: 0x02003CEB RID: 15595
	[Token(Token = "0x2003CEB")]
	public class TuningFragModel : IHotfixable
	{
		// Token: 0x17003A09 RID: 14857
		// (get) Token: 0x06018521 RID: 99617 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17003A09")]
		public string fragId
		{
			[Token(Token = "0x6018521")]
			[Address(RVA = "0x10D9320", Offset = "0x10D7F20", VA = "0x1810D9320")]
			get
			{
				return null;
			}
		}

		// Token: 0x17003A0A RID: 14858
		// (get) Token: 0x06018522 RID: 99618 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17003A0A")]
		public string fragName
		{
			[Token(Token = "0x6018522")]
			[Address(RVA = "0x10D9380", Offset = "0x10D7F80", VA = "0x1810D9380")]
			get
			{
				return null;
			}
		}

		// Token: 0x17003A0B RID: 14859
		// (get) Token: 0x06018523 RID: 99619 RVA: 0x00099F90 File Offset: 0x00098190
		[Token(Token = "0x17003A0B")]
		public int fragNum
		{
			[Token(Token = "0x6018523")]
			[Address(RVA = "0x10D93E0", Offset = "0x10D7FE0", VA = "0x1810D93E0")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17003A0C RID: 14860
		// (get) Token: 0x06018524 RID: 99620 RVA: 0x00099FA8 File Offset: 0x000981A8
		[Token(Token = "0x17003A0C")]
		public int displayFragNum
		{
			[Token(Token = "0x6018524")]
			[Address(RVA = "0x10D9260", Offset = "0x10D7E60", VA = "0x1810D9260")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17003A0D RID: 14861
		// (get) Token: 0x06018525 RID: 99621 RVA: 0x00099FC0 File Offset: 0x000981C0
		[Token(Token = "0x17003A0D")]
		public int selectFragNum
		{
			[Token(Token = "0x6018525")]
			[Address(RVA = "0x10D94A0", Offset = "0x10D80A0", VA = "0x1810D94A0")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17003A0E RID: 14862
		// (get) Token: 0x06018526 RID: 99622 RVA: 0x00099FD8 File Offset: 0x000981D8
		[Token(Token = "0x17003A0E")]
		public int sortId
		{
			[Token(Token = "0x6018526")]
			[Address(RVA = "0x10D9500", Offset = "0x10D8100", VA = "0x1810D9500")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17003A0F RID: 14863
		// (get) Token: 0x06018527 RID: 99623 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17003A0F")]
		public string fragFormIconId
		{
			[Token(Token = "0x6018527")]
			[Address(RVA = "0x10D92C0", Offset = "0x10D7EC0", VA = "0x1810D92C0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17003A10 RID: 14864
		// (get) Token: 0x06018528 RID: 99624 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17003A10")]
		public string fragSmallIconId
		{
			[Token(Token = "0x6018528")]
			[Address(RVA = "0x10D9440", Offset = "0x10D8040", VA = "0x1810D9440")]
			get
			{
				return null;
			}
		}

		// Token: 0x06018529 RID: 99625 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018529")]
		[Address(RVA = "0x10D9060", Offset = "0x10D7C60", VA = "0x1810D9060")]
		public void LoadData(Act29SideData.Act29SideFragData fragData)
		{
		}

		// Token: 0x0601852A RID: 99626 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601852A")]
		[Address(RVA = "0x10D9190", Offset = "0x10D7D90", VA = "0x1810D9190")]
		public void UpdateNum(int num)
		{
		}

		// Token: 0x0601852B RID: 99627 RVA: 0x00099FF0 File Offset: 0x000981F0
		[Token(Token = "0x601852B")]
		[Address(RVA = "0x10D8FA0", Offset = "0x10D7BA0", VA = "0x1810D8FA0")]
		public bool CheckIfDisplayNumZero()
		{
			return default(bool);
		}

		// Token: 0x0601852C RID: 99628 RVA: 0x0009A008 File Offset: 0x00098208
		[Token(Token = "0x601852C")]
		[Address(RVA = "0x10D9120", Offset = "0x10D7D20", VA = "0x1810D9120")]
		public bool TrySelectFrag()
		{
			return default(bool);
		}

		// Token: 0x0601852D RID: 99629 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601852D")]
		[Address(RVA = "0x10D9000", Offset = "0x10D7C00", VA = "0x1810D9000")]
		public void ClearSelectFrag()
		{
		}

		// Token: 0x0601852E RID: 99630 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601852E")]
		[Address(RVA = "0x10D9200", Offset = "0x10D7E00", VA = "0x1810D9200")]
		public TuningFragModel()
		{
		}

		// Token: 0x0401DB65 RID: 121701
		[Token(Token = "0x401DB65")]
		[FieldOffset(Offset = "0x10")]
		private string m_fragId;

		// Token: 0x0401DB66 RID: 121702
		[Token(Token = "0x401DB66")]
		[FieldOffset(Offset = "0x18")]
		private string m_fragName;

		// Token: 0x0401DB67 RID: 121703
		[Token(Token = "0x401DB67")]
		[FieldOffset(Offset = "0x20")]
		private int m_fragNum;

		// Token: 0x0401DB68 RID: 121704
		[Token(Token = "0x401DB68")]
		[FieldOffset(Offset = "0x24")]
		private int m_selectFragNum;

		// Token: 0x0401DB69 RID: 121705
		[Token(Token = "0x401DB69")]
		[FieldOffset(Offset = "0x28")]
		private int m_sortId;

		// Token: 0x0401DB6A RID: 121706
		[Token(Token = "0x401DB6A")]
		[FieldOffset(Offset = "0x30")]
		private string m_fragFormIconId;

		// Token: 0x0401DB6B RID: 121707
		[Token(Token = "0x401DB6B")]
		[FieldOffset(Offset = "0x38")]
		private string m_fragSmallIconId;

		// Token: 0x0401DB6C RID: 121708
		[Token(Token = "0x401DB6C")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_fragId;

		// Token: 0x0401DB6D RID: 121709
		[Token(Token = "0x401DB6D")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_fragName;

		// Token: 0x0401DB6E RID: 121710
		[Token(Token = "0x401DB6E")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_fragNum;

		// Token: 0x0401DB6F RID: 121711
		[Token(Token = "0x401DB6F")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_get_displayFragNum;

		// Token: 0x0401DB70 RID: 121712
		[Token(Token = "0x401DB70")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_get_selectFragNum;

		// Token: 0x0401DB71 RID: 121713
		[Token(Token = "0x401DB71")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_get_sortId;

		// Token: 0x0401DB72 RID: 121714
		[Token(Token = "0x401DB72")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_get_fragFormIconId;

		// Token: 0x0401DB73 RID: 121715
		[Token(Token = "0x401DB73")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_get_fragSmallIconId;

		// Token: 0x0401DB74 RID: 121716
		[Token(Token = "0x401DB74")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_LoadData;

		// Token: 0x0401DB75 RID: 121717
		[Token(Token = "0x401DB75")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_UpdateNum;

		// Token: 0x0401DB76 RID: 121718
		[Token(Token = "0x401DB76")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_CheckIfDisplayNumZero;

		// Token: 0x0401DB77 RID: 121719
		[Token(Token = "0x401DB77")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_TrySelectFrag;

		// Token: 0x0401DB78 RID: 121720
		[Token(Token = "0x401DB78")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0_ClearSelectFrag;

		// Token: 0x0401DB79 RID: 121721
		[Token(Token = "0x401DB79")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}

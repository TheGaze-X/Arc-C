using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.UI.CharacterShow;
using XLua;

namespace Torappu.UI.SpecialOperator
{
	// Token: 0x02003E42 RID: 15938
	[Token(Token = "0x2003E42")]
	public class SpecialOperatorBoardSummaryModel : IHotfixable
	{
		// Token: 0x17003AF4 RID: 15092
		// (get) Token: 0x06018C26 RID: 101414 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17003AF4")]
		public CharacterShowV2Model charShowModel
		{
			[Token(Token = "0x6018C26")]
			[Address(RVA = "0x1176E70", Offset = "0x1175A70", VA = "0x181176E70")]
			get
			{
				return null;
			}
		}

		// Token: 0x06018C27 RID: 101415 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018C27")]
		[Address(RVA = "0x1176830", Offset = "0x1175430", VA = "0x181176830")]
		public void InitData(string charId)
		{
		}

		// Token: 0x06018C28 RID: 101416 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018C28")]
		[Address(RVA = "0x1176920", Offset = "0x1175520", VA = "0x181176920")]
		private void _InitMasterList(string charId)
		{
		}

		// Token: 0x06018C29 RID: 101417 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018C29")]
		[Address(RVA = "0x11768C0", Offset = "0x11754C0", VA = "0x1811768C0")]
		public void RefreshData()
		{
		}

		// Token: 0x06018C2A RID: 101418 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018C2A")]
		[Address(RVA = "0x1176650", Offset = "0x1175250", VA = "0x181176650")]
		public void CalcTalentCnt(out int totalCnt, out int unlockCnt)
		{
		}

		// Token: 0x06018C2B RID: 101419 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018C2B")]
		[Address(RVA = "0x11764E0", Offset = "0x11750E0", VA = "0x1811764E0")]
		public void CalcMasterCnt(out int totalCnt, out int unlockCnt)
		{
		}

		// Token: 0x06018C2C RID: 101420 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018C2C")]
		[Address(RVA = "0x1176BD0", Offset = "0x11757D0", VA = "0x181176BD0")]
		private void _RefreshData()
		{
		}

		// Token: 0x06018C2D RID: 101421 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018C2D")]
		[Address(RVA = "0x1176D80", Offset = "0x1175980", VA = "0x181176D80")]
		public SpecialOperatorBoardSummaryModel()
		{
		}

		// Token: 0x0401E6F0 RID: 124656
		[Token(Token = "0x401E6F0")]
		[FieldOffset(Offset = "0x10")]
		private string m_charId;

		// Token: 0x0401E6F1 RID: 124657
		[Token(Token = "0x401E6F1")]
		[FieldOffset(Offset = "0x18")]
		private CharacterShowV2Model m_charShowModel;

		// Token: 0x0401E6F2 RID: 124658
		[Token(Token = "0x401E6F2")]
		[FieldOffset(Offset = "0x20")]
		private List<SpecialOperatorBoardSummaryModel.MasterModel> m_masterList;

		// Token: 0x0401E6F3 RID: 124659
		[Token(Token = "0x401E6F3")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_charShowModel;

		// Token: 0x0401E6F4 RID: 124660
		[Token(Token = "0x401E6F4")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_InitData;

		// Token: 0x0401E6F5 RID: 124661
		[Token(Token = "0x401E6F5")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__InitMasterList;

		// Token: 0x0401E6F6 RID: 124662
		[Token(Token = "0x401E6F6")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_RefreshData;

		// Token: 0x0401E6F7 RID: 124663
		[Token(Token = "0x401E6F7")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_CalcTalentCnt;

		// Token: 0x0401E6F8 RID: 124664
		[Token(Token = "0x401E6F8")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_CalcMasterCnt;

		// Token: 0x0401E6F9 RID: 124665
		[Token(Token = "0x401E6F9")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__RefreshData;

		// Token: 0x0401E6FA RID: 124666
		[Token(Token = "0x401E6FA")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02003E43 RID: 15939
		[Token(Token = "0x2003E43")]
		public class MasterModel
		{
			// Token: 0x17003AF5 RID: 15093
			// (get) Token: 0x06018C2E RID: 101422 RVA: 0x0009B940 File Offset: 0x00099B40
			[Token(Token = "0x17003AF5")]
			public bool isUnlock
			{
				[Token(Token = "0x6018C2E")]
				[Address(RVA = "0x4F4E70", Offset = "0x4F3A70", VA = "0x1804F4E70")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x06018C2F RID: 101423 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6018C2F")]
			[Address(RVA = "0x4EEA40", Offset = "0x4ED640", VA = "0x1804EEA40")]
			public void LoadData(string masterId, CharMasterBasicData masterData)
			{
			}

			// Token: 0x06018C30 RID: 101424 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6018C30")]
			[Address(RVA = "0x116A960", Offset = "0x1169560", VA = "0x18116A960")]
			public void UpdatePlayerdata(PlayerCharacter playerChar)
			{
			}

			// Token: 0x06018C31 RID: 101425 RVA: 0x0009B958 File Offset: 0x00099B58
			[Token(Token = "0x6018C31")]
			[Address(RVA = "0x116A9E0", Offset = "0x11695E0", VA = "0x18116A9E0")]
			private bool _CalcUnlockStatus(PlayerCharacter playerChar)
			{
				return default(bool);
			}

			// Token: 0x06018C32 RID: 101426 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6018C32")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public MasterModel()
			{
			}

			// Token: 0x0401E6FB RID: 124667
			[Token(Token = "0x401E6FB")]
			[FieldOffset(Offset = "0x10")]
			private string m_masterId;

			// Token: 0x0401E6FC RID: 124668
			[Token(Token = "0x401E6FC")]
			[FieldOffset(Offset = "0x18")]
			private bool m_isUnlock;
		}
	}
}

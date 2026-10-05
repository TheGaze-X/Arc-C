using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.AutoChess.CharSelect
{
	// Token: 0x020063BD RID: 25533
	[Token(Token = "0x20063BD")]
	public class AutoChessCharSelectChessFeatureGroupModel : IHotfixable
	{
		// Token: 0x170056E3 RID: 22243
		// (get) Token: 0x06024CF5 RID: 150773 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06024CF6 RID: 150774 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170056E3")]
		public string chessId
		{
			[Token(Token = "0x6024CF5")]
			[Address(RVA = "0x1FB4A80", Offset = "0x1FB3680", VA = "0x181FB4A80")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6024CF6")]
			[Address(RVA = "0x1FB4C20", Offset = "0x1FB3820", VA = "0x181FB4C20")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170056E4 RID: 22244
		// (get) Token: 0x06024CF7 RID: 150775 RVA: 0x000C5850 File Offset: 0x000C3A50
		// (set) Token: 0x06024CF8 RID: 150776 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170056E4")]
		public FloatType floatType
		{
			[Token(Token = "0x6024CF7")]
			[Address(RVA = "0x1FB4AE0", Offset = "0x1FB36E0", VA = "0x181FB4AE0")]
			[CompilerGenerated]
			get
			{
				return FloatType.NONE;
			}
			[Token(Token = "0x6024CF8")]
			[Address(RVA = "0x1FB4CA0", Offset = "0x1FB38A0", VA = "0x181FB4CA0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170056E5 RID: 22245
		// (get) Token: 0x06024CF9 RID: 150777 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06024CFA RID: 150778 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170056E5")]
		public AutoChessShopCharChessGarrisonModel garrison
		{
			[Token(Token = "0x6024CF9")]
			[Address(RVA = "0x1FB4B40", Offset = "0x1FB3740", VA = "0x181FB4B40")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6024CFA")]
			[Address(RVA = "0x1FB4D10", Offset = "0x1FB3910", VA = "0x181FB4D10")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170056E6 RID: 22246
		// (get) Token: 0x06024CFB RID: 150779 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06024CFC RID: 150780 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170056E6")]
		public IList<AutoChessShopCharChessBondModel> bonds
		{
			[Token(Token = "0x6024CFB")]
			[Address(RVA = "0x1FB4A20", Offset = "0x1FB3620", VA = "0x181FB4A20")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6024CFC")]
			[Address(RVA = "0x1FB4BA0", Offset = "0x1FB37A0", VA = "0x181FB4BA0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x06024CFD RID: 150781 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024CFD")]
		[Address(RVA = "0x1FB49C0", Offset = "0x1FB35C0", VA = "0x181FB49C0")]
		public AutoChessCharSelectChessFeatureGroupModel()
		{
		}

		// Token: 0x0403376E RID: 210798
		[Token(Token = "0x403376E")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_chessId;

		// Token: 0x0403376F RID: 210799
		[Token(Token = "0x403376F")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_chessId;

		// Token: 0x04033770 RID: 210800
		[Token(Token = "0x4033770")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_floatType;

		// Token: 0x04033771 RID: 210801
		[Token(Token = "0x4033771")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_set_floatType;

		// Token: 0x04033772 RID: 210802
		[Token(Token = "0x4033772")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_get_garrison;

		// Token: 0x04033773 RID: 210803
		[Token(Token = "0x4033773")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_set_garrison;

		// Token: 0x04033774 RID: 210804
		[Token(Token = "0x4033774")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_get_bonds;

		// Token: 0x04033775 RID: 210805
		[Token(Token = "0x4033775")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_set_bonds;

		// Token: 0x04033776 RID: 210806
		[Token(Token = "0x4033776")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}

using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.AutoChess
{
	// Token: 0x02006332 RID: 25394
	[Token(Token = "0x2006332")]
	public class AutoChessShopTrapCardViewModel : IHotfixable, IComparable<AutoChessShopTrapCardViewModel>
	{
		// Token: 0x17005652 RID: 22098
		// (get) Token: 0x060249CA RID: 149962 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060249CB RID: 149963 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17005652")]
		public string chessId
		{
			[Token(Token = "0x60249CA")]
			[Address(RVA = "0x1F7D260", Offset = "0x1F7BE60", VA = "0x181F7D260")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60249CB")]
			[Address(RVA = "0x1F7D4A0", Offset = "0x1F7C0A0", VA = "0x181F7D4A0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17005653 RID: 22099
		// (get) Token: 0x060249CC RID: 149964 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060249CD RID: 149965 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17005653")]
		public string trapId
		{
			[Token(Token = "0x60249CC")]
			[Address(RVA = "0x1F7D380", Offset = "0x1F7BF80", VA = "0x181F7D380")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60249CD")]
			[Address(RVA = "0x1F7D600", Offset = "0x1F7C200", VA = "0x181F7D600")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17005654 RID: 22100
		// (get) Token: 0x060249CE RID: 149966 RVA: 0x000C4DE8 File Offset: 0x000C2FE8
		// (set) Token: 0x060249CF RID: 149967 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17005654")]
		public int chessLevel
		{
			[Token(Token = "0x60249CE")]
			[Address(RVA = "0x1F7D2C0", Offset = "0x1F7BEC0", VA = "0x181F7D2C0")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[Token(Token = "0x60249CF")]
			[Address(RVA = "0x1F7D520", Offset = "0x1F7C120", VA = "0x181F7D520")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17005655 RID: 22101
		// (get) Token: 0x060249D0 RID: 149968 RVA: 0x000C4E00 File Offset: 0x000C3000
		// (set) Token: 0x060249D1 RID: 149969 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17005655")]
		public AutoChessItemType trapChessType
		{
			[Token(Token = "0x60249D0")]
			[Address(RVA = "0x1F7D320", Offset = "0x1F7BF20", VA = "0x181F7D320")]
			[CompilerGenerated]
			get
			{
				return AutoChessItemType.CHAR;
			}
			[Token(Token = "0x60249D1")]
			[Address(RVA = "0x1F7D590", Offset = "0x1F7C190", VA = "0x181F7D590")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17005656 RID: 22102
		// (get) Token: 0x060249D2 RID: 149970 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060249D3 RID: 149971 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17005656")]
		public string trapItemName
		{
			[Token(Token = "0x60249D2")]
			[Address(RVA = "0x1F7D440", Offset = "0x1F7C040", VA = "0x181F7D440")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60249D3")]
			[Address(RVA = "0x1F7D700", Offset = "0x1F7C300", VA = "0x181F7D700")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17005657 RID: 22103
		// (get) Token: 0x060249D4 RID: 149972 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060249D5 RID: 149973 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17005657")]
		public string trapItemDesc
		{
			[Token(Token = "0x60249D4")]
			[Address(RVA = "0x1F7D3E0", Offset = "0x1F7BFE0", VA = "0x181F7D3E0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60249D5")]
			[Address(RVA = "0x1F7D680", Offset = "0x1F7C280", VA = "0x181F7D680")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x060249D6 RID: 149974 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60249D6")]
		[Address(RVA = "0x1F7CF30", Offset = "0x1F7BB30", VA = "0x181F7CF30")]
		public void LoadData(ActAutoChessData.ActAutoChessTrapShopChessData trapShopChessData, ActAutoChessData actData)
		{
		}

		// Token: 0x060249D7 RID: 149975 RVA: 0x000C4E18 File Offset: 0x000C3018
		[Token(Token = "0x60249D7")]
		[Address(RVA = "0x1F7CE00", Offset = "0x1F7BA00", VA = "0x181F7CE00", Slot = "4")]
		public int CompareTo(AutoChessShopTrapCardViewModel other)
		{
			return 0;
		}

		// Token: 0x060249D8 RID: 149976 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60249D8")]
		[Address(RVA = "0x1F7D200", Offset = "0x1F7BE00", VA = "0x181F7D200")]
		public AutoChessShopTrapCardViewModel()
		{
		}

		// Token: 0x0403315A RID: 209242
		[Token(Token = "0x403315A")]
		[FieldOffset(Offset = "0x38")]
		private int m_sortId;

		// Token: 0x0403315B RID: 209243
		[Token(Token = "0x403315B")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_chessId;

		// Token: 0x0403315C RID: 209244
		[Token(Token = "0x403315C")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_chessId;

		// Token: 0x0403315D RID: 209245
		[Token(Token = "0x403315D")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_trapId;

		// Token: 0x0403315E RID: 209246
		[Token(Token = "0x403315E")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_set_trapId;

		// Token: 0x0403315F RID: 209247
		[Token(Token = "0x403315F")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_get_chessLevel;

		// Token: 0x04033160 RID: 209248
		[Token(Token = "0x4033160")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_set_chessLevel;

		// Token: 0x04033161 RID: 209249
		[Token(Token = "0x4033161")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_get_trapChessType;

		// Token: 0x04033162 RID: 209250
		[Token(Token = "0x4033162")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_set_trapChessType;

		// Token: 0x04033163 RID: 209251
		[Token(Token = "0x4033163")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_get_trapItemName;

		// Token: 0x04033164 RID: 209252
		[Token(Token = "0x4033164")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_set_trapItemName;

		// Token: 0x04033165 RID: 209253
		[Token(Token = "0x4033165")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_get_trapItemDesc;

		// Token: 0x04033166 RID: 209254
		[Token(Token = "0x4033166")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_set_trapItemDesc;

		// Token: 0x04033167 RID: 209255
		[Token(Token = "0x4033167")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0_LoadData;

		// Token: 0x04033168 RID: 209256
		[Token(Token = "0x4033168")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0_CompareTo;

		// Token: 0x04033169 RID: 209257
		[Token(Token = "0x4033169")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}

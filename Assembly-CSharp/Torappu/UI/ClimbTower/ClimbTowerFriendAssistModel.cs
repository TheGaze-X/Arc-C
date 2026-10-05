using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.ClimbTower
{
	// Token: 0x02005D60 RID: 23904
	[Token(Token = "0x2005D60")]
	public class ClimbTowerFriendAssistModel : IHotfixable
	{
		// Token: 0x17005197 RID: 20887
		// (get) Token: 0x06022A0E RID: 141838 RVA: 0x000BE2F0 File Offset: 0x000BC4F0
		[Token(Token = "0x17005197")]
		public bool isEmpty
		{
			[Token(Token = "0x6022A0E")]
			[Address(RVA = "0x1D177D0", Offset = "0x1D163D0", VA = "0x181D177D0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17005198 RID: 20888
		// (get) Token: 0x06022A0F RID: 141839 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17005198")]
		public CharacterData charData
		{
			[Token(Token = "0x6022A0F")]
			[Address(RVA = "0x1D17770", Offset = "0x1D16370", VA = "0x181D17770")]
			get
			{
				return null;
			}
		}

		// Token: 0x17005199 RID: 20889
		// (get) Token: 0x06022A10 RID: 141840 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17005199")]
		public SquadFriendData assistData
		{
			[Token(Token = "0x6022A10")]
			[Address(RVA = "0x1D17710", Offset = "0x1D16310", VA = "0x181D17710")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700519A RID: 20890
		// (get) Token: 0x06022A11 RID: 141841 RVA: 0x000BE308 File Offset: 0x000BC508
		[Token(Token = "0x1700519A")]
		public bool isFriend
		{
			[Token(Token = "0x6022A11")]
			[Address(RVA = "0x1D17830", Offset = "0x1D16430", VA = "0x181D17830")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06022A12 RID: 141842 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022A12")]
		[Address(RVA = "0x1D174E0", Offset = "0x1D160E0", VA = "0x181D174E0")]
		public void LoadData(SquadFriendData assistData, bool isFriend)
		{
		}

		// Token: 0x06022A13 RID: 141843 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022A13")]
		[Address(RVA = "0x1D17640", Offset = "0x1D16240", VA = "0x181D17640")]
		public void SetEmpty()
		{
		}

		// Token: 0x06022A14 RID: 141844 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022A14")]
		[Address(RVA = "0x1D176B0", Offset = "0x1D162B0", VA = "0x181D176B0")]
		public ClimbTowerFriendAssistModel()
		{
		}

		// Token: 0x0402F96D RID: 194925
		[Token(Token = "0x402F96D")]
		[FieldOffset(Offset = "0x10")]
		private SquadFriendData m_assistData;

		// Token: 0x0402F96E RID: 194926
		[Token(Token = "0x402F96E")]
		[FieldOffset(Offset = "0x18")]
		private bool m_isFriend;

		// Token: 0x0402F96F RID: 194927
		[Token(Token = "0x402F96F")]
		[FieldOffset(Offset = "0x20")]
		private CharacterData m_charData;

		// Token: 0x0402F970 RID: 194928
		[Token(Token = "0x402F970")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_isEmpty;

		// Token: 0x0402F971 RID: 194929
		[Token(Token = "0x402F971")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_charData;

		// Token: 0x0402F972 RID: 194930
		[Token(Token = "0x402F972")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_assistData;

		// Token: 0x0402F973 RID: 194931
		[Token(Token = "0x402F973")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_get_isFriend;

		// Token: 0x0402F974 RID: 194932
		[Token(Token = "0x402F974")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_LoadData;

		// Token: 0x0402F975 RID: 194933
		[Token(Token = "0x402F975")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_SetEmpty;

		// Token: 0x0402F976 RID: 194934
		[Token(Token = "0x402F976")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}

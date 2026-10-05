using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.Roguelike
{
	// Token: 0x020054FD RID: 21757
	[Token(Token = "0x20054FD")]
	public struct RoguelikeShopDetailExtraInfo : IHotfixable
	{
		// Token: 0x17004B0D RID: 19213
		// (get) Token: 0x06020004 RID: 131076 RVA: 0x000B42B8 File Offset: 0x000B24B8
		[Token(Token = "0x17004B0D")]
		public RoguelikeShopDetailExtraInfoType type
		{
			[Token(Token = "0x6020004")]
			[Address(RVA = "0x1A209A0", Offset = "0x1A1F5A0", VA = "0x181A209A0")]
			get
			{
				return RoguelikeShopDetailExtraInfoType.NONE;
			}
		}

		// Token: 0x17004B0E RID: 19214
		// (get) Token: 0x06020005 RID: 131077 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17004B0E")]
		public string tips
		{
			[Token(Token = "0x6020005")]
			[Address(RVA = "0x1A20860", Offset = "0x1A1F460", VA = "0x181A20860")]
			get
			{
				return null;
			}
		}

		// Token: 0x17004B0F RID: 19215
		// (get) Token: 0x06020006 RID: 131078 RVA: 0x000B42D0 File Offset: 0x000B24D0
		[Token(Token = "0x17004B0F")]
		public Color txtCol
		{
			[Token(Token = "0x6020006")]
			[Address(RVA = "0x1A208F0", Offset = "0x1A1F4F0", VA = "0x181A208F0")]
			get
			{
				return default(Color);
			}
		}

		// Token: 0x17004B10 RID: 19216
		// (get) Token: 0x06020007 RID: 131079 RVA: 0x000B42E8 File Offset: 0x000B24E8
		[Token(Token = "0x17004B10")]
		public Color bkgCol
		{
			[Token(Token = "0x6020007")]
			[Address(RVA = "0x1A207B0", Offset = "0x1A1F3B0", VA = "0x181A207B0")]
			get
			{
				return default(Color);
			}
		}

		// Token: 0x06020008 RID: 131080 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020008")]
		[Address(RVA = "0x1A20690", Offset = "0x1A1F290", VA = "0x181A20690")]
		public RoguelikeShopDetailExtraInfo(RoguelikeShopDetailExtraInfoType type, string tips, Color txtCol, Color bkgCol)
		{
		}

		// Token: 0x0402B305 RID: 176901
		[Token(Token = "0x402B305")]
		[FieldOffset(Offset = "0x0")]
		private readonly RoguelikeShopDetailExtraInfoType m_type;

		// Token: 0x0402B306 RID: 176902
		[Token(Token = "0x402B306")]
		[FieldOffset(Offset = "0x8")]
		private readonly string m_tips;

		// Token: 0x0402B307 RID: 176903
		[Token(Token = "0x402B307")]
		[FieldOffset(Offset = "0x10")]
		private readonly Color m_txtCol;

		// Token: 0x0402B308 RID: 176904
		[Token(Token = "0x402B308")]
		[FieldOffset(Offset = "0x20")]
		private readonly Color m_bkgCol;

		// Token: 0x0402B309 RID: 176905
		[Token(Token = "0x402B309")]
		[FieldOffset(Offset = "0x0")]
		public static RoguelikeShopDetailExtraInfo EMPTY;

		// Token: 0x0402B30A RID: 176906
		[Token(Token = "0x402B30A")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_get_type;

		// Token: 0x0402B30B RID: 176907
		[Token(Token = "0x402B30B")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_get_tips;

		// Token: 0x0402B30C RID: 176908
		[Token(Token = "0x402B30C")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_get_txtCol;

		// Token: 0x0402B30D RID: 176909
		[Token(Token = "0x402B30D")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_get_bkgCol;

		// Token: 0x0402B30E RID: 176910
		[Token(Token = "0x402B30E")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}

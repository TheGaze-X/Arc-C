using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.CharacterShow
{
	// Token: 0x02005DE6 RID: 24038
	[Token(Token = "0x2005DE6")]
	public class CharacterShowSkillModel : IHotfixable
	{
		// Token: 0x17005276 RID: 21110
		// (get) Token: 0x06022D5F RID: 142687 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17005276")]
		public SkillData skillData
		{
			[Token(Token = "0x6022D5F")]
			[Address(RVA = "0x1D6F540", Offset = "0x1D6E140", VA = "0x181D6F540")]
			get
			{
				return null;
			}
		}

		// Token: 0x17005277 RID: 21111
		// (get) Token: 0x06022D60 RID: 142688 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17005277")]
		public string skillId
		{
			[Token(Token = "0x6022D60")]
			[Address(RVA = "0x1D6F5A0", Offset = "0x1D6E1A0", VA = "0x181D6F5A0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17005278 RID: 21112
		// (get) Token: 0x06022D61 RID: 142689 RVA: 0x000BF2E0 File Offset: 0x000BD4E0
		[Token(Token = "0x17005278")]
		public bool isUnlock
		{
			[Token(Token = "0x6022D61")]
			[Address(RVA = "0x1D6F3B0", Offset = "0x1D6DFB0", VA = "0x181D6F3B0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17005279 RID: 21113
		// (get) Token: 0x06022D62 RID: 142690 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17005279")]
		public string name
		{
			[Token(Token = "0x6022D62")]
			[Address(RVA = "0x1D6F470", Offset = "0x1D6E070", VA = "0x181D6F470")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700527A RID: 21114
		// (get) Token: 0x06022D63 RID: 142691 RVA: 0x000BF2F8 File Offset: 0x000BD4F8
		[Token(Token = "0x1700527A")]
		public int spCost
		{
			[Token(Token = "0x6022D63")]
			[Address(RVA = "0x1D6F610", Offset = "0x1D6E210", VA = "0x181D6F610")]
			get
			{
				return 0;
			}
		}

		// Token: 0x1700527B RID: 21115
		// (get) Token: 0x06022D64 RID: 142692 RVA: 0x000BF310 File Offset: 0x000BD510
		[Token(Token = "0x1700527B")]
		public int initCost
		{
			[Token(Token = "0x6022D64")]
			[Address(RVA = "0x1D6F2F0", Offset = "0x1D6DEF0", VA = "0x181D6F2F0")]
			get
			{
				return 0;
			}
		}

		// Token: 0x1700527C RID: 21116
		// (get) Token: 0x06022D65 RID: 142693 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700527C")]
		public string desc
		{
			[Token(Token = "0x6022D65")]
			[Address(RVA = "0x1D6F290", Offset = "0x1D6DE90", VA = "0x181D6F290")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700527D RID: 21117
		// (get) Token: 0x06022D66 RID: 142694 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700527D")]
		public string rawDesc
		{
			[Token(Token = "0x6022D66")]
			[Address(RVA = "0x1D6F4E0", Offset = "0x1D6E0E0", VA = "0x181D6F4E0")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700527E RID: 21118
		// (get) Token: 0x06022D67 RID: 142695 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700527E")]
		public List<SkillTagViewModel> tags
		{
			[Token(Token = "0x6022D67")]
			[Address(RVA = "0x1D6F6E0", Offset = "0x1D6E2E0", VA = "0x181D6F6E0")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700527F RID: 21119
		// (get) Token: 0x06022D68 RID: 142696 RVA: 0x000BF328 File Offset: 0x000BD528
		[Token(Token = "0x1700527F")]
		public int mainSkillLv
		{
			[Token(Token = "0x6022D68")]
			[Address(RVA = "0x1D6F410", Offset = "0x1D6E010", VA = "0x181D6F410")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17005280 RID: 21120
		// (get) Token: 0x06022D69 RID: 142697 RVA: 0x000BF340 File Offset: 0x000BD540
		[Token(Token = "0x17005280")]
		public int specLevel
		{
			[Token(Token = "0x6022D69")]
			[Address(RVA = "0x1D6F680", Offset = "0x1D6E280", VA = "0x181D6F680")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17005281 RID: 21121
		// (get) Token: 0x06022D6A RID: 142698 RVA: 0x000BF358 File Offset: 0x000BD558
		[Token(Token = "0x17005281")]
		public CharacterData.UnlockCondition unlockCond
		{
			[Token(Token = "0x6022D6A")]
			[Address(RVA = "0x1D6F7A0", Offset = "0x1D6E3A0", VA = "0x181D6F7A0")]
			get
			{
				return default(CharacterData.UnlockCondition);
			}
		}

		// Token: 0x17005282 RID: 21122
		// (get) Token: 0x06022D6B RID: 142699 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17005282")]
		public string tokenKey
		{
			[Token(Token = "0x6022D6B")]
			[Address(RVA = "0x1D6F740", Offset = "0x1D6E340", VA = "0x181D6F740")]
			get
			{
				return null;
			}
		}

		// Token: 0x06022D6C RID: 142700 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022D6C")]
		[Address(RVA = "0x1D6F090", Offset = "0x1D6DC90", VA = "0x181D6F090")]
		public void LoadData(SkillData skillData, bool isUnlock, int mainSkillLv, int specializeLevel, CharacterData.UnlockCondition unlockCond, string tokenKey)
		{
		}

		// Token: 0x06022D6D RID: 142701 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022D6D")]
		[Address(RVA = "0x1D6F230", Offset = "0x1D6DE30", VA = "0x181D6F230")]
		public CharacterShowSkillModel()
		{
		}

		// Token: 0x0402FF2E RID: 196398
		[Token(Token = "0x402FF2E")]
		[FieldOffset(Offset = "0x10")]
		private SkillData m_skillData;

		// Token: 0x0402FF2F RID: 196399
		[Token(Token = "0x402FF2F")]
		[FieldOffset(Offset = "0x18")]
		private List<SkillTagViewModel> m_tags;

		// Token: 0x0402FF30 RID: 196400
		[Token(Token = "0x402FF30")]
		[FieldOffset(Offset = "0x20")]
		private string m_rawDesc;

		// Token: 0x0402FF31 RID: 196401
		[Token(Token = "0x402FF31")]
		[FieldOffset(Offset = "0x28")]
		private string m_displayDesc;

		// Token: 0x0402FF32 RID: 196402
		[Token(Token = "0x402FF32")]
		[FieldOffset(Offset = "0x30")]
		private bool m_isUnlock;

		// Token: 0x0402FF33 RID: 196403
		[Token(Token = "0x402FF33")]
		[FieldOffset(Offset = "0x34")]
		private int m_mainSkillLv;

		// Token: 0x0402FF34 RID: 196404
		[Token(Token = "0x402FF34")]
		[FieldOffset(Offset = "0x38")]
		private int m_specializeLv;

		// Token: 0x0402FF35 RID: 196405
		[Token(Token = "0x402FF35")]
		[FieldOffset(Offset = "0x3C")]
		private CharacterData.UnlockCondition m_unlockCond;

		// Token: 0x0402FF36 RID: 196406
		[Token(Token = "0x402FF36")]
		[FieldOffset(Offset = "0x48")]
		private string m_tokenKey;

		// Token: 0x0402FF37 RID: 196407
		[Token(Token = "0x402FF37")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_skillData;

		// Token: 0x0402FF38 RID: 196408
		[Token(Token = "0x402FF38")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_skillId;

		// Token: 0x0402FF39 RID: 196409
		[Token(Token = "0x402FF39")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_isUnlock;

		// Token: 0x0402FF3A RID: 196410
		[Token(Token = "0x402FF3A")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_get_name;

		// Token: 0x0402FF3B RID: 196411
		[Token(Token = "0x402FF3B")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_get_spCost;

		// Token: 0x0402FF3C RID: 196412
		[Token(Token = "0x402FF3C")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_get_initCost;

		// Token: 0x0402FF3D RID: 196413
		[Token(Token = "0x402FF3D")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_get_desc;

		// Token: 0x0402FF3E RID: 196414
		[Token(Token = "0x402FF3E")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_get_rawDesc;

		// Token: 0x0402FF3F RID: 196415
		[Token(Token = "0x402FF3F")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_get_tags;

		// Token: 0x0402FF40 RID: 196416
		[Token(Token = "0x402FF40")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_get_mainSkillLv;

		// Token: 0x0402FF41 RID: 196417
		[Token(Token = "0x402FF41")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_get_specLevel;

		// Token: 0x0402FF42 RID: 196418
		[Token(Token = "0x402FF42")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_get_unlockCond;

		// Token: 0x0402FF43 RID: 196419
		[Token(Token = "0x402FF43")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0_get_tokenKey;

		// Token: 0x0402FF44 RID: 196420
		[Token(Token = "0x402FF44")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0_LoadData;

		// Token: 0x0402FF45 RID: 196421
		[Token(Token = "0x402FF45")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}

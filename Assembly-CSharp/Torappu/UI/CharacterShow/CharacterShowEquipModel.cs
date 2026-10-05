using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.CharacterShow
{
	// Token: 0x02005DE7 RID: 24039
	[Token(Token = "0x2005DE7")]
	public class CharacterShowEquipModel : IHotfixable
	{
		// Token: 0x17005283 RID: 21123
		// (get) Token: 0x06022D6E RID: 142702 RVA: 0x000BF370 File Offset: 0x000BD570
		[Token(Token = "0x17005283")]
		public bool isUnlock
		{
			[Token(Token = "0x6022D6E")]
			[Address(RVA = "0x1D6D540", Offset = "0x1D6C140", VA = "0x181D6D540")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17005284 RID: 21124
		// (get) Token: 0x06022D6F RID: 142703 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17005284")]
		public UniEquipData equipData
		{
			[Token(Token = "0x6022D6F")]
			[Address(RVA = "0x1D6D390", Offset = "0x1D6BF90", VA = "0x181D6D390")]
			get
			{
				return null;
			}
		}

		// Token: 0x17005285 RID: 21125
		// (get) Token: 0x06022D70 RID: 142704 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17005285")]
		public string equipId
		{
			[Token(Token = "0x6022D70")]
			[Address(RVA = "0x1D6D3F0", Offset = "0x1D6BFF0", VA = "0x181D6D3F0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17005286 RID: 21126
		// (get) Token: 0x06022D71 RID: 142705 RVA: 0x000BF388 File Offset: 0x000BD588
		[Token(Token = "0x17005286")]
		public UniEquipType equipType
		{
			[Token(Token = "0x6022D71")]
			[Address(RVA = "0x1D6D460", Offset = "0x1D6C060", VA = "0x181D6D460")]
			get
			{
				return UniEquipType.INITIAL;
			}
		}

		// Token: 0x17005287 RID: 21127
		// (get) Token: 0x06022D72 RID: 142706 RVA: 0x000BF3A0 File Offset: 0x000BD5A0
		[Token(Token = "0x17005287")]
		public int sortId
		{
			[Token(Token = "0x6022D72")]
			[Address(RVA = "0x1D6D600", Offset = "0x1D6C200", VA = "0x181D6D600")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17005288 RID: 21128
		// (get) Token: 0x06022D73 RID: 142707 RVA: 0x000BF3B8 File Offset: 0x000BD5B8
		[Token(Token = "0x17005288")]
		public int level
		{
			[Token(Token = "0x6022D73")]
			[Address(RVA = "0x1D6D5A0", Offset = "0x1D6C1A0", VA = "0x181D6D5A0")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17005289 RID: 21129
		// (get) Token: 0x06022D74 RID: 142708 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17005289")]
		public string extraTypeName
		{
			[Token(Token = "0x6022D74")]
			[Address(RVA = "0x1D6D4D0", Offset = "0x1D6C0D0", VA = "0x181D6D4D0")]
			get
			{
				return null;
			}
		}

		// Token: 0x06022D75 RID: 142709 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6022D75")]
		[Address(RVA = "0x1D6D120", Offset = "0x1D6BD20", VA = "0x181D6D120")]
		public List<CharacterData.UniqueEquipPair> CreateUniEquipList()
		{
			return null;
		}

		// Token: 0x06022D76 RID: 142710 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022D76")]
		[Address(RVA = "0x1D6D290", Offset = "0x1D6BE90", VA = "0x181D6D290")]
		public void LoadData(UniEquipData equipData, int level, bool isUnlock)
		{
		}

		// Token: 0x06022D77 RID: 142711 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022D77")]
		[Address(RVA = "0x1D6D330", Offset = "0x1D6BF30", VA = "0x181D6D330")]
		public CharacterShowEquipModel()
		{
		}

		// Token: 0x0402FF46 RID: 196422
		[Token(Token = "0x402FF46")]
		[FieldOffset(Offset = "0x10")]
		private UniEquipData m_equipData;

		// Token: 0x0402FF47 RID: 196423
		[Token(Token = "0x402FF47")]
		[FieldOffset(Offset = "0x18")]
		private int m_level;

		// Token: 0x0402FF48 RID: 196424
		[Token(Token = "0x402FF48")]
		[FieldOffset(Offset = "0x1C")]
		private bool m_isUnlock;

		// Token: 0x0402FF49 RID: 196425
		[Token(Token = "0x402FF49")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_isUnlock;

		// Token: 0x0402FF4A RID: 196426
		[Token(Token = "0x402FF4A")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_equipData;

		// Token: 0x0402FF4B RID: 196427
		[Token(Token = "0x402FF4B")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_equipId;

		// Token: 0x0402FF4C RID: 196428
		[Token(Token = "0x402FF4C")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_get_equipType;

		// Token: 0x0402FF4D RID: 196429
		[Token(Token = "0x402FF4D")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_get_sortId;

		// Token: 0x0402FF4E RID: 196430
		[Token(Token = "0x402FF4E")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_get_level;

		// Token: 0x0402FF4F RID: 196431
		[Token(Token = "0x402FF4F")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_get_extraTypeName;

		// Token: 0x0402FF50 RID: 196432
		[Token(Token = "0x402FF50")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_CreateUniEquipList;

		// Token: 0x0402FF51 RID: 196433
		[Token(Token = "0x402FF51")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_LoadData;

		// Token: 0x0402FF52 RID: 196434
		[Token(Token = "0x402FF52")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}

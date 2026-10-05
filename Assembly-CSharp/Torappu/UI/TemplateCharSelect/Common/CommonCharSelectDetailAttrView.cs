using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.TemplateCharSelect.Common
{
	// Token: 0x02005C0A RID: 23562
	[Token(Token = "0x2005C0A")]
	public class CommonCharSelectDetailAttrView : MonoBehaviour, IHotfixable
	{
		// Token: 0x1700500D RID: 20493
		// (set) Token: 0x0602227D RID: 139901 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700500D")]
		public int maxHp
		{
			[Token(Token = "0x602227D")]
			[Address(RVA = "0x1CAA1E0", Offset = "0x1CA8DE0", VA = "0x181CAA1E0")]
			set
			{
			}
		}

		// Token: 0x1700500E RID: 20494
		// (set) Token: 0x0602227E RID: 139902 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700500E")]
		public int atk
		{
			[Token(Token = "0x602227E")]
			[Address(RVA = "0x1CA9DA0", Offset = "0x1CA89A0", VA = "0x181CA9DA0")]
			set
			{
			}
		}

		// Token: 0x1700500F RID: 20495
		// (set) Token: 0x0602227F RID: 139903 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700500F")]
		public int def
		{
			[Token(Token = "0x602227F")]
			[Address(RVA = "0x1CAA070", Offset = "0x1CA8C70", VA = "0x181CAA070")]
			set
			{
			}
		}

		// Token: 0x17005010 RID: 20496
		// (set) Token: 0x06022280 RID: 139904 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17005010")]
		public float magicRes
		{
			[Token(Token = "0x6022280")]
			[Address(RVA = "0x1CAA120", Offset = "0x1CA8D20", VA = "0x181CAA120")]
			set
			{
			}
		}

		// Token: 0x17005011 RID: 20497
		// (set) Token: 0x06022281 RID: 139905 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17005011")]
		public int reviveTime
		{
			[Token(Token = "0x6022281")]
			[Address(RVA = "0x1CAA290", Offset = "0x1CA8E90", VA = "0x181CAA290")]
			set
			{
			}
		}

		// Token: 0x17005012 RID: 20498
		// (set) Token: 0x06022282 RID: 139906 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17005012")]
		public int cost
		{
			[Token(Token = "0x6022282")]
			[Address(RVA = "0x1CA9FB0", Offset = "0x1CA8BB0", VA = "0x181CA9FB0")]
			set
			{
			}
		}

		// Token: 0x17005013 RID: 20499
		// (set) Token: 0x06022283 RID: 139907 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17005013")]
		public int blockNum
		{
			[Token(Token = "0x6022283")]
			[Address(RVA = "0x1CA9EF0", Offset = "0x1CA8AF0", VA = "0x181CA9EF0")]
			set
			{
			}
		}

		// Token: 0x17005014 RID: 20500
		// (set) Token: 0x06022284 RID: 139908 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17005014")]
		public string attackSpdDesc
		{
			[Token(Token = "0x6022284")]
			[Address(RVA = "0x1CA9E50", Offset = "0x1CA8A50", VA = "0x181CA9E50")]
			set
			{
			}
		}

		// Token: 0x06022285 RID: 139909 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022285")]
		[Address(RVA = "0x1CA9B60", Offset = "0x1CA8760", VA = "0x181CA9B60")]
		public void InitAttrIconSprite()
		{
		}

		// Token: 0x06022286 RID: 139910 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022286")]
		[Address(RVA = "0x1CA9C50", Offset = "0x1CA8850", VA = "0x181CA9C50")]
		private void _SetAttrSprite(Image imgIcon, CharacterSortType sortType)
		{
		}

		// Token: 0x06022287 RID: 139911 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022287")]
		[Address(RVA = "0x1CA9D40", Offset = "0x1CA8940", VA = "0x181CA9D40")]
		public CommonCharSelectDetailAttrView()
		{
		}

		// Token: 0x0402ED4C RID: 191820
		[Token(Token = "0x402ED4C")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Image _iconMaxHp;

		// Token: 0x0402ED4D RID: 191821
		[Token(Token = "0x402ED4D")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Image _iconAtk;

		// Token: 0x0402ED4E RID: 191822
		[Token(Token = "0x402ED4E")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Image _iconDef;

		// Token: 0x0402ED4F RID: 191823
		[Token(Token = "0x402ED4F")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Image _iconRes;

		// Token: 0x0402ED50 RID: 191824
		[Token(Token = "0x402ED50")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Image _iconReviveTime;

		// Token: 0x0402ED51 RID: 191825
		[Token(Token = "0x402ED51")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Image _iconCost;

		// Token: 0x0402ED52 RID: 191826
		[Token(Token = "0x402ED52")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private Image _iconBlockNum;

		// Token: 0x0402ED53 RID: 191827
		[Token(Token = "0x402ED53")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private Image _iconAtkSpeed;

		// Token: 0x0402ED54 RID: 191828
		[Token(Token = "0x402ED54")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private Text _maxHp;

		// Token: 0x0402ED55 RID: 191829
		[Token(Token = "0x402ED55")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private Text _atk;

		// Token: 0x0402ED56 RID: 191830
		[Token(Token = "0x402ED56")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private Text _def;

		// Token: 0x0402ED57 RID: 191831
		[Token(Token = "0x402ED57")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private Text _res;

		// Token: 0x0402ED58 RID: 191832
		[Token(Token = "0x402ED58")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private Text _reviveTimeDesc;

		// Token: 0x0402ED59 RID: 191833
		[Token(Token = "0x402ED59")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private Text _cost;

		// Token: 0x0402ED5A RID: 191834
		[Token(Token = "0x402ED5A")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		private Text _blockNum;

		// Token: 0x0402ED5B RID: 191835
		[Token(Token = "0x402ED5B")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		private Text _attackSpeedDesc;

		// Token: 0x0402ED5C RID: 191836
		[Token(Token = "0x402ED5C")]
		[FieldOffset(Offset = "0x98")]
		private UIPageFinder m_pageFinder;

		// Token: 0x0402ED5D RID: 191837
		[Token(Token = "0x402ED5D")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_set_maxHp;

		// Token: 0x0402ED5E RID: 191838
		[Token(Token = "0x402ED5E")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_atk;

		// Token: 0x0402ED5F RID: 191839
		[Token(Token = "0x402ED5F")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_set_def;

		// Token: 0x0402ED60 RID: 191840
		[Token(Token = "0x402ED60")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_set_magicRes;

		// Token: 0x0402ED61 RID: 191841
		[Token(Token = "0x402ED61")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_set_reviveTime;

		// Token: 0x0402ED62 RID: 191842
		[Token(Token = "0x402ED62")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_set_cost;

		// Token: 0x0402ED63 RID: 191843
		[Token(Token = "0x402ED63")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_set_blockNum;

		// Token: 0x0402ED64 RID: 191844
		[Token(Token = "0x402ED64")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_set_attackSpdDesc;

		// Token: 0x0402ED65 RID: 191845
		[Token(Token = "0x402ED65")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_InitAttrIconSprite;

		// Token: 0x0402ED66 RID: 191846
		[Token(Token = "0x402ED66")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0__SetAttrSprite;

		// Token: 0x0402ED67 RID: 191847
		[Token(Token = "0x402ED67")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}

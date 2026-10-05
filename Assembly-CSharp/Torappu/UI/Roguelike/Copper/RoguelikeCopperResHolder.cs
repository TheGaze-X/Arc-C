using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.Roguelike.Copper
{
	// Token: 0x02005899 RID: 22681
	[Token(Token = "0x2005899")]
	public class RoguelikeCopperResHolder : MonoBehaviour, IHotfixable
	{
		// Token: 0x060211B5 RID: 135605 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60211B5")]
		[Address(RVA = "0x1B7D130", Offset = "0x1B7BD30", VA = "0x181B7D130")]
		public Sprite FindLuckyIconByLuckyLevel(RoguelikeCopperLuckyLevel level)
		{
			return null;
		}

		// Token: 0x060211B6 RID: 135606 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60211B6")]
		[Address(RVA = "0x1B7D040", Offset = "0x1B7BC40", VA = "0x181B7D040")]
		public Sprite FindCopperSimpleFrameByLuckyLevel(RoguelikeCopperLuckyLevel level)
		{
			return null;
		}

		// Token: 0x060211B7 RID: 135607 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60211B7")]
		[Address(RVA = "0x1B7CF70", Offset = "0x1B7BB70", VA = "0x181B7CF70")]
		public GameObject FindCopperParticleFrameByLuckyLevel(RoguelikeCopperLuckyLevel level)
		{
			return null;
		}

		// Token: 0x060211B8 RID: 135608 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60211B8")]
		[Address(RVA = "0x1B7D2E0", Offset = "0x1B7BEE0", VA = "0x181B7D2E0")]
		public Sprite LoadGildTypeIcon(ILoadAsset loader, string gildIcon)
		{
			return null;
		}

		// Token: 0x060211B9 RID: 135609 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60211B9")]
		[Address(RVA = "0x1B7D220", Offset = "0x1B7BE20", VA = "0x181B7D220")]
		public RoguelikeAbstractCopperItemCard GetCopperItemCardBigType()
		{
			return null;
		}

		// Token: 0x060211BA RID: 135610 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60211BA")]
		[Address(RVA = "0x1B7D280", Offset = "0x1B7BE80", VA = "0x181B7D280")]
		public RoguelikeAbstractCopperItemCard GetCopperItemCardSmallType()
		{
			return null;
		}

		// Token: 0x060211BB RID: 135611 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60211BB")]
		[Address(RVA = "0x1B7D520", Offset = "0x1B7C120", VA = "0x181B7D520")]
		private RoguelikeCopperResHolder.CopperLuckyResGroup _FindLuckyResGroup(RoguelikeCopperLuckyLevel level)
		{
			return null;
		}

		// Token: 0x060211BC RID: 135612 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60211BC")]
		[Address(RVA = "0x1B7D600", Offset = "0x1B7C200", VA = "0x181B7D600")]
		public RoguelikeCopperResHolder()
		{
		}

		// Token: 0x0402D138 RID: 184632
		[Token(Token = "0x402D138")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private List<RoguelikeCopperResHolder.CopperLuckyResGroup> _luckyResGroup;

		// Token: 0x0402D139 RID: 184633
		[Token(Token = "0x402D139")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private AutoPackSpriteHub _gildIconHub;

		// Token: 0x0402D13A RID: 184634
		[Token(Token = "0x402D13A")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private RoguelikeAbstractCopperItemCard _copperItemCardBigTypePrefab;

		// Token: 0x0402D13B RID: 184635
		[Token(Token = "0x402D13B")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private RoguelikeAbstractCopperItemCard _copperItemCardSmallTypePrefab;

		// Token: 0x0402D13C RID: 184636
		[Token(Token = "0x402D13C")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_FindLuckyIconByLuckyLevel;

		// Token: 0x0402D13D RID: 184637
		[Token(Token = "0x402D13D")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_FindCopperSimpleFrameByLuckyLevel;

		// Token: 0x0402D13E RID: 184638
		[Token(Token = "0x402D13E")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_FindCopperParticleFrameByLuckyLevel;

		// Token: 0x0402D13F RID: 184639
		[Token(Token = "0x402D13F")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_LoadGildTypeIcon;

		// Token: 0x0402D140 RID: 184640
		[Token(Token = "0x402D140")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_GetCopperItemCardBigType;

		// Token: 0x0402D141 RID: 184641
		[Token(Token = "0x402D141")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_GetCopperItemCardSmallType;

		// Token: 0x0402D142 RID: 184642
		[Token(Token = "0x402D142")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__FindLuckyResGroup;

		// Token: 0x0402D143 RID: 184643
		[Token(Token = "0x402D143")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x0200589A RID: 22682
		[Token(Token = "0x200589A")]
		[Serializable]
		public class CopperLuckyResGroup
		{
			// Token: 0x060211BD RID: 135613 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60211BD")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public CopperLuckyResGroup()
			{
			}

			// Token: 0x0402D144 RID: 184644
			[Token(Token = "0x402D144")]
			[FieldOffset(Offset = "0x10")]
			public RoguelikeCopperLuckyLevel level;

			// Token: 0x0402D145 RID: 184645
			[Token(Token = "0x402D145")]
			[FieldOffset(Offset = "0x18")]
			public Sprite icon;

			// Token: 0x0402D146 RID: 184646
			[Token(Token = "0x402D146")]
			[FieldOffset(Offset = "0x20")]
			public GameObject particleFrame;

			// Token: 0x0402D147 RID: 184647
			[Token(Token = "0x402D147")]
			[FieldOffset(Offset = "0x28")]
			public Sprite simpleFrame;
		}
	}
}

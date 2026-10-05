using System;
using System.Collections.Generic;
using AdvancedInspector;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Battle
{
	// Token: 0x02002522 RID: 9506
	[Token(Token = "0x2002522")]
	public class SecondaryFilterAdvancedSelector : AdvancedSelector
	{
		// Token: 0x1700201B RID: 8219
		// (get) Token: 0x0600F573 RID: 62835 RVA: 0x0005B320 File Offset: 0x00059520
		[Token(Token = "0x1700201B")]
		private bool IsFilterTag
		{
			[Token(Token = "0x600F573")]
			[Address(RVA = "0x6DA450", Offset = "0x6D9050", VA = "0x1806DA450")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700201C RID: 8220
		// (get) Token: 0x0600F574 RID: 62836 RVA: 0x0005B338 File Offset: 0x00059538
		[Token(Token = "0x1700201C")]
		private bool IsFilterBuff
		{
			[Token(Token = "0x600F574")]
			[Address(RVA = "0x6DA3F0", Offset = "0x6D8FF0", VA = "0x1806DA3F0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700201D RID: 8221
		// (get) Token: 0x0600F575 RID: 62837 RVA: 0x0005B350 File Offset: 0x00059550
		[Token(Token = "0x1700201D")]
		private bool IsFilterBuffPairOr
		{
			[Token(Token = "0x600F575")]
			[Address(RVA = "0x6DA390", Offset = "0x6D8F90", VA = "0x1806DA390")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x0600F576 RID: 62838 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F576")]
		[Address(RVA = "0x6D9910", Offset = "0x6D8510", VA = "0x1806D9910", Slot = "37")]
		protected override void OnPostFilter(List<Entity> candidates)
		{
		}

		// Token: 0x0600F577 RID: 62839 RVA: 0x0005B368 File Offset: 0x00059568
		[Token(Token = "0x600F577")]
		[Address(RVA = "0x6D9D80", Offset = "0x6D8980", VA = "0x1806D9D80")]
		private bool _CheckEnemies(DoubleBufferedList<ObjectPtr<Enemy>> enemies)
		{
			return default(bool);
		}

		// Token: 0x0600F578 RID: 62840 RVA: 0x0005B380 File Offset: 0x00059580
		[Token(Token = "0x600F578")]
		[Address(RVA = "0x6D9FB0", Offset = "0x6D8BB0", VA = "0x1806D9FB0")]
		private bool _CheckSecondFilter(Entity entity)
		{
			return default(bool);
		}

		// Token: 0x0600F579 RID: 62841 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F579")]
		[Address(RVA = "0x6DA300", Offset = "0x6D8F00", VA = "0x1806DA300")]
		public SecondaryFilterAdvancedSelector()
		{
		}

		// Token: 0x0600F57A RID: 62842 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F57A")]
		[Address(RVA = "0x69A940", Offset = "0x699540", VA = "0x18069A940")]
		private void <>xLuaBaseProxy_OnPostFilter(List<Entity> P0)
		{
		}

		// Token: 0x04011011 RID: 69649
		[Token(Token = "0x4011011")]
		[FieldOffset(Offset = "0xF0")]
		[SerializeField]
		private SecondaryFilterAdvancedSelector.SecondaryFilterType _secondaryFilter;

		// Token: 0x04011012 RID: 69650
		[Token(Token = "0x4011012")]
		[FieldOffset(Offset = "0xF8")]
		[SerializeField]
		[Inspect("IsFilterTag")]
		private string _filterTag;

		// Token: 0x04011013 RID: 69651
		[Token(Token = "0x4011013")]
		[FieldOffset(Offset = "0x100")]
		[SerializeField]
		[Inspect("IsFilterBuff")]
		private string _buffKey;

		// Token: 0x04011014 RID: 69652
		[Token(Token = "0x4011014")]
		[FieldOffset(Offset = "0x108")]
		[SerializeField]
		[Inspect("IsFilterBuff")]
		private bool _withoutThisBuff;

		// Token: 0x04011015 RID: 69653
		[Token(Token = "0x4011015")]
		[FieldOffset(Offset = "0x109")]
		[SerializeField]
		[Inspect("IsFilterBuff")]
		private bool _filterBuffSource;

		// Token: 0x04011016 RID: 69654
		[Token(Token = "0x4011016")]
		[FieldOffset(Offset = "0x110")]
		[SerializeField]
		[Inspect("IsFilterBuffPairOr")]
		private SecondaryFilterAdvancedSelector.BuffKeyPair[] _buffKeyPairs;

		// Token: 0x04011017 RID: 69655
		[Token(Token = "0x4011017")]
		[FieldOffset(Offset = "0x118")]
		[SerializeField]
		[Inspect("IsFilterBuff")]
		private string _excludeEnemyInRootTileAtFirst;

		// Token: 0x04011018 RID: 69656
		[Token(Token = "0x4011018")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_IsFilterTag;

		// Token: 0x04011019 RID: 69657
		[Token(Token = "0x4011019")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_IsFilterBuff;

		// Token: 0x0401101A RID: 69658
		[Token(Token = "0x401101A")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_IsFilterBuffPairOr;

		// Token: 0x0401101B RID: 69659
		[Token(Token = "0x401101B")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnPostFilter;

		// Token: 0x0401101C RID: 69660
		[Token(Token = "0x401101C")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__CheckEnemies;

		// Token: 0x0401101D RID: 69661
		[Token(Token = "0x401101D")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__CheckSecondFilter;

		// Token: 0x0401101E RID: 69662
		[Token(Token = "0x401101E")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02002523 RID: 9507
		[Token(Token = "0x2002523")]
		public enum SecondaryFilterType
		{
			// Token: 0x04011020 RID: 69664
			[Token(Token = "0x4011020")]
			FLY_FIRST,
			// Token: 0x04011021 RID: 69665
			[Token(Token = "0x4011021")]
			RANGED_APPLYWAY_FIRST,
			// Token: 0x04011022 RID: 69666
			[Token(Token = "0x4011022")]
			SPECIFIED_FILTER_TAG,
			// Token: 0x04011023 RID: 69667
			[Token(Token = "0x4011023")]
			SPECIFIED_BUFF,
			// Token: 0x04011024 RID: 69668
			[Token(Token = "0x4011024")]
			SPECIFIED_BUFF_PAIR_OR,
			// Token: 0x04011025 RID: 69669
			[Token(Token = "0x4011025")]
			MELEE_APPLYWAY_FIRST
		}

		// Token: 0x02002524 RID: 9508
		[Token(Token = "0x2002524")]
		[Serializable]
		public struct BuffKeyPair
		{
			// Token: 0x04011026 RID: 69670
			[Token(Token = "0x4011026")]
			[FieldOffset(Offset = "0x0")]
			[SerializeField]
			public string ownerBuffKey;

			// Token: 0x04011027 RID: 69671
			[Token(Token = "0x4011027")]
			[FieldOffset(Offset = "0x8")]
			[SerializeField]
			public string targetBuffKey;
		}
	}
}

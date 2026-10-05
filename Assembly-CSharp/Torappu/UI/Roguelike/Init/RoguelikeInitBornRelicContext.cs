using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.UI.RoguelikeTopic;
using XLua;

namespace Torappu.UI.Roguelike.Init
{
	// Token: 0x020057C7 RID: 22471
	[Token(Token = "0x20057C7")]
	public class RoguelikeInitBornRelicContext : RoguelikeInitOptionContext
	{
		// Token: 0x17004D11 RID: 19729
		// (get) Token: 0x06020DE0 RID: 134624 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17004D11")]
		public override List<RoguelikeInitOption.Model> list
		{
			[Token(Token = "0x6020DE0")]
			[Address(RVA = "0x1B380C0", Offset = "0x1B36CC0", VA = "0x181B380C0", Slot = "6")]
			get
			{
				return null;
			}
		}

		// Token: 0x17004D12 RID: 19730
		// (get) Token: 0x06020DE1 RID: 134625 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17004D12")]
		public override string name
		{
			[Token(Token = "0x6020DE1")]
			[Address(RVA = "0x1B38120", Offset = "0x1B36D20", VA = "0x181B38120", Slot = "5")]
			get
			{
				return null;
			}
		}

		// Token: 0x06020DE2 RID: 134626 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020DE2")]
		[Address(RVA = "0x1B35940", Offset = "0x1B34540", VA = "0x181B35940", Slot = "4")]
		public override void Load(PlayerRoguelikePendingEvent evt)
		{
		}

		// Token: 0x06020DE3 RID: 134627 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020DE3")]
		[Address(RVA = "0x1B36C70", Offset = "0x1B35870", VA = "0x181B36C70")]
		private void _AddRelic(string index, RoguelikeTopicItemModel itemData, int count, bool isLocked, List<RoguelikeInitOption.Model.EndingFamily> endings, int level)
		{
		}

		// Token: 0x06020DE4 RID: 134628 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6020DE4")]
		[Address(RVA = "0x1B37D60", Offset = "0x1B36960", VA = "0x181B37D60")]
		private List<RoguelikeInitOption.Model.EndingFamily> _GetEndings(string bandGrpId, PlayerRoguelikeV2.OuterData outerData, List<RoguelikeGameEndingData> allEndings, bool showGrade)
		{
			return null;
		}

		// Token: 0x06020DE5 RID: 134629 RVA: 0x000B7A08 File Offset: 0x000B5C08
		[Token(Token = "0x6020DE5")]
		[Address(RVA = "0x1B37240", Offset = "0x1B35E40", VA = "0x181B37240")]
		private bool _CheckIsRogueGameActivityHideEnding()
		{
			return default(bool);
		}

		// Token: 0x06020DE6 RID: 134630 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6020DE6")]
		[Address(RVA = "0x1B37560", Offset = "0x1B36160", VA = "0x181B37560")]
		private List<RoguelikeInitOption.Model.EndingFamily> _GetEndingFromBandCnt(string bandGrpId, PlayerRoguelikeV2.OuterData outerData, List<RoguelikeGameEndingData> allEndings)
		{
			return null;
		}

		// Token: 0x06020DE7 RID: 134631 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6020DE7")]
		[Address(RVA = "0x1B378E0", Offset = "0x1B364E0", VA = "0x181B378E0")]
		private List<RoguelikeInitOption.Model.EndingFamily> _GetEndingFromBandGrade(string bandGrpId, PlayerRoguelikeV2.OuterData outerData, List<RoguelikeGameEndingData> allEndings)
		{
			return null;
		}

		// Token: 0x06020DE8 RID: 134632 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020DE8")]
		[Address(RVA = "0x1B37340", Offset = "0x1B35F40", VA = "0x181B37340")]
		private void _FindAllBornRelic()
		{
		}

		// Token: 0x06020DE9 RID: 134633 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020DE9")]
		[Address(RVA = "0x1B36890", Offset = "0x1B35490", VA = "0x181B36890", Slot = "8")]
		public override void OnSelect(int idx)
		{
		}

		// Token: 0x06020DEA RID: 134634 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020DEA")]
		[Address(RVA = "0x1B37FC0", Offset = "0x1B36BC0", VA = "0x181B37FC0")]
		public RoguelikeInitBornRelicContext()
		{
		}

		// Token: 0x0402CA98 RID: 182936
		[Token(Token = "0x402CA98")]
		[FieldOffset(Offset = "0x28")]
		private List<RoguelikeInitOption.Model> m_list;

		// Token: 0x0402CA99 RID: 182937
		[Token(Token = "0x402CA99")]
		[FieldOffset(Offset = "0x30")]
		private List<KeyValuePair<string, string>> m_relics;

		// Token: 0x0402CA9A RID: 182938
		[Token(Token = "0x402CA9A")]
		[FieldOffset(Offset = "0x38")]
		private List<string> m_allBornRelic;

		// Token: 0x0402CA9B RID: 182939
		[Token(Token = "0x402CA9B")]
		[FieldOffset(Offset = "0x40")]
		private RoguelikeTopicMode m_preMode;

		// Token: 0x0402CA9C RID: 182940
		[Token(Token = "0x402CA9C")]
		[FieldOffset(Offset = "0x48")]
		private string m_prePredefinedId;

		// Token: 0x0402CA9D RID: 182941
		[Token(Token = "0x402CA9D")]
		[FieldOffset(Offset = "0x50")]
		private string m_preTheme;

		// Token: 0x0402CA9E RID: 182942
		[Token(Token = "0x402CA9E")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_list;

		// Token: 0x0402CA9F RID: 182943
		[Token(Token = "0x402CA9F")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_name;

		// Token: 0x0402CAA0 RID: 182944
		[Token(Token = "0x402CAA0")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_Load;

		// Token: 0x0402CAA1 RID: 182945
		[Token(Token = "0x402CAA1")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__AddRelic;

		// Token: 0x0402CAA2 RID: 182946
		[Token(Token = "0x402CAA2")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__GetEndings;

		// Token: 0x0402CAA3 RID: 182947
		[Token(Token = "0x402CAA3")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__CheckIsRogueGameActivityHideEnding;

		// Token: 0x0402CAA4 RID: 182948
		[Token(Token = "0x402CAA4")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__GetEndingFromBandCnt;

		// Token: 0x0402CAA5 RID: 182949
		[Token(Token = "0x402CAA5")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__GetEndingFromBandGrade;

		// Token: 0x0402CAA6 RID: 182950
		[Token(Token = "0x402CAA6")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__FindAllBornRelic;

		// Token: 0x0402CAA7 RID: 182951
		[Token(Token = "0x402CAA7")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_OnSelect;

		// Token: 0x0402CAA8 RID: 182952
		[Token(Token = "0x402CAA8")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}

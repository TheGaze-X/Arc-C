using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using XLua;

namespace Torappu.Activity.Act42D0
{
	// Token: 0x02007382 RID: 29570
	[Token(Token = "0x2007382")]
	public class Act42D0EffectViewModel : IHotfixable
	{
		// Token: 0x170062B5 RID: 25269
		// (get) Token: 0x06029CD8 RID: 171224 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170062B5")]
		public ListDict<string, Act42D0EffectBranchViewModel> effectBranchs
		{
			[Token(Token = "0x6029CD8")]
			[Address(RVA = "0x255D1D0", Offset = "0x255BDD0", VA = "0x18255D1D0")]
			get
			{
				return null;
			}
		}

		// Token: 0x170062B6 RID: 25270
		// (get) Token: 0x06029CD9 RID: 171225 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170062B6")]
		public Dictionary<string, Act42D0EffectItemViewModel> effects
		{
			[Token(Token = "0x6029CD9")]
			[Address(RVA = "0x255D230", Offset = "0x255BE30", VA = "0x18255D230")]
			get
			{
				return null;
			}
		}

		// Token: 0x170062B7 RID: 25271
		// (get) Token: 0x06029CDA RID: 171226 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170062B7")]
		public string stageId
		{
			[Token(Token = "0x6029CDA")]
			[Address(RVA = "0x255D440", Offset = "0x255C040", VA = "0x18255D440")]
			get
			{
				return null;
			}
		}

		// Token: 0x170062B8 RID: 25272
		// (get) Token: 0x06029CDB RID: 171227 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170062B8")]
		public string areaId
		{
			[Token(Token = "0x6029CDB")]
			[Address(RVA = "0x255D0B0", Offset = "0x255BCB0", VA = "0x18255D0B0")]
			get
			{
				return null;
			}
		}

		// Token: 0x170062B9 RID: 25273
		// (get) Token: 0x06029CDC RID: 171228 RVA: 0x000D69C8 File Offset: 0x000D4BC8
		[Token(Token = "0x170062B9")]
		public int energyMax
		{
			[Token(Token = "0x6029CDC")]
			[Address(RVA = "0x255D290", Offset = "0x255BE90", VA = "0x18255D290")]
			get
			{
				return 0;
			}
		}

		// Token: 0x170062BA RID: 25274
		// (get) Token: 0x06029CDD RID: 171229 RVA: 0x000D69E0 File Offset: 0x000D4BE0
		[Token(Token = "0x170062BA")]
		public int costEnergy
		{
			[Token(Token = "0x6029CDD")]
			[Address(RVA = "0x255D110", Offset = "0x255BD10", VA = "0x18255D110")]
			get
			{
				return 0;
			}
		}

		// Token: 0x170062BB RID: 25275
		// (get) Token: 0x06029CDE RID: 171230 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170062BB")]
		public List<Act42D0EffectRatingViewModel> ratingData
		{
			[Token(Token = "0x6029CDE")]
			[Address(RVA = "0x255D2F0", Offset = "0x255BEF0", VA = "0x18255D2F0")]
			get
			{
				return null;
			}
		}

		// Token: 0x170062BC RID: 25276
		// (get) Token: 0x06029CDF RID: 171231 RVA: 0x000D69F8 File Offset: 0x000D4BF8
		[Token(Token = "0x170062BC")]
		public Act42D0Data.Act42D0AreaDifficulty difficulty
		{
			[Token(Token = "0x6029CDF")]
			[Address(RVA = "0x255D170", Offset = "0x255BD70", VA = "0x18255D170")]
			get
			{
				return Act42D0Data.Act42D0AreaDifficulty.NONE;
			}
		}

		// Token: 0x170062BD RID: 25277
		// (get) Token: 0x06029CE0 RID: 171232 RVA: 0x000D6A10 File Offset: 0x000D4C10
		[Token(Token = "0x170062BD")]
		public int ratingIndex
		{
			[Token(Token = "0x6029CE0")]
			[Address(RVA = "0x255D350", Offset = "0x255BF50", VA = "0x18255D350")]
			get
			{
				return 0;
			}
		}

		// Token: 0x06029CE1 RID: 171233 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029CE1")]
		[Address(RVA = "0x255B5D0", Offset = "0x255A1D0", VA = "0x18255B5D0")]
		public void LoadData(string actId, string stageId)
		{
		}

		// Token: 0x06029CE2 RID: 171234 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6029CE2")]
		[Address(RVA = "0x255C350", Offset = "0x255AF50", VA = "0x18255C350")]
		public List<Act42D0EffectItemViewModel> LoadSelectedEffects()
		{
			return null;
		}

		// Token: 0x06029CE3 RID: 171235 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029CE3")]
		[Address(RVA = "0x255B120", Offset = "0x2559D20", VA = "0x18255B120")]
		public void AddEffect(string effectId)
		{
		}

		// Token: 0x06029CE4 RID: 171236 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029CE4")]
		[Address(RVA = "0x255C630", Offset = "0x255B230", VA = "0x18255C630")]
		public void RemoveEffect(string effectId)
		{
		}

		// Token: 0x06029CE5 RID: 171237 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029CE5")]
		[Address(RVA = "0x255CA50", Offset = "0x255B650", VA = "0x18255CA50")]
		public void UpdateEffects(List<string> selectedIds)
		{
		}

		// Token: 0x06029CE6 RID: 171238 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029CE6")]
		[Address(RVA = "0x255C770", Offset = "0x255B370", VA = "0x18255C770")]
		public void SaveSelectedEffect()
		{
		}

		// Token: 0x06029CE7 RID: 171239 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6029CE7")]
		[Address(RVA = "0x255CD20", Offset = "0x255B920", VA = "0x18255CD20")]
		private List<Act42D0EffectItemViewModel> _GetSelectedEffectSortList()
		{
			return null;
		}

		// Token: 0x06029CE8 RID: 171240 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6029CE8")]
		[Address(RVA = "0x255B270", Offset = "0x2559E70", VA = "0x18255B270")]
		public List<string> GetEffectIdList()
		{
			return null;
		}

		// Token: 0x06029CE9 RID: 171241 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6029CE9")]
		[Address(RVA = "0x255B420", Offset = "0x255A020", VA = "0x18255B420")]
		public List<RuneTable.PackedRuneData> GetEffectRuneList()
		{
			return null;
		}

		// Token: 0x06029CEA RID: 171242 RVA: 0x000D6A28 File Offset: 0x000D4C28
		[Token(Token = "0x6029CEA")]
		[Address(RVA = "0x255C9D0", Offset = "0x255B5D0", VA = "0x18255C9D0")]
		public bool TryHide()
		{
			return default(bool);
		}

		// Token: 0x06029CEB RID: 171243 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029CEB")]
		[Address(RVA = "0x255D050", Offset = "0x255BC50", VA = "0x18255D050")]
		public Act42D0EffectViewModel()
		{
		}

		// Token: 0x0403BDC7 RID: 245191
		[Token(Token = "0x403BDC7")]
		[FieldOffset(Offset = "0x10")]
		public bool isShow;

		// Token: 0x0403BDC8 RID: 245192
		[Token(Token = "0x403BDC8")]
		[FieldOffset(Offset = "0x14")]
		public int sequenceNum;

		// Token: 0x0403BDC9 RID: 245193
		[Token(Token = "0x403BDC9")]
		[FieldOffset(Offset = "0x18")]
		private string m_actId;

		// Token: 0x0403BDCA RID: 245194
		[Token(Token = "0x403BDCA")]
		[FieldOffset(Offset = "0x20")]
		private List<Act42D0EffectItemViewModel> m_selectedEffects;

		// Token: 0x0403BDCB RID: 245195
		[Token(Token = "0x403BDCB")]
		[FieldOffset(Offset = "0x28")]
		private ListDict<string, Act42D0EffectBranchViewModel> m_effectBranchs;

		// Token: 0x0403BDCC RID: 245196
		[Token(Token = "0x403BDCC")]
		[FieldOffset(Offset = "0x30")]
		private Dictionary<string, Act42D0EffectItemViewModel> m_effects;

		// Token: 0x0403BDCD RID: 245197
		[Token(Token = "0x403BDCD")]
		[FieldOffset(Offset = "0x38")]
		private string m_stageId;

		// Token: 0x0403BDCE RID: 245198
		[Token(Token = "0x403BDCE")]
		[FieldOffset(Offset = "0x40")]
		private string m_areaId;

		// Token: 0x0403BDCF RID: 245199
		[Token(Token = "0x403BDCF")]
		[FieldOffset(Offset = "0x48")]
		private int m_energyMax;

		// Token: 0x0403BDD0 RID: 245200
		[Token(Token = "0x403BDD0")]
		[FieldOffset(Offset = "0x4C")]
		private int m_costEnergy;

		// Token: 0x0403BDD1 RID: 245201
		[Token(Token = "0x403BDD1")]
		[FieldOffset(Offset = "0x50")]
		private List<Act42D0EffectRatingViewModel> m_ratingData;

		// Token: 0x0403BDD2 RID: 245202
		[Token(Token = "0x403BDD2")]
		[FieldOffset(Offset = "0x58")]
		private Act42D0Data.Act42D0AreaDifficulty m_difficulty;

		// Token: 0x0403BDD3 RID: 245203
		[Token(Token = "0x403BDD3")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_effectBranchs;

		// Token: 0x0403BDD4 RID: 245204
		[Token(Token = "0x403BDD4")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_effects;

		// Token: 0x0403BDD5 RID: 245205
		[Token(Token = "0x403BDD5")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_stageId;

		// Token: 0x0403BDD6 RID: 245206
		[Token(Token = "0x403BDD6")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_get_areaId;

		// Token: 0x0403BDD7 RID: 245207
		[Token(Token = "0x403BDD7")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_get_energyMax;

		// Token: 0x0403BDD8 RID: 245208
		[Token(Token = "0x403BDD8")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_get_costEnergy;

		// Token: 0x0403BDD9 RID: 245209
		[Token(Token = "0x403BDD9")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_get_ratingData;

		// Token: 0x0403BDDA RID: 245210
		[Token(Token = "0x403BDDA")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_get_difficulty;

		// Token: 0x0403BDDB RID: 245211
		[Token(Token = "0x403BDDB")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_get_ratingIndex;

		// Token: 0x0403BDDC RID: 245212
		[Token(Token = "0x403BDDC")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_LoadData;

		// Token: 0x0403BDDD RID: 245213
		[Token(Token = "0x403BDDD")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_LoadSelectedEffects;

		// Token: 0x0403BDDE RID: 245214
		[Token(Token = "0x403BDDE")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_AddEffect;

		// Token: 0x0403BDDF RID: 245215
		[Token(Token = "0x403BDDF")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0_RemoveEffect;

		// Token: 0x0403BDE0 RID: 245216
		[Token(Token = "0x403BDE0")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0_UpdateEffects;

		// Token: 0x0403BDE1 RID: 245217
		[Token(Token = "0x403BDE1")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0_SaveSelectedEffect;

		// Token: 0x0403BDE2 RID: 245218
		[Token(Token = "0x403BDE2")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0__GetSelectedEffectSortList;

		// Token: 0x0403BDE3 RID: 245219
		[Token(Token = "0x403BDE3")]
		[FieldOffset(Offset = "0x80")]
		private static DelegateBridge __Hotfix0_GetEffectIdList;

		// Token: 0x0403BDE4 RID: 245220
		[Token(Token = "0x403BDE4")]
		[FieldOffset(Offset = "0x88")]
		private static DelegateBridge __Hotfix0_GetEffectRuneList;

		// Token: 0x0403BDE5 RID: 245221
		[Token(Token = "0x403BDE5")]
		[FieldOffset(Offset = "0x90")]
		private static DelegateBridge __Hotfix0_TryHide;

		// Token: 0x0403BDE6 RID: 245222
		[Token(Token = "0x403BDE6")]
		[FieldOffset(Offset = "0x98")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}

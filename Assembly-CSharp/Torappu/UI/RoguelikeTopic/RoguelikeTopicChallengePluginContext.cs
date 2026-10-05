using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.RoguelikeTopic
{
	// Token: 0x020044BA RID: 17594
	[Token(Token = "0x20044BA")]
	public abstract class RoguelikeTopicChallengePluginContext : MonoBehaviour, IHotfixable
	{
		// Token: 0x17003FC8 RID: 16328
		// (get) Token: 0x0601ADFA RID: 110074
		[Token(Token = "0x17003FC8")]
		public abstract RoguelikeTopicChallengeToggleGroup topicChallengeToggleGroupPrefab { [Token(Token = "0x601ADFA")] get; }

		// Token: 0x17003FC9 RID: 16329
		// (get) Token: 0x0601ADFB RID: 110075 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17003FC9")]
		public virtual RoguelikeTopicChallengeGroup topicChallengeGroupPrefab
		{
			[Token(Token = "0x601ADFB")]
			[Address(RVA = "0x1408060", Offset = "0x1406C60", VA = "0x181408060", Slot = "5")]
			get
			{
				return null;
			}
		}

		// Token: 0x0601ADFC RID: 110076 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601ADFC")]
		[Address(RVA = "0x1407E30", Offset = "0x1406A30", VA = "0x181407E30", Slot = "6")]
		public virtual void LoadData(RoguelikeTopicChallengeModeViewModel challengeModeViewModel)
		{
		}

		// Token: 0x0601ADFD RID: 110077 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601ADFD")]
		[Address(RVA = "0x1407E90", Offset = "0x1406A90", VA = "0x181407E90", Slot = "7")]
		public virtual void UpdateData(RoguelikeTopicChallengeModeViewModel challengeModeViewModel)
		{
		}

		// Token: 0x17003FCA RID: 16330
		// (get) Token: 0x0601ADFE RID: 110078 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17003FCA")]
		public virtual ListDict<int, int> challengeGroupCountListDic
		{
			[Token(Token = "0x601ADFE")]
			[Address(RVA = "0x1407F50", Offset = "0x1406B50", VA = "0x181407F50", Slot = "8")]
			get
			{
				return null;
			}
		}

		// Token: 0x17003FCB RID: 16331
		// (get) Token: 0x0601ADFF RID: 110079 RVA: 0x000A3860 File Offset: 0x000A1A60
		[Token(Token = "0x17003FCB")]
		public bool hasChallengeGroup
		{
			[Token(Token = "0x601ADFF")]
			[Address(RVA = "0x1407FB0", Offset = "0x1406BB0", VA = "0x181407FB0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x0601AE00 RID: 110080 RVA: 0x000A3878 File Offset: 0x000A1A78
		[Token(Token = "0x601AE00")]
		[Address(RVA = "0x1407D50", Offset = "0x1406950", VA = "0x181407D50", Slot = "9")]
		public virtual int GetCurrChallengeGroupId(RoguelikeTopicChallengeModeViewModel modeViewModel)
		{
			return 0;
		}

		// Token: 0x0601AE01 RID: 110081 RVA: 0x000A3890 File Offset: 0x000A1A90
		[Token(Token = "0x601AE01")]
		[Address(RVA = "0x1407DC0", Offset = "0x14069C0", VA = "0x181407DC0", Slot = "10")]
		public virtual int GetSwitchPageCountByCurPageIndex(int curPageIndex)
		{
			return 0;
		}

		// Token: 0x0601AE02 RID: 110082 RVA: 0x000A38A8 File Offset: 0x000A1AA8
		[Token(Token = "0x601AE02")]
		[Address(RVA = "0x1407CF0", Offset = "0x14068F0", VA = "0x181407CF0", Slot = "11")]
		public virtual bool CheckIfNeedRefreshAllCard()
		{
			return default(bool);
		}

		// Token: 0x0601AE03 RID: 110083 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601AE03")]
		[Address(RVA = "0x1407EF0", Offset = "0x1406AF0", VA = "0x181407EF0")]
		protected RoguelikeTopicChallengePluginContext()
		{
		}

		// Token: 0x040226FD RID: 141053
		[Token(Token = "0x40226FD")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_topicChallengeGroupPrefab;

		// Token: 0x040226FE RID: 141054
		[Token(Token = "0x40226FE")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_LoadData;

		// Token: 0x040226FF RID: 141055
		[Token(Token = "0x40226FF")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_UpdateData;

		// Token: 0x04022700 RID: 141056
		[Token(Token = "0x4022700")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_get_challengeGroupCountListDic;

		// Token: 0x04022701 RID: 141057
		[Token(Token = "0x4022701")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_get_hasChallengeGroup;

		// Token: 0x04022702 RID: 141058
		[Token(Token = "0x4022702")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_GetCurrChallengeGroupId;

		// Token: 0x04022703 RID: 141059
		[Token(Token = "0x4022703")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_GetSwitchPageCountByCurPageIndex;

		// Token: 0x04022704 RID: 141060
		[Token(Token = "0x4022704")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_CheckIfNeedRefreshAllCard;

		// Token: 0x04022705 RID: 141061
		[Token(Token = "0x4022705")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}

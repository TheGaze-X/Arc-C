using System;
using Il2CppDummyDll;
using Torappu.CharWord;

namespace Torappu.UI
{
	// Token: 0x020035AC RID: 13740
	[Token(Token = "0x20035AC")]
	public interface ICharacterCardViewModel : IHotfixable, IComparableChar
	{
		// Token: 0x06015D9D RID: 89501
		[Token(Token = "0x6015D9D")]
		TInfo SetCharInfo<TInfo>(CommonCharCardInfoType infoType, TInfo characterInfo) where TInfo : class, ICharacterInfo;

		// Token: 0x06015D9E RID: 89502
		[Token(Token = "0x6015D9E")]
		TInfo GetCharInfo<TInfo>(CommonCharCardInfoType infoType) where TInfo : class, ICharacterInfo;

		// Token: 0x06015D9F RID: 89503
		[Token(Token = "0x6015D9F")]
		void ClearChar();

		// Token: 0x17003441 RID: 13377
		// (get) Token: 0x06015DA0 RID: 89504
		[Token(Token = "0x17003441")]
		bool isEmpty { [Token(Token = "0x6015DA0")] get; }

		// Token: 0x17003442 RID: 13378
		// (get) Token: 0x06015DA1 RID: 89505
		[Token(Token = "0x17003442")]
		string charId { [Token(Token = "0x6015DA1")] get; }

		// Token: 0x17003443 RID: 13379
		// (get) Token: 0x06015DA2 RID: 89506
		[Token(Token = "0x17003443")]
		int charInstId { [Token(Token = "0x6015DA2")] get; }

		// Token: 0x17003444 RID: 13380
		// (get) Token: 0x06015DA3 RID: 89507
		[Token(Token = "0x17003444")]
		string tmplId { [Token(Token = "0x6015DA3")] get; }

		// Token: 0x17003445 RID: 13381
		// (get) Token: 0x06015DA4 RID: 89508
		[Token(Token = "0x17003445")]
		CharQuery charQuery { [Token(Token = "0x6015DA4")] get; }

		// Token: 0x17003446 RID: 13382
		// (get) Token: 0x06015DA5 RID: 89509
		[Token(Token = "0x17003446")]
		VoiceQuery charVoiceQuery { [Token(Token = "0x6015DA5")] get; }

		// Token: 0x17003447 RID: 13383
		// (get) Token: 0x06015DA6 RID: 89510
		[Token(Token = "0x17003447")]
		string skillId { [Token(Token = "0x6015DA6")] get; }

		// Token: 0x17003448 RID: 13384
		// (get) Token: 0x06015DA7 RID: 89511 RVA: 0x0008E620 File Offset: 0x0008C820
		[Token(Token = "0x17003448")]
		int skillIndex
		{
			[Token(Token = "0x6015DA7")]
			[Address(RVA = "0xE724D0", Offset = "0xE710D0", VA = "0x180E724D0", Slot = "10")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17003449 RID: 13385
		// (get) Token: 0x06015DA8 RID: 89512
		[Token(Token = "0x17003449")]
		string defaultSkillId { [Token(Token = "0x6015DA8")] get; }

		// Token: 0x1700344A RID: 13386
		// (get) Token: 0x06015DA9 RID: 89513
		[Token(Token = "0x1700344A")]
		int mainSkillLvl { [Token(Token = "0x6015DA9")] get; }

		// Token: 0x1700344B RID: 13387
		// (get) Token: 0x06015DAA RID: 89514
		[Token(Token = "0x1700344B")]
		int skillSpecLvl { [Token(Token = "0x6015DAA")] get; }

		// Token: 0x1700344C RID: 13388
		// (get) Token: 0x06015DAB RID: 89515
		[Token(Token = "0x1700344C")]
		ListDict<string, PlayerCharSkill> skills { [Token(Token = "0x6015DAB")] get; }

		// Token: 0x06015DAC RID: 89516
		[Token(Token = "0x6015DAC")]
		void SetSkillId(string newSkillId);

		// Token: 0x1700344D RID: 13389
		// (get) Token: 0x06015DAD RID: 89517
		[Token(Token = "0x1700344D")]
		string equipId { [Token(Token = "0x6015DAD")] get; }

		// Token: 0x1700344E RID: 13390
		// (get) Token: 0x06015DAE RID: 89518
		[Token(Token = "0x1700344E")]
		int equipLvl { [Token(Token = "0x6015DAE")] get; }

		// Token: 0x1700344F RID: 13391
		// (get) Token: 0x06015DAF RID: 89519
		[Token(Token = "0x1700344F")]
		ListDict<string, PlayerCharEquipInfo> equips { [Token(Token = "0x6015DAF")] get; }

		// Token: 0x06015DB0 RID: 89520
		[Token(Token = "0x6015DB0")]
		void SetEquipId(string newEquipId);

		// Token: 0x17003450 RID: 13392
		// (get) Token: 0x06015DB1 RID: 89521
		[Token(Token = "0x17003450")]
		CharUISkinStruct skinStruct { [Token(Token = "0x6015DB1")] get; }

		// Token: 0x17003451 RID: 13393
		// (get) Token: 0x06015DB2 RID: 89522
		[Token(Token = "0x17003451")]
		string nickName { [Token(Token = "0x6015DB2")] get; }

		// Token: 0x17003452 RID: 13394
		// (get) Token: 0x06015DB3 RID: 89523
		[Token(Token = "0x17003452")]
		int maxLevel { [Token(Token = "0x6015DB3")] get; }

		// Token: 0x17003453 RID: 13395
		// (get) Token: 0x06015DB4 RID: 89524
		[Token(Token = "0x17003453")]
		float expPercent { [Token(Token = "0x6015DB4")] get; }

		// Token: 0x17003454 RID: 13396
		// (get) Token: 0x06015DB5 RID: 89525
		[Token(Token = "0x17003454")]
		string subProfessionId { [Token(Token = "0x6015DB5")] get; }

		// Token: 0x17003455 RID: 13397
		// (get) Token: 0x06015DB6 RID: 89526
		[Token(Token = "0x17003455")]
		int potentialRank { [Token(Token = "0x6015DB6")] get; }

		// Token: 0x17003456 RID: 13398
		// (get) Token: 0x06015DB7 RID: 89527
		[Token(Token = "0x17003456")]
		AttributesData attrData { [Token(Token = "0x6015DB7")] get; }

		// Token: 0x17003457 RID: 13399
		// (get) Token: 0x06015DB8 RID: 89528
		[Token(Token = "0x17003457")]
		CharStarMarkState starMark { [Token(Token = "0x6015DB8")] get; }

		// Token: 0x06015DB9 RID: 89529
		[Token(Token = "0x6015DB9")]
		void SetAttrData(AttributesData attributesData);

		// Token: 0x06015DBA RID: 89530 RVA: 0x0008E638 File Offset: 0x0008C838
		[Token(Token = "0x6015DBA")]
		[Address(RVA = "0xE72430", Offset = "0xE71030", VA = "0x180E72430", Slot = "29")]
		bool CheckIfTmplIdChanged(string newTmplId)
		{
			return default(bool);
		}
	}
}

using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Torappu.Battle
{
	// Token: 0x020025EE RID: 9710
	[Token(Token = "0x20025EE")]
	public interface IUseGiantBossInfoPanel : IPtrObject
	{
		// Token: 0x170021CB RID: 8651
		// (get) Token: 0x0600FC96 RID: 64662
		[Token(Token = "0x170021CB")]
		Vector2 bossHudOffset { [Token(Token = "0x600FC96")] get; }

		// Token: 0x170021CC RID: 8652
		// (get) Token: 0x0600FC97 RID: 64663
		[Token(Token = "0x170021CC")]
		Vector3 bossHudScale { [Token(Token = "0x600FC97")] get; }

		// Token: 0x170021CD RID: 8653
		// (get) Token: 0x0600FC98 RID: 64664
		[Token(Token = "0x170021CD")]
		Vector2 bossAvatarOffset { [Token(Token = "0x600FC98")] get; }

		// Token: 0x170021CE RID: 8654
		// (get) Token: 0x0600FC99 RID: 64665
		[Token(Token = "0x170021CE")]
		Vector2 bossAvatarSize { [Token(Token = "0x600FC99")] get; }

		// Token: 0x170021CF RID: 8655
		// (get) Token: 0x0600FC9A RID: 64666
		[Token(Token = "0x170021CF")]
		bool hideAvatarBackground { [Token(Token = "0x600FC9A")] get; }

		// Token: 0x170021D0 RID: 8656
		// (get) Token: 0x0600FC9B RID: 64667
		[Token(Token = "0x170021D0")]
		bool enableSpSliderWarning { [Token(Token = "0x600FC9B")] get; }

		// Token: 0x170021D1 RID: 8657
		// (get) Token: 0x0600FC9C RID: 64668
		[Token(Token = "0x170021D1")]
		bool lockHudPosition { [Token(Token = "0x600FC9C")] get; }

		// Token: 0x170021D2 RID: 8658
		// (get) Token: 0x0600FC9D RID: 64669
		[Token(Token = "0x170021D2")]
		float hudDelayToAppear { [Token(Token = "0x600FC9D")] get; }

		// Token: 0x170021D3 RID: 8659
		// (get) Token: 0x0600FC9E RID: 64670
		[Token(Token = "0x170021D3")]
		bool hideHpSlider { [Token(Token = "0x600FC9E")] get; }

		// Token: 0x170021D4 RID: 8660
		// (get) Token: 0x0600FC9F RID: 64671
		[Token(Token = "0x170021D4")]
		bool hideSpSlider { [Token(Token = "0x600FC9F")] get; }

		// Token: 0x170021D5 RID: 8661
		// (get) Token: 0x0600FCA0 RID: 64672
		[Token(Token = "0x170021D5")]
		BattleUIConst.GiantBossInfoType giantBossInfoType { [Token(Token = "0x600FCA0")] get; }

		// Token: 0x170021D6 RID: 8662
		// (get) Token: 0x0600FCA1 RID: 64673
		[Token(Token = "0x170021D6")]
		Transform uiPoint { [Token(Token = "0x600FCA1")] get; }

		// Token: 0x170021D7 RID: 8663
		// (get) Token: 0x0600FCA2 RID: 64674
		[Token(Token = "0x170021D7")]
		string id { [Token(Token = "0x600FCA2")] get; }

		// Token: 0x170021D8 RID: 8664
		// (get) Token: 0x0600FCA3 RID: 64675
		// (set) Token: 0x0600FCA4 RID: 64676
		[Token(Token = "0x170021D8")]
		Action<Unit> actionOnTakeDamage { [Token(Token = "0x600FCA3")] get; [Token(Token = "0x600FCA4")] set; }

		// Token: 0x170021D9 RID: 8665
		// (get) Token: 0x0600FCA5 RID: 64677
		[Token(Token = "0x170021D9")]
		FP hpToShow { [Token(Token = "0x600FCA5")] get; }

		// Token: 0x170021DA RID: 8666
		// (get) Token: 0x0600FCA6 RID: 64678
		[Token(Token = "0x170021DA")]
		FP maxHp { [Token(Token = "0x600FCA6")] get; }

		// Token: 0x170021DB RID: 8667
		// (get) Token: 0x0600FCA7 RID: 64679
		[Token(Token = "0x170021DB")]
		FP esToShow { [Token(Token = "0x600FCA7")] get; }

		// Token: 0x170021DC RID: 8668
		// (get) Token: 0x0600FCA8 RID: 64680
		[Token(Token = "0x170021DC")]
		FP maxEs { [Token(Token = "0x600FCA8")] get; }

		// Token: 0x170021DD RID: 8669
		// (get) Token: 0x0600FCA9 RID: 64681
		[Token(Token = "0x170021DD")]
		bool alive { [Token(Token = "0x600FCA9")] get; }

		// Token: 0x170021DE RID: 8670
		// (get) Token: 0x0600FCAA RID: 64682
		[Token(Token = "0x170021DE")]
		Entity.SpController spController { [Token(Token = "0x600FCAA")] get; }

		// Token: 0x170021DF RID: 8671
		// (get) Token: 0x0600FCAB RID: 64683
		[Token(Token = "0x170021DF")]
		FP skillRemainingProgress { [Token(Token = "0x600FCAB")] get; }

		// Token: 0x170021E0 RID: 8672
		// (get) Token: 0x0600FCAC RID: 64684
		[Token(Token = "0x170021E0")]
		bool isSkillAffecting { [Token(Token = "0x600FCAC")] get; }

		// Token: 0x170021E1 RID: 8673
		// (get) Token: 0x0600FCAD RID: 64685
		[Token(Token = "0x170021E1")]
		bool isSpCostSkill { [Token(Token = "0x600FCAD")] get; }

		// Token: 0x170021E2 RID: 8674
		// (get) Token: 0x0600FCAE RID: 64686
		[Token(Token = "0x170021E2")]
		bool epIsFull { [Token(Token = "0x600FCAE")] get; }

		// Token: 0x170021E3 RID: 8675
		// (get) Token: 0x0600FCAF RID: 64687
		[Token(Token = "0x170021E3")]
		ElementType minEpTypeToShow { [Token(Token = "0x600FCAF")] get; }

		// Token: 0x170021E4 RID: 8676
		// (get) Token: 0x0600FCB0 RID: 64688
		[Token(Token = "0x170021E4")]
		FP[] epArrayToShow { [Token(Token = "0x600FCB0")] get; }

		// Token: 0x170021E5 RID: 8677
		// (get) Token: 0x0600FCB1 RID: 64689
		[Token(Token = "0x170021E5")]
		Entity.EPController epController { [Token(Token = "0x600FCB1")] get; }

		// Token: 0x170021E6 RID: 8678
		// (get) Token: 0x0600FCB2 RID: 64690
		[Token(Token = "0x170021E6")]
		FP maxEp { [Token(Token = "0x600FCB2")] get; }

		// Token: 0x170021E7 RID: 8679
		// (get) Token: 0x0600FCB3 RID: 64691
		[Token(Token = "0x170021E7")]
		bool isInEpBreakRecovery { [Token(Token = "0x600FCB3")] get; }
	}
}

using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.Battle.GameMode;
using XLua;

namespace Torappu.Battle.Douququ
{
	// Token: 0x02002A34 RID: 10804
	[Token(Token = "0x2002A34")]
	public class DouququNpcManager : IHotfixable
	{
		// Token: 0x06011EEF RID: 73455 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011EEF")]
		[Address(RVA = "0x9C4680", Offset = "0x9C3280", VA = "0x1809C4680")]
		public void Init(GameModeFactory.DouququGameMode gameMode)
		{
		}

		// Token: 0x06011EF0 RID: 73456 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011EF0")]
		[Address(RVA = "0x9C4580", Offset = "0x9C3180", VA = "0x1809C4580")]
		public void BeforeBetAppear()
		{
		}

		// Token: 0x06011EF1 RID: 73457 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011EF1")]
		[Address(RVA = "0x9C4870", Offset = "0x9C3470", VA = "0x1809C4870")]
		public void OnRoundEnd(RoundResult result)
		{
		}

		// Token: 0x06011EF2 RID: 73458 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6011EF2")]
		[Address(RVA = "0x9C4600", Offset = "0x9C3200", VA = "0x1809C4600")]
		public List<string> GetNpcList(bool isLeft)
		{
			return null;
		}

		// Token: 0x06011EF3 RID: 73459 RVA: 0x0006DB90 File Offset: 0x0006BD90
		[Token(Token = "0x6011EF3")]
		[Address(RVA = "0x9C48F0", Offset = "0x9C34F0", VA = "0x1809C48F0")]
		public bool TryGetSelectorInfo(Act5FunNpcSelector selector, out float value)
		{
			return default(bool);
		}

		// Token: 0x06011EF4 RID: 73460 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011EF4")]
		[Address(RVA = "0x9C5760", Offset = "0x9C4360", VA = "0x1809C5760")]
		private void _ProcessNpcInfoData()
		{
		}

		// Token: 0x06011EF5 RID: 73461 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011EF5")]
		[Address(RVA = "0x9C5960", Offset = "0x9C4560", VA = "0x1809C5960")]
		private void _ProcessNpcSelectorData()
		{
		}

		// Token: 0x06011EF6 RID: 73462 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011EF6")]
		[Address(RVA = "0x9C52B0", Offset = "0x9C3EB0", VA = "0x1809C52B0")]
		private void _ChooseNpc()
		{
		}

		// Token: 0x06011EF7 RID: 73463 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011EF7")]
		[Address(RVA = "0x9C5050", Offset = "0x9C3C50", VA = "0x1809C5050")]
		private void _CalculateNpcScore()
		{
		}

		// Token: 0x06011EF8 RID: 73464 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6011EF8")]
		[Address(RVA = "0x9C4D20", Offset = "0x9C3920", VA = "0x1809C4D20")]
		private Act5FunNpcChoice _CalculateDefaultStrategy(Act5FunNpcData npcInfoData)
		{
			return null;
		}

		// Token: 0x06011EF9 RID: 73465 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6011EF9")]
		[Address(RVA = "0x9C4B90", Offset = "0x9C3790", VA = "0x1809C4B90")]
		private Act5FunNpcChoice _CalculateChooseWinStrategy(string npcId)
		{
			return null;
		}

		// Token: 0x06011EFA RID: 73466 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6011EFA")]
		[Address(RVA = "0x9C4A70", Offset = "0x9C3670", VA = "0x1809C4A70")]
		private Act5FunNpcChoice _CalculateChooseOddStrategy(string npcId)
		{
			return null;
		}

		// Token: 0x06011EFB RID: 73467 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6011EFB")]
		[Address(RVA = "0x9C4E20", Offset = "0x9C3A20", VA = "0x1809C4E20")]
		private Act5FunNpcChoice _CalculateFollowStrategy(string npcId, bool isFollowMore)
		{
			return null;
		}

		// Token: 0x06011EFC RID: 73468 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011EFC")]
		[Address(RVA = "0x9C5B50", Offset = "0x9C4750", VA = "0x1809C5B50")]
		private void _SetNpcChoiceResult(RoundResult result)
		{
		}

		// Token: 0x06011EFD RID: 73469 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011EFD")]
		[Address(RVA = "0x9C5550", Offset = "0x9C4150", VA = "0x1809C5550")]
		private void _LogRoundNpcResult()
		{
		}

		// Token: 0x06011EFE RID: 73470 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011EFE")]
		[Address(RVA = "0x9C5D10", Offset = "0x9C4910", VA = "0x1809C5D10")]
		private void _SetTeamList()
		{
		}

		// Token: 0x06011EFF RID: 73471 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011EFF")]
		[Address(RVA = "0x9C5EF0", Offset = "0x9C4AF0", VA = "0x1809C5EF0")]
		public DouququNpcManager()
		{
		}

		// Token: 0x0401437D RID: 82813
		[Token(Token = "0x401437D")]
		[FieldOffset(Offset = "0x10")]
		private bool m_hasChooseNpc;

		// Token: 0x0401437E RID: 82814
		[Token(Token = "0x401437E")]
		[FieldOffset(Offset = "0x18")]
		private GameModeFactory.DouququGameMode m_gameMode;

		// Token: 0x0401437F RID: 82815
		[Token(Token = "0x401437F")]
		[FieldOffset(Offset = "0x20")]
		private readonly List<Act5FunNpcWithWeight> m_npcWithWeights;

		// Token: 0x04014380 RID: 82816
		[Token(Token = "0x4014380")]
		[FieldOffset(Offset = "0x28")]
		private readonly Dictionary<Act5FunNpcSelector, float> m_npcSelectorData;

		// Token: 0x04014381 RID: 82817
		[Token(Token = "0x4014381")]
		[FieldOffset(Offset = "0x30")]
		private Dictionary<string, Act5FunNpcData> m_npcInfoData;

		// Token: 0x04014382 RID: 82818
		[Token(Token = "0x4014382")]
		[FieldOffset(Offset = "0x38")]
		private readonly List<string> m_chooseRightNpcList;

		// Token: 0x04014383 RID: 82819
		[Token(Token = "0x4014383")]
		[FieldOffset(Offset = "0x40")]
		private readonly List<string> m_chooseLeftNpcList;

		// Token: 0x04014384 RID: 82820
		[Token(Token = "0x4014384")]
		[FieldOffset(Offset = "0x48")]
		private readonly List<Act5FunNpcChoice> m_npcChoiceList;

		// Token: 0x04014385 RID: 82821
		[Token(Token = "0x4014385")]
		[FieldOffset(Offset = "0x50")]
		private List<string> m_npcSortList;

		// Token: 0x04014386 RID: 82822
		[Token(Token = "0x4014386")]
		[FieldOffset(Offset = "0x58")]
		private Act5FunNpcChoice m_lastChoice;

		// Token: 0x04014387 RID: 82823
		[Token(Token = "0x4014387")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Init;

		// Token: 0x04014388 RID: 82824
		[Token(Token = "0x4014388")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_BeforeBetAppear;

		// Token: 0x04014389 RID: 82825
		[Token(Token = "0x4014389")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnRoundEnd;

		// Token: 0x0401438A RID: 82826
		[Token(Token = "0x401438A")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_GetNpcList;

		// Token: 0x0401438B RID: 82827
		[Token(Token = "0x401438B")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_TryGetSelectorInfo;

		// Token: 0x0401438C RID: 82828
		[Token(Token = "0x401438C")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__ProcessNpcInfoData;

		// Token: 0x0401438D RID: 82829
		[Token(Token = "0x401438D")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__ProcessNpcSelectorData;

		// Token: 0x0401438E RID: 82830
		[Token(Token = "0x401438E")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__ChooseNpc;

		// Token: 0x0401438F RID: 82831
		[Token(Token = "0x401438F")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__CalculateNpcScore;

		// Token: 0x04014390 RID: 82832
		[Token(Token = "0x4014390")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0__CalculateDefaultStrategy;

		// Token: 0x04014391 RID: 82833
		[Token(Token = "0x4014391")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0__CalculateChooseWinStrategy;

		// Token: 0x04014392 RID: 82834
		[Token(Token = "0x4014392")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0__CalculateChooseOddStrategy;

		// Token: 0x04014393 RID: 82835
		[Token(Token = "0x4014393")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0__CalculateFollowStrategy;

		// Token: 0x04014394 RID: 82836
		[Token(Token = "0x4014394")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0__SetNpcChoiceResult;

		// Token: 0x04014395 RID: 82837
		[Token(Token = "0x4014395")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0__LogRoundNpcResult;

		// Token: 0x04014396 RID: 82838
		[Token(Token = "0x4014396")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0__SetTeamList;

		// Token: 0x04014397 RID: 82839
		[Token(Token = "0x4014397")]
		[FieldOffset(Offset = "0x80")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}

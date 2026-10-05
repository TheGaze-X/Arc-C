using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.Monopoly
{
	// Token: 0x02004817 RID: 18455
	[Token(Token = "0x2004817")]
	public class MonopolyGameDetailViewModel : IHotfixable
	{
		// Token: 0x1700424D RID: 16973
		// (get) Token: 0x0601BE79 RID: 114297 RVA: 0x000A6968 File Offset: 0x000A4B68
		// (set) Token: 0x0601BE7A RID: 114298 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700424D")]
		public int enterSequenceNum
		{
			[Token(Token = "0x601BE79")]
			[Address(RVA = "0x153AF70", Offset = "0x1539B70", VA = "0x18153AF70")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[Token(Token = "0x601BE7A")]
			[Address(RVA = "0x153B0A0", Offset = "0x1539CA0", VA = "0x18153B0A0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x1700424E RID: 16974
		// (get) Token: 0x0601BE7B RID: 114299 RVA: 0x000A6980 File Offset: 0x000A4B80
		// (set) Token: 0x0601BE7C RID: 114300 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700424E")]
		public int cardSelectSequenceNum
		{
			[Token(Token = "0x601BE7B")]
			[Address(RVA = "0x153AF10", Offset = "0x1539B10", VA = "0x18153AF10")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[Token(Token = "0x601BE7C")]
			[Address(RVA = "0x153B030", Offset = "0x1539C30", VA = "0x18153B030")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x1700424F RID: 16975
		// (get) Token: 0x0601BE7D RID: 114301 RVA: 0x000A6998 File Offset: 0x000A4B98
		// (set) Token: 0x0601BE7E RID: 114302 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700424F")]
		public int gameActionSequenceNum
		{
			[Token(Token = "0x601BE7D")]
			[Address(RVA = "0x153AFD0", Offset = "0x1539BD0", VA = "0x18153AFD0")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[Token(Token = "0x601BE7E")]
			[Address(RVA = "0x153B110", Offset = "0x1539D10", VA = "0x18153B110")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x0601BE7F RID: 114303 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601BE7F")]
		[Address(RVA = "0x153A530", Offset = "0x1539130", VA = "0x18153A530")]
		public void LoadData(string actId)
		{
		}

		// Token: 0x0601BE80 RID: 114304 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601BE80")]
		[Address(RVA = "0x153A920", Offset = "0x1539520", VA = "0x18153A920")]
		public void RefreshData(string actId, MonopolyEventType eventType)
		{
		}

		// Token: 0x0601BE81 RID: 114305 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601BE81")]
		[Address(RVA = "0x153AAC0", Offset = "0x15396C0", VA = "0x18153AAC0")]
		public void SelectCard(int cardIndex)
		{
		}

		// Token: 0x0601BE82 RID: 114306 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601BE82")]
		[Address(RVA = "0x153A820", Offset = "0x1539420", VA = "0x18153A820")]
		public void NotifyEnterSequence()
		{
		}

		// Token: 0x0601BE83 RID: 114307 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601BE83")]
		[Address(RVA = "0x153A720", Offset = "0x1539320", VA = "0x18153A720")]
		public void NotifyCardSelect()
		{
		}

		// Token: 0x0601BE84 RID: 114308 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601BE84")]
		[Address(RVA = "0x153A330", Offset = "0x1538F30", VA = "0x18153A330")]
		public void CalculateDelayInfo(MonopolyCalculateDelayInfoInput input, ref float delay)
		{
		}

		// Token: 0x0601BE85 RID: 114309 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601BE85")]
		[Address(RVA = "0x153AB70", Offset = "0x1539770", VA = "0x18153AB70")]
		public MonopolyGameDetailViewModel()
		{
		}

		// Token: 0x040245FF RID: 148991
		[Token(Token = "0x40245FF")]
		[FieldOffset(Offset = "0x10")]
		public string actId;

		// Token: 0x04024600 RID: 148992
		[Token(Token = "0x4024600")]
		[FieldOffset(Offset = "0x18")]
		public long gameId;

		// Token: 0x04024601 RID: 148993
		[Token(Token = "0x4024601")]
		[FieldOffset(Offset = "0x20")]
		public MonopolyEventType gameActionEventType;

		// Token: 0x04024602 RID: 148994
		[Token(Token = "0x4024602")]
		[FieldOffset(Offset = "0x28")]
		public MonopolyCardPanelModel cardPanelModel;

		// Token: 0x04024603 RID: 148995
		[Token(Token = "0x4024603")]
		[FieldOffset(Offset = "0x30")]
		public MonopolyTopBuffModel topBuffModel;

		// Token: 0x04024604 RID: 148996
		[Token(Token = "0x4024604")]
		[FieldOffset(Offset = "0x38")]
		public MonopolyMapViewModel mapViewModel;

		// Token: 0x04024605 RID: 148997
		[Token(Token = "0x4024605")]
		[FieldOffset(Offset = "0x40")]
		public MonopolyMissionViewModel missionViewModel;

		// Token: 0x04024609 RID: 149001
		[Token(Token = "0x4024609")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_enterSequenceNum;

		// Token: 0x0402460A RID: 149002
		[Token(Token = "0x402460A")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_enterSequenceNum;

		// Token: 0x0402460B RID: 149003
		[Token(Token = "0x402460B")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_cardSelectSequenceNum;

		// Token: 0x0402460C RID: 149004
		[Token(Token = "0x402460C")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_set_cardSelectSequenceNum;

		// Token: 0x0402460D RID: 149005
		[Token(Token = "0x402460D")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_get_gameActionSequenceNum;

		// Token: 0x0402460E RID: 149006
		[Token(Token = "0x402460E")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_set_gameActionSequenceNum;

		// Token: 0x0402460F RID: 149007
		[Token(Token = "0x402460F")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_LoadData;

		// Token: 0x04024610 RID: 149008
		[Token(Token = "0x4024610")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_RefreshData;

		// Token: 0x04024611 RID: 149009
		[Token(Token = "0x4024611")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_SelectCard;

		// Token: 0x04024612 RID: 149010
		[Token(Token = "0x4024612")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_NotifyEnterSequence;

		// Token: 0x04024613 RID: 149011
		[Token(Token = "0x4024613")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_NotifyCardSelect;

		// Token: 0x04024614 RID: 149012
		[Token(Token = "0x4024614")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_CalculateDelayInfo;

		// Token: 0x04024615 RID: 149013
		[Token(Token = "0x4024615")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}

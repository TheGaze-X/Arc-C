using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using XLua;

namespace Torappu.Activity.Act20side
{
	// Token: 0x02007694 RID: 30356
	[Token(Token = "0x2007694")]
	public class Act20sideCarVoteViewModel : IHotfixable
	{
		// Token: 0x17006451 RID: 25681
		// (get) Token: 0x0602AB19 RID: 174873 RVA: 0x000D96F8 File Offset: 0x000D78F8
		// (set) Token: 0x0602AB1A RID: 174874 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17006451")]
		public int focusedIndex
		{
			[Token(Token = "0x602AB19")]
			[Address(RVA = "0x266E070", Offset = "0x266CC70", VA = "0x18266E070")]
			get
			{
				return 0;
			}
			[Token(Token = "0x602AB1A")]
			[Address(RVA = "0x266E1A0", Offset = "0x266CDA0", VA = "0x18266E1A0")]
			set
			{
			}
		}

		// Token: 0x17006452 RID: 25682
		// (get) Token: 0x0602AB1B RID: 174875 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17006452")]
		public List<VoteCarViewModel> voteCarDatas
		{
			[Token(Token = "0x602AB1B")]
			[Address(RVA = "0x266E140", Offset = "0x266CD40", VA = "0x18266E140")]
			get
			{
				return null;
			}
		}

		// Token: 0x17006453 RID: 25683
		// (get) Token: 0x0602AB1C RID: 174876 RVA: 0x000D9710 File Offset: 0x000D7910
		[Token(Token = "0x17006453")]
		public int currentRound
		{
			[Token(Token = "0x602AB1C")]
			[Address(RVA = "0x266E010", Offset = "0x266CC10", VA = "0x18266E010")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17006454 RID: 25684
		// (get) Token: 0x0602AB1D RID: 174877 RVA: 0x000D9728 File Offset: 0x000D7928
		[Token(Token = "0x17006454")]
		public bool roundOver
		{
			[Token(Token = "0x602AB1D")]
			[Address(RVA = "0x266E0D0", Offset = "0x266CCD0", VA = "0x18266E0D0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x0602AB1E RID: 174878 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602AB1E")]
		[Address(RVA = "0x266D950", Offset = "0x266C550", VA = "0x18266D950")]
		public void LoadData(string actId, ExhibitionVersus versus)
		{
		}

		// Token: 0x0602AB1F RID: 174879 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602AB1F")]
		[Address(RVA = "0x266D840", Offset = "0x266C440", VA = "0x18266D840")]
		public VoteCarViewModel ArchieveVoteCarDataByUid(string uid)
		{
			return null;
		}

		// Token: 0x0602AB20 RID: 174880 RVA: 0x000D9740 File Offset: 0x000D7940
		[Token(Token = "0x602AB20")]
		[Address(RVA = "0x266DD60", Offset = "0x266C960", VA = "0x18266DD60")]
		private bool _CheckNewEquipment(string actId, PlayerCartInfo.Cart info)
		{
			return default(bool);
		}

		// Token: 0x0602AB21 RID: 174881 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602AB21")]
		[Address(RVA = "0x266DFA0", Offset = "0x266CBA0", VA = "0x18266DFA0")]
		public Act20sideCarVoteViewModel()
		{
		}

		// Token: 0x0403D83A RID: 251962
		[Token(Token = "0x403D83A")]
		[FieldOffset(Offset = "0x10")]
		private List<VoteCarViewModel> m_voteCarDatas;

		// Token: 0x0403D83B RID: 251963
		[Token(Token = "0x403D83B")]
		[FieldOffset(Offset = "0x18")]
		private int m_focusedIndex;

		// Token: 0x0403D83C RID: 251964
		[Token(Token = "0x403D83C")]
		[FieldOffset(Offset = "0x1C")]
		private int m_currentRound;

		// Token: 0x0403D83D RID: 251965
		[Token(Token = "0x403D83D")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_focusedIndex;

		// Token: 0x0403D83E RID: 251966
		[Token(Token = "0x403D83E")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_focusedIndex;

		// Token: 0x0403D83F RID: 251967
		[Token(Token = "0x403D83F")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_voteCarDatas;

		// Token: 0x0403D840 RID: 251968
		[Token(Token = "0x403D840")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_get_currentRound;

		// Token: 0x0403D841 RID: 251969
		[Token(Token = "0x403D841")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_get_roundOver;

		// Token: 0x0403D842 RID: 251970
		[Token(Token = "0x403D842")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_LoadData;

		// Token: 0x0403D843 RID: 251971
		[Token(Token = "0x403D843")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_ArchieveVoteCarDataByUid;

		// Token: 0x0403D844 RID: 251972
		[Token(Token = "0x403D844")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__CheckNewEquipment;

		// Token: 0x0403D845 RID: 251973
		[Token(Token = "0x403D845")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}

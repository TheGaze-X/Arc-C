using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.Activity.Act20side
{
	// Token: 0x02007691 RID: 30353
	[Token(Token = "0x2007691")]
	public class Act20sideCarVoteEntryViewModel : IHotfixable
	{
		// Token: 0x17006448 RID: 25672
		// (get) Token: 0x0602AB0B RID: 174859 RVA: 0x000D9680 File Offset: 0x000D7880
		[Token(Token = "0x17006448")]
		public int score
		{
			[Token(Token = "0x602AB0B")]
			[Address(RVA = "0x26698A0", Offset = "0x26684A0", VA = "0x1826698A0")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17006449 RID: 25673
		// (get) Token: 0x0602AB0C RID: 174860 RVA: 0x000D9698 File Offset: 0x000D7898
		[Token(Token = "0x17006449")]
		public int dailyScore
		{
			[Token(Token = "0x602AB0C")]
			[Address(RVA = "0x2669600", Offset = "0x2668200", VA = "0x182669600")]
			get
			{
				return 0;
			}
		}

		// Token: 0x1700644A RID: 25674
		// (get) Token: 0x0602AB0D RID: 174861 RVA: 0x000D96B0 File Offset: 0x000D78B0
		[Token(Token = "0x1700644A")]
		public int judgeCount
		{
			[Token(Token = "0x602AB0D")]
			[Address(RVA = "0x26696C0", Offset = "0x26682C0", VA = "0x1826696C0")]
			get
			{
				return 0;
			}
		}

		// Token: 0x1700644B RID: 25675
		// (get) Token: 0x0602AB0E RID: 174862 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700644B")]
		public string playerName
		{
			[Token(Token = "0x602AB0E")]
			[Address(RVA = "0x2669840", Offset = "0x2668440", VA = "0x182669840")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700644C RID: 25676
		// (get) Token: 0x0602AB0F RID: 174863 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700644C")]
		public string nickName
		{
			[Token(Token = "0x602AB0F")]
			[Address(RVA = "0x2669780", Offset = "0x2668380", VA = "0x182669780")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700644D RID: 25677
		// (get) Token: 0x0602AB10 RID: 174864 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700644D")]
		public AvatarInfo avatarInfo
		{
			[Token(Token = "0x602AB10")]
			[Address(RVA = "0x26695A0", Offset = "0x26681A0", VA = "0x1826695A0")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700644E RID: 25678
		// (get) Token: 0x0602AB11 RID: 174865 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700644E")]
		public PlayerCartInfo.Cart playerCart
		{
			[Token(Token = "0x602AB11")]
			[Address(RVA = "0x26697E0", Offset = "0x26683E0", VA = "0x1826697E0")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700644F RID: 25679
		// (get) Token: 0x0602AB12 RID: 174866 RVA: 0x000D96C8 File Offset: 0x000D78C8
		[Token(Token = "0x1700644F")]
		public bool hasJoinedExhibition
		{
			[Token(Token = "0x602AB12")]
			[Address(RVA = "0x2669660", Offset = "0x2668260", VA = "0x182669660")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17006450 RID: 25680
		// (get) Token: 0x0602AB13 RID: 174867 RVA: 0x000D96E0 File Offset: 0x000D78E0
		[Token(Token = "0x17006450")]
		public int level
		{
			[Token(Token = "0x602AB13")]
			[Address(RVA = "0x2669720", Offset = "0x2668320", VA = "0x182669720")]
			get
			{
				return 0;
			}
		}

		// Token: 0x0602AB14 RID: 174868 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602AB14")]
		[Address(RVA = "0x26693B0", Offset = "0x2667FB0", VA = "0x1826693B0")]
		public void LoadData(string actId)
		{
		}

		// Token: 0x0602AB15 RID: 174869 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602AB15")]
		[Address(RVA = "0x2669540", Offset = "0x2668140", VA = "0x182669540")]
		public Act20sideCarVoteEntryViewModel()
		{
		}

		// Token: 0x0403D81B RID: 251931
		[Token(Token = "0x403D81B")]
		[FieldOffset(Offset = "0x10")]
		private int m_score;

		// Token: 0x0403D81C RID: 251932
		[Token(Token = "0x403D81C")]
		[FieldOffset(Offset = "0x14")]
		private int m_dailyScore;

		// Token: 0x0403D81D RID: 251933
		[Token(Token = "0x403D81D")]
		[FieldOffset(Offset = "0x18")]
		private int m_judgeCount;

		// Token: 0x0403D81E RID: 251934
		[Token(Token = "0x403D81E")]
		[FieldOffset(Offset = "0x20")]
		private AvatarInfo m_avatarInfo;

		// Token: 0x0403D81F RID: 251935
		[Token(Token = "0x403D81F")]
		[FieldOffset(Offset = "0x28")]
		private string m_playerName;

		// Token: 0x0403D820 RID: 251936
		[Token(Token = "0x403D820")]
		[FieldOffset(Offset = "0x30")]
		private string m_nickName;

		// Token: 0x0403D821 RID: 251937
		[Token(Token = "0x403D821")]
		[FieldOffset(Offset = "0x38")]
		private int m_level;

		// Token: 0x0403D822 RID: 251938
		[Token(Token = "0x403D822")]
		[FieldOffset(Offset = "0x40")]
		private PlayerCartInfo.Cart m_playerCart;

		// Token: 0x0403D823 RID: 251939
		[Token(Token = "0x403D823")]
		[FieldOffset(Offset = "0x48")]
		private bool m_hasJoinedExhibition;

		// Token: 0x0403D824 RID: 251940
		[Token(Token = "0x403D824")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_score;

		// Token: 0x0403D825 RID: 251941
		[Token(Token = "0x403D825")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_dailyScore;

		// Token: 0x0403D826 RID: 251942
		[Token(Token = "0x403D826")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_judgeCount;

		// Token: 0x0403D827 RID: 251943
		[Token(Token = "0x403D827")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_get_playerName;

		// Token: 0x0403D828 RID: 251944
		[Token(Token = "0x403D828")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_get_nickName;

		// Token: 0x0403D829 RID: 251945
		[Token(Token = "0x403D829")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_get_avatarInfo;

		// Token: 0x0403D82A RID: 251946
		[Token(Token = "0x403D82A")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_get_playerCart;

		// Token: 0x0403D82B RID: 251947
		[Token(Token = "0x403D82B")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_get_hasJoinedExhibition;

		// Token: 0x0403D82C RID: 251948
		[Token(Token = "0x403D82C")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_get_level;

		// Token: 0x0403D82D RID: 251949
		[Token(Token = "0x403D82D")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_LoadData;

		// Token: 0x0403D82E RID: 251950
		[Token(Token = "0x403D82E")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}

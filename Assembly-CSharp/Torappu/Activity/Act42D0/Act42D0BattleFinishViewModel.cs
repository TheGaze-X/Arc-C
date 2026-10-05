using System;
using Il2CppDummyDll;
using Torappu.Battle;
using Torappu.UI.Squad;
using XLua;

namespace Torappu.Activity.Act42D0
{
	// Token: 0x02007358 RID: 29528
	[Token(Token = "0x2007358")]
	public class Act42D0BattleFinishViewModel : IHotfixable
	{
		// Token: 0x17006288 RID: 25224
		// (get) Token: 0x06029C12 RID: 171026 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17006288")]
		public string milestoneId
		{
			[Token(Token = "0x6029C12")]
			[Address(RVA = "0x2552AA0", Offset = "0x25516A0", VA = "0x182552AA0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17006289 RID: 25225
		// (get) Token: 0x06029C13 RID: 171027 RVA: 0x000D6698 File Offset: 0x000D4898
		[Token(Token = "0x17006289")]
		public int milestoneLv
		{
			[Token(Token = "0x6029C13")]
			[Address(RVA = "0x2552B00", Offset = "0x2551700", VA = "0x182552B00")]
			get
			{
				return 0;
			}
		}

		// Token: 0x1700628A RID: 25226
		// (get) Token: 0x06029C14 RID: 171028 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700628A")]
		public string progressStr
		{
			[Token(Token = "0x6029C14")]
			[Address(RVA = "0x2552C40", Offset = "0x2551840", VA = "0x182552C40")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700628B RID: 25227
		// (get) Token: 0x06029C15 RID: 171029 RVA: 0x000D66B0 File Offset: 0x000D48B0
		[Token(Token = "0x1700628B")]
		public float milestoneProgress
		{
			[Token(Token = "0x6029C15")]
			[Address(RVA = "0x2552B60", Offset = "0x2551760", VA = "0x182552B60")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x1700628C RID: 25228
		// (get) Token: 0x06029C16 RID: 171030 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700628C")]
		public string actId
		{
			[Token(Token = "0x6029C16")]
			[Address(RVA = "0x2552760", Offset = "0x2551360", VA = "0x182552760")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700628D RID: 25229
		// (get) Token: 0x06029C17 RID: 171031 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700628D")]
		public SquadItemStruct[] squadList
		{
			[Token(Token = "0x6029C17")]
			[Address(RVA = "0x2552DB0", Offset = "0x25519B0", VA = "0x182552DB0")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700628E RID: 25230
		// (get) Token: 0x06029C18 RID: 171032 RVA: 0x000D66C8 File Offset: 0x000D48C8
		[Token(Token = "0x1700628E")]
		public SquadItemStruct assistChar
		{
			[Token(Token = "0x6029C18")]
			[Address(RVA = "0x25527C0", Offset = "0x25513C0", VA = "0x1825527C0")]
			get
			{
				return default(SquadItemStruct);
			}
		}

		// Token: 0x1700628F RID: 25231
		// (get) Token: 0x06029C19 RID: 171033 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700628F")]
		public string playerName
		{
			[Token(Token = "0x6029C19")]
			[Address(RVA = "0x2552BE0", Offset = "0x25517E0", VA = "0x182552BE0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17006290 RID: 25232
		// (get) Token: 0x06029C1A RID: 171034 RVA: 0x000D66E0 File Offset: 0x000D48E0
		[Token(Token = "0x17006290")]
		public CharUISkinStruct randomIllust
		{
			[Token(Token = "0x6029C1A")]
			[Address(RVA = "0x2552D30", Offset = "0x2551930", VA = "0x182552D30")]
			get
			{
				return default(CharUISkinStruct);
			}
		}

		// Token: 0x17006291 RID: 25233
		// (get) Token: 0x06029C1B RID: 171035 RVA: 0x000D66F8 File Offset: 0x000D48F8
		[Token(Token = "0x17006291")]
		public long finishTs
		{
			[Token(Token = "0x6029C1B")]
			[Address(RVA = "0x2552900", Offset = "0x2551500", VA = "0x182552900")]
			get
			{
				return 0L;
			}
		}

		// Token: 0x17006292 RID: 25234
		// (get) Token: 0x06029C1C RID: 171036 RVA: 0x000D6710 File Offset: 0x000D4910
		[Token(Token = "0x17006292")]
		public bool isValid
		{
			[Token(Token = "0x6029C1C")]
			[Address(RVA = "0x25529A0", Offset = "0x25515A0", VA = "0x1825529A0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17006293 RID: 25235
		// (get) Token: 0x06029C1D RID: 171037 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17006293")]
		public Act42D0FinishInfoModel finishInfoModel
		{
			[Token(Token = "0x6029C1D")]
			[Address(RVA = "0x25528A0", Offset = "0x25514A0", VA = "0x1825528A0")]
			get
			{
				return null;
			}
		}

		// Token: 0x06029C1E RID: 171038 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6029C1E")]
		[Address(RVA = "0x2551900", Offset = "0x2550500", VA = "0x182551900")]
		public string GetStageName()
		{
			return null;
		}

		// Token: 0x06029C1F RID: 171039 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6029C1F")]
		[Address(RVA = "0x2551870", Offset = "0x2550470", VA = "0x182551870")]
		public string GetDisplayIconId()
		{
			return null;
		}

		// Token: 0x17006294 RID: 25236
		// (get) Token: 0x06029C20 RID: 171040 RVA: 0x000D6728 File Offset: 0x000D4928
		[Token(Token = "0x17006294")]
		public Act42D0FinishInfoModel.ViewType viewType
		{
			[Token(Token = "0x6029C20")]
			[Address(RVA = "0x2552E10", Offset = "0x2551A10", VA = "0x182552E10")]
			get
			{
				return Act42D0FinishInfoModel.ViewType.NONE;
			}
		}

		// Token: 0x17006295 RID: 25237
		// (get) Token: 0x06029C21 RID: 171041 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17006295")]
		public AvatarInfo avatarInfo
		{
			[Token(Token = "0x6029C21")]
			[Address(RVA = "0x2552840", Offset = "0x2551440", VA = "0x182552840")]
			get
			{
				return null;
			}
		}

		// Token: 0x17006296 RID: 25238
		// (get) Token: 0x06029C22 RID: 171042 RVA: 0x000D6740 File Offset: 0x000D4940
		[Token(Token = "0x17006296")]
		public int milestoneGot
		{
			[Token(Token = "0x6029C22")]
			[Address(RVA = "0x2552A00", Offset = "0x2551600", VA = "0x182552A00")]
			get
			{
				return 0;
			}
		}

		// Token: 0x06029C23 RID: 171043 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029C23")]
		[Address(RVA = "0x25519B0", Offset = "0x25505B0", VA = "0x1825519B0")]
		public void LoadData()
		{
		}

		// Token: 0x06029C24 RID: 171044 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029C24")]
		[Address(RVA = "0x2552170", Offset = "0x2550D70", VA = "0x182552170")]
		private void _LoadMilestoneLvInfo(Act42D0Data actData, Act42D0FinishInfoModel finishInfoModel)
		{
		}

		// Token: 0x06029C25 RID: 171045 RVA: 0x000D6758 File Offset: 0x000D4958
		[Token(Token = "0x6029C25")]
		[Address(RVA = "0x2552380", Offset = "0x2550F80", VA = "0x182552380")]
		private bool _TryLoadFinishInfo(Act42D0Data actData, BattleInOut battleInOut)
		{
			return default(bool);
		}

		// Token: 0x06029C26 RID: 171046 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029C26")]
		[Address(RVA = "0x2551CA0", Offset = "0x25508A0", VA = "0x182551CA0")]
		private void _LoadBasicInfo(BattleInOut battleInOut, PlayerDataModel playerData)
		{
		}

		// Token: 0x06029C27 RID: 171047 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029C27")]
		[Address(RVA = "0x2552700", Offset = "0x2551300", VA = "0x182552700")]
		public Act42D0BattleFinishViewModel()
		{
		}

		// Token: 0x0403BC3D RID: 244797
		[Token(Token = "0x403BC3D")]
		[FieldOffset(Offset = "0x10")]
		private bool m_isValid;

		// Token: 0x0403BC3E RID: 244798
		[Token(Token = "0x403BC3E")]
		[FieldOffset(Offset = "0x18")]
		private CharUISkinStruct m_randomIllust;

		// Token: 0x0403BC3F RID: 244799
		[Token(Token = "0x403BC3F")]
		[FieldOffset(Offset = "0x30")]
		private string m_playerName;

		// Token: 0x0403BC40 RID: 244800
		[Token(Token = "0x403BC40")]
		[FieldOffset(Offset = "0x38")]
		private SquadItemStruct[] m_squadList;

		// Token: 0x0403BC41 RID: 244801
		[Token(Token = "0x403BC41")]
		[FieldOffset(Offset = "0x40")]
		private SquadItemStruct m_assistChar;

		// Token: 0x0403BC42 RID: 244802
		[Token(Token = "0x403BC42")]
		[FieldOffset(Offset = "0x50")]
		private Act42D0FinishInfoModel m_finishInfoModel;

		// Token: 0x0403BC43 RID: 244803
		[Token(Token = "0x403BC43")]
		[FieldOffset(Offset = "0x58")]
		private AvatarInfo m_avatarInfo;

		// Token: 0x0403BC44 RID: 244804
		[Token(Token = "0x403BC44")]
		[FieldOffset(Offset = "0x60")]
		private string m_actId;

		// Token: 0x0403BC45 RID: 244805
		[Token(Token = "0x403BC45")]
		[FieldOffset(Offset = "0x68")]
		private int m_milestoneLv;

		// Token: 0x0403BC46 RID: 244806
		[Token(Token = "0x403BC46")]
		[FieldOffset(Offset = "0x6C")]
		private int m_milestoneCurrent;

		// Token: 0x0403BC47 RID: 244807
		[Token(Token = "0x403BC47")]
		[FieldOffset(Offset = "0x70")]
		private int m_milestoneMax;

		// Token: 0x0403BC48 RID: 244808
		[Token(Token = "0x403BC48")]
		[FieldOffset(Offset = "0x78")]
		private string m_milestoneId;

		// Token: 0x0403BC49 RID: 244809
		[Token(Token = "0x403BC49")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_milestoneId;

		// Token: 0x0403BC4A RID: 244810
		[Token(Token = "0x403BC4A")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_milestoneLv;

		// Token: 0x0403BC4B RID: 244811
		[Token(Token = "0x403BC4B")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_progressStr;

		// Token: 0x0403BC4C RID: 244812
		[Token(Token = "0x403BC4C")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_get_milestoneProgress;

		// Token: 0x0403BC4D RID: 244813
		[Token(Token = "0x403BC4D")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_get_actId;

		// Token: 0x0403BC4E RID: 244814
		[Token(Token = "0x403BC4E")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_get_squadList;

		// Token: 0x0403BC4F RID: 244815
		[Token(Token = "0x403BC4F")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_get_assistChar;

		// Token: 0x0403BC50 RID: 244816
		[Token(Token = "0x403BC50")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_get_playerName;

		// Token: 0x0403BC51 RID: 244817
		[Token(Token = "0x403BC51")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_get_randomIllust;

		// Token: 0x0403BC52 RID: 244818
		[Token(Token = "0x403BC52")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_get_finishTs;

		// Token: 0x0403BC53 RID: 244819
		[Token(Token = "0x403BC53")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_get_isValid;

		// Token: 0x0403BC54 RID: 244820
		[Token(Token = "0x403BC54")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_get_finishInfoModel;

		// Token: 0x0403BC55 RID: 244821
		[Token(Token = "0x403BC55")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0_GetStageName;

		// Token: 0x0403BC56 RID: 244822
		[Token(Token = "0x403BC56")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0_GetDisplayIconId;

		// Token: 0x0403BC57 RID: 244823
		[Token(Token = "0x403BC57")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0_get_viewType;

		// Token: 0x0403BC58 RID: 244824
		[Token(Token = "0x403BC58")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0_get_avatarInfo;

		// Token: 0x0403BC59 RID: 244825
		[Token(Token = "0x403BC59")]
		[FieldOffset(Offset = "0x80")]
		private static DelegateBridge __Hotfix0_get_milestoneGot;

		// Token: 0x0403BC5A RID: 244826
		[Token(Token = "0x403BC5A")]
		[FieldOffset(Offset = "0x88")]
		private static DelegateBridge __Hotfix0_LoadData;

		// Token: 0x0403BC5B RID: 244827
		[Token(Token = "0x403BC5B")]
		[FieldOffset(Offset = "0x90")]
		private static DelegateBridge __Hotfix0__LoadMilestoneLvInfo;

		// Token: 0x0403BC5C RID: 244828
		[Token(Token = "0x403BC5C")]
		[FieldOffset(Offset = "0x98")]
		private static DelegateBridge __Hotfix0__TryLoadFinishInfo;

		// Token: 0x0403BC5D RID: 244829
		[Token(Token = "0x403BC5D")]
		[FieldOffset(Offset = "0xA0")]
		private static DelegateBridge __Hotfix0__LoadBasicInfo;

		// Token: 0x0403BC5E RID: 244830
		[Token(Token = "0x403BC5E")]
		[FieldOffset(Offset = "0xA8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}

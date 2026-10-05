using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using XLua;

namespace Torappu.Battle.AutoChess
{
	// Token: 0x02002783 RID: 10115
	[Token(Token = "0x2002783")]
	public class AutoChessSettleBossModel : IHotfixable
	{
		// Token: 0x17002415 RID: 9237
		// (get) Token: 0x0601081E RID: 67614 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0601081F RID: 67615 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17002415")]
		public string bossId
		{
			[Token(Token = "0x601081E")]
			[Address(RVA = "0x84D9E0", Offset = "0x84C5E0", VA = "0x18084D9E0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x601081F")]
			[Address(RVA = "0x84DC10", Offset = "0x84C810", VA = "0x18084DC10")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17002416 RID: 9238
		// (get) Token: 0x06010820 RID: 67616 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06010821 RID: 67617 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17002416")]
		public string enemyId
		{
			[Token(Token = "0x6010820")]
			[Address(RVA = "0x84DA40", Offset = "0x84C640", VA = "0x18084DA40")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6010821")]
			[Address(RVA = "0x84DC90", Offset = "0x84C890", VA = "0x18084DC90")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17002417 RID: 9239
		// (get) Token: 0x06010822 RID: 67618 RVA: 0x00064AB8 File Offset: 0x00062CB8
		// (set) Token: 0x06010823 RID: 67619 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17002417")]
		public bool isDead
		{
			[Token(Token = "0x6010822")]
			[Address(RVA = "0x84DAA0", Offset = "0x84C6A0", VA = "0x18084DAA0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6010823")]
			[Address(RVA = "0x84DD10", Offset = "0x84C910", VA = "0x18084DD10")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17002418 RID: 9240
		// (get) Token: 0x06010824 RID: 67620 RVA: 0x00064AD0 File Offset: 0x00062CD0
		// (set) Token: 0x06010825 RID: 67621 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17002418")]
		public bool isHidden
		{
			[Token(Token = "0x6010824")]
			[Address(RVA = "0x84DBB0", Offset = "0x84C7B0", VA = "0x18084DBB0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6010825")]
			[Address(RVA = "0x84DD80", Offset = "0x84C980", VA = "0x18084DD80")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17002419 RID: 9241
		// (get) Token: 0x06010826 RID: 67622 RVA: 0x00064AE8 File Offset: 0x00062CE8
		[Token(Token = "0x17002419")]
		public bool isEmpty
		{
			[Token(Token = "0x6010826")]
			[Address(RVA = "0x84DB00", Offset = "0x84C700", VA = "0x18084DB00")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06010827 RID: 67623 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6010827")]
		[Address(RVA = "0x84D6C0", Offset = "0x84C2C0", VA = "0x18084D6C0")]
		public void ClearData()
		{
		}

		// Token: 0x06010828 RID: 67624 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6010828")]
		[Address(RVA = "0x84D7B0", Offset = "0x84C3B0", VA = "0x18084D7B0")]
		public void LoadData(SettleData.BossSettleRecord bossRecord)
		{
		}

		// Token: 0x06010829 RID: 67625 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6010829")]
		[Address(RVA = "0x84D980", Offset = "0x84C580", VA = "0x18084D980")]
		public AutoChessSettleBossModel()
		{
		}

		// Token: 0x0401283C RID: 75836
		[Token(Token = "0x401283C")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_bossId;

		// Token: 0x0401283D RID: 75837
		[Token(Token = "0x401283D")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_bossId;

		// Token: 0x0401283E RID: 75838
		[Token(Token = "0x401283E")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_enemyId;

		// Token: 0x0401283F RID: 75839
		[Token(Token = "0x401283F")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_set_enemyId;

		// Token: 0x04012840 RID: 75840
		[Token(Token = "0x4012840")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_get_isDead;

		// Token: 0x04012841 RID: 75841
		[Token(Token = "0x4012841")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_set_isDead;

		// Token: 0x04012842 RID: 75842
		[Token(Token = "0x4012842")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_get_isHidden;

		// Token: 0x04012843 RID: 75843
		[Token(Token = "0x4012843")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_set_isHidden;

		// Token: 0x04012844 RID: 75844
		[Token(Token = "0x4012844")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_get_isEmpty;

		// Token: 0x04012845 RID: 75845
		[Token(Token = "0x4012845")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_ClearData;

		// Token: 0x04012846 RID: 75846
		[Token(Token = "0x4012846")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_LoadData;

		// Token: 0x04012847 RID: 75847
		[Token(Token = "0x4012847")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}

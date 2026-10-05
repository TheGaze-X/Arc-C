using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Torappu.Battle;
using XLua;

namespace Torappu.Activity.VecBreakV2
{
	// Token: 0x02006E89 RID: 28297
	[Token(Token = "0x2006E89")]
	public abstract class VecBreakStageInfoProvider : IHotfixable
	{
		// Token: 0x06028458 RID: 164952 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028458")]
		[Address(RVA = "0x23A62A0", Offset = "0x23A4EA0", VA = "0x1823A62A0")]
		protected VecBreakStageInfoProvider()
		{
		}

		// Token: 0x17005F13 RID: 24339
		// (get) Token: 0x06028459 RID: 164953 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0602845A RID: 164954 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17005F13")]
		public string actId
		{
			[Token(Token = "0x6028459")]
			[Address(RVA = "0x23A6350", Offset = "0x23A4F50", VA = "0x1823A6350")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x602845A")]
			[Address(RVA = "0x23A6470", Offset = "0x23A5070", VA = "0x1823A6470")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17005F14 RID: 24340
		// (get) Token: 0x0602845B RID: 164955 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0602845C RID: 164956 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17005F14")]
		public string currStageId
		{
			[Token(Token = "0x602845B")]
			[Address(RVA = "0x23A6410", Offset = "0x23A5010", VA = "0x1823A6410")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x602845C")]
			[Address(RVA = "0x23A6570", Offset = "0x23A5170", VA = "0x1823A6570")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17005F15 RID: 24341
		// (get) Token: 0x0602845D RID: 164957 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0602845E RID: 164958 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17005F15")]
		public DataBundle bundleToJumpBack
		{
			[Token(Token = "0x602845D")]
			[Address(RVA = "0x23A63B0", Offset = "0x23A4FB0", VA = "0x1823A63B0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x602845E")]
			[Address(RVA = "0x23A64F0", Offset = "0x23A50F0", VA = "0x1823A64F0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17005F16 RID: 24342
		// (get) Token: 0x0602845F RID: 164959
		[Token(Token = "0x17005F16")]
		public abstract string squadSaveKey { [Token(Token = "0x602845F")] get; }

		// Token: 0x17005F17 RID: 24343
		// (get) Token: 0x06028460 RID: 164960
		[Token(Token = "0x17005F17")]
		public abstract int squadSlotMax { [Token(Token = "0x6028460")] get; }

		// Token: 0x17005F18 RID: 24344
		// (get) Token: 0x06028461 RID: 164961
		[Token(Token = "0x17005F18")]
		public abstract bool initFillWithPlayerSquad { [Token(Token = "0x6028461")] get; }

		// Token: 0x17005F19 RID: 24345
		// (get) Token: 0x06028462 RID: 164962
		[Token(Token = "0x17005F19")]
		public abstract bool canAssist { [Token(Token = "0x6028462")] get; }

		// Token: 0x17005F1A RID: 24346
		// (get) Token: 0x06028463 RID: 164963
		[Token(Token = "0x17005F1A")]
		public abstract BattleStageMeta stageMeta { [Token(Token = "0x6028463")] get; }

		// Token: 0x17005F1B RID: 24347
		// (get) Token: 0x06028464 RID: 164964
		[Token(Token = "0x17005F1B")]
		public abstract GameModeMeta gameModeMeta { [Token(Token = "0x6028464")] get; }

		// Token: 0x17005F1C RID: 24348
		// (get) Token: 0x06028465 RID: 164965
		[Token(Token = "0x17005F1C")]
		public abstract GameTagMeta gameTagMeta { [Token(Token = "0x6028465")] get; }

		// Token: 0x06028466 RID: 164966
		[Token(Token = "0x6028466")]
		public abstract IStartBattleServiceConfig CreateStartBattleConfig(CommonStartBattleRequest.SquadModel squadModel, SquadFriendData assistFriend);

		// Token: 0x06028467 RID: 164967
		[Token(Token = "0x6028467")]
		public abstract IFinishBattleServiceConfig CreateFinishBattleConfig();

		// Token: 0x06028468 RID: 164968 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028468")]
		[Address(RVA = "0x23A5B70", Offset = "0x23A4770", VA = "0x1823A5B70")]
		public void FetchRuneList(List<RuneTable.PackedRuneData> runeList)
		{
		}

		// Token: 0x06028469 RID: 164969
		[Token(Token = "0x6028469")]
		protected abstract void OnInit();

		// Token: 0x0602846A RID: 164970 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602846A")]
		[Address(RVA = "0x23A5DC0", Offset = "0x23A49C0", VA = "0x1823A5DC0")]
		public string GetDefendHint(VecBreakStageDefendStatus defendStatus)
		{
			return null;
		}

		// Token: 0x0602846B RID: 164971 RVA: 0x000D12B0 File Offset: 0x000CF4B0
		[Token(Token = "0x602846B")]
		[Address(RVA = "0x23A5540", Offset = "0x23A4140", VA = "0x1823A5540")]
		public VecBreakStageDefendStatus CalcDefendStatus(int charInstId)
		{
			return VecBreakStageDefendStatus.NONE;
		}

		// Token: 0x0602846C RID: 164972 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602846C")]
		[Address(RVA = "0x23A5E70", Offset = "0x23A4A70", VA = "0x1823A5E70")]
		private void _FetchCharDefendStageList(int charInstId, List<string> stageList)
		{
		}

		// Token: 0x0602846D RID: 164973 RVA: 0x000D12C8 File Offset: 0x000CF4C8
		[Token(Token = "0x602846D")]
		[Address(RVA = "0x23A60E0", Offset = "0x23A4CE0", VA = "0x1823A60E0")]
		private bool _TryGetDefenseGroupId(List<string> stageList, out string groupId)
		{
			return default(bool);
		}

		// Token: 0x0602846E RID: 164974 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602846E")]
		[Address(RVA = "0x23A5850", Offset = "0x23A4450", VA = "0x1823A5850")]
		public static VecBreakStageInfoProvider Create(VecBreakSquadPage.InputParams input)
		{
			return null;
		}

		// Token: 0x040393CC RID: 234444
		[Token(Token = "0x40393CC")]
		[FieldOffset(Offset = "0x10")]
		private List<string> m_tempStageIdList;

		// Token: 0x040393CD RID: 234445
		[Token(Token = "0x40393CD")]
		[FieldOffset(Offset = "0x18")]
		protected ActVecBreakV2Data m_actData;

		// Token: 0x040393D1 RID: 234449
		[Token(Token = "0x40393D1")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x040393D2 RID: 234450
		[Token(Token = "0x40393D2")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_actId;

		// Token: 0x040393D3 RID: 234451
		[Token(Token = "0x40393D3")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_set_actId;

		// Token: 0x040393D4 RID: 234452
		[Token(Token = "0x40393D4")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_get_currStageId;

		// Token: 0x040393D5 RID: 234453
		[Token(Token = "0x40393D5")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_set_currStageId;

		// Token: 0x040393D6 RID: 234454
		[Token(Token = "0x40393D6")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_get_bundleToJumpBack;

		// Token: 0x040393D7 RID: 234455
		[Token(Token = "0x40393D7")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_set_bundleToJumpBack;

		// Token: 0x040393D8 RID: 234456
		[Token(Token = "0x40393D8")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_FetchRuneList;

		// Token: 0x040393D9 RID: 234457
		[Token(Token = "0x40393D9")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_GetDefendHint;

		// Token: 0x040393DA RID: 234458
		[Token(Token = "0x40393DA")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_CalcDefendStatus;

		// Token: 0x040393DB RID: 234459
		[Token(Token = "0x40393DB")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0__FetchCharDefendStageList;

		// Token: 0x040393DC RID: 234460
		[Token(Token = "0x40393DC")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0__TryGetDefenseGroupId;

		// Token: 0x040393DD RID: 234461
		[Token(Token = "0x40393DD")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0_Create;
	}
}

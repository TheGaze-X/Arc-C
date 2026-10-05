using System;
using System.Collections;
using Il2CppDummyDll;
using Torappu.UI;
using UnityEngine;
using XLua;

namespace Torappu.Activity.VecBreakV2
{
	// Token: 0x02006E46 RID: 28230
	[Token(Token = "0x2006E46")]
	public class ActVecBreakV2OffensePage : StateEnginePage
	{
		// Token: 0x17005EF1 RID: 24305
		// (get) Token: 0x060282C1 RID: 164545 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17005EF1")]
		public string actId
		{
			[Token(Token = "0x60282C1")]
			[Address(RVA = "0x2377B40", Offset = "0x2376740", VA = "0x182377B40")]
			get
			{
				return null;
			}
		}

		// Token: 0x060282C2 RID: 164546 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60282C2")]
		[Address(RVA = "0x2377820", Offset = "0x2376420", VA = "0x182377820")]
		public void GetAndConsumeParam(out string prevBattleStageId, out bool isStageCompletedBeforeBattle)
		{
		}

		// Token: 0x17005EF2 RID: 24306
		// (get) Token: 0x060282C3 RID: 164547 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17005EF2")]
		public UICompDialogMgr dlgMgr
		{
			[Token(Token = "0x60282C3")]
			[Address(RVA = "0x2377BA0", Offset = "0x23767A0", VA = "0x182377BA0")]
			get
			{
				return null;
			}
		}

		// Token: 0x060282C4 RID: 164548 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60282C4")]
		[Address(RVA = "0x23779A0", Offset = "0x23765A0", VA = "0x1823779A0", Slot = "8")]
		protected override void OnCreate(DataBundle savedInst)
		{
		}

		// Token: 0x060282C5 RID: 164549 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60282C5")]
		[Address(RVA = "0x23778F0", Offset = "0x23764F0", VA = "0x1823778F0", Slot = "27")]
		protected override IEnumerator InitStateEngine()
		{
			return null;
		}

		// Token: 0x060282C6 RID: 164550 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60282C6")]
		[Address(RVA = "0x2377AE0", Offset = "0x23766E0", VA = "0x182377AE0")]
		public ActVecBreakV2OffensePage()
		{
		}

		// Token: 0x060282C8 RID: 164552 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60282C8")]
		[Address(RVA = "0xE66190", Offset = "0xE64D90", VA = "0x180E66190")]
		private void <>xLuaBaseProxy_OnCreate(DataBundle P0)
		{
		}

		// Token: 0x060282C9 RID: 164553 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60282C9")]
		[Address(RVA = "0xE66180", Offset = "0xE64D80", VA = "0x180E66180")]
		private IEnumerator <>xLuaBaseProxy_InitStateEngine()
		{
			return null;
		}

		// Token: 0x040390D8 RID: 233688
		[Token(Token = "0x40390D8")]
		public const string KEY_PARAM_BUNDLE = "key_vec_break_v2_offense_param";

		// Token: 0x040390D9 RID: 233689
		[Token(Token = "0x40390D9")]
		[FieldOffset(Offset = "0xF0")]
		[SerializeField]
		private RectTransform _dlgContainer;

		// Token: 0x040390DA RID: 233690
		[Token(Token = "0x40390DA")]
		[FieldOffset(Offset = "0xF8")]
		private string m_actId;

		// Token: 0x040390DB RID: 233691
		[Token(Token = "0x40390DB")]
		[FieldOffset(Offset = "0x100")]
		private OffenseStateType m_stateType;

		// Token: 0x040390DC RID: 233692
		[Token(Token = "0x40390DC")]
		[FieldOffset(Offset = "0x108")]
		private string m_prevBattleStageId;

		// Token: 0x040390DD RID: 233693
		[Token(Token = "0x40390DD")]
		[FieldOffset(Offset = "0x110")]
		private bool m_isStageCompletedBeforeBattle;

		// Token: 0x040390DE RID: 233694
		[Token(Token = "0x40390DE")]
		[FieldOffset(Offset = "0x118")]
		private UICompDialogMgr m_dlgMgr;

		// Token: 0x040390DF RID: 233695
		[Token(Token = "0x40390DF")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_actId;

		// Token: 0x040390E0 RID: 233696
		[Token(Token = "0x40390E0")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_GetAndConsumeParam;

		// Token: 0x040390E1 RID: 233697
		[Token(Token = "0x40390E1")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_dlgMgr;

		// Token: 0x040390E2 RID: 233698
		[Token(Token = "0x40390E2")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnCreate;

		// Token: 0x040390E3 RID: 233699
		[Token(Token = "0x40390E3")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_InitStateEngine;

		// Token: 0x040390E4 RID: 233700
		[Token(Token = "0x40390E4")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02006E47 RID: 28231
		[Token(Token = "0x2006E47")]
		public class Params
		{
			// Token: 0x060282CA RID: 164554 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60282CA")]
			[Address(RVA = "0x2387D40", Offset = "0x2386940", VA = "0x182387D40")]
			public string Serialize()
			{
				return null;
			}

			// Token: 0x060282CB RID: 164555 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60282CB")]
			[Address(RVA = "0x2387C20", Offset = "0x2386820", VA = "0x182387C20")]
			public static ActVecBreakV2OffensePage.Params Deserialize(string str)
			{
				return null;
			}

			// Token: 0x060282CC RID: 164556 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60282CC")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public Params()
			{
			}

			// Token: 0x040390E5 RID: 233701
			[Token(Token = "0x40390E5")]
			[FieldOffset(Offset = "0x10")]
			public string actId;

			// Token: 0x040390E6 RID: 233702
			[Token(Token = "0x40390E6")]
			[FieldOffset(Offset = "0x18")]
			public OffenseStateType stateType;

			// Token: 0x040390E7 RID: 233703
			[Token(Token = "0x40390E7")]
			[FieldOffset(Offset = "0x20")]
			public string prevBattleStageId;

			// Token: 0x040390E8 RID: 233704
			[Token(Token = "0x40390E8")]
			[FieldOffset(Offset = "0x28")]
			public bool isStageCompletedBeforeBattle;
		}
	}
}

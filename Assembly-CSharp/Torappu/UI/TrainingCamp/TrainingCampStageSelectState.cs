using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.TrainingCamp
{
	// Token: 0x02003D1E RID: 15646
	[Token(Token = "0x2003D1E")]
	public class TrainingCampStageSelectState : State, IValueMsgReceiver
	{
		// Token: 0x06018632 RID: 99890 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018632")]
		[Address(RVA = "0x10D5270", Offset = "0x10D3E70", VA = "0x1810D5270")]
		private void _InitIfNot()
		{
		}

		// Token: 0x06018633 RID: 99891 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6018633")]
		[Address(RVA = "0x10D3E50", Offset = "0x10D2A50", VA = "0x1810D3E50", Slot = "9")]
		public override IStateBean GetCacheBean()
		{
			return null;
		}

		// Token: 0x06018634 RID: 99892 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018634")]
		[Address(RVA = "0x10D3EB0", Offset = "0x10D2AB0", VA = "0x1810D3EB0", Slot = "14")]
		protected override void OnEnter()
		{
		}

		// Token: 0x06018635 RID: 99893 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6018635")]
		[Address(RVA = "0x10D4620", Offset = "0x10D3220", VA = "0x1810D4620", Slot = "10")]
		public override Dictionary<Type, Action<IStateBean>> RegisterToDataListener()
		{
			return null;
		}

		// Token: 0x06018636 RID: 99894 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018636")]
		[Address(RVA = "0x10D44E0", Offset = "0x10D30E0", VA = "0x1810D44E0")]
		public void OnOpenEnemy()
		{
		}

		// Token: 0x06018637 RID: 99895 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018637")]
		[Address(RVA = "0x10D4780", Offset = "0x10D3380", VA = "0x1810D4780")]
		public void StartBattle()
		{
		}

		// Token: 0x06018638 RID: 99896 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018638")]
		[Address(RVA = "0x10D43C0", Offset = "0x10D2FC0", VA = "0x1810D43C0", Slot = "23")]
		public void OnMessage(int key, ValueBundle msg)
		{
		}

		// Token: 0x06018639 RID: 99897 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018639")]
		[Address(RVA = "0x10D5420", Offset = "0x10D4020", VA = "0x1810D5420")]
		public TrainingCampStageSelectState()
		{
		}

		// Token: 0x0601863B RID: 99899 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601863B")]
		[Address(RVA = "0xE63450", Offset = "0xE62050", VA = "0x180E63450")]
		private void <>xLuaBaseProxy_OnEnter()
		{
		}

		// Token: 0x0601863C RID: 99900 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601863C")]
		[Address(RVA = "0xE63480", Offset = "0xE62080", VA = "0x180E63480")]
		private Dictionary<Type, Action<IStateBean>> <>xLuaBaseProxy_RegisterToDataListener()
		{
			return null;
		}

		// Token: 0x0401DD2C RID: 122156
		[Token(Token = "0x401DD2C")]
		[NonSerialized]
		public const int MSG_SELECT_STAGE = 0;

		// Token: 0x0401DD2D RID: 122157
		[Token(Token = "0x401DD2D")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private TrainingCampStageSelectView _view;

		// Token: 0x0401DD2E RID: 122158
		[Token(Token = "0x401DD2E")]
		[FieldOffset(Offset = "0x58")]
		private bool m_isInited;

		// Token: 0x0401DD2F RID: 122159
		[Token(Token = "0x401DD2F")]
		[FieldOffset(Offset = "0x60")]
		private TrainingCampStageSelectStateBean m_stateBean;

		// Token: 0x0401DD30 RID: 122160
		[Token(Token = "0x401DD30")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0401DD31 RID: 122161
		[Token(Token = "0x401DD31")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_GetCacheBean;

		// Token: 0x0401DD32 RID: 122162
		[Token(Token = "0x401DD32")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnEnter;

		// Token: 0x0401DD33 RID: 122163
		[Token(Token = "0x401DD33")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_RegisterToDataListener;

		// Token: 0x0401DD34 RID: 122164
		[Token(Token = "0x401DD34")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_OnOpenEnemy;

		// Token: 0x0401DD35 RID: 122165
		[Token(Token = "0x401DD35")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_StartBattle;

		// Token: 0x0401DD36 RID: 122166
		[Token(Token = "0x401DD36")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_OnMessage;

		// Token: 0x0401DD37 RID: 122167
		[Token(Token = "0x401DD37")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02003D1F RID: 15647
		[Token(Token = "0x2003D1F")]
		private class TrainingCampStartBattleServiceConfig : StartBattleServiceConfig<TrainingCampStartBattleRequest, CampaignStartBattleResponse>
		{
			// Token: 0x0601863D RID: 99901 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601863D")]
			[Address(RVA = "0x10D77B0", Offset = "0x10D63B0", VA = "0x1810D77B0")]
			public TrainingCampStartBattleServiceConfig(string stageId)
			{
			}

			// Token: 0x17003A50 RID: 14928
			// (get) Token: 0x0601863E RID: 99902 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17003A50")]
			protected override string serviceCode
			{
				[Token(Token = "0x601863E")]
				[Address(RVA = "0x10D7840", Offset = "0x10D6440", VA = "0x1810D7840", Slot = "6")]
				get
				{
					return null;
				}
			}

			// Token: 0x0601863F RID: 99903 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x601863F")]
			[Address(RVA = "0x10D7710", Offset = "0x10D6310", VA = "0x1810D7710", Slot = "5")]
			protected override TrainingCampStartBattleRequest ParseRequest()
			{
				return null;
			}

			// Token: 0x0401DD38 RID: 122168
			[Token(Token = "0x401DD38")]
			[FieldOffset(Offset = "0x10")]
			private string m_stageId;

			// Token: 0x0401DD39 RID: 122169
			[Token(Token = "0x401DD39")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x0401DD3A RID: 122170
			[Token(Token = "0x401DD3A")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_get_serviceCode;

			// Token: 0x0401DD3B RID: 122171
			[Token(Token = "0x401DD3B")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_ParseRequest;
		}

		// Token: 0x02003D20 RID: 15648
		[Token(Token = "0x2003D20")]
		private class TrainingCampFinishBattleServiceConfig : FinishBattleServiceConfig<TrainingCampBattleFinishRequest, TrainingCampBattleFinishResponse>
		{
			// Token: 0x06018640 RID: 99904 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6018640")]
			[Address(RVA = "0x10D1D50", Offset = "0x10D0950", VA = "0x1810D1D50")]
			public TrainingCampFinishBattleServiceConfig(string serviceCode)
			{
			}
		}
	}
}

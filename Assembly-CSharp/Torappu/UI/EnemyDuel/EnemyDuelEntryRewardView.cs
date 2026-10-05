using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.DataBind;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.EnemyDuel
{
	// Token: 0x02004F94 RID: 20372
	[Token(Token = "0x2004F94")]
	public class EnemyDuelEntryRewardView : DataBinder<EnemyDuelEntryRewardProperty>, IHotfixable
	{
		// Token: 0x0601E49B RID: 124059 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E49B")]
		[Address(RVA = "0x17FDC50", Offset = "0x17FC850", VA = "0x1817FDC50")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0601E49C RID: 124060 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E49C")]
		[Address(RVA = "0x17FD990", Offset = "0x17FC590", VA = "0x1817FD990", Slot = "7")]
		public override void OnValueChanged(EnemyDuelEntryRewardProperty property)
		{
		}

		// Token: 0x0601E49D RID: 124061 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E49D")]
		[Address(RVA = "0x17FDF00", Offset = "0x17FCB00", VA = "0x1817FDF00")]
		public EnemyDuelEntryRewardView()
		{
		}

		// Token: 0x040286CC RID: 165580
		[Token(Token = "0x40286CC")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private SimpleLayoutContent _basicScoreContent;

		// Token: 0x040286CD RID: 165581
		[Token(Token = "0x40286CD")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private SimpleLayoutContent _operationScoreContent;

		// Token: 0x040286CE RID: 165582
		[Token(Token = "0x40286CE")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private SimpleLayoutContent _standScoreContent;

		// Token: 0x040286CF RID: 165583
		[Token(Token = "0x40286CF")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Text _operationSkipRate;

		// Token: 0x040286D0 RID: 165584
		[Token(Token = "0x40286D0")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Text _operationBetRate;

		// Token: 0x040286D1 RID: 165585
		[Token(Token = "0x40286D1")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private Text _operationAllinRate;

		// Token: 0x040286D2 RID: 165586
		[Token(Token = "0x40286D2")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private Text _standBetRate;

		// Token: 0x040286D3 RID: 165587
		[Token(Token = "0x40286D3")]
		[FieldOffset(Offset = "0x58")]
		private bool m_isInited;

		// Token: 0x040286D4 RID: 165588
		[Token(Token = "0x40286D4")]
		[FieldOffset(Offset = "0x60")]
		private EnemyDuelEntryRewardViewModel m_cachedModel;

		// Token: 0x040286D5 RID: 165589
		[Token(Token = "0x40286D5")]
		[FieldOffset(Offset = "0x68")]
		private EnemyDuelEntryRewardView.BasicScoreAdapter m_basicScoreAdapter;

		// Token: 0x040286D6 RID: 165590
		[Token(Token = "0x40286D6")]
		[FieldOffset(Offset = "0x70")]
		private EnemyDuelEntryRewardView.OperationScoreAdapter m_operationScoreAdapter;

		// Token: 0x040286D7 RID: 165591
		[Token(Token = "0x40286D7")]
		[FieldOffset(Offset = "0x78")]
		private EnemyDuelEntryRewardView.StandScoreAdapter m_standScoreAdapter;

		// Token: 0x040286D8 RID: 165592
		[Token(Token = "0x40286D8")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x040286D9 RID: 165593
		[Token(Token = "0x40286D9")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnValueChanged;

		// Token: 0x040286DA RID: 165594
		[Token(Token = "0x40286DA")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02004F95 RID: 20373
		[Token(Token = "0x2004F95")]
		private abstract class FormAdapter : SimpleLayoutAdapter
		{
			// Token: 0x170046EA RID: 18154
			// (get) Token: 0x0601E49E RID: 124062 RVA: 0x000AE180 File Offset: 0x000AC380
			[Token(Token = "0x170046EA")]
			public override int count
			{
				[Token(Token = "0x601E49E")]
				[Address(RVA = "0x180AE20", Offset = "0x1809A20", VA = "0x18180AE20", Slot = "4")]
				get
				{
					return 0;
				}
			}

			// Token: 0x0601E49F RID: 124063 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x601E49F")]
			[Address(RVA = "0x180AAD0", Offset = "0x18096D0", VA = "0x18180AAD0", Slot = "5")]
			public override GameObject RenderView(int position, GameObject prefab, Transform parent)
			{
				return null;
			}

			// Token: 0x0601E4A0 RID: 124064
			[Token(Token = "0x601E4A0")]
			protected abstract ListDict<string, string> LoadDataMap();

			// Token: 0x0601E4A1 RID: 124065 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601E4A1")]
			[Address(RVA = "0x180ADC0", Offset = "0x18099C0", VA = "0x18180ADC0")]
			protected FormAdapter()
			{
			}

			// Token: 0x040286DB RID: 165595
			[Token(Token = "0x40286DB")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_get_count;

			// Token: 0x040286DC RID: 165596
			[Token(Token = "0x40286DC")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_RenderView;

			// Token: 0x040286DD RID: 165597
			[Token(Token = "0x40286DD")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}

		// Token: 0x02004F96 RID: 20374
		[Token(Token = "0x2004F96")]
		private class BasicScoreAdapter : EnemyDuelEntryRewardView.FormAdapter
		{
			// Token: 0x0601E4A2 RID: 124066 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601E4A2")]
			[Address(RVA = "0x17F7D40", Offset = "0x17F6940", VA = "0x1817F7D40")]
			public BasicScoreAdapter(EnemyDuelEntryRewardView closure)
			{
			}

			// Token: 0x0601E4A3 RID: 124067 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x601E4A3")]
			[Address(RVA = "0x17F7A50", Offset = "0x17F6650", VA = "0x1817F7A50", Slot = "9")]
			protected override ListDict<string, string> LoadDataMap()
			{
				return null;
			}

			// Token: 0x040286DE RID: 165598
			[Token(Token = "0x40286DE")]
			[FieldOffset(Offset = "0x20")]
			private EnemyDuelEntryRewardView m_closure;

			// Token: 0x040286DF RID: 165599
			[Token(Token = "0x40286DF")]
			[FieldOffset(Offset = "0x28")]
			private ListDict<string, string> m_basicScoreMap;

			// Token: 0x040286E0 RID: 165600
			[Token(Token = "0x40286E0")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x040286E1 RID: 165601
			[Token(Token = "0x40286E1")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_LoadDataMap;
		}

		// Token: 0x02004F97 RID: 20375
		[Token(Token = "0x2004F97")]
		private abstract class ScoreAdapter : EnemyDuelEntryRewardView.FormAdapter
		{
			// Token: 0x0601E4A4 RID: 124068 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x601E4A4")]
			[Address(RVA = "0x180CD40", Offset = "0x180B940", VA = "0x18180CD40", Slot = "9")]
			protected sealed override ListDict<string, string> LoadDataMap()
			{
				return null;
			}

			// Token: 0x0601E4A5 RID: 124069
			[Token(Token = "0x601E4A5")]
			public abstract List<ActivityEnemyDuelExtraScoreData> GetScoreData();

			// Token: 0x0601E4A6 RID: 124070 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601E4A6")]
			[Address(RVA = "0x180CFE0", Offset = "0x180BBE0", VA = "0x18180CFE0")]
			protected ScoreAdapter()
			{
			}

			// Token: 0x040286E2 RID: 165602
			[Token(Token = "0x40286E2")]
			[FieldOffset(Offset = "0x20")]
			private ListDict<string, string> m_scoreMap;

			// Token: 0x040286E3 RID: 165603
			[Token(Token = "0x40286E3")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_LoadDataMap;

			// Token: 0x040286E4 RID: 165604
			[Token(Token = "0x40286E4")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}

		// Token: 0x02004F98 RID: 20376
		[Token(Token = "0x2004F98")]
		private class OperationScoreAdapter : EnemyDuelEntryRewardView.ScoreAdapter
		{
			// Token: 0x0601E4A7 RID: 124071 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601E4A7")]
			[Address(RVA = "0x180C0F0", Offset = "0x180ACF0", VA = "0x18180C0F0")]
			public OperationScoreAdapter(EnemyDuelEntryRewardView closure)
			{
			}

			// Token: 0x0601E4A8 RID: 124072 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x601E4A8")]
			[Address(RVA = "0x180C030", Offset = "0x180AC30", VA = "0x18180C030", Slot = "10")]
			public override List<ActivityEnemyDuelExtraScoreData> GetScoreData()
			{
				return null;
			}

			// Token: 0x040286E5 RID: 165605
			[Token(Token = "0x40286E5")]
			[FieldOffset(Offset = "0x28")]
			private EnemyDuelEntryRewardView m_closure;

			// Token: 0x040286E6 RID: 165606
			[Token(Token = "0x40286E6")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x040286E7 RID: 165607
			[Token(Token = "0x40286E7")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_GetScoreData;
		}

		// Token: 0x02004F99 RID: 20377
		[Token(Token = "0x2004F99")]
		private class StandScoreAdapter : EnemyDuelEntryRewardView.ScoreAdapter
		{
			// Token: 0x0601E4A9 RID: 124073 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601E4A9")]
			[Address(RVA = "0x180D140", Offset = "0x180BD40", VA = "0x18180D140")]
			public StandScoreAdapter(EnemyDuelEntryRewardView closure)
			{
			}

			// Token: 0x0601E4AA RID: 124074 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x601E4AA")]
			[Address(RVA = "0x180D080", Offset = "0x180BC80", VA = "0x18180D080", Slot = "10")]
			public override List<ActivityEnemyDuelExtraScoreData> GetScoreData()
			{
				return null;
			}

			// Token: 0x040286E8 RID: 165608
			[Token(Token = "0x40286E8")]
			[FieldOffset(Offset = "0x28")]
			private EnemyDuelEntryRewardView m_closure;

			// Token: 0x040286E9 RID: 165609
			[Token(Token = "0x40286E9")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x040286EA RID: 165610
			[Token(Token = "0x40286EA")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_GetScoreData;
		}
	}
}

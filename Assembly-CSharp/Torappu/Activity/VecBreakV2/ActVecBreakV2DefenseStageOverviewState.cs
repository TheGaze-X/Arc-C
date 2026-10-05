using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.UI;
using Torappu.UI.CrossAppShare;
using UnityEngine;
using XLua;

namespace Torappu.Activity.VecBreakV2
{
	// Token: 0x02006E06 RID: 28166
	[Token(Token = "0x2006E06")]
	public class ActVecBreakV2DefenseStageOverviewState : PopupFadeState, IHotfixable, IValueMsgReceiver
	{
		// Token: 0x06028184 RID: 164228 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6028184")]
		[Address(RVA = "0x2369400", Offset = "0x2368000", VA = "0x182369400", Slot = "9")]
		public override IStateBean GetCacheBean()
		{
			return null;
		}

		// Token: 0x06028185 RID: 164229 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028185")]
		[Address(RVA = "0x2369460", Offset = "0x2368060", VA = "0x182369460", Slot = "14")]
		protected override void OnEnter()
		{
		}

		// Token: 0x06028186 RID: 164230 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028186")]
		[Address(RVA = "0x2369970", Offset = "0x2368570", VA = "0x182369970", Slot = "15")]
		protected override void OnResume()
		{
		}

		// Token: 0x06028187 RID: 164231 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028187")]
		[Address(RVA = "0x2369C70", Offset = "0x2368870", VA = "0x182369C70")]
		private void _InitIfNot()
		{
		}

		// Token: 0x06028188 RID: 164232 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6028188")]
		[Address(RVA = "0x2369A40", Offset = "0x2368640", VA = "0x182369A40", Slot = "10")]
		public override Dictionary<Type, Action<IStateBean>> RegisterToDataListener()
		{
			return null;
		}

		// Token: 0x06028189 RID: 164233 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028189")]
		[Address(RVA = "0x236A440", Offset = "0x2369040", VA = "0x18236A440")]
		private void _RegiserToStageSelectState(IStateBean stateBean)
		{
		}

		// Token: 0x0602818A RID: 164234 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602818A")]
		[Address(RVA = "0x2369880", Offset = "0x2368480", VA = "0x182369880", Slot = "31")]
		public void OnMessage(int key, ValueBundle msg)
		{
		}

		// Token: 0x0602818B RID: 164235 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602818B")]
		[Address(RVA = "0x236A1B0", Offset = "0x2368DB0", VA = "0x18236A1B0")]
		private void _OpenSquad(string stageId)
		{
		}

		// Token: 0x0602818C RID: 164236 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602818C")]
		[Address(RVA = "0x236A540", Offset = "0x2369140", VA = "0x18236A540")]
		private void _RemoveDefenseSquad(string stageId)
		{
		}

		// Token: 0x0602818D RID: 164237 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602818D")]
		[Address(RVA = "0x236A850", Offset = "0x2369450", VA = "0x18236A850")]
		private void _SendRemoveDefenseSquadService(string stageId)
		{
		}

		// Token: 0x0602818E RID: 164238 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602818E")]
		[Address(RVA = "0x2369E00", Offset = "0x2368A00", VA = "0x182369E00")]
		private void _OpenShare()
		{
		}

		// Token: 0x0602818F RID: 164239 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602818F")]
		[Address(RVA = "0x236AB50", Offset = "0x2369750", VA = "0x18236AB50")]
		public ActVecBreakV2DefenseStageOverviewState()
		{
		}

		// Token: 0x06028191 RID: 164241 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028191")]
		[Address(RVA = "0xE63450", Offset = "0xE62050", VA = "0x180E63450")]
		private void <>xLuaBaseProxy_OnEnter()
		{
		}

		// Token: 0x06028192 RID: 164242 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028192")]
		[Address(RVA = "0xE0F5F0", Offset = "0xE0E1F0", VA = "0x180E0F5F0")]
		private void <>xLuaBaseProxy_OnResume()
		{
		}

		// Token: 0x06028193 RID: 164243 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6028193")]
		[Address(RVA = "0xE63480", Offset = "0xE62080", VA = "0x180E63480")]
		private Dictionary<Type, Action<IStateBean>> <>xLuaBaseProxy_RegisterToDataListener()
		{
			return null;
		}

		// Token: 0x04038E47 RID: 233031
		[Token(Token = "0x4038E47")]
		[NonSerialized]
		public const string SHARE_ITEM_LIST = "share_item_list";

		// Token: 0x04038E48 RID: 233032
		[Token(Token = "0x4038E48")]
		[NonSerialized]
		public const string SHARE_ITEM_ELEMENT = "share_item_element";

		// Token: 0x04038E49 RID: 233033
		[Token(Token = "0x4038E49")]
		[NonSerialized]
		public const int OPEN_SQUAD = 0;

		// Token: 0x04038E4A RID: 233034
		[Token(Token = "0x4038E4A")]
		[NonSerialized]
		public const int REMOVE_DEFENSE_SQUAD = 1;

		// Token: 0x04038E4B RID: 233035
		[Token(Token = "0x4038E4B")]
		[NonSerialized]
		public const int OPEN_SHARE = 2;

		// Token: 0x04038E4C RID: 233036
		[Token(Token = "0x4038E4C")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private ActVecBreakV2DefenseStageOverviewView _view;

		// Token: 0x04038E4D RID: 233037
		[Token(Token = "0x4038E4D")]
		[FieldOffset(Offset = "0x78")]
		private ActVecBreakV2DefenseStageOverviewStateBean m_stateBean;

		// Token: 0x04038E4E RID: 233038
		[Token(Token = "0x4038E4E")]
		[FieldOffset(Offset = "0x80")]
		private bool m_hasInited;

		// Token: 0x04038E4F RID: 233039
		[Token(Token = "0x4038E4F")]
		[FieldOffset(Offset = "0x88")]
		private string m_actId;

		// Token: 0x04038E50 RID: 233040
		[Token(Token = "0x4038E50")]
		[FieldOffset(Offset = "0x90")]
		private ActVecBreakV2DefenseStageOverviewState.ShareModelCollector m_shareCollector;

		// Token: 0x04038E51 RID: 233041
		[Token(Token = "0x4038E51")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetCacheBean;

		// Token: 0x04038E52 RID: 233042
		[Token(Token = "0x4038E52")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnEnter;

		// Token: 0x04038E53 RID: 233043
		[Token(Token = "0x4038E53")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnResume;

		// Token: 0x04038E54 RID: 233044
		[Token(Token = "0x4038E54")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x04038E55 RID: 233045
		[Token(Token = "0x4038E55")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_RegisterToDataListener;

		// Token: 0x04038E56 RID: 233046
		[Token(Token = "0x4038E56")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__RegiserToStageSelectState;

		// Token: 0x04038E57 RID: 233047
		[Token(Token = "0x4038E57")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_OnMessage;

		// Token: 0x04038E58 RID: 233048
		[Token(Token = "0x4038E58")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__OpenSquad;

		// Token: 0x04038E59 RID: 233049
		[Token(Token = "0x4038E59")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__RemoveDefenseSquad;

		// Token: 0x04038E5A RID: 233050
		[Token(Token = "0x4038E5A")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0__SendRemoveDefenseSquadService;

		// Token: 0x04038E5B RID: 233051
		[Token(Token = "0x4038E5B")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0__OpenShare;

		// Token: 0x04038E5C RID: 233052
		[Token(Token = "0x4038E5C")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02006E07 RID: 28167
		[Token(Token = "0x2006E07")]
		private class ShareModelCollector : ISimpleCrossAppShareRemakeModelCollector, ICrossAppShareModelCollector, IHotfixable
		{
			// Token: 0x06028194 RID: 164244 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6028194")]
			[Address(RVA = "0x2374630", Offset = "0x2373230", VA = "0x182374630")]
			public ShareModelCollector(ActVecBreakV2DefenseStageOverviewState closure)
			{
			}

			// Token: 0x06028195 RID: 164245 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6028195")]
			[Address(RVA = "0x2373F70", Offset = "0x2372B70", VA = "0x182373F70", Slot = "5")]
			public void CollectModel()
			{
			}

			// Token: 0x06028196 RID: 164246 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6028196")]
			[Address(RVA = "0x23745D0", Offset = "0x23731D0", VA = "0x1823745D0", Slot = "4")]
			public SimpleCrossAppShareRemakeModel GetSimpleModel()
			{
				return null;
			}

			// Token: 0x04038E5D RID: 233053
			[Token(Token = "0x4038E5D")]
			[FieldOffset(Offset = "0x10")]
			private readonly ActVecBreakV2DefenseStageOverviewState m_closure;

			// Token: 0x04038E5E RID: 233054
			[Token(Token = "0x4038E5E")]
			[FieldOffset(Offset = "0x18")]
			private readonly SimpleCrossAppShareRemakeModel m_model;

			// Token: 0x04038E5F RID: 233055
			[Token(Token = "0x4038E5F")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x04038E60 RID: 233056
			[Token(Token = "0x4038E60")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_CollectModel;

			// Token: 0x04038E61 RID: 233057
			[Token(Token = "0x4038E61")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_GetSimpleModel;
		}
	}
}

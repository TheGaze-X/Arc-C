using System;
using DG.Tweening;
using Il2CppDummyDll;
using Torappu.UI;
using UnityEngine;
using XLua;

namespace Torappu.Activity.VecBreakV2
{
	// Token: 0x02006E09 RID: 28169
	[Token(Token = "0x2006E09")]
	public class ActVecBreakV2DefenseStageSelectState : PopupFadeState, IHotfixable, IValueMsgReceiver
	{
		// Token: 0x06028199 RID: 164249 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6028199")]
		[Address(RVA = "0x236BC70", Offset = "0x236A870", VA = "0x18236BC70", Slot = "9")]
		public override IStateBean GetCacheBean()
		{
			return null;
		}

		// Token: 0x0602819A RID: 164250 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602819A")]
		[Address(RVA = "0x236BCD0", Offset = "0x236A8D0", VA = "0x18236BCD0", Slot = "14")]
		protected override void OnEnter()
		{
		}

		// Token: 0x0602819B RID: 164251 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602819B")]
		[Address(RVA = "0x236C690", Offset = "0x236B290", VA = "0x18236C690", Slot = "15")]
		protected override void OnResume()
		{
		}

		// Token: 0x0602819C RID: 164252 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602819C")]
		[Address(RVA = "0x236C040", Offset = "0x236AC40", VA = "0x18236C040", Slot = "18")]
		protected override void OnExit()
		{
		}

		// Token: 0x0602819D RID: 164253 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602819D")]
		[Address(RVA = "0x236CE90", Offset = "0x236BA90", VA = "0x18236CE90")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0602819E RID: 164254 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602819E")]
		[Address(RVA = "0x236C110", Offset = "0x236AD10", VA = "0x18236C110", Slot = "31")]
		public void OnMessage(int key, ValueBundle msg)
		{
		}

		// Token: 0x0602819F RID: 164255 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602819F")]
		[Address(RVA = "0x236D8F0", Offset = "0x236C4F0", VA = "0x18236D8F0")]
		private void _SelectStage(string stageId)
		{
		}

		// Token: 0x060281A0 RID: 164256 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60281A0")]
		[Address(RVA = "0x236D180", Offset = "0x236BD80", VA = "0x18236D180")]
		private void _OpenMapPreview()
		{
		}

		// Token: 0x060281A1 RID: 164257 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60281A1")]
		[Address(RVA = "0x236D0E0", Offset = "0x236BCE0", VA = "0x18236D0E0")]
		private void _OpenEnemyHandbook()
		{
		}

		// Token: 0x060281A2 RID: 164258 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60281A2")]
		[Address(RVA = "0x236C7D0", Offset = "0x236B3D0", VA = "0x18236C7D0")]
		private void _ActiveBuff()
		{
		}

		// Token: 0x060281A3 RID: 164259 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60281A3")]
		[Address(RVA = "0x236CBA0", Offset = "0x236B7A0", VA = "0x18236CBA0")]
		private void _InactiveBuff(string buffId)
		{
		}

		// Token: 0x060281A4 RID: 164260 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60281A4")]
		[Address(RVA = "0x236D5E0", Offset = "0x236C1E0", VA = "0x18236D5E0")]
		private void _RemoveDefenseSquad(string stageId)
		{
		}

		// Token: 0x060281A5 RID: 164261 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60281A5")]
		[Address(RVA = "0x236DB30", Offset = "0x236C730", VA = "0x18236DB30")]
		private void _SendRemoveDefenseSquadService(string stageId)
		{
		}

		// Token: 0x060281A6 RID: 164262 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60281A6")]
		[Address(RVA = "0x236D320", Offset = "0x236BF20", VA = "0x18236D320")]
		private void _OpenSquad()
		{
		}

		// Token: 0x060281A7 RID: 164263 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60281A7")]
		[Address(RVA = "0x236CF30", Offset = "0x236BB30", VA = "0x18236CF30")]
		private void _OpenDefenseStageDetailState()
		{
		}

		// Token: 0x060281A8 RID: 164264 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60281A8")]
		[Address(RVA = "0x236CAC0", Offset = "0x236B6C0", VA = "0x18236CAC0")]
		private void _BuffExceedNotify()
		{
		}

		// Token: 0x060281A9 RID: 164265 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60281A9")]
		[Address(RVA = "0x236DE30", Offset = "0x236CA30", VA = "0x18236DE30")]
		public ActVecBreakV2DefenseStageSelectState()
		{
		}

		// Token: 0x060281AD RID: 164269 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60281AD")]
		[Address(RVA = "0xE63450", Offset = "0xE62050", VA = "0x180E63450")]
		private void <>xLuaBaseProxy_OnEnter()
		{
		}

		// Token: 0x060281AE RID: 164270 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60281AE")]
		[Address(RVA = "0xE0F5F0", Offset = "0xE0E1F0", VA = "0x180E0F5F0")]
		private void <>xLuaBaseProxy_OnResume()
		{
		}

		// Token: 0x060281AF RID: 164271 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60281AF")]
		[Address(RVA = "0xE63460", Offset = "0xE62060", VA = "0x180E63460")]
		private void <>xLuaBaseProxy_OnExit()
		{
		}

		// Token: 0x04038E64 RID: 233060
		[Token(Token = "0x4038E64")]
		private const string GUIDE_BOOK_SUB_SIGNAL = "defense";

		// Token: 0x04038E65 RID: 233061
		[Token(Token = "0x4038E65")]
		[NonSerialized]
		public const int SELECT_STAGE = 0;

		// Token: 0x04038E66 RID: 233062
		[Token(Token = "0x4038E66")]
		[NonSerialized]
		public const int OPEN_MAP_PREVIEW = 1;

		// Token: 0x04038E67 RID: 233063
		[Token(Token = "0x4038E67")]
		[NonSerialized]
		public const int OPEN_ENEMY_HANDBOOK = 2;

		// Token: 0x04038E68 RID: 233064
		[Token(Token = "0x4038E68")]
		[NonSerialized]
		public const int OPEN_SQUAD = 3;

		// Token: 0x04038E69 RID: 233065
		[Token(Token = "0x4038E69")]
		[NonSerialized]
		public const int ACTIVE_BUFF = 4;

		// Token: 0x04038E6A RID: 233066
		[Token(Token = "0x4038E6A")]
		[NonSerialized]
		public const int INACTIVE_BUFF = 5;

		// Token: 0x04038E6B RID: 233067
		[Token(Token = "0x4038E6B")]
		[NonSerialized]
		public const int REMOVE_DEFENSE_SQUAD = 6;

		// Token: 0x04038E6C RID: 233068
		[Token(Token = "0x4038E6C")]
		[NonSerialized]
		public const int OPEN_DEFENSE_DETAIL_STATE = 7;

		// Token: 0x04038E6D RID: 233069
		[Token(Token = "0x4038E6D")]
		[NonSerialized]
		public const int BUFF_EXCEED_NOTIFY = 8;

		// Token: 0x04038E6E RID: 233070
		[Token(Token = "0x4038E6E")]
		[FieldOffset(Offset = "0x70")]
		private ActVecBreakV2DefenseStageSelectStateBean m_stateBean;

		// Token: 0x04038E6F RID: 233071
		[Token(Token = "0x4038E6F")]
		[FieldOffset(Offset = "0x78")]
		private bool m_hasInited;

		// Token: 0x04038E70 RID: 233072
		[Token(Token = "0x4038E70")]
		[FieldOffset(Offset = "0x80")]
		private Tween m_enterAnimTween;

		// Token: 0x04038E71 RID: 233073
		[Token(Token = "0x4038E71")]
		[FieldOffset(Offset = "0x88")]
		private string m_actId;

		// Token: 0x04038E72 RID: 233074
		[Token(Token = "0x4038E72")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		private ActVecBreakV2DefenseStageSelectView _view;

		// Token: 0x04038E73 RID: 233075
		[Token(Token = "0x4038E73")]
		[FieldOffset(Offset = "0x98")]
		[SerializeField]
		private UIAnimationLocation _enterAnim;

		// Token: 0x04038E74 RID: 233076
		[Token(Token = "0x4038E74")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetCacheBean;

		// Token: 0x04038E75 RID: 233077
		[Token(Token = "0x4038E75")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnEnter;

		// Token: 0x04038E76 RID: 233078
		[Token(Token = "0x4038E76")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnResume;

		// Token: 0x04038E77 RID: 233079
		[Token(Token = "0x4038E77")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnExit;

		// Token: 0x04038E78 RID: 233080
		[Token(Token = "0x4038E78")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x04038E79 RID: 233081
		[Token(Token = "0x4038E79")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_OnMessage;

		// Token: 0x04038E7A RID: 233082
		[Token(Token = "0x4038E7A")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__SelectStage;

		// Token: 0x04038E7B RID: 233083
		[Token(Token = "0x4038E7B")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__OpenMapPreview;

		// Token: 0x04038E7C RID: 233084
		[Token(Token = "0x4038E7C")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__OpenEnemyHandbook;

		// Token: 0x04038E7D RID: 233085
		[Token(Token = "0x4038E7D")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0__ActiveBuff;

		// Token: 0x04038E7E RID: 233086
		[Token(Token = "0x4038E7E")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0__InactiveBuff;

		// Token: 0x04038E7F RID: 233087
		[Token(Token = "0x4038E7F")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0__RemoveDefenseSquad;

		// Token: 0x04038E80 RID: 233088
		[Token(Token = "0x4038E80")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0__SendRemoveDefenseSquadService;

		// Token: 0x04038E81 RID: 233089
		[Token(Token = "0x4038E81")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0__OpenSquad;

		// Token: 0x04038E82 RID: 233090
		[Token(Token = "0x4038E82")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0__OpenDefenseStageDetailState;

		// Token: 0x04038E83 RID: 233091
		[Token(Token = "0x4038E83")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0__BuffExceedNotify;

		// Token: 0x04038E84 RID: 233092
		[Token(Token = "0x4038E84")]
		[FieldOffset(Offset = "0x80")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}

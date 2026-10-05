using System;
using System.Collections;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.RoguelikeTopic
{
	// Token: 0x020044E7 RID: 17639
	[Token(Token = "0x20044E7")]
	public class RoguelikeTopicMonthTaskState : PopupFloatState
	{
		// Token: 0x0601AEE1 RID: 110305 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601AEE1")]
		[Address(RVA = "0x142A9A0", Offset = "0x14295A0", VA = "0x18142A9A0", Slot = "9")]
		public override IStateBean GetCacheBean()
		{
			return null;
		}

		// Token: 0x0601AEE2 RID: 110306 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601AEE2")]
		[Address(RVA = "0x142AA00", Offset = "0x1429600", VA = "0x18142AA00", Slot = "14")]
		protected override void OnEnter()
		{
		}

		// Token: 0x0601AEE3 RID: 110307 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601AEE3")]
		[Address(RVA = "0x142AD60", Offset = "0x1429960", VA = "0x18142AD60")]
		private void _InitIfNot(RoguelikeTopicPage page)
		{
		}

		// Token: 0x0601AEE4 RID: 110308 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601AEE4")]
		[Address(RVA = "0x142B2A0", Offset = "0x1429EA0", VA = "0x18142B2A0")]
		private void _UpdateTaskModel()
		{
		}

		// Token: 0x0601AEE5 RID: 110309 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601AEE5")]
		[Address(RVA = "0x142B1F0", Offset = "0x1429DF0", VA = "0x18142B1F0")]
		private IEnumerator _UpdateTaskModelAfterDelay()
		{
			return null;
		}

		// Token: 0x0601AEE6 RID: 110310 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601AEE6")]
		[Address(RVA = "0x142AF40", Offset = "0x1429B40", VA = "0x18142AF40")]
		private void _SendRefreshMissionRequest(string topicId, int index, Action onComplete)
		{
		}

		// Token: 0x0601AEE7 RID: 110311 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601AEE7")]
		[Address(RVA = "0x142ADD0", Offset = "0x14299D0", VA = "0x18142ADD0")]
		private void _OnTaskRefresh(RoguelikeTopicMonthTaskModel taskModel)
		{
		}

		// Token: 0x0601AEE8 RID: 110312 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601AEE8")]
		[Address(RVA = "0x142B370", Offset = "0x1429F70", VA = "0x18142B370")]
		public RoguelikeTopicMonthTaskState()
		{
		}

		// Token: 0x0601AEE9 RID: 110313 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601AEE9")]
		[Address(RVA = "0xE63450", Offset = "0xE62050", VA = "0x180E63450")]
		private void <>xLuaBaseProxy_OnEnter()
		{
		}

		// Token: 0x040228AF RID: 141487
		[Token(Token = "0x40228AF")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private RoguelikeTopicMonthTaskView _taskView;

		// Token: 0x040228B0 RID: 141488
		[Token(Token = "0x40228B0")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private float _propRefreshDelay;

		// Token: 0x040228B1 RID: 141489
		[Token(Token = "0x40228B1")]
		[FieldOffset(Offset = "0x7C")]
		private bool m_hasInited;

		// Token: 0x040228B2 RID: 141490
		[Token(Token = "0x40228B2")]
		[FieldOffset(Offset = "0x80")]
		private string m_topicId;

		// Token: 0x040228B3 RID: 141491
		[Token(Token = "0x40228B3")]
		[FieldOffset(Offset = "0x88")]
		private RoguelikeTopicMonthTaskStateBean m_stateBean;

		// Token: 0x040228B4 RID: 141492
		[Token(Token = "0x40228B4")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetCacheBean;

		// Token: 0x040228B5 RID: 141493
		[Token(Token = "0x40228B5")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnEnter;

		// Token: 0x040228B6 RID: 141494
		[Token(Token = "0x40228B6")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x040228B7 RID: 141495
		[Token(Token = "0x40228B7")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__UpdateTaskModel;

		// Token: 0x040228B8 RID: 141496
		[Token(Token = "0x40228B8")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__UpdateTaskModelAfterDelay;

		// Token: 0x040228B9 RID: 141497
		[Token(Token = "0x40228B9")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__SendRefreshMissionRequest;

		// Token: 0x040228BA RID: 141498
		[Token(Token = "0x40228BA")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__OnTaskRefresh;

		// Token: 0x040228BB RID: 141499
		[Token(Token = "0x40228BB")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}

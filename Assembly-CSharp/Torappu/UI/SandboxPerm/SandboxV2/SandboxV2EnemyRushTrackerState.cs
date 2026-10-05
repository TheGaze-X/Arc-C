using System;
using DG.Tweening;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.SandboxPerm.SandboxV2
{
	// Token: 0x0200421A RID: 16922
	[Token(Token = "0x200421A")]
	public class SandboxV2EnemyRushTrackerState : SandboxV2TrackerState, IValueMsgReceiver
	{
		// Token: 0x0601A1A4 RID: 106916 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A1A4")]
		[Address(RVA = "0x1303B70", Offset = "0x1302770", VA = "0x181303B70", Slot = "14")]
		protected override void OnEnter()
		{
		}

		// Token: 0x0601A1A5 RID: 106917 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601A1A5")]
		[Address(RVA = "0x1303B10", Offset = "0x1302710", VA = "0x181303B10", Slot = "9")]
		public override IStateBean GetCacheBean()
		{
			return null;
		}

		// Token: 0x0601A1A6 RID: 106918 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A1A6")]
		[Address(RVA = "0x1304010", Offset = "0x1302C10", VA = "0x181304010")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0601A1A7 RID: 106919 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A1A7")]
		[Address(RVA = "0x1304380", Offset = "0x1302F80", VA = "0x181304380")]
		private void _PlayEnterAnim()
		{
		}

		// Token: 0x0601A1A8 RID: 106920 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A1A8")]
		[Address(RVA = "0x1304480", Offset = "0x1303080", VA = "0x181304480")]
		private void _UpdateData()
		{
		}

		// Token: 0x0601A1A9 RID: 106921 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A1A9")]
		[Address(RVA = "0x1303F30", Offset = "0x1302B30", VA = "0x181303F30", Slot = "33")]
		public void OnMessage(int key, ValueBundle msg)
		{
		}

		// Token: 0x0601A1AA RID: 106922 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A1AA")]
		[Address(RVA = "0x1304100", Offset = "0x1302D00", VA = "0x181304100")]
		private void _OnItemSelect(string selectedId)
		{
		}

		// Token: 0x0601A1AB RID: 106923 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A1AB")]
		[Address(RVA = "0x1304640", Offset = "0x1303240", VA = "0x181304640")]
		public SandboxV2EnemyRushTrackerState()
		{
		}

		// Token: 0x0601A1AC RID: 106924 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A1AC")]
		[Address(RVA = "0x1304000", Offset = "0x1302C00", VA = "0x181304000")]
		private void <>xLuaBaseProxy_OnEnter()
		{
		}

		// Token: 0x04020ED1 RID: 134865
		[Token(Token = "0x4020ED1")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private UIAnimationLocation _enterAnim;

		// Token: 0x04020ED2 RID: 134866
		[Token(Token = "0x4020ED2")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		private SandboxV2EnemyRushTrackerView _view;

		// Token: 0x04020ED3 RID: 134867
		[Token(Token = "0x4020ED3")]
		[FieldOffset(Offset = "0x98")]
		private bool m_isInited;

		// Token: 0x04020ED4 RID: 134868
		[Token(Token = "0x4020ED4")]
		[FieldOffset(Offset = "0xA0")]
		private Tween m_enterTween;

		// Token: 0x04020ED5 RID: 134869
		[Token(Token = "0x4020ED5")]
		[FieldOffset(Offset = "0xA8")]
		private SandboxV2EnemyRushTrackerProperty m_property;

		// Token: 0x04020ED6 RID: 134870
		[Token(Token = "0x4020ED6")]
		[NonSerialized]
		public const int ON_ITEM_SELECT = 0;

		// Token: 0x04020ED7 RID: 134871
		[Token(Token = "0x4020ED7")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnEnter;

		// Token: 0x04020ED8 RID: 134872
		[Token(Token = "0x4020ED8")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_GetCacheBean;

		// Token: 0x04020ED9 RID: 134873
		[Token(Token = "0x4020ED9")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x04020EDA RID: 134874
		[Token(Token = "0x4020EDA")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__PlayEnterAnim;

		// Token: 0x04020EDB RID: 134875
		[Token(Token = "0x4020EDB")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__UpdateData;

		// Token: 0x04020EDC RID: 134876
		[Token(Token = "0x4020EDC")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_OnMessage;

		// Token: 0x04020EDD RID: 134877
		[Token(Token = "0x4020EDD")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__OnItemSelect;

		// Token: 0x04020EDE RID: 134878
		[Token(Token = "0x4020EDE")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}

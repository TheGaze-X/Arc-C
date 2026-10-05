using System;
using Il2CppDummyDll;
using Torappu.UI;
using UnityEngine;
using XLua;

namespace Torappu.Activity.Act42D0
{
	// Token: 0x020073AA RID: 29610
	[Token(Token = "0x20073AA")]
	public class Act42D0RewardState : PopupFloatState, IValueMsgReceiver
	{
		// Token: 0x06029D96 RID: 171414 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6029D96")]
		[Address(RVA = "0x2574370", Offset = "0x2572F70", VA = "0x182574370", Slot = "9")]
		public override IStateBean GetCacheBean()
		{
			return null;
		}

		// Token: 0x06029D97 RID: 171415 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029D97")]
		[Address(RVA = "0x25743D0", Offset = "0x2572FD0", VA = "0x1825743D0", Slot = "14")]
		protected override void OnEnter()
		{
		}

		// Token: 0x06029D98 RID: 171416 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029D98")]
		[Address(RVA = "0x25748C0", Offset = "0x25734C0", VA = "0x1825748C0", Slot = "15")]
		protected override void OnResume()
		{
		}

		// Token: 0x06029D99 RID: 171417 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029D99")]
		[Address(RVA = "0x25749A0", Offset = "0x25735A0", VA = "0x1825749A0")]
		private void _InitIfNot()
		{
		}

		// Token: 0x06029D9A RID: 171418 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029D9A")]
		[Address(RVA = "0x2574700", Offset = "0x2573300", VA = "0x182574700", Slot = "32")]
		public void OnMessage(int key, ValueBundle msg)
		{
		}

		// Token: 0x06029D9B RID: 171419 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029D9B")]
		[Address(RVA = "0x2574B20", Offset = "0x2573720", VA = "0x182574B20")]
		private void _OnSelectArea(string areaId)
		{
		}

		// Token: 0x06029D9C RID: 171420 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029D9C")]
		[Address(RVA = "0x2574C40", Offset = "0x2573840", VA = "0x182574C40")]
		public Act42D0RewardState()
		{
		}

		// Token: 0x06029D9D RID: 171421 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029D9D")]
		[Address(RVA = "0xE63450", Offset = "0xE62050", VA = "0x180E63450")]
		private void <>xLuaBaseProxy_OnEnter()
		{
		}

		// Token: 0x06029D9E RID: 171422 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029D9E")]
		[Address(RVA = "0xE0F5F0", Offset = "0xE0E1F0", VA = "0x180E0F5F0")]
		private void <>xLuaBaseProxy_OnResume()
		{
		}

		// Token: 0x0403BF86 RID: 245638
		[Token(Token = "0x403BF86")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private Act42D0RewardView _rewardView;

		// Token: 0x0403BF87 RID: 245639
		[Token(Token = "0x403BF87")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private RectTransform _backRt;

		// Token: 0x0403BF88 RID: 245640
		[Token(Token = "0x403BF88")]
		[FieldOffset(Offset = "0x80")]
		private bool m_isInited;

		// Token: 0x0403BF89 RID: 245641
		[Token(Token = "0x403BF89")]
		[FieldOffset(Offset = "0x88")]
		private string m_actId;

		// Token: 0x0403BF8A RID: 245642
		[Token(Token = "0x403BF8A")]
		[FieldOffset(Offset = "0x90")]
		private Act42D0RewardProperty m_property;

		// Token: 0x0403BF8B RID: 245643
		[Token(Token = "0x403BF8B")]
		[NonSerialized]
		public const int MSG_SELECT_AREA = 0;

		// Token: 0x0403BF8C RID: 245644
		[Token(Token = "0x403BF8C")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetCacheBean;

		// Token: 0x0403BF8D RID: 245645
		[Token(Token = "0x403BF8D")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnEnter;

		// Token: 0x0403BF8E RID: 245646
		[Token(Token = "0x403BF8E")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnResume;

		// Token: 0x0403BF8F RID: 245647
		[Token(Token = "0x403BF8F")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0403BF90 RID: 245648
		[Token(Token = "0x403BF90")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_OnMessage;

		// Token: 0x0403BF91 RID: 245649
		[Token(Token = "0x403BF91")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__OnSelectArea;

		// Token: 0x0403BF92 RID: 245650
		[Token(Token = "0x403BF92")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}

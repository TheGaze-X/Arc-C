using System;
using Il2CppDummyDll;
using Torappu.UI;
using UnityEngine;
using XLua;

namespace Torappu.Activity.ActMultiV3
{
	// Token: 0x02006FC3 RID: 28611
	[Token(Token = "0x2006FC3")]
	public class ActMultiV3SquadEffectSelectState : PopupFadeState, IValueMsgReceiver
	{
		// Token: 0x06028A15 RID: 166421 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6028A15")]
		[Address(RVA = "0x23F2C40", Offset = "0x23F1840", VA = "0x1823F2C40", Slot = "9")]
		public override IStateBean GetCacheBean()
		{
			return null;
		}

		// Token: 0x06028A16 RID: 166422 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028A16")]
		[Address(RVA = "0x23F2CA0", Offset = "0x23F18A0", VA = "0x1823F2CA0", Slot = "14")]
		protected override void OnEnter()
		{
		}

		// Token: 0x06028A17 RID: 166423 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028A17")]
		[Address(RVA = "0x23F30B0", Offset = "0x23F1CB0", VA = "0x1823F30B0", Slot = "15")]
		protected override void OnResume()
		{
		}

		// Token: 0x06028A18 RID: 166424 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028A18")]
		[Address(RVA = "0x23F3420", Offset = "0x23F2020", VA = "0x1823F3420")]
		private void _InitIfNot()
		{
		}

		// Token: 0x06028A19 RID: 166425 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028A19")]
		[Address(RVA = "0x23F3120", Offset = "0x23F1D20", VA = "0x1823F3120")]
		private void _EventOnBtnBack()
		{
		}

		// Token: 0x06028A1A RID: 166426 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028A1A")]
		[Address(RVA = "0x23F3000", Offset = "0x23F1C00", VA = "0x1823F3000", Slot = "31")]
		public void OnMessage(int key, ValueBundle msg)
		{
		}

		// Token: 0x06028A1B RID: 166427 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028A1B")]
		[Address(RVA = "0x23F31A0", Offset = "0x23F1DA0", VA = "0x1823F31A0")]
		private void _EventOnSelectEffect(string effectId)
		{
		}

		// Token: 0x06028A1C RID: 166428 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028A1C")]
		[Address(RVA = "0x23F2AC0", Offset = "0x23F16C0", VA = "0x1823F2AC0")]
		public void EventOnBtnConfirm()
		{
		}

		// Token: 0x06028A1D RID: 166429 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028A1D")]
		[Address(RVA = "0x23F3930", Offset = "0x23F2530", VA = "0x1823F3930")]
		private void _TryUnlockEffect(ActMultiV3SquadEffectSelectModel viewModel, ActMultiV3SquadEffectModel currEffectModel)
		{
		}

		// Token: 0x06028A1E RID: 166430 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028A1E")]
		[Address(RVA = "0x23F34F0", Offset = "0x23F20F0", VA = "0x1823F34F0")]
		private void _TryEquipEffect(ActMultiV3SquadEffectSelectModel viewModel, ActMultiV3SquadEffectModel currEffectModel)
		{
		}

		// Token: 0x06028A1F RID: 166431 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028A1F")]
		[Address(RVA = "0x23F3CC0", Offset = "0x23F28C0", VA = "0x1823F3CC0")]
		public ActMultiV3SquadEffectSelectState()
		{
		}

		// Token: 0x06028A20 RID: 166432 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028A20")]
		[Address(RVA = "0xE63450", Offset = "0xE62050", VA = "0x180E63450")]
		private void <>xLuaBaseProxy_OnEnter()
		{
		}

		// Token: 0x06028A21 RID: 166433 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028A21")]
		[Address(RVA = "0xE0F5F0", Offset = "0xE0E1F0", VA = "0x180E0F5F0")]
		private void <>xLuaBaseProxy_OnResume()
		{
		}

		// Token: 0x04039E2F RID: 237103
		[Token(Token = "0x4039E2F")]
		[NonSerialized]
		public const int MSG_SELECT_EFFECT = 1;

		// Token: 0x04039E30 RID: 237104
		[Token(Token = "0x4039E30")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private ActMultiV3SquadEffectSelectView _view;

		// Token: 0x04039E31 RID: 237105
		[Token(Token = "0x4039E31")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private RectTransform _topMenuContainer;

		// Token: 0x04039E32 RID: 237106
		[Token(Token = "0x4039E32")]
		[FieldOffset(Offset = "0x80")]
		private bool m_hasInited;

		// Token: 0x04039E33 RID: 237107
		[Token(Token = "0x4039E33")]
		[FieldOffset(Offset = "0x88")]
		private ActMultiV3SquadEffectSelectStateBean m_stateBean;

		// Token: 0x04039E34 RID: 237108
		[Token(Token = "0x4039E34")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetCacheBean;

		// Token: 0x04039E35 RID: 237109
		[Token(Token = "0x4039E35")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnEnter;

		// Token: 0x04039E36 RID: 237110
		[Token(Token = "0x4039E36")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnResume;

		// Token: 0x04039E37 RID: 237111
		[Token(Token = "0x4039E37")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x04039E38 RID: 237112
		[Token(Token = "0x4039E38")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__EventOnBtnBack;

		// Token: 0x04039E39 RID: 237113
		[Token(Token = "0x4039E39")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_OnMessage;

		// Token: 0x04039E3A RID: 237114
		[Token(Token = "0x4039E3A")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__EventOnSelectEffect;

		// Token: 0x04039E3B RID: 237115
		[Token(Token = "0x4039E3B")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_EventOnBtnConfirm;

		// Token: 0x04039E3C RID: 237116
		[Token(Token = "0x4039E3C")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__TryUnlockEffect;

		// Token: 0x04039E3D RID: 237117
		[Token(Token = "0x4039E3D")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0__TryEquipEffect;

		// Token: 0x04039E3E RID: 237118
		[Token(Token = "0x4039E3E")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}

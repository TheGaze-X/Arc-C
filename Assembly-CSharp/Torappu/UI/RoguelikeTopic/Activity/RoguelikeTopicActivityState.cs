using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.RoguelikeTopic.Activity
{
	// Token: 0x02004699 RID: 18073
	[Token(Token = "0x2004699")]
	public class RoguelikeTopicActivityState : PopupFloatState, ICompDialogCallBack
	{
		// Token: 0x0601B6C9 RID: 112329 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601B6C9")]
		[Address(RVA = "0x14B1B20", Offset = "0x14B0720", VA = "0x1814B1B20", Slot = "9")]
		public override IStateBean GetCacheBean()
		{
			return null;
		}

		// Token: 0x0601B6CA RID: 112330 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B6CA")]
		[Address(RVA = "0x14B1C30", Offset = "0x14B0830", VA = "0x1814B1C30", Slot = "14")]
		protected override void OnEnter()
		{
		}

		// Token: 0x0601B6CB RID: 112331 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B6CB")]
		[Address(RVA = "0x14B2070", Offset = "0x14B0C70", VA = "0x1814B2070", Slot = "15")]
		protected override void OnResume()
		{
		}

		// Token: 0x0601B6CC RID: 112332 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B6CC")]
		[Address(RVA = "0x14B2130", Offset = "0x14B0D30", VA = "0x1814B2130")]
		private void _OnClickRemoveState()
		{
		}

		// Token: 0x0601B6CD RID: 112333 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B6CD")]
		[Address(RVA = "0x14B1B80", Offset = "0x14B0780", VA = "0x1814B1B80", Slot = "32")]
		public void HandleCallBack(int instId, ValueBundle output)
		{
		}

		// Token: 0x0601B6CE RID: 112334 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B6CE")]
		[Address(RVA = "0x14B21E0", Offset = "0x14B0DE0", VA = "0x1814B21E0")]
		public RoguelikeTopicActivityState()
		{
		}

		// Token: 0x0601B6CF RID: 112335 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B6CF")]
		[Address(RVA = "0xE63450", Offset = "0xE62050", VA = "0x180E63450")]
		private void <>xLuaBaseProxy_OnEnter()
		{
		}

		// Token: 0x0601B6D0 RID: 112336 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B6D0")]
		[Address(RVA = "0xE0F5F0", Offset = "0xE0E1F0", VA = "0x180E0F5F0")]
		private void <>xLuaBaseProxy_OnResume()
		{
		}

		// Token: 0x04023798 RID: 145304
		[Token(Token = "0x4023798")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private RectTransform _actPanelContent;

		// Token: 0x04023799 RID: 145305
		[Token(Token = "0x4023799")]
		[FieldOffset(Offset = "0x78")]
		private RoguelikeTopicActivityStateBean m_stateBean;

		// Token: 0x0402379A RID: 145306
		[Token(Token = "0x402379A")]
		[FieldOffset(Offset = "0x80")]
		private RoguelikeTopicActivityPanel m_actPanel;

		// Token: 0x0402379B RID: 145307
		[Token(Token = "0x402379B")]
		[FieldOffset(Offset = "0x88")]
		private int m_dialogInst;

		// Token: 0x0402379C RID: 145308
		[Token(Token = "0x402379C")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetCacheBean;

		// Token: 0x0402379D RID: 145309
		[Token(Token = "0x402379D")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnEnter;

		// Token: 0x0402379E RID: 145310
		[Token(Token = "0x402379E")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnResume;

		// Token: 0x0402379F RID: 145311
		[Token(Token = "0x402379F")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__OnClickRemoveState;

		// Token: 0x040237A0 RID: 145312
		[Token(Token = "0x40237A0")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_HandleCallBack;

		// Token: 0x040237A1 RID: 145313
		[Token(Token = "0x40237A1")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}

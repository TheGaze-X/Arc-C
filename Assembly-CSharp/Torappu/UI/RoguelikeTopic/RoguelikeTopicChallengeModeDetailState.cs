using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.RoguelikeTopic
{
	// Token: 0x020044AE RID: 17582
	[Token(Token = "0x20044AE")]
	public class RoguelikeTopicChallengeModeDetailState : PopupFloatState
	{
		// Token: 0x0601ADBB RID: 110011 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601ADBB")]
		[Address(RVA = "0x1404080", Offset = "0x1402C80", VA = "0x181404080", Slot = "9")]
		public override IStateBean GetCacheBean()
		{
			return null;
		}

		// Token: 0x0601ADBC RID: 110012 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601ADBC")]
		[Address(RVA = "0x1404640", Offset = "0x1403240", VA = "0x181404640")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0601ADBD RID: 110013 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601ADBD")]
		[Address(RVA = "0x1404160", Offset = "0x1402D60", VA = "0x181404160", Slot = "14")]
		protected override void OnEnter()
		{
		}

		// Token: 0x0601ADBE RID: 110014 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601ADBE")]
		[Address(RVA = "0x14040E0", Offset = "0x1402CE0", VA = "0x1814040E0")]
		public void OnBackClick()
		{
		}

		// Token: 0x0601ADBF RID: 110015 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601ADBF")]
		[Address(RVA = "0x1404760", Offset = "0x1403360", VA = "0x181404760")]
		public RoguelikeTopicChallengeModeDetailState()
		{
		}

		// Token: 0x0601ADC0 RID: 110016 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601ADC0")]
		[Address(RVA = "0xE63450", Offset = "0xE62050", VA = "0x180E63450")]
		private void <>xLuaBaseProxy_OnEnter()
		{
		}

		// Token: 0x04022673 RID: 140915
		[Token(Token = "0x4022673")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private RectTransform _viewHolder;

		// Token: 0x04022674 RID: 140916
		[Token(Token = "0x4022674")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private RectTransform _backBtn;

		// Token: 0x04022675 RID: 140917
		[Token(Token = "0x4022675")]
		[FieldOffset(Offset = "0x80")]
		private string m_cachedTopicId;

		// Token: 0x04022676 RID: 140918
		[Token(Token = "0x4022676")]
		[FieldOffset(Offset = "0x88")]
		private RoguelikeTopicChallengeModeDetailViewBase m_detailView;

		// Token: 0x04022677 RID: 140919
		[Token(Token = "0x4022677")]
		[FieldOffset(Offset = "0x90")]
		private bool m_isInited;

		// Token: 0x04022678 RID: 140920
		[Token(Token = "0x4022678")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetCacheBean;

		// Token: 0x04022679 RID: 140921
		[Token(Token = "0x4022679")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0402267A RID: 140922
		[Token(Token = "0x402267A")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnEnter;

		// Token: 0x0402267B RID: 140923
		[Token(Token = "0x402267B")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnBackClick;

		// Token: 0x0402267C RID: 140924
		[Token(Token = "0x402267C")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}

using System;
using System.Collections;
using Il2CppDummyDll;
using Torappu.AVG;
using UnityEngine;
using XLua;

namespace Torappu.UI.UniEquip
{
	// Token: 0x02003C1A RID: 15386
	[Token(Token = "0x2003C1A")]
	public class UniEquipUnlockState : PopupFadeState
	{
		// Token: 0x0601811C RID: 98588 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601811C")]
		[Address(RVA = "0x108A3A0", Offset = "0x1088FA0", VA = "0x18108A3A0", Slot = "9")]
		public override IStateBean GetCacheBean()
		{
			return null;
		}

		// Token: 0x0601811D RID: 98589 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601811D")]
		[Address(RVA = "0x108A400", Offset = "0x1089000", VA = "0x18108A400", Slot = "14")]
		protected override void OnEnter()
		{
		}

		// Token: 0x0601811E RID: 98590 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601811E")]
		[Address(RVA = "0x108A5A0", Offset = "0x10891A0", VA = "0x18108A5A0", Slot = "23")]
		protected override IEnumerator ShowCoroutine(UIPopupState.TransactionContext context)
		{
			return null;
		}

		// Token: 0x0601811F RID: 98591 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601811F")]
		[Address(RVA = "0x108A510", Offset = "0x1089110", VA = "0x18108A510", Slot = "15")]
		protected override void OnResume()
		{
		}

		// Token: 0x06018120 RID: 98592 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018120")]
		[Address(RVA = "0x1089F80", Offset = "0x1088B80", VA = "0x181089F80")]
		public void EventOnConfirmClick()
		{
		}

		// Token: 0x06018121 RID: 98593 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018121")]
		[Address(RVA = "0x108A7C0", Offset = "0x10893C0", VA = "0x18108A7C0")]
		private void _UniqEquipGuideEndCallback(Story story)
		{
		}

		// Token: 0x06018122 RID: 98594 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018122")]
		[Address(RVA = "0x1089E00", Offset = "0x1088A00", VA = "0x181089E00")]
		public void EventOnCancelClick()
		{
		}

		// Token: 0x06018123 RID: 98595 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018123")]
		[Address(RVA = "0x1089E80", Offset = "0x1088A80", VA = "0x181089E80")]
		public void EventOnClickPreview()
		{
		}

		// Token: 0x06018124 RID: 98596 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018124")]
		[Address(RVA = "0x108A2B0", Offset = "0x1088EB0", VA = "0x18108A2B0")]
		public void EventOnRouteToTarget()
		{
		}

		// Token: 0x06018125 RID: 98597 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018125")]
		[Address(RVA = "0x108A6F0", Offset = "0x10892F0", VA = "0x18108A6F0")]
		private void _InitIfNot()
		{
		}

		// Token: 0x06018126 RID: 98598 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018126")]
		[Address(RVA = "0x108A890", Offset = "0x1089490", VA = "0x18108A890")]
		public UniEquipUnlockState()
		{
		}

		// Token: 0x06018128 RID: 98600 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018128")]
		[Address(RVA = "0xE63450", Offset = "0xE62050", VA = "0x180E63450")]
		private void <>xLuaBaseProxy_OnEnter()
		{
		}

		// Token: 0x06018129 RID: 98601 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6018129")]
		[Address(RVA = "0x1089D20", Offset = "0x1088920", VA = "0x181089D20")]
		private IEnumerator <>xLuaBaseProxy_ShowCoroutine(UIPopupState.TransactionContext P0)
		{
			return null;
		}

		// Token: 0x0601812A RID: 98602 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601812A")]
		[Address(RVA = "0xE0F5F0", Offset = "0xE0E1F0", VA = "0x180E0F5F0")]
		private void <>xLuaBaseProxy_OnResume()
		{
		}

		// Token: 0x0401D322 RID: 119586
		[Token(Token = "0x401D322")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private UniEquipUnlockView _unlockView;

		// Token: 0x0401D323 RID: 119587
		[Token(Token = "0x401D323")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private UniEquipUnlockPreviewView _previewView;

		// Token: 0x0401D324 RID: 119588
		[Token(Token = "0x401D324")]
		[FieldOffset(Offset = "0x80")]
		private bool m_isInited;

		// Token: 0x0401D325 RID: 119589
		[Token(Token = "0x401D325")]
		[FieldOffset(Offset = "0x88")]
		private UniEquipUnlockStateBean m_stateBean;

		// Token: 0x0401D326 RID: 119590
		[Token(Token = "0x401D326")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetCacheBean;

		// Token: 0x0401D327 RID: 119591
		[Token(Token = "0x401D327")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnEnter;

		// Token: 0x0401D328 RID: 119592
		[Token(Token = "0x401D328")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_ShowCoroutine;

		// Token: 0x0401D329 RID: 119593
		[Token(Token = "0x401D329")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnResume;

		// Token: 0x0401D32A RID: 119594
		[Token(Token = "0x401D32A")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_EventOnConfirmClick;

		// Token: 0x0401D32B RID: 119595
		[Token(Token = "0x401D32B")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__UniqEquipGuideEndCallback;

		// Token: 0x0401D32C RID: 119596
		[Token(Token = "0x401D32C")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_EventOnCancelClick;

		// Token: 0x0401D32D RID: 119597
		[Token(Token = "0x401D32D")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_EventOnClickPreview;

		// Token: 0x0401D32E RID: 119598
		[Token(Token = "0x401D32E")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_EventOnRouteToTarget;

		// Token: 0x0401D32F RID: 119599
		[Token(Token = "0x401D32F")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0401D330 RID: 119600
		[Token(Token = "0x401D330")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}

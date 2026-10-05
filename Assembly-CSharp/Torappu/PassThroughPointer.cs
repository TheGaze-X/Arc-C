using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using XLua;

namespace Torappu
{
	// Token: 0x02001402 RID: 5122
	[Token(Token = "0x2001402")]
	[DisallowMultipleComponent]
	[AddComponentMenu("UI/Pass Through Pointer")]
	public class PassThroughPointer : MonoBehaviour, IHotfixable, IPointerDownHandler, IEventSystemHandler, IPointerUpHandler, IPointerMoveHandler, IPointerClickHandler
	{
		// Token: 0x06007669 RID: 30313 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007669")]
		[Address(RVA = "0x241FCD0", Offset = "0x241E8D0", VA = "0x18241FCD0", Slot = "4")]
		public void OnPointerDown(PointerEventData eventData)
		{
		}

		// Token: 0x0600766A RID: 30314 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600766A")]
		[Address(RVA = "0x2420040", Offset = "0x241EC40", VA = "0x182420040", Slot = "5")]
		public void OnPointerUp(PointerEventData eventData)
		{
		}

		// Token: 0x0600766B RID: 30315 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600766B")]
		[Address(RVA = "0x2420840", Offset = "0x241F440", VA = "0x182420840")]
		private void _InvokePreClick(PointerEventData eventData)
		{
		}

		// Token: 0x0600766C RID: 30316 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600766C")]
		[Address(RVA = "0x2420550", Offset = "0x241F150", VA = "0x182420550")]
		private List<GameObject> _GetUnderlyingTargets(PointerEventData sourceEventData)
		{
			return null;
		}

		// Token: 0x0600766D RID: 30317 RVA: 0x00035070 File Offset: 0x00033270
		[Token(Token = "0x600766D")]
		[Address(RVA = "0x2420430", Offset = "0x241F030", VA = "0x182420430")]
		private bool _ContainsTarget(List<GameObject> list, GameObject target)
		{
			return default(bool);
		}

		// Token: 0x0600766E RID: 30318 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600766E")]
		[Address(RVA = "0x2420270", Offset = "0x241EE70", VA = "0x182420270")]
		private PointerEventData _CloneEventData(PointerEventData source, GameObject target)
		{
			return null;
		}

		// Token: 0x0600766F RID: 30319 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600766F")]
		[Address(RVA = "0x241F360", Offset = "0x241DF60", VA = "0x18241F360")]
		protected static GameObject FindCommonRoot(GameObject g1, GameObject g2)
		{
			return null;
		}

		// Token: 0x06007670 RID: 30320 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007670")]
		[Address(RVA = "0x241F540", Offset = "0x241E140", VA = "0x18241F540")]
		protected void HandlePointerExitAndEnter(PointerEventData currentPointerData)
		{
		}

		// Token: 0x06007671 RID: 30321 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007671")]
		[Address(RVA = "0x241FF50", Offset = "0x241EB50", VA = "0x18241FF50", Slot = "6")]
		public void OnPointerMove(PointerEventData eventData)
		{
		}

		// Token: 0x06007672 RID: 30322 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007672")]
		[Address(RVA = "0x241F820", Offset = "0x241E420", VA = "0x18241F820")]
		protected void OnDisable()
		{
		}

		// Token: 0x06007673 RID: 30323 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007673")]
		[Address(RVA = "0x241FAB0", Offset = "0x241E6B0", VA = "0x18241FAB0", Slot = "7")]
		public void OnPointerClick(PointerEventData eventData)
		{
		}

		// Token: 0x06007674 RID: 30324 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007674")]
		[Address(RVA = "0x24208E0", Offset = "0x241F4E0", VA = "0x1824208E0")]
		public PassThroughPointer()
		{
		}

		// Token: 0x0400738E RID: 29582
		[Token(Token = "0x400738E")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private bool _requirePointerUpOverSameTargetForClick;

		// Token: 0x0400738F RID: 29583
		[Token(Token = "0x400738F")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Button.ButtonClickedEvent _OnClick;

		// Token: 0x04007390 RID: 29584
		[Token(Token = "0x4007390")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		[Tooltip("Invoke this event before invoke under button.")]
		private Button.ButtonClickedEvent _onPreClick;

		// Token: 0x04007391 RID: 29585
		[Token(Token = "0x4007391")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		[Tooltip("Invoke this event before invoke under button.")]
		private PassThroughPointer.BtnClickEvtWithData _onPreClickWithData;

		// Token: 0x04007392 RID: 29586
		[Token(Token = "0x4007392")]
		[FieldOffset(Offset = "0x38")]
		private GameObject m_forwardedPressTarget;

		// Token: 0x04007393 RID: 29587
		[Token(Token = "0x4007393")]
		[FieldOffset(Offset = "0x40")]
		private GameObject m_lastEnterTarget;

		// Token: 0x04007394 RID: 29588
		[Token(Token = "0x4007394")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnPointerDown;

		// Token: 0x04007395 RID: 29589
		[Token(Token = "0x4007395")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnPointerUp;

		// Token: 0x04007396 RID: 29590
		[Token(Token = "0x4007396")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__InvokePreClick;

		// Token: 0x04007397 RID: 29591
		[Token(Token = "0x4007397")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__GetUnderlyingTargets;

		// Token: 0x04007398 RID: 29592
		[Token(Token = "0x4007398")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__ContainsTarget;

		// Token: 0x04007399 RID: 29593
		[Token(Token = "0x4007399")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__CloneEventData;

		// Token: 0x0400739A RID: 29594
		[Token(Token = "0x400739A")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_FindCommonRoot;

		// Token: 0x0400739B RID: 29595
		[Token(Token = "0x400739B")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_HandlePointerExitAndEnter;

		// Token: 0x0400739C RID: 29596
		[Token(Token = "0x400739C")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_OnPointerMove;

		// Token: 0x0400739D RID: 29597
		[Token(Token = "0x400739D")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_OnDisable;

		// Token: 0x0400739E RID: 29598
		[Token(Token = "0x400739E")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_OnPointerClick;

		// Token: 0x0400739F RID: 29599
		[Token(Token = "0x400739F")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02001403 RID: 5123
		[Token(Token = "0x2001403")]
		[Serializable]
		public class BtnClickEvtWithData : UnityEvent<PointerEventData>
		{
			// Token: 0x06007675 RID: 30325 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007675")]
			[Address(RVA = "0x241E550", Offset = "0x241D150", VA = "0x18241E550")]
			public BtnClickEvtWithData()
			{
			}
		}
	}
}

using System;
using System.Runtime.InteropServices;
using DG.Tweening;
using Il2CppDummyDll;
using Torappu.DataBind;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.StoryReview
{
	// Token: 0x020048BD RID: 18621
	[Token(Token = "0x20048BD")]
	public class MiniActDisplayBinderView : DataBinder<MiniActDisplayProperty>
	{
		// Token: 0x0601C174 RID: 115060 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C174")]
		[Address(RVA = "0x1594FC0", Offset = "0x1593BC0", VA = "0x181594FC0", Slot = "7")]
		public override void OnValueChanged(MiniActDisplayProperty property)
		{
		}

		// Token: 0x0601C175 RID: 115061 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C175")]
		[Address(RVA = "0x15951C0", Offset = "0x1593DC0", VA = "0x1815951C0")]
		public void PlaySwitchAnim(bool showTrial, [Optional] Action onCompleteCallBack)
		{
		}

		// Token: 0x0601C176 RID: 115062 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C176")]
		[Address(RVA = "0x15954D0", Offset = "0x15940D0", VA = "0x1815954D0")]
		public void RecordScrollPos()
		{
		}

		// Token: 0x0601C177 RID: 115063 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C177")]
		[Address(RVA = "0x15955D0", Offset = "0x15941D0", VA = "0x1815955D0")]
		public void ScrollToTrialItem(int index, int count)
		{
		}

		// Token: 0x0601C178 RID: 115064 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C178")]
		[Address(RVA = "0x1594E70", Offset = "0x1593A70", VA = "0x181594E70")]
		public void InitParam(LoopScrollRect reviewScrollRect, LoopScrollRect trialScrollRect, GridLayoutGroup itemGridLayout)
		{
		}

		// Token: 0x0601C179 RID: 115065 RVA: 0x000A72F8 File Offset: 0x000A54F8
		[Token(Token = "0x601C179")]
		[Address(RVA = "0x1594C90", Offset = "0x1593890", VA = "0x181594C90")]
		public float CalculatePositionForItem(int index, int count)
		{
			return 0f;
		}

		// Token: 0x0601C17A RID: 115066 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601C17A")]
		[Address(RVA = "0x15957F0", Offset = "0x15943F0", VA = "0x1815957F0")]
		private Tween _ScrollToPos(LoopScrollRect scrollRect, float normalizedPos, float duration = -1f)
		{
			return null;
		}

		// Token: 0x0601C17B RID: 115067 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C17B")]
		[Address(RVA = "0x1594F30", Offset = "0x1593B30", VA = "0x181594F30")]
		public void OnScrollVal(Vector2 normalizedPos)
		{
		}

		// Token: 0x0601C17C RID: 115068 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C17C")]
		[Address(RVA = "0x1595A00", Offset = "0x1594600", VA = "0x181595A00")]
		public MiniActDisplayBinderView()
		{
		}

		// Token: 0x04024B59 RID: 150361
		[Token(Token = "0x4024B59")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Scrollbar _slidingDisk;

		// Token: 0x04024B5A RID: 150362
		[Token(Token = "0x4024B5A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private UIAnimationLocation _animLocation;

		// Token: 0x04024B5B RID: 150363
		[Token(Token = "0x4024B5B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[SerializeField]
		private float _focusScrollDuration;

		// Token: 0x04024B5C RID: 150364
		[Token(Token = "0x4024B5C")]
		private const float SCROLL_INTERVAL = 0.1f;

		// Token: 0x04024B5D RID: 150365
		[Token(Token = "0x4024B5D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		private bool m_isPlayAnim;

		// Token: 0x04024B5E RID: 150366
		[Token(Token = "0x4024B5E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private MiniActDisplayProperty m_property;

		// Token: 0x04024B5F RID: 150367
		[Token(Token = "0x4024B5F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private Tween m_scrollTween;

		// Token: 0x04024B60 RID: 150368
		[Token(Token = "0x4024B60")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private LoopScrollRect m_reviewScrollRect;

		// Token: 0x04024B61 RID: 150369
		[Token(Token = "0x4024B61")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private LoopScrollRect m_trialScrollRect;

		// Token: 0x04024B62 RID: 150370
		[Token(Token = "0x4024B62")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private GridLayoutGroup m_itemGridLayout;

		// Token: 0x04024B63 RID: 150371
		[Token(Token = "0x4024B63")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnValueChanged;

		// Token: 0x04024B64 RID: 150372
		[Token(Token = "0x4024B64")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_PlaySwitchAnim;

		// Token: 0x04024B65 RID: 150373
		[Token(Token = "0x4024B65")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_RecordScrollPos;

		// Token: 0x04024B66 RID: 150374
		[Token(Token = "0x4024B66")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_ScrollToTrialItem;

		// Token: 0x04024B67 RID: 150375
		[Token(Token = "0x4024B67")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_InitParam;

		// Token: 0x04024B68 RID: 150376
		[Token(Token = "0x4024B68")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_CalculatePositionForItem;

		// Token: 0x04024B69 RID: 150377
		[Token(Token = "0x4024B69")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__ScrollToPos;

		// Token: 0x04024B6A RID: 150378
		[Token(Token = "0x4024B6A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_OnScrollVal;

		// Token: 0x04024B6B RID: 150379
		[Token(Token = "0x4024B6B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}

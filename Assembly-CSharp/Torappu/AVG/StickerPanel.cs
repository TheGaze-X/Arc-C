using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.AVG
{
	// Token: 0x02001EDA RID: 7898
	[Token(Token = "0x2001EDA")]
	public class StickerPanel : ExecutorComponent
	{
		// Token: 0x0600C401 RID: 50177 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C401")]
		[Address(RVA = "0x34348E0", Offset = "0x34334E0", VA = "0x1834348E0")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0600C402 RID: 50178 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600C402")]
		[Address(RVA = "0x3432780", Offset = "0x3431380", VA = "0x183432780", Slot = "8")]
		public override Dictionary<string, ExecutorComponent.Executor> GetExecutors()
		{
			return null;
		}

		// Token: 0x0600C403 RID: 50179 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C403")]
		[Address(RVA = "0x3432CD0", Offset = "0x34318D0", VA = "0x183432CD0", Slot = "5")]
		public override void OnStoryBegin(Story story)
		{
		}

		// Token: 0x0600C404 RID: 50180 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C404")]
		[Address(RVA = "0x3432B30", Offset = "0x3431730", VA = "0x183432B30", Slot = "7")]
		public override void OnReset()
		{
		}

		// Token: 0x0600C405 RID: 50181 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C405")]
		[Address(RVA = "0x34326D0", Offset = "0x34312D0", VA = "0x1834326D0", Slot = "12")]
		protected override void ForceCommandEnd()
		{
		}

		// Token: 0x0600C406 RID: 50182 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C406")]
		[Address(RVA = "0x34329D0", Offset = "0x34315D0", VA = "0x1834329D0", Slot = "11")]
		protected override void OnFinish()
		{
		}

		// Token: 0x0600C407 RID: 50183 RVA: 0x00047F28 File Offset: 0x00046128
		[Token(Token = "0x600C407")]
		[Address(RVA = "0x3433780", Offset = "0x3432380", VA = "0x183433780")]
		protected bool _ExecuteSticker(Command command)
		{
			return default(bool);
		}

		// Token: 0x0600C408 RID: 50184 RVA: 0x00047F40 File Offset: 0x00046140
		[Token(Token = "0x600C408")]
		[Address(RVA = "0x3433FE0", Offset = "0x3432BE0", VA = "0x183433FE0")]
		private StickerParam _GenParam(Command command, string textContent)
		{
			return default(StickerParam);
		}

		// Token: 0x0600C409 RID: 50185 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600C409")]
		[Address(RVA = "0x3434540", Offset = "0x3433140", VA = "0x183434540")]
		private AVGStickerTextView _GenSticker(string stickerId)
		{
			return null;
		}

		// Token: 0x0600C40A RID: 50186 RVA: 0x00047F58 File Offset: 0x00046158
		[Token(Token = "0x600C40A")]
		[Address(RVA = "0x3432F60", Offset = "0x3431B60", VA = "0x183432F60")]
		protected bool _ExcuteClear(Command command)
		{
			return default(bool);
		}

		// Token: 0x0600C40B RID: 50187 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C40B")]
		[Address(RVA = "0x3434A00", Offset = "0x3433600", VA = "0x183434A00", Slot = "13")]
		protected virtual void _OnClicked(object arg)
		{
		}

		// Token: 0x0600C40C RID: 50188 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C40C")]
		[Address(RVA = "0x3432E90", Offset = "0x3431A90", VA = "0x183432E90")]
		private void _AppendStickerText(string text, AVGStickerTextView stickerView)
		{
		}

		// Token: 0x0600C40D RID: 50189 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C40D")]
		[Address(RVA = "0x3434770", Offset = "0x3433370", VA = "0x183434770")]
		private void _HideSticker(string stickerId, AVGStickerTextView stickerView, float duration = 0f)
		{
		}

		// Token: 0x0600C40E RID: 50190 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C40E")]
		[Address(RVA = "0x3434BE0", Offset = "0x34337E0", VA = "0x183434BE0")]
		private void _RecycleStickers()
		{
		}

		// Token: 0x0600C40F RID: 50191 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C40F")]
		[Address(RVA = "0x3434B40", Offset = "0x3433740", VA = "0x183434B40")]
		private void _OnStickerTypeEnd(int msgLenth)
		{
		}

		// Token: 0x0600C410 RID: 50192 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C410")]
		[Address(RVA = "0x3434E60", Offset = "0x3433A60", VA = "0x183434E60")]
		private void _SetTypeWriterDelay(object arg)
		{
		}

		// Token: 0x0600C411 RID: 50193 RVA: 0x00047F70 File Offset: 0x00046170
		[Token(Token = "0x600C411")]
		[Address(RVA = "0x3433270", Offset = "0x3431E70", VA = "0x183433270")]
		protected bool _ExcuteTimerSticker(Command command)
		{
			return default(bool);
		}

		// Token: 0x0600C412 RID: 50194 RVA: 0x00047F88 File Offset: 0x00046188
		[Token(Token = "0x600C412")]
		[Address(RVA = "0x3433110", Offset = "0x3431D10", VA = "0x183433110")]
		protected bool _ExcuteTimerClier(Command command)
		{
			return default(bool);
		}

		// Token: 0x0600C413 RID: 50195 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C413")]
		[Address(RVA = "0x3434F40", Offset = "0x3433B40", VA = "0x183434F40")]
		public StickerPanel()
		{
		}

		// Token: 0x0600C414 RID: 50196 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C414")]
		[Address(RVA = "0x33F0E70", Offset = "0x33EFA70", VA = "0x1833F0E70")]
		private void <>xLuaBaseProxy_OnStoryBegin(Story P0)
		{
		}

		// Token: 0x0600C415 RID: 50197 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C415")]
		[Address(RVA = "0x1C5FCF0", Offset = "0x1C5E8F0", VA = "0x181C5FCF0")]
		private void <>xLuaBaseProxy_OnReset()
		{
		}

		// Token: 0x0600C416 RID: 50198 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C416")]
		[Address(RVA = "0x33F4E00", Offset = "0x33F3A00", VA = "0x1833F4E00")]
		private void <>xLuaBaseProxy_OnFinish()
		{
		}

		// Token: 0x0400C66A RID: 50794
		[Token(Token = "0x400C66A")]
		private const float SCREEN_WIDTH = 1280f;

		// Token: 0x0400C66B RID: 50795
		[Token(Token = "0x400C66B")]
		private const float SCREEN_HEIGHT = 720f;

		// Token: 0x0400C66C RID: 50796
		[Token(Token = "0x400C66C")]
		private const int STICKER_MAX_NUM = 20;

		// Token: 0x0400C66D RID: 50797
		[Token(Token = "0x400C66D")]
		private const float DEFAULT_FADE_DURATION = 0.13f;

		// Token: 0x0400C66E RID: 50798
		[Token(Token = "0x400C66E")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private RectTransform _stickerContainer;

		// Token: 0x0400C66F RID: 50799
		[Token(Token = "0x400C66F")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private AVGStickerTextView _stickerPrefab;

		// Token: 0x0400C670 RID: 50800
		[Token(Token = "0x400C670")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private AVGTimerView _timerStickerPrefab;

		// Token: 0x0400C671 RID: 50801
		[Token(Token = "0x400C671")]
		[FieldOffset(Offset = "0x68")]
		private AVGStickerTextView m_currentSticker;

		// Token: 0x0400C672 RID: 50802
		[Token(Token = "0x400C672")]
		[FieldOffset(Offset = "0x70")]
		private Dictionary<string, AVGStickerTextView> m_stickerDict;

		// Token: 0x0400C673 RID: 50803
		[Token(Token = "0x400C673")]
		[FieldOffset(Offset = "0x78")]
		private List<AVGStickerTextView> m_recyclePool;

		// Token: 0x0400C674 RID: 50804
		[Token(Token = "0x400C674")]
		[FieldOffset(Offset = "0x80")]
		private AVGTimerView m_currentTimer;

		// Token: 0x0400C675 RID: 50805
		[Token(Token = "0x400C675")]
		[FieldOffset(Offset = "0x88")]
		private bool m_inited;

		// Token: 0x0400C676 RID: 50806
		[Token(Token = "0x400C676")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0400C677 RID: 50807
		[Token(Token = "0x400C677")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_GetExecutors;

		// Token: 0x0400C678 RID: 50808
		[Token(Token = "0x400C678")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnStoryBegin;

		// Token: 0x0400C679 RID: 50809
		[Token(Token = "0x400C679")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnReset;

		// Token: 0x0400C67A RID: 50810
		[Token(Token = "0x400C67A")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_ForceCommandEnd;

		// Token: 0x0400C67B RID: 50811
		[Token(Token = "0x400C67B")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_OnFinish;

		// Token: 0x0400C67C RID: 50812
		[Token(Token = "0x400C67C")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__ExecuteSticker;

		// Token: 0x0400C67D RID: 50813
		[Token(Token = "0x400C67D")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__GenParam;

		// Token: 0x0400C67E RID: 50814
		[Token(Token = "0x400C67E")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__GenSticker;

		// Token: 0x0400C67F RID: 50815
		[Token(Token = "0x400C67F")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0__ExcuteClear;

		// Token: 0x0400C680 RID: 50816
		[Token(Token = "0x400C680")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0__OnClicked;

		// Token: 0x0400C681 RID: 50817
		[Token(Token = "0x400C681")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0__AppendStickerText;

		// Token: 0x0400C682 RID: 50818
		[Token(Token = "0x400C682")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0__HideSticker;

		// Token: 0x0400C683 RID: 50819
		[Token(Token = "0x400C683")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0__RecycleStickers;

		// Token: 0x0400C684 RID: 50820
		[Token(Token = "0x400C684")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0__OnStickerTypeEnd;

		// Token: 0x0400C685 RID: 50821
		[Token(Token = "0x400C685")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0__SetTypeWriterDelay;

		// Token: 0x0400C686 RID: 50822
		[Token(Token = "0x400C686")]
		[FieldOffset(Offset = "0x80")]
		private static DelegateBridge __Hotfix0__ExcuteTimerSticker;

		// Token: 0x0400C687 RID: 50823
		[Token(Token = "0x400C687")]
		[FieldOffset(Offset = "0x88")]
		private static DelegateBridge __Hotfix0__ExcuteTimerClier;

		// Token: 0x0400C688 RID: 50824
		[Token(Token = "0x400C688")]
		[FieldOffset(Offset = "0x90")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}

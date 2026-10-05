using System;
using DG.Tweening;
using Il2CppDummyDll;
using Torappu.UI;
using UnityEngine;
using XLua;

namespace Torappu.Activity.Act42D0
{
	// Token: 0x02007390 RID: 29584
	[Token(Token = "0x2007390")]
	public class Act42d0AreaGroupView : MonoBehaviour, IHotfixable
	{
		// Token: 0x170062C9 RID: 25289
		// (get) Token: 0x06029D24 RID: 171300 RVA: 0x000D6B48 File Offset: 0x000D4D48
		[Token(Token = "0x170062C9")]
		public Act42D0Data.Act42D0AreaDifficulty difficulty
		{
			[Token(Token = "0x6029D24")]
			[Address(RVA = "0x2578420", Offset = "0x2577020", VA = "0x182578420")]
			get
			{
				return Act42D0Data.Act42D0AreaDifficulty.NONE;
			}
		}

		// Token: 0x06029D25 RID: 171301 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029D25")]
		[Address(RVA = "0x2577DE0", Offset = "0x25769E0", VA = "0x182577DE0")]
		private void _InitIfNot()
		{
		}

		// Token: 0x06029D26 RID: 171302 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029D26")]
		[Address(RVA = "0x25778D0", Offset = "0x25764D0", VA = "0x1825778D0")]
		public void RenderAreas(Act42d0AreaMapViewModel viewModel)
		{
		}

		// Token: 0x06029D27 RID: 171303 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029D27")]
		[Address(RVA = "0x2578150", Offset = "0x2576D50", VA = "0x182578150")]
		private void _TryFocusArea(Act42d0AreaMapViewModel viewModel)
		{
		}

		// Token: 0x06029D28 RID: 171304 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029D28")]
		[Address(RVA = "0x2577CC0", Offset = "0x25768C0", VA = "0x182577CC0")]
		private void _FocusAreaImpl(float targetVal)
		{
		}

		// Token: 0x06029D29 RID: 171305 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029D29")]
		[Address(RVA = "0x2577EF0", Offset = "0x2576AF0", VA = "0x182577EF0")]
		private void _RenderAreaButtons(Act42d0AreaMapViewModel viewModel, bool showStatusChanged)
		{
		}

		// Token: 0x06029D2A RID: 171306 RVA: 0x000D6B60 File Offset: 0x000D4D60
		[Token(Token = "0x6029D2A")]
		[Address(RVA = "0x2577B80", Offset = "0x2576780", VA = "0x182577B80")]
		public bool TryRegisterAreaGo()
		{
			return default(bool);
		}

		// Token: 0x06029D2B RID: 171307 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029D2B")]
		[Address(RVA = "0x2577AF0", Offset = "0x25766F0", VA = "0x182577AF0")]
		public void SetFocusThreshold(float focusThreshold, float focusDuration)
		{
		}

		// Token: 0x06029D2C RID: 171308 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029D2C")]
		[Address(RVA = "0x25783C0", Offset = "0x2576FC0", VA = "0x1825783C0")]
		public Act42d0AreaGroupView()
		{
		}

		// Token: 0x0403BE4B RID: 245323
		[Token(Token = "0x403BE4B")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Act42d0AreaButtonHolder[] _btnHolders;

		// Token: 0x0403BE4C RID: 245324
		[Token(Token = "0x403BE4C")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Act42D0Data.Act42D0AreaDifficulty _difficulty;

		// Token: 0x0403BE4D RID: 245325
		[Token(Token = "0x403BE4D")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private UIAnimationLocation _hideSwitchAnim;

		// Token: 0x0403BE4E RID: 245326
		[Token(Token = "0x403BE4E")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private RectTransform _focusTweenRoot;

		// Token: 0x0403BE4F RID: 245327
		[Token(Token = "0x403BE4F")]
		[FieldOffset(Offset = "0x40")]
		private AnimationSwitchTween m_switchTw;

		// Token: 0x0403BE50 RID: 245328
		[Token(Token = "0x403BE50")]
		[FieldOffset(Offset = "0x48")]
		private bool m_inited;

		// Token: 0x0403BE51 RID: 245329
		[Token(Token = "0x403BE51")]
		[FieldOffset(Offset = "0x50")]
		private string m_cachedSelectAreaId;

		// Token: 0x0403BE52 RID: 245330
		[Token(Token = "0x403BE52")]
		[FieldOffset(Offset = "0x58")]
		private float m_focusThreshold;

		// Token: 0x0403BE53 RID: 245331
		[Token(Token = "0x403BE53")]
		[FieldOffset(Offset = "0x5C")]
		private float m_focusDuration;

		// Token: 0x0403BE54 RID: 245332
		[Token(Token = "0x403BE54")]
		[FieldOffset(Offset = "0x60")]
		private Tween m_focusTween;

		// Token: 0x0403BE55 RID: 245333
		[Token(Token = "0x403BE55")]
		[FieldOffset(Offset = "0x68")]
		private bool m_cachedShowStatus;

		// Token: 0x0403BE56 RID: 245334
		[Token(Token = "0x403BE56")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_difficulty;

		// Token: 0x0403BE57 RID: 245335
		[Token(Token = "0x403BE57")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0403BE58 RID: 245336
		[Token(Token = "0x403BE58")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_RenderAreas;

		// Token: 0x0403BE59 RID: 245337
		[Token(Token = "0x403BE59")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__TryFocusArea;

		// Token: 0x0403BE5A RID: 245338
		[Token(Token = "0x403BE5A")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__FocusAreaImpl;

		// Token: 0x0403BE5B RID: 245339
		[Token(Token = "0x403BE5B")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__RenderAreaButtons;

		// Token: 0x0403BE5C RID: 245340
		[Token(Token = "0x403BE5C")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_TryRegisterAreaGo;

		// Token: 0x0403BE5D RID: 245341
		[Token(Token = "0x403BE5D")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_SetFocusThreshold;

		// Token: 0x0403BE5E RID: 245342
		[Token(Token = "0x403BE5E")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}

using System;
using System.Collections;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.HotUpdate
{
	// Token: 0x02004A87 RID: 19079
	[Token(Token = "0x2004A87")]
	public abstract class AbstractHotUpdatePreMainFadeInView : MonoBehaviour, IHotfixable
	{
		// Token: 0x170043A2 RID: 17314
		// (get) Token: 0x0601CABE RID: 117438 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170043A2")]
		protected FadeSwitchTween switchTween
		{
			[Token(Token = "0x601CABE")]
			[Address(RVA = "0x161FFA0", Offset = "0x161EBA0", VA = "0x18161FFA0")]
			get
			{
				return null;
			}
		}

		// Token: 0x170043A3 RID: 17315
		// (get) Token: 0x0601CABF RID: 117439
		[Token(Token = "0x170043A3")]
		protected abstract PreMainState state { [Token(Token = "0x601CABF")] get; }

		// Token: 0x0601CAC0 RID: 117440 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601CAC0")]
		[Address(RVA = "0x161FE00", Offset = "0x161EA00", VA = "0x18161FE00")]
		public void SetContext(HotUpdateWorkflow.IContext i_context)
		{
		}

		// Token: 0x0601CAC1 RID: 117441 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601CAC1")]
		[Address(RVA = "0x161FC30", Offset = "0x161E830", VA = "0x18161FC30", Slot = "5")]
		public virtual void Render(HotUpdatePremainViewModel viewModel, ILoadAsset assets)
		{
		}

		// Token: 0x0601CAC2 RID: 117442 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601CAC2")]
		[Address(RVA = "0x161F900", Offset = "0x161E500", VA = "0x18161F900", Slot = "6")]
		public virtual void Clear()
		{
		}

		// Token: 0x0601CAC3 RID: 117443 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601CAC3")]
		[Address(RVA = "0x161FA90", Offset = "0x161E690", VA = "0x18161FA90")]
		protected void InitIfNot()
		{
		}

		// Token: 0x0601CAC4 RID: 117444 RVA: 0x000A9080 File Offset: 0x000A7280
		[Token(Token = "0x601CAC4")]
		[Address(RVA = "0x161FB80", Offset = "0x161E780", VA = "0x18161FB80", Slot = "7")]
		protected virtual bool IsShow(HotUpdatePremainViewModel viewModel)
		{
			return default(bool);
		}

		// Token: 0x0601CAC5 RID: 117445 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601CAC5")]
		[Address(RVA = "0x161F7A0", Offset = "0x161E3A0", VA = "0x18161F7A0")]
		protected void ApplyState(HotUpdatePremainViewModel viewModel)
		{
		}

		// Token: 0x0601CAC6 RID: 117446 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601CAC6")]
		[Address(RVA = "0x161FE80", Offset = "0x161EA80", VA = "0x18161FE80", Slot = "8")]
		public virtual IEnumerator Show(PreMainState lastState)
		{
			return null;
		}

		// Token: 0x0601CAC7 RID: 117447 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601CAC7")]
		[Address(RVA = "0x161F9B0", Offset = "0x161E5B0", VA = "0x18161F9B0", Slot = "9")]
		public virtual void Hide(bool immediately)
		{
		}

		// Token: 0x0601CAC8 RID: 117448 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601CAC8")]
		[Address(RVA = "0x161FF40", Offset = "0x161EB40", VA = "0x18161FF40")]
		protected AbstractHotUpdatePreMainFadeInView()
		{
		}

		// Token: 0x04025A19 RID: 154137
		[Token(Token = "0x4025A19")]
		public const float DEFAULT_WAIT_TWEEN_DURATION = 0.5f;

		// Token: 0x04025A1A RID: 154138
		[Token(Token = "0x4025A1A")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private CanvasGroup _canvasGroup;

		// Token: 0x04025A1B RID: 154139
		[Token(Token = "0x4025A1B")]
		[FieldOffset(Offset = "0x20")]
		protected HotUpdateWorkflow.IContext context;

		// Token: 0x04025A1C RID: 154140
		[Token(Token = "0x4025A1C")]
		[FieldOffset(Offset = "0x28")]
		private FadeSwitchTween m_switchTween;

		// Token: 0x04025A1D RID: 154141
		[Token(Token = "0x4025A1D")]
		[FieldOffset(Offset = "0x30")]
		private bool m_isInited;

		// Token: 0x04025A1E RID: 154142
		[Token(Token = "0x4025A1E")]
		[FieldOffset(Offset = "0x38")]
		private IEnumerator m_showCoroutine;

		// Token: 0x04025A1F RID: 154143
		[Token(Token = "0x4025A1F")]
		[FieldOffset(Offset = "0x40")]
		private PreMainState m_cacheState;

		// Token: 0x04025A20 RID: 154144
		[Token(Token = "0x4025A20")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_switchTween;

		// Token: 0x04025A21 RID: 154145
		[Token(Token = "0x4025A21")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_SetContext;

		// Token: 0x04025A22 RID: 154146
		[Token(Token = "0x4025A22")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x04025A23 RID: 154147
		[Token(Token = "0x4025A23")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_Clear;

		// Token: 0x04025A24 RID: 154148
		[Token(Token = "0x4025A24")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_InitIfNot;

		// Token: 0x04025A25 RID: 154149
		[Token(Token = "0x4025A25")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_IsShow;

		// Token: 0x04025A26 RID: 154150
		[Token(Token = "0x4025A26")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_ApplyState;

		// Token: 0x04025A27 RID: 154151
		[Token(Token = "0x4025A27")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_Show;

		// Token: 0x04025A28 RID: 154152
		[Token(Token = "0x4025A28")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_Hide;

		// Token: 0x04025A29 RID: 154153
		[Token(Token = "0x4025A29")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}

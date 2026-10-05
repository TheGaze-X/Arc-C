using System;
using Il2CppDummyDll;
using UnityEngine.EventSystems;
using XLua;

namespace Torappu.UI
{
	// Token: 0x0200376E RID: 14190
	[Token(Token = "0x200376E")]
	public abstract class UIStylerApplier<StyleType> : UIBehaviour, IUIStyleListener, IHotfixable where StyleType : UIStyle
	{
		// Token: 0x06016880 RID: 92288 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6016880")]
		public void SetStyle(UIStyle style)
		{
		}

		// Token: 0x06016881 RID: 92289
		[Token(Token = "0x6016881")]
		protected abstract void OnApplyStyle(StyleType style);

		// Token: 0x06016882 RID: 92290 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6016882")]
		private void _StopListen()
		{
		}

		// Token: 0x06016883 RID: 92291 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6016883")]
		private void _TryListen()
		{
		}

		// Token: 0x06016884 RID: 92292 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6016884")]
		protected override void OnBeforeTransformParentChanged()
		{
		}

		// Token: 0x06016885 RID: 92293 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6016885")]
		protected override void OnTransformParentChanged()
		{
		}

		// Token: 0x06016886 RID: 92294 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6016886")]
		protected override void OnEnable()
		{
		}

		// Token: 0x06016887 RID: 92295 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6016887")]
		protected override void OnDisable()
		{
		}

		// Token: 0x06016888 RID: 92296 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6016888")]
		protected UIStylerApplier()
		{
		}

		// Token: 0x0401B246 RID: 111174
		[Token(Token = "0x401B246")]
		[FieldOffset(Offset = "0x0")]
		private UIStyleProvider m_provider;

		// Token: 0x0401B247 RID: 111175
		[Token(Token = "0x401B247")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_SetStyle;

		// Token: 0x0401B248 RID: 111176
		[Token(Token = "0x401B248")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0__StopListen;

		// Token: 0x0401B249 RID: 111177
		[Token(Token = "0x401B249")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0__TryListen;

		// Token: 0x0401B24A RID: 111178
		[Token(Token = "0x401B24A")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnBeforeTransformParentChanged;

		// Token: 0x0401B24B RID: 111179
		[Token(Token = "0x401B24B")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnTransformParentChanged;

		// Token: 0x0401B24C RID: 111180
		[Token(Token = "0x401B24C")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnEnable;

		// Token: 0x0401B24D RID: 111181
		[Token(Token = "0x401B24D")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnDisable;

		// Token: 0x0401B24E RID: 111182
		[Token(Token = "0x401B24E")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}

using System;
using Il2CppDummyDll;
using Torappu.UI;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Activity.Act1VHalfIdle
{
	// Token: 0x020077BC RID: 30652
	[Token(Token = "0x20077BC")]
	public class Act1VHalfIdleStageIncomeDialog : UICompDialog<Act1VHalfIdleStageIncomeDialog.Option>
	{
		// Token: 0x0602B06A RID: 176234 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B06A")]
		[Address(RVA = "0x26D3470", Offset = "0x26D2070", VA = "0x1826D3470", Slot = "9")]
		protected override void OnInit()
		{
		}

		// Token: 0x0602B06B RID: 176235 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B06B")]
		[Address(RVA = "0x26D3570", Offset = "0x26D2170", VA = "0x1826D3570", Slot = "18")]
		protected override void OnRender(Act1VHalfIdleStageIncomeDialog.Option input)
		{
		}

		// Token: 0x0602B06C RID: 176236 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602B06C")]
		[Address(RVA = "0x26D31E0", Offset = "0x26D1DE0", VA = "0x1826D31E0", Slot = "15")]
		protected override UIRenderTextureImage GetBlurTarget()
		{
			return null;
		}

		// Token: 0x0602B06D RID: 176237 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B06D")]
		[Address(RVA = "0x26D3310", Offset = "0x26D1F10", VA = "0x1826D3310", Slot = "10")]
		protected override void OnFinishShowTransition()
		{
		}

		// Token: 0x0602B06E RID: 176238 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B06E")]
		[Address(RVA = "0x26D3240", Offset = "0x26D1E40", VA = "0x1826D3240", Slot = "11")]
		protected override void OnDestroySubClass()
		{
		}

		// Token: 0x0602B06F RID: 176239 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B06F")]
		[Address(RVA = "0x26D3120", Offset = "0x26D1D20", VA = "0x1826D3120")]
		public void Close()
		{
		}

		// Token: 0x0602B070 RID: 176240 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B070")]
		[Address(RVA = "0x26D37F0", Offset = "0x26D23F0", VA = "0x1826D37F0")]
		private void _TryRaiseIncomeDialogShowSignal()
		{
		}

		// Token: 0x0602B071 RID: 176241 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B071")]
		[Address(RVA = "0x26D3760", Offset = "0x26D2360", VA = "0x1826D3760")]
		private void _TryRaiseIncomeDialogHideSignal()
		{
		}

		// Token: 0x0602B072 RID: 176242 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B072")]
		[Address(RVA = "0x26D3910", Offset = "0x26D2510", VA = "0x1826D3910")]
		public Act1VHalfIdleStageIncomeDialog()
		{
		}

		// Token: 0x0602B073 RID: 176243 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B073")]
		[Address(RVA = "0xE613C0", Offset = "0xE5FFC0", VA = "0x180E613C0")]
		private void <>xLuaBaseProxy_OnInit()
		{
		}

		// Token: 0x0602B074 RID: 176244 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602B074")]
		[Address(RVA = "0xE613B0", Offset = "0xE5FFB0", VA = "0x180E613B0")]
		private UIRenderTextureImage <>xLuaBaseProxy_GetBlurTarget()
		{
			return null;
		}

		// Token: 0x0602B075 RID: 176245 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B075")]
		[Address(RVA = "0x1A4B800", Offset = "0x1A4A400", VA = "0x181A4B800")]
		private void <>xLuaBaseProxy_OnFinishShowTransition()
		{
		}

		// Token: 0x0602B076 RID: 176246 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B076")]
		[Address(RVA = "0x1E376C0", Offset = "0x1E362C0", VA = "0x181E376C0")]
		private void <>xLuaBaseProxy_OnDestroySubClass()
		{
		}

		// Token: 0x0403E20D RID: 254477
		[Token(Token = "0x403E20D")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private Transform _graphContainer;

		// Token: 0x0403E20E RID: 254478
		[Token(Token = "0x403E20E")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private Act1VHalfIdleIncomeGraphView _graphViewPrefab;

		// Token: 0x0403E20F RID: 254479
		[Token(Token = "0x403E20F")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private UIRenderTextureImage _blurBg;

		// Token: 0x0403E210 RID: 254480
		[Token(Token = "0x403E210")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		private RectTransform _backRect;

		// Token: 0x0403E211 RID: 254481
		[Token(Token = "0x403E211")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		private Text _stageCodeText;

		// Token: 0x0403E212 RID: 254482
		[Token(Token = "0x403E212")]
		[FieldOffset(Offset = "0x98")]
		private Act1VHalfIdleIncomeGraphViewModel m_graphViewModel;

		// Token: 0x0403E213 RID: 254483
		[Token(Token = "0x403E213")]
		[FieldOffset(Offset = "0xA0")]
		private Act1VHalfIdleIncomeGraphView m_graphView;

		// Token: 0x0403E214 RID: 254484
		[Token(Token = "0x403E214")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnInit;

		// Token: 0x0403E215 RID: 254485
		[Token(Token = "0x403E215")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnRender;

		// Token: 0x0403E216 RID: 254486
		[Token(Token = "0x403E216")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_GetBlurTarget;

		// Token: 0x0403E217 RID: 254487
		[Token(Token = "0x403E217")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnFinishShowTransition;

		// Token: 0x0403E218 RID: 254488
		[Token(Token = "0x403E218")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_OnDestroySubClass;

		// Token: 0x0403E219 RID: 254489
		[Token(Token = "0x403E219")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_Close;

		// Token: 0x0403E21A RID: 254490
		[Token(Token = "0x403E21A")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__TryRaiseIncomeDialogShowSignal;

		// Token: 0x0403E21B RID: 254491
		[Token(Token = "0x403E21B")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__TryRaiseIncomeDialogHideSignal;

		// Token: 0x0403E21C RID: 254492
		[Token(Token = "0x403E21C")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x020077BD RID: 30653
		[Token(Token = "0x20077BD")]
		public class Option
		{
			// Token: 0x0602B077 RID: 176247 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602B077")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public Option()
			{
			}

			// Token: 0x0403E21D RID: 254493
			[Token(Token = "0x403E21D")]
			[FieldOffset(Offset = "0x10")]
			public string actId;

			// Token: 0x0403E21E RID: 254494
			[Token(Token = "0x403E21E")]
			[FieldOffset(Offset = "0x18")]
			public string stageId;
		}
	}
}

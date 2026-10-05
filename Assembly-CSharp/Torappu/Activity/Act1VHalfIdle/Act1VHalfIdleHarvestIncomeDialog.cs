using System;
using Il2CppDummyDll;
using Torappu.UI;
using UnityEngine;
using XLua;

namespace Torappu.Activity.Act1VHalfIdle
{
	// Token: 0x020077B2 RID: 30642
	[Token(Token = "0x20077B2")]
	public class Act1VHalfIdleHarvestIncomeDialog : UICompDialog<Act1VHalfIdleHarvestIncomeDialog.Option>
	{
		// Token: 0x0602B03F RID: 176191 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B03F")]
		[Address(RVA = "0x26CC110", Offset = "0x26CAD10", VA = "0x1826CC110", Slot = "9")]
		protected override void OnInit()
		{
		}

		// Token: 0x0602B040 RID: 176192 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B040")]
		[Address(RVA = "0x26CC210", Offset = "0x26CAE10", VA = "0x1826CC210", Slot = "18")]
		protected override void OnRender(Act1VHalfIdleHarvestIncomeDialog.Option input)
		{
		}

		// Token: 0x0602B041 RID: 176193 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B041")]
		[Address(RVA = "0x26CBFB0", Offset = "0x26CABB0", VA = "0x1826CBFB0", Slot = "10")]
		protected override void OnFinishShowTransition()
		{
		}

		// Token: 0x0602B042 RID: 176194 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B042")]
		[Address(RVA = "0x26CBEE0", Offset = "0x26CAAE0", VA = "0x1826CBEE0", Slot = "11")]
		protected override void OnDestroySubClass()
		{
		}

		// Token: 0x0602B043 RID: 176195 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602B043")]
		[Address(RVA = "0x26CBE80", Offset = "0x26CAA80", VA = "0x1826CBE80", Slot = "15")]
		protected override UIRenderTextureImage GetBlurTarget()
		{
			return null;
		}

		// Token: 0x0602B044 RID: 176196 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B044")]
		[Address(RVA = "0x26CBDC0", Offset = "0x26CA9C0", VA = "0x1826CBDC0")]
		public void Close()
		{
		}

		// Token: 0x0602B045 RID: 176197 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B045")]
		[Address(RVA = "0x26CC440", Offset = "0x26CB040", VA = "0x1826CC440")]
		private void _TryRaiseIncomeDialogShowSignal()
		{
		}

		// Token: 0x0602B046 RID: 176198 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B046")]
		[Address(RVA = "0x26CC3B0", Offset = "0x26CAFB0", VA = "0x1826CC3B0")]
		private void _TryRaiseIncomeDialogHideSignal()
		{
		}

		// Token: 0x0602B047 RID: 176199 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B047")]
		[Address(RVA = "0x26CC560", Offset = "0x26CB160", VA = "0x1826CC560")]
		public Act1VHalfIdleHarvestIncomeDialog()
		{
		}

		// Token: 0x0602B048 RID: 176200 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B048")]
		[Address(RVA = "0xE613C0", Offset = "0xE5FFC0", VA = "0x180E613C0")]
		private void <>xLuaBaseProxy_OnInit()
		{
		}

		// Token: 0x0602B049 RID: 176201 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B049")]
		[Address(RVA = "0x1A4B800", Offset = "0x1A4A400", VA = "0x181A4B800")]
		private void <>xLuaBaseProxy_OnFinishShowTransition()
		{
		}

		// Token: 0x0602B04A RID: 176202 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B04A")]
		[Address(RVA = "0x1E376C0", Offset = "0x1E362C0", VA = "0x181E376C0")]
		private void <>xLuaBaseProxy_OnDestroySubClass()
		{
		}

		// Token: 0x0602B04B RID: 176203 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602B04B")]
		[Address(RVA = "0xE613B0", Offset = "0xE5FFB0", VA = "0x180E613B0")]
		private UIRenderTextureImage <>xLuaBaseProxy_GetBlurTarget()
		{
			return null;
		}

		// Token: 0x0403E19B RID: 254363
		[Token(Token = "0x403E19B")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private Transform _graphContainer;

		// Token: 0x0403E19C RID: 254364
		[Token(Token = "0x403E19C")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private Act1VHalfIdleIncomeGraphView _graphViewPrefab;

		// Token: 0x0403E19D RID: 254365
		[Token(Token = "0x403E19D")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private UIRenderTextureImage _blurBg;

		// Token: 0x0403E19E RID: 254366
		[Token(Token = "0x403E19E")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		private RectTransform _backRect;

		// Token: 0x0403E19F RID: 254367
		[Token(Token = "0x403E19F")]
		[FieldOffset(Offset = "0x90")]
		private Act1VHalfIdleIncomeGraphViewModel m_graphViewModel;

		// Token: 0x0403E1A0 RID: 254368
		[Token(Token = "0x403E1A0")]
		[FieldOffset(Offset = "0x98")]
		private Act1VHalfIdleIncomeGraphView m_graphView;

		// Token: 0x0403E1A1 RID: 254369
		[Token(Token = "0x403E1A1")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnInit;

		// Token: 0x0403E1A2 RID: 254370
		[Token(Token = "0x403E1A2")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnRender;

		// Token: 0x0403E1A3 RID: 254371
		[Token(Token = "0x403E1A3")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnFinishShowTransition;

		// Token: 0x0403E1A4 RID: 254372
		[Token(Token = "0x403E1A4")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnDestroySubClass;

		// Token: 0x0403E1A5 RID: 254373
		[Token(Token = "0x403E1A5")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_GetBlurTarget;

		// Token: 0x0403E1A6 RID: 254374
		[Token(Token = "0x403E1A6")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_Close;

		// Token: 0x0403E1A7 RID: 254375
		[Token(Token = "0x403E1A7")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__TryRaiseIncomeDialogShowSignal;

		// Token: 0x0403E1A8 RID: 254376
		[Token(Token = "0x403E1A8")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__TryRaiseIncomeDialogHideSignal;

		// Token: 0x0403E1A9 RID: 254377
		[Token(Token = "0x403E1A9")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x020077B3 RID: 30643
		[Token(Token = "0x20077B3")]
		public class Option
		{
			// Token: 0x0602B04C RID: 176204 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602B04C")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public Option()
			{
			}

			// Token: 0x0403E1AA RID: 254378
			[Token(Token = "0x403E1AA")]
			[FieldOffset(Offset = "0x10")]
			public string actId;
		}
	}
}

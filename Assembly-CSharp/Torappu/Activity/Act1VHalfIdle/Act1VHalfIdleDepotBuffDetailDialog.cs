using System;
using Il2CppDummyDll;
using Torappu.UI;
using UnityEngine;
using XLua;

namespace Torappu.Activity.Act1VHalfIdle
{
	// Token: 0x02007792 RID: 30610
	[Token(Token = "0x2007792")]
	public class Act1VHalfIdleDepotBuffDetailDialog : UICompDialog<Act1VHalfIdleDepotBuffDetailDialog.Inputs>
	{
		// Token: 0x0602AFC4 RID: 176068 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602AFC4")]
		[Address(RVA = "0x26C6950", Offset = "0x26C5550", VA = "0x1826C6950", Slot = "15")]
		protected override UIRenderTextureImage GetBlurTarget()
		{
			return null;
		}

		// Token: 0x0602AFC5 RID: 176069 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602AFC5")]
		[Address(RVA = "0x26C6A70", Offset = "0x26C5670", VA = "0x1826C6A70", Slot = "9")]
		protected override void OnInit()
		{
		}

		// Token: 0x0602AFC6 RID: 176070 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602AFC6")]
		[Address(RVA = "0x26C6C80", Offset = "0x26C5880", VA = "0x1826C6C80", Slot = "18")]
		protected override void OnRender(Act1VHalfIdleDepotBuffDetailDialog.Inputs input)
		{
		}

		// Token: 0x0602AFC7 RID: 176071 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602AFC7")]
		[Address(RVA = "0x26C6BC0", Offset = "0x26C57C0", VA = "0x1826C6BC0")]
		public void OnPrevClick()
		{
		}

		// Token: 0x0602AFC8 RID: 176072 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602AFC8")]
		[Address(RVA = "0x26C6B00", Offset = "0x26C5700", VA = "0x1826C6B00")]
		public void OnNextClick()
		{
		}

		// Token: 0x0602AFC9 RID: 176073 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602AFC9")]
		[Address(RVA = "0x26C6E70", Offset = "0x26C5A70", VA = "0x1826C6E70")]
		public void OnSwitchShowType()
		{
		}

		// Token: 0x0602AFCA RID: 176074 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602AFCA")]
		[Address(RVA = "0x26C69B0", Offset = "0x26C55B0", VA = "0x1826C69B0")]
		public void OnBackClick()
		{
		}

		// Token: 0x0602AFCB RID: 176075 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602AFCB")]
		[Address(RVA = "0x26C6F30", Offset = "0x26C5B30", VA = "0x1826C6F30")]
		public Act1VHalfIdleDepotBuffDetailDialog()
		{
		}

		// Token: 0x0602AFCC RID: 176076 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602AFCC")]
		[Address(RVA = "0xE613B0", Offset = "0xE5FFB0", VA = "0x180E613B0")]
		private UIRenderTextureImage <>xLuaBaseProxy_GetBlurTarget()
		{
			return null;
		}

		// Token: 0x0602AFCD RID: 176077 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602AFCD")]
		[Address(RVA = "0xE613C0", Offset = "0xE5FFC0", VA = "0x180E613C0")]
		private void <>xLuaBaseProxy_OnInit()
		{
		}

		// Token: 0x0403E080 RID: 254080
		[Token(Token = "0x403E080")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private UIRenderTextureImage _blur;

		// Token: 0x0403E081 RID: 254081
		[Token(Token = "0x403E081")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private Act1VHalfIdleDepotBuffDetailView _view;

		// Token: 0x0403E082 RID: 254082
		[Token(Token = "0x403E082")]
		[FieldOffset(Offset = "0x80")]
		private Act1VHalfIdleDepotBuffDetailProp m_prop;

		// Token: 0x0403E083 RID: 254083
		[Token(Token = "0x403E083")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetBlurTarget;

		// Token: 0x0403E084 RID: 254084
		[Token(Token = "0x403E084")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnInit;

		// Token: 0x0403E085 RID: 254085
		[Token(Token = "0x403E085")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnRender;

		// Token: 0x0403E086 RID: 254086
		[Token(Token = "0x403E086")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnPrevClick;

		// Token: 0x0403E087 RID: 254087
		[Token(Token = "0x403E087")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_OnNextClick;

		// Token: 0x0403E088 RID: 254088
		[Token(Token = "0x403E088")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_OnSwitchShowType;

		// Token: 0x0403E089 RID: 254089
		[Token(Token = "0x403E089")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_OnBackClick;

		// Token: 0x0403E08A RID: 254090
		[Token(Token = "0x403E08A")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02007793 RID: 30611
		[Token(Token = "0x2007793")]
		public class Inputs
		{
			// Token: 0x0602AFCE RID: 176078 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602AFCE")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public Inputs()
			{
			}

			// Token: 0x0403E08B RID: 254091
			[Token(Token = "0x403E08B")]
			[FieldOffset(Offset = "0x10")]
			public ProfessionCategory prof;

			// Token: 0x0403E08C RID: 254092
			[Token(Token = "0x403E08C")]
			[FieldOffset(Offset = "0x18")]
			public Act1VHalfIdleDepotBuffViewModel buffViewModel;
		}
	}
}

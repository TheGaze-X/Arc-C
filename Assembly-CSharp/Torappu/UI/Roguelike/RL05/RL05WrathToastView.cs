using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Roguelike.RL05
{
	// Token: 0x02005640 RID: 22080
	[Token(Token = "0x2005640")]
	public class RL05WrathToastView : UINotifyView<RL05WrathToastView.Param>
	{
		// Token: 0x06020647 RID: 132679 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020647")]
		[Address(RVA = "0x1A892E0", Offset = "0x1A87EE0", VA = "0x181A892E0", Slot = "9")]
		protected override void Render(RL05WrathToastView.Param param)
		{
		}

		// Token: 0x06020648 RID: 132680 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020648")]
		[Address(RVA = "0x1A89440", Offset = "0x1A88040", VA = "0x181A89440")]
		public RL05WrathToastView()
		{
		}

		// Token: 0x0402BD9E RID: 179614
		[Token(Token = "0x402BD9E")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Image _icon;

		// Token: 0x0402BD9F RID: 179615
		[Token(Token = "0x402BD9F")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Text _textDesc;

		// Token: 0x0402BDA0 RID: 179616
		[Token(Token = "0x402BDA0")]
		[FieldOffset(Offset = "0x40")]
		private UIPageFinder m_pageFinder;

		// Token: 0x0402BDA1 RID: 179617
		[Token(Token = "0x402BDA1")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0402BDA2 RID: 179618
		[Token(Token = "0x402BDA2")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02005641 RID: 22081
		[Token(Token = "0x2005641")]
		public class Param : NotifyViewParam
		{
			// Token: 0x06020649 RID: 132681 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6020649")]
			[Address(RVA = "0x4E9D30", Offset = "0x4E8930", VA = "0x1804E9D30")]
			public Param()
			{
			}

			// Token: 0x0402BDA3 RID: 179619
			[Token(Token = "0x402BDA3")]
			[FieldOffset(Offset = "0x10")]
			public string topicId;

			// Token: 0x0402BDA4 RID: 179620
			[Token(Token = "0x402BDA4")]
			[FieldOffset(Offset = "0x18")]
			public string iconId;

			// Token: 0x0402BDA5 RID: 179621
			[Token(Token = "0x402BDA5")]
			[FieldOffset(Offset = "0x20")]
			public string text;
		}
	}
}

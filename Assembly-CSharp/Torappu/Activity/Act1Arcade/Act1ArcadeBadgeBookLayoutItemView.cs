using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Activity.Act1Arcade
{
	// Token: 0x02007930 RID: 31024
	[Token(Token = "0x2007930")]
	public class Act1ArcadeBadgeBookLayoutItemView : MonoBehaviour, IHotfixable
	{
		// Token: 0x170065FF RID: 26111
		// (get) Token: 0x0602B870 RID: 178288 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0602B871 RID: 178289 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170065FF")]
		public ScrollRect parentScroll
		{
			[Token(Token = "0x602B870")]
			[Address(RVA = "0x276B810", Offset = "0x276A410", VA = "0x18276B810")]
			[CompilerGenerated]
			private get
			{
				return null;
			}
			[Token(Token = "0x602B871")]
			[Address(RVA = "0x276B870", Offset = "0x276A470", VA = "0x18276B870")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x0602B872 RID: 178290 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B872")]
		[Address(RVA = "0x276B5D0", Offset = "0x276A1D0", VA = "0x18276B5D0")]
		public void Render(string actId, Act1ArcadeBadgeBookItemViewModel model, BadgeBookLayoutMode layoutMode)
		{
		}

		// Token: 0x0602B873 RID: 178291 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B873")]
		[Address(RVA = "0x276B7B0", Offset = "0x276A3B0", VA = "0x18276B7B0")]
		public Act1ArcadeBadgeBookLayoutItemView()
		{
		}

		// Token: 0x0403EF1A RID: 257818
		[Token(Token = "0x403EF1A")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Act1ArcadeBadgeBookItemHeadView _headView;

		// Token: 0x0403EF1B RID: 257819
		[Token(Token = "0x403EF1B")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Act1ArcadeBadgeBookItemTailView _tailView;

		// Token: 0x0403EF1D RID: 257821
		[Token(Token = "0x403EF1D")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_parentScroll;

		// Token: 0x0403EF1E RID: 257822
		[Token(Token = "0x403EF1E")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_parentScroll;

		// Token: 0x0403EF1F RID: 257823
		[Token(Token = "0x403EF1F")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0403EF20 RID: 257824
		[Token(Token = "0x403EF20")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}

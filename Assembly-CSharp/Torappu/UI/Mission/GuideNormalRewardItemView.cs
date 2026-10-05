using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Mission
{
	// Token: 0x0200486A RID: 18538
	[Token(Token = "0x200486A")]
	public class GuideNormalRewardItemView : GuideRewardItemView
	{
		// Token: 0x0601BFFB RID: 114683 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601BFFB")]
		[Address(RVA = "0x154D180", Offset = "0x154BD80", VA = "0x18154D180", Slot = "4")]
		protected override void OnRender()
		{
		}

		// Token: 0x0601BFFC RID: 114684 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601BFFC")]
		[Address(RVA = "0x154D4A0", Offset = "0x154C0A0", VA = "0x18154D4A0")]
		public GuideNormalRewardItemView()
		{
		}

		// Token: 0x04024855 RID: 149589
		[Token(Token = "0x4024855")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Image _imgItemIcon;

		// Token: 0x04024856 RID: 149590
		[Token(Token = "0x4024856")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Text _textGroupName;

		// Token: 0x04024857 RID: 149591
		[Token(Token = "0x4024857")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Text _textItemName;

		// Token: 0x04024858 RID: 149592
		[Token(Token = "0x4024858")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private Text _textItemCount;

		// Token: 0x04024859 RID: 149593
		[Token(Token = "0x4024859")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private GameObject _arrowToDoGo;

		// Token: 0x0402485A RID: 149594
		[Token(Token = "0x402485A")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnRender;

		// Token: 0x0402485B RID: 149595
		[Token(Token = "0x402485B")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}

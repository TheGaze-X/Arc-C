using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Activity.Act1VHalfIdle
{
	// Token: 0x020077D3 RID: 30675
	[Token(Token = "0x20077D3")]
	public class Act1VHalfIdleRecruitDetailItemView : MonoBehaviour, IHotfixable
	{
		// Token: 0x0602B0C5 RID: 176325 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B0C5")]
		[Address(RVA = "0x26DB010", Offset = "0x26D9C10", VA = "0x1826DB010")]
		public void Render(Act1VHalfIdleRecruitDetailDialog.RecruitDetailItemViewModel itemViewModel)
		{
		}

		// Token: 0x0602B0C6 RID: 176326 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B0C6")]
		[Address(RVA = "0x26DB1F0", Offset = "0x26D9DF0", VA = "0x1826DB1F0")]
		public Act1VHalfIdleRecruitDetailItemView()
		{
		}

		// Token: 0x0403E2BE RID: 254654
		[Token(Token = "0x403E2BE")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Text _textName;

		// Token: 0x0403E2BF RID: 254655
		[Token(Token = "0x403E2BF")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Text _textDesc;

		// Token: 0x0403E2C0 RID: 254656
		[Token(Token = "0x403E2C0")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Act1VHalfIdleRecruitDetailItemView.TabIcon[] _tabIcons;

		// Token: 0x0403E2C1 RID: 254657
		[Token(Token = "0x403E2C1")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0403E2C2 RID: 254658
		[Token(Token = "0x403E2C2")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x020077D4 RID: 30676
		[Token(Token = "0x20077D4")]
		[Serializable]
		private class TabIcon : IHotfixable
		{
			// Token: 0x0602B0C7 RID: 176327 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602B0C7")]
			[Address(RVA = "0x26ED180", Offset = "0x26EBD80", VA = "0x1826ED180")]
			public void Render(Act1VHalfIdleGachaPoolType gachaPoolType)
			{
			}

			// Token: 0x0602B0C8 RID: 176328 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602B0C8")]
			[Address(RVA = "0x26ED2E0", Offset = "0x26EBEE0", VA = "0x1826ED2E0")]
			public TabIcon()
			{
			}

			// Token: 0x0403E2C3 RID: 254659
			[Token(Token = "0x403E2C3")]
			[FieldOffset(Offset = "0x10")]
			[SerializeField]
			private Act1VHalfIdleGachaPoolType _gachaPoolType;

			// Token: 0x0403E2C4 RID: 254660
			[Token(Token = "0x403E2C4")]
			[FieldOffset(Offset = "0x18")]
			[SerializeField]
			private GameObject _tabIcon;

			// Token: 0x0403E2C5 RID: 254661
			[Token(Token = "0x403E2C5")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_Render;

			// Token: 0x0403E2C6 RID: 254662
			[Token(Token = "0x403E2C6")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}
	}
}

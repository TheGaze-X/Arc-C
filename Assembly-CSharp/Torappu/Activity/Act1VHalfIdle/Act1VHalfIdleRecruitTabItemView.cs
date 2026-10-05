using System;
using Il2CppDummyDll;
using Torappu.UI;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Activity.Act1VHalfIdle
{
	// Token: 0x020077F5 RID: 30709
	[Token(Token = "0x20077F5")]
	public class Act1VHalfIdleRecruitTabItemView : MonoBehaviour, IHotfixable
	{
		// Token: 0x0602B14F RID: 176463 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B14F")]
		[Address(RVA = "0x26E25D0", Offset = "0x26E11D0", VA = "0x1826E25D0")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0602B150 RID: 176464 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B150")]
		[Address(RVA = "0x26E2290", Offset = "0x26E0E90", VA = "0x1826E2290")]
		public void Render(GachaViewModel gachaViewModel, UITabPager.TabPageGroupViewModel tabPageGroupViewModel)
		{
		}

		// Token: 0x0602B151 RID: 176465 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B151")]
		[Address(RVA = "0x26E21A0", Offset = "0x26E0DA0", VA = "0x1826E21A0")]
		public void OnBtnClicked()
		{
		}

		// Token: 0x0602B152 RID: 176466 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B152")]
		[Address(RVA = "0x26E26D0", Offset = "0x26E12D0", VA = "0x1826E26D0")]
		public Act1VHalfIdleRecruitTabItemView()
		{
		}

		// Token: 0x0403E3FC RID: 254972
		[Token(Token = "0x403E3FC")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private GameObject _pnlDot;

		// Token: 0x0403E3FD RID: 254973
		[Token(Token = "0x403E3FD")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Text _textCount;

		// Token: 0x0403E3FE RID: 254974
		[Token(Token = "0x403E3FE")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Text _textPoolName;

		// Token: 0x0403E3FF RID: 254975
		[Token(Token = "0x403E3FF")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Text _textPoolName2;

		// Token: 0x0403E400 RID: 254976
		[Token(Token = "0x403E400")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Act1VHalfIdleRecruitTabItemView.TabIcon[] _tabIcons;

		// Token: 0x0403E401 RID: 254977
		[Token(Token = "0x403E401")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private UIAnimationLocation _animSelected;

		// Token: 0x0403E402 RID: 254978
		[Token(Token = "0x403E402")]
		[FieldOffset(Offset = "0x50")]
		private string m_cachedTabId;

		// Token: 0x0403E403 RID: 254979
		[Token(Token = "0x403E403")]
		[FieldOffset(Offset = "0x58")]
		private UIStateFinder m_stateFinder;

		// Token: 0x0403E404 RID: 254980
		[Token(Token = "0x403E404")]
		[FieldOffset(Offset = "0x68")]
		private UISwitchTween m_selectedTween;

		// Token: 0x0403E405 RID: 254981
		[Token(Token = "0x403E405")]
		[FieldOffset(Offset = "0x70")]
		private bool m_inited;

		// Token: 0x0403E406 RID: 254982
		[Token(Token = "0x403E406")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0403E407 RID: 254983
		[Token(Token = "0x403E407")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0403E408 RID: 254984
		[Token(Token = "0x403E408")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnBtnClicked;

		// Token: 0x0403E409 RID: 254985
		[Token(Token = "0x403E409")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x020077F6 RID: 30710
		[Token(Token = "0x20077F6")]
		[Serializable]
		private class TabIcon : IHotfixable
		{
			// Token: 0x0602B153 RID: 176467 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602B153")]
			[Address(RVA = "0x26ED200", Offset = "0x26EBE00", VA = "0x1826ED200")]
			public void Render(Act1VHalfIdleGachaPoolType gachaPoolType)
			{
			}

			// Token: 0x0602B154 RID: 176468 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602B154")]
			[Address(RVA = "0x26ED280", Offset = "0x26EBE80", VA = "0x1826ED280")]
			public TabIcon()
			{
			}

			// Token: 0x0403E40A RID: 254986
			[Token(Token = "0x403E40A")]
			[FieldOffset(Offset = "0x10")]
			[SerializeField]
			private Act1VHalfIdleGachaPoolType _gachaPoolType;

			// Token: 0x0403E40B RID: 254987
			[Token(Token = "0x403E40B")]
			[FieldOffset(Offset = "0x18")]
			[SerializeField]
			private GameObject _tabIcon;

			// Token: 0x0403E40C RID: 254988
			[Token(Token = "0x403E40C")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_Render;

			// Token: 0x0403E40D RID: 254989
			[Token(Token = "0x403E40D")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}
	}
}

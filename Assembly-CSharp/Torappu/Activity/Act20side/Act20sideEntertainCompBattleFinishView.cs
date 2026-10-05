using System;
using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using Il2CppDummyDll;
using Torappu.UI;
using Torappu.UI.BattleFinish;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Activity.Act20side
{
	// Token: 0x02007684 RID: 30340
	[Token(Token = "0x2007684")]
	public class Act20sideEntertainCompBattleFinishView : DynBattleFinishView
	{
		// Token: 0x0602AAD1 RID: 174801 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602AAD1")]
		[Address(RVA = "0x26736F0", Offset = "0x26722F0", VA = "0x1826736F0", Slot = "6")]
		protected override void OnInit()
		{
		}

		// Token: 0x0602AAD2 RID: 174802 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602AAD2")]
		[Address(RVA = "0x2673670", Offset = "0x2672270", VA = "0x182673670")]
		public void EventOnViewClicked()
		{
		}

		// Token: 0x0602AAD3 RID: 174803 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602AAD3")]
		[Address(RVA = "0x26740A0", Offset = "0x2672CA0", VA = "0x1826740A0")]
		private void _Render(Act20sideEntertainCompBattleFinishViewModel viewModel)
		{
		}

		// Token: 0x0602AAD4 RID: 174804 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602AAD4")]
		[Address(RVA = "0x2673A50", Offset = "0x2672650", VA = "0x182673A50")]
		private void _Init()
		{
		}

		// Token: 0x0602AAD5 RID: 174805 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602AAD5")]
		[Address(RVA = "0x2673C50", Offset = "0x2672850", VA = "0x182673C50")]
		private void _RenderView(Act20sideEntertainCompBattleFinishViewModel viewModel)
		{
		}

		// Token: 0x0602AAD6 RID: 174806 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602AAD6")]
		[Address(RVA = "0x2673BA0", Offset = "0x26727A0", VA = "0x182673BA0")]
		private IEnumerator _PlayEnterAnim()
		{
			return null;
		}

		// Token: 0x0602AAD7 RID: 174807 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602AAD7")]
		[Address(RVA = "0x2674310", Offset = "0x2672F10", VA = "0x182674310")]
		public Act20sideEntertainCompBattleFinishView()
		{
		}

		// Token: 0x0403D7A7 RID: 251815
		[Token(Token = "0x403D7A7")]
		private const string ANIM_ENTER = "act20side_cart_finish";

		// Token: 0x0403D7A8 RID: 251816
		[Token(Token = "0x403D7A8")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private UIFullScreenImage _imgBlur;

		// Token: 0x0403D7A9 RID: 251817
		[Token(Token = "0x403D7A9")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Text _txtName;

		// Token: 0x0403D7AA RID: 251818
		[Token(Token = "0x403D7AA")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Text _txtPerformanceScore;

		// Token: 0x0403D7AB RID: 251819
		[Token(Token = "0x403D7AB")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Text _txtExpressionScore;

		// Token: 0x0403D7AC RID: 251820
		[Token(Token = "0x403D7AC")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Text _txtOperationScore;

		// Token: 0x0403D7AD RID: 251821
		[Token(Token = "0x403D7AD")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private Text _txtTotalScore;

		// Token: 0x0403D7AE RID: 251822
		[Token(Token = "0x403D7AE")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private UIAtlasImage _imgRank;

		// Token: 0x0403D7AF RID: 251823
		[Token(Token = "0x403D7AF")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private UIAtlasImage _imgRankAnim;

		// Token: 0x0403D7B0 RID: 251824
		[Token(Token = "0x403D7B0")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private GameObject _panelNewRank;

		// Token: 0x0403D7B1 RID: 251825
		[Token(Token = "0x403D7B1")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private List<string> _rankImageName;

		// Token: 0x0403D7B2 RID: 251826
		[Token(Token = "0x403D7B2")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private UIAtlasObject _rankImageObject;

		// Token: 0x0403D7B3 RID: 251827
		[Token(Token = "0x403D7B3")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private AnimationWrapper _animationWrapper;

		// Token: 0x0403D7B4 RID: 251828
		[Token(Token = "0x403D7B4")]
		[FieldOffset(Offset = "0x80")]
		private Tween m_enterTween;

		// Token: 0x0403D7B5 RID: 251829
		[Token(Token = "0x403D7B5")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnInit;

		// Token: 0x0403D7B6 RID: 251830
		[Token(Token = "0x403D7B6")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_EventOnViewClicked;

		// Token: 0x0403D7B7 RID: 251831
		[Token(Token = "0x403D7B7")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__Render;

		// Token: 0x0403D7B8 RID: 251832
		[Token(Token = "0x403D7B8")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__Init;

		// Token: 0x0403D7B9 RID: 251833
		[Token(Token = "0x403D7B9")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__RenderView;

		// Token: 0x0403D7BA RID: 251834
		[Token(Token = "0x403D7BA")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__PlayEnterAnim;

		// Token: 0x0403D7BB RID: 251835
		[Token(Token = "0x403D7BB")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}

using System;
using System.Collections.Generic;
using DG.Tweening;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.ArtMagazine
{
	// Token: 0x0200651B RID: 25883
	[Token(Token = "0x200651B")]
	public class ArtMagazineCoverFirstRewardDialog : UISimpleCompDialog
	{
		// Token: 0x0602533B RID: 152379 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602533B")]
		[Address(RVA = "0x202BCB0", Offset = "0x202A8B0", VA = "0x18202BCB0", Slot = "18")]
		protected override void OnRender(object input)
		{
		}

		// Token: 0x0602533C RID: 152380 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602533C")]
		[Address(RVA = "0x202BC50", Offset = "0x202A850", VA = "0x18202BC50", Slot = "15")]
		protected override UIRenderTextureImage GetBlurTarget()
		{
			return null;
		}

		// Token: 0x0602533D RID: 152381 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602533D")]
		[Address(RVA = "0x202C390", Offset = "0x202AF90", VA = "0x18202C390")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0602533E RID: 152382 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602533E")]
		[Address(RVA = "0x202C7F0", Offset = "0x202B3F0", VA = "0x18202C7F0")]
		private void _RenderLeafView()
		{
		}

		// Token: 0x0602533F RID: 152383 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602533F")]
		[Address(RVA = "0x202C9D0", Offset = "0x202B5D0", VA = "0x18202C9D0")]
		private void _RenderRewards()
		{
		}

		// Token: 0x06025340 RID: 152384 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025340")]
		[Address(RVA = "0x202C180", Offset = "0x202AD80", VA = "0x18202C180")]
		private void _ClaimSysFirstMeetRewards()
		{
		}

		// Token: 0x06025341 RID: 152385 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025341")]
		[Address(RVA = "0x202C560", Offset = "0x202B160", VA = "0x18202C560")]
		private void _OnRewardClaimed(ArtMagazineGetFirstRewardsResponse response)
		{
		}

		// Token: 0x06025342 RID: 152386 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025342")]
		[Address(RVA = "0x202C090", Offset = "0x202AC90", VA = "0x18202C090")]
		private void _CancelOnBackPressed()
		{
		}

		// Token: 0x06025343 RID: 152387 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025343")]
		[Address(RVA = "0x202BA10", Offset = "0x202A610", VA = "0x18202BA10")]
		public void EventOnClaimBtnClick()
		{
		}

		// Token: 0x06025344 RID: 152388 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025344")]
		[Address(RVA = "0x202CBE0", Offset = "0x202B7E0", VA = "0x18202CBE0")]
		public ArtMagazineCoverFirstRewardDialog()
		{
		}

		// Token: 0x06025346 RID: 152390 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6025346")]
		[Address(RVA = "0xE613B0", Offset = "0xE5FFB0", VA = "0x180E613B0")]
		private UIRenderTextureImage <>xLuaBaseProxy_GetBlurTarget()
		{
			return null;
		}

		// Token: 0x040342CB RID: 213707
		[Token(Token = "0x40342CB")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private SimpleLayoutContent _rewardItemContent;

		// Token: 0x040342CC RID: 213708
		[Token(Token = "0x40342CC")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private float _itemCardScale;

		// Token: 0x040342CD RID: 213709
		[Token(Token = "0x40342CD")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private RectTransform _backBtnRt;

		// Token: 0x040342CE RID: 213710
		[Token(Token = "0x40342CE")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		private UIRenderTextureImage _blurImg;

		// Token: 0x040342CF RID: 213711
		[Token(Token = "0x40342CF")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		private ArtMagazineLeafViewHolder _leafViewHolder;

		// Token: 0x040342D0 RID: 213712
		[Token(Token = "0x40342D0")]
		[FieldOffset(Offset = "0x98")]
		[SerializeField]
		private UIAnimationLocation _enterAnim;

		// Token: 0x040342D1 RID: 213713
		[Token(Token = "0x40342D1")]
		[FieldOffset(Offset = "0xA8")]
		private bool m_hasInited;

		// Token: 0x040342D2 RID: 213714
		[Token(Token = "0x40342D2")]
		[FieldOffset(Offset = "0xB0")]
		private ArtMagazineCoverFirstRewardDialog.Adapter m_adapter;

		// Token: 0x040342D3 RID: 213715
		[Token(Token = "0x40342D3")]
		[FieldOffset(Offset = "0xB8")]
		private ArtMagazineLeafViewModel m_leafViewModel;

		// Token: 0x040342D4 RID: 213716
		[Token(Token = "0x40342D4")]
		[FieldOffset(Offset = "0xC0")]
		private List<UIItemViewModel> m_rewardItemList;

		// Token: 0x040342D5 RID: 213717
		[Token(Token = "0x40342D5")]
		[FieldOffset(Offset = "0xC8")]
		private Tween m_animTween;

		// Token: 0x040342D6 RID: 213718
		[Token(Token = "0x40342D6")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnRender;

		// Token: 0x040342D7 RID: 213719
		[Token(Token = "0x40342D7")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_GetBlurTarget;

		// Token: 0x040342D8 RID: 213720
		[Token(Token = "0x40342D8")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x040342D9 RID: 213721
		[Token(Token = "0x40342D9")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__RenderLeafView;

		// Token: 0x040342DA RID: 213722
		[Token(Token = "0x40342DA")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__RenderRewards;

		// Token: 0x040342DB RID: 213723
		[Token(Token = "0x40342DB")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__ClaimSysFirstMeetRewards;

		// Token: 0x040342DC RID: 213724
		[Token(Token = "0x40342DC")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__OnRewardClaimed;

		// Token: 0x040342DD RID: 213725
		[Token(Token = "0x40342DD")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__CancelOnBackPressed;

		// Token: 0x040342DE RID: 213726
		[Token(Token = "0x40342DE")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_EventOnClaimBtnClick;

		// Token: 0x040342DF RID: 213727
		[Token(Token = "0x40342DF")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x0200651C RID: 25884
		[Token(Token = "0x200651C")]
		public class Output
		{
			// Token: 0x06025347 RID: 152391 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6025347")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public Output()
			{
			}

			// Token: 0x040342E0 RID: 213728
			[Token(Token = "0x40342E0")]
			[FieldOffset(Offset = "0x10")]
			public bool needClosePage;
		}

		// Token: 0x0200651D RID: 25885
		[Token(Token = "0x200651D")]
		private class Adapter : SimpleLayoutAdapter
		{
			// Token: 0x06025348 RID: 152392 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6025348")]
			[Address(RVA = "0x2026790", Offset = "0x2025390", VA = "0x182026790")]
			public Adapter(ArtMagazineCoverFirstRewardDialog closure)
			{
			}

			// Token: 0x170057CD RID: 22477
			// (get) Token: 0x06025349 RID: 152393 RVA: 0x000C7008 File Offset: 0x000C5208
			[Token(Token = "0x170057CD")]
			public override int count
			{
				[Token(Token = "0x6025349")]
				[Address(RVA = "0x2026810", Offset = "0x2025410", VA = "0x182026810", Slot = "4")]
				get
				{
					return 0;
				}
			}

			// Token: 0x0602534A RID: 152394 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x602534A")]
			[Address(RVA = "0x2026440", Offset = "0x2025040", VA = "0x182026440", Slot = "5")]
			public override GameObject RenderView(int position, GameObject prefab, Transform parent)
			{
				return null;
			}

			// Token: 0x040342E1 RID: 213729
			[Token(Token = "0x40342E1")]
			[FieldOffset(Offset = "0x20")]
			private ArtMagazineCoverFirstRewardDialog m_closure;

			// Token: 0x040342E2 RID: 213730
			[Token(Token = "0x40342E2")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x040342E3 RID: 213731
			[Token(Token = "0x40342E3")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_get_count;

			// Token: 0x040342E4 RID: 213732
			[Token(Token = "0x40342E4")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_RenderView;
		}
	}
}

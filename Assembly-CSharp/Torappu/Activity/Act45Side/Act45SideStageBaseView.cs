using System;
using DG.Tweening;
using Il2CppDummyDll;
using Torappu.UI;
using UnityEngine;
using XLua;

namespace Torappu.Activity.Act45Side
{
	// Token: 0x020072CC RID: 29388
	[Token(Token = "0x20072CC")]
	public class Act45SideStageBaseView : MonoBehaviour, IHotfixable
	{
		// Token: 0x06029987 RID: 170375 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029987")]
		[Address(RVA = "0x24FCDF0", Offset = "0x24FB9F0", VA = "0x1824FCDF0", Slot = "4")]
		public virtual void Render(bool isActive, Act45SideLiveViewModel viewModel)
		{
		}

		// Token: 0x06029988 RID: 170376 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029988")]
		[Address(RVA = "0x24FCCA0", Offset = "0x24FB8A0", VA = "0x1824FCCA0", Slot = "5")]
		public virtual void OnCurtainOut(bool isActive)
		{
		}

		// Token: 0x06029989 RID: 170377 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029989")]
		[Address(RVA = "0x24FCC40", Offset = "0x24FB840", VA = "0x1824FCC40", Slot = "6")]
		public virtual void OnBgmReplay()
		{
		}

		// Token: 0x0602998A RID: 170378 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602998A")]
		[Address(RVA = "0x24FCEB0", Offset = "0x24FBAB0", VA = "0x1824FCEB0", Slot = "7")]
		protected virtual void _PlayCurtainOutAudio()
		{
		}

		// Token: 0x0602998B RID: 170379 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602998B")]
		[Address(RVA = "0x24FD090", Offset = "0x24FBC90", VA = "0x1824FD090", Slot = "8")]
		protected virtual void _SetUpIfNot(Act45SideLiveViewModel viewModel)
		{
		}

		// Token: 0x0602998C RID: 170380 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602998C")]
		[Address(RVA = "0x24FCF40", Offset = "0x24FBB40", VA = "0x1824FCF40")]
		private void _SetUpFurns(Act45SideLiveViewModel viewModel)
		{
		}

		// Token: 0x0602998D RID: 170381 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602998D")]
		[Address(RVA = "0x24FD220", Offset = "0x24FBE20", VA = "0x1824FD220")]
		public Act45SideStageBaseView()
		{
		}

		// Token: 0x0403B7D9 RID: 243673
		[Token(Token = "0x403B7D9")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Act45SideStageBaseView.Furniture[] _furnitures;

		// Token: 0x0403B7DA RID: 243674
		[Token(Token = "0x403B7DA")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private UIAnimationLocation _curtainOutAnim;

		// Token: 0x0403B7DB RID: 243675
		[Token(Token = "0x403B7DB")]
		[FieldOffset(Offset = "0x30")]
		private bool m_isInited;

		// Token: 0x0403B7DC RID: 243676
		[Token(Token = "0x403B7DC")]
		[FieldOffset(Offset = "0x38")]
		private string m_cachedMusicId;

		// Token: 0x0403B7DD RID: 243677
		[Token(Token = "0x403B7DD")]
		[FieldOffset(Offset = "0x40")]
		private Tween m_curtainOutTween;

		// Token: 0x0403B7DE RID: 243678
		[Token(Token = "0x403B7DE")]
		[FieldOffset(Offset = "0x48")]
		private UIPageFinder m_pageFinder;

		// Token: 0x0403B7DF RID: 243679
		[Token(Token = "0x403B7DF")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0403B7E0 RID: 243680
		[Token(Token = "0x403B7E0")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnCurtainOut;

		// Token: 0x0403B7E1 RID: 243681
		[Token(Token = "0x403B7E1")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnBgmReplay;

		// Token: 0x0403B7E2 RID: 243682
		[Token(Token = "0x403B7E2")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__PlayCurtainOutAudio;

		// Token: 0x0403B7E3 RID: 243683
		[Token(Token = "0x403B7E3")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__SetUpIfNot;

		// Token: 0x0403B7E4 RID: 243684
		[Token(Token = "0x403B7E4")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__SetUpFurns;

		// Token: 0x0403B7E5 RID: 243685
		[Token(Token = "0x403B7E5")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x020072CD RID: 29389
		[Token(Token = "0x20072CD")]
		[Serializable]
		private class Furniture
		{
			// Token: 0x0602998E RID: 170382 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602998E")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public Furniture()
			{
			}

			// Token: 0x0403B7E6 RID: 243686
			[Token(Token = "0x403B7E6")]
			[FieldOffset(Offset = "0x10")]
			public string mailId;

			// Token: 0x0403B7E7 RID: 243687
			[Token(Token = "0x403B7E7")]
			[FieldOffset(Offset = "0x18")]
			public GameObject furniture;
		}
	}
}

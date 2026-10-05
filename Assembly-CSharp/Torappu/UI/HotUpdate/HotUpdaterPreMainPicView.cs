using System;
using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.HotUpdate
{
	// Token: 0x02004A8F RID: 19087
	[Token(Token = "0x2004A8F")]
	public class HotUpdaterPreMainPicView : AbstractHotUpdatePreMainFadeInView
	{
		// Token: 0x170043AB RID: 17323
		// (get) Token: 0x0601CAF4 RID: 117492 RVA: 0x000A90F8 File Offset: 0x000A72F8
		[Token(Token = "0x170043AB")]
		protected override PreMainState state
		{
			[Token(Token = "0x601CAF4")]
			[Address(RVA = "0x162D6B0", Offset = "0x162C2B0", VA = "0x18162D6B0", Slot = "4")]
			get
			{
				return PreMainState.NONE;
			}
		}

		// Token: 0x0601CAF5 RID: 117493 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601CAF5")]
		[Address(RVA = "0x162D210", Offset = "0x162BE10", VA = "0x18162D210")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0601CAF6 RID: 117494 RVA: 0x000A9110 File Offset: 0x000A7310
		[Token(Token = "0x601CAF6")]
		[Address(RVA = "0x162CBE0", Offset = "0x162B7E0", VA = "0x18162CBE0", Slot = "7")]
		protected override bool IsShow(HotUpdatePremainViewModel viewModel)
		{
			return default(bool);
		}

		// Token: 0x0601CAF7 RID: 117495 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601CAF7")]
		[Address(RVA = "0x162CFC0", Offset = "0x162BBC0", VA = "0x18162CFC0", Slot = "5")]
		public override void Render(HotUpdatePremainViewModel viewModel, ILoadAsset assets)
		{
		}

		// Token: 0x0601CAF8 RID: 117496 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601CAF8")]
		[Address(RVA = "0x162CAE0", Offset = "0x162B6E0", VA = "0x18162CAE0", Slot = "6")]
		public override void Clear()
		{
		}

		// Token: 0x0601CAF9 RID: 117497 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601CAF9")]
		[Address(RVA = "0x162CD30", Offset = "0x162B930", VA = "0x18162CD30")]
		public void PlayTargetPic(HotUpdatePremainViewModel.PicInfo picInfo, ILoadAsset assets)
		{
		}

		// Token: 0x0601CAFA RID: 117498 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601CAFA")]
		[Address(RVA = "0x162D330", Offset = "0x162BF30", VA = "0x18162D330")]
		private IEnumerator _PlayPicChange(HotUpdatePremainViewModel.PicInfo picInfo, ILoadAsset assets)
		{
			return null;
		}

		// Token: 0x0601CAFB RID: 117499 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601CAFB")]
		[Address(RVA = "0x162D430", Offset = "0x162C030", VA = "0x18162D430")]
		private void _RenderView(HotUpdatePremainViewModel.PicInfo picInfo, ILoadAsset assets)
		{
		}

		// Token: 0x0601CAFC RID: 117500 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601CAFC")]
		[Address(RVA = "0x162CA60", Offset = "0x162B660", VA = "0x18162CA60")]
		public void ClearCacheImage()
		{
		}

		// Token: 0x0601CAFD RID: 117501 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601CAFD")]
		[Address(RVA = "0x162CC90", Offset = "0x162B890", VA = "0x18162CC90")]
		public void OnPvPlay()
		{
		}

		// Token: 0x0601CAFE RID: 117502 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601CAFE")]
		[Address(RVA = "0x162D610", Offset = "0x162C210", VA = "0x18162D610")]
		public HotUpdaterPreMainPicView()
		{
		}

		// Token: 0x0601CAFF RID: 117503 RVA: 0x000A9128 File Offset: 0x000A7328
		[Token(Token = "0x601CAFF")]
		[Address(RVA = "0x161FB80", Offset = "0x161E780", VA = "0x18161FB80")]
		private bool <>xLuaBaseProxy_IsShow(HotUpdatePremainViewModel P0)
		{
			return default(bool);
		}

		// Token: 0x0601CB00 RID: 117504 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601CB00")]
		[Address(RVA = "0x162C360", Offset = "0x162AF60", VA = "0x18162C360")]
		private void <>xLuaBaseProxy_Render(HotUpdatePremainViewModel P0, ILoadAsset P1)
		{
		}

		// Token: 0x0601CB01 RID: 117505 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601CB01")]
		[Address(RVA = "0x162C350", Offset = "0x162AF50", VA = "0x18162C350")]
		private void <>xLuaBaseProxy_Clear()
		{
		}

		// Token: 0x04025A67 RID: 154215
		[Token(Token = "0x4025A67")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private Image _backImage;

		// Token: 0x04025A68 RID: 154216
		[Token(Token = "0x4025A68")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private Image _logoImg;

		// Token: 0x04025A69 RID: 154217
		[Token(Token = "0x4025A69")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private SimpleLayoutContent _textContent;

		// Token: 0x04025A6A RID: 154218
		[Token(Token = "0x4025A6A")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private GameObject _replayBtn;

		// Token: 0x04025A6B RID: 154219
		[Token(Token = "0x4025A6B")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private GameObject _skinIcon;

		// Token: 0x04025A6C RID: 154220
		[Token(Token = "0x4025A6C")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private UIAnimationLocation _animPicOut;

		// Token: 0x04025A6D RID: 154221
		[Token(Token = "0x4025A6D")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private UIAnimationLocation _animPicIn;

		// Token: 0x04025A6E RID: 154222
		[Token(Token = "0x4025A6E")]
		[FieldOffset(Offset = "0x90")]
		private string m_cachePicId;

		// Token: 0x04025A6F RID: 154223
		[Token(Token = "0x4025A6F")]
		[FieldOffset(Offset = "0x98")]
		private IEnumerator m_tweenCoroutine;

		// Token: 0x04025A70 RID: 154224
		[Token(Token = "0x4025A70")]
		[FieldOffset(Offset = "0xA0")]
		private HotUpdaterPreMainPicView.Adapter m_adapter;

		// Token: 0x04025A71 RID: 154225
		[Token(Token = "0x4025A71")]
		[FieldOffset(Offset = "0xA8")]
		private Tween m_tweenPicOut;

		// Token: 0x04025A72 RID: 154226
		[Token(Token = "0x4025A72")]
		[FieldOffset(Offset = "0xB0")]
		private Tween m_tweenPicIn;

		// Token: 0x04025A73 RID: 154227
		[Token(Token = "0x4025A73")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_state;

		// Token: 0x04025A74 RID: 154228
		[Token(Token = "0x4025A74")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x04025A75 RID: 154229
		[Token(Token = "0x4025A75")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_IsShow;

		// Token: 0x04025A76 RID: 154230
		[Token(Token = "0x4025A76")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x04025A77 RID: 154231
		[Token(Token = "0x4025A77")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_Clear;

		// Token: 0x04025A78 RID: 154232
		[Token(Token = "0x4025A78")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_PlayTargetPic;

		// Token: 0x04025A79 RID: 154233
		[Token(Token = "0x4025A79")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__PlayPicChange;

		// Token: 0x04025A7A RID: 154234
		[Token(Token = "0x4025A7A")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__RenderView;

		// Token: 0x04025A7B RID: 154235
		[Token(Token = "0x4025A7B")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_ClearCacheImage;

		// Token: 0x04025A7C RID: 154236
		[Token(Token = "0x4025A7C")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_OnPvPlay;

		// Token: 0x04025A7D RID: 154237
		[Token(Token = "0x4025A7D")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02004A90 RID: 19088
		[Token(Token = "0x2004A90")]
		private class Adapter : SimpleLayoutAdapter
		{
			// Token: 0x170043AC RID: 17324
			// (get) Token: 0x0601CB02 RID: 117506 RVA: 0x000A9140 File Offset: 0x000A7340
			[Token(Token = "0x170043AC")]
			public override int count
			{
				[Token(Token = "0x601CB02")]
				[Address(RVA = "0x16205F0", Offset = "0x161F1F0", VA = "0x1816205F0", Slot = "4")]
				get
				{
					return 0;
				}
			}

			// Token: 0x0601CB03 RID: 117507 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x601CB03")]
			[Address(RVA = "0x1620270", Offset = "0x161EE70", VA = "0x181620270", Slot = "5")]
			public override GameObject RenderView(int position, GameObject prefab, Transform parent)
			{
				return null;
			}

			// Token: 0x0601CB04 RID: 117508 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601CB04")]
			[Address(RVA = "0x1620480", Offset = "0x161F080", VA = "0x181620480")]
			public Adapter()
			{
			}

			// Token: 0x04025A7E RID: 154238
			[Token(Token = "0x4025A7E")]
			[FieldOffset(Offset = "0x20")]
			public List<string> textList;

			// Token: 0x04025A7F RID: 154239
			[Token(Token = "0x4025A7F")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_get_count;

			// Token: 0x04025A80 RID: 154240
			[Token(Token = "0x4025A80")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_RenderView;

			// Token: 0x04025A81 RID: 154241
			[Token(Token = "0x4025A81")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}
	}
}

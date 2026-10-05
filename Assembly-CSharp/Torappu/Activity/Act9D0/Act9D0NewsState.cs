using System;
using Il2CppDummyDll;
using Torappu.UI;
using UnityEngine;
using XLua;

namespace Torappu.Activity.Act9D0
{
	// Token: 0x0200715C RID: 29020
	[Token(Token = "0x200715C")]
	public class Act9D0NewsState : PopupFloatState
	{
		// Token: 0x0602934A RID: 168778 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602934A")]
		[Address(RVA = "0x249F990", Offset = "0x249E590", VA = "0x18249F990", Slot = "9")]
		public override IStateBean GetCacheBean()
		{
			return null;
		}

		// Token: 0x0602934B RID: 168779 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602934B")]
		[Address(RVA = "0x249F9F0", Offset = "0x249E5F0", VA = "0x18249F9F0", Slot = "14")]
		protected override void OnEnter()
		{
		}

		// Token: 0x0602934C RID: 168780 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602934C")]
		[Address(RVA = "0x249F470", Offset = "0x249E070", VA = "0x18249F470")]
		public void EventOnNewsObjClicked(string newsId)
		{
		}

		// Token: 0x0602934D RID: 168781 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602934D")]
		[Address(RVA = "0x249FB40", Offset = "0x249E740", VA = "0x18249FB40")]
		private void _RenderDetailPart(string newsId)
		{
		}

		// Token: 0x0602934E RID: 168782 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602934E")]
		[Address(RVA = "0x249FCF0", Offset = "0x249E8F0", VA = "0x18249FCF0")]
		private void _ResetAnimation()
		{
		}

		// Token: 0x0602934F RID: 168783 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602934F")]
		[Address(RVA = "0x249F310", Offset = "0x249DF10", VA = "0x18249F310")]
		public void ClosePage()
		{
		}

		// Token: 0x06029350 RID: 168784 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029350")]
		[Address(RVA = "0x249FDA0", Offset = "0x249E9A0", VA = "0x18249FDA0")]
		public Act9D0NewsState()
		{
		}

		// Token: 0x06029351 RID: 168785 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029351")]
		[Address(RVA = "0xE63450", Offset = "0xE62050", VA = "0x180E63450")]
		private void <>xLuaBaseProxy_OnEnter()
		{
		}

		// Token: 0x0403AD46 RID: 240966
		[Token(Token = "0x403AD46")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private Act9D0NewsView _view;

		// Token: 0x0403AD47 RID: 240967
		[Token(Token = "0x403AD47")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private AnimationWrapper _groupAnimation;

		// Token: 0x0403AD48 RID: 240968
		[Token(Token = "0x403AD48")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private AnimationWrapper _detailAnimation;

		// Token: 0x0403AD49 RID: 240969
		[Token(Token = "0x403AD49")]
		[FieldOffset(Offset = "0x88")]
		private Act9D0NewsStateBean m_stateBean;

		// Token: 0x0403AD4A RID: 240970
		[Token(Token = "0x403AD4A")]
		[FieldOffset(Offset = "0x90")]
		private string m_cachedNewsId;

		// Token: 0x0403AD4B RID: 240971
		[Token(Token = "0x403AD4B")]
		private const string NEWS_LIST_ANIM = "news_show";

		// Token: 0x0403AD4C RID: 240972
		[Token(Token = "0x403AD4C")]
		private const string NEWS_DETAIL_ANIM = "news_detail";

		// Token: 0x0403AD4D RID: 240973
		[Token(Token = "0x403AD4D")]
		[FieldOffset(Offset = "0x98")]
		private bool m_detailOut;

		// Token: 0x0403AD4E RID: 240974
		[Token(Token = "0x403AD4E")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetCacheBean;

		// Token: 0x0403AD4F RID: 240975
		[Token(Token = "0x403AD4F")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnEnter;

		// Token: 0x0403AD50 RID: 240976
		[Token(Token = "0x403AD50")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_EventOnNewsObjClicked;

		// Token: 0x0403AD51 RID: 240977
		[Token(Token = "0x403AD51")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__RenderDetailPart;

		// Token: 0x0403AD52 RID: 240978
		[Token(Token = "0x403AD52")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__ResetAnimation;

		// Token: 0x0403AD53 RID: 240979
		[Token(Token = "0x403AD53")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_ClosePage;

		// Token: 0x0403AD54 RID: 240980
		[Token(Token = "0x403AD54")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}

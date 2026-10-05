using System;
using System.Collections.Generic;
using DG.Tweening;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.AVG
{
	// Token: 0x02001EA2 RID: 7842
	[Token(Token = "0x2001EA2")]
	public class AVGImagePanel : ExecutorComponent, IContainsResRefs, IFadeTimeRatio
	{
		// Token: 0x0600C238 RID: 49720 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600C238")]
		[Address(RVA = "0x33F6540", Offset = "0x33F5140", VA = "0x1833F6540", Slot = "8")]
		public override Dictionary<string, ExecutorComponent.Executor> GetExecutors()
		{
			return null;
		}

		// Token: 0x0600C239 RID: 49721 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C239")]
		[Address(RVA = "0x33F6860", Offset = "0x33F5460", VA = "0x1833F6860", Slot = "7")]
		public override void OnReset()
		{
		}

		// Token: 0x0600C23A RID: 49722 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C23A")]
		[Address(RVA = "0x33F69D0", Offset = "0x33F55D0", VA = "0x1833F69D0", Slot = "5")]
		public override void OnStoryBegin(Story story)
		{
		}

		// Token: 0x0600C23B RID: 49723 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600C23B")]
		[Address(RVA = "0x33F6B80", Offset = "0x33F5780", VA = "0x1833F6B80", Slot = "16")]
		protected virtual string PostDisplayKey1()
		{
			return null;
		}

		// Token: 0x0600C23C RID: 49724 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600C23C")]
		[Address(RVA = "0x33F6C00", Offset = "0x33F5800", VA = "0x1833F6C00", Slot = "17")]
		protected virtual string PostDisplayKey2()
		{
			return null;
		}

		// Token: 0x0600C23D RID: 49725 RVA: 0x00047448 File Offset: 0x00045648
		[Token(Token = "0x600C23D")]
		[Address(RVA = "0x33F6740", Offset = "0x33F5340", VA = "0x1833F6740", Slot = "18")]
		protected virtual PostDisplayType GetPostDisplayType()
		{
			return PostDisplayType.NONE;
		}

		// Token: 0x0600C23E RID: 49726 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C23E")]
		[Address(RVA = "0x33F70E0", Offset = "0x33F5CE0", VA = "0x1833F70E0")]
		private void _BindCamEffectTarget()
		{
		}

		// Token: 0x0600C23F RID: 49727 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C23F")]
		[Address(RVA = "0x33F7230", Offset = "0x33F5E30", VA = "0x1833F7230")]
		private void _BindPostDisplay(ref PostDisplayHandler handler, string key, Image image, AVGSceneEffectManager effectMgr)
		{
		}

		// Token: 0x0600C240 RID: 49728 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600C240")]
		[Address(RVA = "0x33F6420", Offset = "0x33F5020", VA = "0x1833F6420", Slot = "19")]
		public virtual AbstractResRefCollecter DontInvoke_PlzImplInternalResRefCollector()
		{
			return null;
		}

		// Token: 0x0600C241 RID: 49729 RVA: 0x00047460 File Offset: 0x00045660
		[Token(Token = "0x600C241")]
		[Address(RVA = "0x33F73D0", Offset = "0x33F5FD0", VA = "0x1833F73D0")]
		private bool _ExecuteImageRotate(Command command)
		{
			return default(bool);
		}

		// Token: 0x0600C242 RID: 49730 RVA: 0x00047478 File Offset: 0x00045678
		[Token(Token = "0x600C242")]
		[Address(RVA = "0x33F7F20", Offset = "0x33F6B20", VA = "0x1833F7F20")]
		protected bool _ExecuteImage(Command command)
		{
			return default(bool);
		}

		// Token: 0x0600C243 RID: 49731 RVA: 0x00047490 File Offset: 0x00045690
		[Token(Token = "0x600C243")]
		[Address(RVA = "0x33F77F0", Offset = "0x33F63F0", VA = "0x1833F77F0")]
		protected bool _ExecuteImageTween(Command command)
		{
			return default(bool);
		}

		// Token: 0x0600C244 RID: 49732 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C244")]
		[Address(RVA = "0x33F64D0", Offset = "0x33F50D0", VA = "0x1833F64D0", Slot = "12")]
		protected override void ForceCommandEnd()
		{
		}

		// Token: 0x0600C245 RID: 49733 RVA: 0x000474A8 File Offset: 0x000456A8
		[Token(Token = "0x600C245")]
		[Address(RVA = "0x33F85E0", Offset = "0x33F71E0", VA = "0x1833F85E0")]
		private bool _LoadImage(Image image, Command command)
		{
			return default(bool);
		}

		// Token: 0x0600C246 RID: 49734 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600C246")]
		[Address(RVA = "0x33F8BF0", Offset = "0x33F77F0", VA = "0x1833F8BF0", Slot = "20")]
		protected virtual Sprite _LoadSprite(string key)
		{
			return null;
		}

		// Token: 0x0600C247 RID: 49735 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C247")]
		[Address(RVA = "0x33F8D70", Offset = "0x33F7970", VA = "0x1833F8D70")]
		private static void _SwapImages(ref Image lhs, ref Image rhs, ref PostDisplayHandler lHandler, ref PostDisplayHandler rHandler)
		{
		}

		// Token: 0x0600C248 RID: 49736 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C248")]
		[Address(RVA = "0x33F8CB0", Offset = "0x33F78B0", VA = "0x1833F8CB0")]
		private static void _ResetImage(Image img)
		{
		}

		// Token: 0x0600C249 RID: 49737 RVA: 0x000474C0 File Offset: 0x000456C0
		[Token(Token = "0x600C249")]
		[Address(RVA = "0x33F7010", Offset = "0x33F5C10", VA = "0x1833F7010")]
		private static Vector2 _AdaptScreenWidth(Vector2 target, Vector2 reference)
		{
			return default(Vector2);
		}

		// Token: 0x0600C24A RID: 49738 RVA: 0x000474D8 File Offset: 0x000456D8
		[Token(Token = "0x600C24A")]
		[Address(RVA = "0x33F6E40", Offset = "0x33F5A40", VA = "0x1833F6E40")]
		private static Vector2 _AdaptScreenHeight(Vector2 target, Vector2 reference)
		{
			return default(Vector2);
		}

		// Token: 0x0600C24B RID: 49739 RVA: 0x000474F0 File Offset: 0x000456F0
		[Token(Token = "0x600C24B")]
		[Address(RVA = "0x33F6F00", Offset = "0x33F5B00", VA = "0x1833F6F00")]
		private static Vector2 _AdaptScreenShowAll(Vector2 target, Vector2 reference)
		{
			return default(Vector2);
		}

		// Token: 0x0600C24C RID: 49740 RVA: 0x00047508 File Offset: 0x00045708
		[Token(Token = "0x600C24C")]
		[Address(RVA = "0x33F6C80", Offset = "0x33F5880", VA = "0x1833F6C80")]
		private static Vector2 _AdaptScreenCoverAll(Vector2 target, Vector2 reference)
		{
			return default(Vector2);
		}

		// Token: 0x0600C24D RID: 49741 RVA: 0x00047520 File Offset: 0x00045720
		[Token(Token = "0x600C24D")]
		[Address(RVA = "0x33F6D90", Offset = "0x33F5990", VA = "0x1833F6D90")]
		private static Vector2 _AdaptScreenFill(Vector2 target, Vector2 reference)
		{
			return default(Vector2);
		}

		// Token: 0x0600C24E RID: 49742 RVA: 0x00047538 File Offset: 0x00045738
		[Token(Token = "0x600C24E")]
		[Address(RVA = "0x33F6360", Offset = "0x33F4F60", VA = "0x1833F6360", Slot = "14")]
		public float CalculateFadetime(float initialFadetime)
		{
			return 0f;
		}

		// Token: 0x0600C24F RID: 49743 RVA: 0x00047550 File Offset: 0x00045750
		[Token(Token = "0x600C24F")]
		[Address(RVA = "0x33F67B0", Offset = "0x33F53B0", VA = "0x1833F67B0", Slot = "15")]
		public bool NeedSkipAnimation(float fadetime)
		{
			return default(bool);
		}

		// Token: 0x0600C250 RID: 49744 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C250")]
		[Address(RVA = "0x33F9150", Offset = "0x33F7D50", VA = "0x1833F9150")]
		public AVGImagePanel()
		{
		}

		// Token: 0x0600C252 RID: 49746 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C252")]
		[Address(RVA = "0x1C5FCF0", Offset = "0x1C5E8F0", VA = "0x181C5FCF0")]
		private void <>xLuaBaseProxy_OnReset()
		{
		}

		// Token: 0x0600C253 RID: 49747 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C253")]
		[Address(RVA = "0x33F0E70", Offset = "0x33EFA70", VA = "0x1833F0E70")]
		private void <>xLuaBaseProxy_OnStoryBegin(Story P0)
		{
		}

		// Token: 0x0400C3F9 RID: 50169
		[Token(Token = "0x400C3F9")]
		[FieldOffset(Offset = "0x0")]
		private static readonly Dictionary<string, Func<Vector2, Vector2, Vector2>> SCREEN_ADAPT_FUNCTION_MAP;

		// Token: 0x0400C3FA RID: 50170
		[Token(Token = "0x400C3FA")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		protected Image _foreImage;

		// Token: 0x0400C3FB RID: 50171
		[Token(Token = "0x400C3FB")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		protected Image _backImage;

		// Token: 0x0400C3FC RID: 50172
		[Token(Token = "0x400C3FC")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		protected Ease _fadeEase;

		// Token: 0x0400C3FD RID: 50173
		[Token(Token = "0x400C3FD")]
		[FieldOffset(Offset = "0x64")]
		[SerializeField]
		protected Vector2 _screenAdaptReferenceResolution;

		// Token: 0x0400C3FE RID: 50174
		[Token(Token = "0x400C3FE")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		protected RectTransform _rectTransform;

		// Token: 0x0400C3FF RID: 50175
		[Token(Token = "0x400C3FF")]
		[FieldOffset(Offset = "0x78")]
		private PostDisplayHandler m_forePostDisplay;

		// Token: 0x0400C400 RID: 50176
		[Token(Token = "0x400C400")]
		[FieldOffset(Offset = "0x80")]
		private PostDisplayHandler m_backPostDisplay;

		// Token: 0x0400C401 RID: 50177
		[Token(Token = "0x400C401")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_GetExecutors;

		// Token: 0x0400C402 RID: 50178
		[Token(Token = "0x400C402")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnReset;

		// Token: 0x0400C403 RID: 50179
		[Token(Token = "0x400C403")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnStoryBegin;

		// Token: 0x0400C404 RID: 50180
		[Token(Token = "0x400C404")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_PostDisplayKey1;

		// Token: 0x0400C405 RID: 50181
		[Token(Token = "0x400C405")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_PostDisplayKey2;

		// Token: 0x0400C406 RID: 50182
		[Token(Token = "0x400C406")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_GetPostDisplayType;

		// Token: 0x0400C407 RID: 50183
		[Token(Token = "0x400C407")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__BindCamEffectTarget;

		// Token: 0x0400C408 RID: 50184
		[Token(Token = "0x400C408")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__BindPostDisplay;

		// Token: 0x0400C409 RID: 50185
		[Token(Token = "0x400C409")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_DontInvoke_PlzImplInternalResRefCollector;

		// Token: 0x0400C40A RID: 50186
		[Token(Token = "0x400C40A")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0__ExecuteImageRotate;

		// Token: 0x0400C40B RID: 50187
		[Token(Token = "0x400C40B")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0__ExecuteImage;

		// Token: 0x0400C40C RID: 50188
		[Token(Token = "0x400C40C")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0__ExecuteImageTween;

		// Token: 0x0400C40D RID: 50189
		[Token(Token = "0x400C40D")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0_ForceCommandEnd;

		// Token: 0x0400C40E RID: 50190
		[Token(Token = "0x400C40E")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0__LoadImage;

		// Token: 0x0400C40F RID: 50191
		[Token(Token = "0x400C40F")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0__LoadSprite;

		// Token: 0x0400C410 RID: 50192
		[Token(Token = "0x400C410")]
		[FieldOffset(Offset = "0x80")]
		private static DelegateBridge __Hotfix0__SwapImages;

		// Token: 0x0400C411 RID: 50193
		[Token(Token = "0x400C411")]
		[FieldOffset(Offset = "0x88")]
		private static DelegateBridge __Hotfix0__ResetImage;

		// Token: 0x0400C412 RID: 50194
		[Token(Token = "0x400C412")]
		[FieldOffset(Offset = "0x90")]
		private static DelegateBridge __Hotfix0__AdaptScreenWidth;

		// Token: 0x0400C413 RID: 50195
		[Token(Token = "0x400C413")]
		[FieldOffset(Offset = "0x98")]
		private static DelegateBridge __Hotfix0__AdaptScreenHeight;

		// Token: 0x0400C414 RID: 50196
		[Token(Token = "0x400C414")]
		[FieldOffset(Offset = "0xA0")]
		private static DelegateBridge __Hotfix0__AdaptScreenShowAll;

		// Token: 0x0400C415 RID: 50197
		[Token(Token = "0x400C415")]
		[FieldOffset(Offset = "0xA8")]
		private static DelegateBridge __Hotfix0__AdaptScreenCoverAll;

		// Token: 0x0400C416 RID: 50198
		[Token(Token = "0x400C416")]
		[FieldOffset(Offset = "0xB0")]
		private static DelegateBridge __Hotfix0__AdaptScreenFill;

		// Token: 0x0400C417 RID: 50199
		[Token(Token = "0x400C417")]
		[FieldOffset(Offset = "0xB8")]
		private static DelegateBridge __Hotfix0_CalculateFadetime;

		// Token: 0x0400C418 RID: 50200
		[Token(Token = "0x400C418")]
		[FieldOffset(Offset = "0xC0")]
		private static DelegateBridge __Hotfix0_NeedSkipAnimation;

		// Token: 0x0400C419 RID: 50201
		[Token(Token = "0x400C419")]
		[FieldOffset(Offset = "0xC8")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02001EA3 RID: 7843
		[Token(Token = "0x2001EA3")]
		private class InternalResRefCollector : AbstractResRefCollecter
		{
			// Token: 0x0600C254 RID: 49748 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600C254")]
			[Address(RVA = "0x3404AA0", Offset = "0x34036A0", VA = "0x183404AA0", Slot = "4")]
			public override void GatherResRefs(Command command, HashSet<string> references)
			{
			}

			// Token: 0x0600C255 RID: 49749 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600C255")]
			[Address(RVA = "0x4E9D30", Offset = "0x4E8930", VA = "0x1804E9D30")]
			public InternalResRefCollector()
			{
			}
		}
	}
}

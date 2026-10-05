using System;
using DG.Tweening;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.CrossAppShare
{
	// Token: 0x020058EF RID: 22767
	[Token(Token = "0x20058EF")]
	public class CrossAppShareRemakeController : MonoBehaviour, IHotfixable
	{
		// Token: 0x17004DEC RID: 19948
		// (get) Token: 0x06021316 RID: 135958 RVA: 0x000B8DE8 File Offset: 0x000B6FE8
		[Token(Token = "0x17004DEC")]
		public Vector2 renderResolution
		{
			[Token(Token = "0x6021316")]
			[Address(RVA = "0x1B769E0", Offset = "0x1B755E0", VA = "0x181B769E0")]
			get
			{
				return default(Vector2);
			}
		}

		// Token: 0x17004DED RID: 19949
		// (get) Token: 0x06021317 RID: 135959 RVA: 0x000B8E00 File Offset: 0x000B7000
		[Token(Token = "0x17004DED")]
		public Vector2 shotResolution
		{
			[Token(Token = "0x6021317")]
			[Address(RVA = "0x1B76A50", Offset = "0x1B75650", VA = "0x181B76A50")]
			get
			{
				return default(Vector2);
			}
		}

		// Token: 0x06021318 RID: 135960 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021318")]
		[Address(RVA = "0x1B766F0", Offset = "0x1B752F0", VA = "0x181B766F0")]
		public void RemakeShareWindow(ICrossAppShareModelCollector modelCollector, ILoadAsset iLoadAsset, ICrossAppShareRemakeAdditionBaseModel additionModel)
		{
		}

		// Token: 0x06021319 RID: 135961 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021319")]
		[Address(RVA = "0x1B765B0", Offset = "0x1B751B0", VA = "0x181B765B0")]
		public void PlayShowAnim()
		{
		}

		// Token: 0x0602131A RID: 135962 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602131A")]
		[Address(RVA = "0x1B76880", Offset = "0x1B75480", VA = "0x181B76880")]
		public void SetRemakeGroupShow(bool isShow)
		{
		}

		// Token: 0x0602131B RID: 135963 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602131B")]
		[Address(RVA = "0x1B76910", Offset = "0x1B75510", VA = "0x181B76910")]
		private void _EnsureCanvasGroupBlockRaycastFalse()
		{
		}

		// Token: 0x0602131C RID: 135964 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602131C")]
		[Address(RVA = "0x1B76980", Offset = "0x1B75580", VA = "0x181B76980")]
		public CrossAppShareRemakeController()
		{
		}

		// Token: 0x0402D368 RID: 185192
		[Token(Token = "0x402D368")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private CrossAppShareRemakeModelApplier _remakeModelApplier;

		// Token: 0x0402D369 RID: 185193
		[Token(Token = "0x402D369")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private CrossAppShareRemakeAdditionBaseView _remakeAdditionView;

		// Token: 0x0402D36A RID: 185194
		[Token(Token = "0x402D36A")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private UIAnimationLocation _showAnim;

		// Token: 0x0402D36B RID: 185195
		[Token(Token = "0x402D36B")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private CanvasGroup _canvasGroup;

		// Token: 0x0402D36C RID: 185196
		[Token(Token = "0x402D36C")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Vector2 _renderResolution;

		// Token: 0x0402D36D RID: 185197
		[Token(Token = "0x402D36D")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private Vector2 _shotResolution;

		// Token: 0x0402D36E RID: 185198
		[Token(Token = "0x402D36E")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private string _showAnimAudioSignalCanBeEmpty;

		// Token: 0x0402D36F RID: 185199
		[Token(Token = "0x402D36F")]
		[FieldOffset(Offset = "0x58")]
		private Tween m_showTween;

		// Token: 0x0402D370 RID: 185200
		[Token(Token = "0x402D370")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_renderResolution;

		// Token: 0x0402D371 RID: 185201
		[Token(Token = "0x402D371")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_shotResolution;

		// Token: 0x0402D372 RID: 185202
		[Token(Token = "0x402D372")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_RemakeShareWindow;

		// Token: 0x0402D373 RID: 185203
		[Token(Token = "0x402D373")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_PlayShowAnim;

		// Token: 0x0402D374 RID: 185204
		[Token(Token = "0x402D374")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_SetRemakeGroupShow;

		// Token: 0x0402D375 RID: 185205
		[Token(Token = "0x402D375")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__EnsureCanvasGroupBlockRaycastFalse;

		// Token: 0x0402D376 RID: 185206
		[Token(Token = "0x402D376")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}

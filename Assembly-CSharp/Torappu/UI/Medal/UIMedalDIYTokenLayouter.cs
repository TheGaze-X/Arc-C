using System;
using System.Collections.Generic;
using DG.Tweening;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.Medal
{
	// Token: 0x0200493A RID: 18746
	[Token(Token = "0x200493A")]
	public class UIMedalDIYTokenLayouter : MonoBehaviour, IHotfixable
	{
		// Token: 0x0601C42A RID: 115754 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C42A")]
		[Address(RVA = "0x15BE2D0", Offset = "0x15BCED0", VA = "0x1815BE2D0")]
		public void Init(string frameId, IMedalDIYContext context)
		{
		}

		// Token: 0x0601C42B RID: 115755 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C42B")]
		[Address(RVA = "0x15BE860", Offset = "0x15BD460", VA = "0x1815BE860")]
		public void UpdateStatus(MedalDIYViewModel viewModel, bool immediately, ref ListDict<string, HexPoint> removedTokens)
		{
		}

		// Token: 0x0601C42C RID: 115756 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601C42C")]
		[Address(RVA = "0x15BE180", Offset = "0x15BCD80", VA = "0x1815BE180")]
		public UIMedalDIYTokenView GetTokenOrCreate(DIYMedalModel model)
		{
			return null;
		}

		// Token: 0x0601C42D RID: 115757 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C42D")]
		[Address(RVA = "0x15BE680", Offset = "0x15BD280", VA = "0x1815BE680")]
		public void SetHexPosition(RectTransform rectTrans, HexPoint hexPoint, bool immediately = true)
		{
		}

		// Token: 0x0601C42E RID: 115758 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601C42E")]
		[Address(RVA = "0x15BE120", Offset = "0x15BCD20", VA = "0x1815BE120")]
		public UIMedalDIYFrame GetFrame()
		{
			return null;
		}

		// Token: 0x170042FC RID: 17148
		// (get) Token: 0x0601C42F RID: 115759 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170042FC")]
		public RectTransform tokenContainer
		{
			[Token(Token = "0x601C42F")]
			[Address(RVA = "0x15BF8A0", Offset = "0x15BE4A0", VA = "0x1815BF8A0")]
			get
			{
				return null;
			}
		}

		// Token: 0x0601C430 RID: 115760 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C430")]
		[Address(RVA = "0x15BDFE0", Offset = "0x15BCBE0", VA = "0x1815BDFE0")]
		public void ClearEvents()
		{
		}

		// Token: 0x0601C431 RID: 115761 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C431")]
		[Address(RVA = "0x15BEDD0", Offset = "0x15BD9D0", VA = "0x1815BEDD0")]
		private void _ClearAllTokens()
		{
		}

		// Token: 0x0601C432 RID: 115762 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C432")]
		[Address(RVA = "0x15BF180", Offset = "0x15BDD80", VA = "0x1815BF180")]
		private void _RemoveToken(UIMedalDIYTokenView token, bool immediately)
		{
		}

		// Token: 0x0601C433 RID: 115763 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601C433")]
		[Address(RVA = "0x15BEF60", Offset = "0x15BDB60", VA = "0x1815BEF60")]
		private UIMedalDIYTokenView _CreateToken(DIYMedalModel model)
		{
			return null;
		}

		// Token: 0x0601C434 RID: 115764 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C434")]
		[Address(RVA = "0x15BF3A0", Offset = "0x15BDFA0", VA = "0x1815BF3A0")]
		private void _TweenViewTo(RectTransform rectTrans, Vector2 targetPos)
		{
		}

		// Token: 0x0601C435 RID: 115765 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C435")]
		[Address(RVA = "0x15BF060", Offset = "0x15BDC60", VA = "0x1815BF060")]
		private static void _PlayAudioWhenViewTweened(RectTransform rectTrans)
		{
		}

		// Token: 0x0601C436 RID: 115766 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C436")]
		[Address(RVA = "0x15BF7A0", Offset = "0x15BE3A0", VA = "0x1815BF7A0")]
		public UIMedalDIYTokenLayouter()
		{
		}

		// Token: 0x04024F76 RID: 151414
		[Token(Token = "0x4024F76")]
		private const float TWEEN_DUR = 0.16f;

		// Token: 0x04024F77 RID: 151415
		[Token(Token = "0x4024F77")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private RectTransform _tokenContainer;

		// Token: 0x04024F78 RID: 151416
		[Token(Token = "0x4024F78")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private RectTransform _frameContainer;

		// Token: 0x04024F79 RID: 151417
		[Token(Token = "0x4024F79")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private RectTransform _validPosContainer;

		// Token: 0x04024F7A RID: 151418
		[Token(Token = "0x4024F7A")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private UIMedalDIYTokenView _tokenPrefab;

		// Token: 0x04024F7B RID: 151419
		[Token(Token = "0x4024F7B")]
		[FieldOffset(Offset = "0x38")]
		private Dictionary<string, UIMedalDIYTokenView> m_tokens;

		// Token: 0x04024F7C RID: 151420
		[Token(Token = "0x4024F7C")]
		[FieldOffset(Offset = "0x40")]
		private Dictionary<RectTransform, Tween> m_medalMoveTweens;

		// Token: 0x04024F7D RID: 151421
		[Token(Token = "0x4024F7D")]
		[FieldOffset(Offset = "0x48")]
		private UIMedalDIYFrame m_frame;

		// Token: 0x04024F7E RID: 151422
		[Token(Token = "0x4024F7E")]
		[FieldOffset(Offset = "0x50")]
		private IMedalDIYContext m_context;

		// Token: 0x04024F7F RID: 151423
		[Token(Token = "0x4024F7F")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Init;

		// Token: 0x04024F80 RID: 151424
		[Token(Token = "0x4024F80")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_UpdateStatus;

		// Token: 0x04024F81 RID: 151425
		[Token(Token = "0x4024F81")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_GetTokenOrCreate;

		// Token: 0x04024F82 RID: 151426
		[Token(Token = "0x4024F82")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_SetHexPosition;

		// Token: 0x04024F83 RID: 151427
		[Token(Token = "0x4024F83")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_GetFrame;

		// Token: 0x04024F84 RID: 151428
		[Token(Token = "0x4024F84")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_get_tokenContainer;

		// Token: 0x04024F85 RID: 151429
		[Token(Token = "0x4024F85")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_ClearEvents;

		// Token: 0x04024F86 RID: 151430
		[Token(Token = "0x4024F86")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__ClearAllTokens;

		// Token: 0x04024F87 RID: 151431
		[Token(Token = "0x4024F87")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__RemoveToken;

		// Token: 0x04024F88 RID: 151432
		[Token(Token = "0x4024F88")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0__CreateToken;

		// Token: 0x04024F89 RID: 151433
		[Token(Token = "0x4024F89")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0__TweenViewTo;

		// Token: 0x04024F8A RID: 151434
		[Token(Token = "0x4024F8A")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0__PlayAudioWhenViewTweened;

		// Token: 0x04024F8B RID: 151435
		[Token(Token = "0x4024F8B")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}

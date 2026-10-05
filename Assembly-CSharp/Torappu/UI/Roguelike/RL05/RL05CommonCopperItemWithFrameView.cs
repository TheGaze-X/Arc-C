using System;
using System.Collections.Generic;
using DG.Tweening;
using Il2CppDummyDll;
using Torappu.UI.Roguelike.Copper;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Roguelike.RL05
{
	// Token: 0x02005583 RID: 21891
	[Token(Token = "0x2005583")]
	public class RL05CommonCopperItemWithFrameView : MonoBehaviour, IHotfixable
	{
		// Token: 0x17004B74 RID: 19316
		// (get) Token: 0x06020296 RID: 131734 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17004B74")]
		public UIColorGraphic graphic
		{
			[Token(Token = "0x6020296")]
			[Address(RVA = "0x1A36AB0", Offset = "0x1A356B0", VA = "0x181A36AB0")]
			get
			{
				return null;
			}
		}

		// Token: 0x06020297 RID: 131735 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020297")]
		[Address(RVA = "0x1A35EC0", Offset = "0x1A34AC0", VA = "0x181A35EC0")]
		public void Render(ILoadAsset assetLoader, IRoguelikeCopperItemModel model, bool showSimpleFrame, bool showParticleFrame, float itemScale = 1f)
		{
		}

		// Token: 0x06020298 RID: 131736 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020298")]
		[Address(RVA = "0x1A361F0", Offset = "0x1A34DF0", VA = "0x181A361F0")]
		public void SetCopperAlpha(float alpha)
		{
		}

		// Token: 0x06020299 RID: 131737 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020299")]
		[Address(RVA = "0x1A35D30", Offset = "0x1A34930", VA = "0x181A35D30")]
		public void PlayBreatheTween()
		{
		}

		// Token: 0x0602029A RID: 131738 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602029A")]
		[Address(RVA = "0x1A36910", Offset = "0x1A35510", VA = "0x181A36910")]
		private void _RenderSimpleFrame(IRoguelikeCopperItemModel model, bool showSimpleFrame)
		{
		}

		// Token: 0x0602029B RID: 131739 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602029B")]
		[Address(RVA = "0x1A365B0", Offset = "0x1A351B0", VA = "0x181A365B0")]
		private void _RenderParticleFrame(IRoguelikeCopperItemModel model, bool showParticleFrame)
		{
		}

		// Token: 0x0602029C RID: 131740 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602029C")]
		[Address(RVA = "0x1A36470", Offset = "0x1A35070", VA = "0x181A36470")]
		private void _RenderCloud(bool isShowCloud, bool isCloudMove)
		{
		}

		// Token: 0x0602029D RID: 131741 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602029D")]
		[Address(RVA = "0x1A36270", Offset = "0x1A34E70", VA = "0x181A36270")]
		private void _InitIfNot(ILoadAsset assetLoader, IRoguelikeCopperItemModel model)
		{
		}

		// Token: 0x0602029E RID: 131742 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602029E")]
		[Address(RVA = "0x1A36A00", Offset = "0x1A35600", VA = "0x181A36A00")]
		public RL05CommonCopperItemWithFrameView()
		{
		}

		// Token: 0x0402B724 RID: 177956
		[Token(Token = "0x402B724")]
		private const float ITEM_CARD_SCALE = 0.722f;

		// Token: 0x0402B725 RID: 177957
		[Token(Token = "0x402B725")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private UIScaler _scaler;

		// Token: 0x0402B726 RID: 177958
		[Token(Token = "0x402B726")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private UIColorGraphic _graphic;

		// Token: 0x0402B727 RID: 177959
		[Token(Token = "0x402B727")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private RectTransform _itemCardContent;

		// Token: 0x0402B728 RID: 177960
		[Token(Token = "0x402B728")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private RectTransform _particleFrameContent;

		// Token: 0x0402B729 RID: 177961
		[Token(Token = "0x402B729")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Image _simpleFrameImg;

		// Token: 0x0402B72A RID: 177962
		[Token(Token = "0x402B72A")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Image _cloudImg1;

		// Token: 0x0402B72B RID: 177963
		[Token(Token = "0x402B72B")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private Image _cloudImg2;

		// Token: 0x0402B72C RID: 177964
		[Token(Token = "0x402B72C")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private Material _cloudMoveMaterial;

		// Token: 0x0402B72D RID: 177965
		[Token(Token = "0x402B72D")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private CanvasGroup _itemGroup;

		// Token: 0x0402B72E RID: 177966
		[Token(Token = "0x402B72E")]
		[FieldOffset(Offset = "0x60")]
		private RoguelikeAbstractCopperItemCard m_itemCard;

		// Token: 0x0402B72F RID: 177967
		[Token(Token = "0x402B72F")]
		[FieldOffset(Offset = "0x68")]
		private RoguelikeCopperResHolder m_copperResHolder;

		// Token: 0x0402B730 RID: 177968
		[Token(Token = "0x402B730")]
		[FieldOffset(Offset = "0x70")]
		private Dictionary<RoguelikeCopperLuckyLevel, GameObject> m_particleFrameDict;

		// Token: 0x0402B731 RID: 177969
		[Token(Token = "0x402B731")]
		[FieldOffset(Offset = "0x78")]
		private bool m_isInited;

		// Token: 0x0402B732 RID: 177970
		[Token(Token = "0x402B732")]
		[FieldOffset(Offset = "0x7C")]
		private RoguelikeCopperLuckyLevel m_copperLuckyLevel;

		// Token: 0x0402B733 RID: 177971
		[Token(Token = "0x402B733")]
		[FieldOffset(Offset = "0x80")]
		private Tween m_itemFadeTween;

		// Token: 0x0402B734 RID: 177972
		[Token(Token = "0x402B734")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_graphic;

		// Token: 0x0402B735 RID: 177973
		[Token(Token = "0x402B735")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0402B736 RID: 177974
		[Token(Token = "0x402B736")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_SetCopperAlpha;

		// Token: 0x0402B737 RID: 177975
		[Token(Token = "0x402B737")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_PlayBreatheTween;

		// Token: 0x0402B738 RID: 177976
		[Token(Token = "0x402B738")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__RenderSimpleFrame;

		// Token: 0x0402B739 RID: 177977
		[Token(Token = "0x402B739")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__RenderParticleFrame;

		// Token: 0x0402B73A RID: 177978
		[Token(Token = "0x402B73A")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__RenderCloud;

		// Token: 0x0402B73B RID: 177979
		[Token(Token = "0x402B73B")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0402B73C RID: 177980
		[Token(Token = "0x402B73C")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}

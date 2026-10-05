using System;
using DG.Tweening;
using Il2CppDummyDll;
using Torappu.Audio;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Firework
{
	// Token: 0x02004E3C RID: 20028
	[Token(Token = "0x2004E3C")]
	public class FireworkPlateSubListItemView : MonoBehaviour, IAudioAnimationPlayerConditionProvider, IHotfixable
	{
		// Token: 0x0601DE9F RID: 122527 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601DE9F")]
		[Address(RVA = "0x1770F30", Offset = "0x176FB30", VA = "0x181770F30")]
		private void _PlayAnimShow(int idx)
		{
		}

		// Token: 0x0601DEA0 RID: 122528 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601DEA0")]
		[Address(RVA = "0x1770950", Offset = "0x176F550", VA = "0x181770950")]
		public void Render(FireworkData.PlateSlotData plateSlotData, FireworkPlateGroupModel groupModel, FireworkPlateGroupViewStyle style, bool isNewGroup)
		{
		}

		// Token: 0x0601DEA1 RID: 122529 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601DEA1")]
		[Address(RVA = "0x1770870", Offset = "0x176F470", VA = "0x181770870")]
		public void RegisterTutorialGo()
		{
		}

		// Token: 0x0601DEA2 RID: 122530 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601DEA2")]
		[Address(RVA = "0x1770780", Offset = "0x176F380", VA = "0x181770780")]
		public void OnClicked()
		{
		}

		// Token: 0x0601DEA3 RID: 122531 RVA: 0x000ACD88 File Offset: 0x000AAF88
		[Token(Token = "0x601DEA3")]
		[Address(RVA = "0x1770720", Offset = "0x176F320", VA = "0x181770720", Slot = "4")]
		public bool CanPlayAudio()
		{
			return default(bool);
		}

		// Token: 0x0601DEA4 RID: 122532 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601DEA4")]
		[Address(RVA = "0x1771090", Offset = "0x176FC90", VA = "0x181771090")]
		public FireworkPlateSubListItemView()
		{
		}

		// Token: 0x04027B1C RID: 162588
		[Token(Token = "0x4027B1C")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private UIAtlasImage _imgBkg;

		// Token: 0x04027B1D RID: 162589
		[Token(Token = "0x4027B1D")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private UIAtlasObject _atlasObject;

		// Token: 0x04027B1E RID: 162590
		[Token(Token = "0x4027B1E")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private string _spriteFilled;

		// Token: 0x04027B1F RID: 162591
		[Token(Token = "0x4027B1F")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private string _spriteNormal;

		// Token: 0x04027B20 RID: 162592
		[Token(Token = "0x4027B20")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Image _imgRange;

		// Token: 0x04027B21 RID: 162593
		[Token(Token = "0x4027B21")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private UIAtlasImage _imgSelectedFrame;

		// Token: 0x04027B22 RID: 162594
		[Token(Token = "0x4027B22")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private GameObject _pnlFilled;

		// Token: 0x04027B23 RID: 162595
		[Token(Token = "0x4027B23")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private GameObject _pnlFilledCheck;

		// Token: 0x04027B24 RID: 162596
		[Token(Token = "0x4027B24")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private UIAnimationLocation _animShow;

		// Token: 0x04027B25 RID: 162597
		[Token(Token = "0x4027B25")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private float _delay;

		// Token: 0x04027B26 RID: 162598
		[Token(Token = "0x4027B26")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private FireworkPlatePieceView _pieceView;

		// Token: 0x04027B27 RID: 162599
		[Token(Token = "0x4027B27")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private GameObject _hintGo;

		// Token: 0x04027B28 RID: 162600
		[Token(Token = "0x4027B28")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private UIAtlasImage _imgRangeCenter;

		// Token: 0x04027B29 RID: 162601
		[Token(Token = "0x4027B29")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		private Button _hotspotGo;

		// Token: 0x04027B2A RID: 162602
		[Token(Token = "0x4027B2A")]
		[FieldOffset(Offset = "0x90")]
		private Tween m_showTween;

		// Token: 0x04027B2B RID: 162603
		[Token(Token = "0x4027B2B")]
		[FieldOffset(Offset = "0x98")]
		private FireworkData.PlateSlotData m_cachedSlotData;

		// Token: 0x04027B2C RID: 162604
		[Token(Token = "0x4027B2C")]
		[FieldOffset(Offset = "0xA0")]
		private UIStateFinder m_stateFinder;

		// Token: 0x04027B2D RID: 162605
		[Token(Token = "0x4027B2D")]
		[FieldOffset(Offset = "0xB0")]
		private bool m_cachedPieceHinted;

		// Token: 0x04027B2E RID: 162606
		[Token(Token = "0x4027B2E")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0__PlayAnimShow;

		// Token: 0x04027B2F RID: 162607
		[Token(Token = "0x4027B2F")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x04027B30 RID: 162608
		[Token(Token = "0x4027B30")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_RegisterTutorialGo;

		// Token: 0x04027B31 RID: 162609
		[Token(Token = "0x4027B31")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnClicked;

		// Token: 0x04027B32 RID: 162610
		[Token(Token = "0x4027B32")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_CanPlayAudio;

		// Token: 0x04027B33 RID: 162611
		[Token(Token = "0x4027B33")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}

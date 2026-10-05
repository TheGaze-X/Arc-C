using System;
using DG.Tweening;
using Il2CppDummyDll;
using Torappu.UI;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.AVG
{
	// Token: 0x02001F4E RID: 8014
	[Token(Token = "0x2001F4E")]
	public class AVGCharacterSlot : MonoBehaviour, IHotfixable
	{
		// Token: 0x1700179A RID: 6042
		// (get) Token: 0x0600C728 RID: 50984 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700179A")]
		public Image currentImage
		{
			[Token(Token = "0x600C728")]
			[Address(RVA = "0x34793A0", Offset = "0x3477FA0", VA = "0x1834793A0")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600C729 RID: 50985 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C729")]
		[Address(RVA = "0x34769C0", Offset = "0x34755C0", VA = "0x1834769C0")]
		public void Set(string key, float duration, Color color)
		{
		}

		// Token: 0x0600C72A RID: 50986 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C72A")]
		[Address(RVA = "0x3476AA0", Offset = "0x34756A0", VA = "0x183476AA0")]
		public void Set(string key, float duration, Color color, bool dontFadeIfSameChar, bool resetOffsetPos = true, float blackStart = 0f, float blackEnd = 0f, CharacterPanel.ECharTransType transType = CharacterPanel.ECharTransType.NONE, bool blackMaskInverse = false)
		{
		}

		// Token: 0x0600C72B RID: 50987 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C72B")]
		[Address(RVA = "0x3476320", Offset = "0x3474F20", VA = "0x183476320")]
		public void Clear(float duration = 0f)
		{
		}

		// Token: 0x0600C72C RID: 50988 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C72C")]
		[Address(RVA = "0x3476290", Offset = "0x3474E90", VA = "0x183476290")]
		public void ClearSelfAndImageHolders()
		{
		}

		// Token: 0x0600C72D RID: 50989 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C72D")]
		[Address(RVA = "0x3476640", Offset = "0x3475240", VA = "0x183476640")]
		public void OnReset()
		{
		}

		// Token: 0x0600C72E RID: 50990 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C72E")]
		[Address(RVA = "0x34768B0", Offset = "0x34754B0", VA = "0x1834768B0")]
		public void SetFocus(bool isFocus, bool forceSibling = false)
		{
		}

		// Token: 0x0600C72F RID: 50991 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C72F")]
		[Address(RVA = "0x34759F0", Offset = "0x34745F0", VA = "0x1834759F0")]
		public void BindPostDisplay(string foreChannel, string backChannel, AVGController.AVGCompBridge bridge)
		{
		}

		// Token: 0x0600C730 RID: 50992 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600C730")]
		[Address(RVA = "0x3476420", Offset = "0x3475020", VA = "0x183476420")]
		public Tween MoveChar(float x, float y, float fadeTime)
		{
			return null;
		}

		// Token: 0x0600C731 RID: 50993 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600C731")]
		[Address(RVA = "0x3475AC0", Offset = "0x34746C0", VA = "0x183475AC0")]
		public Tween CharJump(float x, float y, float jumpPower, int times, float fadeTime)
		{
			return null;
		}

		// Token: 0x0600C732 RID: 50994 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600C732")]
		[Address(RVA = "0x3475E40", Offset = "0x3474A40", VA = "0x183475E40")]
		public Tween CharShake(float shakePower, int times, float fadeTime, int random)
		{
			return null;
		}

		// Token: 0x0600C733 RID: 50995 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600C733")]
		[Address(RVA = "0x3475FA0", Offset = "0x3474BA0", VA = "0x183475FA0")]
		public Tween CharZoom(float xPos, float yPos, float scale, float fadeTime)
		{
			return null;
		}

		// Token: 0x0600C734 RID: 50996 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600C734")]
		[Address(RVA = "0x3476700", Offset = "0x3475300", VA = "0x183476700")]
		public Tween SetCharPos(float x, float y, float fadeTime = 0f)
		{
			return null;
		}

		// Token: 0x0600C735 RID: 50997 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600C735")]
		[Address(RVA = "0x3475C60", Offset = "0x3474860", VA = "0x183475C60")]
		public Tween CharRotate(float angle, float fadeTime, bool inverse = false, int circles = 0)
		{
			return null;
		}

		// Token: 0x0600C736 RID: 50998 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600C736")]
		[Address(RVA = "0x3477D20", Offset = "0x3476920", VA = "0x183477D20")]
		private Tween _GenForeImageTween(Color color, float duration)
		{
			return null;
		}

		// Token: 0x0600C737 RID: 50999 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600C737")]
		[Address(RVA = "0x3477BC0", Offset = "0x34767C0", VA = "0x183477BC0")]
		private Tween _GenBackImageTween(float duration)
		{
			return null;
		}

		// Token: 0x0600C738 RID: 51000 RVA: 0x000489D8 File Offset: 0x00046BD8
		[Token(Token = "0x600C738")]
		[Address(RVA = "0x3477E20", Offset = "0x3476A20", VA = "0x183477E20")]
		private float _GenOriginAlphaWithTransType(CharacterPanel.ECharTransType transType)
		{
			return 0f;
		}

		// Token: 0x0600C739 RID: 51001 RVA: 0x000489F0 File Offset: 0x00046BF0
		[Token(Token = "0x600C739")]
		[Address(RVA = "0x34781B0", Offset = "0x3476DB0", VA = "0x1834781B0")]
		private static bool _LoadImage(AlphaSplitImageHolder imageHolder, string key, CharacterParam param)
		{
			return default(bool);
		}

		// Token: 0x0600C73A RID: 51002 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C73A")]
		[Address(RVA = "0x3478EF0", Offset = "0x3477AF0", VA = "0x183478EF0")]
		private static void _SwapImages(ref Image lhs, ref Image rhs, ref AlphaSplitImageHolder lhsHolder, ref AlphaSplitImageHolder rhsHolder)
		{
		}

		// Token: 0x0600C73B RID: 51003 RVA: 0x00048A08 File Offset: 0x00046C08
		[Token(Token = "0x600C73B")]
		[Address(RVA = "0x3479020", Offset = "0x3477C20", VA = "0x183479020")]
		private static bool _TryParseAlias(ref string key, out string alias)
		{
			return default(bool);
		}

		// Token: 0x0600C73C RID: 51004 RVA: 0x00048A20 File Offset: 0x00046C20
		[Token(Token = "0x600C73C")]
		[Address(RVA = "0x3479230", Offset = "0x3477E30", VA = "0x183479230")]
		private static bool _TryParseIndex(ref string key, out int index)
		{
			return default(bool);
		}

		// Token: 0x0600C73D RID: 51005 RVA: 0x00048A38 File Offset: 0x00046C38
		[Token(Token = "0x600C73D")]
		[Address(RVA = "0x3479130", Offset = "0x3477D30", VA = "0x183479130")]
		private static bool _TryParseBody(ref string key, out int body)
		{
			return default(bool);
		}

		// Token: 0x0600C73E RID: 51006 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600C73E")]
		[Address(RVA = "0x3477EB0", Offset = "0x3476AB0", VA = "0x183477EB0")]
		private static string _GetIdWithoutAliasOrIndex(string key)
		{
			return null;
		}

		// Token: 0x0600C73F RID: 51007 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C73F")]
		[Address(RVA = "0x3475990", Offset = "0x3474590", VA = "0x183475990")]
		private void Awake()
		{
		}

		// Token: 0x0600C740 RID: 51008 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C740")]
		[Address(RVA = "0x3477F70", Offset = "0x3476B70", VA = "0x183477F70")]
		private void _InitImageHolders()
		{
		}

		// Token: 0x0600C741 RID: 51009 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C741")]
		[Address(RVA = "0x3478AC0", Offset = "0x34776C0", VA = "0x183478AC0")]
		private void _ResetLocationAndTween()
		{
		}

		// Token: 0x0600C742 RID: 51010 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600C742")]
		[Address(RVA = "0x34778E0", Offset = "0x34764E0", VA = "0x1834778E0")]
		public Tween SlotMoveChar(Vector2 posFrom, Vector2 posTo, float duration)
		{
			return null;
		}

		// Token: 0x0600C743 RID: 51011 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600C743")]
		[Address(RVA = "0x3477AF0", Offset = "0x34766F0", VA = "0x183477AF0")]
		public Tween SlotSetCharWithParam(AVGCharacterslotPanel.TweenerOptions options, bool resetOffsetPos = false)
		{
			return null;
		}

		// Token: 0x0600C744 RID: 51012 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600C744")]
		[Address(RVA = "0x3478BF0", Offset = "0x34777F0", VA = "0x183478BF0")]
		private Tween _SlotSetCharInternal(AVGCharacterslotPanel.TweenerOptions options, bool resetOffsetPos = false)
		{
			return null;
		}

		// Token: 0x0600C745 RID: 51013 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600C745")]
		[Address(RVA = "0x3476F40", Offset = "0x3475B40", VA = "0x183476F40")]
		public Tween SlotChangeAlpha(float aFrom, float aTo, float duration)
		{
			return null;
		}

		// Token: 0x0600C746 RID: 51014 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600C746")]
		[Address(RVA = "0x3477490", Offset = "0x3476090", VA = "0x183477490")]
		public Tween SlotCleanChar(float duration = 0f)
		{
			return null;
		}

		// Token: 0x0600C747 RID: 51015 RVA: 0x00048A50 File Offset: 0x00046C50
		[Token(Token = "0x600C747")]
		[Address(RVA = "0x3477110", Offset = "0x3475D10", VA = "0x183477110")]
		public bool SlotChangeMask(float bsTarget, float beTarget, float duration, Action onCompete)
		{
			return default(bool);
		}

		// Token: 0x0600C748 RID: 51016 RVA: 0x00048A68 File Offset: 0x00046C68
		[Token(Token = "0x600C748")]
		[Address(RVA = "0x3477650", Offset = "0x3476250", VA = "0x183477650")]
		public bool SlotGlitchTween(string toSetting, float duration, Action onComplete)
		{
			return default(bool);
		}

		// Token: 0x0600C749 RID: 51017 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600C749")]
		[Address(RVA = "0x34780C0", Offset = "0x3476CC0", VA = "0x1834780C0")]
		private AVGGlitchMaterialSettings _LoadGlitchMaterialParam(string settingName)
		{
			return null;
		}

		// Token: 0x0600C74A RID: 51018 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C74A")]
		[Address(RVA = "0x3479330", Offset = "0x3477F30", VA = "0x183479330")]
		public AVGCharacterSlot()
		{
		}

		// Token: 0x0400CCEC RID: 52460
		[Token(Token = "0x400CCEC")]
		public const char INDEX_TOKEN = '#';

		// Token: 0x0400CCED RID: 52461
		[Token(Token = "0x400CCED")]
		public const char ALIAS_TOKEN = '@';

		// Token: 0x0400CCEE RID: 52462
		[Token(Token = "0x400CCEE")]
		public const char BODY_TOKEN = '$';

		// Token: 0x0400CCEF RID: 52463
		[Token(Token = "0x400CCEF")]
		public const string EMPTY_CHARACTER = "char_empty";

		// Token: 0x0400CCF0 RID: 52464
		[Token(Token = "0x400CCF0")]
		private const float ALPHA_ZERO = 0f;

		// Token: 0x0400CCF1 RID: 52465
		[Token(Token = "0x400CCF1")]
		private const float ALPHA_ONE = 1f;

		// Token: 0x0400CCF2 RID: 52466
		[Token(Token = "0x400CCF2")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Image _foreImage;

		// Token: 0x0400CCF3 RID: 52467
		[Token(Token = "0x400CCF3")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Image _backImage;

		// Token: 0x0400CCF4 RID: 52468
		[Token(Token = "0x400CCF4")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private RectTransform _offset;

		// Token: 0x0400CCF5 RID: 52469
		[Token(Token = "0x400CCF5")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private RectTransform _shakeContainer;

		// Token: 0x0400CCF6 RID: 52470
		[Token(Token = "0x400CCF6")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Ease _fadeEase;

		// Token: 0x0400CCF7 RID: 52471
		[Token(Token = "0x400CCF7")]
		[FieldOffset(Offset = "0x40")]
		private string m_currentKey;

		// Token: 0x0400CCF8 RID: 52472
		[Token(Token = "0x400CCF8")]
		[FieldOffset(Offset = "0x48")]
		private float m_currBlackStart;

		// Token: 0x0400CCF9 RID: 52473
		[Token(Token = "0x400CCF9")]
		[FieldOffset(Offset = "0x4C")]
		private float m_currBlackEnd;

		// Token: 0x0400CCFA RID: 52474
		[Token(Token = "0x400CCFA")]
		[FieldOffset(Offset = "0x50")]
		private string m_currentFaceKey;

		// Token: 0x0400CCFB RID: 52475
		[Token(Token = "0x400CCFB")]
		[FieldOffset(Offset = "0x58")]
		private AlphaSplitImageHolder m_foreImageHolder;

		// Token: 0x0400CCFC RID: 52476
		[Token(Token = "0x400CCFC")]
		[FieldOffset(Offset = "0x60")]
		private AlphaSplitImageHolder m_backImageHolder;

		// Token: 0x0400CCFD RID: 52477
		[Token(Token = "0x400CCFD")]
		[FieldOffset(Offset = "0x68")]
		private AVGMaterialTweenWrapper m_maskWrapper;

		// Token: 0x0400CCFE RID: 52478
		[Token(Token = "0x400CCFE")]
		[FieldOffset(Offset = "0x70")]
		private AVGMaterialTweenWrapper m_glitchWrapper;

		// Token: 0x0400CCFF RID: 52479
		[Token(Token = "0x400CCFF")]
		[FieldOffset(Offset = "0x78")]
		private AVGShaderProfile m_profile;

		// Token: 0x0400CD00 RID: 52480
		[Token(Token = "0x400CD00")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_currentImage;

		// Token: 0x0400CD01 RID: 52481
		[Token(Token = "0x400CD01")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_Set;

		// Token: 0x0400CD02 RID: 52482
		[Token(Token = "0x400CD02")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix1_Set;

		// Token: 0x0400CD03 RID: 52483
		[Token(Token = "0x400CD03")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_Clear;

		// Token: 0x0400CD04 RID: 52484
		[Token(Token = "0x400CD04")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_ClearSelfAndImageHolders;

		// Token: 0x0400CD05 RID: 52485
		[Token(Token = "0x400CD05")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_OnReset;

		// Token: 0x0400CD06 RID: 52486
		[Token(Token = "0x400CD06")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_SetFocus;

		// Token: 0x0400CD07 RID: 52487
		[Token(Token = "0x400CD07")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_BindPostDisplay;

		// Token: 0x0400CD08 RID: 52488
		[Token(Token = "0x400CD08")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_MoveChar;

		// Token: 0x0400CD09 RID: 52489
		[Token(Token = "0x400CD09")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_CharJump;

		// Token: 0x0400CD0A RID: 52490
		[Token(Token = "0x400CD0A")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_CharShake;

		// Token: 0x0400CD0B RID: 52491
		[Token(Token = "0x400CD0B")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_CharZoom;

		// Token: 0x0400CD0C RID: 52492
		[Token(Token = "0x400CD0C")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0_SetCharPos;

		// Token: 0x0400CD0D RID: 52493
		[Token(Token = "0x400CD0D")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0_CharRotate;

		// Token: 0x0400CD0E RID: 52494
		[Token(Token = "0x400CD0E")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0__GenForeImageTween;

		// Token: 0x0400CD0F RID: 52495
		[Token(Token = "0x400CD0F")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0__GenBackImageTween;

		// Token: 0x0400CD10 RID: 52496
		[Token(Token = "0x400CD10")]
		[FieldOffset(Offset = "0x80")]
		private static DelegateBridge __Hotfix0__GenOriginAlphaWithTransType;

		// Token: 0x0400CD11 RID: 52497
		[Token(Token = "0x400CD11")]
		[FieldOffset(Offset = "0x88")]
		private static DelegateBridge __Hotfix0__LoadImage;

		// Token: 0x0400CD12 RID: 52498
		[Token(Token = "0x400CD12")]
		[FieldOffset(Offset = "0x90")]
		private static DelegateBridge __Hotfix0__SwapImages;

		// Token: 0x0400CD13 RID: 52499
		[Token(Token = "0x400CD13")]
		[FieldOffset(Offset = "0x98")]
		private static DelegateBridge __Hotfix0__TryParseAlias;

		// Token: 0x0400CD14 RID: 52500
		[Token(Token = "0x400CD14")]
		[FieldOffset(Offset = "0xA0")]
		private static DelegateBridge __Hotfix0__TryParseIndex;

		// Token: 0x0400CD15 RID: 52501
		[Token(Token = "0x400CD15")]
		[FieldOffset(Offset = "0xA8")]
		private static DelegateBridge __Hotfix0__TryParseBody;

		// Token: 0x0400CD16 RID: 52502
		[Token(Token = "0x400CD16")]
		[FieldOffset(Offset = "0xB0")]
		private static DelegateBridge __Hotfix0__GetIdWithoutAliasOrIndex;

		// Token: 0x0400CD17 RID: 52503
		[Token(Token = "0x400CD17")]
		[FieldOffset(Offset = "0xB8")]
		private static DelegateBridge __Hotfix0_Awake;

		// Token: 0x0400CD18 RID: 52504
		[Token(Token = "0x400CD18")]
		[FieldOffset(Offset = "0xC0")]
		private static DelegateBridge __Hotfix0__InitImageHolders;

		// Token: 0x0400CD19 RID: 52505
		[Token(Token = "0x400CD19")]
		[FieldOffset(Offset = "0xC8")]
		private static DelegateBridge __Hotfix0__ResetLocationAndTween;

		// Token: 0x0400CD1A RID: 52506
		[Token(Token = "0x400CD1A")]
		[FieldOffset(Offset = "0xD0")]
		private static DelegateBridge __Hotfix0_SlotMoveChar;

		// Token: 0x0400CD1B RID: 52507
		[Token(Token = "0x400CD1B")]
		[FieldOffset(Offset = "0xD8")]
		private static DelegateBridge __Hotfix0_SlotSetCharWithParam;

		// Token: 0x0400CD1C RID: 52508
		[Token(Token = "0x400CD1C")]
		[FieldOffset(Offset = "0xE0")]
		private static DelegateBridge __Hotfix0__SlotSetCharInternal;

		// Token: 0x0400CD1D RID: 52509
		[Token(Token = "0x400CD1D")]
		[FieldOffset(Offset = "0xE8")]
		private static DelegateBridge __Hotfix0_SlotChangeAlpha;

		// Token: 0x0400CD1E RID: 52510
		[Token(Token = "0x400CD1E")]
		[FieldOffset(Offset = "0xF0")]
		private static DelegateBridge __Hotfix0_SlotCleanChar;

		// Token: 0x0400CD1F RID: 52511
		[Token(Token = "0x400CD1F")]
		[FieldOffset(Offset = "0xF8")]
		private static DelegateBridge __Hotfix0_SlotChangeMask;

		// Token: 0x0400CD20 RID: 52512
		[Token(Token = "0x400CD20")]
		[FieldOffset(Offset = "0x100")]
		private static DelegateBridge __Hotfix0_SlotGlitchTween;

		// Token: 0x0400CD21 RID: 52513
		[Token(Token = "0x400CD21")]
		[FieldOffset(Offset = "0x108")]
		private static DelegateBridge __Hotfix0__LoadGlitchMaterialParam;

		// Token: 0x0400CD22 RID: 52514
		[Token(Token = "0x400CD22")]
		[FieldOffset(Offset = "0x110")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}

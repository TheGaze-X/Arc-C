using System;
using AdvancedInspector;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.CharacterInfo
{
	// Token: 0x02005F57 RID: 24407
	[Token(Token = "0x2005F57")]
	[RequireComponent(typeof(RectTransform))]
	public class CharacterInfoIllustWrapper : MonoBehaviour, IHotfixable
	{
		// Token: 0x06023574 RID: 144756 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023574")]
		[Address(RVA = "0x1DDA180", Offset = "0x1DD8D80", VA = "0x181DDA180")]
		private void Awake()
		{
		}

		// Token: 0x06023575 RID: 144757 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023575")]
		[Address(RVA = "0x1DDA290", Offset = "0x1DD8E90", VA = "0x181DDA290")]
		public void ResetContent(CharacterIllustViewModel viewModel, UICharacterIllustLoader loader, bool forceStatic = false)
		{
		}

		// Token: 0x06023576 RID: 144758 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023576")]
		[Address(RVA = "0x1DDA3D0", Offset = "0x1DD8FD0", VA = "0x181DDA3D0")]
		public void ResetContent(CharUISkinStruct skin, UICharacterIllustLoader loader, bool forceStatic = false)
		{
		}

		// Token: 0x06023577 RID: 144759 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023577")]
		[Address(RVA = "0x1DDA1E0", Offset = "0x1DD8DE0", VA = "0x181DDA1E0")]
		public void ResetContentSkinShopOnly(CharUISkinStruct skin, UICharacterIllustLoader loader)
		{
		}

		// Token: 0x1700538B RID: 21387
		// (get) Token: 0x06023578 RID: 144760 RVA: 0x000C09A8 File Offset: 0x000BEBA8
		// (set) Token: 0x06023579 RID: 144761 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700538B")]
		[Inspect(InspectorLevel.Debug)]
		public float scale
		{
			[Token(Token = "0x6023578")]
			[Address(RVA = "0x1DDB270", Offset = "0x1DD9E70", VA = "0x181DDB270")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6023579")]
			[Address(RVA = "0x1DDB2D0", Offset = "0x1DD9ED0", VA = "0x181DDB2D0")]
			set
			{
			}
		}

		// Token: 0x1700538C RID: 21388
		// (get) Token: 0x0602357A RID: 144762 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700538C")]
		public UICharacterIllust illust
		{
			[Token(Token = "0x602357A")]
			[Address(RVA = "0x1DDB140", Offset = "0x1DD9D40", VA = "0x181DDB140")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700538D RID: 21389
		// (get) Token: 0x0602357B RID: 144763 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700538D")]
		public RectTransform rectTransform
		{
			[Token(Token = "0x602357B")]
			[Address(RVA = "0x1DDB1A0", Offset = "0x1DD9DA0", VA = "0x181DDB1A0")]
			get
			{
				return null;
			}
		}

		// Token: 0x0602357C RID: 144764 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602357C")]
		[Address(RVA = "0x1DDAC30", Offset = "0x1DD9830", VA = "0x181DDAC30")]
		private void _ResetContent(CharUISkinStruct skin, UICharacterIllustLoader loader, bool forceStatic)
		{
		}

		// Token: 0x0602357D RID: 144765 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602357D")]
		[Address(RVA = "0x1DDAA00", Offset = "0x1DD9600", VA = "0x181DDAA00")]
		private void _ResetContent(string npcId, UICharacterIllustLoader loader, IllustNPCResType resFolder, CharUISkinStruct npcIllust)
		{
		}

		// Token: 0x0602357E RID: 144766 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602357E")]
		[Address(RVA = "0x1DDA760", Offset = "0x1DD9360", VA = "0x181DDA760")]
		private void _ResetContentShopOnly(CharUISkinStruct skin, UICharacterIllustLoader loader)
		{
		}

		// Token: 0x0602357F RID: 144767 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602357F")]
		[Address(RVA = "0x1DDA540", Offset = "0x1DD9140", VA = "0x181DDA540")]
		private void _ResetContentInternal(Func<UICharacterIllust> loadIllustFunc)
		{
		}

		// Token: 0x06023580 RID: 144768 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023580")]
		[Address(RVA = "0x1DDAF00", Offset = "0x1DD9B00", VA = "0x181DDAF00")]
		private void _UpdateScale()
		{
		}

		// Token: 0x06023581 RID: 144769 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6023581")]
		[Address(RVA = "0x1DDA490", Offset = "0x1DD9090", VA = "0x181DDA490")]
		private static UICharacterIllustLoader _IllustLoaderFromPage(UICharacterIllustLoader loader)
		{
			return null;
		}

		// Token: 0x06023582 RID: 144770 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023582")]
		[Address(RVA = "0x1DDB080", Offset = "0x1DD9C80", VA = "0x181DDB080")]
		public CharacterInfoIllustWrapper()
		{
		}

		// Token: 0x04030C56 RID: 199766
		[Token(Token = "0x4030C56")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		[Range(0f, 2f)]
		[Tooltip("The initial scale of the illustration")]
		private float _scaleIllustration;

		// Token: 0x04030C57 RID: 199767
		[Token(Token = "0x4030C57")]
		[FieldOffset(Offset = "0x20")]
		private UICharacterIllust m_illust;

		// Token: 0x04030C58 RID: 199768
		[Token(Token = "0x4030C58")]
		[FieldOffset(Offset = "0x28")]
		private RectTransform m_rectTransform;

		// Token: 0x04030C59 RID: 199769
		[Token(Token = "0x4030C59")]
		[FieldOffset(Offset = "0x30")]
		private float m_scale;

		// Token: 0x04030C5A RID: 199770
		[Token(Token = "0x4030C5A")]
		[FieldOffset(Offset = "0x34")]
		private bool m_cacheForceStatic;

		// Token: 0x04030C5B RID: 199771
		[Token(Token = "0x4030C5B")]
		[FieldOffset(Offset = "0x38")]
		private Vector2 m_initScale;

		// Token: 0x04030C5C RID: 199772
		[Token(Token = "0x4030C5C")]
		[FieldOffset(Offset = "0x40")]
		private Vector2 m_initPosition;

		// Token: 0x04030C5D RID: 199773
		[Token(Token = "0x4030C5D")]
		[FieldOffset(Offset = "0x48")]
		private IllustCache m_illustCache;

		// Token: 0x04030C5E RID: 199774
		[Token(Token = "0x4030C5E")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Awake;

		// Token: 0x04030C5F RID: 199775
		[Token(Token = "0x4030C5F")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_ResetContent;

		// Token: 0x04030C60 RID: 199776
		[Token(Token = "0x4030C60")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix1_ResetContent;

		// Token: 0x04030C61 RID: 199777
		[Token(Token = "0x4030C61")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_ResetContentSkinShopOnly;

		// Token: 0x04030C62 RID: 199778
		[Token(Token = "0x4030C62")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_get_scale;

		// Token: 0x04030C63 RID: 199779
		[Token(Token = "0x4030C63")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_set_scale;

		// Token: 0x04030C64 RID: 199780
		[Token(Token = "0x4030C64")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_get_illust;

		// Token: 0x04030C65 RID: 199781
		[Token(Token = "0x4030C65")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_get_rectTransform;

		// Token: 0x04030C66 RID: 199782
		[Token(Token = "0x4030C66")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__ResetContent;

		// Token: 0x04030C67 RID: 199783
		[Token(Token = "0x4030C67")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix1__ResetContent;

		// Token: 0x04030C68 RID: 199784
		[Token(Token = "0x4030C68")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0__ResetContentShopOnly;

		// Token: 0x04030C69 RID: 199785
		[Token(Token = "0x4030C69")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0__ResetContentInternal;

		// Token: 0x04030C6A RID: 199786
		[Token(Token = "0x4030C6A")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0__UpdateScale;

		// Token: 0x04030C6B RID: 199787
		[Token(Token = "0x4030C6B")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0__IllustLoaderFromPage;

		// Token: 0x04030C6C RID: 199788
		[Token(Token = "0x4030C6C")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}

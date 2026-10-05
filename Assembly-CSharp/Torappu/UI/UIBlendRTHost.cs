using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI
{
	// Token: 0x020034B3 RID: 13491
	[Token(Token = "0x20034B3")]
	public class UIBlendRTHost : MonoBehaviour, IHotfixable
	{
		// Token: 0x0601580D RID: 88077 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601580D")]
		[Address(RVA = "0xE08190", Offset = "0xE06D90", VA = "0x180E08190")]
		public void InitWithBlurMode(UIBlendRTHost.BlurOptions options)
		{
		}

		// Token: 0x0601580E RID: 88078 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601580E")]
		[Address(RVA = "0xE080B0", Offset = "0xE06CB0", VA = "0x180E080B0")]
		public void Bind(UIBlendRTImage image)
		{
		}

		// Token: 0x0601580F RID: 88079 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601580F")]
		[Address(RVA = "0xE08840", Offset = "0xE07440", VA = "0x180E08840")]
		public void Unbind(UIBlendRTImage image)
		{
		}

		// Token: 0x06015810 RID: 88080 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6015810")]
		[Address(RVA = "0xE08630", Offset = "0xE07230", VA = "0x180E08630")]
		public Material SelectPropMaterial(UIBlendRTHost.MatOptions options)
		{
			return null;
		}

		// Token: 0x06015811 RID: 88081 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015811")]
		[Address(RVA = "0xE08920", Offset = "0xE07520", VA = "0x180E08920")]
		private void _BindImageWhenInited(UIBlendRTImage image)
		{
		}

		// Token: 0x06015812 RID: 88082 RVA: 0x0008C538 File Offset: 0x0008A738
		[Token(Token = "0x6015812")]
		[Address(RVA = "0xE08AF0", Offset = "0xE076F0", VA = "0x180E08AF0")]
		private BlurScreenTexGenerator.Config _CreateBlurConfig(UIBlendRTHost.BlurOptions options)
		{
			return default(BlurScreenTexGenerator.Config);
		}

		// Token: 0x06015813 RID: 88083 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6015813")]
		[Address(RVA = "0xE09360", Offset = "0xE07F60", VA = "0x180E09360")]
		private Material _LoadMaterial(string path)
		{
			return null;
		}

		// Token: 0x06015814 RID: 88084 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6015814")]
		[Address(RVA = "0xE08E30", Offset = "0xE07A30", VA = "0x180E08E30")]
		private Material _CreateMatByNameIfNot(string shaderName, ref Material curMat)
		{
			return null;
		}

		// Token: 0x06015815 RID: 88085 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6015815")]
		[Address(RVA = "0xE090D0", Offset = "0xE07CD0", VA = "0x180E090D0")]
		private Material _GetOrCreateHighColorImgMat(Material baseMat)
		{
			return null;
		}

		// Token: 0x06015816 RID: 88086 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6015816")]
		[Address(RVA = "0xE092E0", Offset = "0xE07EE0", VA = "0x180E092E0")]
		private Material _GetOrCreateLowColorImgMat(Material baseMat)
		{
			return null;
		}

		// Token: 0x06015817 RID: 88087 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6015817")]
		[Address(RVA = "0xE09050", Offset = "0xE07C50", VA = "0x180E09050")]
		private Material _GetOrCreateAlphaOnlyImgMat(Material baseMat)
		{
			return null;
		}

		// Token: 0x06015818 RID: 88088 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015818")]
		[Address(RVA = "0xE08A70", Offset = "0xE07670", VA = "0x180E08A70")]
		private void _ClearCustomImgMats()
		{
		}

		// Token: 0x06015819 RID: 88089 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6015819")]
		[Address(RVA = "0xE09150", Offset = "0xE07D50", VA = "0x180E09150")]
		private static Material _GetOrCreateImgMat(Material baseMat, float weight, ref Material imgMat)
		{
			return null;
		}

		// Token: 0x0601581A RID: 88090 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601581A")]
		[Address(RVA = "0xE08F80", Offset = "0xE07B80", VA = "0x180E08F80")]
		private static void _DestroyMat(ref Material imgMat)
		{
		}

		// Token: 0x0601581B RID: 88091 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601581B")]
		[Address(RVA = "0xE083C0", Offset = "0xE06FC0", VA = "0x180E083C0")]
		private void OnDestroy()
		{
		}

		// Token: 0x0601581C RID: 88092 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601581C")]
		[Address(RVA = "0xE09440", Offset = "0xE08040", VA = "0x180E09440")]
		private void _OnBlurEnableStateChanged(bool isEnabled)
		{
		}

		// Token: 0x0601581D RID: 88093 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601581D")]
		[Address(RVA = "0xE095E0", Offset = "0xE081E0", VA = "0x180E095E0")]
		public UIBlendRTHost()
		{
		}

		// Token: 0x04019C35 RID: 105525
		[Token(Token = "0x4019C35")]
		private const string MAT_KEY_RGB_WEIGHT = "_RGBWeight";

		// Token: 0x04019C36 RID: 105526
		[Token(Token = "0x4019C36")]
		private const float WEIGHT_HIGH_BLEND = 0.618f;

		// Token: 0x04019C37 RID: 105527
		[Token(Token = "0x4019C37")]
		private const float WEIGHT_LOW_BLEND = 0.382f;

		// Token: 0x04019C38 RID: 105528
		[Token(Token = "0x4019C38")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private BlurScreenTexGenerator _texGenerator;

		// Token: 0x04019C39 RID: 105529
		[Token(Token = "0x4019C39")]
		[FieldOffset(Offset = "0x20")]
		private HashSet<UIBlendRTImage> m_bindedImages;

		// Token: 0x04019C3A RID: 105530
		[Token(Token = "0x4019C3A")]
		[FieldOffset(Offset = "0x28")]
		private bool m_isInited;

		// Token: 0x04019C3B RID: 105531
		[Token(Token = "0x4019C3B")]
		[FieldOffset(Offset = "0x29")]
		private bool m_isRTEnabled;

		// Token: 0x04019C3C RID: 105532
		[Token(Token = "0x4019C3C")]
		[FieldOffset(Offset = "0x30")]
		private Material m_baseImgMat;

		// Token: 0x04019C3D RID: 105533
		[Token(Token = "0x4019C3D")]
		[FieldOffset(Offset = "0x38")]
		private UIAssetLoader.Assets m_loadedAssets;

		// Token: 0x04019C3E RID: 105534
		[Token(Token = "0x4019C3E")]
		[FieldOffset(Offset = "0x40")]
		private bool m_isDestroyed;

		// Token: 0x04019C3F RID: 105535
		[Token(Token = "0x4019C3F")]
		[FieldOffset(Offset = "0x48")]
		private Material m_guassianBlurMat;

		// Token: 0x04019C40 RID: 105536
		[Token(Token = "0x4019C40")]
		[FieldOffset(Offset = "0x50")]
		private Material m_highColorImgMat;

		// Token: 0x04019C41 RID: 105537
		[Token(Token = "0x4019C41")]
		[FieldOffset(Offset = "0x58")]
		private Material m_lowColorImgMat;

		// Token: 0x04019C42 RID: 105538
		[Token(Token = "0x4019C42")]
		[FieldOffset(Offset = "0x60")]
		private Material m_alphaOnlyImgMat;

		// Token: 0x04019C43 RID: 105539
		[Token(Token = "0x4019C43")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_InitWithBlurMode;

		// Token: 0x04019C44 RID: 105540
		[Token(Token = "0x4019C44")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_Bind;

		// Token: 0x04019C45 RID: 105541
		[Token(Token = "0x4019C45")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_Unbind;

		// Token: 0x04019C46 RID: 105542
		[Token(Token = "0x4019C46")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_SelectPropMaterial;

		// Token: 0x04019C47 RID: 105543
		[Token(Token = "0x4019C47")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__BindImageWhenInited;

		// Token: 0x04019C48 RID: 105544
		[Token(Token = "0x4019C48")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__CreateBlurConfig;

		// Token: 0x04019C49 RID: 105545
		[Token(Token = "0x4019C49")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__LoadMaterial;

		// Token: 0x04019C4A RID: 105546
		[Token(Token = "0x4019C4A")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__CreateMatByNameIfNot;

		// Token: 0x04019C4B RID: 105547
		[Token(Token = "0x4019C4B")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__GetOrCreateHighColorImgMat;

		// Token: 0x04019C4C RID: 105548
		[Token(Token = "0x4019C4C")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0__GetOrCreateLowColorImgMat;

		// Token: 0x04019C4D RID: 105549
		[Token(Token = "0x4019C4D")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0__GetOrCreateAlphaOnlyImgMat;

		// Token: 0x04019C4E RID: 105550
		[Token(Token = "0x4019C4E")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0__ClearCustomImgMats;

		// Token: 0x04019C4F RID: 105551
		[Token(Token = "0x4019C4F")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0__GetOrCreateImgMat;

		// Token: 0x04019C50 RID: 105552
		[Token(Token = "0x4019C50")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0__DestroyMat;

		// Token: 0x04019C51 RID: 105553
		[Token(Token = "0x4019C51")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0_OnDestroy;

		// Token: 0x04019C52 RID: 105554
		[Token(Token = "0x4019C52")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0__OnBlurEnableStateChanged;

		// Token: 0x04019C53 RID: 105555
		[Token(Token = "0x4019C53")]
		[FieldOffset(Offset = "0x80")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x020034B4 RID: 13492
		[Token(Token = "0x20034B4")]
		public enum BlendWeight
		{
			// Token: 0x04019C55 RID: 105557
			[Token(Token = "0x4019C55")]
			ZERO,
			// Token: 0x04019C56 RID: 105558
			[Token(Token = "0x4019C56")]
			LOW,
			// Token: 0x04019C57 RID: 105559
			[Token(Token = "0x4019C57")]
			HIGH
		}

		// Token: 0x020034B5 RID: 13493
		[Token(Token = "0x20034B5")]
		public struct MatOptions
		{
			// Token: 0x04019C58 RID: 105560
			[Token(Token = "0x4019C58")]
			[FieldOffset(Offset = "0x0")]
			public UIBlendRTHost.BlendWeight weight;
		}

		// Token: 0x020034B6 RID: 13494
		[Token(Token = "0x20034B6")]
		public struct BlurOptions
		{
			// Token: 0x04019C59 RID: 105561
			[Token(Token = "0x4019C59")]
			[FieldOffset(Offset = "0x0")]
			public int texSize;

			// Token: 0x04019C5A RID: 105562
			[Token(Token = "0x4019C5A")]
			[FieldOffset(Offset = "0x4")]
			public int blurLevel;

			// Token: 0x04019C5B RID: 105563
			[Token(Token = "0x4019C5B")]
			[FieldOffset(Offset = "0x8")]
			public BlurScreenTexGenerator.BlurMode blurMode;

			// Token: 0x04019C5C RID: 105564
			[Token(Token = "0x4019C5C")]
			[FieldOffset(Offset = "0xC")]
			public bool keepCameraTarget;
		}
	}
}

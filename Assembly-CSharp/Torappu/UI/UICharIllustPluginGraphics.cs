using System;
using System.Collections.Generic;
using DG.Tweening;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI
{
	// Token: 0x0200355D RID: 13661
	[Token(Token = "0x200355D")]
	public class UICharIllustPluginGraphics : MonoBehaviour, IHotfixable
	{
		// Token: 0x170033BA RID: 13242
		// (get) Token: 0x06015C4D RID: 89165 RVA: 0x0008DBA0 File Offset: 0x0008BDA0
		[Token(Token = "0x170033BA")]
		public float alpha
		{
			[Token(Token = "0x6015C4D")]
			[Address(RVA = "0xE47B90", Offset = "0xE46790", VA = "0x180E47B90")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x06015C4E RID: 89166 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015C4E")]
		[Address(RVA = "0xE47990", Offset = "0xE46590", VA = "0x180E47990")]
		public void SetColor(Color color)
		{
		}

		// Token: 0x06015C4F RID: 89167 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015C4F")]
		[Address(RVA = "0xE47910", Offset = "0xE46510", VA = "0x180E47910")]
		public void SetAlpha(float pAlpha)
		{
		}

		// Token: 0x170033BB RID: 13243
		// (get) Token: 0x06015C50 RID: 89168 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170033BB")]
		public IList<Graphic> graphics
		{
			[Token(Token = "0x6015C50")]
			[Address(RVA = "0xE47C00", Offset = "0xE46800", VA = "0x180E47C00")]
			get
			{
				return null;
			}
		}

		// Token: 0x06015C51 RID: 89169 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6015C51")]
		[Address(RVA = "0xE477F0", Offset = "0xE463F0", VA = "0x180E477F0")]
		public Tween DOFade(float endValue, float duration)
		{
			return null;
		}

		// Token: 0x06015C52 RID: 89170 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015C52")]
		[Address(RVA = "0xE47890", Offset = "0xE46490", VA = "0x180E47890")]
		public void Disable()
		{
		}

		// Token: 0x06015C53 RID: 89171 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015C53")]
		[Address(RVA = "0xE47B00", Offset = "0xE46700", VA = "0x180E47B00")]
		public UICharIllustPluginGraphics()
		{
		}

		// Token: 0x0401A2DE RID: 107230
		[Token(Token = "0x401A2DE")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Graphic[] _graphics;

		// Token: 0x0401A2DF RID: 107231
		[Token(Token = "0x401A2DF")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private CanvasGroup _alphaHandler;

		// Token: 0x0401A2E0 RID: 107232
		[Token(Token = "0x401A2E0")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_alpha;

		// Token: 0x0401A2E1 RID: 107233
		[Token(Token = "0x401A2E1")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_SetColor;

		// Token: 0x0401A2E2 RID: 107234
		[Token(Token = "0x401A2E2")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_SetAlpha;

		// Token: 0x0401A2E3 RID: 107235
		[Token(Token = "0x401A2E3")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_get_graphics;

		// Token: 0x0401A2E4 RID: 107236
		[Token(Token = "0x401A2E4")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_DOFade;

		// Token: 0x0401A2E5 RID: 107237
		[Token(Token = "0x401A2E5")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_Disable;

		// Token: 0x0401A2E6 RID: 107238
		[Token(Token = "0x401A2E6")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}

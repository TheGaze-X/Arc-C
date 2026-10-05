using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Torappu.UI;
using UnityEngine;
using UnityEngine.UI;

namespace Torappu.AVG
{
	// Token: 0x02001F44 RID: 8004
	[Token(Token = "0x2001F44")]
	public class AlphaSplitImageHolder
	{
		// Token: 0x17001797 RID: 6039
		// (get) Token: 0x0600C6FB RID: 50939 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17001797")]
		public Image image
		{
			[Token(Token = "0x600C6FB")]
			[Address(RVA = "0x4EC5A0", Offset = "0x4EB1A0", VA = "0x1804EC5A0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17001798 RID: 6040
		// (get) Token: 0x0600C6FC RID: 50940 RVA: 0x00048978 File Offset: 0x00046B78
		// (set) Token: 0x0600C6FD RID: 50941 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17001798")]
		public AlphaSplitImageHolder.ShaderLoadType loadType
		{
			[Token(Token = "0x600C6FC")]
			[Address(RVA = "0xC91700", Offset = "0xC90300", VA = "0x180C91700")]
			[CompilerGenerated]
			private get
			{
				return AlphaSplitImageHolder.ShaderLoadType.AVG;
			}
			[Token(Token = "0x600C6FD")]
			[Address(RVA = "0xF82EE0", Offset = "0xF81AE0", VA = "0x180F82EE0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x0600C6FE RID: 50942 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C6FE")]
		[Address(RVA = "0x3487C30", Offset = "0x3486830", VA = "0x183487C30")]
		public void SetSprite(AVGCharacterSpriteHub.SpriteConfig config, AVGCharacterSpriteHub.SpriteConfig faceConfig, CharSpriteConfig spriteConfig)
		{
		}

		// Token: 0x0600C6FF RID: 50943 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C6FF")]
		[Address(RVA = "0x34883E0", Offset = "0x3486FE0", VA = "0x1834883E0")]
		private void _HandleGlitch(CharSpriteConfig config)
		{
		}

		// Token: 0x0600C700 RID: 50944 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C700")]
		[Address(RVA = "0x557D40", Offset = "0x556940", VA = "0x180557D40")]
		public AlphaSplitImageHolder(Image image)
		{
		}

		// Token: 0x0600C701 RID: 50945 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C701")]
		[Address(RVA = "0x3487A50", Offset = "0x3486650", VA = "0x183487A50")]
		public void Clear()
		{
		}

		// Token: 0x0600C702 RID: 50946 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C702")]
		[Address(RVA = "0x3487B50", Offset = "0x3486750", VA = "0x183487B50")]
		public void Reset()
		{
		}

		// Token: 0x0600C703 RID: 50947 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C703")]
		[Address(RVA = "0x3487980", Offset = "0x3486580", VA = "0x183487980")]
		public void BindPostDisplay(string channel, AVGController.AVGCompBridge bridge)
		{
		}

		// Token: 0x17001799 RID: 6041
		// (get) Token: 0x0600C704 RID: 50948 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600C705 RID: 50949 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17001799")]
		public Material charMaterial
		{
			[Token(Token = "0x600C704")]
			[Address(RVA = "0x4E5A80", Offset = "0x4E4680", VA = "0x1804E5A80")]
			get
			{
				return null;
			}
			[Token(Token = "0x600C705")]
			[Address(RVA = "0x4EC670", Offset = "0x4EB270", VA = "0x1804EC670")]
			set
			{
			}
		}

		// Token: 0x0600C706 RID: 50950 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600C706")]
		[Address(RVA = "0x3488280", Offset = "0x3486E80", VA = "0x183488280")]
		private AVGShaderProfile _EnsureProfile()
		{
			return null;
		}

		// Token: 0x0600C707 RID: 50951 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600C707")]
		[Address(RVA = "0x3488500", Offset = "0x3487100", VA = "0x183488500")]
		private AVGShaderProfile _LoadShaderProfile()
		{
			return null;
		}

		// Token: 0x0600C708 RID: 50952 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600C708")]
		[Address(RVA = "0x34884D0", Offset = "0x34870D0", VA = "0x1834884D0")]
		private AVGGlitchMaterialSettings _LoadGlitchMaterialParam(string settingName)
		{
			return null;
		}

		// Token: 0x0400CCA7 RID: 52391
		[Token(Token = "0x400CCA7")]
		[FieldOffset(Offset = "0x10")]
		private Image m_image;

		// Token: 0x0400CCA8 RID: 52392
		[Token(Token = "0x400CCA8")]
		[FieldOffset(Offset = "0x18")]
		private Material m_alphaSplitMaterial;

		// Token: 0x0400CCA9 RID: 52393
		[Token(Token = "0x400CCA9")]
		[FieldOffset(Offset = "0x20")]
		private PostDisplayHandler m_postDisplay;

		// Token: 0x0400CCAA RID: 52394
		[Token(Token = "0x400CCAA")]
		[FieldOffset(Offset = "0x28")]
		private AVGShaderProfile m_profile;

		// Token: 0x02001F45 RID: 8005
		[Token(Token = "0x2001F45")]
		public enum ShaderLoadType
		{
			// Token: 0x0400CCAD RID: 52397
			[Token(Token = "0x400CCAD")]
			AVG,
			// Token: 0x0400CCAE RID: 52398
			[Token(Token = "0x400CCAE")]
			UI
		}
	}
}

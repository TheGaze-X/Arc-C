using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.PostEffect
{
	// Token: 0x0200144A RID: 5194
	[Token(Token = "0x200144A")]
	public class MobileBloom : PostEffectBase
	{
		// Token: 0x17000E5F RID: 3679
		// (get) Token: 0x06007881 RID: 30849 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06007882 RID: 30850 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000E5F")]
		public MobileBloom.Settings settings
		{
			[Token(Token = "0x6007881")]
			[Address(RVA = "0x2539150", Offset = "0x2537D50", VA = "0x182539150")]
			get
			{
				return null;
			}
			[Token(Token = "0x6007882")]
			[Address(RVA = "0x2539220", Offset = "0x2537E20", VA = "0x182539220")]
			set
			{
			}
		}

		// Token: 0x17000E60 RID: 3680
		// (get) Token: 0x06007883 RID: 30851 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000E60")]
		protected override string shaderName
		{
			[Token(Token = "0x6007883")]
			[Address(RVA = "0x25391B0", Offset = "0x2537DB0", VA = "0x1825391B0", Slot = "4")]
			get
			{
				return null;
			}
		}

		// Token: 0x06007884 RID: 30852 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007884")]
		[Address(RVA = "0x2538A00", Offset = "0x2537600", VA = "0x182538A00", Slot = "5")]
		protected override void OnInit()
		{
		}

		// Token: 0x06007885 RID: 30853 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007885")]
		[Address(RVA = "0x2538AB0", Offset = "0x25376B0", VA = "0x182538AB0", Slot = "6")]
		protected override void OnPostEffect(RenderTexture source, RenderTexture destination)
		{
		}

		// Token: 0x06007886 RID: 30854 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007886")]
		[Address(RVA = "0x25390F0", Offset = "0x2537CF0", VA = "0x1825390F0")]
		public MobileBloom()
		{
		}

		// Token: 0x04007636 RID: 30262
		[Token(Token = "0x4007636")]
		private const string SHADER_NAME = "Hidden/Torappu/PostEffect/MobileBloom";

		// Token: 0x04007637 RID: 30263
		[Token(Token = "0x4007637")]
		private const string KEYWORD_FASTEST_BLUR_ON = "FASTEST_BLUR_ON";

		// Token: 0x04007638 RID: 30264
		[Token(Token = "0x4007638")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private MobileBloom.Settings _settings;

		// Token: 0x04007639 RID: 30265
		[Token(Token = "0x4007639")]
		[FieldOffset(Offset = "0x58")]
		private int m_thresholdShaderId;

		// Token: 0x0400763A RID: 30266
		[Token(Token = "0x400763A")]
		[FieldOffset(Offset = "0x5C")]
		private int m_parameterShaderId;

		// Token: 0x0400763B RID: 30267
		[Token(Token = "0x400763B")]
		[FieldOffset(Offset = "0x60")]
		private int m_bloomTexShaderId;

		// Token: 0x0400763C RID: 30268
		[Token(Token = "0x400763C")]
		[FieldOffset(Offset = "0x64")]
		private MobileBloom.BlurQuality? m_cachedBlurQuality;

		// Token: 0x0400763D RID: 30269
		[Token(Token = "0x400763D")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_settings;

		// Token: 0x0400763E RID: 30270
		[Token(Token = "0x400763E")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_settings;

		// Token: 0x0400763F RID: 30271
		[Token(Token = "0x400763F")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_shaderName;

		// Token: 0x04007640 RID: 30272
		[Token(Token = "0x4007640")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnInit;

		// Token: 0x04007641 RID: 30273
		[Token(Token = "0x4007641")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_OnPostEffect;

		// Token: 0x04007642 RID: 30274
		[Token(Token = "0x4007642")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x0200144B RID: 5195
		[Token(Token = "0x200144B")]
		public enum BloomScreenBlendMode
		{
			// Token: 0x04007644 RID: 30276
			[Token(Token = "0x4007644")]
			Screen,
			// Token: 0x04007645 RID: 30277
			[Token(Token = "0x4007645")]
			Add
		}

		// Token: 0x0200144C RID: 5196
		[Token(Token = "0x200144C")]
		public enum BlurQuality
		{
			// Token: 0x04007647 RID: 30279
			[Token(Token = "0x4007647")]
			STANDARD,
			// Token: 0x04007648 RID: 30280
			[Token(Token = "0x4007648")]
			FASTEST
		}

		// Token: 0x0200144D RID: 5197
		[Token(Token = "0x200144D")]
		[Serializable]
		public class Settings
		{
			// Token: 0x06007887 RID: 30855 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007887")]
			[Address(RVA = "0x253AA90", Offset = "0x2539690", VA = "0x18253AA90")]
			public Settings()
			{
			}

			// Token: 0x04007649 RID: 30281
			[Token(Token = "0x4007649")]
			[FieldOffset(Offset = "0x10")]
			[SerializeField]
			public MobileBloom.BloomScreenBlendMode screenBlendMode;

			// Token: 0x0400764A RID: 30282
			[Token(Token = "0x400764A")]
			[FieldOffset(Offset = "0x14")]
			[SerializeField]
			[Range(0f, 10f)]
			public float intensity;

			// Token: 0x0400764B RID: 30283
			[Token(Token = "0x400764B")]
			[FieldOffset(Offset = "0x18")]
			[SerializeField]
			public Color blendColor;

			// Token: 0x0400764C RID: 30284
			[Token(Token = "0x400764C")]
			[FieldOffset(Offset = "0x28")]
			[SerializeField]
			[Range(0f, 1f)]
			public float threshold;

			// Token: 0x0400764D RID: 30285
			[Token(Token = "0x400764D")]
			[FieldOffset(Offset = "0x2C")]
			[SerializeField]
			public Color thresholdColor;

			// Token: 0x0400764E RID: 30286
			[Token(Token = "0x400764E")]
			[FieldOffset(Offset = "0x3C")]
			[SerializeField]
			public MobileBloom.BlurQuality blurQuality;

			// Token: 0x0400764F RID: 30287
			[Token(Token = "0x400764F")]
			[FieldOffset(Offset = "0x40")]
			[SerializeField]
			public float sepBlurSpread;

			// Token: 0x04007650 RID: 30288
			[Token(Token = "0x4007650")]
			[FieldOffset(Offset = "0x44")]
			[SerializeField]
			[Range(1f, 4f)]
			public int blurIterations;

			// Token: 0x04007651 RID: 30289
			[Token(Token = "0x4007651")]
			[FieldOffset(Offset = "0x48")]
			[SerializeField]
			[Range(4f, 6f)]
			public int downSampleDivider;
		}
	}
}

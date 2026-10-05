using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.PostEffect
{
	// Token: 0x02001451 RID: 5201
	[Token(Token = "0x2001451")]
	public class MobileBlurE : PostEffectBaseE
	{
		// Token: 0x17000E63 RID: 3683
		// (get) Token: 0x0600788F RID: 30863 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06007890 RID: 30864 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000E63")]
		public MobileBlurE.Settings settings
		{
			[Token(Token = "0x600788F")]
			[Address(RVA = "0x25398F0", Offset = "0x25384F0", VA = "0x1825398F0")]
			get
			{
				return null;
			}
			[Token(Token = "0x6007890")]
			[Address(RVA = "0x25399C0", Offset = "0x25385C0", VA = "0x1825399C0")]
			set
			{
			}
		}

		// Token: 0x17000E64 RID: 3684
		// (get) Token: 0x06007891 RID: 30865 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000E64")]
		protected override string shaderName
		{
			[Token(Token = "0x6007891")]
			[Address(RVA = "0x2539950", Offset = "0x2538550", VA = "0x182539950", Slot = "4")]
			get
			{
				return null;
			}
		}

		// Token: 0x06007892 RID: 30866 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007892")]
		[Address(RVA = "0x25392A0", Offset = "0x2537EA0", VA = "0x1825392A0", Slot = "5")]
		protected override void OnInit()
		{
		}

		// Token: 0x06007893 RID: 30867 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007893")]
		[Address(RVA = "0x2539330", Offset = "0x2537F30", VA = "0x182539330", Slot = "6")]
		protected override void OnPostEffect(RenderTexture source, RenderTexture destination)
		{
		}

		// Token: 0x06007894 RID: 30868 RVA: 0x00036510 File Offset: 0x00034710
		[Token(Token = "0x6007894")]
		[Address(RVA = "0x2539820", Offset = "0x2538420", VA = "0x182539820")]
		private int _GetPassOffset(MobileBlurE.BlurType blurType)
		{
			return 0;
		}

		// Token: 0x06007895 RID: 30869 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007895")]
		[Address(RVA = "0x2539890", Offset = "0x2538490", VA = "0x182539890")]
		public MobileBlurE()
		{
		}

		// Token: 0x04007663 RID: 30307
		[Token(Token = "0x4007663")]
		public const string SHADER_NAME = "Hidden/Torappu/PostEffect/MobileBlurWithMask";

		// Token: 0x04007664 RID: 30308
		[Token(Token = "0x4007664")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private MobileBlurE.Settings _settings;

		// Token: 0x04007665 RID: 30309
		[Token(Token = "0x4007665")]
		[FieldOffset(Offset = "0x58")]
		private int m_parameterShaderId;

		// Token: 0x04007666 RID: 30310
		[Token(Token = "0x4007666")]
		[FieldOffset(Offset = "0x5C")]
		private int m_maskShaderId;

		// Token: 0x04007667 RID: 30311
		[Token(Token = "0x4007667")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_settings;

		// Token: 0x04007668 RID: 30312
		[Token(Token = "0x4007668")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_settings;

		// Token: 0x04007669 RID: 30313
		[Token(Token = "0x4007669")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_shaderName;

		// Token: 0x0400766A RID: 30314
		[Token(Token = "0x400766A")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnInit;

		// Token: 0x0400766B RID: 30315
		[Token(Token = "0x400766B")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_OnPostEffect;

		// Token: 0x0400766C RID: 30316
		[Token(Token = "0x400766C")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__GetPassOffset;

		// Token: 0x0400766D RID: 30317
		[Token(Token = "0x400766D")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02001452 RID: 5202
		[Token(Token = "0x2001452")]
		public enum BlurType
		{
			// Token: 0x0400766F RID: 30319
			[Token(Token = "0x400766F")]
			StandardGauss,
			// Token: 0x04007670 RID: 30320
			[Token(Token = "0x4007670")]
			SgxGauss,
			// Token: 0x04007671 RID: 30321
			[Token(Token = "0x4007671")]
			GaussWithAlpha
		}

		// Token: 0x02001453 RID: 5203
		[Token(Token = "0x2001453")]
		[Serializable]
		public class Settings
		{
			// Token: 0x06007896 RID: 30870 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007896")]
			[Address(RVA = "0x253AAD0", Offset = "0x25396D0", VA = "0x18253AAD0")]
			public Settings()
			{
			}

			// Token: 0x04007672 RID: 30322
			[Token(Token = "0x4007672")]
			[FieldOffset(Offset = "0x10")]
			[SerializeField]
			[Range(0f, 2f)]
			public int downsample;

			// Token: 0x04007673 RID: 30323
			[Token(Token = "0x4007673")]
			[FieldOffset(Offset = "0x14")]
			[SerializeField]
			[Range(0f, 10f)]
			public float blurSize;

			// Token: 0x04007674 RID: 30324
			[Token(Token = "0x4007674")]
			[FieldOffset(Offset = "0x18")]
			[SerializeField]
			[Range(1f, 4f)]
			public int blurIterations;

			// Token: 0x04007675 RID: 30325
			[Token(Token = "0x4007675")]
			[FieldOffset(Offset = "0x1C")]
			[SerializeField]
			public MobileBlurE.BlurType blurType;

			// Token: 0x04007676 RID: 30326
			[Token(Token = "0x4007676")]
			[FieldOffset(Offset = "0x20")]
			[SerializeField]
			public Texture mask;
		}
	}
}

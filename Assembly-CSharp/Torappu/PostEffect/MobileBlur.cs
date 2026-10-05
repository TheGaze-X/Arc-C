using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.PostEffect
{
	// Token: 0x0200144E RID: 5198
	[Token(Token = "0x200144E")]
	public class MobileBlur : PostEffectBase
	{
		// Token: 0x17000E61 RID: 3681
		// (get) Token: 0x06007888 RID: 30856 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06007889 RID: 30857 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000E61")]
		public MobileBlur.Settings settings
		{
			[Token(Token = "0x6007888")]
			[Address(RVA = "0x2539F50", Offset = "0x2538B50", VA = "0x182539F50")]
			get
			{
				return null;
			}
			[Token(Token = "0x6007889")]
			[Address(RVA = "0x253A020", Offset = "0x2538C20", VA = "0x18253A020")]
			set
			{
			}
		}

		// Token: 0x17000E62 RID: 3682
		// (get) Token: 0x0600788A RID: 30858 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000E62")]
		protected override string shaderName
		{
			[Token(Token = "0x600788A")]
			[Address(RVA = "0x2539FB0", Offset = "0x2538BB0", VA = "0x182539FB0", Slot = "4")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600788B RID: 30859 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600788B")]
		[Address(RVA = "0x2539A40", Offset = "0x2538640", VA = "0x182539A40", Slot = "5")]
		protected override void OnInit()
		{
		}

		// Token: 0x0600788C RID: 30860 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600788C")]
		[Address(RVA = "0x2539AB0", Offset = "0x25386B0", VA = "0x182539AB0", Slot = "6")]
		protected override void OnPostEffect(RenderTexture source, RenderTexture destination)
		{
		}

		// Token: 0x0600788D RID: 30861 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600788D")]
		[Address(RVA = "0x2539EF0", Offset = "0x2538AF0", VA = "0x182539EF0")]
		public MobileBlur()
		{
		}

		// Token: 0x04007652 RID: 30290
		[Token(Token = "0x4007652")]
		public const string SHADER_NAME = "Hidden/Torappu/PostEffect/MobileBlur";

		// Token: 0x04007653 RID: 30291
		[Token(Token = "0x4007653")]
		public const string PARAM_BLUR_SIZE = "_Parameter";

		// Token: 0x04007654 RID: 30292
		[Token(Token = "0x4007654")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private MobileBlur.Settings _settings;

		// Token: 0x04007655 RID: 30293
		[Token(Token = "0x4007655")]
		[FieldOffset(Offset = "0x58")]
		private int m_parameterShaderId;

		// Token: 0x04007656 RID: 30294
		[Token(Token = "0x4007656")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_settings;

		// Token: 0x04007657 RID: 30295
		[Token(Token = "0x4007657")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_settings;

		// Token: 0x04007658 RID: 30296
		[Token(Token = "0x4007658")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_shaderName;

		// Token: 0x04007659 RID: 30297
		[Token(Token = "0x4007659")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnInit;

		// Token: 0x0400765A RID: 30298
		[Token(Token = "0x400765A")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_OnPostEffect;

		// Token: 0x0400765B RID: 30299
		[Token(Token = "0x400765B")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x0200144F RID: 5199
		[Token(Token = "0x200144F")]
		public enum BlurType
		{
			// Token: 0x0400765D RID: 30301
			[Token(Token = "0x400765D")]
			StandardGauss,
			// Token: 0x0400765E RID: 30302
			[Token(Token = "0x400765E")]
			SgxGauss
		}

		// Token: 0x02001450 RID: 5200
		[Token(Token = "0x2001450")]
		[Serializable]
		public class Settings
		{
			// Token: 0x0600788E RID: 30862 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600788E")]
			[Address(RVA = "0x253AAD0", Offset = "0x25396D0", VA = "0x18253AAD0")]
			public Settings()
			{
			}

			// Token: 0x0400765F RID: 30303
			[Token(Token = "0x400765F")]
			[FieldOffset(Offset = "0x10")]
			[SerializeField]
			[Range(0f, 2f)]
			public int downsample;

			// Token: 0x04007660 RID: 30304
			[Token(Token = "0x4007660")]
			[FieldOffset(Offset = "0x14")]
			[SerializeField]
			[Range(0f, 10f)]
			public float blurSize;

			// Token: 0x04007661 RID: 30305
			[Token(Token = "0x4007661")]
			[FieldOffset(Offset = "0x18")]
			[SerializeField]
			[Range(1f, 4f)]
			public int blurIterations;

			// Token: 0x04007662 RID: 30306
			[Token(Token = "0x4007662")]
			[FieldOffset(Offset = "0x1C")]
			[SerializeField]
			public MobileBlur.BlurType blurType;
		}
	}
}

using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.PostEffect
{
	// Token: 0x02001454 RID: 5204
	[Token(Token = "0x2001454")]
	public class MobileFishEye : PostEffectBaseE
	{
		// Token: 0x17000E65 RID: 3685
		// (get) Token: 0x06007897 RID: 30871 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06007898 RID: 30872 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000E65")]
		public MobileFishEye.Settings settings
		{
			[Token(Token = "0x6007897")]
			[Address(RVA = "0x263C7C0", Offset = "0x263B3C0", VA = "0x18263C7C0")]
			get
			{
				return null;
			}
			[Token(Token = "0x6007898")]
			[Address(RVA = "0x263C890", Offset = "0x263B490", VA = "0x18263C890")]
			set
			{
			}
		}

		// Token: 0x17000E66 RID: 3686
		// (get) Token: 0x06007899 RID: 30873 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000E66")]
		protected override string shaderName
		{
			[Token(Token = "0x6007899")]
			[Address(RVA = "0x263C820", Offset = "0x263B420", VA = "0x18263C820", Slot = "4")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600789A RID: 30874 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600789A")]
		[Address(RVA = "0x263C340", Offset = "0x263AF40", VA = "0x18263C340", Slot = "5")]
		protected override void OnInit()
		{
		}

		// Token: 0x0600789B RID: 30875 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600789B")]
		[Address(RVA = "0x263C4B0", Offset = "0x263B0B0", VA = "0x18263C4B0", Slot = "6")]
		protected override void OnPostEffect(RenderTexture source, RenderTexture destination)
		{
		}

		// Token: 0x0600789C RID: 30876 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600789C")]
		[Address(RVA = "0x263C620", Offset = "0x263B220", VA = "0x18263C620")]
		private void _InitDepthBuffer()
		{
		}

		// Token: 0x0600789D RID: 30877 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600789D")]
		[Address(RVA = "0x263C6E0", Offset = "0x263B2E0", VA = "0x18263C6E0")]
		public MobileFishEye()
		{
		}

		// Token: 0x04007677 RID: 30327
		[Token(Token = "0x4007677")]
		public const string SHADER_NAME = "Hidden/Torappu/PostEffect/MobileFisheye";

		// Token: 0x04007678 RID: 30328
		[Token(Token = "0x4007678")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private MobileFishEye.Settings _settings;

		// Token: 0x04007679 RID: 30329
		[Token(Token = "0x4007679")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private bool _useDepth;

		// Token: 0x0400767A RID: 30330
		[Token(Token = "0x400767A")]
		[FieldOffset(Offset = "0x59")]
		[SerializeField]
		private bool _useStencil;

		// Token: 0x0400767B RID: 30331
		[Token(Token = "0x400767B")]
		[FieldOffset(Offset = "0x5C")]
		private int m_transPowerShaderId;

		// Token: 0x0400767C RID: 30332
		[Token(Token = "0x400767C")]
		[FieldOffset(Offset = "0x60")]
		private int m_distortionAmountShaderId;

		// Token: 0x0400767D RID: 30333
		[Token(Token = "0x400767D")]
		[FieldOffset(Offset = "0x64")]
		private int m_inOutSwitchShaderId;

		// Token: 0x0400767E RID: 30334
		[Token(Token = "0x400767E")]
		[FieldOffset(Offset = "0x68")]
		private int m_rbChannelOffsetShaderId;

		// Token: 0x0400767F RID: 30335
		[Token(Token = "0x400767F")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_settings;

		// Token: 0x04007680 RID: 30336
		[Token(Token = "0x4007680")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_settings;

		// Token: 0x04007681 RID: 30337
		[Token(Token = "0x4007681")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_shaderName;

		// Token: 0x04007682 RID: 30338
		[Token(Token = "0x4007682")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnInit;

		// Token: 0x04007683 RID: 30339
		[Token(Token = "0x4007683")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_OnPostEffect;

		// Token: 0x04007684 RID: 30340
		[Token(Token = "0x4007684")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__InitDepthBuffer;

		// Token: 0x04007685 RID: 30341
		[Token(Token = "0x4007685")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02001455 RID: 5205
		[Token(Token = "0x2001455")]
		[Serializable]
		public class Settings
		{
			// Token: 0x0600789E RID: 30878 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600789E")]
			[Address(RVA = "0x264C410", Offset = "0x264B010", VA = "0x18264C410")]
			public Settings()
			{
			}

			// Token: 0x04007686 RID: 30342
			[Token(Token = "0x4007686")]
			[FieldOffset(Offset = "0x10")]
			[SerializeField]
			public float transPower;

			// Token: 0x04007687 RID: 30343
			[Token(Token = "0x4007687")]
			[FieldOffset(Offset = "0x14")]
			[SerializeField]
			[Range(0f, 1f)]
			public float distortionAmount;

			// Token: 0x04007688 RID: 30344
			[Token(Token = "0x4007688")]
			[FieldOffset(Offset = "0x18")]
			[SerializeField]
			[Range(0f, 1f)]
			public float inOutSwitch;

			// Token: 0x04007689 RID: 30345
			[Token(Token = "0x4007689")]
			[FieldOffset(Offset = "0x1C")]
			[SerializeField]
			public Vector4 rbChannelOffset;
		}
	}
}

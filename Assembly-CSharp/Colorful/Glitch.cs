using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Colorful
{
	// Token: 0x02007CE0 RID: 31968
	[Token(Token = "0x2007CE0")]
	[HelpURL("http://www.thomashourdel.com/colorful/doc/camera-effects/glitch.html")]
	[ExecuteInEditMode]
	[AddComponentMenu("Colorful FX/Camera Effects/Glitch")]
	public class Glitch : BaseEffect
	{
		// Token: 0x17006867 RID: 26727
		// (get) Token: 0x0602C9E7 RID: 182759 RVA: 0x000E10F0 File Offset: 0x000DF2F0
		[Token(Token = "0x17006867")]
		public bool IsActive
		{
			[Token(Token = "0x602C9E7")]
			[Address(RVA = "0x789390", Offset = "0x787F90", VA = "0x180789390")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x0602C9E8 RID: 182760 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602C9E8")]
		[Address(RVA = "0x287CD60", Offset = "0x287B960", VA = "0x18287CD60", Slot = "4")]
		protected override void Start()
		{
		}

		// Token: 0x0602C9E9 RID: 182761 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602C9E9")]
		[Address(RVA = "0x287CD90", Offset = "0x287B990", VA = "0x18287CD90", Slot = "8")]
		protected virtual void Update()
		{
		}

		// Token: 0x0602C9EA RID: 182762 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602C9EA")]
		[Address(RVA = "0x287CBD0", Offset = "0x287B7D0", VA = "0x18287CBD0", Slot = "6")]
		protected override void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		// Token: 0x0602C9EB RID: 182763 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602C9EB")]
		[Address(RVA = "0x287C950", Offset = "0x287B550", VA = "0x18287C950", Slot = "9")]
		protected virtual void DoInterferences(RenderTexture source, RenderTexture destination, Glitch.InterferenceSettings settings)
		{
		}

		// Token: 0x0602C9EC RID: 182764 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602C9EC")]
		[Address(RVA = "0x287CA60", Offset = "0x287B660", VA = "0x18287CA60", Slot = "10")]
		protected virtual void DoTearing(RenderTexture source, RenderTexture destination, Glitch.TearingSettings settings)
		{
		}

		// Token: 0x0602C9ED RID: 182765 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602C9ED")]
		[Address(RVA = "0x287CBA0", Offset = "0x287B7A0", VA = "0x18287CBA0", Slot = "7")]
		protected override string GetShaderName()
		{
			return null;
		}

		// Token: 0x0602C9EE RID: 182766 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602C9EE")]
		[Address(RVA = "0x287CE40", Offset = "0x287BA40", VA = "0x18287CE40")]
		public Glitch()
		{
		}

		// Token: 0x04040473 RID: 263283
		[Token(Token = "0x4040473")]
		[FieldOffset(Offset = "0x28")]
		[Tooltip("Automatically activate/deactivate the effect randomly.")]
		public bool RandomActivation;

		// Token: 0x04040474 RID: 263284
		[Token(Token = "0x4040474")]
		[FieldOffset(Offset = "0x2C")]
		public Vector2 RandomEvery;

		// Token: 0x04040475 RID: 263285
		[Token(Token = "0x4040475")]
		[FieldOffset(Offset = "0x34")]
		public Vector2 RandomDuration;

		// Token: 0x04040476 RID: 263286
		[Token(Token = "0x4040476")]
		[FieldOffset(Offset = "0x3C")]
		[Tooltip("Glitch type.")]
		public Glitch.GlitchingMode Mode;

		// Token: 0x04040477 RID: 263287
		[Token(Token = "0x4040477")]
		[FieldOffset(Offset = "0x40")]
		public Glitch.InterferenceSettings SettingsInterferences;

		// Token: 0x04040478 RID: 263288
		[Token(Token = "0x4040478")]
		[FieldOffset(Offset = "0x48")]
		public Glitch.TearingSettings SettingsTearing;

		// Token: 0x04040479 RID: 263289
		[Token(Token = "0x4040479")]
		[FieldOffset(Offset = "0x50")]
		protected bool m_Activated;

		// Token: 0x0404047A RID: 263290
		[Token(Token = "0x404047A")]
		[FieldOffset(Offset = "0x54")]
		protected float m_EveryTimer;

		// Token: 0x0404047B RID: 263291
		[Token(Token = "0x404047B")]
		[FieldOffset(Offset = "0x58")]
		protected float m_EveryTimerEnd;

		// Token: 0x0404047C RID: 263292
		[Token(Token = "0x404047C")]
		[FieldOffset(Offset = "0x5C")]
		protected float m_DurationTimer;

		// Token: 0x0404047D RID: 263293
		[Token(Token = "0x404047D")]
		[FieldOffset(Offset = "0x60")]
		protected float m_DurationTimerEnd;

		// Token: 0x02007CE1 RID: 31969
		[Token(Token = "0x2007CE1")]
		public enum GlitchingMode
		{
			// Token: 0x0404047F RID: 263295
			[Token(Token = "0x404047F")]
			Interferences,
			// Token: 0x04040480 RID: 263296
			[Token(Token = "0x4040480")]
			Tearing,
			// Token: 0x04040481 RID: 263297
			[Token(Token = "0x4040481")]
			Complete
		}

		// Token: 0x02007CE2 RID: 31970
		[Token(Token = "0x2007CE2")]
		[Serializable]
		public class InterferenceSettings
		{
			// Token: 0x0602C9EF RID: 182767 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602C9EF")]
			[Address(RVA = "0x287E4E0", Offset = "0x287D0E0", VA = "0x18287E4E0")]
			public InterferenceSettings()
			{
			}

			// Token: 0x04040482 RID: 263298
			[Token(Token = "0x4040482")]
			[FieldOffset(Offset = "0x10")]
			public float Speed;

			// Token: 0x04040483 RID: 263299
			[Token(Token = "0x4040483")]
			[FieldOffset(Offset = "0x14")]
			public float Density;

			// Token: 0x04040484 RID: 263300
			[Token(Token = "0x4040484")]
			[FieldOffset(Offset = "0x18")]
			public float MaxDisplacement;
		}

		// Token: 0x02007CE3 RID: 31971
		[Token(Token = "0x2007CE3")]
		[Serializable]
		public class TearingSettings
		{
			// Token: 0x0602C9F0 RID: 182768 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602C9F0")]
			[Address(RVA = "0x2883010", Offset = "0x2881C10", VA = "0x182883010")]
			public TearingSettings()
			{
			}

			// Token: 0x04040485 RID: 263301
			[Token(Token = "0x4040485")]
			[FieldOffset(Offset = "0x10")]
			public float Speed;

			// Token: 0x04040486 RID: 263302
			[Token(Token = "0x4040486")]
			[FieldOffset(Offset = "0x14")]
			[Range(0f, 1f)]
			public float Intensity;

			// Token: 0x04040487 RID: 263303
			[Token(Token = "0x4040487")]
			[FieldOffset(Offset = "0x18")]
			[Range(0f, 0.5f)]
			public float MaxDisplacement;

			// Token: 0x04040488 RID: 263304
			[Token(Token = "0x4040488")]
			[FieldOffset(Offset = "0x1C")]
			public bool AllowFlipping;

			// Token: 0x04040489 RID: 263305
			[Token(Token = "0x4040489")]
			[FieldOffset(Offset = "0x1D")]
			public bool YuvColorBleeding;

			// Token: 0x0404048A RID: 263306
			[Token(Token = "0x404048A")]
			[FieldOffset(Offset = "0x20")]
			[Range(-2f, 2f)]
			public float YuvOffset;
		}
	}
}

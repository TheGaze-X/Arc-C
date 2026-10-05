using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace UnityEngine.Rendering.PostProcessing
{
	// Token: 0x0200007D RID: 125
	[Token(Token = "0x200007D")]
	public sealed class PostProcessProfile : ScriptableObject
	{
		// Token: 0x0600018D RID: 397 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x600018D")]
		[Address(RVA = "0x5841A50", Offset = "0x5840650", VA = "0x185841A50")]
		private void OnEnable()
		{
		}

		// Token: 0x0600018E RID: 398 RVA: 0x000020AE File Offset: 0x000002AE
		[Token(Token = "0x600018E")]
		public T AddSettings<T>() where T : PostProcessEffectSettings
		{
			return null;
		}

		// Token: 0x0600018F RID: 399 RVA: 0x000020AE File Offset: 0x000002AE
		[Token(Token = "0x600018F")]
		[Address(RVA = "0x58415E0", Offset = "0x58401E0", VA = "0x1858415E0")]
		public PostProcessEffectSettings AddSettings(Type type)
		{
			return null;
		}

		// Token: 0x06000190 RID: 400 RVA: 0x000020AE File Offset: 0x000002AE
		[Token(Token = "0x6000190")]
		[Address(RVA = "0x5841800", Offset = "0x5840400", VA = "0x185841800")]
		public PostProcessEffectSettings AddSettings(PostProcessEffectSettings effect)
		{
			return null;
		}

		// Token: 0x06000191 RID: 401 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x6000191")]
		public void RemoveSettings<T>() where T : PostProcessEffectSettings
		{
		}

		// Token: 0x06000192 RID: 402 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x6000192")]
		[Address(RVA = "0x5841B80", Offset = "0x5840780", VA = "0x185841B80")]
		public void RemoveSettings(Type type)
		{
		}

		// Token: 0x06000193 RID: 403 RVA: 0x00002924 File Offset: 0x00000B24
		[Token(Token = "0x6000193")]
		public bool HasSettings<T>() where T : PostProcessEffectSettings
		{
			return default(bool);
		}

		// Token: 0x06000194 RID: 404 RVA: 0x0000293C File Offset: 0x00000B3C
		[Token(Token = "0x6000194")]
		[Address(RVA = "0x58418D0", Offset = "0x58404D0", VA = "0x1858418D0")]
		public bool HasSettings(Type type)
		{
			return default(bool);
		}

		// Token: 0x06000195 RID: 405 RVA: 0x000020AE File Offset: 0x000002AE
		[Token(Token = "0x6000195")]
		public T GetSetting<T>() where T : PostProcessEffectSettings
		{
			return null;
		}

		// Token: 0x06000196 RID: 406 RVA: 0x00002954 File Offset: 0x00000B54
		[Token(Token = "0x6000196")]
		public bool TryGetSettings<T>(out T outSetting) where T : PostProcessEffectSettings
		{
			return default(bool);
		}

		// Token: 0x06000197 RID: 407 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x6000197")]
		[Address(RVA = "0x5841CF0", Offset = "0x58408F0", VA = "0x185841CF0")]
		public PostProcessProfile()
		{
		}

		// Token: 0x0400020F RID: 527
		[Token(Token = "0x400020F")]
		[FieldOffset(Offset = "0x18")]
		[Tooltip("A list of all settings currently stored in this profile.")]
		public List<PostProcessEffectSettings> settings;

		// Token: 0x04000210 RID: 528
		[Token(Token = "0x4000210")]
		[FieldOffset(Offset = "0x20")]
		[NonSerialized]
		public bool isDirty;
	}
}

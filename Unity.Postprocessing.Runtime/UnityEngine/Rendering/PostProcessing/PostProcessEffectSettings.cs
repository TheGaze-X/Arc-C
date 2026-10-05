using System;
using System.Collections.ObjectModel;
using Il2CppDummyDll;

namespace UnityEngine.Rendering.PostProcessing
{
	// Token: 0x0200006F RID: 111
	[Token(Token = "0x200006F")]
	[Serializable]
	public class PostProcessEffectSettings : ScriptableObject
	{
		// Token: 0x0600012B RID: 299 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x600012B")]
		[Address(RVA = "0x5834190", Offset = "0x5832D90", VA = "0x185834190")]
		private void OnEnable()
		{
		}

		// Token: 0x0600012C RID: 300 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x600012C")]
		[Address(RVA = "0x5833FA0", Offset = "0x5832BA0", VA = "0x185833FA0")]
		private void OnDisable()
		{
		}

		// Token: 0x0600012D RID: 301 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x600012D")]
		[Address(RVA = "0x5834660", Offset = "0x5833260", VA = "0x185834660")]
		public void SetAllOverridesTo(bool state, bool excludeEnabled = true)
		{
		}

		// Token: 0x0600012E RID: 302 RVA: 0x0000263C File Offset: 0x0000083C
		[Token(Token = "0x600012E")]
		[Address(RVA = "0x58223F0", Offset = "0x5820FF0", VA = "0x1858223F0", Slot = "4")]
		public virtual bool IsEnabledAndSupported(PostProcessRenderContext context)
		{
			return default(bool);
		}

		// Token: 0x0600012F RID: 303 RVA: 0x00002654 File Offset: 0x00000854
		[Token(Token = "0x600012F")]
		[Address(RVA = "0x5833DA0", Offset = "0x58329A0", VA = "0x185833DA0")]
		public int GetHash()
		{
			return 0;
		}

		// Token: 0x06000130 RID: 304 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x6000130")]
		[Address(RVA = "0x5834940", Offset = "0x5833540", VA = "0x185834940")]
		public PostProcessEffectSettings()
		{
		}

		// Token: 0x04000199 RID: 409
		[Token(Token = "0x4000199")]
		[FieldOffset(Offset = "0x18")]
		public bool active;

		// Token: 0x0400019A RID: 410
		[Token(Token = "0x400019A")]
		[FieldOffset(Offset = "0x20")]
		public BoolParameter enabled;

		// Token: 0x0400019B RID: 411
		[Token(Token = "0x400019B")]
		[FieldOffset(Offset = "0x28")]
		internal ReadOnlyCollection<ParameterOverride> parameters;
	}
}

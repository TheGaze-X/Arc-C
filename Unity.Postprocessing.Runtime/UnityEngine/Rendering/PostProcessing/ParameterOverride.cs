using System;
using Il2CppDummyDll;

namespace UnityEngine.Rendering.PostProcessing
{
	// Token: 0x0200005B RID: 91
	[Token(Token = "0x200005B")]
	public abstract class ParameterOverride
	{
		// Token: 0x060000D0 RID: 208
		[Token(Token = "0x60000D0")]
		internal abstract void Interp(ParameterOverride from, ParameterOverride to, float t);

		// Token: 0x060000D1 RID: 209
		[Token(Token = "0x60000D1")]
		public abstract int GetHash();

		// Token: 0x060000D2 RID: 210 RVA: 0x000020AE File Offset: 0x000002AE
		[Token(Token = "0x60000D2")]
		public T GetValue<T>()
		{
			return null;
		}

		// Token: 0x060000D3 RID: 211 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x60000D3")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70", Slot = "6")]
		protected internal virtual void OnEnable()
		{
		}

		// Token: 0x060000D4 RID: 212 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x60000D4")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70", Slot = "7")]
		protected internal virtual void OnDisable()
		{
		}

		// Token: 0x060000D5 RID: 213
		[Token(Token = "0x60000D5")]
		internal abstract void SetValue(ParameterOverride parameter);

		// Token: 0x060000D6 RID: 214 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x60000D6")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		protected ParameterOverride()
		{
		}

		// Token: 0x04000162 RID: 354
		[Token(Token = "0x4000162")]
		[FieldOffset(Offset = "0x10")]
		public bool overrideState;
	}
}

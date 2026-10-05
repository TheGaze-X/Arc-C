using System;
using Il2CppDummyDll;

namespace UnityEngine.Rendering.PostProcessing
{
	// Token: 0x0200005C RID: 92
	[Token(Token = "0x200005C")]
	[Serializable]
	public class ParameterOverride<T> : ParameterOverride
	{
		// Token: 0x060000D7 RID: 215 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x60000D7")]
		public ParameterOverride()
		{
		}

		// Token: 0x060000D8 RID: 216 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x60000D8")]
		public ParameterOverride(T value)
		{
		}

		// Token: 0x060000D9 RID: 217 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x60000D9")]
		public ParameterOverride(T value, bool overrideState)
		{
		}

		// Token: 0x060000DA RID: 218 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x60000DA")]
		internal override void Interp(ParameterOverride from, ParameterOverride to, float t)
		{
		}

		// Token: 0x060000DB RID: 219 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x60000DB")]
		public virtual void Interp(T from, T to, float t)
		{
		}

		// Token: 0x060000DC RID: 220 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x60000DC")]
		public void Override(T x)
		{
		}

		// Token: 0x060000DD RID: 221 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x60000DD")]
		internal override void SetValue(ParameterOverride parameter)
		{
		}

		// Token: 0x060000DE RID: 222 RVA: 0x0000251C File Offset: 0x0000071C
		[Token(Token = "0x60000DE")]
		public override int GetHash()
		{
			return 0;
		}

		// Token: 0x060000DF RID: 223 RVA: 0x000020AE File Offset: 0x000002AE
		[Token(Token = "0x60000DF")]
		public static implicit operator T(ParameterOverride<T> prop)
		{
			return null;
		}

		// Token: 0x04000163 RID: 355
		[Token(Token = "0x4000163")]
		[FieldOffset(Offset = "0x0")]
		public T value;
	}
}

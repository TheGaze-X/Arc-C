using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace UnityEngine.PostProcessing
{
	// Token: 0x020000EE RID: 238
	[Token(Token = "0x20000EE")]
	public sealed class MaterialFactory : IDisposable
	{
		// Token: 0x060003EF RID: 1007 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60003EF")]
		[Address(RVA = "0x5428220", Offset = "0x5426E20", VA = "0x185428220")]
		public MaterialFactory()
		{
		}

		// Token: 0x060003F0 RID: 1008 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60003F0")]
		[Address(RVA = "0x5428020", Offset = "0x5426C20", VA = "0x185428020")]
		public Material Get(string shaderName)
		{
			return null;
		}

		// Token: 0x060003F1 RID: 1009 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60003F1")]
		[Address(RVA = "0x5427EB0", Offset = "0x5426AB0", VA = "0x185427EB0", Slot = "4")]
		public void Dispose()
		{
		}

		// Token: 0x04000547 RID: 1351
		[Token(Token = "0x4000547")]
		[FieldOffset(Offset = "0x10")]
		private Dictionary<string, Material> m_Materials;
	}
}

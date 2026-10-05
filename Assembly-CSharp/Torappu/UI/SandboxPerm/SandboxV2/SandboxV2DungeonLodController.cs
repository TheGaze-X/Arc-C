using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.SandboxPerm.SandboxV2
{
	// Token: 0x02004160 RID: 16736
	[Token(Token = "0x2004160")]
	public class SandboxV2DungeonLodController : MonoBehaviour, IHotfixable
	{
		// Token: 0x06019D65 RID: 105829 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019D65")]
		[Address(RVA = "0x12B3140", Offset = "0x12B1D40", VA = "0x1812B3140")]
		public void Watch(ISandboxV2DungeonLodElement element)
		{
		}

		// Token: 0x06019D66 RID: 105830 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019D66")]
		[Address(RVA = "0x12B2EF0", Offset = "0x12B1AF0", VA = "0x1812B2EF0")]
		public void Unwatch(ISandboxV2DungeonLodElement element)
		{
		}

		// Token: 0x06019D67 RID: 105831 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019D67")]
		[Address(RVA = "0x12B2FB0", Offset = "0x12B1BB0", VA = "0x1812B2FB0")]
		public void UpdateLod(float normalizedLod, SandboxV2DungeonLodRank lodRank)
		{
		}

		// Token: 0x06019D68 RID: 105832 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019D68")]
		[Address(RVA = "0x12B3230", Offset = "0x12B1E30", VA = "0x1812B3230")]
		public SandboxV2DungeonLodController()
		{
		}

		// Token: 0x04020735 RID: 132917
		[Token(Token = "0x4020735")]
		[FieldOffset(Offset = "0x18")]
		private HashSet<ISandboxV2DungeonLodElement> m_lodElements;

		// Token: 0x04020736 RID: 132918
		[Token(Token = "0x4020736")]
		[FieldOffset(Offset = "0x20")]
		private float m_lod;

		// Token: 0x04020737 RID: 132919
		[Token(Token = "0x4020737")]
		[FieldOffset(Offset = "0x24")]
		private SandboxV2DungeonLodRank m_lodRank;

		// Token: 0x04020738 RID: 132920
		[Token(Token = "0x4020738")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Watch;

		// Token: 0x04020739 RID: 132921
		[Token(Token = "0x4020739")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_Unwatch;

		// Token: 0x0402073A RID: 132922
		[Token(Token = "0x402073A")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_UpdateLod;

		// Token: 0x0402073B RID: 132923
		[Token(Token = "0x402073B")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}

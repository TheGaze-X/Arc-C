using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Building
{
	// Token: 0x020017F0 RID: 6128
	[Token(Token = "0x20017F0")]
	public class VFurnitureOutline : IHotfixable
	{
		// Token: 0x170010DB RID: 4315
		// (get) Token: 0x06009ABC RID: 39612 RVA: 0x0003C180 File Offset: 0x0003A380
		[Token(Token = "0x170010DB")]
		public bool isOutlineOn
		{
			[Token(Token = "0x6009ABC")]
			[Address(RVA = "0x31698E0", Offset = "0x31684E0", VA = "0x1831698E0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06009ABD RID: 39613 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009ABD")]
		[Address(RVA = "0x3169810", Offset = "0x3168410", VA = "0x183169810")]
		public VFurnitureOutline(GameObject gameObject)
		{
		}

		// Token: 0x06009ABE RID: 39614 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009ABE")]
		[Address(RVA = "0x3169070", Offset = "0x3167C70", VA = "0x183169070")]
		public void EnableOutline(bool value)
		{
		}

		// Token: 0x06009ABF RID: 39615 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009ABF")]
		[Address(RVA = "0x3169200", Offset = "0x3167E00", VA = "0x183169200")]
		public void ResetOutline()
		{
		}

		// Token: 0x06009AC0 RID: 39616 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009AC0")]
		[Address(RVA = "0x3169360", Offset = "0x3167F60", VA = "0x183169360")]
		private void _EnsureFurnitureOutlines()
		{
		}

		// Token: 0x06009AC1 RID: 39617 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009AC1")]
		[Address(RVA = "0x31693D0", Offset = "0x3167FD0", VA = "0x1831693D0")]
		private void _InitFurnitureOutlines()
		{
		}

		// Token: 0x04009119 RID: 37145
		[Token(Token = "0x4009119")]
		[FieldOffset(Offset = "0x10")]
		private GameObject m_gameObject;

		// Token: 0x0400911A RID: 37146
		[Token(Token = "0x400911A")]
		[FieldOffset(Offset = "0x18")]
		private List<VFurnitureOutline.FurnitureOutlineHolder> m_outlineHolders;

		// Token: 0x0400911B RID: 37147
		[Token(Token = "0x400911B")]
		[FieldOffset(Offset = "0x20")]
		private bool m_inited;

		// Token: 0x0400911C RID: 37148
		[Token(Token = "0x400911C")]
		[FieldOffset(Offset = "0x21")]
		private bool m_outlineOn;

		// Token: 0x0400911D RID: 37149
		[Token(Token = "0x400911D")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_isOutlineOn;

		// Token: 0x0400911E RID: 37150
		[Token(Token = "0x400911E")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x0400911F RID: 37151
		[Token(Token = "0x400911F")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_EnableOutline;

		// Token: 0x04009120 RID: 37152
		[Token(Token = "0x4009120")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_ResetOutline;

		// Token: 0x04009121 RID: 37153
		[Token(Token = "0x4009121")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__EnsureFurnitureOutlines;

		// Token: 0x04009122 RID: 37154
		[Token(Token = "0x4009122")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__InitFurnitureOutlines;

		// Token: 0x020017F1 RID: 6129
		[Token(Token = "0x20017F1")]
		private class FurnitureOutlineHolder
		{
			// Token: 0x06009AC2 RID: 39618 RVA: 0x0003C198 File Offset: 0x0003A398
			[Token(Token = "0x6009AC2")]
			[Address(RVA = "0x315FFF0", Offset = "0x315EBF0", VA = "0x18315FFF0")]
			public bool Init(MeshRenderer meshRenderer)
			{
				return default(bool);
			}

			// Token: 0x06009AC3 RID: 39619 RVA: 0x0003C1B0 File Offset: 0x0003A3B0
			[Token(Token = "0x6009AC3")]
			[Address(RVA = "0x315FEC0", Offset = "0x315EAC0", VA = "0x18315FEC0")]
			public bool Init(SkinnedMeshRenderer skinnedMeshRenderer)
			{
				return default(bool);
			}

			// Token: 0x06009AC4 RID: 39620 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6009AC4")]
			[Address(RVA = "0x3160140", Offset = "0x315ED40", VA = "0x183160140")]
			public void SetEnable(bool value)
			{
			}

			// Token: 0x06009AC5 RID: 39621 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6009AC5")]
			[Address(RVA = "0x3160120", Offset = "0x315ED20", VA = "0x183160120")]
			public void Reset()
			{
			}

			// Token: 0x06009AC6 RID: 39622 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6009AC6")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public FurnitureOutlineHolder()
			{
			}

			// Token: 0x04009123 RID: 37155
			[Token(Token = "0x4009123")]
			[FieldOffset(Offset = "0x10")]
			private FurnitureOutline m_outline;
		}
	}
}

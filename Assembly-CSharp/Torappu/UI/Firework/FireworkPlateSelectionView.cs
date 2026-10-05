using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.Firework
{
	// Token: 0x02004E3B RID: 20027
	[Token(Token = "0x2004E3B")]
	public class FireworkPlateSelectionView : MonoBehaviour, IHotfixable
	{
		// Token: 0x0601DE9D RID: 122525 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601DE9D")]
		[Address(RVA = "0x1770510", Offset = "0x176F110", VA = "0x181770510")]
		public void Render(FireworkPlateGroupModel plateGroupModel, FireworkPlateViewStyle style)
		{
		}

		// Token: 0x0601DE9E RID: 122526 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601DE9E")]
		[Address(RVA = "0x17706C0", Offset = "0x176F2C0", VA = "0x1817706C0")]
		public FireworkPlateSelectionView()
		{
		}

		// Token: 0x04027B15 RID: 162581
		[Token(Token = "0x4027B15")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private RectTransform _elementContainer;

		// Token: 0x04027B16 RID: 162582
		[Token(Token = "0x4027B16")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private FireworkPlateSelectionElementView _prefabElementView;

		// Token: 0x04027B17 RID: 162583
		[Token(Token = "0x4027B17")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Vector2 _gridSize;

		// Token: 0x04027B18 RID: 162584
		[Token(Token = "0x4027B18")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Vector2 _padding;

		// Token: 0x04027B19 RID: 162585
		[Token(Token = "0x4027B19")]
		[FieldOffset(Offset = "0x38")]
		private List<FireworkPlateSelectionElementView> m_gridElements;

		// Token: 0x04027B1A RID: 162586
		[Token(Token = "0x4027B1A")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x04027B1B RID: 162587
		[Token(Token = "0x4027B1B")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}

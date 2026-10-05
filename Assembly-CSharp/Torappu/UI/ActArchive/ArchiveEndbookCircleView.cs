using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.ActArchive
{
	// Token: 0x02006B6D RID: 27501
	[Token(Token = "0x2006B6D")]
	public class ArchiveEndbookCircleView : MonoBehaviour, IHotfixable
	{
		// Token: 0x060274B9 RID: 160953 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60274B9")]
		[Address(RVA = "0x227CD00", Offset = "0x227B900", VA = "0x18227CD00")]
		public void Render(bool isSelected)
		{
		}

		// Token: 0x060274BA RID: 160954 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60274BA")]
		[Address(RVA = "0x227CD90", Offset = "0x227B990", VA = "0x18227CD90")]
		public ArchiveEndbookCircleView()
		{
		}

		// Token: 0x04037A35 RID: 227893
		[Token(Token = "0x4037A35")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private GameObject _panelSelected;

		// Token: 0x04037A36 RID: 227894
		[Token(Token = "0x4037A36")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GameObject _panelUnselected;

		// Token: 0x04037A37 RID: 227895
		[Token(Token = "0x4037A37")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x04037A38 RID: 227896
		[Token(Token = "0x4037A38")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}

using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.SiracusaMap
{
	// Token: 0x02003F90 RID: 16272
	[Token(Token = "0x2003F90")]
	public class SiracusaMapPointView : MonoBehaviour, IHotfixable
	{
		// Token: 0x060193E4 RID: 103396 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60193E4")]
		[Address(RVA = "0x11F2BF0", Offset = "0x11F17F0", VA = "0x1811F2BF0")]
		public SiracusaMapPointView()
		{
		}

		// Token: 0x0401F532 RID: 128306
		[Token(Token = "0x401F532")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		[HideInInspector]
		private string _pointId;

		// Token: 0x0401F533 RID: 128307
		[Token(Token = "0x401F533")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}

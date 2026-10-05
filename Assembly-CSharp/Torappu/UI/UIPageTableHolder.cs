using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Torappu.UI
{
	// Token: 0x0200363D RID: 13885
	[Token(Token = "0x200363D")]
	public class UIPageTableHolder : MonoBehaviour
	{
		// Token: 0x17003526 RID: 13606
		// (get) Token: 0x060161AD RID: 90541 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17003526")]
		public UIPageTable[] pageTables
		{
			[Token(Token = "0x60161AD")]
			[Address(RVA = "0x4E5A80", Offset = "0x4E4680", VA = "0x1804E5A80")]
			get
			{
				return null;
			}
		}

		// Token: 0x060161AE RID: 90542 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60161AE")]
		[Address(RVA = "0xEA5390", Offset = "0xEA3F90", VA = "0x180EA5390", Slot = "4")]
		protected virtual void Start()
		{
		}

		// Token: 0x060161AF RID: 90543 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60161AF")]
		[Address(RVA = "0x4EC010", Offset = "0x4EAC10", VA = "0x1804EC010")]
		public UIPageTableHolder()
		{
		}

		// Token: 0x0401A956 RID: 108886
		[Token(Token = "0x401A956")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private UIPageTable[] _pageTables;
	}
}

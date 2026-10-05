using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

namespace Torappu.UI
{
	// Token: 0x020039E3 RID: 14819
	[Token(Token = "0x20039E3")]
	public class UICommonTopMenuButton : MonoBehaviour
	{
		// Token: 0x1700380E RID: 14350
		// (get) Token: 0x06017676 RID: 95862 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06017677 RID: 95863 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700380E")]
		public Action<UIRouteTarget> onRouteButtonClicked
		{
			[Token(Token = "0x6017676")]
			[Address(RVA = "0x4E5A70", Offset = "0x4E4670", VA = "0x1804E5A70")]
			[CompilerGenerated]
			private get
			{
				return null;
			}
			[Token(Token = "0x6017677")]
			[Address(RVA = "0x4E6EC0", Offset = "0x4E5AC0", VA = "0x1804E6EC0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x1700380F RID: 14351
		// (get) Token: 0x06017678 RID: 95864 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700380F")]
		protected Button button
		{
			[Token(Token = "0x6017678")]
			[Address(RVA = "0xFC2150", Offset = "0xFC0D50", VA = "0x180FC2150")]
			get
			{
				return null;
			}
		}

		// Token: 0x06017679 RID: 95865 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017679")]
		[Address(RVA = "0xFC2030", Offset = "0xFC0C30", VA = "0x180FC2030")]
		protected void Start()
		{
		}

		// Token: 0x0601767A RID: 95866 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601767A")]
		[Address(RVA = "0xFC1FF0", Offset = "0xFC0BF0", VA = "0x180FC1FF0")]
		public void EventOnClicked()
		{
		}

		// Token: 0x0601767B RID: 95867 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601767B")]
		[Address(RVA = "0x4EC010", Offset = "0x4EAC10", VA = "0x1804EC010")]
		public UICommonTopMenuButton()
		{
		}

		// Token: 0x0401C44E RID: 115790
		[Token(Token = "0x401C44E")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private UIRouteTarget _routeTarget;

		// Token: 0x0401C450 RID: 115792
		[Token(Token = "0x401C450")]
		[FieldOffset(Offset = "0x28")]
		private Button m_button;
	}
}

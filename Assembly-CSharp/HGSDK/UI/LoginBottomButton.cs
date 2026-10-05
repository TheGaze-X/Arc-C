using System;
using Il2CppDummyDll;
using UnityEngine;

namespace HGSDK.UI
{
	// Token: 0x0200017F RID: 383
	[Token(Token = "0x200017F")]
	public class LoginBottomButton : MonoBehaviour
	{
		// Token: 0x170000D2 RID: 210
		// (get) Token: 0x060005FF RID: 1535 RVA: 0x00003390 File Offset: 0x00001590
		[Token(Token = "0x170000D2")]
		public SDKLoginPage.BottomButtonType bottomBtnType
		{
			[Token(Token = "0x60005FF")]
			[Address(RVA = "0x4EA860", Offset = "0x4E9460", VA = "0x1804EA860")]
			get
			{
				return (SDKLoginPage.BottomButtonType)0;
			}
		}

		// Token: 0x06000600 RID: 1536 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000600")]
		[Address(RVA = "0x4EC010", Offset = "0x4EAC10", VA = "0x1804EC010")]
		public LoginBottomButton()
		{
		}

		// Token: 0x040007C2 RID: 1986
		[Token(Token = "0x40007C2")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private SDKLoginPage.BottomButtonType _bottomBtnType;
	}
}

using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.HandBook
{
	// Token: 0x02006700 RID: 26368
	[Token(Token = "0x2006700")]
	public class HandBookV2MapGroupForceLogoView : MonoBehaviour, IHotfixable
	{
		// Token: 0x06025D7D RID: 155005 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025D7D")]
		[Address(RVA = "0x20C6F70", Offset = "0x20C5B70", VA = "0x1820C6F70")]
		public void Render(HandBookV2GroupForceViewModel forceViewModel)
		{
		}

		// Token: 0x06025D7E RID: 155006 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025D7E")]
		[Address(RVA = "0x20C7140", Offset = "0x20C5D40", VA = "0x1820C7140")]
		public HandBookV2MapGroupForceLogoView()
		{
		}

		// Token: 0x04035343 RID: 217923
		[Token(Token = "0x4035343")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Image _logoImg;

		// Token: 0x04035344 RID: 217924
		[Token(Token = "0x4035344")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Text _groupName;

		// Token: 0x04035345 RID: 217925
		[Token(Token = "0x4035345")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Text _percent;

		// Token: 0x04035346 RID: 217926
		[Token(Token = "0x4035346")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x04035347 RID: 217927
		[Token(Token = "0x4035347")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}

using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.ArtMagazine
{
	// Token: 0x02006522 RID: 25890
	[Token(Token = "0x2006522")]
	public class ArtMagazineCoverLeafNameItemView : MonoBehaviour, IHotfixable
	{
		// Token: 0x0602535C RID: 152412 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602535C")]
		[Address(RVA = "0x202E040", Offset = "0x202CC40", VA = "0x18202E040")]
		public void Render(ArtMagazineCoverLeafItemViewModel leafItemViewModel)
		{
		}

		// Token: 0x0602535D RID: 152413 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602535D")]
		[Address(RVA = "0x202E1B0", Offset = "0x202CDB0", VA = "0x18202E1B0")]
		public ArtMagazineCoverLeafNameItemView()
		{
		}

		// Token: 0x0403430C RID: 213772
		[Token(Token = "0x403430C")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Text _txtLeafName;

		// Token: 0x0403430D RID: 213773
		[Token(Token = "0x403430D")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GameObject _objHasInfoDot;

		// Token: 0x0403430E RID: 213774
		[Token(Token = "0x403430E")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private GameObject _objEmptyDot;

		// Token: 0x0403430F RID: 213775
		[Token(Token = "0x403430F")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x04034310 RID: 213776
		[Token(Token = "0x4034310")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}

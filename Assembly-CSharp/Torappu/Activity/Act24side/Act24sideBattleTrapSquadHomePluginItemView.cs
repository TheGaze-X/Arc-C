using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using Torappu.UI;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Activity.Act24side
{
	// Token: 0x02007572 RID: 30066
	[Token(Token = "0x2007572")]
	public class Act24sideBattleTrapSquadHomePluginItemView : MonoBehaviour, IHotfixable
	{
		// Token: 0x0602A53C RID: 173372 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A53C")]
		[Address(RVA = "0x25F89A0", Offset = "0x25F75A0", VA = "0x1825F89A0")]
		public void Render(string actId, [Optional] string itemIconId)
		{
		}

		// Token: 0x0602A53D RID: 173373 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A53D")]
		[Address(RVA = "0x25F8AA0", Offset = "0x25F76A0", VA = "0x1825F8AA0")]
		public Act24sideBattleTrapSquadHomePluginItemView()
		{
		}

		// Token: 0x0403CDF8 RID: 249336
		[Token(Token = "0x403CDF8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Image _imgIcon;

		// Token: 0x0403CDF9 RID: 249337
		[Token(Token = "0x403CDF9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private UIStateFinder m_finder;

		// Token: 0x0403CDFA RID: 249338
		[Token(Token = "0x403CDFA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0403CDFB RID: 249339
		[Token(Token = "0x403CDFB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}

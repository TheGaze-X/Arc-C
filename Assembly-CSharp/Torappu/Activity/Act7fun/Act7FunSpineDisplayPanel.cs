using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Activity.Act7fun
{
	// Token: 0x0200719D RID: 29085
	[Token(Token = "0x200719D")]
	public class Act7FunSpineDisplayPanel : MonoBehaviour, IHotfixable
	{
		// Token: 0x06029445 RID: 169029 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029445")]
		[Address(RVA = "0x24BDCD0", Offset = "0x24BC8D0", VA = "0x1824BDCD0")]
		public void Render(string spineGroupId, bool isFail)
		{
		}

		// Token: 0x06029446 RID: 169030 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029446")]
		[Address(RVA = "0x24BDED0", Offset = "0x24BCAD0", VA = "0x1824BDED0")]
		public Act7FunSpineDisplayPanel()
		{
		}

		// Token: 0x0403AF00 RID: 241408
		[Token(Token = "0x403AF00")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Act7FunSpineDisplaySpineHolder[] _spineHolders;

		// Token: 0x0403AF01 RID: 241409
		[Token(Token = "0x403AF01")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0403AF02 RID: 241410
		[Token(Token = "0x403AF02")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}

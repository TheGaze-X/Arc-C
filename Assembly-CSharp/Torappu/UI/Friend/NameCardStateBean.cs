using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.Friend
{
	// Token: 0x02004D7B RID: 19835
	[Token(Token = "0x2004D7B")]
	public class NameCardStateBean : MonoBehaviour, IStateBean, IHotfixable
	{
		// Token: 0x0601DAFD RID: 121597 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601DAFD")]
		[Address(RVA = "0x17455C0", Offset = "0x17441C0", VA = "0x1817455C0")]
		public void InitData()
		{
		}

		// Token: 0x0601DAFE RID: 121598 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601DAFE")]
		[Address(RVA = "0x1745670", Offset = "0x1744270", VA = "0x181745670")]
		public NameCardStateBean()
		{
		}

		// Token: 0x04027390 RID: 160656
		[Token(Token = "0x4027390")]
		[FieldOffset(Offset = "0x18")]
		[NonSerialized]
		public NameCardViewModel nameCardViewModel;

		// Token: 0x04027391 RID: 160657
		[Token(Token = "0x4027391")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_InitData;

		// Token: 0x04027392 RID: 160658
		[Token(Token = "0x4027392")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}

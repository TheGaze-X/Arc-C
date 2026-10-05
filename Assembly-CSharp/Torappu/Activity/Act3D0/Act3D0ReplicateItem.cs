using System;
using Il2CppDummyDll;
using Torappu.UI;
using UnityEngine;
using XLua;

namespace Torappu.Activity.Act3D0
{
	// Token: 0x0200740D RID: 29709
	[Token(Token = "0x200740D")]
	public class Act3D0ReplicateItem : MonoBehaviour, IHotfixable
	{
		// Token: 0x06029F3F RID: 171839 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029F3F")]
		[Address(RVA = "0x2590640", Offset = "0x258F240", VA = "0x182590640")]
		private void _InitIfNot()
		{
		}

		// Token: 0x06029F40 RID: 171840 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029F40")]
		[Address(RVA = "0x2590490", Offset = "0x258F090", VA = "0x182590490")]
		public void Render(ReplicateData data, bool isLast)
		{
		}

		// Token: 0x06029F41 RID: 171841 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029F41")]
		[Address(RVA = "0x2590890", Offset = "0x258F490", VA = "0x182590890")]
		public Act3D0ReplicateItem()
		{
		}

		// Token: 0x0403C22A RID: 246314
		[Token(Token = "0x403C22A")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Transform _itemContainer1;

		// Token: 0x0403C22B RID: 246315
		[Token(Token = "0x403C22B")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Transform _itemContainer2;

		// Token: 0x0403C22C RID: 246316
		[Token(Token = "0x403C22C")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private GameObject _lastIgnoreObj;

		// Token: 0x0403C22D RID: 246317
		[Token(Token = "0x403C22D")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private float _scaleFactor;

		// Token: 0x0403C22E RID: 246318
		[Token(Token = "0x403C22E")]
		[FieldOffset(Offset = "0x34")]
		private bool m_isInited;

		// Token: 0x0403C22F RID: 246319
		[Token(Token = "0x403C22F")]
		[FieldOffset(Offset = "0x38")]
		private UIItemCard m_itemCard1;

		// Token: 0x0403C230 RID: 246320
		[Token(Token = "0x403C230")]
		[FieldOffset(Offset = "0x40")]
		private UIItemCard m_itemCard2;

		// Token: 0x0403C231 RID: 246321
		[Token(Token = "0x403C231")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0403C232 RID: 246322
		[Token(Token = "0x403C232")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0403C233 RID: 246323
		[Token(Token = "0x403C233")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}

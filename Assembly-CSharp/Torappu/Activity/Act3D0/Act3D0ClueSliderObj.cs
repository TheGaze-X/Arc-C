using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Activity.Act3D0
{
	// Token: 0x0200741C RID: 29724
	[Token(Token = "0x200741C")]
	public class Act3D0ClueSliderObj : MonoBehaviour, IHotfixable
	{
		// Token: 0x06029F7C RID: 171900 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029F7C")]
		[Address(RVA = "0x2586F10", Offset = "0x2585B10", VA = "0x182586F10")]
		public void InitData(int index, Act3D0ClueInfo info)
		{
		}

		// Token: 0x06029F7D RID: 171901 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029F7D")]
		[Address(RVA = "0x2586FB0", Offset = "0x2585BB0", VA = "0x182586FB0")]
		public void SetIndex(int index)
		{
		}

		// Token: 0x06029F7E RID: 171902 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029F7E")]
		[Address(RVA = "0x2587070", Offset = "0x2585C70", VA = "0x182587070")]
		public Act3D0ClueSliderObj()
		{
		}

		// Token: 0x0403C29A RID: 246426
		[Token(Token = "0x403C29A")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private GameObject _selectedPart;

		// Token: 0x0403C29B RID: 246427
		[Token(Token = "0x403C29B")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GameObject _availPart;

		// Token: 0x0403C29C RID: 246428
		[Token(Token = "0x403C29C")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private GameObject _unavailPart;

		// Token: 0x0403C29D RID: 246429
		[Token(Token = "0x403C29D")]
		[FieldOffset(Offset = "0x30")]
		private int m_currentIndex;

		// Token: 0x0403C29E RID: 246430
		[Token(Token = "0x403C29E")]
		[FieldOffset(Offset = "0x34")]
		private Act3D0ClueInfo.State m_cacheState;

		// Token: 0x0403C29F RID: 246431
		[Token(Token = "0x403C29F")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_InitData;

		// Token: 0x0403C2A0 RID: 246432
		[Token(Token = "0x403C2A0")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_SetIndex;

		// Token: 0x0403C2A1 RID: 246433
		[Token(Token = "0x403C2A1")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}

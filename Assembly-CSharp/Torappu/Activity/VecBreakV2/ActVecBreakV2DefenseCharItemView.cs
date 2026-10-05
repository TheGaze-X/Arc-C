using System;
using Il2CppDummyDll;
using Torappu.UI;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Activity.VecBreakV2
{
	// Token: 0x02006E12 RID: 28178
	[Token(Token = "0x2006E12")]
	public class ActVecBreakV2DefenseCharItemView : MonoBehaviour, IHotfixable
	{
		// Token: 0x060281C7 RID: 164295 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60281C7")]
		[Address(RVA = "0x23611C0", Offset = "0x235FDC0", VA = "0x1823611C0")]
		public void Render(ActVecBreakV2DefenseCharSlotModel model)
		{
		}

		// Token: 0x060281C8 RID: 164296 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60281C8")]
		[Address(RVA = "0x2361330", Offset = "0x235FF30", VA = "0x182361330")]
		public ActVecBreakV2DefenseCharItemView()
		{
		}

		// Token: 0x04038ECF RID: 233167
		[Token(Token = "0x4038ECF")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Image _avatarIcon;

		// Token: 0x04038ED0 RID: 233168
		[Token(Token = "0x4038ED0")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GameObject _lockObject;

		// Token: 0x04038ED1 RID: 233169
		[Token(Token = "0x4038ED1")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private GameObject _emptyObject;

		// Token: 0x04038ED2 RID: 233170
		[Token(Token = "0x4038ED2")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private GameObject _avatarObject;

		// Token: 0x04038ED3 RID: 233171
		[Token(Token = "0x4038ED3")]
		[FieldOffset(Offset = "0x38")]
		private UIPageFinder m_pageFinder;

		// Token: 0x04038ED4 RID: 233172
		[Token(Token = "0x4038ED4")]
		[FieldOffset(Offset = "0x48")]
		private string m_cacheAvatarId;

		// Token: 0x04038ED5 RID: 233173
		[Token(Token = "0x4038ED5")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x04038ED6 RID: 233174
		[Token(Token = "0x4038ED6")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}

using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.UI.Stencil;
using UnityEngine;
using XLua;

namespace Torappu.UI
{
	// Token: 0x02003769 RID: 14185
	[Token(Token = "0x2003769")]
	[DisallowMultipleComponent]
	[RequireComponent(typeof(UIStencilComponent))]
	public abstract class UIStencilDefaultMaterialChecker : MonoBehaviour, IMatChecker, IHotfixable
	{
		// Token: 0x06016860 RID: 92256 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6016860")]
		[Address(RVA = "0xF040A0", Offset = "0xF02CA0", VA = "0x180F040A0", Slot = "5")]
		public virtual void BindComponent()
		{
		}

		// Token: 0x06016861 RID: 92257 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6016861")]
		[Address(RVA = "0xF043A0", Offset = "0xF02FA0", VA = "0x180F043A0")]
		private void OnEnable()
		{
		}

		// Token: 0x06016862 RID: 92258 RVA: 0x00091788 File Offset: 0x0008F988
		[Token(Token = "0x6016862")]
		[Address(RVA = "0xF04240", Offset = "0xF02E40", VA = "0x180F04240", Slot = "6")]
		public virtual bool CheckMaterialExclusive(Material baseMat, List<Material> customList)
		{
			return default(bool);
		}

		// Token: 0x06016863 RID: 92259 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6016863")]
		[Address(RVA = "0xF04420", Offset = "0xF03020", VA = "0x180F04420")]
		protected UIStencilDefaultMaterialChecker()
		{
		}

		// Token: 0x0401B223 RID: 111139
		[Token(Token = "0x401B223")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_BindComponent;

		// Token: 0x0401B224 RID: 111140
		[Token(Token = "0x401B224")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnEnable;

		// Token: 0x0401B225 RID: 111141
		[Token(Token = "0x401B225")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_CheckMaterialExclusive;

		// Token: 0x0401B226 RID: 111142
		[Token(Token = "0x401B226")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}

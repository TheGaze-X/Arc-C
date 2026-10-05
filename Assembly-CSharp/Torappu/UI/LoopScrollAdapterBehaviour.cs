using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI
{
	// Token: 0x02003977 RID: 14711
	[Token(Token = "0x2003977")]
	[RequireComponent(typeof(GridLayoutGroup))]
	public class LoopScrollAdapterBehaviour : LoopScrollAdapter<GetComponentCache, object>, LoopScrollAdapterBinder.IBinderHost
	{
		// Token: 0x060173A9 RID: 95145 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60173A9")]
		[Address(RVA = "0xF8EDA0", Offset = "0xF8D9A0", VA = "0x180F8EDA0", Slot = "14")]
		public void LoopScrollAdapterBinderOnly_Bind(LoopScrollAdapterBinder binder)
		{
		}

		// Token: 0x060173AA RID: 95146 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60173AA")]
		[Address(RVA = "0xF8EBD0", Offset = "0xF8D7D0", VA = "0x180F8EBD0", Slot = "8")]
		public sealed override GameObject CreateView(Transform parent)
		{
			return null;
		}

		// Token: 0x060173AB RID: 95147 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60173AB")]
		[Address(RVA = "0xF8EF20", Offset = "0xF8DB20", VA = "0x180F8EF20", Slot = "13")]
		public sealed override void UpdateView(int position, GameObject view, GetComponentCache holder, object data)
		{
		}

		// Token: 0x060173AC RID: 95148 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60173AC")]
		[Address(RVA = "0xF8F030", Offset = "0xF8DC30", VA = "0x180F8F030")]
		public LoopScrollAdapterBehaviour()
		{
		}

		// Token: 0x0401C0A2 RID: 114850
		[Token(Token = "0x401C0A2")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private GameObject _prefab;

		// Token: 0x0401C0A3 RID: 114851
		[Token(Token = "0x401C0A3")]
		[FieldOffset(Offset = "0x60")]
		private LoopScrollAdapterBinder m_binder;

		// Token: 0x0401C0A4 RID: 114852
		[Token(Token = "0x401C0A4")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_LoopScrollAdapterBinderOnly_Bind;

		// Token: 0x0401C0A5 RID: 114853
		[Token(Token = "0x401C0A5")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_CreateView;

		// Token: 0x0401C0A6 RID: 114854
		[Token(Token = "0x401C0A6")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_UpdateView;

		// Token: 0x0401C0A7 RID: 114855
		[Token(Token = "0x401C0A7")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}

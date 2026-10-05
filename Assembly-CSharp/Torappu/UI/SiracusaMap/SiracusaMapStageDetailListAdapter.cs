using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Torappu.ObjectPool;
using UnityEngine;
using XLua;

namespace Torappu.UI.SiracusaMap
{
	// Token: 0x02003EFD RID: 16125
	[Token(Token = "0x2003EFD")]
	public class SiracusaMapStageDetailListAdapter : RecycleLoopScrollAdapter<SiracusaMapStageDetailItemHolder, SiracusaMapStageDetailInfoViewModel>
	{
		// Token: 0x17003BC9 RID: 15305
		// (get) Token: 0x0601908D RID: 102541 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0601908E RID: 102542 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17003BC9")]
		public Action<string> onDetailItemClick
		{
			[Token(Token = "0x601908D")]
			[Address(RVA = "0x11BF510", Offset = "0x11BE110", VA = "0x1811BF510")]
			[CompilerGenerated]
			private get
			{
				return null;
			}
			[Token(Token = "0x601908E")]
			[Address(RVA = "0x11BF570", Offset = "0x11BE170", VA = "0x1811BF570")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x0601908F RID: 102543 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601908F")]
		[Address(RVA = "0x11BF1B0", Offset = "0x11BDDB0", VA = "0x1811BF1B0", Slot = "13")]
		public override void UpdateView(int position, GameObject view, SiracusaMapStageDetailItemHolder holder, SiracusaMapStageDetailInfoViewModel data)
		{
		}

		// Token: 0x06019090 RID: 102544 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6019090")]
		[Address(RVA = "0x11BF380", Offset = "0x11BDF80", VA = "0x1811BF380", Slot = "14")]
		protected override GameObject ViewConstructor(GameObjectPool objectPool)
		{
			return null;
		}

		// Token: 0x06019091 RID: 102545 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019091")]
		[Address(RVA = "0x11BF4A0", Offset = "0x11BE0A0", VA = "0x1811BF4A0")]
		public SiracusaMapStageDetailListAdapter()
		{
		}

		// Token: 0x0401EF3C RID: 126780
		[Token(Token = "0x401EF3C")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private GameObject _detailItem;

		// Token: 0x0401EF3E RID: 126782
		[Token(Token = "0x401EF3E")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_onDetailItemClick;

		// Token: 0x0401EF3F RID: 126783
		[Token(Token = "0x401EF3F")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_onDetailItemClick;

		// Token: 0x0401EF40 RID: 126784
		[Token(Token = "0x401EF40")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_UpdateView;

		// Token: 0x0401EF41 RID: 126785
		[Token(Token = "0x401EF41")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_ViewConstructor;

		// Token: 0x0401EF42 RID: 126786
		[Token(Token = "0x401EF42")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}

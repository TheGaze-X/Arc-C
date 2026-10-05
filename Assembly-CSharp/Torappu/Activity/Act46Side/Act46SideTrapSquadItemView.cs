using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Torappu.UI;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Activity.Act46Side
{
	// Token: 0x020072A9 RID: 29353
	[Token(Token = "0x20072A9")]
	public class Act46SideTrapSquadItemView : MonoBehaviour, IHotfixable
	{
		// Token: 0x17006246 RID: 25158
		// (get) Token: 0x060298E4 RID: 170212 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060298E5 RID: 170213 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17006246")]
		public Action<string> onClicked
		{
			[Token(Token = "0x60298E4")]
			[Address(RVA = "0x24FF660", Offset = "0x24FE260", VA = "0x1824FF660")]
			[CompilerGenerated]
			private get
			{
				return null;
			}
			[Token(Token = "0x60298E5")]
			[Address(RVA = "0x24FF6C0", Offset = "0x24FE2C0", VA = "0x1824FF6C0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x060298E6 RID: 170214 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60298E6")]
		[Address(RVA = "0x24FF430", Offset = "0x24FE030", VA = "0x1824FF430")]
		public void Render(Act46SideTrapSquadView.TrapItemViewModel viewModel, string selectedTrapId)
		{
		}

		// Token: 0x060298E7 RID: 170215 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60298E7")]
		[Address(RVA = "0x24FF370", Offset = "0x24FDF70", VA = "0x1824FF370")]
		public void OnClicked()
		{
		}

		// Token: 0x060298E8 RID: 170216 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60298E8")]
		[Address(RVA = "0x24FF600", Offset = "0x24FE200", VA = "0x1824FF600")]
		public Act46SideTrapSquadItemView()
		{
		}

		// Token: 0x0403B6A9 RID: 243369
		[Token(Token = "0x403B6A9")]
		private const string TRAP_SMALL_ICON_NAME = "{0}_small";

		// Token: 0x0403B6AA RID: 243370
		[Token(Token = "0x403B6AA")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private GameObject _pnlSelected;

		// Token: 0x0403B6AB RID: 243371
		[Token(Token = "0x403B6AB")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GameObject _pnlUnselected;

		// Token: 0x0403B6AC RID: 243372
		[Token(Token = "0x403B6AC")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private GameObject _pnlLocked;

		// Token: 0x0403B6AD RID: 243373
		[Token(Token = "0x403B6AD")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Image _imgIconSelected;

		// Token: 0x0403B6AE RID: 243374
		[Token(Token = "0x403B6AE")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Image _imgIconUnselected;

		// Token: 0x0403B6AF RID: 243375
		[Token(Token = "0x403B6AF")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private GameObject _pnlTrackpoint;

		// Token: 0x0403B6B0 RID: 243376
		[Token(Token = "0x403B6B0")]
		[FieldOffset(Offset = "0x48")]
		private string m_cachedTrapId;

		// Token: 0x0403B6B1 RID: 243377
		[Token(Token = "0x403B6B1")]
		[FieldOffset(Offset = "0x50")]
		private UIStateFinder m_stateFinder;

		// Token: 0x0403B6B3 RID: 243379
		[Token(Token = "0x403B6B3")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_onClicked;

		// Token: 0x0403B6B4 RID: 243380
		[Token(Token = "0x403B6B4")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_onClicked;

		// Token: 0x0403B6B5 RID: 243381
		[Token(Token = "0x403B6B5")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0403B6B6 RID: 243382
		[Token(Token = "0x403B6B6")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnClicked;

		// Token: 0x0403B6B7 RID: 243383
		[Token(Token = "0x403B6B7")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}

using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI
{
	// Token: 0x020039C2 RID: 14786
	[Token(Token = "0x20039C2")]
	[RequireComponent(typeof(LayoutGroup))]
	public class SimpleLayoutContent : MonoBehaviour, IHotfixable
	{
		// Token: 0x060175BE RID: 95678 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60175BE")]
		[Address(RVA = "0xFB83F0", Offset = "0xFB6FF0", VA = "0x180FB83F0")]
		private void Start()
		{
		}

		// Token: 0x060175BF RID: 95679 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60175BF")]
		[Address(RVA = "0xFB8150", Offset = "0xFB6D50", VA = "0x180FB8150")]
		private void OnDestroy()
		{
		}

		// Token: 0x170037F0 RID: 14320
		// (get) Token: 0x060175C0 RID: 95680 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060175C1 RID: 95681 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170037F0")]
		public SimpleLayoutAdapter adapter
		{
			[Token(Token = "0x60175C0")]
			[Address(RVA = "0xFB8710", Offset = "0xFB7310", VA = "0x180FB8710")]
			get
			{
				return null;
			}
			[Token(Token = "0x60175C1")]
			[Address(RVA = "0xFB8770", Offset = "0xFB7370", VA = "0x180FB8770")]
			set
			{
			}
		}

		// Token: 0x060175C2 RID: 95682 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60175C2")]
		[Address(RVA = "0xFB80F0", Offset = "0xFB6CF0", VA = "0x180FB80F0")]
		public GameObject GetViewPrefab()
		{
			return null;
		}

		// Token: 0x060175C3 RID: 95683 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60175C3")]
		[Address(RVA = "0xFB8620", Offset = "0xFB7220", VA = "0x180FB8620")]
		private void _ObserveAdapter(SimpleLayoutAdapter adapter)
		{
		}

		// Token: 0x060175C4 RID: 95684 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60175C4")]
		[Address(RVA = "0xFB81C0", Offset = "0xFB6DC0", VA = "0x180FB81C0", Slot = "4")]
		protected virtual void RefreshViews()
		{
		}

		// Token: 0x060175C5 RID: 95685 RVA: 0x00096288 File Offset: 0x00094488
		[Token(Token = "0x60175C5")]
		[Address(RVA = "0xFB8450", Offset = "0xFB7050", VA = "0x180FB8450")]
		private bool _EnsureInHierarchyTemplateHidden()
		{
			return default(bool);
		}

		// Token: 0x060175C6 RID: 95686 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60175C6")]
		[Address(RVA = "0xFB86B0", Offset = "0xFB72B0", VA = "0x180FB86B0")]
		public SimpleLayoutContent()
		{
		}

		// Token: 0x0401C349 RID: 115529
		[Token(Token = "0x401C349")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private GameObject _viewPrefab;

		// Token: 0x0401C34A RID: 115530
		[Token(Token = "0x401C34A")]
		[FieldOffset(Offset = "0x20")]
		private SimpleLayoutAdapter m_adapter;

		// Token: 0x0401C34B RID: 115531
		[Token(Token = "0x401C34B")]
		[FieldOffset(Offset = "0x28")]
		private bool? m_isViewTemplateInHierarchy;

		// Token: 0x0401C34C RID: 115532
		[Token(Token = "0x401C34C")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Start;

		// Token: 0x0401C34D RID: 115533
		[Token(Token = "0x401C34D")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnDestroy;

		// Token: 0x0401C34E RID: 115534
		[Token(Token = "0x401C34E")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_adapter;

		// Token: 0x0401C34F RID: 115535
		[Token(Token = "0x401C34F")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_set_adapter;

		// Token: 0x0401C350 RID: 115536
		[Token(Token = "0x401C350")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_GetViewPrefab;

		// Token: 0x0401C351 RID: 115537
		[Token(Token = "0x401C351")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__ObserveAdapter;

		// Token: 0x0401C352 RID: 115538
		[Token(Token = "0x401C352")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_RefreshViews;

		// Token: 0x0401C353 RID: 115539
		[Token(Token = "0x401C353")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__EnsureInHierarchyTemplateHidden;

		// Token: 0x0401C354 RID: 115540
		[Token(Token = "0x401C354")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}

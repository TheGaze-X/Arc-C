using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI
{
	// Token: 0x020037EB RID: 14315
	[Token(Token = "0x20037EB")]
	public class UICommonPageEffectHolder : MonoBehaviour, IPageUIRenderer, IHotfixable
	{
		// Token: 0x06016B0B RID: 92939 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6016B0B")]
		[Address(RVA = "0xF11680", Offset = "0xF10280", VA = "0x180F11680")]
		public void Bind(UIPage pageToBind)
		{
		}

		// Token: 0x06016B0C RID: 92940 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6016B0C")]
		[Address(RVA = "0xF119B0", Offset = "0xF105B0", VA = "0x180F119B0")]
		public void Unbind()
		{
		}

		// Token: 0x06016B0D RID: 92941 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6016B0D")]
		[Address(RVA = "0xF11920", Offset = "0xF10520", VA = "0x180F11920")]
		public void SetEffectEnable(bool enable = true)
		{
		}

		// Token: 0x06016B0E RID: 92942 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6016B0E")]
		[Address(RVA = "0xF117F0", Offset = "0xF103F0", VA = "0x180F117F0", Slot = "4")]
		public void InitSortingInfo(SortingInfo sortingInfo)
		{
		}

		// Token: 0x06016B0F RID: 92943 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6016B0F")]
		[Address(RVA = "0xF115D0", Offset = "0xF101D0", VA = "0x180F115D0", Slot = "5")]
		public void AdjustToTargetLayer(SortingInfo sortingInfo)
		{
		}

		// Token: 0x06016B10 RID: 92944 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6016B10")]
		[Address(RVA = "0xF118A0", Offset = "0xF104A0", VA = "0x180F118A0", Slot = "6")]
		public void RestoreLayers()
		{
		}

		// Token: 0x06016B11 RID: 92945 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6016B11")]
		[Address(RVA = "0xF11AE0", Offset = "0xF106E0", VA = "0x180F11AE0")]
		private void _BindToPage()
		{
		}

		// Token: 0x06016B12 RID: 92946 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6016B12")]
		[Address(RVA = "0xF11CF0", Offset = "0xF108F0", VA = "0x180F11CF0")]
		private void _UnbindFromPage()
		{
		}

		// Token: 0x06016B13 RID: 92947 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6016B13")]
		[Address(RVA = "0xF11BA0", Offset = "0xF107A0", VA = "0x180F11BA0")]
		private void _InitCacheIfNot()
		{
		}

		// Token: 0x06016B14 RID: 92948 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6016B14")]
		[Address(RVA = "0xF11DB0", Offset = "0xF109B0", VA = "0x180F11DB0")]
		public UICommonPageEffectHolder()
		{
		}

		// Token: 0x0401B58C RID: 112012
		[Token(Token = "0x401B58C")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private ScreenEffectHolder _effectHolder;

		// Token: 0x0401B58D RID: 112013
		[Token(Token = "0x401B58D")]
		[FieldOffset(Offset = "0x20")]
		private bool m_isInited;

		// Token: 0x0401B58E RID: 112014
		[Token(Token = "0x401B58E")]
		[FieldOffset(Offset = "0x28")]
		private UIRendererSortingInfoStorage m_sortingInfo;

		// Token: 0x0401B58F RID: 112015
		[Token(Token = "0x401B58F")]
		[FieldOffset(Offset = "0x30")]
		private UIPage m_registeredPage;

		// Token: 0x0401B590 RID: 112016
		[Token(Token = "0x401B590")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Bind;

		// Token: 0x0401B591 RID: 112017
		[Token(Token = "0x401B591")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_Unbind;

		// Token: 0x0401B592 RID: 112018
		[Token(Token = "0x401B592")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_SetEffectEnable;

		// Token: 0x0401B593 RID: 112019
		[Token(Token = "0x401B593")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_InitSortingInfo;

		// Token: 0x0401B594 RID: 112020
		[Token(Token = "0x401B594")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_AdjustToTargetLayer;

		// Token: 0x0401B595 RID: 112021
		[Token(Token = "0x401B595")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_RestoreLayers;

		// Token: 0x0401B596 RID: 112022
		[Token(Token = "0x401B596")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__BindToPage;

		// Token: 0x0401B597 RID: 112023
		[Token(Token = "0x401B597")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__UnbindFromPage;

		// Token: 0x0401B598 RID: 112024
		[Token(Token = "0x401B598")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__InitCacheIfNot;

		// Token: 0x0401B599 RID: 112025
		[Token(Token = "0x401B599")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}

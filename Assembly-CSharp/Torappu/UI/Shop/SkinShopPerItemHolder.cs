using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.Shop
{
	// Token: 0x02005B62 RID: 23394
	[Token(Token = "0x2005B62")]
	public class SkinShopPerItemHolder : MonoBehaviour, IExposure, IHotfixable
	{
		// Token: 0x06021F4C RID: 139084 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021F4C")]
		[Address(RVA = "0x1C7DB50", Offset = "0x1C7C750", VA = "0x181C7DB50")]
		private void _InitSkinShopPerSkinItemViewIfNecessary()
		{
		}

		// Token: 0x06021F4D RID: 139085 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021F4D")]
		[Address(RVA = "0x1C7DA10", Offset = "0x1C7C610", VA = "0x181C7DA10")]
		private void _InitSkinShopPerBlindboxItemViewIfNecessary()
		{
		}

		// Token: 0x06021F4E RID: 139086 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021F4E")]
		[Address(RVA = "0x1C7D670", Offset = "0x1C7C270", VA = "0x181C7D670")]
		public void Render(ISkinShopItemViewModel viewModel)
		{
		}

		// Token: 0x06021F4F RID: 139087 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021F4F")]
		[Address(RVA = "0x1C7D5E0", Offset = "0x1C7C1E0", VA = "0x181C7D5E0")]
		public void RenderButton()
		{
		}

		// Token: 0x06021F50 RID: 139088 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021F50")]
		[Address(RVA = "0x1C7D250", Offset = "0x1C7BE50", VA = "0x181C7D250")]
		public void GoToWardrobe()
		{
		}

		// Token: 0x06021F51 RID: 139089 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021F51")]
		[Address(RVA = "0x1C7DC90", Offset = "0x1C7C890", VA = "0x181C7DC90")]
		private void _OnExpose()
		{
		}

		// Token: 0x06021F52 RID: 139090 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021F52")]
		[Address(RVA = "0x1C7D4D0", Offset = "0x1C7C0D0", VA = "0x181C7D4D0")]
		private void OnEnable()
		{
		}

		// Token: 0x06021F53 RID: 139091 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021F53")]
		[Address(RVA = "0x1C7D420", Offset = "0x1C7C020", VA = "0x181C7D420")]
		private void OnDisable()
		{
		}

		// Token: 0x06021F54 RID: 139092 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021F54")]
		[Address(RVA = "0x1C7D2C0", Offset = "0x1C7BEC0", VA = "0x181C7D2C0")]
		private void OnDestroy()
		{
		}

		// Token: 0x17004F75 RID: 20341
		// (get) Token: 0x06021F55 RID: 139093 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17004F75")]
		public string exposureId
		{
			[Token(Token = "0x6021F55")]
			[Address(RVA = "0x1C7DE30", Offset = "0x1C7CA30", VA = "0x181C7DE30", Slot = "4")]
			get
			{
				return null;
			}
		}

		// Token: 0x17004F76 RID: 20342
		// (get) Token: 0x06021F56 RID: 139094 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17004F76")]
		public Action onExpose
		{
			[Token(Token = "0x6021F56")]
			[Address(RVA = "0x1C7DF50", Offset = "0x1C7CB50", VA = "0x181C7DF50", Slot = "5")]
			get
			{
				return null;
			}
		}

		// Token: 0x17004F77 RID: 20343
		// (get) Token: 0x06021F57 RID: 139095 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17004F77")]
		public RectTransform exposureRectTransform
		{
			[Token(Token = "0x6021F57")]
			[Address(RVA = "0x1C7DEC0", Offset = "0x1C7CAC0", VA = "0x181C7DEC0", Slot = "6")]
			get
			{
				return null;
			}
		}

		// Token: 0x17004F78 RID: 20344
		// (get) Token: 0x06021F58 RID: 139096 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06021F59 RID: 139097 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17004F78")]
		public Action<IExposure> registerExposure
		{
			[Token(Token = "0x6021F58")]
			[Address(RVA = "0x1C7E000", Offset = "0x1C7CC00", VA = "0x181C7E000", Slot = "7")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6021F59")]
			[Address(RVA = "0x1C7E120", Offset = "0x1C7CD20", VA = "0x181C7E120", Slot = "8")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17004F79 RID: 20345
		// (get) Token: 0x06021F5A RID: 139098 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06021F5B RID: 139099 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17004F79")]
		public Action<IExposure> unregisterExposure
		{
			[Token(Token = "0x6021F5A")]
			[Address(RVA = "0x1C7E0C0", Offset = "0x1C7CCC0", VA = "0x181C7E0C0", Slot = "9")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6021F5B")]
			[Address(RVA = "0x1C7E220", Offset = "0x1C7CE20", VA = "0x181C7E220", Slot = "10")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17004F7A RID: 20346
		// (get) Token: 0x06021F5C RID: 139100 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06021F5D RID: 139101 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17004F7A")]
		public Action tickExposure
		{
			[Token(Token = "0x6021F5C")]
			[Address(RVA = "0x1C7E060", Offset = "0x1C7CC60", VA = "0x181C7E060", Slot = "11")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6021F5D")]
			[Address(RVA = "0x1C7E1A0", Offset = "0x1C7CDA0", VA = "0x181C7E1A0", Slot = "12")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x06021F5E RID: 139102 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021F5E")]
		[Address(RVA = "0x1C7DDD0", Offset = "0x1C7C9D0", VA = "0x181C7DDD0")]
		public SkinShopPerItemHolder()
		{
		}

		// Token: 0x0402E854 RID: 190548
		[Token(Token = "0x402E854")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Transform _container;

		// Token: 0x0402E855 RID: 190549
		[Token(Token = "0x402E855")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GameObject _button;

		// Token: 0x0402E856 RID: 190550
		[Token(Token = "0x402E856")]
		[FieldOffset(Offset = "0x28")]
		private SkinShopPerItemView m_skinItemView;

		// Token: 0x0402E857 RID: 190551
		[Token(Token = "0x402E857")]
		[FieldOffset(Offset = "0x30")]
		private SkinShopPerBlindboxItemView m_blindboxItemView;

		// Token: 0x0402E858 RID: 190552
		[Token(Token = "0x402E858")]
		[FieldOffset(Offset = "0x38")]
		private UIPageFinder m_pageFinder;

		// Token: 0x0402E859 RID: 190553
		[Token(Token = "0x402E859")]
		[FieldOffset(Offset = "0x48")]
		private ISkinShopItemViewModel m_viewModel;

		// Token: 0x0402E85D RID: 190557
		[Token(Token = "0x402E85D")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0__InitSkinShopPerSkinItemViewIfNecessary;

		// Token: 0x0402E85E RID: 190558
		[Token(Token = "0x402E85E")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__InitSkinShopPerBlindboxItemViewIfNecessary;

		// Token: 0x0402E85F RID: 190559
		[Token(Token = "0x402E85F")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0402E860 RID: 190560
		[Token(Token = "0x402E860")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_RenderButton;

		// Token: 0x0402E861 RID: 190561
		[Token(Token = "0x402E861")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_GoToWardrobe;

		// Token: 0x0402E862 RID: 190562
		[Token(Token = "0x402E862")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__OnExpose;

		// Token: 0x0402E863 RID: 190563
		[Token(Token = "0x402E863")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_OnEnable;

		// Token: 0x0402E864 RID: 190564
		[Token(Token = "0x402E864")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_OnDisable;

		// Token: 0x0402E865 RID: 190565
		[Token(Token = "0x402E865")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_OnDestroy;

		// Token: 0x0402E866 RID: 190566
		[Token(Token = "0x402E866")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_get_exposureId;

		// Token: 0x0402E867 RID: 190567
		[Token(Token = "0x402E867")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_get_onExpose;

		// Token: 0x0402E868 RID: 190568
		[Token(Token = "0x402E868")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_get_exposureRectTransform;

		// Token: 0x0402E869 RID: 190569
		[Token(Token = "0x402E869")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0_get_registerExposure;

		// Token: 0x0402E86A RID: 190570
		[Token(Token = "0x402E86A")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0_set_registerExposure;

		// Token: 0x0402E86B RID: 190571
		[Token(Token = "0x402E86B")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0_get_unregisterExposure;

		// Token: 0x0402E86C RID: 190572
		[Token(Token = "0x402E86C")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0_set_unregisterExposure;

		// Token: 0x0402E86D RID: 190573
		[Token(Token = "0x402E86D")]
		[FieldOffset(Offset = "0x80")]
		private static DelegateBridge __Hotfix0_get_tickExposure;

		// Token: 0x0402E86E RID: 190574
		[Token(Token = "0x402E86E")]
		[FieldOffset(Offset = "0x88")]
		private static DelegateBridge __Hotfix0_set_tickExposure;

		// Token: 0x0402E86F RID: 190575
		[Token(Token = "0x402E86F")]
		[FieldOffset(Offset = "0x90")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}

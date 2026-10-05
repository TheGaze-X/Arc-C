using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Roguelike
{
	// Token: 0x020051CE RID: 20942
	[Token(Token = "0x20051CE")]
	public abstract class RoguelikeCustomizableItemIcon : MonoBehaviour, IHotfixable
	{
		// Token: 0x17004838 RID: 18488
		// (get) Token: 0x0601EEE9 RID: 126697 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0601EEEA RID: 126698 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17004838")]
		public ILoadAsset assetLoader
		{
			[Token(Token = "0x601EEE9")]
			[Address(RVA = "0x18B1400", Offset = "0x18B0000", VA = "0x1818B1400")]
			protected get
			{
				return null;
			}
			[Token(Token = "0x601EEEA")]
			[Address(RVA = "0x18B1550", Offset = "0x18B0150", VA = "0x1818B1550")]
			set
			{
			}
		}

		// Token: 0x17004839 RID: 18489
		// (get) Token: 0x0601EEEB RID: 126699 RVA: 0x000B02E0 File Offset: 0x000AE4E0
		// (set) Token: 0x0601EEEC RID: 126700 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17004839")]
		public float scale
		{
			[Token(Token = "0x601EEEB")]
			[Address(RVA = "0x18B1490", Offset = "0x18B0090", VA = "0x1818B1490")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x601EEEC")]
			[Address(RVA = "0x18B15D0", Offset = "0x18B01D0", VA = "0x1818B15D0")]
			set
			{
			}
		}

		// Token: 0x1700483A RID: 18490
		// (get) Token: 0x0601EEED RID: 126701
		[Token(Token = "0x1700483A")]
		public abstract Graphic graphic { [Token(Token = "0x601EEED")] get; }

		// Token: 0x0601EEEE RID: 126702
		[Token(Token = "0x601EEEE")]
		public abstract void Render(string topicId, string itemId, RoguelikeGameItemType itemType);

		// Token: 0x0601EEEF RID: 126703 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601EEEF")]
		[Address(RVA = "0x18B13A0", Offset = "0x18AFFA0", VA = "0x1818B13A0")]
		protected RoguelikeCustomizableItemIcon()
		{
		}

		// Token: 0x04029814 RID: 170004
		[Token(Token = "0x4029814")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private UIScaler _scaler;

		// Token: 0x04029815 RID: 170005
		[Token(Token = "0x4029815")]
		[FieldOffset(Offset = "0x20")]
		private UIPageFinder m_pageFinder;

		// Token: 0x04029816 RID: 170006
		[Token(Token = "0x4029816")]
		[FieldOffset(Offset = "0x30")]
		private ILoadAsset m_assetLoader;

		// Token: 0x04029817 RID: 170007
		[Token(Token = "0x4029817")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_assetLoader;

		// Token: 0x04029818 RID: 170008
		[Token(Token = "0x4029818")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_assetLoader;

		// Token: 0x04029819 RID: 170009
		[Token(Token = "0x4029819")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_scale;

		// Token: 0x0402981A RID: 170010
		[Token(Token = "0x402981A")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_set_scale;

		// Token: 0x0402981B RID: 170011
		[Token(Token = "0x402981B")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}

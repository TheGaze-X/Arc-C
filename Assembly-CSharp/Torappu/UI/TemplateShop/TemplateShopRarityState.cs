using System;
using System.Collections;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.TemplateShop
{
	// Token: 0x02003D43 RID: 15683
	[Token(Token = "0x2003D43")]
	public class TemplateShopRarityState : PopupFadeState
	{
		// Token: 0x060186EC RID: 100076 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60186EC")]
		[Address(RVA = "0x10F7A60", Offset = "0x10F6660", VA = "0x1810F7A60", Slot = "9")]
		public override IStateBean GetCacheBean()
		{
			return null;
		}

		// Token: 0x060186ED RID: 100077 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60186ED")]
		[Address(RVA = "0x10F83C0", Offset = "0x10F6FC0", VA = "0x1810F83C0", Slot = "15")]
		protected override void OnResume()
		{
		}

		// Token: 0x060186EE RID: 100078 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60186EE")]
		[Address(RVA = "0x10F7AC0", Offset = "0x10F66C0", VA = "0x1810F7AC0", Slot = "14")]
		protected override void OnEnter()
		{
		}

		// Token: 0x060186EF RID: 100079 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60186EF")]
		[Address(RVA = "0x10F84D0", Offset = "0x10F70D0", VA = "0x1810F84D0")]
		private IEnumerator _FocusListRarity()
		{
			return null;
		}

		// Token: 0x060186F0 RID: 100080 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60186F0")]
		[Address(RVA = "0x10F8580", Offset = "0x10F7180", VA = "0x1810F8580")]
		public TemplateShopRarityState()
		{
		}

		// Token: 0x060186F1 RID: 100081 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60186F1")]
		[Address(RVA = "0xE0F5F0", Offset = "0xE0E1F0", VA = "0x180E0F5F0")]
		private void <>xLuaBaseProxy_OnResume()
		{
		}

		// Token: 0x060186F2 RID: 100082 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60186F2")]
		[Address(RVA = "0xE63450", Offset = "0xE62050", VA = "0x180E63450")]
		private void <>xLuaBaseProxy_OnEnter()
		{
		}

		// Token: 0x0401DE40 RID: 122432
		[Token(Token = "0x401DE40")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private PrefabInstHolder _topMenuHolder;

		// Token: 0x0401DE41 RID: 122433
		[Token(Token = "0x401DE41")]
		[FieldOffset(Offset = "0x78")]
		private TemplateRarityShopStateBean m_stateBean;

		// Token: 0x0401DE42 RID: 122434
		[Token(Token = "0x401DE42")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private TemplateShopRarityListView _listView;

		// Token: 0x0401DE43 RID: 122435
		[Token(Token = "0x401DE43")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		private Image _shopIcon;

		// Token: 0x0401DE44 RID: 122436
		[Token(Token = "0x401DE44")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		private Text _shopName;

		// Token: 0x0401DE45 RID: 122437
		[Token(Token = "0x401DE45")]
		[FieldOffset(Offset = "0x98")]
		[SerializeField]
		private Image _shopLongBar;

		// Token: 0x0401DE46 RID: 122438
		[Token(Token = "0x401DE46")]
		[FieldOffset(Offset = "0xA0")]
		[SerializeField]
		private Image _shopBack;

		// Token: 0x0401DE47 RID: 122439
		[Token(Token = "0x401DE47")]
		[FieldOffset(Offset = "0xA8")]
		[SerializeField]
		private Text _timeText;

		// Token: 0x0401DE48 RID: 122440
		[Token(Token = "0x401DE48")]
		[FieldOffset(Offset = "0xB0")]
		[SerializeField]
		private Text _remainText;

		// Token: 0x0401DE49 RID: 122441
		[Token(Token = "0x401DE49")]
		[FieldOffset(Offset = "0xB8")]
		[SerializeField]
		private Transform _titleContainer;

		// Token: 0x0401DE4A RID: 122442
		[Token(Token = "0x401DE4A")]
		[FieldOffset(Offset = "0xC0")]
		private TemplateShopResHolder m_resHolder;

		// Token: 0x0401DE4B RID: 122443
		[Token(Token = "0x401DE4B")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetCacheBean;

		// Token: 0x0401DE4C RID: 122444
		[Token(Token = "0x401DE4C")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnResume;

		// Token: 0x0401DE4D RID: 122445
		[Token(Token = "0x401DE4D")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnEnter;

		// Token: 0x0401DE4E RID: 122446
		[Token(Token = "0x401DE4E")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__FocusListRarity;

		// Token: 0x0401DE4F RID: 122447
		[Token(Token = "0x401DE4F")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}

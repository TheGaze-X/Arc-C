using System;
using System.Collections;
using Il2CppDummyDll;
using Torappu.AsyncLoader;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.TemplateShop
{
	// Token: 0x02003D40 RID: 15680
	[Token(Token = "0x2003D40")]
	public class TemplateShopGroupState : PopupFadeState, ITimeWatcher
	{
		// Token: 0x060186D8 RID: 100056 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60186D8")]
		[Address(RVA = "0x10F3D10", Offset = "0x10F2910", VA = "0x1810F3D10", Slot = "9")]
		public override IStateBean GetCacheBean()
		{
			return null;
		}

		// Token: 0x060186D9 RID: 100057 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60186D9")]
		[Address(RVA = "0x10F45D0", Offset = "0x10F31D0", VA = "0x1810F45D0", Slot = "31")]
		public void UpdateTime(float delta)
		{
		}

		// Token: 0x060186DA RID: 100058 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60186DA")]
		[Address(RVA = "0x10F3DD0", Offset = "0x10F29D0", VA = "0x1810F3DD0")]
		private void OnEnable()
		{
		}

		// Token: 0x060186DB RID: 100059 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60186DB")]
		[Address(RVA = "0x10F3D70", Offset = "0x10F2970", VA = "0x1810F3D70")]
		private void OnDisable()
		{
		}

		// Token: 0x060186DC RID: 100060 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60186DC")]
		[Address(RVA = "0x10F4490", Offset = "0x10F3090", VA = "0x1810F4490", Slot = "15")]
		protected override void OnResume()
		{
		}

		// Token: 0x060186DD RID: 100061 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60186DD")]
		[Address(RVA = "0x10F3E30", Offset = "0x10F2A30", VA = "0x1810F3E30", Slot = "14")]
		protected override void OnEnter()
		{
		}

		// Token: 0x060186DE RID: 100062 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60186DE")]
		[Address(RVA = "0x10F4650", Offset = "0x10F3250", VA = "0x1810F4650")]
		private IEnumerator _FocusOnLatest()
		{
			return null;
		}

		// Token: 0x060186DF RID: 100063 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60186DF")]
		[Address(RVA = "0x10F4700", Offset = "0x10F3300", VA = "0x1810F4700")]
		public TemplateShopGroupState()
		{
		}

		// Token: 0x060186E0 RID: 100064 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60186E0")]
		[Address(RVA = "0xE0F5F0", Offset = "0xE0E1F0", VA = "0x180E0F5F0")]
		private void <>xLuaBaseProxy_OnResume()
		{
		}

		// Token: 0x060186E1 RID: 100065 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60186E1")]
		[Address(RVA = "0xE63450", Offset = "0xE62050", VA = "0x180E63450")]
		private void <>xLuaBaseProxy_OnEnter()
		{
		}

		// Token: 0x0401DE27 RID: 122407
		[Token(Token = "0x401DE27")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private PrefabInstHolder _topMenuHolder;

		// Token: 0x0401DE28 RID: 122408
		[Token(Token = "0x401DE28")]
		[FieldOffset(Offset = "0x78")]
		private TemplateGroupShopStateBean m_stateBean;

		// Token: 0x0401DE29 RID: 122409
		[Token(Token = "0x401DE29")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private TemplateShopGroupListView _listView;

		// Token: 0x0401DE2A RID: 122410
		[Token(Token = "0x401DE2A")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		private Image _shopIcon;

		// Token: 0x0401DE2B RID: 122411
		[Token(Token = "0x401DE2B")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		private Text _shopName;

		// Token: 0x0401DE2C RID: 122412
		[Token(Token = "0x401DE2C")]
		[FieldOffset(Offset = "0x98")]
		[SerializeField]
		private Image _shopLongBar;

		// Token: 0x0401DE2D RID: 122413
		[Token(Token = "0x401DE2D")]
		[FieldOffset(Offset = "0xA0")]
		[SerializeField]
		private Image _shopBack;

		// Token: 0x0401DE2E RID: 122414
		[Token(Token = "0x401DE2E")]
		[FieldOffset(Offset = "0xA8")]
		[SerializeField]
		private Text _timeText;

		// Token: 0x0401DE2F RID: 122415
		[Token(Token = "0x401DE2F")]
		[FieldOffset(Offset = "0xB0")]
		[SerializeField]
		private Transform _titleContainer;

		// Token: 0x0401DE30 RID: 122416
		[Token(Token = "0x401DE30")]
		[FieldOffset(Offset = "0xB8")]
		private TemplateShopResHolder m_resHolder;

		// Token: 0x0401DE31 RID: 122417
		[Token(Token = "0x401DE31")]
		[FieldOffset(Offset = "0xC0")]
		private AsyncGameObjectLoader m_objLoader;

		// Token: 0x0401DE32 RID: 122418
		[Token(Token = "0x401DE32")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetCacheBean;

		// Token: 0x0401DE33 RID: 122419
		[Token(Token = "0x401DE33")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_UpdateTime;

		// Token: 0x0401DE34 RID: 122420
		[Token(Token = "0x401DE34")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnEnable;

		// Token: 0x0401DE35 RID: 122421
		[Token(Token = "0x401DE35")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnDisable;

		// Token: 0x0401DE36 RID: 122422
		[Token(Token = "0x401DE36")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_OnResume;

		// Token: 0x0401DE37 RID: 122423
		[Token(Token = "0x401DE37")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_OnEnter;

		// Token: 0x0401DE38 RID: 122424
		[Token(Token = "0x401DE38")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__FocusOnLatest;

		// Token: 0x0401DE39 RID: 122425
		[Token(Token = "0x401DE39")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}

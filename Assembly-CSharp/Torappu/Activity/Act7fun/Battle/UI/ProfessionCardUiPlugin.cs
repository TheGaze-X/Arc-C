using System;
using Il2CppDummyDll;
using Torappu.Battle.UI;
using Torappu.ObjectPool;
using UnityEngine;
using XLua;

namespace Torappu.Activity.Act7Fun.Battle.UI
{
	// Token: 0x020071A4 RID: 29092
	[Token(Token = "0x20071A4")]
	public class ProfessionCardUiPlugin : BattleReusableUI, UICard.IUICardPlugin, IReusableObject, IReusable, IPtrObject
	{
		// Token: 0x170061B1 RID: 25009
		// (get) Token: 0x06029485 RID: 169093 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170061B1")]
		public string pluginId
		{
			[Token(Token = "0x6029485")]
			[Address(RVA = "0x24BEAE0", Offset = "0x24BD6E0", VA = "0x1824BEAE0", Slot = "9")]
			get
			{
				return null;
			}
		}

		// Token: 0x06029486 RID: 169094 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029486")]
		[Address(RVA = "0x24BE960", Offset = "0x24BD560", VA = "0x1824BE960", Slot = "12")]
		public void OnAppearanceRefresh(UICard card)
		{
		}

		// Token: 0x06029487 RID: 169095 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029487")]
		[Address(RVA = "0x24BE9F0", Offset = "0x24BD5F0", VA = "0x1824BE9F0", Slot = "13")]
		public void OnRender(UICard card)
		{
		}

		// Token: 0x06029488 RID: 169096 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6029488")]
		[Address(RVA = "0x24BE900", Offset = "0x24BD500", VA = "0x1824BE900", Slot = "16")]
		public MonoBehaviour GetRootMono()
		{
			return null;
		}

		// Token: 0x06029489 RID: 169097 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029489")]
		[Address(RVA = "0x24BEA80", Offset = "0x24BD680", VA = "0x1824BEA80")]
		public ProfessionCardUiPlugin()
		{
		}

		// Token: 0x0403AF5F RID: 241503
		[Token(Token = "0x403AF5F")]
		private const string PLUGIN_ID = "ProfessionCardUiPlugin";

		// Token: 0x0403AF60 RID: 241504
		[Token(Token = "0x403AF60")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Sprite _professionSprite;

		// Token: 0x0403AF61 RID: 241505
		[Token(Token = "0x403AF61")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Color _maskColor;

		// Token: 0x0403AF62 RID: 241506
		[Token(Token = "0x403AF62")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_pluginId;

		// Token: 0x0403AF63 RID: 241507
		[Token(Token = "0x403AF63")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnAppearanceRefresh;

		// Token: 0x0403AF64 RID: 241508
		[Token(Token = "0x403AF64")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnRender;

		// Token: 0x0403AF65 RID: 241509
		[Token(Token = "0x403AF65")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_GetRootMono;

		// Token: 0x0403AF66 RID: 241510
		[Token(Token = "0x403AF66")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}

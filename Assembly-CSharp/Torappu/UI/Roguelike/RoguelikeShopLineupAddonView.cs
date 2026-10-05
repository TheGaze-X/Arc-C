using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.Roguelike
{
	// Token: 0x02005506 RID: 21766
	[Token(Token = "0x2005506")]
	public abstract class RoguelikeShopLineupAddonView : MonoBehaviour, IHotfixable
	{
		// Token: 0x17004B19 RID: 19225
		// (get) Token: 0x06020037 RID: 131127 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06020038 RID: 131128 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17004B19")]
		private protected RoguelikeShopLineupControllerBindings bindings
		{
			[Token(Token = "0x6020037")]
			[Address(RVA = "0x1A237C0", Offset = "0x1A223C0", VA = "0x181A237C0")]
			[CompilerGenerated]
			protected get
			{
				return null;
			}
			[Token(Token = "0x6020038")]
			[Address(RVA = "0x1A23820", Offset = "0x1A22420", VA = "0x181A23820")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x06020039 RID: 131129 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020039")]
		[Address(RVA = "0x1A232A0", Offset = "0x1A21EA0", VA = "0x181A232A0")]
		public void OnValueChange(RoguelikeGameShopViewModel model)
		{
		}

		// Token: 0x0602003A RID: 131130 RVA: 0x000B43F0 File Offset: 0x000B25F0
		[Token(Token = "0x602003A")]
		[Address(RVA = "0x1A23480", Offset = "0x1A22080", VA = "0x181A23480")]
		public float SetShow(bool isShow, bool fastMode)
		{
			return 0f;
		}

		// Token: 0x0602003B RID: 131131 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602003B")]
		[Address(RVA = "0x1A22EC0", Offset = "0x1A21AC0", VA = "0x181A22EC0")]
		public void BindShopController(RoguelikeShopLineupControllerBindings bind)
		{
		}

		// Token: 0x0602003C RID: 131132
		[Token(Token = "0x602003C")]
		protected abstract void OnDataChange(RoguelikeGameShopViewModel model);

		// Token: 0x0602003D RID: 131133 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602003D")]
		[Address(RVA = "0x1A23620", Offset = "0x1A22220", VA = "0x181A23620")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0602003E RID: 131134 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602003E")]
		[Address(RVA = "0x1A23700", Offset = "0x1A22300", VA = "0x181A23700")]
		protected RoguelikeShopLineupAddonView()
		{
		}

		// Token: 0x0402B376 RID: 177014
		[Token(Token = "0x402B376")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private CanvasGroup _rootGroup;

		// Token: 0x0402B377 RID: 177015
		[Token(Token = "0x402B377")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private float _fadeDuration;

		// Token: 0x0402B378 RID: 177016
		[Token(Token = "0x402B378")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Transform _pluginContainer;

		// Token: 0x0402B379 RID: 177017
		[Token(Token = "0x402B379")]
		[FieldOffset(Offset = "0x30")]
		private readonly List<RoguelikeShopLineupAddonPlugin> m_plugins;

		// Token: 0x0402B37A RID: 177018
		[Token(Token = "0x402B37A")]
		[FieldOffset(Offset = "0x38")]
		private bool m_hasInited;

		// Token: 0x0402B37B RID: 177019
		[Token(Token = "0x402B37B")]
		[FieldOffset(Offset = "0x40")]
		private UISwitchTween m_rootSwitchTween;

		// Token: 0x0402B37D RID: 177021
		[Token(Token = "0x402B37D")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_bindings;

		// Token: 0x0402B37E RID: 177022
		[Token(Token = "0x402B37E")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_bindings;

		// Token: 0x0402B37F RID: 177023
		[Token(Token = "0x402B37F")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnValueChange;

		// Token: 0x0402B380 RID: 177024
		[Token(Token = "0x402B380")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_SetShow;

		// Token: 0x0402B381 RID: 177025
		[Token(Token = "0x402B381")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_BindShopController;

		// Token: 0x0402B382 RID: 177026
		[Token(Token = "0x402B382")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0402B383 RID: 177027
		[Token(Token = "0x402B383")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}

using System;
using System.Collections;
using Il2CppDummyDll;
using Torappu.Notification;
using UnityEngine;
using XLua;

namespace Torappu.Battle.UI
{
	// Token: 0x020032E8 RID: 13032
	[Token(Token = "0x20032E8")]
	public class BattleNotification : SingletonMonoBehaviour<BattleNotification>, ISingletonNotAutoCreate
	{
		// Token: 0x06014B58 RID: 84824 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014B58")]
		[Address(RVA = "0xD18120", Offset = "0xD16D20", VA = "0x180D18120", Slot = "4")]
		protected override void OnInit()
		{
		}

		// Token: 0x06014B59 RID: 84825 RVA: 0x00088110 File Offset: 0x00086310
		[Token(Token = "0x6014B59")]
		public bool AddNotifyView<ViewType, ParamType>(NotifyViewOptions<ViewType, ParamType> options) where ViewType : NotifyView, IFloatNotifyView where ParamType : NotifyViewParam
		{
			return default(bool);
		}

		// Token: 0x06014B5A RID: 84826 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014B5A")]
		[Address(RVA = "0xD17FD0", Offset = "0xD16BD0", VA = "0x180D17FD0")]
		private void FixedUpdate()
		{
		}

		// Token: 0x06014B5B RID: 84827 RVA: 0x00088128 File Offset: 0x00086328
		[Token(Token = "0x6014B5B")]
		[Address(RVA = "0xD18290", Offset = "0xD16E90", VA = "0x180D18290")]
		private bool _CheckIfVisible()
		{
			return default(bool);
		}

		// Token: 0x06014B5C RID: 84828 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014B5C")]
		[Address(RVA = "0xD18330", Offset = "0xD16F30", VA = "0x180D18330")]
		private void _SetVisible(bool visible)
		{
		}

		// Token: 0x06014B5D RID: 84829 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014B5D")]
		[Address(RVA = "0xD183B0", Offset = "0xD16FB0", VA = "0x180D183B0")]
		public BattleNotification()
		{
		}

		// Token: 0x040189A8 RID: 100776
		[Token(Token = "0x40189A8")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private RectTransform _notifyFloatLayout;

		// Token: 0x040189A9 RID: 100777
		[Token(Token = "0x40189A9")]
		[FieldOffset(Offset = "0x20")]
		private BattleNotification.HostImpl m_host;

		// Token: 0x040189AA RID: 100778
		[Token(Token = "0x40189AA")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnInit;

		// Token: 0x040189AB RID: 100779
		[Token(Token = "0x40189AB")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_AddNotifyView;

		// Token: 0x040189AC RID: 100780
		[Token(Token = "0x40189AC")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_FixedUpdate;

		// Token: 0x040189AD RID: 100781
		[Token(Token = "0x40189AD")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__CheckIfVisible;

		// Token: 0x040189AE RID: 100782
		[Token(Token = "0x40189AE")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__SetVisible;

		// Token: 0x040189AF RID: 100783
		[Token(Token = "0x40189AF")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x020032E9 RID: 13033
		[Token(Token = "0x20032E9")]
		private class HostImpl : NotifyViewHost
		{
			// Token: 0x06014B5E RID: 84830 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6014B5E")]
			[Address(RVA = "0xD19390", Offset = "0xD17F90", VA = "0x180D19390")]
			public HostImpl(BattleNotification closure)
			{
			}

			// Token: 0x06014B5F RID: 84831 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6014B5F")]
			[Address(RVA = "0xD191D0", Offset = "0xD17DD0", VA = "0x180D191D0", Slot = "7")]
			public override GameObject LoadPrefabFromResource(string resPath)
			{
				return null;
			}

			// Token: 0x06014B60 RID: 84832 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6014B60")]
			[Address(RVA = "0xD192B0", Offset = "0xD17EB0", VA = "0x180D192B0", Slot = "6")]
			public override Coroutine StartCoroutine(IEnumerator routine)
			{
				return null;
			}

			// Token: 0x06014B61 RID: 84833 RVA: 0x00088140 File Offset: 0x00086340
			[Token(Token = "0x6014B61")]
			[Address(RVA = "0xD19120", Offset = "0xD17D20", VA = "0x180D19120", Slot = "4")]
			protected override long CurrentTicks()
			{
				return 0L;
			}

			// Token: 0x06014B62 RID: 84834 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6014B62")]
			protected override NotifyViewLayouter SelectLayouter<ViewType, ParamType>(NotifyViewOptions<ViewType, ParamType> options)
			{
				return null;
			}

			// Token: 0x06014B63 RID: 84835 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6014B63")]
			[Address(RVA = "0xD19330", Offset = "0xD17F30", VA = "0x180D19330", Slot = "8")]
			protected override void UnloadUnusedPrefabs()
			{
			}

			// Token: 0x040189B0 RID: 100784
			[Token(Token = "0x40189B0")]
			[FieldOffset(Offset = "0x28")]
			private BattleNotification m_closure;

			// Token: 0x040189B1 RID: 100785
			[Token(Token = "0x40189B1")]
			[FieldOffset(Offset = "0x30")]
			private NotificationFloatLayouter m_layouter;

			// Token: 0x040189B2 RID: 100786
			[Token(Token = "0x40189B2")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x040189B3 RID: 100787
			[Token(Token = "0x40189B3")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_LoadPrefabFromResource;

			// Token: 0x040189B4 RID: 100788
			[Token(Token = "0x40189B4")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_StartCoroutine;

			// Token: 0x040189B5 RID: 100789
			[Token(Token = "0x40189B5")]
			[FieldOffset(Offset = "0x18")]
			private static DelegateBridge __Hotfix0_CurrentTicks;

			// Token: 0x040189B6 RID: 100790
			[Token(Token = "0x40189B6")]
			[FieldOffset(Offset = "0x20")]
			private static DelegateBridge __Hotfix0_SelectLayouter;

			// Token: 0x040189B7 RID: 100791
			[Token(Token = "0x40189B7")]
			[FieldOffset(Offset = "0x28")]
			private static DelegateBridge __Hotfix0_UnloadUnusedPrefabs;
		}
	}
}

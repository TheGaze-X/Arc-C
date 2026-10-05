using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.UI.BackPress;
using UnityEngine;
using XLua;

namespace Torappu.UI
{
	// Token: 0x020034AA RID: 13482
	[Token(Token = "0x20034AA")]
	public class BackPressManager : Singleton<BackPressManager>, IHotfixable, IDisposable
	{
		// Token: 0x060157D3 RID: 88019 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60157D3")]
		[Address(RVA = "0xDF9910", Offset = "0xDF8510", VA = "0x180DF9910")]
		protected BackPressManager()
		{
		}

		// Token: 0x060157D4 RID: 88020 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60157D4")]
		[Address(RVA = "0xDF8EA0", Offset = "0xDF7AA0", VA = "0x180DF8EA0", Slot = "5")]
		public virtual void Dispose()
		{
		}

		// Token: 0x060157D5 RID: 88021 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60157D5")]
		[Address(RVA = "0xDF9710", Offset = "0xDF8310", VA = "0x180DF9710")]
		private void _OnSceneChanged(string fromSceneName, string toSceneName)
		{
		}

		// Token: 0x060157D6 RID: 88022 RVA: 0x0008C3A0 File Offset: 0x0008A5A0
		[Token(Token = "0x60157D6")]
		[Address(RVA = "0xDF94E0", Offset = "0xDF80E0", VA = "0x180DF94E0")]
		private bool _OnBackPress()
		{
			return default(bool);
		}

		// Token: 0x060157D7 RID: 88023 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60157D7")]
		[Address(RVA = "0xDF8B10", Offset = "0xDF7710", VA = "0x180DF8B10")]
		public static void BindListener(RectTransform rectTrans, BackPressOptions options)
		{
		}

		// Token: 0x060157D8 RID: 88024 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60157D8")]
		[Address(RVA = "0xDF8C90", Offset = "0xDF7890", VA = "0x180DF8C90")]
		public static void BindListener(MonoBehaviour root, BackPressOptions options, params string[] names)
		{
		}

		// Token: 0x060157D9 RID: 88025 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60157D9")]
		[Address(RVA = "0xDF9120", Offset = "0xDF7D20", VA = "0x180DF9120")]
		public static void SetPostHandler(BackPressManager.PostHandler postHandler)
		{
		}

		// Token: 0x060157DA RID: 88026 RVA: 0x0008C3B8 File Offset: 0x0008A5B8
		[Token(Token = "0x60157DA")]
		[Address(RVA = "0xDF91C0", Offset = "0xDF7DC0", VA = "0x180DF91C0")]
		public bool TriggerBackPress()
		{
			return default(bool);
		}

		// Token: 0x060157DB RID: 88027 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60157DB")]
		[Address(RVA = "0xDF9280", Offset = "0xDF7E80", VA = "0x180DF9280")]
		private void _Clear()
		{
		}

		// Token: 0x060157DC RID: 88028 RVA: 0x0008C3D0 File Offset: 0x0008A5D0
		[Token(Token = "0x60157DC")]
		[Address(RVA = "0xDF97A0", Offset = "0xDF83A0", VA = "0x180DF97A0")]
		private bool _TryTriggerBackPress()
		{
			return default(bool);
		}

		// Token: 0x060157DD RID: 88029 RVA: 0x0008C3E8 File Offset: 0x0008A5E8
		[Token(Token = "0x60157DD")]
		[Address(RVA = "0xDF9830", Offset = "0xDF8430", VA = "0x180DF9830")]
		private bool _TryTriggerPostHandler()
		{
			return default(bool);
		}

		// Token: 0x060157DE RID: 88030 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60157DE")]
		[Address(RVA = "0xDF8F60", Offset = "0xDF7B60", VA = "0x180DF8F60")]
		public void ListenerOnlyRegister(UIBackPressListener listener)
		{
		}

		// Token: 0x060157DF RID: 88031 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60157DF")]
		[Address(RVA = "0xDF9050", Offset = "0xDF7C50", VA = "0x180DF9050")]
		public void ListenerOnlyUnregister(UIBackPressListener listener)
		{
		}

		// Token: 0x060157E0 RID: 88032 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60157E0")]
		[Address(RVA = "0xDF93A0", Offset = "0xDF7FA0", VA = "0x180DF93A0")]
		private static string _MergePath(string[] names)
		{
			return null;
		}

		// Token: 0x060157E1 RID: 88033 RVA: 0x0008C400 File Offset: 0x0008A600
		[Token(Token = "0x60157E1")]
		[Address(RVA = "0xDF9320", Offset = "0xDF7F20", VA = "0x180DF9320")]
		private static bool _IsBackPressEnabled()
		{
			return default(bool);
		}

		// Token: 0x04019BC5 RID: 105413
		[Token(Token = "0x4019BC5")]
		private const float FAST_THRESHOLD = 0f;

		// Token: 0x04019BC6 RID: 105414
		[Token(Token = "0x4019BC6")]
		[FieldOffset(Offset = "0x10")]
		private float m_lastEventTime;

		// Token: 0x04019BC7 RID: 105415
		[Token(Token = "0x4019BC7")]
		[FieldOffset(Offset = "0x18")]
		private List<UIBackPressListener> m_listeners;

		// Token: 0x04019BC8 RID: 105416
		[Token(Token = "0x4019BC8")]
		[FieldOffset(Offset = "0x20")]
		private BackPressManager.PostHandler m_postHandler;

		// Token: 0x04019BC9 RID: 105417
		[Token(Token = "0x4019BC9")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x04019BCA RID: 105418
		[Token(Token = "0x4019BCA")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_Dispose;

		// Token: 0x04019BCB RID: 105419
		[Token(Token = "0x4019BCB")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__OnSceneChanged;

		// Token: 0x04019BCC RID: 105420
		[Token(Token = "0x4019BCC")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__OnBackPress;

		// Token: 0x04019BCD RID: 105421
		[Token(Token = "0x4019BCD")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_BindListener;

		// Token: 0x04019BCE RID: 105422
		[Token(Token = "0x4019BCE")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix1_BindListener;

		// Token: 0x04019BCF RID: 105423
		[Token(Token = "0x4019BCF")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_SetPostHandler;

		// Token: 0x04019BD0 RID: 105424
		[Token(Token = "0x4019BD0")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_TriggerBackPress;

		// Token: 0x04019BD1 RID: 105425
		[Token(Token = "0x4019BD1")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__Clear;

		// Token: 0x04019BD2 RID: 105426
		[Token(Token = "0x4019BD2")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0__TryTriggerBackPress;

		// Token: 0x04019BD3 RID: 105427
		[Token(Token = "0x4019BD3")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0__TryTriggerPostHandler;

		// Token: 0x04019BD4 RID: 105428
		[Token(Token = "0x4019BD4")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_ListenerOnlyRegister;

		// Token: 0x04019BD5 RID: 105429
		[Token(Token = "0x4019BD5")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0_ListenerOnlyUnregister;

		// Token: 0x04019BD6 RID: 105430
		[Token(Token = "0x4019BD6")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0__MergePath;

		// Token: 0x04019BD7 RID: 105431
		[Token(Token = "0x4019BD7")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0__IsBackPressEnabled;

		// Token: 0x020034AB RID: 13483
		[Token(Token = "0x20034AB")]
		public class PostHandler
		{
			// Token: 0x060157E2 RID: 88034 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60157E2")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public PostHandler()
			{
			}

			// Token: 0x04019BD8 RID: 105432
			[Token(Token = "0x4019BD8")]
			[FieldOffset(Offset = "0x10")]
			public Func<bool> condition;

			// Token: 0x04019BD9 RID: 105433
			[Token(Token = "0x4019BD9")]
			[FieldOffset(Offset = "0x18")]
			public Action onBackPressed;
		}
	}
}

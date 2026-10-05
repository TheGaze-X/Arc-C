using System;
using System.Collections;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.Carving
{
	// Token: 0x0200602D RID: 24621
	[Token(Token = "0x200602D")]
	public class CarvingHomePage : StateEnginePage, IHotfixable
	{
		// Token: 0x17005410 RID: 21520
		// (get) Token: 0x060239AA RID: 145834 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17005410")]
		public string activityId
		{
			[Token(Token = "0x60239AA")]
			[Address(RVA = "0x1E46010", Offset = "0x1E44C10", VA = "0x181E46010")]
			get
			{
				return null;
			}
		}

		// Token: 0x17005411 RID: 21521
		// (get) Token: 0x060239AB RID: 145835 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17005411")]
		public UICompDialogMgr dialogMgr
		{
			[Token(Token = "0x60239AB")]
			[Address(RVA = "0x1E46070", Offset = "0x1E44C70", VA = "0x181E46070")]
			get
			{
				return null;
			}
		}

		// Token: 0x060239AC RID: 145836 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60239AC")]
		[Address(RVA = "0x1E45AC0", Offset = "0x1E446C0", VA = "0x181E45AC0", Slot = "8")]
		protected override void OnCreate(DataBundle savedInst)
		{
		}

		// Token: 0x060239AD RID: 145837 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60239AD")]
		[Address(RVA = "0x1E45D30", Offset = "0x1E44930", VA = "0x181E45D30", Slot = "16")]
		protected override void OnDestroy()
		{
		}

		// Token: 0x060239AE RID: 145838 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60239AE")]
		[Address(RVA = "0x1E45A10", Offset = "0x1E44610", VA = "0x181E45A10", Slot = "27")]
		protected override IEnumerator InitStateEngine()
		{
			return null;
		}

		// Token: 0x060239AF RID: 145839 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60239AF")]
		[Address(RVA = "0x1E45E40", Offset = "0x1E44A40", VA = "0x181E45E40")]
		private void _TriggerBGMSignal()
		{
		}

		// Token: 0x060239B0 RID: 145840 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60239B0")]
		[Address(RVA = "0x1E45DA0", Offset = "0x1E449A0", VA = "0x181E45DA0")]
		private void _ClearBGM()
		{
		}

		// Token: 0x060239B1 RID: 145841 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60239B1")]
		[Address(RVA = "0x1E45890", Offset = "0x1E44490", VA = "0x181E45890")]
		public static CommonTopMenu CreateCommonTopMenu(Transform container, [Optional] Action onBackClick)
		{
			return null;
		}

		// Token: 0x060239B2 RID: 145842 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60239B2")]
		[Address(RVA = "0x1E45FB0", Offset = "0x1E44BB0", VA = "0x181E45FB0")]
		public CarvingHomePage()
		{
		}

		// Token: 0x060239B4 RID: 145844 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60239B4")]
		[Address(RVA = "0xE66190", Offset = "0xE64D90", VA = "0x180E66190")]
		private void <>xLuaBaseProxy_OnCreate(DataBundle P0)
		{
		}

		// Token: 0x060239B5 RID: 145845 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60239B5")]
		[Address(RVA = "0x12172F0", Offset = "0x1215EF0", VA = "0x1812172F0")]
		private void <>xLuaBaseProxy_OnDestroy()
		{
		}

		// Token: 0x060239B6 RID: 145846 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60239B6")]
		[Address(RVA = "0xE66180", Offset = "0xE64D80", VA = "0x180E66180")]
		private IEnumerator <>xLuaBaseProxy_InitStateEngine()
		{
			return null;
		}

		// Token: 0x040314BD RID: 201917
		[Token(Token = "0x40314BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		[SerializeField]
		private RectTransform _dialogContainer;

		// Token: 0x040314BE RID: 201918
		[Token(Token = "0x40314BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		private string m_actId;

		// Token: 0x040314BF RID: 201919
		[Token(Token = "0x40314BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
		private UICompDialogMgr m_dialogMgr;

		// Token: 0x040314C0 RID: 201920
		[Token(Token = "0x40314C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_activityId;

		// Token: 0x040314C1 RID: 201921
		[Token(Token = "0x40314C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_dialogMgr;

		// Token: 0x040314C2 RID: 201922
		[Token(Token = "0x40314C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnCreate;

		// Token: 0x040314C3 RID: 201923
		[Token(Token = "0x40314C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnDestroy;

		// Token: 0x040314C4 RID: 201924
		[Token(Token = "0x40314C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_InitStateEngine;

		// Token: 0x040314C5 RID: 201925
		[Token(Token = "0x40314C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__TriggerBGMSignal;

		// Token: 0x040314C6 RID: 201926
		[Token(Token = "0x40314C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__ClearBGM;

		// Token: 0x040314C7 RID: 201927
		[Token(Token = "0x40314C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_CreateCommonTopMenu;

		// Token: 0x040314C8 RID: 201928
		[Token(Token = "0x40314C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x0200602E RID: 24622
		[Token(Token = "0x200602E")]
		public class Params
		{
			// Token: 0x060239B7 RID: 145847 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60239B7")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public Params()
			{
			}

			// Token: 0x040314C9 RID: 201929
			[Token(Token = "0x40314C9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public string actId;
		}
	}
}

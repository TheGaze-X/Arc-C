using System;
using System.Collections.Generic;
using AdvancedInspector;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.Friend
{
	// Token: 0x02004D67 RID: 19815
	[Token(Token = "0x2004D67")]
	public class NameCardEditState : PopupFloatState, IValueMsgReceiver
	{
		// Token: 0x0601DA5F RID: 121439 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601DA5F")]
		[Address(RVA = "0x1734A10", Offset = "0x1733610", VA = "0x181734A10", Slot = "9")]
		public override IStateBean GetCacheBean()
		{
			return null;
		}

		// Token: 0x0601DA60 RID: 121440 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601DA60")]
		[Address(RVA = "0x1734EC0", Offset = "0x1733AC0", VA = "0x181734EC0", Slot = "16")]
		protected override void OnPreResume(bool isFromStack)
		{
		}

		// Token: 0x0601DA61 RID: 121441 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601DA61")]
		[Address(RVA = "0x1735130", Offset = "0x1733D30", VA = "0x181735130")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0601DA62 RID: 121442 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601DA62")]
		[Address(RVA = "0x1734A70", Offset = "0x1733670", VA = "0x181734A70", Slot = "32")]
		public void OnMessage(int key, ValueBundle msg)
		{
		}

		// Token: 0x0601DA63 RID: 121443 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601DA63")]
		[Address(RVA = "0x17355F0", Offset = "0x17341F0", VA = "0x1817355F0")]
		private void _SelectModule(string moduleId)
		{
		}

		// Token: 0x0601DA64 RID: 121444 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601DA64")]
		[Address(RVA = "0x1735A90", Offset = "0x1734690", VA = "0x181735A90")]
		private void _UnselectModule(string moduleId)
		{
		}

		// Token: 0x0601DA65 RID: 121445 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601DA65")]
		[Address(RVA = "0x1735030", Offset = "0x1733C30", VA = "0x181735030")]
		private void _CloseModuleContainer()
		{
		}

		// Token: 0x0601DA66 RID: 121446 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601DA66")]
		[Address(RVA = "0x1735810", Offset = "0x1734410", VA = "0x181735810")]
		private void _SwitchDateMode()
		{
		}

		// Token: 0x0601DA67 RID: 121447 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601DA67")]
		[Address(RVA = "0x1735730", Offset = "0x1734330", VA = "0x181735730")]
		private void _SetBirth()
		{
		}

		// Token: 0x0601DA68 RID: 121448 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601DA68")]
		[Address(RVA = "0x1735580", Offset = "0x1734180", VA = "0x181735580")]
		private void _OpenModuleContainer()
		{
		}

		// Token: 0x0601DA69 RID: 121449 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601DA69")]
		[Address(RVA = "0x1734790", Offset = "0x1733390", VA = "0x181734790")]
		public void CloseState()
		{
		}

		// Token: 0x0601DA6A RID: 121450 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601DA6A")]
		[Address(RVA = "0x1734730", Offset = "0x1733330", VA = "0x181734730")]
		public void CloseModuleContainer()
		{
		}

		// Token: 0x0601DA6B RID: 121451 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601DA6B")]
		[Address(RVA = "0x1735B60", Offset = "0x1734760", VA = "0x181735B60")]
		public NameCardEditState()
		{
		}

		// Token: 0x0601DA6D RID: 121453 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601DA6D")]
		[Address(RVA = "0x1061490", Offset = "0x1060090", VA = "0x181061490")]
		private void <>xLuaBaseProxy_OnPreResume(bool P0)
		{
		}

		// Token: 0x04027293 RID: 160403
		[Token(Token = "0x4027293")]
		[NonSerialized]
		public const int SELECT_MODULE = 0;

		// Token: 0x04027294 RID: 160404
		[Token(Token = "0x4027294")]
		[NonSerialized]
		public const int UNSELECT_MODULE = 1;

		// Token: 0x04027295 RID: 160405
		[Token(Token = "0x4027295")]
		[NonSerialized]
		public const int CLOSE_MODULE_CONTAINER = 2;

		// Token: 0x04027296 RID: 160406
		[Token(Token = "0x4027296")]
		[NonSerialized]
		public const int SWITCH_DATE_MODE = 4;

		// Token: 0x04027297 RID: 160407
		[Token(Token = "0x4027297")]
		[NonSerialized]
		public const int SET_BIRTH = 5;

		// Token: 0x04027298 RID: 160408
		[Token(Token = "0x4027298")]
		[NonSerialized]
		public const int OPEN_MODULE_CONTAINER = 6;

		// Token: 0x04027299 RID: 160409
		[Token(Token = "0x4027299")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private RectTransform _backRect;

		// Token: 0x0402729A RID: 160410
		[Token(Token = "0x402729A")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private RectTransform _nameCardContainer;

		// Token: 0x0402729B RID: 160411
		[Token(Token = "0x402729B")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private float _nameCardScale;

		// Token: 0x0402729C RID: 160412
		[Token(Token = "0x402729C")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		private RectTransform _moduleListContainer;

		// Token: 0x0402729D RID: 160413
		[Token(Token = "0x402729D")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		private FriendStateControl _stateControl;

		// Token: 0x0402729E RID: 160414
		[Token(Token = "0x402729E")]
		[FieldOffset(Offset = "0x98")]
		[SerializeField]
		private NameCardV2BirthButtonView _birthButtonView;

		// Token: 0x0402729F RID: 160415
		[Token(Token = "0x402729F")]
		[FieldOffset(Offset = "0xA0")]
		[SerializeField]
		private NameCardV2EditOpenModuleContainerBtnView _openModuleContainerBtnView;

		// Token: 0x040272A0 RID: 160416
		[Token(Token = "0x40272A0")]
		[FieldOffset(Offset = "0xA8")]
		[SerializeField]
		[Group("Container Anim")]
		private UIAnimationLocation _containerShowAnim;

		// Token: 0x040272A1 RID: 160417
		[Token(Token = "0x40272A1")]
		[FieldOffset(Offset = "0xB8")]
		[SerializeField]
		[Group("Container Anim")]
		private float _duration;

		// Token: 0x040272A2 RID: 160418
		[Token(Token = "0x40272A2")]
		[FieldOffset(Offset = "0xC0")]
		private NameCardV2EditStateBean m_stateBean;

		// Token: 0x040272A3 RID: 160419
		[Token(Token = "0x40272A3")]
		[FieldOffset(Offset = "0xC8")]
		private bool m_hasInited;

		// Token: 0x040272A4 RID: 160420
		[Token(Token = "0x40272A4")]
		[FieldOffset(Offset = "0xD0")]
		private AnimationSwitchTween m_tween;

		// Token: 0x040272A5 RID: 160421
		[Token(Token = "0x40272A5")]
		[FieldOffset(Offset = "0xD8")]
		private NameCardV2View m_nameCard;

		// Token: 0x040272A6 RID: 160422
		[Token(Token = "0x40272A6")]
		[FieldOffset(Offset = "0xE0")]
		private NameCardV2ModuleContainerView m_moduleList;

		// Token: 0x040272A7 RID: 160423
		[Token(Token = "0x40272A7")]
		[FieldOffset(Offset = "0xE8")]
		private List<string> m_cachedSelectedModuleList;

		// Token: 0x040272A8 RID: 160424
		[Token(Token = "0x40272A8")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetCacheBean;

		// Token: 0x040272A9 RID: 160425
		[Token(Token = "0x40272A9")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnPreResume;

		// Token: 0x040272AA RID: 160426
		[Token(Token = "0x40272AA")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x040272AB RID: 160427
		[Token(Token = "0x40272AB")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnMessage;

		// Token: 0x040272AC RID: 160428
		[Token(Token = "0x40272AC")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__SelectModule;

		// Token: 0x040272AD RID: 160429
		[Token(Token = "0x40272AD")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__UnselectModule;

		// Token: 0x040272AE RID: 160430
		[Token(Token = "0x40272AE")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__CloseModuleContainer;

		// Token: 0x040272AF RID: 160431
		[Token(Token = "0x40272AF")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__SwitchDateMode;

		// Token: 0x040272B0 RID: 160432
		[Token(Token = "0x40272B0")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__SetBirth;

		// Token: 0x040272B1 RID: 160433
		[Token(Token = "0x40272B1")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0__OpenModuleContainer;

		// Token: 0x040272B2 RID: 160434
		[Token(Token = "0x40272B2")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_CloseState;

		// Token: 0x040272B3 RID: 160435
		[Token(Token = "0x40272B3")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_CloseModuleContainer;

		// Token: 0x040272B4 RID: 160436
		[Token(Token = "0x40272B4")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}

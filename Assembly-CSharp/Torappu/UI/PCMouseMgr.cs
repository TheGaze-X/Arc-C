using System;
using Il2CppDummyDll;
using Torappu.Common;
using UnityEngine;
using UnityEngine.SceneManagement;
using XLua;

namespace Torappu.UI
{
	// Token: 0x0200374A RID: 14154
	[Token(Token = "0x200374A")]
	public class PCMouseMgr : MonoBehaviour, IHotfixable
	{
		// Token: 0x060167D0 RID: 92112 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60167D0")]
		[Address(RVA = "0xEDD170", Offset = "0xEDBD70", VA = "0x180EDD170")]
		private void _SettingSizeAndRender()
		{
		}

		// Token: 0x060167D1 RID: 92113 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60167D1")]
		[Address(RVA = "0xEDC8A0", Offset = "0xEDB4A0", VA = "0x180EDC8A0")]
		public void Init(TorappuPCInputHelper inputHelper)
		{
		}

		// Token: 0x060167D2 RID: 92114 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60167D2")]
		[Address(RVA = "0xEDCE70", Offset = "0xEDBA70", VA = "0x180EDCE70")]
		public void RefreshUI()
		{
		}

		// Token: 0x060167D3 RID: 92115 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60167D3")]
		[Address(RVA = "0xEDCF50", Offset = "0xEDBB50", VA = "0x180EDCF50")]
		public void Reload()
		{
		}

		// Token: 0x060167D4 RID: 92116 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60167D4")]
		[Address(RVA = "0xEDCB40", Offset = "0xEDB740", VA = "0x180EDCB40")]
		public void OnSceneChanged(Scene scene, LoadSceneMode mode)
		{
		}

		// Token: 0x060167D5 RID: 92117 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60167D5")]
		[Address(RVA = "0xEDCA50", Offset = "0xEDB650", VA = "0x180EDCA50")]
		protected void OnDestroy()
		{
		}

		// Token: 0x060167D6 RID: 92118 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60167D6")]
		[Address(RVA = "0xEDCBE0", Offset = "0xEDB7E0", VA = "0x180EDCBE0")]
		public void OnTick()
		{
		}

		// Token: 0x060167D7 RID: 92119 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60167D7")]
		[Address(RVA = "0xEDCFB0", Offset = "0xEDBBB0", VA = "0x180EDCFB0")]
		private void _OnMouseDownEvent()
		{
		}

		// Token: 0x060167D8 RID: 92120 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60167D8")]
		[Address(RVA = "0xEDD090", Offset = "0xEDBC90", VA = "0x180EDD090")]
		private void _OnMouseUpEvent()
		{
		}

		// Token: 0x060167D9 RID: 92121 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60167D9")]
		[Address(RVA = "0xEDD6D0", Offset = "0xEDC2D0", VA = "0x180EDD6D0")]
		private void _SwitchState(bool immediate)
		{
		}

		// Token: 0x060167DA RID: 92122 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60167DA")]
		[Address(RVA = "0xEDD630", Offset = "0xEDC230", VA = "0x180EDD630")]
		private void _SwitchStateImpl(bool isAvail)
		{
		}

		// Token: 0x060167DB RID: 92123 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60167DB")]
		[Address(RVA = "0xEDD2A0", Offset = "0xEDBEA0", VA = "0x180EDD2A0")]
		private void _SetupMouse(string toScene)
		{
		}

		// Token: 0x060167DC RID: 92124 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60167DC")]
		[Address(RVA = "0xEDC7E0", Offset = "0xEDB3E0", VA = "0x180EDC7E0")]
		public PCMouseHandlerBase GetMouseItem(string toScene)
		{
			return null;
		}

		// Token: 0x060167DD RID: 92125 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60167DD")]
		[Address(RVA = "0xEDD8A0", Offset = "0xEDC4A0", VA = "0x180EDD8A0")]
		public PCMouseMgr()
		{
		}

		// Token: 0x0401B15F RID: 110943
		[Token(Token = "0x401B15F")]
		private const float HIDE_MOUSE_DELAY = 0.2f;

		// Token: 0x0401B160 RID: 110944
		[Token(Token = "0x401B160")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Camera _cameraUI;

		// Token: 0x0401B161 RID: 110945
		[Token(Token = "0x401B161")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Canvas _canvasUI;

		// Token: 0x0401B162 RID: 110946
		[Token(Token = "0x401B162")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private PCMouseConfig _defaultConfig;

		// Token: 0x0401B163 RID: 110947
		[Token(Token = "0x401B163")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private RectTransform _mouseHolder;

		// Token: 0x0401B164 RID: 110948
		[Token(Token = "0x401B164")]
		[FieldOffset(Offset = "0x38")]
		private PCMouseHandlerBase m_mouseItem;

		// Token: 0x0401B165 RID: 110949
		[Token(Token = "0x401B165")]
		[FieldOffset(Offset = "0x40")]
		private PCMouseConfig m_config;

		// Token: 0x0401B166 RID: 110950
		[Token(Token = "0x401B166")]
		[FieldOffset(Offset = "0x48")]
		private string m_cacheMouseId;

		// Token: 0x0401B167 RID: 110951
		[Token(Token = "0x401B167")]
		[FieldOffset(Offset = "0x50")]
		private bool m_ForceNotAvail;

		// Token: 0x0401B168 RID: 110952
		[Token(Token = "0x401B168")]
		[FieldOffset(Offset = "0x51")]
		private bool m_FocusNotAvail;

		// Token: 0x0401B169 RID: 110953
		[Token(Token = "0x401B169")]
		[FieldOffset(Offset = "0x52")]
		private bool m_isAvail;

		// Token: 0x0401B16A RID: 110954
		[Token(Token = "0x401B16A")]
		[FieldOffset(Offset = "0x53")]
		private bool m_isSettingUp;

		// Token: 0x0401B16B RID: 110955
		[Token(Token = "0x401B16B")]
		[FieldOffset(Offset = "0x54")]
		private float m_cacheCursorScale;

		// Token: 0x0401B16C RID: 110956
		[Token(Token = "0x401B16C")]
		[FieldOffset(Offset = "0x58")]
		private DelaySwitchTween m_switchStateTween;

		// Token: 0x0401B16D RID: 110957
		[Token(Token = "0x401B16D")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0__SettingSizeAndRender;

		// Token: 0x0401B16E RID: 110958
		[Token(Token = "0x401B16E")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_Init;

		// Token: 0x0401B16F RID: 110959
		[Token(Token = "0x401B16F")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_RefreshUI;

		// Token: 0x0401B170 RID: 110960
		[Token(Token = "0x401B170")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_Reload;

		// Token: 0x0401B171 RID: 110961
		[Token(Token = "0x401B171")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_OnSceneChanged;

		// Token: 0x0401B172 RID: 110962
		[Token(Token = "0x401B172")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_OnDestroy;

		// Token: 0x0401B173 RID: 110963
		[Token(Token = "0x401B173")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_OnTick;

		// Token: 0x0401B174 RID: 110964
		[Token(Token = "0x401B174")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__OnMouseDownEvent;

		// Token: 0x0401B175 RID: 110965
		[Token(Token = "0x401B175")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__OnMouseUpEvent;

		// Token: 0x0401B176 RID: 110966
		[Token(Token = "0x401B176")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0__SwitchState;

		// Token: 0x0401B177 RID: 110967
		[Token(Token = "0x401B177")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0__SwitchStateImpl;

		// Token: 0x0401B178 RID: 110968
		[Token(Token = "0x401B178")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0__SetupMouse;

		// Token: 0x0401B179 RID: 110969
		[Token(Token = "0x401B179")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0_GetMouseItem;

		// Token: 0x0401B17A RID: 110970
		[Token(Token = "0x401B17A")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}

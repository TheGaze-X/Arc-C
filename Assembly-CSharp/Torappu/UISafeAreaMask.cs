using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu
{
	// Token: 0x0200053C RID: 1340
	[Token(Token = "0x200053C")]
	public class UISafeAreaMask : SingletonMonoBehaviour<UISafeAreaMask>, ISingletonNotAutoCreate, ISafeAreaListener
	{
		// Token: 0x06005A10 RID: 23056 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005A10")]
		[Address(RVA = "0x1B03080", Offset = "0x1B01C80", VA = "0x181B03080")]
		private void Start()
		{
		}

		// Token: 0x06005A11 RID: 23057 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005A11")]
		[Address(RVA = "0x1B02E50", Offset = "0x1B01A50", VA = "0x181B02E50", Slot = "7")]
		protected override void OnDestroy()
		{
		}

		// Token: 0x06005A12 RID: 23058 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005A12")]
		[Address(RVA = "0x1B03110", Offset = "0x1B01D10", VA = "0x181B03110")]
		private void Update()
		{
		}

		// Token: 0x06005A13 RID: 23059 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005A13")]
		[Address(RVA = "0x1B02EF0", Offset = "0x1B01AF0", VA = "0x181B02EF0", Slot = "8")]
		public void OnSafeRectUpdated(SafeRect rect)
		{
		}

		// Token: 0x06005A14 RID: 23060 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005A14")]
		[Address(RVA = "0x1B02D30", Offset = "0x1B01930", VA = "0x181B02D30")]
		public static void Display(SafeAreaMaskCond condition, bool isShow)
		{
		}

		// Token: 0x06005A15 RID: 23061 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005A15")]
		[Address(RVA = "0x1B02F70", Offset = "0x1B01B70", VA = "0x181B02F70")]
		public static void ShowIfNeeded()
		{
		}

		// Token: 0x06005A16 RID: 23062 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005A16")]
		[Address(RVA = "0x1B03230", Offset = "0x1B01E30", VA = "0x181B03230")]
		private void _ShowIfNeeded()
		{
		}

		// Token: 0x06005A17 RID: 23063 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005A17")]
		[Address(RVA = "0x1B03370", Offset = "0x1B01F70", VA = "0x181B03370")]
		private void _UpdateLayout()
		{
		}

		// Token: 0x06005A18 RID: 23064 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005A18")]
		[Address(RVA = "0x1B032A0", Offset = "0x1B01EA0", VA = "0x181B032A0")]
		private void _UpdateDisplayStatus()
		{
		}

		// Token: 0x06005A19 RID: 23065 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005A19")]
		[Address(RVA = "0x1B03190", Offset = "0x1B01D90", VA = "0x181B03190")]
		private void _EnableCoreComponents(bool isEnable)
		{
		}

		// Token: 0x06005A1A RID: 23066 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005A1A")]
		[Address(RVA = "0x1B03510", Offset = "0x1B02110", VA = "0x181B03510")]
		public UISafeAreaMask()
		{
		}

		// Token: 0x04001FE4 RID: 8164
		[Token(Token = "0x4001FE4")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private RectTransform _panelLeft;

		// Token: 0x04001FE5 RID: 8165
		[Token(Token = "0x4001FE5")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private RectTransform _panelRight;

		// Token: 0x04001FE6 RID: 8166
		[Token(Token = "0x4001FE6")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private CanvasScaler _scaler;

		// Token: 0x04001FE7 RID: 8167
		[Token(Token = "0x4001FE7")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Canvas _canvas;

		// Token: 0x04001FE8 RID: 8168
		[Token(Token = "0x4001FE8")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Camera _camera;

		// Token: 0x04001FE9 RID: 8169
		[Token(Token = "0x4001FE9")]
		[FieldOffset(Offset = "0x40")]
		private bool m_isShown;

		// Token: 0x04001FEA RID: 8170
		[Token(Token = "0x4001FEA")]
		[FieldOffset(Offset = "0x48")]
		private ListSet<SafeAreaMaskCond> m_hideCondSet;

		// Token: 0x04001FEB RID: 8171
		[Token(Token = "0x4001FEB")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Start;

		// Token: 0x04001FEC RID: 8172
		[Token(Token = "0x4001FEC")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnDestroy;

		// Token: 0x04001FED RID: 8173
		[Token(Token = "0x4001FED")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_Update;

		// Token: 0x04001FEE RID: 8174
		[Token(Token = "0x4001FEE")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnSafeRectUpdated;

		// Token: 0x04001FEF RID: 8175
		[Token(Token = "0x4001FEF")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_Display;

		// Token: 0x04001FF0 RID: 8176
		[Token(Token = "0x4001FF0")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_ShowIfNeeded;

		// Token: 0x04001FF1 RID: 8177
		[Token(Token = "0x4001FF1")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__ShowIfNeeded;

		// Token: 0x04001FF2 RID: 8178
		[Token(Token = "0x4001FF2")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__UpdateLayout;

		// Token: 0x04001FF3 RID: 8179
		[Token(Token = "0x4001FF3")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__UpdateDisplayStatus;

		// Token: 0x04001FF4 RID: 8180
		[Token(Token = "0x4001FF4")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0__EnableCoreComponents;

		// Token: 0x04001FF5 RID: 8181
		[Token(Token = "0x4001FF5")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}

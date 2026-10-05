using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.UI.Stencil;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI
{
	// Token: 0x02003764 RID: 14180
	[Token(Token = "0x2003764")]
	[RequireComponent(typeof(RectMask2D))]
	public class UIStencilCleaner : UIStencilMaskable
	{
		// Token: 0x170035F0 RID: 13808
		// (get) Token: 0x0601682F RID: 92207 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170035F0")]
		public override Material materialForRendering
		{
			[Token(Token = "0x601682F")]
			[Address(RVA = "0xF03490", Offset = "0xF02090", VA = "0x180F03490", Slot = "36")]
			get
			{
				return null;
			}
		}

		// Token: 0x06016830 RID: 92208 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6016830")]
		[Address(RVA = "0xF02DB0", Offset = "0xF019B0", VA = "0x180F02DB0", Slot = "5")]
		protected override void OnEnable()
		{
		}

		// Token: 0x06016831 RID: 92209 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6016831")]
		[Address(RVA = "0xF02D40", Offset = "0xF01940", VA = "0x180F02D40", Slot = "7")]
		protected override void OnDisable()
		{
		}

		// Token: 0x06016832 RID: 92210 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6016832")]
		[Address(RVA = "0xF02CD0", Offset = "0xF018D0", VA = "0x180F02CD0", Slot = "8")]
		protected override void OnDestroy()
		{
		}

		// Token: 0x170035F1 RID: 13809
		// (get) Token: 0x06016833 RID: 92211 RVA: 0x000916C8 File Offset: 0x0008F8C8
		// (set) Token: 0x06016834 RID: 92212 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170035F1")]
		public override bool raycastTarget
		{
			[Token(Token = "0x6016833")]
			[Address(RVA = "0xF034F0", Offset = "0xF020F0", VA = "0x180F034F0", Slot = "24")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6016834")]
			[Address(RVA = "0xF03550", Offset = "0xF02150", VA = "0x180F03550", Slot = "25")]
			set
			{
			}
		}

		// Token: 0x06016835 RID: 92213 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6016835")]
		[Address(RVA = "0xF03060", Offset = "0xF01C60", VA = "0x180F03060")]
		private void _AddClearMaterial()
		{
		}

		// Token: 0x06016836 RID: 92214 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6016836")]
		[Address(RVA = "0xF03280", Offset = "0xF01E80", VA = "0x180F03280")]
		private void _RemoveClearMaterial()
		{
		}

		// Token: 0x06016837 RID: 92215 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6016837")]
		[Address(RVA = "0xF02E20", Offset = "0xF01A20", VA = "0x180F02E20")]
		public void RegisterNeedClean(UIStencilCleaner.INeedClean needClean)
		{
		}

		// Token: 0x06016838 RID: 92216 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6016838")]
		[Address(RVA = "0xF02F70", Offset = "0xF01B70", VA = "0x180F02F70")]
		public void UnregisterNeedClean(UIStencilCleaner.INeedClean needClean)
		{
		}

		// Token: 0x06016839 RID: 92217 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6016839")]
		[Address(RVA = "0xF033D0", Offset = "0xF01FD0", VA = "0x180F033D0")]
		public UIStencilCleaner()
		{
		}

		// Token: 0x0601683A RID: 92218 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601683A")]
		[Address(RVA = "0xF02F40", Offset = "0xF01B40", VA = "0x180F02F40")]
		private Material <>xLuaBaseProxy_get_materialForRendering()
		{
			return null;
		}

		// Token: 0x0601683B RID: 92219 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601683B")]
		[Address(RVA = "0xF02F30", Offset = "0xF01B30", VA = "0x180F02F30")]
		private void <>xLuaBaseProxy_OnEnable()
		{
		}

		// Token: 0x0601683C RID: 92220 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601683C")]
		[Address(RVA = "0xF02F20", Offset = "0xF01B20", VA = "0x180F02F20")]
		private void <>xLuaBaseProxy_OnDisable()
		{
		}

		// Token: 0x0601683D RID: 92221 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601683D")]
		[Address(RVA = "0xF02F10", Offset = "0xF01B10", VA = "0x180F02F10")]
		private void <>xLuaBaseProxy_OnDestroy()
		{
		}

		// Token: 0x0601683E RID: 92222 RVA: 0x000916E0 File Offset: 0x0008F8E0
		[Token(Token = "0x601683E")]
		[Address(RVA = "0xF02F50", Offset = "0xF01B50", VA = "0x180F02F50")]
		private bool <>xLuaBaseProxy_get_raycastTarget()
		{
			return default(bool);
		}

		// Token: 0x0601683F RID: 92223 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601683F")]
		[Address(RVA = "0xF02F60", Offset = "0xF01B60", VA = "0x180F02F60")]
		private void <>xLuaBaseProxy_set_raycastTarget(bool P0)
		{
		}

		// Token: 0x0401B1F8 RID: 111096
		[Token(Token = "0x401B1F8")]
		[FieldOffset(Offset = "0xC0")]
		private HashSet<UIStencilCleaner.INeedClean> m_needCleans;

		// Token: 0x0401B1F9 RID: 111097
		[Token(Token = "0x401B1F9")]
		[FieldOffset(Offset = "0xC8")]
		private Material m_clearMat;

		// Token: 0x0401B1FA RID: 111098
		[Token(Token = "0x401B1FA")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_materialForRendering;

		// Token: 0x0401B1FB RID: 111099
		[Token(Token = "0x401B1FB")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnEnable;

		// Token: 0x0401B1FC RID: 111100
		[Token(Token = "0x401B1FC")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnDisable;

		// Token: 0x0401B1FD RID: 111101
		[Token(Token = "0x401B1FD")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnDestroy;

		// Token: 0x0401B1FE RID: 111102
		[Token(Token = "0x401B1FE")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_get_raycastTarget;

		// Token: 0x0401B1FF RID: 111103
		[Token(Token = "0x401B1FF")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_set_raycastTarget;

		// Token: 0x0401B200 RID: 111104
		[Token(Token = "0x401B200")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__AddClearMaterial;

		// Token: 0x0401B201 RID: 111105
		[Token(Token = "0x401B201")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__RemoveClearMaterial;

		// Token: 0x0401B202 RID: 111106
		[Token(Token = "0x401B202")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_RegisterNeedClean;

		// Token: 0x0401B203 RID: 111107
		[Token(Token = "0x401B203")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_UnregisterNeedClean;

		// Token: 0x0401B204 RID: 111108
		[Token(Token = "0x401B204")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02003765 RID: 14181
		[Token(Token = "0x2003765")]
		public interface INeedClean
		{
			// Token: 0x06016840 RID: 92224
			[Token(Token = "0x6016840")]
			bool NeedCleaner();
		}
	}
}

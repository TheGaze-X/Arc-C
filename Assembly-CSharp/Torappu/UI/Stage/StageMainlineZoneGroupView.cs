using System;
using System.Collections;
using DG.Tweening;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Stage
{
	// Token: 0x02006969 RID: 26985
	[Token(Token = "0x2006969")]
	public class StageMainlineZoneGroupView : StageZoneGroupView
	{
		// Token: 0x17005B2A RID: 23338
		// (get) Token: 0x060269DC RID: 158172 RVA: 0x000CBD48 File Offset: 0x000C9F48
		[Token(Token = "0x17005B2A")]
		protected override bool showLockedZones
		{
			[Token(Token = "0x60269DC")]
			[Address(RVA = "0x21AED40", Offset = "0x21AD940", VA = "0x1821AED40", Slot = "8")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x060269DD RID: 158173 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60269DD")]
		[Address(RVA = "0x21ADDC0", Offset = "0x21AC9C0", VA = "0x1821ADDC0", Slot = "9")]
		protected override void OnInit()
		{
		}

		// Token: 0x060269DE RID: 158174 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60269DE")]
		[Address(RVA = "0x21ADEC0", Offset = "0x21ACAC0", VA = "0x1821ADEC0", Slot = "16")]
		protected override void OnUpdate(bool isActive)
		{
		}

		// Token: 0x060269DF RID: 158175 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60269DF")]
		[Address(RVA = "0x21AE650", Offset = "0x21AD250", VA = "0x1821AE650")]
		private void _OnZoneClicked(string zoneId)
		{
		}

		// Token: 0x060269E0 RID: 158176 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60269E0")]
		[Address(RVA = "0x21AEC20", Offset = "0x21AD820", VA = "0x1821AEC20")]
		private void _TriggerZoneClickedEvent(ZoneViewModel zoneModel)
		{
		}

		// Token: 0x060269E1 RID: 158177 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60269E1")]
		[Address(RVA = "0x21AE220", Offset = "0x21ACE20", VA = "0x1821AE220")]
		private void _InitZones()
		{
		}

		// Token: 0x060269E2 RID: 158178 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60269E2")]
		[Address(RVA = "0x21AE580", Offset = "0x21AD180", VA = "0x1821AE580")]
		private IEnumerator _InitialFocusCoroutine(string zoneId)
		{
			return null;
		}

		// Token: 0x060269E3 RID: 158179 RVA: 0x000CBD60 File Offset: 0x000C9F60
		[Token(Token = "0x60269E3")]
		[Address(RVA = "0x21AE030", Offset = "0x21ACC30", VA = "0x1821AE030")]
		private float _FocusZone(string zoneId, bool tweenTo = true)
		{
			return 0f;
		}

		// Token: 0x060269E4 RID: 158180 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60269E4")]
		[Address(RVA = "0x21AE870", Offset = "0x21AD470", VA = "0x1821AE870")]
		private Tween _ScrollToFocusRect(RectTransform zoneTrans, bool useTween, out float time)
		{
			return null;
		}

		// Token: 0x060269E5 RID: 158181 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60269E5")]
		[Address(RVA = "0x21AECE0", Offset = "0x21AD8E0", VA = "0x1821AECE0")]
		public StageMainlineZoneGroupView()
		{
		}

		// Token: 0x060269E9 RID: 158185 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60269E9")]
		[Address(RVA = "0x21ADFC0", Offset = "0x21ACBC0", VA = "0x1821ADFC0")]
		private void <>xLuaBaseProxy_OnInit()
		{
		}

		// Token: 0x060269EA RID: 158186 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60269EA")]
		[Address(RVA = "0x21ADFD0", Offset = "0x21ACBD0", VA = "0x1821ADFD0")]
		private void <>xLuaBaseProxy_OnUpdate(bool P0)
		{
		}

		// Token: 0x040367F6 RID: 223222
		[Token(Token = "0x40367F6")]
		private const float TWEEN_TIME_UNIT = 0.0006f;

		// Token: 0x040367F7 RID: 223223
		[Token(Token = "0x40367F7")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private StageZoneLockedView _lockedViewPrefab;

		// Token: 0x040367F8 RID: 223224
		[Token(Token = "0x40367F8")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private ScrollRect _focusScroll;

		// Token: 0x040367F9 RID: 223225
		[Token(Token = "0x40367F9")]
		[FieldOffset(Offset = "0x80")]
		private StageZoneLockedView m_lockedZoneView;

		// Token: 0x040367FA RID: 223226
		[Token(Token = "0x40367FA")]
		[FieldOffset(Offset = "0x88")]
		private string m_focusZoneCache;

		// Token: 0x040367FB RID: 223227
		[Token(Token = "0x40367FB")]
		[FieldOffset(Offset = "0x90")]
		private bool m_zoneLock;

		// Token: 0x040367FC RID: 223228
		[Token(Token = "0x40367FC")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_showLockedZones;

		// Token: 0x040367FD RID: 223229
		[Token(Token = "0x40367FD")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnInit;

		// Token: 0x040367FE RID: 223230
		[Token(Token = "0x40367FE")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnUpdate;

		// Token: 0x040367FF RID: 223231
		[Token(Token = "0x40367FF")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__OnZoneClicked;

		// Token: 0x04036800 RID: 223232
		[Token(Token = "0x4036800")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__TriggerZoneClickedEvent;

		// Token: 0x04036801 RID: 223233
		[Token(Token = "0x4036801")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__InitZones;

		// Token: 0x04036802 RID: 223234
		[Token(Token = "0x4036802")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__InitialFocusCoroutine;

		// Token: 0x04036803 RID: 223235
		[Token(Token = "0x4036803")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__FocusZone;

		// Token: 0x04036804 RID: 223236
		[Token(Token = "0x4036804")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__ScrollToFocusRect;

		// Token: 0x04036805 RID: 223237
		[Token(Token = "0x4036805")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}

using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Torappu.ObjectPool;
using UnityEngine;
using XLua;

namespace Torappu.Battle.UI
{
	// Token: 0x02003393 RID: 13203
	[Token(Token = "0x2003393")]
	public class UIUnitHUD : MonoBehaviour, IReusableObject, IReusable, IPtrObject, IHotfixable
	{
		// Token: 0x17003204 RID: 12804
		// (get) Token: 0x060150D1 RID: 86225 RVA: 0x0008A2D0 File Offset: 0x000884D0
		// (set) Token: 0x060150D2 RID: 86226 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17003204")]
		public uint instanceUid
		{
			[Token(Token = "0x60150D1")]
			[Address(RVA = "0xD7DF20", Offset = "0xD7CB20", VA = "0x180D7DF20", Slot = "6")]
			[CompilerGenerated]
			get
			{
				return 0U;
			}
			[Token(Token = "0x60150D2")]
			[Address(RVA = "0xD7DFE0", Offset = "0xD7CBE0", VA = "0x180D7DFE0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17003205 RID: 12805
		// (get) Token: 0x060150D3 RID: 86227 RVA: 0x0008A2E8 File Offset: 0x000884E8
		// (set) Token: 0x060150D4 RID: 86228 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17003205")]
		public bool isAttached
		{
			[Token(Token = "0x60150D3")]
			[Address(RVA = "0xD7DF80", Offset = "0xD7CB80", VA = "0x180D7DF80")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60150D4")]
			[Address(RVA = "0xD7E050", Offset = "0xD7CC50", VA = "0x180D7E050")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x060150D5 RID: 86229 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60150D5")]
		[Address(RVA = "0xD7AF90", Offset = "0xD79B90", VA = "0x180D7AF90")]
		public void Attach(Unit owner, UIUnitHudPluginHolder holder)
		{
		}

		// Token: 0x060150D6 RID: 86230 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60150D6")]
		[Address(RVA = "0xD7D3C0", Offset = "0xD7BFC0", VA = "0x180D7D3C0")]
		private void _SetPluginParent(Transform pluginObj, HudPluginMask mask)
		{
		}

		// Token: 0x060150D7 RID: 86231 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60150D7")]
		[Address(RVA = "0xD7C7C0", Offset = "0xD7B3C0", VA = "0x180D7C7C0")]
		private void _AllocateHudPlugin(Unit owner, string pluginName)
		{
		}

		// Token: 0x060150D8 RID: 86232 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60150D8")]
		[Address(RVA = "0xD7B820", Offset = "0xD7A420", VA = "0x180D7B820")]
		public void OnAttachPlugin(Transform plugin)
		{
		}

		// Token: 0x060150D9 RID: 86233 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60150D9")]
		[Address(RVA = "0xD7B760", Offset = "0xD7A360", VA = "0x180D7B760", Slot = "4")]
		public void OnAllocate()
		{
		}

		// Token: 0x060150DA RID: 86234 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60150DA")]
		[Address(RVA = "0xD7B9C0", Offset = "0xD7A5C0", VA = "0x180D7B9C0", Slot = "5")]
		public void OnRecycle()
		{
		}

		// Token: 0x060150DB RID: 86235 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60150DB")]
		[Address(RVA = "0xD7CD70", Offset = "0xD7B970", VA = "0x180D7CD70")]
		private void _OnAppearOrDisappear(object arg)
		{
		}

		// Token: 0x060150DC RID: 86236 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60150DC")]
		[Address(RVA = "0xD7B660", Offset = "0xD7A260", VA = "0x180D7B660")]
		private void Awake()
		{
		}

		// Token: 0x060150DD RID: 86237 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60150DD")]
		[Address(RVA = "0xD7C030", Offset = "0xD7AC30", VA = "0x180D7C030")]
		protected void Update()
		{
		}

		// Token: 0x060150DE RID: 86238 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60150DE")]
		[Address(RVA = "0xD7DB30", Offset = "0xD7C730", VA = "0x180D7DB30")]
		private void _UpdateSliderGroup(Transform group, List<Transform> trans)
		{
		}

		// Token: 0x060150DF RID: 86239 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60150DF")]
		[Address(RVA = "0xD7D4D0", Offset = "0xD7C0D0", VA = "0x180D7D4D0")]
		private void _ShowDamageText(object arg)
		{
		}

		// Token: 0x060150E0 RID: 86240 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60150E0")]
		[Address(RVA = "0xD7CE30", Offset = "0xD7BA30", VA = "0x180D7CE30")]
		private void _OnAppliedModifier(object arg)
		{
		}

		// Token: 0x060150E1 RID: 86241 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60150E1")]
		[Address(RVA = "0xD7D6C0", Offset = "0xD7C2C0", VA = "0x180D7D6C0")]
		private void _ShowDebugLog(object arg)
		{
		}

		// Token: 0x060150E2 RID: 86242 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60150E2")]
		[Address(RVA = "0xD7D8E0", Offset = "0xD7C4E0", VA = "0x180D7D8E0")]
		private void _ShowMessage(object arg)
		{
		}

		// Token: 0x060150E3 RID: 86243 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60150E3")]
		[Address(RVA = "0xD7DD40", Offset = "0xD7C940", VA = "0x180D7DD40")]
		public UIUnitHUD()
		{
		}

		// Token: 0x040190E4 RID: 102628
		[Token(Token = "0x40190E4")]
		private const int UPDATE_FRAME_TICK = 2;

		// Token: 0x040190E5 RID: 102629
		[Token(Token = "0x40190E5")]
		[FieldOffset(Offset = "0x0")]
		private static uint s_globalCounter;

		// Token: 0x040190E6 RID: 102630
		[Token(Token = "0x40190E6")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private UIFollower _follower;

		// Token: 0x040190E7 RID: 102631
		[Token(Token = "0x40190E7")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Transform _popupTransform;

		// Token: 0x040190E8 RID: 102632
		[Token(Token = "0x40190E8")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Transform _pluginTransform;

		// Token: 0x040190E9 RID: 102633
		[Token(Token = "0x40190E9")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Transform _pluginRoot;

		// Token: 0x040190EA RID: 102634
		[Token(Token = "0x40190EA")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Transform _sliderGroupA;

		// Token: 0x040190EB RID: 102635
		[Token(Token = "0x40190EB")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Transform _sliderGroupB;

		// Token: 0x040190EC RID: 102636
		[Token(Token = "0x40190EC")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private Transform _normalPluginRoot;

		// Token: 0x040190ED RID: 102637
		[Token(Token = "0x40190ED")]
		[FieldOffset(Offset = "0x50")]
		private ObjectPtr<Unit> m_owner;

		// Token: 0x040190EE RID: 102638
		[Token(Token = "0x40190EE")]
		[FieldOffset(Offset = "0x60")]
		private UIUnitHudPluginHolder m_holder;

		// Token: 0x040190EF RID: 102639
		[Token(Token = "0x40190EF")]
		[FieldOffset(Offset = "0x68")]
		private List<string> m_pluginTypesNeedAllocate;

		// Token: 0x040190F0 RID: 102640
		[Token(Token = "0x40190F0")]
		[FieldOffset(Offset = "0x70")]
		private List<UIUnitHUD.HudPluginObj> m_plugins;

		// Token: 0x040190F1 RID: 102641
		[Token(Token = "0x40190F1")]
		[FieldOffset(Offset = "0x78")]
		private Transform m_sliderBG;

		// Token: 0x040190F2 RID: 102642
		[Token(Token = "0x40190F2")]
		[FieldOffset(Offset = "0x80")]
		private List<Transform> m_sliderGroupATrans;

		// Token: 0x040190F3 RID: 102643
		[Token(Token = "0x40190F3")]
		[FieldOffset(Offset = "0x88")]
		private List<Transform> m_sliderGroupBTrans;

		// Token: 0x040190F4 RID: 102644
		[Token(Token = "0x40190F4")]
		[FieldOffset(Offset = "0x90")]
		private PeriodicTicker m_updateFrameTicker;

		// Token: 0x040190F7 RID: 102647
		[Token(Token = "0x40190F7")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_instanceUid;

		// Token: 0x040190F8 RID: 102648
		[Token(Token = "0x40190F8")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_set_instanceUid;

		// Token: 0x040190F9 RID: 102649
		[Token(Token = "0x40190F9")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_get_isAttached;

		// Token: 0x040190FA RID: 102650
		[Token(Token = "0x40190FA")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_set_isAttached;

		// Token: 0x040190FB RID: 102651
		[Token(Token = "0x40190FB")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_Attach;

		// Token: 0x040190FC RID: 102652
		[Token(Token = "0x40190FC")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__SetPluginParent;

		// Token: 0x040190FD RID: 102653
		[Token(Token = "0x40190FD")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__AllocateHudPlugin;

		// Token: 0x040190FE RID: 102654
		[Token(Token = "0x40190FE")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_OnAttachPlugin;

		// Token: 0x040190FF RID: 102655
		[Token(Token = "0x40190FF")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_OnAllocate;

		// Token: 0x04019100 RID: 102656
		[Token(Token = "0x4019100")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_OnRecycle;

		// Token: 0x04019101 RID: 102657
		[Token(Token = "0x4019101")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0__OnAppearOrDisappear;

		// Token: 0x04019102 RID: 102658
		[Token(Token = "0x4019102")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0_Awake;

		// Token: 0x04019103 RID: 102659
		[Token(Token = "0x4019103")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0_Update;

		// Token: 0x04019104 RID: 102660
		[Token(Token = "0x4019104")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0__UpdateSliderGroup;

		// Token: 0x04019105 RID: 102661
		[Token(Token = "0x4019105")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0__ShowDamageText;

		// Token: 0x04019106 RID: 102662
		[Token(Token = "0x4019106")]
		[FieldOffset(Offset = "0x80")]
		private static DelegateBridge __Hotfix0__OnAppliedModifier;

		// Token: 0x04019107 RID: 102663
		[Token(Token = "0x4019107")]
		[FieldOffset(Offset = "0x88")]
		private static DelegateBridge __Hotfix0__ShowDebugLog;

		// Token: 0x04019108 RID: 102664
		[Token(Token = "0x4019108")]
		[FieldOffset(Offset = "0x90")]
		private static DelegateBridge __Hotfix0__ShowMessage;

		// Token: 0x04019109 RID: 102665
		[Token(Token = "0x4019109")]
		[FieldOffset(Offset = "0x98")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02003394 RID: 13204
		[Token(Token = "0x2003394")]
		private struct HudPluginObj
		{
			// Token: 0x060150E4 RID: 86244 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60150E4")]
			[Address(RVA = "0xD6AD60", Offset = "0xD69960", VA = "0x180D6AD60")]
			public HudPluginObj(HudPlugin _plugin, Transform _obj)
			{
			}

			// Token: 0x0401910A RID: 102666
			[Token(Token = "0x401910A")]
			[FieldOffset(Offset = "0x0")]
			public HudPlugin plugin;

			// Token: 0x0401910B RID: 102667
			[Token(Token = "0x401910B")]
			[FieldOffset(Offset = "0x8")]
			public Transform obj;
		}
	}
}

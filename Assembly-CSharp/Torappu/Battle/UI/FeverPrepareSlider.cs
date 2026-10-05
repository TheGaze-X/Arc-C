using System;
using Il2CppDummyDll;
using Torappu.UI;
using UnityEngine;
using XLua;

namespace Torappu.Battle.UI
{
	// Token: 0x02003291 RID: 12945
	[Token(Token = "0x2003291")]
	public class FeverPrepareSlider : UnitHudPluginManager.HudPlugin, HudPlugin, IHotfixable
	{
		// Token: 0x170030A3 RID: 12451
		// (get) Token: 0x060148CB RID: 84171 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170030A3")]
		private FeverSystemManager feverManager
		{
			[Token(Token = "0x60148CB")]
			[Address(RVA = "0xCCE2C0", Offset = "0xCCCEC0", VA = "0x180CCE2C0")]
			get
			{
				return null;
			}
		}

		// Token: 0x170030A4 RID: 12452
		// (get) Token: 0x060148CC RID: 84172 RVA: 0x000876C0 File Offset: 0x000858C0
		[Token(Token = "0x170030A4")]
		public HudPluginMask hudMask
		{
			[Token(Token = "0x60148CC")]
			[Address(RVA = "0xCCE3D0", Offset = "0xCCCFD0", VA = "0x180CCE3D0", Slot = "11")]
			get
			{
				return HudPluginMask.NONE;
			}
		}

		// Token: 0x170030A5 RID: 12453
		// (get) Token: 0x060148CD RID: 84173 RVA: 0x000876D8 File Offset: 0x000858D8
		[Token(Token = "0x170030A5")]
		public bool needToShow
		{
			[Token(Token = "0x60148CD")]
			[Address(RVA = "0xCCE430", Offset = "0xCCD030", VA = "0x180CCE430", Slot = "12")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x060148CE RID: 84174 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60148CE")]
		[Address(RVA = "0xCCDDE0", Offset = "0xCCC9E0", VA = "0x180CCDDE0", Slot = "13")]
		public void OnAttach(Unit owner)
		{
		}

		// Token: 0x060148CF RID: 84175 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60148CF")]
		[Address(RVA = "0xCCDF10", Offset = "0xCCCB10", VA = "0x180CCDF10", Slot = "14")]
		public void OnDetach()
		{
		}

		// Token: 0x060148D0 RID: 84176 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60148D0")]
		[Address(RVA = "0xCCDBD0", Offset = "0xCCC7D0", VA = "0x180CCDBD0", Slot = "9")]
		protected override void DoAttach(Unit owner)
		{
		}

		// Token: 0x060148D1 RID: 84177 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60148D1")]
		[Address(RVA = "0xCCDD40", Offset = "0xCCC940", VA = "0x180CCDD40", Slot = "10")]
		protected override void DoDetach()
		{
		}

		// Token: 0x060148D2 RID: 84178 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60148D2")]
		[Address(RVA = "0xCCDF90", Offset = "0xCCCB90", VA = "0x180CCDF90", Slot = "15")]
		public void UpdatePlugin()
		{
		}

		// Token: 0x060148D3 RID: 84179 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60148D3")]
		[Address(RVA = "0xCCDFF0", Offset = "0xCCCBF0", VA = "0x180CCDFF0")]
		public void Update()
		{
		}

		// Token: 0x060148D4 RID: 84180 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60148D4")]
		[Address(RVA = "0xCCE230", Offset = "0xCCCE30", VA = "0x180CCE230")]
		public FeverPrepareSlider()
		{
		}

		// Token: 0x060148D5 RID: 84181 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60148D5")]
		[Address(RVA = "0xCCDF70", Offset = "0xCCCB70", VA = "0x180CCDF70")]
		private void <>xLuaBaseProxy_DoAttach(Unit P0)
		{
		}

		// Token: 0x060148D6 RID: 84182 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60148D6")]
		[Address(RVA = "0xCCDF80", Offset = "0xCCCB80", VA = "0x180CCDF80")]
		private void <>xLuaBaseProxy_DoDetach()
		{
		}

		// Token: 0x040184D7 RID: 99543
		[Token(Token = "0x40184D7")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private UITextSlider _prepareSlider;

		// Token: 0x040184D8 RID: 99544
		[Token(Token = "0x40184D8")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Transform _prepareSliderRoot;

		// Token: 0x040184D9 RID: 99545
		[Token(Token = "0x40184D9")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Transform _prepareFullHintRoot;

		// Token: 0x040184DA RID: 99546
		[Token(Token = "0x40184DA")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private string _feverKey;

		// Token: 0x040184DB RID: 99547
		[Token(Token = "0x40184DB")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private string _characterGroupTag;

		// Token: 0x040184DC RID: 99548
		[Token(Token = "0x40184DC")]
		[FieldOffset(Offset = "0x50")]
		private float m_colletedRatio;

		// Token: 0x040184DD RID: 99549
		[Token(Token = "0x40184DD")]
		[FieldOffset(Offset = "0x54")]
		private bool m_isCharacterValid;

		// Token: 0x040184DE RID: 99550
		[Token(Token = "0x40184DE")]
		[FieldOffset(Offset = "0x58")]
		private FeverSystemManager m_feverSystemManager;

		// Token: 0x040184DF RID: 99551
		[Token(Token = "0x40184DF")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_feverManager;

		// Token: 0x040184E0 RID: 99552
		[Token(Token = "0x40184E0")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_hudMask;

		// Token: 0x040184E1 RID: 99553
		[Token(Token = "0x40184E1")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_needToShow;

		// Token: 0x040184E2 RID: 99554
		[Token(Token = "0x40184E2")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnAttach;

		// Token: 0x040184E3 RID: 99555
		[Token(Token = "0x40184E3")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_OnDetach;

		// Token: 0x040184E4 RID: 99556
		[Token(Token = "0x40184E4")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_DoAttach;

		// Token: 0x040184E5 RID: 99557
		[Token(Token = "0x40184E5")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_DoDetach;

		// Token: 0x040184E6 RID: 99558
		[Token(Token = "0x40184E6")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_UpdatePlugin;

		// Token: 0x040184E7 RID: 99559
		[Token(Token = "0x40184E7")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_Update;

		// Token: 0x040184E8 RID: 99560
		[Token(Token = "0x40184E8")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}

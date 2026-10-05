using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Battle.UI
{
	// Token: 0x02003366 RID: 13158
	[Token(Token = "0x2003366")]
	public class UIHudTrapCostPanel : MonoBehaviour, HudPlugin, IHotfixable
	{
		// Token: 0x170031E2 RID: 12770
		// (get) Token: 0x06014FFA RID: 86010 RVA: 0x0008A090 File Offset: 0x00088290
		[Token(Token = "0x170031E2")]
		public HudPluginMask hudMask
		{
			[Token(Token = "0x6014FFA")]
			[Address(RVA = "0xD766A0", Offset = "0xD752A0", VA = "0x180D766A0", Slot = "4")]
			get
			{
				return HudPluginMask.NONE;
			}
		}

		// Token: 0x170031E3 RID: 12771
		// (get) Token: 0x06014FFB RID: 86011 RVA: 0x0008A0A8 File Offset: 0x000882A8
		[Token(Token = "0x170031E3")]
		public bool needToShow
		{
			[Token(Token = "0x6014FFB")]
			[Address(RVA = "0xD76700", Offset = "0xD75300", VA = "0x180D76700", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06014FFC RID: 86012 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014FFC")]
		[Address(RVA = "0xD76180", Offset = "0xD74D80", VA = "0x180D76180", Slot = "6")]
		public void OnAttach(Unit owner)
		{
		}

		// Token: 0x06014FFD RID: 86013 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014FFD")]
		[Address(RVA = "0xD76430", Offset = "0xD75030", VA = "0x180D76430", Slot = "7")]
		public void OnDetach()
		{
		}

		// Token: 0x06014FFE RID: 86014 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014FFE")]
		[Address(RVA = "0xD76490", Offset = "0xD75090", VA = "0x180D76490", Slot = "8")]
		public void UpdatePlugin()
		{
		}

		// Token: 0x06014FFF RID: 86015 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014FFF")]
		[Address(RVA = "0xD76640", Offset = "0xD75240", VA = "0x180D76640")]
		public UIHudTrapCostPanel()
		{
		}

		// Token: 0x04018FA9 RID: 102313
		[Token(Token = "0x4018FA9")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Text _costLabel;

		// Token: 0x04018FAA RID: 102314
		[Token(Token = "0x4018FAA")]
		[FieldOffset(Offset = "0x20")]
		private Trap m_trap;

		// Token: 0x04018FAB RID: 102315
		[Token(Token = "0x4018FAB")]
		[FieldOffset(Offset = "0x28")]
		private CastSkillWithCost m_castSkillWithCost;

		// Token: 0x04018FAC RID: 102316
		[Token(Token = "0x4018FAC")]
		[FieldOffset(Offset = "0x30")]
		private CastSkillForTrapGarage m_castSkillForTrapGarage;

		// Token: 0x04018FAD RID: 102317
		[Token(Token = "0x4018FAD")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_hudMask;

		// Token: 0x04018FAE RID: 102318
		[Token(Token = "0x4018FAE")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_needToShow;

		// Token: 0x04018FAF RID: 102319
		[Token(Token = "0x4018FAF")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnAttach;

		// Token: 0x04018FB0 RID: 102320
		[Token(Token = "0x4018FB0")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnDetach;

		// Token: 0x04018FB1 RID: 102321
		[Token(Token = "0x4018FB1")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_UpdatePlugin;

		// Token: 0x04018FB2 RID: 102322
		[Token(Token = "0x4018FB2")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}

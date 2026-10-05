using System;
using Il2CppDummyDll;
using Torappu.UI;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Battle
{
	// Token: 0x020024BC RID: 9404
	[Token(Token = "0x20024BC")]
	public class UISandboxResHUDPlugin : UIPluginTalent.UnitTalentUIPlugin
	{
		// Token: 0x0600F1F0 RID: 61936 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F1F0")]
		[Address(RVA = "0x699310", Offset = "0x697F10", VA = "0x180699310", Slot = "9")]
		protected override void DoAttach(Unit owner, UIPluginTalent talent)
		{
		}

		// Token: 0x0600F1F1 RID: 61937 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F1F1")]
		[Address(RVA = "0x699880", Offset = "0x698480", VA = "0x180699880")]
		private void _SetChildrenActive(bool isActive)
		{
		}

		// Token: 0x0600F1F2 RID: 61938 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F1F2")]
		[Address(RVA = "0x699610", Offset = "0x698210", VA = "0x180699610")]
		private void Update()
		{
		}

		// Token: 0x0600F1F3 RID: 61939 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F1F3")]
		[Address(RVA = "0x699950", Offset = "0x698550", VA = "0x180699950")]
		public UISandboxResHUDPlugin()
		{
		}

		// Token: 0x0600F1F4 RID: 61940 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F1F4")]
		[Address(RVA = "0x683020", Offset = "0x681C20", VA = "0x180683020")]
		private void <>xLuaBaseProxy_DoAttach(Unit P0, UIPluginTalent P1)
		{
		}

		// Token: 0x04010BD1 RID: 68561
		[Token(Token = "0x4010BD1")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private UIAtlasImage _resIcon;

		// Token: 0x04010BD2 RID: 68562
		[Token(Token = "0x4010BD2")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Text _resCount;

		// Token: 0x04010BD3 RID: 68563
		[Token(Token = "0x4010BD3")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private UIAtlasImage _resBackground;

		// Token: 0x04010BD4 RID: 68564
		[Token(Token = "0x4010BD4")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private UIAtlasObject _battleAtlas;

		// Token: 0x04010BD5 RID: 68565
		[Token(Token = "0x4010BD5")]
		[FieldOffset(Offset = "0x50")]
		private bool m_isValid;

		// Token: 0x04010BD6 RID: 68566
		[Token(Token = "0x4010BD6")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_DoAttach;

		// Token: 0x04010BD7 RID: 68567
		[Token(Token = "0x4010BD7")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__SetChildrenActive;

		// Token: 0x04010BD8 RID: 68568
		[Token(Token = "0x4010BD8")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_Update;

		// Token: 0x04010BD9 RID: 68569
		[Token(Token = "0x4010BD9")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
